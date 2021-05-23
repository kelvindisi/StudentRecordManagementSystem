namespace StudentRecordManagementSystem.Controls
{
    partial class DepartmentCourseManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentCourseManager));
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnDepartmentCourses = new System.Windows.Forms.Button();
            this.btnAssignCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnroll
            // 
            this.btnEnroll.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEnroll.FlatAppearance.BorderSize = 0;
            this.btnEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnroll.ForeColor = System.Drawing.Color.White;
            this.btnEnroll.Image = ((System.Drawing.Image)(resources.GetObject("btnEnroll.Image")));
            this.btnEnroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnroll.Location = new System.Drawing.Point(33, 45);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(235, 65);
            this.btnEnroll.TabIndex = 9;
            this.btnEnroll.Text = "    Enroll";
            this.btnEnroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnroll.UseVisualStyleBackColor = false;
            // 
            // btnDepartmentCourses
            // 
            this.btnDepartmentCourses.BackColor = System.Drawing.Color.Black;
            this.btnDepartmentCourses.FlatAppearance.BorderSize = 0;
            this.btnDepartmentCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentCourses.ForeColor = System.Drawing.Color.White;
            this.btnDepartmentCourses.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartmentCourses.Image")));
            this.btnDepartmentCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartmentCourses.Location = new System.Drawing.Point(33, 116);
            this.btnDepartmentCourses.Name = "btnDepartmentCourses";
            this.btnDepartmentCourses.Size = new System.Drawing.Size(235, 65);
            this.btnDepartmentCourses.TabIndex = 5;
            this.btnDepartmentCourses.Text = "    Student List";
            this.btnDepartmentCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepartmentCourses.UseVisualStyleBackColor = false;
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
            this.btnAssignCourse.TabIndex = 6;
            this.btnAssignCourse.Text = "    Academic Registry";
            this.btnAssignCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAssignCourse.UseVisualStyleBackColor = false;
            // 
            // DepartmentCourseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.btnDepartmentCourses);
            this.Controls.Add(this.btnAssignCourse);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DepartmentCourseManager";
            this.Size = new System.Drawing.Size(552, 420);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btnDepartmentCourses;
        private System.Windows.Forms.Button btnAssignCourse;
    }
}
