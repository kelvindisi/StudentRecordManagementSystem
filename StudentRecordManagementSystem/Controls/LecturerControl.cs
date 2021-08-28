using System;
using System.Windows.Forms;
using StudentRecordManagementSystem.Common;
using DataAccess.Models;
using StudentRecordManagementSystem.Lecturer;
using DataAccess;
using StudentRecordManagementSystem.ReportsLecturer;
using System.Data;

namespace StudentRecordManagementSystem
{
    public partial class LecturerControl : UserControl
    {
        public static int staffId { get; set; }
        public LecturerControl()
        {
            InitializeComponent();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            try
            {
                int sessionId = getSession();
                if (sessionId == 0)
                    return;
                SessionUnits units = new SessionUnits();
                units.session_id = sessionId;
                units.lecturer_id = staffId;
                units.ShowDialog();
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.StackTrace);
            }

        }

        private int getSession()
        {
            int session = 0;
            SessionPick selector = new SessionPick();
            DialogResult rs = selector.ShowDialog(this);
            if (rs == DialogResult.OK)
            {
                SessionModel sess = selector.session;
                session = sess.ID;
                validateSession(session);
            }

            return session;

        }

        private void validateSession(int session)
        {
            if (session == 0)
                throw new Exception("Please select valid session");
        }

        private void showErrorMessage(string message)
        {
            MessageBox.Show(message, "Lecturer",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                int sessionId = getSession();
                if (sessionId == 0)
                    return;
                int selected_sess_unit = chooseUnit(sessionId);
                if (selected_sess_unit == 0)
                    return;
                showAttendanceForm(selected_sess_unit, true);
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }

        private void showAttendanceForm(int selected_sess_unit, bool attendance)
        {
            SessionUnitStudentList list = new SessionUnitStudentList();
            list.takeAttendance = attendance;
            list.sess_unit_id = selected_sess_unit;
            list.lecturerId = staffId;
            list.ShowDialog(this);
        }

        private int chooseUnit(int sessionId)
        {
            SessionUnits units = new SessionUnits();
            units.session_id = sessionId;
            units.lecturer_id = staffId;
            units.dblClickable = true;
            units.ShowDialog();

            return units.selected_sess_unit;
        }

        private void btnAssessment_Click(object sender, EventArgs e)
        {
            try
            {
                int sessionId = getSession();
                if (sessionId == 0)
                    return;
                int selected_sess_unit = chooseUnit(sessionId);
                if (selected_sess_unit == 0)
                    return;
                showAttendanceForm(selected_sess_unit, false);
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }
        
        private void btnAttendanceReports_Click(object sender, EventArgs e)
        {
            try
            {
                int sessionId = getSession();
                if (sessionId == 0)
                    return;
                int selected_sess_unit = chooseUnit(sessionId);
                if (selected_sess_unit == 0)
                    return;
                int totalSessions = SessionUnitManager
                    .getTotalSessionCount(selected_sess_unit);
                // display form with report viewer
                AttendanceRpt view = new AttendanceRpt();
                view.selected_sess_unit = selected_sess_unit;
                view.sessionId = sessionId;
                view.totalSessions = totalSessions;
                view.ShowDialog();
                
            }
            catch (Exception ex)
            {
                showErrorMessage(ex.Message);
            }
        }
    }
}
