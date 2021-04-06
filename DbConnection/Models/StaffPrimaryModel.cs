using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class StaffPrimaryModel
    {
        protected int id;
        protected string firstName;
        protected string surname;
        protected string email;
        protected string gender;
        protected string password;

        public int DepartmentId { get; set; }
        public string Password
        {
            get { return password; }
            set { password = value; }
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
            get { return id; }
            set { id = value; }
        }
    }
}
