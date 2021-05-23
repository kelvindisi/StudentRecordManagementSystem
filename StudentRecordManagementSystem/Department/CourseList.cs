using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using DataAccess;
using DataAccess.Models;

namespace StudentRecordManagementSystem.Department
{
    public partial class CourseList : MaterialForm
    {
        public int department { get; set; }
        public CourseList()
        {
            InitializeComponent();
        }

        private void EnrollCourse_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900,
                Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            initializeGridSettings();
            fillGridData();
        }

        private void initializeGridSettings()
        {
            // ID, CourseName, CourseCode, Duration, Department
            dtGridCourses.AutoGenerateColumns = false;
            dtGridCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridCourses.CellDoubleClick += DtGridCourses_CellDoubleClick;
            dtGridCourses.Columns[0].DataPropertyName = "ID";
            dtGridCourses.Columns[1].DataPropertyName = "CourseCode";
            dtGridCourses.Columns[2].DataPropertyName = "CourseName";
            dtGridCourses.Columns[3].DataPropertyName = "Duration";

            dtGridCourses.Columns[0].Visible = false;
            dtGridCourses.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGridCourses.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtGridCourses.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void DtGridCourses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowId = e.RowIndex;
                if (rowId < 0)
                    return;
                int courseId = (int)dtGridCourses.Rows[rowId].Cells[0].Value;
                CourseManagerOption manager = new CourseManagerOption();
                manager.courseId = courseId;
                manager.departmentId = department;
                manager.ShowDialog();
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void fillGridData()
        {
            try
            {
                fillGrid();
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void fillGrid()
        {
            List<CourseModel> courses = 
                CourseManager.getCoursesByDepartment(this.department);
            dtGridCourses.DataSource = courses;
        }

        private void showErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
