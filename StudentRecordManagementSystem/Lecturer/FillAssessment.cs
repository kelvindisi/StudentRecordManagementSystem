using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using DataAccess.Managers;
using DataAccess.Models;
using System.Globalization;

namespace StudentRecordManagementSystem.Lecturer
{
    public partial class FillAssessment : MaterialForm
    {
        public int RegistrationId { get; set; }
        public FillAssessment()
        {
            InitializeComponent();
        }

        private void FillAccessment_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            loadStudentData();
            numOutOf.Minimum = 1;
        }

        private void loadStudentData()
        {
            try
            {
                validateRegistrationId();
                getStudentData();
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }


        private void getStudentData()
        {
            StudentScoreAttendanceModel result =
                AttendanceManager.fullInfo(RegistrationId);
            txtFirstName.Text = result.info.FirstName;
            txtSurname.Text = result.info.Surname;
            txtEmail.Text = result.info.Email;
            txtUnitName.Text = result.info.UnitName;
            txtYear.Text = result.info.Year.ToString();
            txtSemester.Text = result.info.Semester.ToString();
            txtSessionsNo.Text = result.attendance.NoOfSessions.ToString();
            txtAttended.Text = result.attendance.Attended.ToString();
            decimal score = result.info.Score;
            decimal outof = result.info.OutOf;
            numScore.Value = score;
            numOutOf.Value = outof;
            txtPercentage.Text= calculatePercentage(score, outof);
        }

        private string calculatePercentage(decimal score, decimal outof)
        {
            decimal percentage = (score * 100)/outof;
            string msg = string.Format(CultureInfo.InvariantCulture, 
                "{0:0.00}", percentage);
            return msg;
        }

        private void validateRegistrationId()
        {
            if (RegistrationId == 0)
                throw new Exception("Cannot retrive data");
        }

        private void showErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void numScore_ValueChanged(object sender, EventArgs e)
        {
            decimal score = numScore.Value;
            decimal outof = numOutOf.Value;
            txtPercentage.Text = calculatePercentage(score, outof);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int score = (int)Math.Ceiling(numScore.Value);
                int outof = (int)Math.Ceiling(numOutOf.Value);
                validateValues(score, outof);
                AttendanceManager.saveScore(RegistrationId, score, outof);
                loadStudentData();
                MessageBox.Show("Saved record successfully", this.Text,
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void validateValues(int score, int outof)
        {
            if (score > outof)
                throw new Exception("Score can't be greater than maximum score");
        }
    }
}
