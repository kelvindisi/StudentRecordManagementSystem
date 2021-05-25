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

namespace StudentRecordManagementSystem.Lecturer
{
    public partial class SessionUnits : MaterialForm
    {
        public int lecturer_id { get; set; }
        public int session_id { get; set; }
        public bool dblClickable { get; set; } = false;
        public int selected_sess_unit { get; set; }
        public SessionUnits()
        {
            InitializeComponent();
        }

        private void SessionUnits_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            initializeGridConfig();
            fillGrid();
            dtGridUnits.CellDoubleClick += DtGridUnits_CellDoubleClick;
        }

        private void DtGridUnits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!dblClickable)
                    return;
                int row = e.RowIndex;
                if (row >= 0)
                    setSessionUnit(row);
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
           
        }

        private void setSessionUnit(int row)
        {
            int val = (int)dtGridUnits.Rows[row].Cells[0].Value;
            selected_sess_unit = val;
            this.Close();
        }

        private void initializeGridConfig()
        {
            dtGridUnits.AutoGenerateColumns = false;
            dtGridUnits.Columns[0].DataPropertyName = "id";
            dtGridUnits.Columns[1].DataPropertyName = "unit_id";
            dtGridUnits.Columns[2].DataPropertyName = "unit_code";
            dtGridUnits.Columns[3].DataPropertyName = "unit_name";
            dtGridUnits.Columns[4].DataPropertyName = "course_name";
            dtGridUnits.Columns[5].DataPropertyName = "year";
            dtGridUnits.Columns[6].DataPropertyName = "semester";
        }

        private void fillGrid()
        {
            try
            {
                DataTable table = 
                    SessionUnitManager
                    .getLecturerUnits(lecturer_id, session_id, "");
                bindData(table);

            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void bindData(DataTable table)
        {
            dtGridUnits.DataSource = table;
        }

        private void showErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtSearch.Text.Trim();
                DataTable table =
                    SessionUnitManager
                    .getLecturerUnits(lecturer_id, session_id, search);
                bindData(table);
            }catch(Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }
    }
}
