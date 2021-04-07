using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class CourseModel
    {
        private int id;
        private string course_name;
        private string course_code;
        private int duration;
        private DepartmentModel department;

        public CourseModel()
        {
            this.CourseName = "";
            this.CourseCode = "";
            this.duration = 0;
            this.ID = 0;
        }
        public int ID
        {
            set { id = value; }
            get { return id;  }
        }
        public string CourseName
        {
            get { return course_name; }

            set { course_name = value; }
        }
        public string CourseCode
        {
            get { return course_code; }
            set { course_code = value; }
        }
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public DepartmentModel Department
        {
            get { return department; }
            set { department = value; }
        }


    }
}
