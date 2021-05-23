using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem.Department.Model
{
    class GridSessionUnitModel
    {
        public int ID { get; set; }
        public bool Active { get; set; }
        public int Semester { get; set; }
        public int UnitID { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public int LecturerID { get; set; }
        public string LecturerName { get; set; }
    }
}
