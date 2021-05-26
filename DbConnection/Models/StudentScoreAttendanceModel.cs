using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class StudentScoreAttendanceModel
    {
        public StudentScoreModel info { get; set; }
        public StudentAttendanceScore attendance { get; set; }
    }
}
