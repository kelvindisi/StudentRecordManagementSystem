namespace StudentRecordManagementSystem.ReportsLecturer
{
    partial class AttendanceRpt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SummaryAttendanceRpt1 = new StudentRecordManagementSystem.ReportsLecturer.SummaryAttendanceRpt();
            this.attendanceViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // attendanceViewer
            // 
            this.attendanceViewer.ActiveViewIndex = -1;
            this.attendanceViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attendanceViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.attendanceViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendanceViewer.Location = new System.Drawing.Point(0, 0);
            this.attendanceViewer.Name = "attendanceViewer";
            this.attendanceViewer.Size = new System.Drawing.Size(927, 433);
            this.attendanceViewer.TabIndex = 0;
            this.attendanceViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // AttendanceRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 433);
            this.Controls.Add(this.attendanceViewer);
            this.Name = "AttendanceRpt";
            this.Text = "AttendanceRpt";
            this.Load += new System.EventHandler(this.AttendanceRpt_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private SummaryAttendanceRpt SummaryAttendanceRpt1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer attendanceViewer;
    }
}