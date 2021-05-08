using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class UnitModel
    {
        private int id;
        private CourseModel course;
        private string unit_name;
        private string unit_code;
        private int semester;

        public int Semester
        {
            get { return semester; }
            set { semester = value; }
        }


        public string UnitCode
        {
            get { return unit_code; }
            set { unit_code = value; }
        }
        public CourseModel Course
        {
            get { return course; }
            set { course = value; }
        }
        public string UnitName
        {
            get { return unit_name; }
            set { unit_name = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public override string ToString()
        {
            return UnitName;
        }

    }
}
