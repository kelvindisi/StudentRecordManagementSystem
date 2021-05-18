using System;
using System.Collections;
using DataAccess;
using DataAccess.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Data;
using System.Linq;

namespace StudentRecordManagementSystem
{
    public partial class ManageStaffForm : MaterialForm
    {
        private int ID { get; set; }
        public ManageStaffForm()
        {
            InitializeComponent();
        }

        private void ManageStaffForm_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            // Set grid configuration
            dtGridStaffs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtGridStaffs.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dtGridStaffs.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dtGridStaffs.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dtGridStaffs.Columns[3].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            updateDepartments();
            fillGrid();

            // Event executed if selection changes to update form
            dtGridStaffs.SelectionChanged += UpdateFormData;
        }

        private void UpdateFormData(object sender, EventArgs e)
        {
            try
            {
                string email = dtGridStaffs.SelectedRows[0].Cells[3].Value.ToString();
                fetchUpdateForm(email);
            }
            catch (Exception)
            {
               // pass
            }
        }

        private void fetchUpdateForm(string email)
        {
            StaffModel staff = StaffManager.getStaffByEmail(email);
            this.ID = staff.ID;
            txtFirstName.Text = staff.FirstName;
            txtSurname.Text = staff.Surname;
            txtEmail.Text = staff.Email;
            updateFormGender(staff.Gender);
            updateformDepartment(staff.Department);
            updateFormRoles(staff.Roles);
        }

        private void updateFormRoles(RoleModel[] roles)
        {
            cbxLecturer.Checked = false;
            cbxAdmin.Checked = false;
            cbxDepartmentAdmin.Checked = false;

            foreach (RoleModel role in roles)
            {
                if (role.RoleName.ToLower() == "admin")
                    cbxAdmin.Checked = true;
                else if (role.RoleName.ToLower() == "department admin")
                    cbxDepartmentAdmin.Checked = true;
                else if (role.RoleName.ToLower() == "lecturer")
                    cbxLecturer.Checked = true;
            }
        }


        private void updateformDepartment(DepartmentModel department)
        {
            int selectedIndex = 0;

            foreach (ComboBoxItem item in cboDepartment.Items)
            {
                if (department.DepartmentId == (int)item.Tag)
                {
                    selectedIndex = cboDepartment.Items.IndexOf(item);
                    break;
                }
            }

            cboDepartment.SelectedIndex = selectedIndex;
        }

        private void updateFormGender(string gender)
        {
            if (gender.ToLower().Equals("female"))
                rdoFemale.Checked = true;
            else if (gender.ToLower().Equals("male"))
                rdoMale.Checked = true;
            else
                rdoOther.Checked = true;
        }

        public void updateDepartments()
        {
            try
            {
                ArrayList departments = DepartmentManager.getDepartmentsList();
                foreach (DepartmentModel department in departments)
                {
                    ComboBoxItem item = new ComboBoxItem(department.DepartmentName, department.DepartmentId);
                    cboDepartment.Items.Add(item);
                }
            }
            catch (Exception)
            {
                showErrorMessage("Error occured while loading department list");
            }
        }
        public void fillGrid()
        {
            try
            {
                setGridData();
            }
            catch (Exception)
            {
                showErrorMessage("Error occured while trying to load data");
            }
        }
        private void setGridData()
        {
            dtGridStaffs.AutoGenerateColumns = false;

            DataTable table = StaffManager.getStaff();

            dtGridStaffs.Columns[0].DataPropertyName = "surname";
            dtGridStaffs.Columns[1].DataPropertyName = "first_name";
            dtGridStaffs.Columns[2].DataPropertyName = "gender";
            dtGridStaffs.Columns[3].DataPropertyName = "email";

            dtGridStaffs.DataSource = table;
        }
        public void showErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateForm())
                    return;
                if (updateStaffDetails())
                {
                    fillGrid();
                    MessageBox.Show("updated details successfully", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    showErrorMessage("Error occured failed to update data");
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }

        }

        private bool updateStaffDetails()
        {
            StaffModel staff = getUserInput();
            staff.ID = this.ID;
            if (StaffManager.UpdateStaffDetails(staff))
                return true;
            return false;
        }
        private StaffPrimaryModel getPrimaryStaffInput()
        {
            StaffPrimaryModel pStaff = new StaffPrimaryModel();
            pStaff.FirstName = txtFirstName.Text;
            pStaff.Surname = txtSurname.Text;
            pStaff.Gender = getGender();
            pStaff.Email = txtEmail.Text;
            pStaff.Password = txtPassword.Text;

            return pStaff;
        }
        private StaffModel getUserInput()
        {
            StaffPrimaryModel pStaff = getPrimaryStaffInput();
            StaffModel staff = new StaffModel(pStaff);
            staff.Department = getDepartment();
            staff.Roles = getRoles();
           
            return staff;     
        }

        private RoleModel[] getRoles()
        {
            ArrayList roles = new ArrayList();
            if (cbxAdmin.Checked)
            {
                RoleModel role = getRole("admin");
                if (role != null)
                    roles.Add(role);
            }
            if (cbxLecturer.Checked)
            {
                RoleModel role = getRole("lecturer");
                if (role != null)
                    roles.Add(role);
            }
            if (cbxDepartmentAdmin.Checked)
            {
                RoleModel role = getRole("department admin");
                if (role != null)
                    roles.Add(role);
            }

            return roles.Cast<RoleModel>().ToArray();
        }

        private RoleModel getRole(string role_name)
        {
            int id = RolesManager.getRoleId(role_name);
            RoleModel role = RolesManager.getRoleById(id);

            return role;
        }

        private DepartmentModel getDepartment()
        {
            ComboBoxItem item = (ComboBoxItem)cboDepartment.SelectedItem;

            return new DepartmentModel((int)item.Tag, item.Message);
        }

        private string getGender()
        {
            if (rdoFemale.Checked)
                return "Female";
            if (rdoMale.Checked)
                return "Male";
            else
                return "Other";
        }

        private bool validateForm()
        {
            bool valid = true;

            if (!validFormUserNames() || !validFormEmail() || !validFormRoles() || !validFormDepartment() || !validateFormPassword())
                valid = false;

            return valid;
        }

        private bool validateFormPassword()
        {
            bool valid = true;
            removeError(txtPassword);

            if (txtPassword.Text.Length != 0)
            {
                string password, confirmation;
                password = txtPassword.Text;
                confirmation = txtConfirmation.Text;

                if (password != confirmation)
                {
                    errProvider.SetError(txtPassword, "Password does not match with password confirmation");
                    valid = false;
                }
            }

            return valid;
        }

        private bool validFormDepartment()
        {
            bool valid = false;
            try
            {
                ComboBoxItem selected = (ComboBoxItem)cboDepartment.SelectedItem;
                if ((int)selected.Tag != 0)
                    valid = true;
                else
                    showErrorMessage("Please choose valid department");
            }
            catch (Exception)
            {
                showErrorMessage("Ooops! seems you have not chosen department");
            }

            return valid;
        }

        private bool validFormRoles()
        {
            bool valid = false;
            if (cbxAdmin.Checked)
                valid = true;
            if (cbxDepartmentAdmin.Checked)
                valid = true;
            if (cbxLecturer.Checked)
                valid = true;
            if (!valid)
                showErrorMessage("Please select staff role");
            return valid;
        }

        private bool validFormEmail()
        {
            bool valid = true;

            removeError(txtEmail);

            if (txtEmail.Text.Trim().Length == 0)
            {
                setRequiredError(txtEmail, "Email");
                valid = false;
            }
            if (checkEmailHasOtherOwner())
            {
                valid = false;
                showErrorMessage("Email belongs to different user");
            }

            return valid;
        }

        private bool checkEmailHasOtherOwner()
        {
            bool belongToOther = false;
            string email = txtEmail.Text;

            StaffModel staff = StaffManager.getStaffByEmail(email);
            if (staff != null)
            {
                if (staff.ID != this.ID)
                    belongToOther = true;
            }

            return belongToOther;
        }

        private bool validFormUserNames()
        {
            bool valid = true;

            removeError(txtSurname);
            removeError(txtFirstName);

            if (txtSurname.Text.Trim().Length == 0)
            {
                setRequiredError(txtSurname, "Surname");
                valid = false;
            }
            if (txtFirstName.Text.Trim().Length == 0)
            {
                setRequiredError(txtFirstName, "First Name");
                valid = false;
            }

            return valid;
        }
        private void removeError(Control control)
        {
            errProvider.SetError(control, null);
        }
        private void setRequiredError(Control control, string field)
        {
            errProvider.SetError(control, string.Format("{0} is required.", field));
        }
    }
}
