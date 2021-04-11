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

        public static CourseModel getCourseById(int courseId)
        {
            CourseModel course = new CourseModel();

            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM courses WHERE id=@courseId";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("courseId", courseId);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (!rd.HasRows)
                    throw new CourseDoesNotExistException(courseId);
                if (rd.Read())
                {
                    course.ID = rd.GetInt32("id");
                    course.CourseCode = rd.GetString("course_code");
                    course.CourseName = rd.GetString("course_name");
                    course.Duration = rd.GetInt32("semesters");
                    course.Department = DepartmentManager.getDepartmentById(rd.GetInt32("department_id"));
                }
            }

            return course;
        }

        public static CourseModel getCourseByCode(string courseCode)
        {
            CourseModel course = new CourseModel();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM courses where course_code=@courseCode";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("courseCode", courseCode);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    course.ID = rd.GetInt32("id");
                    course.CourseName = rd.GetString("course_name");
                    course.CourseCode = rd.GetString("course_code");
                    course.Department = DepartmentManager.getDepartmentById(rd.GetInt32("department_id"));
                    course.Duration = rd.GetInt32("semesters");
                }
            }
            return course;
        }
        public static void checkIfCourseExists(string newCode, int courseId)
        {
            CourseModel course = CourseManager.getCourseByCode(newCode);
            if (course.ID != 0)
            {
                if (course.ID != courseId)
                    throw new CourseAlreadyExistsException(newCode);
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
        public static bool updateCourseDetails(CourseModel course)
        {
            bool updated = false;

            checkIfCourseExists(course.CourseCode, course.ID);
            using(conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "UPDATE courses SET course_name=@courseName, course_code=@courseCode, "
                    + "semesters=@semesters, department_id=@departmentId WHERE id=@id";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("courseName", course.CourseName);
                cmd.Parameters.AddWithValue("courseCode", course.CourseCode);
                cmd.Parameters.AddWithValue("semesters", course.Duration);
                cmd.Parameters.AddWithValue("departmentId", course.Department.DepartmentId);
                cmd.Parameters.AddWithValue("id", course.ID);

                if (cmd.ExecuteNonQuery() > 0)
                    updated = true;

            }

            return updated;
        }
    }
}
