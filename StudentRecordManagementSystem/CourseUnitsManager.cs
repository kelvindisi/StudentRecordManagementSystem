using System;
using System.Collections.Generic;
using DataAccess.Models;
using DataAccess;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace StudentRecordManagementSystem
{
    public partial class CourseUnitsManager : MaterialForm
    {
        private int course_id = 0;
        CourseModel course;

        public CourseUnitsManager(int course_id)
        {
            InitializeComponent();

            this.course_id = course_id;
        }
        private void CourseUnitsManager_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.BlueGrey500, 
                Accent.LightBlue200, TextShade.WHITE);

            // Grid configuration
            dtGridUnits.Columns[0].Visible = false;
            dtGridUnits.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGridUnits.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtGridUnits.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGridUnits.BorderStyle = BorderStyle.Fixed3D;
            
            dtGridUnits.Columns[0].DataPropertyName = "ID";
            dtGridUnits.Columns[1].DataPropertyName = "UnitCode";
            dtGridUnits.Columns[2].DataPropertyName = "UnitName";
            dtGridUnits.Columns[3].DataPropertyName = "Semester";

            dtGridUnits.AutoGenerateColumns = false;

            getCourseDetails();
            fillGrid();

        }

        private void getCourseDetails()
        {
            try
            {
                course = CourseManager.getCourseById(course_id);
                lblCourseValue.Text = course.CourseName;
                numSemester.Maximum = course.Duration;
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void fillGrid()
        {
            try
            {
                List<UnitModel> units = new List<UnitModel>();
                units = UnitManager.getCourseUnitsByCourseId(course_id);
                dtGridUnits.DataSource = null;
                dtGridUnits.DataSource = units;
            } catch(Exception ex)
            {
                showErrorMessage(ex.Message);
            }
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        public void showErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }
}
