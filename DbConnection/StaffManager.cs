using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DataAccess.Models;
using System.Windows.Forms;

namespace DataAccess
{
    public class StaffManager: DbConnector
    {
        /**
         * Staff Management
         **/

        public static bool staffExists(string email)
        {
            bool exists = false;
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM staffs WHERE email=@email";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("email", email);
                if (cmd.ExecuteReader().HasRows)
                    exists = true;
            }
            return exists;
        }
        private static MySqlCommand mapNewStaffDetails(string query, MySqlConnection conn, StaffModel userInput)
        {
            cmd = new MySqlCommand(query, conn);
            cmd.Prepare();
            cmd.Parameters.AddWithValue("surname", userInput.Surname);
            cmd.Parameters.AddWithValue("first_name", userInput.FirstName);
            cmd.Parameters.AddWithValue("email", userInput.Email);
            cmd.Parameters.AddWithValue("gender", userInput.Gender);
            cmd.Parameters.AddWithValue("department_id", userInput.Department.DepartmentId);
            cmd.Parameters.AddWithValue("password", userInput.Password);

            return cmd;
        }
        public static bool saveStaff(StaffModel userInput)
        {
            bool saved = false;
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "INSERT INTO `staffs`(`surname`, `first_name`, `email`, `gender`, `department_id`, `password`)"
                    + "VALUES (@surname, @first_name, @email, @gender, @department_id, @password); SELECT last_insert_id();";

                cmd = mapNewStaffDetails(query, conn, userInput);

                int staffId = Convert.ToInt32(cmd.ExecuteScalar());
                if (staffId != 0)
                {
                    saved = true;
                    saveUserRoles(staffId, userInput.Roles);
                }
            }
            return saved;
        }

        public static void saveUserRoles(int staffId, RoleModel[] roles)
        {
            foreach (RoleModel role in roles)
            {
                addUserRole(staffId, role.RoleName);
            }
        }
        public static bool addUserRole(int staffId, string role_name)
        {
            int roleId = RolesManager.getRoleId(role_name);
            if (roleId == 0) // check if valid role
                return false;
            if (RolesManager.userHasRole(staffId, roleId)) // check if user has that role
                return true;
            if (RolesManager.addUserRole(staffId, roleId))  // add role if they don't have
                return true;
            return false;
        }

    }
}
