using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using StudentRecordManagementSystem.Common;

namespace StudentRecordManagementSystem.Department
{
    public partial class CourseManagerOption : MaterialForm
    {
        internal int courseId;
        internal int departmentId;

        public CourseManagerOption()
        {
            InitializeComponent();
        }

        private void CourseManagerOption_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, 
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnEnrollStudent_Click(object sender, EventArgs e)
        {
            EnrollStudent stud = new EnrollStudent();
            stud.courseId = courseId;
            stud.ShowDialog();
        }

        private void btnSessionUnits_Click(object sender, EventArgs e)
        {
            try
            {
                SessionPick selectedSession = new SessionPick();
                selectedSession.ShowDialog();
                int sessionId = selectedSession.session.ID;
                validateSelectedSession(sessionId);
                SessionCourseUnitList units = new SessionCourseUnitList();
                units.sessionId = sessionId;
                units.courseId = courseId;
                units.Show();                
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void validateSelectedSession(int sessionId)
        {
            if (sessionId == 0)
                throw new Exception("Please choose session to continue");
        }

        private void showErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRegisterUnit_Click(object sender, EventArgs e)
        {
            try
            {
                int sessionId = getSessionId();
                RegisterUnits formRegister = new RegisterUnits();
                formRegister.sessionId = sessionId;
                formRegister.courseId = courseId;
                formRegister.Show();
            }catch(Exception ex)
            {
                showErrorMessage(ex.Message);
            }

        }

        private int getSessionId()
        {
            SessionPick selectedSession = new SessionPick();
            selectedSession.ShowDialog();
            int sessionId = selectedSession.session.ID;
            validateSelectedSession(sessionId);

            return sessionId;
        }
    }
}
