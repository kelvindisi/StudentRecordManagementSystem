using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
    }
}
