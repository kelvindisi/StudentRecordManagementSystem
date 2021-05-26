using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class StudentScoreModel
    {
        public string RegNo { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }
        public int Score { get; set; }
        public int OutOf { get; set; }
    }
}
