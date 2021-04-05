using System;
using System.Collections;
using MySql.Data.MySqlClient;


namespace DataAccess
{
    public class RolesManager: DbConnector
    {
        public static ArrayList getRoles()
        {
            ArrayList roles = new ArrayList();

            using (conn = new MySqlConnection(getConnectionString()))
            {
                string query = "SELECT * FROM roles";
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                        roles.Add(reader.GetString("name"));
                }
            }

            return roles;
        }
        public static void autoRoleConfig()
        {
            ArrayList roles = new ArrayList(new string[] { "admin", "department admin", "lecturer" });
            ArrayList savedRoles = getRoles();

            foreach (var role in savedRoles)
            {
                if (roles.Contains((string)role))
                {
                    roles.Remove((string)role);
                }
            }

            saveRoles(roles);

        }
        public static void saveRoles(ArrayList roles)
        {
            foreach (string role in roles)
            {
                using (conn = new MySqlConnection(getConnectionString()))
                {
                    string query = "INSERT INTO roles(name) VALUES(@roleName)";
                    conn.Open();
                    cmd = new MySqlCommand(query, conn);
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("roleName", role);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static int getRoleId(string roleName)
        {
            int roleId = 0;
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT id FROM roles WHERE name=@roleName";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("roleName", roleName);
                int id = (int)cmd.ExecuteScalar();
                roleId = id;
            }
            return roleId;
        }
        public static string getRoleName(int roleId)
        {
            string roleName = "";
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT name FROM roles WHERE id=@roleId";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("roleId", roleId);
                roleName = (string)cmd.ExecuteScalar();
            }
            return roleName;
        }
        public static bool userHasAnyRole(int staffId)
        {
            bool hasRole = false;
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM roles_staff WHERE staff_id=@staffId";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("staffId", staffId);
                if (cmd.ExecuteReader().HasRows)
                    hasRole = true;
            }
            return hasRole;
        }
        public static bool userHasRole(int staffId, int roleId)
        {
            bool hasRole = false;
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM roles_staff WHERE staff_id=@staffId AND role_id=@roleId";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("staffId", staffId);
                cmd.Parameters.AddWithValue("roleId", roleId);
                if (cmd.ExecuteReader().HasRows)
                    hasRole = true;
            }
            return hasRole;
        }
        public static bool addUserRole(int staffId, int roleId)
        {
            bool addedRole = false;
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "INSERT INTO roles_staff VALUES (@staffId, @roleId)";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("staffId", staffId);
                cmd.Parameters.AddWithValue("roleId", roleId);
                if (cmd.ExecuteNonQuery() > 0)
                    addedRole = true;

            }
            return addedRole;
        }
    }
}
