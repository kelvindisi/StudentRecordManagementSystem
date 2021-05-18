using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using DataAccess.Models;
using DataAccess;

namespace StudentRecordManagementSystem
{
    public partial class StudentBioManager : MaterialForm
    {
        public StudentBioManager()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void ManageStudents_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900,
                Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            dtGridConfig();
            try
            {
                fillGrid();
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void dtGridConfig()
        {
            dtGridBio.AutoGenerateColumns = false;
            dtGridBio.Columns[0].Visible = false;
            dtGridBio.Columns[0].DataPropertyName = "ID";
            dtGridBio.Columns[1].DataPropertyName = "PFirstName";
            dtGridBio.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGridBio.Columns[2].DataPropertyName = "PSurname";
            dtGridBio.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtGridBio.Columns[3].DataPropertyName = "PEmail";
            dtGridBio.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtGridBio.Columns[4].DataPropertyName = "PGender";
            dtGridBio.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dtGridBio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridBio.CellDoubleClick += DtGridBio_CellDoubleClick;
        }

        private void DtGridBio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                if (rowIndex < 0)
                    return;

                int bioDataId = (int)dtGridBio.Rows[rowIndex].Cells[0].Value;
                UpdateStudentBioData updateForm = new UpdateStudentBioData(bioDataId);
                updateForm.ShowDialog(this);
                fillGrid();
            }catch(Exception ex)
            {
                showErrorMessage(ex.Message);
            }

        }

        private void fillGrid()
        {
            List<BioDataModel> bios = StudentManager.getStudentBio();
            dtGridBio.DataSource = bios;
        }

        private void showErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text, 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }
}
