using System;
using MaterialSkin;
using MaterialSkin.Controls;
using DataAccess;
using System.Windows.Forms;
using System.Data;

namespace StudentRecordManagementSystem
{
    public partial class SelectLecturer : MaterialForm
    {
        public int lecturerId { get; set; }
        public SelectLecturer()
        {
            InitializeComponent();
        }

        private void SelectLecturer_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            configGrid();
            fillGrid();
        }

        private void configGrid()
        {
            dtGridLecturers.AutoGenerateColumns = false;
            dtGridLecturers.SelectionMode = 
                DataGridViewSelectionMode.FullRowSelect;
            dtGridLecturers.MultiSelect = false;
            dtGridLecturers.Columns[0].DataPropertyName = "id";
            dtGridLecturers.Columns[1].DataPropertyName = "first_name";
            dtGridLecturers.Columns[2].DataPropertyName = "surname";
            dtGridLecturers.Columns[3].DataPropertyName = "email";
            dtGridLecturers.Columns[4].DataPropertyName = "departmentName";

            dtGridLecturers.CellClick += DtGridLecturers_CellClick;
        }

        private void DtGridLecturers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
                lecturerId = (int)dtGridLecturers.Rows[row].Cells[0].Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            DataTable table = StaffManager.getLecturers(search);
            dtGridLecturers.DataSource = table;
        }

        private void fillGrid()
        {
            try
            {
                DataTable table = StaffManager.getLecturers("");
                dtGridLecturers.DataSource = table;
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void showErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text, 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
