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

namespace StudentRecordManagementSystem
{
    public partial class UnitsRegisterList : MaterialForm
    {
        internal int sessionId;
        internal int courseId;
        internal int studentId;

        public UnitsRegisterList()
        {
            InitializeComponent();
        }

        private void UnitsRegisterList_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);            
            initializeGrid();
            fillGrid();
        }

        private void initializeGrid()
        {
            dtGridSessCourseUnits.AutoGenerateColumns = false;
            dtGridSessCourseUnits.Columns[0].DataPropertyName = "id";
            dtGridSessCourseUnits.Columns[1].DataPropertyName = "unit_id";
            dtGridSessCourseUnits.Columns[2].DataPropertyName = "unit_code";
            dtGridSessCourseUnits.Columns[3].DataPropertyName = "unit_name";
            dtGridSessCourseUnits.Columns[4].DataPropertyName = "msg";
            dtGridSessCourseUnits.CellClick += DtGridSessCourseUnits_CellClick;
        }

        private void DtGridSessCourseUnits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int col = e.ColumnIndex;
                int row = e.RowIndex;

                if (row >= 0 && col == 4)
                    updateRegistration(row, col);
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void updateRegistration(int row, int col)
        {
            string val = (string)dtGridSessCourseUnits
                .Rows[row].Cells[col].Value;
            int unit = (int)dtGridSessCourseUnits.Rows[row].Cells[0].Value;

            if (val.ToLower().Equals("enroll"))
                enrollStudentUnit(unit);
            else
                disenrollStudentUnit(unit);

        }

        private void disenrollStudentUnit(int unit)
        {
            var isEnrolled = SessionUnitManager
                .isEnrolledSessUnit(studentId, unit);
            if (isEnrolled)
            {
                string msg = "When disenrolled attendance and test "
                    + "records will be deleted";
                string title = "Please confirm first";
                DialogResult rs = MessageBox.Show(msg, title,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    SessionUnitManager.DisenrollSessUnit(studentId, unit);
                    fillterWithSearch();
                }
            }
        }

        private void enrollStudentUnit(int unit)
        {
            var isEnrolled = SessionUnitManager
                .isEnrolledSessUnit(studentId, unit);
            if (!isEnrolled)
                SessionUnitManager.enrollSessUnit(studentId, unit);
            fillterWithSearch();
        }

        private void fillGrid()
        {
            try
            {
                DataTable sessUnits =
                    SessionUnitManager
                    .getSessionCourseUnits(sessionId, courseId, "");
                bindData(sessUnits);

            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void bindData(DataTable sessUnits)
        {
            sessUnits = updateRegistered(sessUnits);
            dtGridSessCourseUnits.DataSource = sessUnits;
        }

        private DataTable updateRegistered(DataTable units)
        {
            List<int> registeredIds = SessionUnitManager
                .registeredUnitsId(sessionId, courseId, studentId);
            for(int rowIndex=0; rowIndex < units.Rows.Count; rowIndex++)
            {
                int unitId = (int)units.Rows[rowIndex][1];
                if (registeredIds.Contains(unitId))
                {
                    units.Rows[rowIndex][4] = "Disenroll";
                }
            }

            return units;
        }

        private void showErrorMessage(string v)
        {
            MessageBox.Show(v, this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fillterWithSearch();
        }

        private void fillterWithSearch()
        {
            try
            {
                string search = txtSearch.Text.Trim();
                DataTable table = SessionUnitManager
                    .getSessionCourseUnits(sessionId, courseId, search);
                bindData(table);
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }
    }
}
