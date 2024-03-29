﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DataAccess
{
    public class SessionUnitManager: DbConnector
    {
        public static List<SessionUnitModel> getActiveSessionUnits(int courseId, int sessionId)
        {
            List<SessionUnitModel> units = new List<SessionUnitModel>();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = "SELECT `session_units`.`id`, `courses`.`id` as `course_id`,"
                    + "`units`.`id` as `unit_id`, "
                    + "COALESCE(`staffs`.`id`, 0) as `staff_id`"
                    + "FROM `session_units` JOIN `units` ON "
                    + "`units`.`id`=`session_units`.`unit_id` "
                    + "JOIN `courses` ON `courses`.`id`=`units`.`course_id` "
                    + "LEFT JOIN `staffs` ON `session_units`.`lecturer_id`=`staffs`.`id`"
                    + "WHERE `session_id`=@sessionId AND `courses`.`id`=@courseId";
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("sessionId", sessionId);
                cmd.Parameters.AddWithValue("courseId", courseId);

                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    SessionUnitModel unit = new SessionUnitModel();
                    unit.ID = rd.GetInt32("id");
                    unit.Active = true;
                    unit.Course = CourseManager.getCourseById(rd.GetInt32("course_id"));
                    unit.Unit = UnitManager.getUnitById(rd.GetInt32("unit_id"));
                    unit.Lecturer = getAssignedLecture(rd.GetInt32("staff_id"));
                    units.Add(unit);
                }
            }

            return units;
        }

        private static StaffPrimaryModel getAssignedLecture(int v)
        {
            return StaffManager.getById(v);
        }
        public static List<SessionUnitModel> getSessionUnits(int courseId, int sessId)
        {
            List<UnitModel> units = UnitManager.getCourseUnitsByCourseId(courseId);
            List<SessionUnitModel> active = getActiveSessionUnits(courseId, sessId);
            var activeUnitIds = getActiveUnitIds(active);

            IEnumerable<UnitModel> inactive = 
                units.Where(unit => !activeUnitIds.Contains(unit.ID));
            List<SessionUnitModel> inactiveSessUnit = 
                convertInactiveToSessUnit(inactive);
            active = active.Concat(inactiveSessUnit)
                .ToList();
            return active;
        }

        public static SessionUnitModel addSessionUnit(int sess, int unit)
        {
            SessionUnitModel sessUnit = new SessionUnitModel();
            
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = "INSERT INTO `session_units`(`session_id`, `unit_id`) "
                    + "VALUES (@sessionId, @unitId); "
                    + "SELECT last_insert_id();";
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("sessionId", sess);
                cmd.Parameters.AddWithValue("unitId", unit);
                int insertedId = Convert.ToInt32(cmd.ExecuteScalar());
                if (insertedId != 0)
                    sessUnit = getSessionModelById(insertedId);
            }

            return sessUnit;
        }

        public static SessionUnitModel getSessionModelById(int insertedId)
        {
            SessionUnitModel sessUnit = new SessionUnitModel();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = "SELECT `id`, `session_id`, `unit_id`, "
                    + "COALESCE(`lecturer_id`,0) as lecturer_id "
                    + "FROM `session_units` WHERE id=@ID";
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("ID", insertedId);
                MySqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    rd.Read();
                    sessUnit.ID = rd.GetInt32("id");
                    sessUnit.Active = true;
                    int unit_id = rd.GetInt32("unit_id");
                    int lec_id = rd.GetInt32("lecturer_id");
                    sessUnit.Lecturer = StaffManager.getById(lec_id);
                    sessUnit.Unit = UnitManager.getUnitById(unit_id);
                }
            }

            return sessUnit;
        }

        public static int getTotalSessionCount(int selected_sess_unit)
        {
            int count = 0;
            string q = "SELECT COUNT(*) AS count FROM `class_session` WHERE session_unit_id=@sess;";
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("sess", selected_sess_unit);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    count = rd.GetInt32("count");
                }
            }

            return count;
        }

        public static bool removeSessionUnit(int sessUnitId)
        {
            bool removed = false;
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = "DELETE FROM `session_units` WHERE id=@ID";
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("ID", sessUnitId);
                int count = cmd.ExecuteNonQuery();

                if (count > 0)
                    removed = true;
            }
            return removed;
        }

        private static List<SessionUnitModel> convertInactiveToSessUnit(IEnumerable<UnitModel> inactiveUnits)
        {
            List<SessionUnitModel> units = new List<SessionUnitModel>();
            foreach (UnitModel unit in inactiveUnits)
            {
                SessionUnitModel inactive = new SessionUnitModel();
                inactive.Course = unit.Course;
                inactive.Unit = unit;
                inactive.Lecturer = StaffManager.getById(0);
                inactive.Active = false;
                units.Add(inactive);
            }
            return units;
        }

        public static void addSessUnitLecturer(int id, int lec_id)
        {
            removeAssignedLecturer(id);

            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();

                string q = "UPDATE `session_units` SET "
                    + "`lecturer_id`=@lec_id WHERE id=@ID";

                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("lec_id", lec_id);
                cmd.Parameters.AddWithValue("ID", id);

                cmd.ExecuteNonQuery();
            }
        }

        private static void removeAssignedLecturer(int id)
        {
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = "UPDATE `session_units` SET `lecturer_id`=NULL WHERE id=@ID";
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("ID", id);
                cmd.ExecuteNonQuery();
            }
        }

        private static List<int> getActiveUnitIds(List<SessionUnitModel> active)
        {
            List<int> activeUnitIds = new List<int>();
            foreach (SessionUnitModel unit in active)
            {
                activeUnitIds.Add(unit.Unit.ID);
            }

            return activeUnitIds;
        }
        public static DataTable getSessionCourseUnits
            (int session, int courseId, string find)
        {
            DataTable table = new DataTable();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = "SELECT session_units.id, units.id as unit_id, "
                   + "unit_code, unit_name, "
                   + "'Enroll' as msg FROM session_units "
                   + "JOIN units ON session_units.unit_id = units.id "
                   + "WHERE session_units.session_id = @sessId "
                   + "AND units.course_id = @courseId AND "
                   + "(units.unit_code LIKE @find OR "
                   + "units.unit_name LIKE @find);";
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("sessId", session);
                cmd.Parameters.AddWithValue("courseId", courseId);
                cmd.Parameters.AddWithValue("find", $"%{find}%");

                MySqlDataAdapter dapt = new MySqlDataAdapter(cmd);
                dapt.Fill(table);
            }

            return table;
        }
        public static List<int> registeredUnitsId(int sess, int course, int stud)
        {
            List<int> registered = new List<int>();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = "SELECT session_units.unit_id FROM registered_units "
                    + "JOIN session_units ON session_units.id = "
                    + "registered_units.session_unit_id "
                    + "JOIN units ON units.id = session_units.unit_id "
                    + "WHERE units.course_id = @course AND "
                    + "session_units.session_id = @sess AND "
                    + "registered_units.student_id = @stud";
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("course", course);
                cmd.Parameters.AddWithValue("sess", sess);
                cmd.Parameters.AddWithValue("stud", stud);
                MySqlDataReader rd = cmd.ExecuteReader();
                while(rd.Read())
                {
                    registered.Add(rd.GetInt32("unit_id"));
                }
            }
            return registered;
        }
        public static void DisenrollSessUnit(int student, int session)
        {
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = "DELETE FROM `registered_units` WHERE "
                    + "`student_id`=@student AND `session_unit_id`=@session";
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("student", student);
                cmd.Parameters.AddWithValue("session", session);

                cmd.ExecuteNonQuery();
            }
        }
        public static bool isEnrolledSessUnit(int student, int session)
        {
            bool exists = false;
            using(conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = "SELECT * FROM `registered_units` WHERE "
                    + "`student_id`=@student AND `session_unit_id`=@session";
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("student", student);
                cmd.Parameters.AddWithValue("session", session);

                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                    exists = true;
            }
            return exists;
        }
        public static void enrollSessUnit(int student, int session)
        {
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = "INSERT INTO `registered_units`(`student_id`, "
                    + "`session_unit_id`) VALUES (@student,@session)";
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("student", student);
                cmd.Parameters.AddWithValue("session", session);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable getLecturerUnits(int lec, int sess, string q)
        {
            DataTable table = new DataTable();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string qr = "SELECT session_units.id, unit_id, unit_code, "
                    + "unit_name, course_name, CEIL(semester / 2) as `year`, "
                    + "semester FROM session_units "
                    + "JOIN units ON session_units.unit_id = units.id "
                    + "JOIN courses ON units.course_id = courses.id "
                    + "WHERE lecturer_id = @lec AND session_id = @sess AND "
                    + "(unit_code LIKE @q OR unit_name LIKE @q OR "
                    + "course_name LIKE @q OR semester LIKE @q)";
                cmd = new MySqlCommand(qr, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("lec", lec);
                cmd.Parameters.AddWithValue("sess", sess);
                cmd.Parameters.AddWithValue("q", $"%{q}%");
                MySqlDataAdapter dapt = new MySqlDataAdapter(cmd);
                dapt.Fill(table);
            }
            return table;
        }
        public static DataTable getSessLecUnits(int lec, int sess, string q)
        {
            DataTable table = new DataTable();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string qr = "SELECT registered_units.id as registered_id, "
                    + "enrollment.id, regNo, first_name, "
                    + "surname, email FROM registered_units "
                    + "JOIN enrollment ON enrollment.id = "
                    + "registered_units.student_id "
                    + "JOIN student_bio ON student_bio.id = "
                    + "enrollment.student_id "
                    + "JOIN session_units ON session_units.id = "
                    + "registered_units.session_unit_id "
                    + "WHERE lecturer_id =@lec AND session_unit_id = @sess AND "
                    + "(regNo LIKE @q OR first_name LIKE @q OR "
                    + "surname LIKE @q OR email LIKE @q)";
                cmd = new MySqlCommand(qr, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("lec", lec);
                cmd.Parameters.AddWithValue("sess", sess);
                cmd.Parameters.AddWithValue("q", $"%{q}%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(table);
            }

            return table;
        }
    }
}
