using System;
using System.Collections.Generic;
using DataAccess.Models;
using MySql.Data.MySqlClient;
using DataAccess.Exceptions;

namespace DataAccess
{
    public class UnitManager: DbConnector
    {
        public static List<UnitModel> getCourseUnitsByCourseId(int course_id)
        {
            List<UnitModel> units = new List<UnitModel>();
            CourseModel course = CourseManager.getCourseById(course_id);

            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM units WHERE course_id=@courseId";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("courseId", course_id);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (!rd.HasRows)
                    throw new CourseHasNoUnitsException(course.CourseName);
                while (rd.Read())
                {
                    UnitModel unit = returnUnitModelFromDbResults(rd, course);
                    units.Add(unit);
                }
            }

            return units;
        }
        private static UnitModel returnUnitModelFromDbResults(MySqlDataReader rd, CourseModel course)
        {
            UnitModel unit = new UnitModel();
            unit.ID = rd.GetInt32("id");
            unit.UnitName = rd.GetString("unit_name");
            unit.UnitCode = rd.GetString("unit_code");
            unit.Course = course;
            unit.Semester = rd.GetInt32("semester");
            return unit;
        }

        public static UnitModel getUnitById(int unitId)
        {
            UnitModel unit = new UnitModel();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM units WHERE id=@id";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("id", unitId);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (!rd.HasRows)
                    throw new UnitDoesNotExistException();
                if (rd.Read())
                {
                    unit.ID = rd.GetInt32("id");
                    unit.UnitName = rd.GetString("unit_name");
                    unit.UnitCode = rd.GetString("unit_code");
                    unit.Course = CourseManager.getCourseById(rd.GetInt32("course_id"));
                    unit.Semester = rd.GetInt32("semester");
                }
            }
            return unit;
        }

        public static int saveNewUnit(UnitModel unit)
        {
            int saved = 0;
            using (conn = new MySqlConnection(getConnectionString()))
            {
                checkIfUnitExists(unit.UnitCode, unit.Course);
                
                conn.Open();
                string query = "INSERT INTO `units`(`course_id`, `unit_name`, `unit_code`, `semester`)"
                    + "VALUES (@courseId, @unitName, @unitCode, @semester)";

                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("courseId", unit.Course.ID);
                cmd.Parameters.AddWithValue("unitName", unit.UnitName);
                cmd.Parameters.AddWithValue("unitCode", unit.UnitCode.ToUpper());
                cmd.Parameters.AddWithValue("semester", unit.Semester);

                saved = cmd.ExecuteNonQuery();
            }

            return saved;
        }

        private static void checkIfUnitExists(string unitCode, CourseModel course)
        {
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM units WHERE unit_code=@unitCode AND course_id=@courseId";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("unitCode", unitCode.ToUpper());
                cmd.Parameters.AddWithValue("courseId", course.ID);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                    throw new UnitAlreadyExistsException(unitCode.ToUpper(), course.CourseName);
            }
        }

        private static void checkIfUnitExists(UnitModel unit)
        {
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM units WHERE unit_code=@unitCode AND course_id=@courseId";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("unitCode", unit.UnitCode.ToUpper());
                cmd.Parameters.AddWithValue("courseId", unit.Course.ID);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    int unitId = rd.GetInt32("id");
                    if (unitId != unit.ID)
                        throw new UnitAlreadyExistsException(unit.UnitCode, unit.UnitName);
                }
            }
        }

        public static bool updateUnit(UnitModel unit)
        {
            bool saved = false;

            using (conn = new MySqlConnection(getConnectionString()))
            {
                checkIfUnitExists(unit);
                conn.Open();
                string query = "UPDATE `units` SET `course_id`=@courseId,`unit_name`=@unitName,"
                    + "`unit_code`=@unitCode,`semester`=@semester WHERE id=@ID";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("courseId", unit.Course.ID);
                cmd.Parameters.AddWithValue("unitName", unit.UnitName);
                cmd.Parameters.AddWithValue("unitCode", unit.UnitCode);
                cmd.Parameters.AddWithValue("semester", unit.Semester);
                cmd.Parameters.AddWithValue("ID", unit.ID);

                if (cmd.ExecuteNonQuery() > 0)
                    saved = true;

            }

            return saved;
        }
    }
}
