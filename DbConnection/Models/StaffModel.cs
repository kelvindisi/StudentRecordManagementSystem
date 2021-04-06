using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class StaffModel: StaffPrimaryModel
    {
        protected DepartmentModel department;
        protected RoleModel[] roles;

        public StaffModel(StaffPrimaryModel staff)
        {
            ID = staff.ID;
            Surname = staff.Surname;
            FirstName = staff.FirstName;
            Email = staff.Email;
            Gender = staff.Gender;
            Password = staff.Password;
        }
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
            get { return roles; }
            set { roles = value; }
        }

        public DepartmentModel Department
        {
            get { return department; }
            set { department = value; }
        }

    }
}
