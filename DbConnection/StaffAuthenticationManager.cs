using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using MySql.Data.MySqlClient;
using DataAccess.Exceptions;

namespace DataAccess
{
    public class StaffAuthenticationManager: DbConnector
    {
        public static StaffAuthModel loginStaff(string email, string password)
        {
            StaffAuthModel staff = new StaffAuthModel();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM staffs WHERE email=@email AND password=@password";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("password", password);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (!rd.HasRows)
                    throw new WrongUsernamePasswordException();
                rd.Read();
                staff.ID = (int)rd.GetInt32("id");
                staff.Username = rd.GetString("email");
                staff.Roles = getStaffRoles(staff.ID);
                staff.FirstName = rd.GetString("first_name");
                staff.Surname = rd.GetString("surname");
            }

            return staff;
        }

        private static List<RoleModel> getStaffRoles(int id)
        {
            RoleModel[] rolesArr = StaffManager.getStaffRoles(id);

            return rolesArr.ToList();

        }
    }
}
