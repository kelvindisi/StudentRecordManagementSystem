using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentRecordManagementSystem.ReportsAdmin;

namespace StudentRecordManagementSystem
{
    public partial class AdminControl : UserControl
    {
        public AdminControl()
        {
            InitializeComponent();
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaffForm addStaff = new AddStaffForm();
            addStaff.ShowDialog();
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            ManageStaffForm manageStaff = new ManageStaffForm();
            manageStaff.ShowDialog();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            DepartmentForm departments = new DepartmentForm();
            departments.ShowDialog();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CoursesForm courseForm = new CoursesForm();
            courseForm.ShowDialog();
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            SessionManagerForm sessionForm = new SessionManagerForm();
            sessionForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ViewStaffList staffs = new ViewStaffList();
            staffs.Show();
        }
    }
}
