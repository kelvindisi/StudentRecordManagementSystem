using System;
using MaterialSkin.Controls;
using MaterialSkin;
using DataAccess;
using System.Windows.Forms;
using Futronic.SDKHelper;
using System.Drawing;
using Biometric;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace StudentRecordManagementSystem
{
    public partial class BioDataForm : MaterialForm
    {
        const string kCompanyName = "School";
        const string kProductName = "SDK 4.0";
        const string kDbName = "Students";

        /// <summary>
        /// This delegate enables asynchronous calls for setting
        /// the text property on a status control.
        /// </summary>
        /// <param name="text"></param>
        delegate void SetTextCallback(string text);

        /// <summary>
        /// This delegate enables asynchronous calls for setting
        /// the text property on a identification limit control.
        /// </summary>
        /// <param name="text"></param>
        delegate void SetIdentificationLimitCallback(int limit);

        /// <summary>
        /// This delegate enables asynchronous calls for setting
        /// the Image property on a PictureBox control.
        /// </summary>
        /// <param name="hBitmap">the instance of Bitmap class</param>
        delegate void SetImageCallback(Bitmap hBitmap);

        /// <summary>
        /// This delegate enables asynchronous calls for setting
        /// the Enable property on a buttons.
        /// </summary>
        /// <param name="bEnable">true to enable buttons, otherwise to disable</param>
        delegate void EnableControlsCallback(bool bEnable);

        /// <summary>
        /// Contain reference for current operation object
        /// </summary>
        private FutronicSdkBase m_Operation;

        private bool m_bExit;

        /// <summary>
        /// The type of this parameter is depending from current operation. For
        /// enrollment operation this is DbRecord.
        /// </summary>
        private Object m_OperationObj;

        /// <summary>
        /// A directory name to write user's information.
        /// </summary>
        private String m_DatabaseDir;

        private bool m_bInitializationSuccess;

        /// <summary>
        /// End of Futronic initialization code
        /// </summary>
        public const int MINIMUM_ADM_AGE = 15;
        public BioDataForm()
        {
            InitializeComponent();

            // Futronic initialization
            m_bExit = false;
            
            try
            {
                this.m_DatabaseDir = BiometricData.GetDatabaseDir(kCompanyName, kProductName, kDbName);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(this, "Initialization failed. Application will be close.\nCan not create database folder. Access denied.",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            catch (IOException)
            {
                MessageBox.Show(this, "Initialization failed. Application will be close.\nCan not create database folder",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            m_bInitializationSuccess = true;
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

            //initialize scanner
            //btnScanLeft.Enabled = false;
            //btnScanRight.Enabled = false;
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
            if (validateInput())
            {
                MessageBox.Show("Please fill the form as required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BioDataModel bioData = new BioDataModel(
                    txtSurname.Text, txtFirstName.Text, getGender(), txtPhone.Text,
                    getDOB(), txtID.Text, txtBox.Text, txtTown.Text,
                    txtEmail.Text, getReligion(), txtVillage.Text, txtLocation.Text,
                    txtCounty.Text
                );
            try
            {
                if (DbConnection.bioDataExists(bioData.PEmail))
                {
                    MessageBox.Show("Bio data with this email exists", "Bio Data Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (DbConnection.saveBioData(bioData))
                {
                    MessageBox.Show("Bio Data saved successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bioDisableControls();
                } else
                {
                    MessageBox.Show("Failed to save data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            datePickerDOB.Text = DateTime.Now.AddYears(-MINIMUM_ADM_AGE).ToShortDateString();
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

        private string getReligion()
        {
            if (rdoChristian.Checked)
                return "Christian";
            else if (rdoMuslim.Checked)
                return "Muslim";
            else
                return "Buthist";
        }

        private void bioDisableControls()
        {
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnScanLeft.Enabled = true;
        }

        private bool validateInput()
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

            return hasErrors;
        }

        private void btnScanLeft_Click(object sender, EventArgs e)
        {
            DbRecord User = new DbRecord();
            string userEmail = txtEmail.Text;
            if (userEmail == null || userEmail.Length == 0)
            {
                MessageBox.Show("Email is required to register fingerprint", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // check if email is associated with fingerprint
            if (isUserExists(userEmail))
            {
                DialogResult respo = MessageBox.Show("User has already been registered, want to replace?",
                    "User has been registered already", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (respo == DialogResult.No)
                    return;
            }
            else
            {
                try
                {
                    CreateFile(userEmail);
                }
                #pragma warning disable CS0168 // Variable is declared but never used
                catch (DirectoryNotFoundException ep)
                #pragma warning restore CS0168 // Variable is declared but never used
                {
                    MessageBox.Show("Cannot create file to save student information",
                        "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (IOException ei)
                {
                    MessageBox.Show(String.Format("Bad user {0}", userEmail), "Error occured",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User.UserName = userEmail;
                m_OperationObj = User;
                FutronicSdkBase dummy = new FutronicEnrollment();
                if (m_Operation != null)
                {
                    m_Operation.Dispose();
                    m_Operation = null;
                }
                m_Operation = dummy;

                // Set control properties
                m_Operation.FakeDetection = BiometricData.DetectFakeFinger();
                m_Operation.FFDControl = true;
                m_Operation.FARN = Int32.Parse(BiometricData.getFARnLevel().ToString());
                m_Operation.Version = (BiometricData.getCompatibleVersion());
                m_Operation.FastMode = BiometricData.fastMode;
                ((FutronicEnrollment)m_Operation).MIOTControlOff = BiometricData.MIOT;
                ((FutronicEnrollment)m_Operation).MaxModels = BiometricData.max_frame;

                EnableControls(false);

                // register events
                m_Operation.OnPutOn += new OnPutOnHandler(this.OnPutOn);
                m_Operation.OnTakeOff += new OnTakeOffHandler(this.OnTakeOff);
                m_Operation.UpdateScreenImage += new UpdateScreenImageHandler(this.UpdateScreenImage);
                m_Operation.OnFakeSource += new OnFakeSourceHandler(this.OnFakeSource);
                ((FutronicEnrollment)m_Operation).OnEnrollmentComplete +=
                    new OnEnrollmentCompleteHandler(this.OnEnrollmentComplete);

                // start enrollment process
                ((FutronicEnrollment)m_Operation).Enrollment();
            }
        }
        private void OnPutOn(FTR_PROGRESS Progress)
        {
            this.SetStatusText("Put finger into device, please ...");
        }

        private void OnTakeOff(FTR_PROGRESS Progress)
        {
            this.SetStatusText("Take off finger from device, please ...");
        }

        private void UpdateScreenImage(Bitmap hBitmap)
        {
            // Do not change the state control during application closing.
            if (m_bExit)
                return;

            if (picLeftIndex.InvokeRequired)
            {
                SetImageCallback d = new SetImageCallback(this.UpdateScreenImage);
                this.Invoke(d, new object[] { hBitmap });
            }
            else
            {
                picLeftIndex.Image = hBitmap;
            }
        }

        private bool OnFakeSource(FTR_PROGRESS Progress)
        {
            if (m_bExit)
                return true;

            DialogResult result;
            result = MessageBox.Show("Fake source detected. Do you want continue process?",
                                     "C# example for Futronic SDK",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return (result == DialogResult.No);
        }
        private void OnEnrollmentComplete(bool bSuccess, int nRetCode)
        {
            StringBuilder szMessage = new StringBuilder();
            if (bSuccess)
            {
                // set status string
                szMessage.Append("Fingerprint registered successfully.");
                szMessage.Append("Quality: ");
                szMessage.Append(((FutronicEnrollment)m_Operation).Quality.ToString());
                this.SetStatusText(szMessage.ToString());

                // Set template into user's information and save it
                DbRecord User = (DbRecord)m_OperationObj;
                User.Template = ((FutronicEnrollment)m_Operation).Template;

                String szFileName = Path.Combine(m_DatabaseDir, User.UserName);
                if (!User.Save(szFileName))
                {
                    MessageBox.Show("Can not save users's information to file " + szFileName,
                                     "Error occured",
                                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                szMessage.Append("Enrollment process failed.");
                szMessage.Append("Error description: ");
                szMessage.Append(FutronicSdkBase.SdkRetCode2Message(nRetCode));
                this.SetStatusText(szMessage.ToString());
            }

            // unregister events
            m_Operation.OnPutOn -= new OnPutOnHandler(this.OnPutOn);
            m_Operation.OnTakeOff -= new OnTakeOffHandler(this.OnTakeOff);
            m_Operation.UpdateScreenImage -= new UpdateScreenImageHandler(this.UpdateScreenImage);
            m_Operation.OnFakeSource -= new OnFakeSourceHandler(this.OnFakeSource);
            ((FutronicEnrollment)m_Operation).OnEnrollmentComplete -= new OnEnrollmentCompleteHandler(this.OnEnrollmentComplete);

            m_OperationObj = null;
            EnableControls(true);
        }
        private void SetStatusText(String text)
        {
            // Do not change the state control during application closing.
            if (m_bExit)
                return;

            if (this.txtFingerPrintMsg.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(this.SetStatusText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtFingerPrintMsg.Text = text;
                this.Update();
            }
        }
        public void EnableControls(bool state)
        {

        }
        protected bool isUserExists(String UserName)
        {
            String szFileName;
            szFileName = Path.Combine(m_DatabaseDir, UserName);
            return File.Exists(szFileName);
        }

        protected void CreateFile(String UserName)
        {
            String szFileName;
            szFileName = Path.Combine(m_DatabaseDir, UserName);
            File.Create(szFileName).Close();
            File.Delete(szFileName);
        }
    }
}
