using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace StudentRecordManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            activeMenu.Height = btnDashboard.Height;
            activeMenu.Top = btnDashboard.Top;
            dashboardControl.BringToFront();

            initializeAppDbConfig();
        }

        private void initializeAppDbConfig()
        {
            try
            {
                RolesManager.autoRoleConfig();
            }
            catch (Exception)
            {
                
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            activeMenu.Height = btnDashboard.Height;
            activeMenu.Top = btnDashboard.Top;
            dashboardControl.BringToFront();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            activeMenu.Height = btnAdmin.Height;
            activeMenu.Top = btnAdmin.Top;
            adminControl.BringToFront();
        }

        private void btnDepartmentAdmin_Click(object sender, EventArgs e)
        {
            activeMenu.Height = btnDepartmentAdmin.Height;
            activeMenu.Top = btnDepartmentAdmin.Top;
            departmentControl.BringToFront();
        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            activeMenu.Height = btnLecturer.Height;
            activeMenu.Top = btnLecturer.Top;
            lecturerControl.BringToFront();
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            activeMenu.Height = btnHospital.Height;
            activeMenu.Top = btnHospital.Top;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
