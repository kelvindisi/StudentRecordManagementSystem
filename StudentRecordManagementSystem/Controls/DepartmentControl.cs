using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentRecordManagementSystem.Department;

namespace StudentRecordManagementSystem
{
    public partial class DepartmentControl : UserControl
    {
        public static int department { get; set; }
        public DepartmentControl()
        {
            InitializeComponent();
        }

        private void btnEnrollStudent_Click(object sender, EventArgs e)
        {
            BioDataForm studentForm = new BioDataForm();
            try
            {
                studentForm.ShowDialog();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAssignCourse_Click(object sender, EventArgs e)
        {
            StudentBioManager students = new StudentBioManager();
            students.ShowDialog();
        }

        private void btnEnrollCourse_Click(object sender, EventArgs e)
        {
            CourseList courses = new CourseList();
            courses.department = department;
            courses.ShowDialog();
        }
    }
}
