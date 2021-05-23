using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Models;
using StudentRecordManagementSystem.Department.Model;

namespace StudentRecordManagementSystem.Department
{
    public partial class SessionCourseUnitList : MaterialForm
    {
        public int sessionId { get; set; }
        public int courseId { get; set; }
        public SessionCourseUnitList()
        {
            InitializeComponent();
            initializeGridSettings();
        }

        private void initializeGridSettings()
        {
            dtGridCourses.AutoGenerateColumns = false;
            dtGridCourses.MultiSelect = false;
            dtGridCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridCourses.CellClick += DtGridCourses_CellClick;
            dtGridCourses.CellDoubleClick += DtGridCourses_CellDoubleClick;
            gridDataPropNames();
            readAndWriteSetup();
            gridColumnsSizing();
        }

        private void DtGridCourses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                int sessUnitId = getSessionUnitId(row);
                SelectLecturer lectForm = new SelectLecturer();
                DialogResult result = lectForm.ShowDialog();
                if (result == DialogResult.OK)
                    dialogResultOK(sessUnitId, lectForm.lecturerId);
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }


        private void dialogResultOK(int unitId, int lecId)
        {
            if (lecId <= 0)
                throw new Exception("You need to select lecture first");
            SessionUnitManager.addSessUnitLecturer(unitId, lecId);
            bindGridData();
        }
        private int getSessionUnitId(int row)
        {
            int id = (int)dtGridCourses.Rows[row].Cells[0].Value;
            if (id == 0)
                throw new Exception("Unit is not allowed for registration");

            return id;
        }

        private void DtGridCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int colIndex = e.ColumnIndex;
                int rowIndex = e.RowIndex;
                if (rowIndex > -1 && colIndex == 1)
                    updateSessUnit(rowIndex);
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void updateSessUnit(int row)
        {
            GridSessionUnit current = getCurrentValue(row);
            if (current.Active)
            {
                SessionUnitModel sess = saveState(current.UnitID);
                updateGridData(row, sess);
            }else
            {
                removeSessUnit(row, current.ID);
            }

        }

        private void removeSessUnit(int row, int sessID)
        {
            var removed = SessionUnitManager.removeSessionUnit(sessID);
            if (removed)
            {
                dtGridCourses.Rows[row].Cells[0].Value = 0;
                dtGridCourses.Rows[row].Cells[1].Value = null;
                dtGridCourses.Rows[row].Cells[6].Value = "None";
            }
        }

        private void updateGridData(int row, SessionUnitModel sess)
        {
            dtGridCourses.Rows[row].Cells[0].Value = sess.ID;
            dtGridCourses.Rows[row].Cells[1].Value = sess.Active;
        }

        private SessionUnitModel saveState(int unitId)
        {
            return SessionUnitManager
                .addSessionUnit(sessionId, unitId);
        }

        private GridSessionUnit getCurrentValue(int row)
        {
            GridSessionUnit sess = new GridSessionUnit();
            sess.ID = (int)dtGridCourses.Rows[row].Cells[0].Value;
            sess.Active = !(bool)dtGridCourses.Rows[row].Cells[1].Value;
            sess.UnitID = (int)dtGridCourses.Rows[row].Cells[2].Value;
            return sess;
        }

        private void gridDataPropNames()
        {
            dtGridCourses.Columns[0].DataPropertyName = "ID";
            dtGridCourses.Columns[1].DataPropertyName = "Active";
            dtGridCourses.Columns[2].DataPropertyName = "UnitID";
            dtGridCourses.Columns[3].DataPropertyName = "UnitCode";
            dtGridCourses.Columns[4].DataPropertyName = "UnitName";
            dtGridCourses.Columns[5].DataPropertyName = "Semester";
            dtGridCourses.Columns[6].DataPropertyName = "LecturerName";
        }

        private void gridColumnsSizing()
        {
            dtGridCourses.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGridCourses.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGridCourses.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtGridCourses.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGridCourses.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void readAndWriteSetup()
        {
            dtGridCourses.Columns[0].Visible = false;
            dtGridCourses.Columns[2].Visible = false;
            dtGridCourses.Columns[3].ReadOnly = true;
            dtGridCourses.Columns[4].ReadOnly = true;
            dtGridCourses.Columns[5].ReadOnly = true;
            dtGridCourses.Columns[6].ReadOnly = true;
        }
        private void CourseUnitList_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            fillGrid();
        }

        private void fillGrid()
        {
            try
            {
                bindGridData();
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void bindGridData()
        {
            List<SessionUnitModel> units = SessionUnitManager
                        .getSessionUnits(courseId, sessionId);
            List<GridSessionUnitModel> gridUnits = toGridData(units);

            var bs = new BindingSource();
            bs.DataSource = gridUnits;
            dtGridCourses.DataSource = bs;
        }

        private List<GridSessionUnitModel> toGridData(List<SessionUnitModel> LUnits)
        {
            List<GridSessionUnitModel> units = new List<GridSessionUnitModel>();

            foreach(var unit in LUnits)
            {
                GridSessionUnitModel sUnit = new GridSessionUnitModel();
                sUnit.ID = unit.ID;
                sUnit.Active = unit.Active;
                sUnit.UnitID = unit.Unit.ID;
                sUnit.Semester = unit.Unit.Semester;
                sUnit.UnitCode = unit.Unit.UnitCode;
                sUnit.UnitName = unit.Unit.UnitName;
                sUnit.LecturerID = unit.Lecturer.ID;
                sUnit.LecturerName = getLecName(unit.Lecturer);
                units.Add(sUnit);
            }

            return units;

        }

        private string getLecName(StaffPrimaryModel lecturer)
        {
            string fName = lecturer.FirstName;
            string sName = lecturer.Surname;
            string fullName = string.Format("{0} {0}", fName, sName);
            if (fullName.Trim().Length == 0)
                return "None";
            return fullName;
        }

        private void showErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text, 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
