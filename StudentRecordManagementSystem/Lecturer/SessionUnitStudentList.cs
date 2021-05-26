using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Data;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Models;
using DataAccess.Managers;

namespace StudentRecordManagementSystem.Lecturer
{
    public partial class SessionUnitStudentList : MaterialForm
    {
        public int lecturerId { get; set; }
        public int sess_unit_id { get; set; }
        public bool takeAttendance { get; set; } = true;
        public SessionUnitStudentList()
        {
            InitializeComponent();
        }

        private void SessionUnitStudentList_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            initializeGridConfig();
            fillGrid();
        }

        private void fillGrid()
        {
            try
            {
                DataTable table = SessionUnitManager.
                    getSessLecUnits(lecturerId, sess_unit_id, "");
                bindGridData(table);
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void showErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text, 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bindGridData(DataTable table)
        {
            dtGridStudents.DataSource = table;
        }

        private void initializeGridConfig()
        {
            dtGridStudents.AutoGenerateColumns = false;
            dtGridStudents.Columns[0].DataPropertyName = "registered_id";
            dtGridStudents.Columns[1].DataPropertyName = "id";
            dtGridStudents.Columns[2].DataPropertyName = "regNo";
            dtGridStudents.Columns[3].DataPropertyName = "first_name";
            dtGridStudents.Columns[4].DataPropertyName = "surname";
            dtGridStudents.Columns[5].DataPropertyName = "email";

            dtGridStudents.CellDoubleClick += DtGridStudents_CellDoubleClick;
        }

        private void DtGridStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)//selected header
                return;
            if (takeAttendance)
                TakeAttendance(row);
            else
                recordScore(row);
        }

        private void TakeAttendance(int row)
        {
            int sessionId = getSessionId();
            if (sessionId == 0)
                return;
            string email = getEmail(row);
            int registrationId = getRegistrationId(row);
            bool confirmed = confirmFingerPrints(email);
            if (confirmed)
                saveTodaysAttendance(sessionId, registrationId);
        }

        private void saveTodaysAttendance(int sessionId, int registrationId)
        {
            if (AttendanceManager.hasAttendedTodaySession(sessionId, registrationId))
            {
                showErrorMessage("Already took attendance for today.");
                return;
            }
            if (AttendanceManager.saveAttendance(sessionId, registrationId))
            {
                showMessage("Attendance details saved.");
                return;
            }
            throw new Exception("Failed to save attendance.");
        }

        private void showMessage(string v)
        {
            MessageBox.Show(v, this.Text, 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int getRegistrationId(int row)
        {
            int registrationId = (int)dtGridStudents.Rows[row].Cells[0].Value;
            if (registrationId == 0)
                throw new Exception("Cannot validate unit registration, "
                    + "close to refresh.");
            return registrationId;
        }

        private bool confirmFingerPrints(string email)
        {
            FingerprintVerify verifier = new FingerprintVerify(DbName.student);
            verifier.email = email;
            verifier.ShowDialog(this);
            if (!verifier.attemptedVerification)
                return false;
            if (verifier.verified)
                return true;
            showErrorMessage("Failed to verify fingerprint.");
            return false;
        }

        private string getEmail(int row)
        {
            return (string)dtGridStudents.Rows[row].Cells[5].Value;
        }

        private int getSessionId()
        {
            ClassSessionModel sess = AttendanceManager
                .getTodaySession(sess_unit_id);
            if (sess.ID == 0)
                sess = promptToCreateSession();
            return sess.ID;
        }

        private ClassSessionModel promptToCreateSession()
        {
            string msg = "Today session has not been created, "
                + "do you wish to create and continue?";
            string title = "Create session";
            DialogResult rs = MessageBox.Show(msg, title,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                return AttendanceManager.createTodaySession(sess_unit_id);
            return new ClassSessionModel();
        }

        private void recordScore(int row)
        {
            int registrationId = getRegistrationId(row);
            FillAssessment assess = new FillAssessment();
            assess.RegistrationId = registrationId;
            assess.ShowDialog();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtSearch.Text.Trim();
                DataTable table = SessionUnitManager.
                    getSessLecUnits(lecturerId, sess_unit_id, search);
                bindGridData(table);
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }
    }
}
