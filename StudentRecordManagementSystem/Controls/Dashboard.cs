using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Models;

namespace StudentRecordManagementSystem
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        internal void updateRoles(List<RoleModel> roles)
        {
            clearRoles();
            foreach(RoleModel role in roles)
            {
                if (role.RoleName.ToLower() == "admin")
                    checkAdmin.Checked = true;

                if (role.RoleName.ToLower() == "department admin")
                    checkDepartmentAdmin.Checked = true;

                if (role.RoleName.ToLower() == "lecturer")
                    checkLecture.Checked = true;
            }
        }

        private void clearRoles()
        {
            checkAdmin.Checked = false;
            checkDepartmentAdmin.Checked = false;
            checkLecture.Checked = false;
        }
    }
}
