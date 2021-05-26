using System;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace StudentRecordManagementSystem
{
    public partial class DepartmentForm : MaterialForm
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            fillDepartmentGrid();
        }
        private void fillDepartmentGrid()
        {
            BindingSource bSource = new BindingSource();
            bSource.DataSource = DepartmentManager.getDepartmentsData();
            dtGridDepartment.DataSource = bSource;
            this.dtGridDepartment.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dtGridDepartment.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string department = txtDepartmentName.Text;

            if (department.Length == 0)
            {
                errProvider.SetError(txtDepartmentName, "Please enter valid department name");
                return;
            }
            DepartmentModel departmentModel = new DepartmentModel(department);
            try
            {
                if (DepartmentManager.departmentExists(departmentModel.DepartmentName))
                {
                    MessageBox.Show("Department already exists", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!DepartmentManager.saveDepartment(departmentModel))
                {
                    MessageBox.Show("Failed to save department details", "Student Record MIS",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                fillDepartmentGrid();
                MessageBox.Show("Saved department details successfully", "Student Record MIS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                // update gridview
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
    }
}
