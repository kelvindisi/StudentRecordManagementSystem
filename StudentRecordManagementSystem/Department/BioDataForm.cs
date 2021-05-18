using System;
using MaterialSkin.Controls;
using MaterialSkin;
using DataAccess;
using System.Windows.Forms;
using DataAccess.Models;

namespace StudentRecordManagementSystem
{
    public partial class BioDataForm : MaterialForm
    {
        enum dbName
        {
            admin,
            deparment_admin,
            lecture,
            student
        }
        public const int MINIMUM_ADM_AGE = 15;
        public BioDataForm()
        {
            InitializeComponent();
        }


        private void BioDataForm_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            // initialize form data
            rdoMale.Checked = true;
            rdoChristian.Checked = true;
            datePickerDOB.MaxDate = DateTime.Now.AddYears(-MINIMUM_ADM_AGE);
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validInput())
                {
                    BioDataModel bioData = getUserInput();
                    StudentManager.saveBioData(bioData);
                    showScannerForm(bioData.PEmail);
                }
            }catch(Exception ex)
            {
                showErrorMessage(ex.Message);
            } 
        }
      
        private void showErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private BioDataModel getUserInput()
        {
            return new BioDataModel(
                                txtSurname.Text, txtFirstName.Text, getGender(), txtPhone.Text,
                                getDOB(), txtID.Text, txtBox.Text, txtTown.Text,
                                txtEmail.Text, getReligion(), txtVillage.Text, txtLocation.Text,
                                txtCounty.Text
                            );
        }

        private DateTime getDOB()
        {
            DateTime dob = DateTime.Parse(datePickerDOB.Text);
            return dob;
        }

        private void clearInput()
        {
            txtSurname.Clear();
            txtFirstName.Clear();
            rdoMale.Checked = true;
            setDefaultDate();
            txtID.Clear();
            txtBox.Clear();
            txtTown.Clear();
            txtEmail.Clear();
            rdoChristian.Checked = true;
            txtVillage.Clear();
            txtLocation.Clear();
            txtCounty.Clear();
            txtPhone.Clear();
        }

        private void setDefaultDate()
        {
            datePickerDOB.Text = DateTime.Now.AddYears(-MINIMUM_ADM_AGE)
                .ToShortDateString();
        }

        private string getReligion()
        {
            if (rdoChristian.Checked)
                return "Christian";
            else if (rdoMuslim.Checked)
                return "Muslim";
            else
                return "Buthist";
        }

        
        private bool validInput()
        {
            bool hasErrors = false;

            if (txtSurname.Text == "")
            {
                bioDataErrProvider.SetError(txtSurname, "Surname is required");
                hasErrors = true;
            }
            else
                bioDataErrProvider.SetError(txtSurname, null);
            // First Name
            if (txtFirstName.Text == "")
            {
                bioDataErrProvider.SetError(txtFirstName, "First name is required");
                hasErrors = true;
            }
            else
                bioDataErrProvider.SetError(txtFirstName, null);
            // ID / Passport/ Birth certificate
            if (txtID.Text == "")
            {
                bioDataErrProvider.SetError(txtID, "ID No or Passport No or "
                    + "Birth certificate No is required");
                hasErrors = true;
            }
            else
                bioDataErrProvider.SetError(txtID, null);
            // Box
            if (txtBox.Text == "")
            {
                bioDataErrProvider.SetError(txtBox, "This field is required");
                hasErrors = true;
            }
            else
                bioDataErrProvider.SetError(txtBox, null);
            // Town
            if (txtTown.Text == "")
            {
                bioDataErrProvider.SetError(txtTown, "This field is required");
                hasErrors = true;
            }
            else
                bioDataErrProvider.SetError(txtTown, null);
            // Phone
            if (txtPhone.Text == "")
            {
                bioDataErrProvider.SetError(txtPhone, "This field is required");
                hasErrors = true;
            }
            else
                bioDataErrProvider.SetError(txtPhone, null);
            // Email
            if (txtEmail.Text == "")
            {
                bioDataErrProvider.SetError(txtEmail, "This field is required");
                hasErrors = true;
            }
            else
                bioDataErrProvider.SetError(txtEmail, null);
            // Village
            if (txtVillage.Text == "")
            {
                bioDataErrProvider.SetError(txtVillage, "This field is required");
                hasErrors = true;
            }
            else
                bioDataErrProvider.SetError(txtVillage, null);
            // Location
            if (txtLocation.Text == "")
            {
                bioDataErrProvider.SetError(txtLocation, "This field is required");
                hasErrors = true;
            }
            else
                bioDataErrProvider.SetError(txtLocation, null);
            // County
            if (txtCounty.Text == "")
            {
                hasErrors = true;
                bioDataErrProvider.SetError(txtCounty, "This field is required");
            }
            else
                bioDataErrProvider.SetError(txtCounty, null);

            return !hasErrors;
        }

        private void showScannerForm(string email)
        {
            FingerPrintScanner scanner = new FingerPrintScanner(DbName.student);
            scanner.email = email;
            scanner.ShowDialog();
            if (!scanner.recorded)
                promptActions(email);
            else
                bioDataCompletelyStored();
        }

        private void bioDataCompletelyStored()
        {
            showMessage("Saved bio data and fingerprint successfully");
            clearInput();
        }
        private void showMessage(string message)
        {
            MessageBox.Show(message, this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void promptActions(string email)
        {
            FingerPrintNotRecorded diag = new FingerPrintNotRecorded();
            DialogResult result = diag.ShowDialog(this);
            if (result == DialogResult.Cancel)
                promptDeleteBioData(email);
            else if (result == DialogResult.Retry)
                showScannerForm(email);
            else if (result == DialogResult.Ignore)
                bioDataWithoutFingerprintSaved();
        }

        private void bioDataWithoutFingerprintSaved()
        {
            showMessage("Saved student bio data, to capture fingerprint later");
            clearInput();
        }

        private void promptDeleteBioData(string email)
        {
            FingerprintCancelBioDelete prompt = new FingerprintCancelBioDelete();
            DialogResult result = prompt.ShowDialog(this);
            if (result == DialogResult.No)
                showScannerForm(email);
            else if (result == DialogResult.Yes)
                deleteStudentBioData(email);
        }

        private void deleteStudentBioData(string email)
        {
            StudentManager.deleteBioData(email);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInput();
        }
    }
}
