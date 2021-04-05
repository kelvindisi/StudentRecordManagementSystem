using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Models;
using System.Collections;
using MaterialSkin;
using MaterialSkin.Controls;

namespace StudentRecordManagementSystem
{
    public partial class AddStaffForm : MaterialForm
    {
        public AddStaffForm()
        {
            InitializeComponent();

            addDepartments();

        }

        private void addDepartments()
        {
            try
            {
                ArrayList departments = DepartmentManager.getDepartmentsList();
                foreach(DepartmentModel department in departments)
                {
                    ComboBoxItem item = new ComboBoxItem(department.DepartmentName, department.DepartmentId);
                    cboDepartment.Items.Add(item);
                }
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void AddStaffForm_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            rdoMale.Checked = true;
        }
        private bool validNames()
        {
            bool valid = true;
            setError(txtFirstName);
            setError(txtSurname);

            if (txtFirstName.Text.Length == 0)
            {
                setError(txtFirstName, "First name");
                valid = false;
            }
            if (txtSurname.Text.Length == 0)
            {
               setError(txtSurname, "Surname");
                valid = false;
            }

            return valid;
        }
        private void setError(Control field, String fieldName)
        {
            errorProvider.SetError(field, string.Format("{0} is required", fieldName));
        }
        public void setError(Control field)
        {
            errorProvider.SetError(field, null);
        }
        private bool validEmail()
        {
            setError(txtEmail);
            if (txtEmail.Text.Length > 0)
                return true;
            setError(txtEmail, "Email");
            return false;
        }
        private bool validPassword()
        {
            bool valid = true;
            string password, passwordConfirmation;
            password = txtPassword.Text;
            passwordConfirmation = txtPasswordConfirmation.Text;
            // password typed?
            bool typed = password.Length > 0 && passwordConfirmation.Length > 0;
            setError(txtPassword);
            setError(txtPasswordConfirmation);
            errorProvider.SetError(txtPassword, null);

            if (!(typed))
            {
                setError(txtPassword, "Password");
                setError(txtPasswordConfirmation, "Password confirmation");
                valid = false;
            }

            if (password != passwordConfirmation)
            {
                errorProvider.SetError(txtPassword, "Passwords do not match");
                valid = false;
            }

            return valid;
        }

        private bool validStaffRoles()
        {
            bool valid = false;

            if (cbxAdmin.Checked)
                valid = true;
            if (cbxLecturer.Checked)
                valid = true;
            if (cbxDepartmentAdmin.Checked)
                valid = true;
            if (!valid)
                showErrorMessageBox("Please select user role");

            return valid;
        }

        private bool validDepartment()
        {
            bool valid = false;
            try
            {

                ComboBoxItem selected = (ComboBoxItem)cboDepartment.SelectedItem;
                if (selected.Tag != null)
                    valid = true;
            }
            catch (Exception)
            {
                showErrorMessageBox("Please select valid department");
            }
            return valid;
        }
        private void showErrorMessageBox(String error)
        {
            MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private string getGender()
        {
            if (rdoMale.Checked)
                return "Male";
            else if (rdoFemale.Checked)
                return "Female";
            else
                return "Other";
        }
        private DepartmentModel getDepartment()
        {
            ComboBoxItem department = (ComboBoxItem)cboDepartment.SelectedItem;


            return new DepartmentModel((int)department.Tag, department.Message);
        }
        private RoleModel[] getRoles()
        {
            ArrayList roles = new ArrayList();
            if (cbxAdmin.Checked)
                roles.Add(new RoleModel("admin"));
            if (cbxDepartmentAdmin.Checked)
                roles.Add(new RoleModel("department admin"));
            if (cbxLecturer.Checked)
                roles.Add(new RoleModel("lecturer"));

            return roles.Cast<RoleModel>().ToArray();
        }
        private StaffModel staffFormDetails()
        {
            string firstName = txtFirstName.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;
            string gender = getGender();
            string password = txtPassword.Text;
            RoleModel[] roles = getRoles();
            DepartmentModel department = getDepartment();
            StaffModel details = new StaffModel(firstName, surname, email, gender, department, password, roles);
            return details;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // check whether input is invalid
                if (!validNames() || !validEmail() || !validStaffRoles() || !validDepartment() || !validPassword())
                    return;
                StaffModel userInput = staffFormDetails();
                if (StaffManager.staffExists(userInput.Email))
                {
                    showErrorMessageBox("Staff with similar email already exists");
                    return;
                }
                if (StaffManager.saveStaff(userInput))
                {
                    MessageBox.Show("Saved staff details successfully", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                showErrorMessageBox("Failed to details to database");
            }
            catch (Exception ex)
            {
                showErrorMessageBox(ex.Message);
            }
        }
    }
}
