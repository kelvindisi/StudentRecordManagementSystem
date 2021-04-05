using System;
using MaterialSkin.Controls;
using MaterialSkin;
using DataAccess;
using System.Windows.Forms;
using Futronic.SDKHelper;
using System.Drawing;
using System.IO;
using System.Text;
using DataAccess.Models;

namespace StudentRecordManagementSystem
{
    public partial class BioDataForm : MaterialForm
    {
        const string kCompanyName = "Futronic";
        const string kProductName = "SDK 4.0";
        const string kDbName = "DataBaseNet";
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
        public const int MINIMUM_ADM_AGE = 15;
        public BioDataForm()
        {
            InitializeComponent();
            this.m_bInitializationSuccess = false;
            // Create FutronicEnrollment object for retrieve default values only
            FutronicEnrollment dummy = new FutronicEnrollment();
            FingerprintConfig.FARNLevel = (int) dummy.FARnLevel;
            FingerprintConfig.MaxModels = dummy.MaxModels;
            FingerprintConfig.detectFakeFinger = dummy.FakeDetection;
            FingerprintConfig.MIOT = dummy.MIOTControlOff;
            FingerprintConfig.FastMode = dummy.FastMode;
            FingerprintConfig.identificationLimit = dummy.IdentificationsLeft;
            FingerprintConfig.version = dummy.Version;

            btnStop.Enabled = false;
            btnScanLeft.Enabled = false;
            try
            {
                m_DatabaseDir = GetDatabaseDir();
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

            BioDataModel bioData = getUserInput();
            SaveBioData(bioData);
        }

        private void SaveBioData(BioDataModel bioData)
        {
            try
            {
                if (StudentManager.bioDataExists(bioData.PEmail))
                {
                    MessageBox.Show("Bio data with this email exists", "Bio Data Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (StudentManager.saveBioData(bioData))
                {
                    MessageBox.Show("Bio Data saved successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bioDisableControls();
                }
                else
                {
                    MessageBox.Show("Failed to save data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            string UserName = txtEmail.Text;

            if (UserName.Length == 0)
            {
                MessageBox.Show("Email is required to register fingerprint",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isUserExists(UserName))
            {
                DialogResult results = MessageBox.Show("User exists, do you want to replace?", 
                    "User Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (results == DialogResult.No)
                    return;
            }else
            {
                try
                {
                    CreateFile(UserName);
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show(this, "Can not create file to save an user's information.", this.Text,
                                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                catch (IOException)
                {
                    MessageBox.Show(this, String.Format("Bad user name '{0}'.", UserName),
                                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            User.UserName = UserName;

            m_OperationObj = User;
            FutronicSdkBase dummy = new FutronicEnrollment();
            if (m_Operation != null)
            {
                m_Operation.Dispose();
                m_Operation = null;
            }
            m_Operation = dummy;

            // Set control properties
            m_Operation.FakeDetection = FingerprintConfig.detectFakeFinger;
            m_Operation.FFDControl = true;
            m_Operation.FARN = FingerprintConfig.FARNLevel;
            m_Operation.Version = FingerprintConfig.version;
            m_Operation.FastMode = FingerprintConfig.FastMode;
            ((FutronicEnrollment)m_Operation).MIOTControlOff = FingerprintConfig.MIOT;
            ((FutronicEnrollment)m_Operation).MaxModels = FingerprintConfig.MaxModels;

            EnableControls(false);

            // register events
            m_Operation.OnPutOn += new OnPutOnHandler(this.OnPutOn);
            m_Operation.OnTakeOff += new OnTakeOffHandler(this.OnTakeOff);
            m_Operation.UpdateScreenImage += new UpdateScreenImageHandler(this.UpdateScreenImage);
            m_Operation.OnFakeSource += new OnFakeSourceHandler(this.OnFakeSource);
            ((FutronicEnrollment)m_Operation).OnEnrollmentComplete += new OnEnrollmentCompleteHandler(this.OnEnrollmentComplete);

            // start enrollment process
            ((FutronicEnrollment)m_Operation).Enrollment();
        }
        protected void EnableControls(Boolean state)
        {
            MessageBox.Show("Disable controls scanning is on going");
        }

        /**
         * Fingerprint methods
         * */
        public static String GetDatabaseDir()
        {
            String szDbDir;
            szDbDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments, Environment.SpecialFolderOption.Create);
            szDbDir = Path.Combine(szDbDir, kCompanyName);
            if (!Directory.Exists(szDbDir))
            {
                Directory.CreateDirectory(szDbDir);
            }
            szDbDir = Path.Combine(szDbDir, kProductName);
            if (!Directory.Exists(szDbDir))
            {
                Directory.CreateDirectory(szDbDir);
            }

            szDbDir = Path.Combine(szDbDir, kDbName);
            if (!Directory.Exists(szDbDir))
            {
                Directory.CreateDirectory(szDbDir);
            }

            return szDbDir;
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

            if (PictureFingerPrint.InvokeRequired)
            {
                SetImageCallback d = new SetImageCallback(this.UpdateScreenImage);
                this.Invoke(d, new object[] { hBitmap });
            }
            else
            {
                PictureFingerPrint.Image = hBitmap;
            }
        }

        private bool OnFakeSource(FTR_PROGRESS Progress)
        {
            if (m_bExit)
                return true;

            DialogResult result;
            result = MessageBox.Show("Fake source detected. Do you want continue process?",
                                     "Student Record MIS",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return (result == DialogResult.No);
        }
        private void SetStatusText(String text)
        {
            // Do not change the state control during application closing.
            if (m_bExit)
                return;

            if (this.txtMessage.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(this.SetStatusText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtMessage.Text = text;
                this.Update();
            }
        }
        private void OnEnrollmentComplete(bool bSuccess, int nRetCode)
        {
            StringBuilder szMessage = new StringBuilder();
            if (bSuccess)
            {
                // set status string
                szMessage.Append("Enrollment process finished successfully.");
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
                                     "Student Record MIS",
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
    }
}
