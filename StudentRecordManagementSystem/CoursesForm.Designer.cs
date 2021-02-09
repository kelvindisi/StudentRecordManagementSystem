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
            this.topPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dtCourses = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btnClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblCourse = new MaterialSkin.Controls.MaterialLabel();
            this.txtCourse = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboDepartments = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new MaterialSkin.Controls.MaterialLabel();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCourses)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Enabled = false;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(858, 60);
            this.topPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dtCourses);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(858, 444);
            this.mainPanel.TabIndex = 1;
            // 
            // dtCourses
            // 
            this.dtCourses.AllowUserToAddRows = false;
            this.dtCourses.AllowUserToDeleteRows = false;
            this.dtCourses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.department,
            this.course});
            this.dtCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtCourses.Location = new System.Drawing.Point(0, 0);
            this.dtCourses.Name = "dtCourses";
            this.dtCourses.ReadOnly = true;
            this.dtCourses.Size = new System.Drawing.Size(858, 444);
            this.dtCourses.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "No";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // department
            // 
            this.department.HeaderText = "Department";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            this.department.Width = 150;
            // 
            // course
            // 
            this.course.HeaderText = "Course";
            this.course.Name = "course";
            this.course.ReadOnly = true;
            this.course.Width = 270;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.btnClear);
            this.leftPanel.Controls.Add(this.btnSave);
            this.leftPanel.Controls.Add(this.lblCourse);
            this.leftPanel.Controls.Add(this.txtCourse);
            this.leftPanel.Controls.Add(this.cboDepartments);
            this.leftPanel.Controls.Add(this.lblDepartment);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.leftPanel.Location = new System.Drawing.Point(561, 60);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(297, 444);
            this.leftPanel.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Depth = 0;
            this.btnClear.Location = new System.Drawing.Point(135, 169);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = false;
            this.btnClear.Size = new System.Drawing.Size(54, 36);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(32, 169);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(96, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Depth = 0;
            this.lblCourse.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCourse.Location = new System.Drawing.Point(27, 118);
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
            this.txtCourse.Location = new System.Drawing.Point(31, 140);
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
            this.cboDepartments.Location = new System.Drawing.Point(31, 87);
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
            this.lblDepartment.Location = new System.Drawing.Point(28, 65);
            this.lblDepartment.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(87, 19);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Department";
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 504);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtCourses)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView dtCourses;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private MaterialSkin.Controls.MaterialFlatButton btnClear;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialLabel lblCourse;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCourse;
        private System.Windows.Forms.ComboBox cboDepartments;
        private MaterialSkin.Controls.MaterialLabel lblDepartment;
    }
}