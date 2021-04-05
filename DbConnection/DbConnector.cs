using MySql.Data.MySqlClient;
using System.Configuration;

namespace DataAccess
{
    public class DbConnector
    {
        public static MySqlConnection conn;
        protected static MySqlCommand cmd;
        protected static string getConnectionString()
        {
            string connStr = ConfigurationManager.ConnectionStrings["students"].ToString();
            return connStr;
        }
    }
}
