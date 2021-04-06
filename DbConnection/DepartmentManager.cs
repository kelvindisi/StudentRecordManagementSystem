using DataAccess.Models;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Data;

namespace DataAccess
{
    public class DepartmentManager: DbConnector
    {
        public static bool departmentExists(string departmentName)
        {
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM `departments` WHERE departmentName=@department";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("department", departmentName);
                if (cmd.ExecuteReader().HasRows)
                    return true;
            }
            return false;
        }

        public static bool saveDepartment(DepartmentModel department)
        {
            using (conn = new MySqlConnection(getConnectionString()))
            {
                string query = "INSERT INTO departments (departmentName) VALUES(@departmentName)";
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("departmentName", department.DepartmentName);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            return false;
        }

        public static ArrayList getDepartmentsList()
        {
            ArrayList list = new ArrayList();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT id as ID, departmentName as `DEPARTMENT NAME`  FROM departments", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(new DepartmentModel(reader.GetInt32("id"), reader.GetString("DEPARTMENT NAME")));
                    }
                }
            }
            return list;
        }

        public static DataTable getDepartmentsData()
        {
            DataTable table = new DataTable();

            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT id as ID, departmentName as `DEPARTMENT NAME`  FROM departments", conn);
                MySqlDataAdapter dapt = new MySqlDataAdapter(cmd);
                dapt.Fill(table);

            }

            return table;
        }
        public static DepartmentModel getDepartmentById(int id)
        {
            DepartmentModel department = new DepartmentModel();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM departments WHERE id=@id";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("id", id);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    department.DepartmentId = rd.GetInt32("id");
                    department.DepartmentName = rd.GetString("departmentName");
                } 
            }

            return department;
        }
    }
}
