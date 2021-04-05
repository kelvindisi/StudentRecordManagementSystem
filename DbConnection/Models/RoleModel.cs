using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class RoleModel
    {
        private int id;
        private string roleName;


        public RoleModel()
        {
            this.id = 0;
            this.roleName = "";
        }
        public RoleModel(int id, string roleName)
        {
            this.id = id;
            this.roleName = roleName;
        }
        public RoleModel(string roleName)
        {
            this.roleName = roleName;
        }
        public RoleModel(int id)
        {
            this.id = id;
        }

        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}
