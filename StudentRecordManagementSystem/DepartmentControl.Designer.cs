namespace StudentRecordManagementSystem
{
    partial class DepartmentControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentControl));
            this.btnAssessment = new System.Windows.Forms.Button();
            this.btnAttendanceReport = new System.Windows.Forms.Button();
            this.btnDepartmentCourses = new System.Windows.Forms.Button();
            this.btnEnrollStudent = new System.Windows.Forms.Button();
            this.btnAssignCourse = new System.Windows.Forms.Button();
            this.btnEnrollCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAssessment
            // 
            this.btnAssessment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.btnAssessment.FlatAppearance.BorderSize = 0;
            this.btnAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssessment.ForeColor = System.Drawing.Color.White;
            this.btnAssessment.Image = ((System.Drawing.Image)(resources.GetObject("btnAssessment.Image")));
            this.btnAssessment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssessment.Location = new System.Drawing.Point(286, 187);
            this.btnAssessment.Name = "btnAssessment";
            this.btnAssessment.Size = new System.Drawing.Size(235, 65);
            this.btnAssessment.TabIndex = 1;
            this.btnAssessment.Text = "    Assessment";
            this.btnAssessment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAssessment.UseVisualStyleBackColor = false;
            // 
            // btnAttendanceReport
            // 
            this.btnAttendanceReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAttendanceReport.FlatAppearance.BorderSize = 0;
            this.btnAttendanceReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendanceReport.ForeColor = System.Drawing.Color.White;
            this.btnAttendanceReport.Image = ((System.Drawing.Image)(resources.GetObject("btnAttendanceReport.Image")));
            this.btnAttendanceReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendanceReport.Location = new System.Drawing.Point(33, 187);
            this.btnAttendanceReport.Name = "btnAttendanceReport";
            this.btnAttendanceReport.Size = new System.Drawing.Size(235, 65);
            this.btnAttendanceReport.TabIndex = 2;
            this.btnAttendanceReport.Text = "    Attendance Reports";
            this.btnAttendanceReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttendanceReport.UseVisualStyleBackColor = false;
            // 
            // btnDepartmentCourses
            // 
            this.btnDepartmentCourses.BackColor = System.Drawing.Color.Black;
            this.btnDepartmentCourses.FlatAppearance.BorderSize = 0;
            this.btnDepartmentCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentCourses.ForeColor = System.Drawing.Color.White;
            this.btnDepartmentCourses.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartmentCourses.Image")));
            this.btnDepartmentCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartmentCourses.Location = new System.Drawing.Point(286, 116);
            this.btnDepartmentCourses.Name = "btnDepartmentCourses";
            this.btnDepartmentCourses.Size = new System.Drawing.Size(235, 65);
            this.btnDepartmentCourses.TabIndex = 0;
            this.btnDepartmentCourses.Text = "    Department Courses";
            this.btnDepartmentCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepartmentCourses.UseVisualStyleBackColor = false;
            // 
            // btnEnrollStudent
            // 
            this.btnEnrollStudent.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEnrollStudent.FlatAppearance.BorderSize = 0;
            this.btnEnrollStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollStudent.ForeColor = System.Drawing.Color.White;
            this.btnEnrollStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnEnrollStudent.Image")));
            this.btnEnrollStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnrollStudent.Location = new System.Drawing.Point(33, 45);
            this.btnEnrollStudent.Name = "btnEnrollStudent";
            this.btnEnrollStudent.Size = new System.Drawing.Size(235, 65);
            this.btnEnrollStudent.TabIndex = 3;
            this.btnEnrollStudent.Text = "    New Student";
            this.btnEnrollStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnrollStudent.UseVisualStyleBackColor = false;
            this.btnEnrollStudent.Click += new System.EventHandler(this.btnEnrollStudent_Click);
            // 
            // btnAssignCourse
            // 
            this.btnAssignCourse.BackColor = System.Drawing.Color.Indigo;
            this.btnAssignCourse.FlatAppearance.BorderSize = 0;
            this.btnAssignCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignCourse.ForeColor = System.Drawing.Color.White;
            this.btnAssignCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignCourse.Image")));
            this.btnAssignCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignCourse.Location = new System.Drawing.Point(286, 45);
            this.btnAssignCourse.Name = "btnAssignCourse";
            this.btnAssignCourse.Size = new System.Drawing.Size(235, 65);
            this.btnAssignCourse.TabIndex = 0;
            this.btnAssignCourse.Text = "    Manage Students";
            this.btnAssignCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAssignCourse.UseVisualStyleBackColor = false;
            this.btnAssignCourse.Click += new System.EventHandler(this.btnAssignCourse_Click);
            // 
            // btnEnrollCourse
            // 
            this.btnEnrollCourse.BackColor = System.Drawing.Color.HotPink;
            this.btnEnrollCourse.FlatAppearance.BorderSize = 0;
            this.btnEnrollCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollCourse.ForeColor = System.Drawing.Color.White;
            this.btnEnrollCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnEnrollCourse.Image")));
            this.btnEnrollCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnrollCourse.Location = new System.Drawing.Point(33, 116);
            this.btnEnrollCourse.Name = "btnEnrollCourse";
            this.btnEnrollCourse.Size = new System.Drawing.Size(235, 65);
            this.btnEnrollCourse.TabIndex = 0;
            this.btnEnrollCourse.Text = "    Enroll Course";
            this.btnEnrollCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnrollCourse.UseVisualStyleBackColor = false;
            // 
            // DepartmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEnrollStudent);
            this.Controls.Add(this.btnAttendanceReport);
            this.Controls.Add(this.btnAssessment);
            this.Controls.Add(this.btnEnrollCourse);
            this.Controls.Add(this.btnDepartmentCourses);
            this.Controls.Add(this.btnAssignCourse);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DepartmentControl";
            this.Size = new System.Drawing.Size(552, 420);
            this.Load += new System.EventHandler(this.DepartmentControl_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAssessment;
        private System.Windows.Forms.Button btnAttendanceReport;
        private System.Windows.Forms.Button btnDepartmentCourses;
        private System.Windows.Forms.Button btnEnrollStudent;
        private System.Windows.Forms.Button btnAssignCourse;
        private System.Windows.Forms.Button btnEnrollCourse;
    }
}
