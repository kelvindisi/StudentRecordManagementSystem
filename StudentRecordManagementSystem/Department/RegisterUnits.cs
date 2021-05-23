using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using DataAccess;

namespace StudentRecordManagementSystem
{
    public partial class RegisterUnits : MaterialForm
    {
        internal int sessionId;
        internal int courseId;
        public RegisterUnits()
        {
            InitializeComponent();
        }

        private void RegisterUnits_Load(object sender, EventArgs e)
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
            dtGridStudents.AutoGenerateColumns = false;
            dtGridStudents.Columns[0].DataPropertyName = "id";
            dtGridStudents.Columns[1].DataPropertyName = "regNo";
            dtGridStudents.Columns[2].DataPropertyName = "first_name";
            dtGridStudents.Columns[3].DataPropertyName = "surname";
            dtGridStudents.Columns[4].DataPropertyName = "email";
        }

        private void fillGrid()
        {
            try
            {
                DataTable courseStudents =
                    StudentManager.getCourseStudents(courseId, "");
                dtGridStudents.DataSource = courseStudents;
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void showErrorMessage(string msg)
        {
            MessageBox.Show(msg, this.Text, 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtSearch.Text;
                DataTable table = 
                    StudentManager.getCourseStudents(courseId, search);
                dtGridStudents.DataSource = table;
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }
    }
}
