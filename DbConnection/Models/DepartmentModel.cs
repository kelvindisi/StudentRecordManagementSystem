using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class DepartmentModel
    {
        private int departmentId;
        private string departmentName;

        public DepartmentModel()
        {
            this.departmentId = 0;
            this.departmentName = "";
        }
        public DepartmentModel(string departmentName)
        {
            this.departmentName = departmentName;
        }
        public DepartmentModel(int departmentId, string departmentName)
        {
            this.departmentId = departmentId;
            this.departmentName = departmentName;
        }
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }

        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }

    }
}
