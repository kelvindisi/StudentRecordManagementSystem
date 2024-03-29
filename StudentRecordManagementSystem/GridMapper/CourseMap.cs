﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace StudentRecordManagementSystem.GridMapper
{
    class CourseMap
    {
        public int id { get; set; }
        public string courseName { get; set; }
        public string courseCode { get; set; }
        public DepartmentModel department { get; set; }
        public int semesters { get; set; }
    }
}
