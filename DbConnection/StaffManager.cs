using System;
using System.Collections;
using MySql.Data.MySqlClient;
using DataAccess.Models;
using System.Data;
using System.Linq;

using System.Windows.Forms;
using System.Text;

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
        public static DataTable getStaff()
        {
            DataTable table = new DataTable("staffs");
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM staffs";
                cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter dapt = new MySqlDataAdapter(cmd);
                dapt.Fill(table);
            }
            return table;
        }
        private static StaffPrimaryModel getByEmail(string email)
        {
            StaffPrimaryModel staff = new StaffPrimaryModel();

            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM staffs WHERE email=@email";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("email", email);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    if (rd.Read())
                    {
                        staff.ID = rd.GetInt32("id");
                        staff.FirstName = rd.GetString("first_name");
                        staff.Surname = rd.GetString("surname");
                        staff.Email = rd.GetString("email");
                        staff.Gender = rd.GetString("gender");
                        staff.DepartmentId = rd.GetInt32("department_id");
                    }
                }else
                {
                    return null;
                }
            }
            

            return staff;
        }
        private static StaffPrimaryModel getById(int id)
        {
            StaffPrimaryModel staff = new StaffPrimaryModel();

            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM staffs WHERE id=@id";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("id", id);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    if (rd.Read())
                    {
                        staff.ID = rd.GetInt32("id");
                        staff.FirstName = rd.GetString("first_name");
                        staff.Surname = rd.GetString("surname");
                        staff.Email = rd.GetString("email");
                        staff.Gender = rd.GetString("gender");
                        staff.DepartmentId = rd.GetInt32("department_id");
                        staff.Password = rd.GetString("password");
                    }
                }
                else
                {
                    return null;
                }
            }


            return staff;
        }

        private static ArrayList getListStaffRoles(int staffId)
        {
            ArrayList roles = new ArrayList();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM roles_staff WHERE staff_id=@staffId";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("staffId", staffId);
                MySqlDataReader rd = cmd.ExecuteReader();
                while(rd.Read())
                    roles.Add(rd.GetInt32("role_id"));
            }
            return roles;
        }
        
        public static RoleModel[] getStaffRoles(int staffId)
        {
            ArrayList roles = new ArrayList();
            ArrayList role_ids = getListStaffRoles(staffId);
            foreach(int role_id in role_ids)
            {
                RoleModel role = RolesManager.getRoleById(role_id);
                roles.Add(role);
            }

            return roles.Cast<RoleModel>().ToArray();

        }
       
        public static StaffModel getStaffByEmail(string email)
        {
            StaffPrimaryModel pDetailsStaff = getByEmail(email);
            if (pDetailsStaff == null)
                return null;
            StaffModel staff = new StaffModel(pDetailsStaff);
            if (staff.ID != 0)
            {
                staff.Department = DepartmentManager.getDepartmentById(pDetailsStaff.DepartmentId);
                staff.Roles = getStaffRoles(pDetailsStaff.ID);
            }

            return staff;
        }
       
        public static bool UpdateStaffDetails(StaffModel staff)
        {
            bool updated = false;
            StaffPrimaryModel oldStaff = getById(staff.ID);
            bool personalUpdated = updatedPersonalDetails(staff, oldStaff.Password);
            bool rolesUpdated = updatedRoles(staff.ID, staff.Roles);

            if (personalUpdated && rolesUpdated)
                updated = true;
            
            return updated;
        }

        private static bool updatedRoles(int staffId, RoleModel[] roles)
        {
            bool updated = false;
            // remove all permissions
            bool removed = removedStaffPermissions(staffId);
            // add new permissions
            bool added = addedStaffPermissions(staffId, roles);
            if (removed && added)
                updated = true;
            return updated;
        }

        private static bool addedStaffPermissions(int staffId, RoleModel[] roles)
        {
            bool added = true;

            foreach(RoleModel role in roles){
                if (!addUserRole(staffId, RolesManager.getRoleName(role.ID)))
                    added = false;
            }

            return added;
        }

        private static bool removedStaffPermissions(int staffId)
        {
            bool removed = false;
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "DELETE FROM roles_staff WHERE staff_id=@staffId";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("staffId", staffId);
                cmd.ExecuteNonQuery();
                int staffRoleCount = getStaffRoles(staffId).Count();
                if (staffRoleCount == 0)
                    return true;
            }
            return removed;
        }

        private static bool updatedPersonalDetails(StaffModel staff, string password)
        {
            bool updated = false;
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "UPDATE `staffs` SET `surname`=@surname,`first_name`=@firstName,"
                    + "`email`=@email,`gender`=@gender,`department_id`=@departmentId,`password`=@password WHERE `id`=@id";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("surname", staff.Surname);
                cmd.Parameters.AddWithValue("firstName", staff.FirstName);
                cmd.Parameters.AddWithValue("email", staff.Email);
                cmd.Parameters.AddWithValue("gender", staff.Gender);
                cmd.Parameters.AddWithValue("departmentId", staff.Department.DepartmentId);
                cmd.Parameters.AddWithValue("id", staff.ID);
                if (staff.Password.Length == 0)
                    cmd.Parameters.AddWithValue("password", password);
                else
                    cmd.Parameters.AddWithValue("password", staff.Password);

                if (cmd.ExecuteNonQuery() > 0)
                    updated = true;

            }

            return updated;
        }
    }
}
