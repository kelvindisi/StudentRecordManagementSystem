using System;
using System.Drawing;
using System.IO;
using System.Text;
using Futronic.SDKHelper;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Windows.Forms;

namespace StudentRecordManagementSystem
{
    public partial class FingerPrintScanner : MaterialForm
    {
        const string kCompanyName = "Futronic";
        const string kProductName = "SDK 4.0";
        private static string kDbName;
        public bool recorded { get; set; } = false;
        public string email { get; set; }
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
        public FingerPrintScanner(DbName dbName)
        {
            InitializeComponent();
            kDbName = dbName.ToString();
            this.m_bInitializationSuccess = false;
            // Create FutronicEnrollment object for retrieve default values only
            FutronicEnrollment dummy = new FutronicEnrollment();
            FingerprintConfig.FARNLevel = (int)dummy.FARnLevel;
            FingerprintConfig.MaxModels = dummy.MaxModels;
            FingerprintConfig.detectFakeFinger = dummy.FakeDetection;
            FingerprintConfig.MIOT = dummy.MIOTControlOff;
            FingerprintConfig.FastMode = dummy.FastMode;
            FingerprintConfig.identificationLimit = dummy.IdentificationsLeft;
            FingerprintConfig.version = dummy.Version;
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

        private void FingerPrintScanner_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, 
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            checkEmail();
        }

        private void checkEmail()
        {
            if (email.Length < 5)
            {
                showErrorMessage("You can only register with valid email");
            }
            else
            {
                btnScan.Enabled = true;
            }
        }

        private void showErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text, 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            DbRecord User = new DbRecord();
            string UserName = email;

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
            }
            else
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

            // register events
            m_Operation.OnPutOn += new OnPutOnHandler(this.OnPutOn);
            m_Operation.OnTakeOff += new OnTakeOffHandler(this.OnTakeOff);
            m_Operation.UpdateScreenImage += new UpdateScreenImageHandler(this.UpdateScreenImage);
            m_Operation.OnFakeSource += new OnFakeSourceHandler(this.OnFakeSource);
            ((FutronicEnrollment)m_Operation).OnEnrollmentComplete += new OnEnrollmentCompleteHandler(this.OnEnrollmentComplete);
            EnableControls(false);
            // start enrollment process
            ((FutronicEnrollment)m_Operation).Enrollment();
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
            recorded = true;
        }

        private void EnableControls(bool bEnable)
        {
            // Do not change the state control during application closing.
            if (m_bExit)
                return;
            if (this.InvokeRequired)
            {
                EnableControlsCallback d = new EnableControlsCallback(this.EnableControls);
                this.Invoke(d, new object[] { bEnable });
            }
            else
            {
                btnFinish.Enabled = bEnable;
                btnScan.Enabled = bEnable;
                btnStop.Enabled = !bEnable;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            m_Operation.OnCalcel();
        }
    }
}
