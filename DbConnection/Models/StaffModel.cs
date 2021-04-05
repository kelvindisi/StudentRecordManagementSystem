using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class StaffModel
    {
        private int id;
        private string firstName;
        private string surname;
        private string email;
        private string gender;
        private DepartmentModel department;
        private string password;
        private RoleModel[] roles;

        public StaffModel(string firstName, string surname, string email, 
            string gender, DepartmentModel department, string password, RoleModel[] roles)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.email = email;
            this.gender = gender;
            this.department = department;
            this.password = password;
            this.roles = roles;
        }
        public RoleModel[] Roles
        {
            get
            {
                return roles;
            }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public DepartmentModel Department
        {
            get { return department; }
            set { department = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public int ID
        {
            get
            {
                return id;
            }
        }

    }
}
