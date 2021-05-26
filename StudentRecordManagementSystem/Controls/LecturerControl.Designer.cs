namespace StudentRecordManagementSystem
{
    partial class LecturerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerControl));
            this.btnAttendanceReports = new System.Windows.Forms.Button();
            this.btnAssessment = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAttendanceReports
            // 
            this.btnAttendanceReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAttendanceReports.FlatAppearance.BorderSize = 0;
            this.btnAttendanceReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendanceReports.ForeColor = System.Drawing.Color.White;
            this.btnAttendanceReports.Image = ((System.Drawing.Image)(resources.GetObject("btnAttendanceReports.Image")));
            this.btnAttendanceReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendanceReports.Location = new System.Drawing.Point(286, 198);
            this.btnAttendanceReports.Name = "btnAttendanceReports";
            this.btnAttendanceReports.Size = new System.Drawing.Size(226, 68);
            this.btnAttendanceReports.TabIndex = 6;
            this.btnAttendanceReports.Text = "    Attendance Reports";
            this.btnAttendanceReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttendanceReports.UseVisualStyleBackColor = false;
            // 
            // btnAssessment
            // 
            this.btnAssessment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.btnAssessment.FlatAppearance.BorderSize = 0;
            this.btnAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssessment.ForeColor = System.Drawing.Color.White;
            this.btnAssessment.Image = ((System.Drawing.Image)(resources.GetObject("btnAssessment.Image")));
            this.btnAssessment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssessment.Location = new System.Drawing.Point(34, 198);
            this.btnAssessment.Name = "btnAssessment";
            this.btnAssessment.Size = new System.Drawing.Size(226, 68);
            this.btnAssessment.TabIndex = 5;
            this.btnAssessment.Text = "    Assessment";
            this.btnAssessment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAssessment.UseVisualStyleBackColor = false;
            this.btnAssessment.Click += new System.EventHandler(this.btnAssessment_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.Indigo;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Image = ((System.Drawing.Image)(resources.GetObject("btnCourses.Image")));
            this.btnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.Location = new System.Drawing.Point(34, 104);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(226, 68);
            this.btnCourses.TabIndex = 3;
            this.btnCourses.Text = "    Assigned Units";
            this.btnCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.Black;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Image = ((System.Drawing.Image)(resources.GetObject("btnAttendance.Image")));
            this.btnAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.Location = new System.Drawing.Point(286, 104);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(226, 68);
            this.btnAttendance.TabIndex = 4;
            this.btnAttendance.Text = "    Take Attendance";
            this.btnAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // LecturerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAttendanceReports);
            this.Controls.Add(this.btnAssessment);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnAttendance);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LecturerControl";
            this.Size = new System.Drawing.Size(552, 420);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAttendanceReports;
        private System.Windows.Forms.Button btnAssessment;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnAttendance;
    }
}
