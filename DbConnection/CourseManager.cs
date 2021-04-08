using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Models;
using MySql.Data.MySqlClient;
using DataAccess.Exceptions;

namespace DataAccess
{
    public class CourseManager: DbConnector
    {
        public static bool saveNewCourse(CourseModel course)
        {
            bool saved = false;
            checkIfCourseExists(course.CourseCode);
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "INSERT INTO courses (course_name, course_code, semesters, department_id) "
                    + "VALUES(@courseName, @courseCode, @semesters, @departmentId)";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("courseName", course.CourseName);
                cmd.Parameters.AddWithValue("courseCode", course.CourseCode);
                cmd.Parameters.AddWithValue("semesters", course.Duration);
                cmd.Parameters.AddWithValue("departmentId", course.Department.DepartmentId);

                if (cmd.ExecuteNonQuery() == 1)
                    saved = true;
            }
            return saved;
        }

        public static void checkIfCourseExists(string courseCode)
        {
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM courses WHERE course_code=@courseCode";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("courseCode", courseCode);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                    throw new CourseAlreadyExistsException(courseCode);
            }
        }
        public static List<CourseModel> getCourses()
        {
            List<CourseModel> courses = new List<CourseModel>();

            using(conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM courses", conn);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    CourseModel course = new CourseModel();
                    course.ID = rd.GetInt32("id");
                    course.CourseCode = rd.GetString("course_code");
                    course.CourseName = rd.GetString("course_name");
                    course.Duration = rd.GetInt32("semesters");
                    course.Department = DepartmentManager.getDepartmentById(rd.GetInt32("department_id"));
                    courses.Add(course);
                }
            }

            return courses;
        }
    }
}
