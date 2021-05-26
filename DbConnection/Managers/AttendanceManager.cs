using System;
using DataAccess.Models;
using MySql.Data.MySqlClient;

namespace DataAccess.Managers
{
    public class AttendanceManager:DbConnector
    {
        public static ClassSessionModel getTodaySession(int unit_sess)
        {
            ClassSessionModel sess = new ClassSessionModel();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = "SELECT * FROM `class_session` WHERE "
                    + "`session_unit_id`=@sess AND "
                    + "`date_recorded`=CURRENT_DATE";
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("sess", unit_sess);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows && rd.Read())
                {
                    sess.ID = rd.GetInt32("id");
                    sess.SessionUnit = rd.GetInt32("session_unit_id");
                    sess.SessionDate = rd.GetDateTime("date_recorded");
                }

            }

            return sess;
        }
        public static ClassSessionModel createTodaySession(int sess_unit)
        {
            ClassSessionModel sess = new ClassSessionModel();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = "INSERT INTO `class_session`(`session_unit_id`) "
                    + "VALUES (@sess)";
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("sess", sess_unit);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    sess = getTodaySession(sess_unit);
            }
            return sess;
        }
        public static bool hasAttendedTodaySession(int session, int regId)
        {
            bool attended = false;
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = "SELECT * FROM `attendance` WHERE "
                    + "`registration_id`=@regId AND "
                    + "class_session_id=@session AND "
                    + "`attendance_date`=CURRENT_DATE";
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("regId", regId);
                cmd.Parameters.AddWithValue("session", session);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                    attended = true;
            }

            return attended;
        }
        public static bool saveAttendance(int session, int regId)
        {
            bool saved = false;
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = "INSERT INTO `attendance`(`class_session_id`, "
                    + "`registration_id`, `attendance_date`) "
                    + "VALUES (@session, @regId, CURRENT_DATE)";
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("session", session);
                cmd.Parameters.AddWithValue("regId", regId);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                    saved = true;
            }
            return saved;
        }
        public static int ClassSessionCount(int regUnitId)
        {
            int count = 0;
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = QueryStrings.SessionCounter;
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("regId", regUnitId);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    count = rd.GetInt32("count");
            }
            return count;
        }
        private static int AttendedSessionCount(int regUnitId)
        {
            int count = 0;
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = QueryStrings.AttendedCounter;
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("regId", regUnitId);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    count = rd.GetInt32("count");
            }
            return count;
        }
        public static StudentAttendanceScore getAttendanceScore(int regUnitId)
        {
            StudentAttendanceScore score = new StudentAttendanceScore();
            score.NoOfSessions = ClassSessionCount(regUnitId);
            score.Attended = AttendedSessionCount(regUnitId);
            return score;
        }

        public static StudentScoreModel getStudentScore(int regUnitId)
        {
            StudentScoreModel card = new StudentScoreModel();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string q = QueryStrings.studentRecordCard;
                cmd = new MySqlCommand(q, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("regId", regUnitId);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    card.RegNo = rd.GetString("regNo");
                    card.FirstName = rd.GetString("first_name");
                    card.Surname = rd.GetString("surname");
                    card.Email = rd.GetString("email");
                    card.UnitCode = rd.GetString("unit_code");
                    card.UnitName = rd.GetString("unit_name");
                    card.Semester = rd.GetInt32("semester");
                    card.Year = rd.GetInt32("year");
                    card.Score = rd.GetInt32("score");
                    card.OutOf = rd.GetInt32("outof");
                }
            }
            return card;
        }

        public static StudentScoreAttendanceModel fullInfo(int regUnitId)
        {
            StudentScoreAttendanceModel compiled = new StudentScoreAttendanceModel();
            compiled.info = getStudentScore(regUnitId);
            compiled.attendance = getAttendanceScore(regUnitId);
            return compiled;
        }
        public static void saveScore(int regUnitId, float score, float outof)
        {
            deleteRecordIfExists(regUnitId);
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                cmd = new MySqlCommand(QueryStrings.saveScore, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("regId", regUnitId);
                cmd.Parameters.AddWithValue("score", score);
                cmd.Parameters.AddWithValue("outof", outof);
                cmd.ExecuteNonQuery();
            }
        }

        private static void deleteRecordIfExists(int regId)
        {
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                cmd = new MySqlCommand(QueryStrings.deleteScore, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("regId", regId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
