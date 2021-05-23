using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using DataAccess.Models;
using System.Windows.Forms;
using DataAccess;

namespace StudentRecordManagementSystem.Department
{
    public partial class EnrollStudent : MaterialForm
    {
        public int departmentId { get; set; }
        public int courseId { get; set; }
        public BioDataModel bioData { get; set; }
        public CourseModel course { get; set; }
        public EnrollStudent()
        {
            InitializeComponent();
        }

        private void EnrollStudent_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, 
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            getCourse();
        }
        public void getCourse()
        {
            try
            {
                checkValidity();
                course = CourseManager.getCourseById(courseId);
                updateCourseDetails();
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void updateCourseDetails()
        {
            txtCourse.Text = course.CourseName.ToUpper();
            txtCourseCode.Text = course.CourseCode.ToUpper();
        }

        private void checkValidity()
        {
            if (!(courseId > 0))
                throw new Exception("Course is not valid");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                validateInput();
                string email = txtSearch.Text;
                bioData = StudentManager.getBioByEmail(email);
                updateFormBio();
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void updateFormBio()
        {
            if (bioData.ID == 0)
                throw new Exception("No record found.");

            txtFirstName.Text = bioData.PFirstName.ToUpper();
            txtSurname.Text = bioData.PSurname.ToUpper();
            txtGender.Text = bioData.PGender.ToUpper();
            txtPassport.Text = bioData.PPassport.ToUpper();
        }

        private void validateInput()
        {
            if (txtSearch.Text.Length < 5)
                throw new Exception("Enter valid email");
        }

        private void showErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text, 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateStudentBio();
                validateRegNo();
                EnrollmentModel enroll = getEnrollment();
                EnrollmentManager.enroll(enroll);
                showMessage("Enrollment complete");
            }
            catch(NullReferenceException)
            {
                showErrorMessage("Ensure student and course details have been selected");
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void ValidateStudentBio()
        {
            if (bioData.ID == 0)
                throw new Exception("Select student first before you enroll.");
        }

        private EnrollmentModel getEnrollment()
        {
            EnrollmentModel enroll = new EnrollmentModel();
            enroll.RegistrationNo = txtRegNo.Text;
            enroll.Student = bioData;
            enroll.Course = course;
            return enroll;
        }

        private void showMessage(string v)
        {
            MessageBox.Show(v, this.Text, 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void validateRegNo()
        {
            string reg = txtRegNo.Text;
            bool hasHyphen = reg.Contains("-");
            bool hasSlash = reg.Contains("/");
            bool sized = reg.Length > 6 && reg.Length < 15 ? true : false;

            if (!sized || !hasHyphen || !hasSlash)
                throw new Exception("Invalid registration number");
        }
    }
}
