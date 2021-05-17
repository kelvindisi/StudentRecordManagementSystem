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
using DataAccess.Models;

namespace StudentRecordManagementSystem
{
    public partial class MainForm : Form
    {
        public StaffAuthModel staff { get; set; }
        public Login loginForm { get; set; }
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
            loginForm.clearInput();
            loginForm.Show();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                strpLblName.Text = staff.FirstName;
                updateRoles();
                updateMainFormInterface();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateMainFormInterface()
        {
            List<string> roles = new List<string>();
            foreach (RoleModel role in staff.Roles)
            {
                roles.Add(role.RoleName);
            }
            disableAdmin(roles);
            disableDepartmentAdmin(roles);
            disableLecturer(roles);
        }

        private void disableLecturer(List<string> roles)
        {
            if (roles.Contains("lecturer"))
                return;
            btnLecturer.Enabled = false;
            disabledBackground(btnLecturer);
        }

        private void disableDepartmentAdmin(List<string> roles)
        {
            if (roles.Contains("department admin"))
                return;
            btnDepartmentAdmin.Enabled = false;
            disabledBackground(btnDepartmentAdmin);
        }

        private void disableAdmin(List<string> roles)
        {
            if (roles.Contains("admin"))
                return;
            btnAdmin.Enabled = false;
            disabledBackground(btnAdmin);
        }

        private void disabledBackground(Button btn)
        {
            btn.BackColor = Color.Gray;
        }

        private void updateRoles()
        {
            dashboardControl.updateRoles(staff.Roles);
        }
    }
}
