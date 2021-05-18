using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using DataAccess.Models;
using DataAccess;
using System.IO;
using StudentRecordManagementSystem.Futronic;
using StudentRecordManagementSystem.Exceptions;

namespace StudentRecordManagementSystem
{
    public partial class UpdateStudentBioData : MaterialForm
    {
        private int studentId;
        private string newEmail;
        public const int MINIMUM_ADM_AGE = 15;
        public BioDataModel bio { get; set; }
        public UpdateStudentBioData(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            
            // initialize form data
            rdoMale.Checked = true;
            rdoChristian.Checked = true;
            datePickerDOB.MaxDate = DateTime.Now.AddYears(-MINIMUM_ADM_AGE);
            updateFormValues();
        }

        private void updateFormValues()
        {
            try
            {
                setFormValues();
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }
        
        private void setFormValues()
        {
            UpdateBioField();
            if (bio.ID == 0)
            {
                showErrorMessage("Bio data doesn't exist anymore.");
                return;
            }
            setPersonalDetails();
            setAddressDetails();
            setContactDetails();
            setHomeAddressDetails();
        }

        private void UpdateBioField()
        {
            BioDataModel bioData = StudentManager.getBioById(studentId);
            bio = bioData;
        }

        private void setHomeAddressDetails()
        {
            txtVillage.Text = bio.Pvillage;
            txtLocation.Text = bio.PLocation;
            txtCounty.Text = bio.PCounty;
        }

        private void setContactDetails()
        {
            txtEmail.Text = bio.PEmail;
            txtPhone.Text = bio.PPhone;
        }

        private void setAddressDetails()
        {
            txtBox.Text = bio.PBox;
            txtTown.Text = bio.PTown;
        }

        private void setPersonalDetails()
        {
            txtFirstName.Text = bio.PFirstName;
            txtSurname.Text = bio.PSurname;
            txtID.Text = bio.PPassport;
            datePickerDOB.Value = bio.PDOB;
            setGender(bio.PGender);
            setReligion(bio.PReligion);
        }

        private void setReligion(string pReligion)
        {
            if (pReligion == "Christian")
                rdoChristian.Checked = true;
            else if (pReligion == "Muslim")
                rdoMuslim.Checked = true;
            else
                rdoButhist.Checked = true;
        }

        private void setGender(string pGender)
        {
            if (pGender == "Male")
                rdoMale.Checked = true;
            else if (pGender == "Female")
                rdoFemale.Checked = true;
            else
                rdoOther.Checked = true;
        }

        private void UpdateStudentBioData_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900,
                Primary.Blue700, Primary.BlueGrey500,
                Accent.LightBlue200, TextShade.WHITE);
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
                errProvider.SetError(txtSurname, "Surname is required");
                hasErrors = true;
            }
            else
                errProvider.SetError(txtSurname, null);
            // First Name
            if (txtFirstName.Text == "")
            {
                errProvider.SetError(txtFirstName, "First name is required");
                hasErrors = true;
            }
            else
                errProvider.SetError(txtFirstName, null);
            // ID / Passport/ Birth certificate
            if (txtID.Text == "")
            {
                errProvider.SetError(txtID, "ID No or Passport No or "
                    + "Birth certificate No is required");
                hasErrors = true;
            }
            else
                errProvider.SetError(txtID, null);
            // Box
            if (txtBox.Text == "")
            {
                errProvider.SetError(txtBox, "This field is required");
                hasErrors = true;
            }
            else
                errProvider.SetError(txtBox, null);
            // Town
            if (txtTown.Text == "")
            {
                errProvider.SetError(txtTown, "This field is required");
                hasErrors = true;
            }
            else
                errProvider.SetError(txtTown, null);
            // Phone
            if (txtPhone.Text == "")
            {
                errProvider.SetError(txtPhone, "This field is required");
                hasErrors = true;
            }
            else
                errProvider.SetError(txtPhone, null);
            // Email
            if (txtEmail.Text == "")
            {
                errProvider.SetError(txtEmail, "This field is required");
                hasErrors = true;
            }
            else
                errProvider.SetError(txtEmail, null);
            // Village
            if (txtVillage.Text == "")
            {
                errProvider.SetError(txtVillage, "This field is required");
                hasErrors = true;
            }
            else
                errProvider.SetError(txtVillage, null);
            // Location
            if (txtLocation.Text == "")
            {
                errProvider.SetError(txtLocation, "This field is required");
                hasErrors = true;
            }
            else
                errProvider.SetError(txtLocation, null);
            // County
            if (txtCounty.Text == "")
            {
                hasErrors = true;
                errProvider.SetError(txtCounty, "This field is required");
            }
            else
                errProvider.SetError(txtCounty, null);

            return !hasErrors;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInput();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (validInput())
                {
                    BioDataModel bioData = getUserInput();
                    bioData.ID = studentId;
                    StudentManager.updateBioData(bioData);
                    manageFingerprint(bioData);

                    showMessage("Updated details successfully.");
                }
            }
            catch(FingerprintNotRecordedException)
            {
                showFingerprintDialog();
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
            finally
            {
                UpdateBioField();
            }
        }

        private void manageFingerprint(BioDataModel bioData)
        {
            bool emailChanged = bioData.PEmail != bio.PEmail ? true : false;

            if (emailChanged)
            {
                newEmail = bioData.PEmail;
                renameFingerprintName(bio.PEmail, bioData.PEmail);
            }
            else
                FingerprintManager
                    .checkFingerprintExists(bio.PEmail, DbName.student);
        }

        private void showFingerprintDialog()
        {
            try
            {
                NoFingerprintCaptured fr = new NoFingerprintCaptured();
                DialogResult rs = fr.ShowDialog(this);
                if (rs == DialogResult.Yes)
                {
                    FingerPrintScanner scanner = new FingerPrintScanner(DbName.student);
                    scanner.email = newEmail;
                    scanner.ShowDialog();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void renameFingerprintName(string old, string updated)
        {
            FingerprintManager.renameFingerPrint(DbName.student, old, updated);
        }

        private void showMessage(string v)
        {
            MessageBox.Show(v, this.Text, 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
