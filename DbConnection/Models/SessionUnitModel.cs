using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class SessionUnitModel
    {
        public int ID { get; set; }
        public CourseModel Course { get; set; }
        public UnitModel Unit { get; set; }
        public StaffPrimaryModel Lecturer { get; set; }
        public bool Active { get; set; }
    }
}
