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
        
    }
}
