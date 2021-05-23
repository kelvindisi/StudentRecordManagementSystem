using DataAccess.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EnrollmentManager: DbConnector
    {
        public static void enroll(EnrollmentModel detail)
        {
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                validateRegNo(detail.RegistrationNo);
                saveEnrollment(detail);
            }
        }

        private static void saveEnrollment(EnrollmentModel detail)
        {
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = "INSERT INTO `enrollment`(`student_id`, `course_id`, "
                    + "`regNo`, `enrollment_year`) VALUES "
                    + "(@bioId,@courseId,@regNo,@year)";
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("bioId", detail.Student.ID);
                cmd.Parameters.AddWithValue("courseId", detail.Course.ID);
                cmd.Parameters.AddWithValue("regNo", detail.RegistrationNo);
                cmd.Parameters.AddWithValue("year", getYear(detail.RegistrationNo));
                cmd.ExecuteNonQuery();
            }
        }

        private static int getYear(string registrationNo)
        {
            DateTime current = DateTime.Now;
            int year = current.Year;
            return year;
        }

        private static void validateRegNo(string registrationNo)
        {
            EnrollmentModel enroll = getEnrollmentByRegNo(registrationNo);
            if (enroll.ID != 0)
                throw new Exception("Reg No already exists.");
        }

        private static EnrollmentModel getEnrollmentByRegNo(string registrationNo)
        {
            EnrollmentModel enrollment = new EnrollmentModel();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM enrollment WHERE regNo=@regNo";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("regNo", registrationNo);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    enrollment.ID = rd.GetInt32("id");
                    enrollment.RegistrationNo = rd.GetString("regNo");
                    int bioDataId = rd.GetInt32("student_id");
                    int courseId = rd.GetInt32("course_id");
                    enrollment.Student = StudentManager.getBioById(bioDataId);
                    enrollment.Course = CourseManager.getCourseById(courseId);
                }
            }
            return enrollment;
        }
    }
}
