using DataAccess.Models;
using System;
using System.Collections.Generic;
using DataAccess.Exceptions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DataAccess
{
    class SessionManager: DbConnector
    {
        public static List<SessionModel> getSessions()
        {
            List<SessionModel> sessions = new List<SessionModel>();

            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM sessions";
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    SessionModel session = new SessionModel();
                    session.ID = rd.GetInt32("id");
                    session.Month = rd.GetInt32("month");
                    session.Year = rd.GetInt32("year");

                    sessions.Add(session);
                }
            }
            return sessions;
        }
        public static void updateSession(SessionModel session)
        {
            using(conn = new MySqlConnection(getConnectionString()))
            {
                checkIfSessionExists(session);
                conn.Open();
                string query = "UPDATE sessions SET year=@year, month=@month WHERE id=@ID";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("year", session.Year);
                cmd.Parameters.AddWithValue("month", session.Month);

                cmd.ExecuteNonQuery();
            }
        }

        private static void checkIfSessionExists(SessionModel session)
        {
            using(conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM sessions WHERE year=@year AND month=@month";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("year", session.Year);
                cmd.Parameters.AddWithValue("month", session.Month);

                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    int id = rd.GetInt32("id");
                    if (id != session.ID)
                        throw new SessionAlreadyExistsException(session.Month, session.Year);
                }
            }
        }

        public static void addSession(SessionModel session)
        {
            using (conn = new MySqlConnection(getConnectionString()))
            {
                checkIfSessionExists(session.Month, session.Year);
                conn.Open();
                string query = "INSERT INTO sessions(month, year) VALUES(@month, @year)";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("month", session.Month);
                cmd.Parameters.AddWithValue("year", session.Year);

                cmd.ExecuteNonQuery();
            }
        }

        private static void checkIfSessionExists(int month, int year)
        {
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM sessions WHERE year=@year AND month=@month";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("year", year);
                cmd.Parameters.AddWithValue("month", month);

                if (cmd.ExecuteReader().HasRows)
                    throw new SessionAlreadyExistsException(month, year);
            }
        }
    }
}
