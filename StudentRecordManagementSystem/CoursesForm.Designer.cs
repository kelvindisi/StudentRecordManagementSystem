namespace StudentRecordManagementSystem
{
    partial class CoursesForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dtGridCourses = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.txtSemesters = new System.Windows.Forms.NumericUpDown();
            this.lblNoOfSemesters = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManageUnits = new System.Windows.Forms.Button();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCourseCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCourseCode = new MaterialSkin.Controls.MaterialLabel();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblCourse = new MaterialSkin.Controls.MaterialLabel();
            this.txtCourse = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboDepartments = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCourses)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSemesters)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Enabled = false;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(896, 60);
            this.topPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dtGridCourses);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(896, 444);
            this.mainPanel.TabIndex = 1;
            // 
            // dtGridCourses
            // 
            this.dtGridCourses.AllowUserToAddRows = false;
            this.dtGridCourses.AllowUserToDeleteRows = false;
            this.dtGridCourses.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.course,
            this.courseCode,
            this.semesters,
            this.department});
            this.dtGridCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridCourses.Location = new System.Drawing.Point(0, 0);
            this.dtGridCourses.Name = "dtGridCourses";
            this.dtGridCourses.ReadOnly = true;
            this.dtGridCourses.Size = new System.Drawing.Size(896, 444);
            this.dtGridCourses.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "No";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // course
            // 
            this.course.HeaderText = "Course";
            this.course.Name = "course";
            this.course.ReadOnly = true;
            this.course.Width = 150;
            // 
            // courseCode
            // 
            this.courseCode.HeaderText = "Course-Code";
            this.courseCode.Name = "courseCode";
            this.courseCode.ReadOnly = true;
            this.courseCode.Width = 150;
            // 
            // semesters
            // 
            this.semesters.HeaderText = "Semesters";
            this.semesters.Name = "semesters";
            this.semesters.ReadOnly = true;
            // 
            // department
            // 
            this.department.HeaderText = "Department";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            this.department.Width = 150;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.txtSemesters);
            this.leftPanel.Controls.Add(this.lblNoOfSemesters);
            this.leftPanel.Controls.Add(this.panel1);
            this.leftPanel.Controls.Add(this.btnUpdate);
            this.leftPanel.Controls.Add(this.txtCourseCode);
            this.leftPanel.Controls.Add(this.lblCourseCode);
            this.leftPanel.Controls.Add(this.btnSave);
            this.leftPanel.Controls.Add(this.lblCourse);
            this.leftPanel.Controls.Add(this.txtCourse);
            this.leftPanel.Controls.Add(this.cboDepartments);
            this.leftPanel.Controls.Add(this.lblDepartment);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.leftPanel.Location = new System.Drawing.Point(599, 60);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(297, 444);
            this.leftPanel.TabIndex = 2;
            // 
            // txtSemesters
            // 
            this.txtSemesters.Location = new System.Drawing.Point(31, 186);
            this.txtSemesters.Name = "txtSemesters";
            this.txtSemesters.Size = new System.Drawing.Size(147, 26);
            this.txtSemesters.TabIndex = 11;
            // 
            // lblNoOfSemesters
            // 
            this.lblNoOfSemesters.AutoSize = true;
            this.lblNoOfSemesters.Depth = 0;
            this.lblNoOfSemesters.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNoOfSemesters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoOfSemesters.Location = new System.Drawing.Point(28, 164);
            this.lblNoOfSemesters.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNoOfSemesters.Name = "lblNoOfSemesters";
            this.lblNoOfSemesters.Size = new System.Drawing.Size(184, 19);
            this.lblNoOfSemesters.TabIndex = 10;
            this.lblNoOfSemesters.Text = "Duration|No of Semesters";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnManageUnits);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 94);
            this.panel1.TabIndex = 9;
            // 
            // btnManageUnits
            // 
            this.btnManageUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageUnits.Enabled = false;
            this.btnManageUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUnits.ForeColor = System.Drawing.Color.White;
            this.btnManageUnits.Location = new System.Drawing.Point(31, 3);
            this.btnManageUnits.Name = "btnManageUnits";
            this.btnManageUnits.Size = new System.Drawing.Size(238, 45);
            this.btnManageUnits.TabIndex = 0;
            this.btnManageUnits.Text = "Manage Units";
            this.btnManageUnits.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(32, 260);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(238, 36);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Depth = 0;
            this.txtCourseCode.Hint = "";
            this.txtCourseCode.Location = new System.Drawing.Point(31, 138);
            this.txtCourseCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.PasswordChar = '\0';
            this.txtCourseCode.SelectedText = "";
            this.txtCourseCode.SelectionLength = 0;
            this.txtCourseCode.SelectionStart = 0;
            this.txtCourseCode.Size = new System.Drawing.Size(238, 23);
            this.txtCourseCode.TabIndex = 7;
            this.txtCourseCode.UseSystemPasswordChar = false;
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Depth = 0;
            this.lblCourseCode.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCourseCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCourseCode.Location = new System.Drawing.Point(28, 116);
            this.lblCourseCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(96, 19);
            this.lblCourseCode.TabIndex = 6;
            this.lblCourseCode.Text = "Course Code";
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(32, 218);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(238, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Depth = 0;
            this.lblCourse.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCourse.Location = new System.Drawing.Point(27, 68);
            this.lblCourse.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(101, 19);
            this.lblCourse.TabIndex = 3;
            this.lblCourse.Text = "Course Name";
            // 
            // txtCourse
            // 
            this.txtCourse.Depth = 0;
            this.txtCourse.Hint = "";
            this.txtCourse.Location = new System.Drawing.Point(31, 90);
            this.txtCourse.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.PasswordChar = '\0';
            this.txtCourse.SelectedText = "";
            this.txtCourse.SelectionLength = 0;
            this.txtCourse.SelectionStart = 0;
            this.txtCourse.Size = new System.Drawing.Size(239, 23);
            this.txtCourse.TabIndex = 2;
            this.txtCourse.UseSystemPasswordChar = false;
            // 
            // cboDepartments
            // 
            this.cboDepartments.FormattingEnabled = true;
            this.cboDepartments.Location = new System.Drawing.Point(31, 37);
            this.cboDepartments.Name = "cboDepartments";
            this.cboDepartments.Size = new System.Drawing.Size(239, 28);
            this.cboDepartments.TabIndex = 1;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Depth = 0;
            this.lblDepartment.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDepartment.Location = new System.Drawing.Point(28, 15);
            this.lblDepartment.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(87, 19);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Department";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 504);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CoursesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoursesForm";
            this.Load += new System.EventHandler(this.CoursesForm_Load);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCourses)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSemesters)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView dtGridCourses;
        private System.Windows.Forms.Panel leftPanel;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialLabel lblCourse;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCourse;
        private System.Windows.Forms.ComboBox cboDepartments;
        private MaterialSkin.Controls.MaterialLabel lblDepartment;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCourseCode;
        private MaterialSkin.Controls.MaterialLabel lblCourseCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnManageUnits;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown txtSemesters;
        private MaterialSkin.Controls.MaterialLabel lblNoOfSemesters;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesters;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
    }
}