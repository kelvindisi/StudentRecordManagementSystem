using DataAccess.Managers;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRecordManagementSystem.ReportsLecturer
{
    public partial class AttendanceRpt : Form
    {
        internal int totalSessions;
        internal int selected_sess_unit;
        internal int sessionId;

        public AttendanceRpt()
        {
            InitializeComponent();
        }
        private DataSet fillReportDataTable()
        {
            DataSet ds = new DataSet();
            ds.ReadXmlSchema("student_record_sytem.xsd");

            if (ds.Tables.Contains("attendance"))
            {
                DataTable dt = ds.Tables["attendance"];
                //firstName, secondName, attended, percentage
                List<AttendanceSummary> attendance;
                attendance = AttendanceManager
                    .getSessionAttendance(sessionId, selected_sess_unit, totalSessions);
                foreach(AttendanceSummary summary in  attendance)
                {
                    DataRow student = dt.NewRow();
                    dt.Rows.Add(new String[] {summary.firstName, summary.secondName,
                        summary.attended.ToString(), summary.percentage().ToString()});
                }
                
                ds.Tables.Remove("attendance");
                ds.Tables.Add(dt);
            }

            return ds;
        }
        private void AttendanceRpt_Load(object sender, EventArgs e)
        {
            try
            {
                SummaryAttendanceRpt report = new SummaryAttendanceRpt();
                DataSet ds = fillReportDataTable();
                report.Refresh();
                report.SetDataSource(ds);
                report.SetParameterValue("totalSessions", totalSessions.ToString());
                attendanceViewer.ReportSource = report;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
