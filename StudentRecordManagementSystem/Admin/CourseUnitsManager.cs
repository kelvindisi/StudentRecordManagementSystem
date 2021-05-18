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
        private int selectedUnitId = 0;
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
            dtGridUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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

            dtGridUnits.SelectionChanged += DtGridUnits_SelectionChanged;

        }

        private void DtGridUnits_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int unitId = (int)dtGridUnits.SelectedRows[0].Cells[0].Value;
                updateFormData(unitId);
            }
            catch (Exception)
            {
                // no error
            }
        }

        private void updateFormData(int unitId)
        {
            try
            {
                fillFormWithNewUpdatedData(unitId);
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void fillFormWithNewUpdatedData(int unitId)
        {
            UnitModel unit = UnitManager.getUnitById(unitId);
            selectedUnitId = unit.ID;
            txtUnitName.Text = unit.UnitName;
            txtUnitCode.Text = unit.UnitCode;
            int semester = unit.Semester; ;
            if (semester >= numSemester.Minimum && semester <= numSemester.Maximum)
            {
                numSemester.Value = semester;
            }
            else
            {
                numSemester.Value = numSemester.Maximum;
                showErrorMessage("Number of semesters may have been reduced update unit details");
            }
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
                selectedUnitId = 0;
                dtGridUnits.DataSource = null;
                List<UnitModel> units = new List<UnitModel>();
                units = UnitManager.getCourseUnitsByCourseId(course_id);
                dtGridUnits.DataSource = null;
                dtGridUnits.DataSource = units;
            } catch(Exception ex)
            {
                showErrorMessage(ex.Message);
            }
            
        }
        public bool validateInput()
        {
            bool valid = true;

            errProvider.SetError(txtUnitName, null);
            errProvider.SetError(txtUnitCode, null);

            if (txtUnitCode.Text.Trim().Length == 0)
            {
                errProvider.SetError(txtUnitName, "Please enter unit code");
                valid = false;
            }
            if (txtUnitName.Text.Trim().Length == 0)
            {
                errProvider.SetError(txtUnitName, "Please enter unit name");
                valid = false;
            }

            return valid; 
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                validateAndSaveNewInput();
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void validateAndSaveNewInput()
        {
            if (!validateInput())
                return;
            UnitModel unit = getUnitInput();
            int count = UnitManager.saveNewUnit(unit);
            if (count == 0)
            {
                showErrorMessage("Failed to save data");
                return;
            }
            MessageBox.Show("Saved unit details successfully");
            fillGrid();
        }

        private UnitModel getUnitInput()
        {
            UnitModel unit = new UnitModel();
            unit.Course = course;
            unit.Semester = (int)numSemester.Value;
            unit.UnitCode = txtUnitCode.Text.Trim();
            unit.UnitName = txtUnitName.Text.Trim();

            return unit;
        }

        public void showErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                updateSelectedUnit();
                fillGrid();
                MessageBox.Show("Updated unit successfully");
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void updateSelectedUnit()
        {
            if (!validateInput())
                return;
            UnitModel unit = getUnitDetails();
            UnitManager.updateUnit(unit);
        }

        private UnitModel getUnitDetails()
        {
            UnitModel unit = new UnitModel();

            unit = getUnitInput();
            unit.ID = selectedUnitId;       

            return unit;
        }
    }
}
