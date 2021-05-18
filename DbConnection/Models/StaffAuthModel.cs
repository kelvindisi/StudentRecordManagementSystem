using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class StaffAuthModel
    {
        private int id;
        private string username;
        private string password;
        private List<RoleModel> roles;
        private string fName;
        private string sName;
        private int department;

        public int DepartmentId
        {
            get { return department; }
            set { department = value; }
        }


        public string Surname
        {
            get { return sName; }
            set { sName = value; }
        }

            
        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }


        public List<RoleModel> Roles
        {
            get { return roles; }
            set { roles = value; }
        }


        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public string Username
        {
            get { return username; }
            set { username = value; }
        }


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}
