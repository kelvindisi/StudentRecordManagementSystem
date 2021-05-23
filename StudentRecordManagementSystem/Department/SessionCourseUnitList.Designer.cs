namespace StudentRecordManagementSystem.Department
{
    partial class SessionCourseUnitList
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
            this.dtGridCourses = new System.Windows.Forms.DataGridView();
            this.sessUnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.added = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Enabled = false;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1031, 79);
            this.topPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.dtGridCourses);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 79);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1031, 477);
            this.mainPanel.TabIndex = 1;
            // 
            // dtGridCourses
            // 
            this.dtGridCourses.AllowUserToAddRows = false;
            this.dtGridCourses.AllowUserToDeleteRows = false;
            this.dtGridCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessUnitId,
            this.added,
            this.UnitId,
            this.unitCode,
            this.unitName,
            this.semester,
            this.lecturer});
            this.dtGridCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridCourses.Location = new System.Drawing.Point(0, 0);
            this.dtGridCourses.Name = "dtGridCourses";
            this.dtGridCourses.RowTemplate.Height = 28;
            this.dtGridCourses.Size = new System.Drawing.Size(1031, 477);
            this.dtGridCourses.TabIndex = 0;
            // 
            // sessUnitId
            // 
            this.sessUnitId.HeaderText = "Session Unit Id";
            this.sessUnitId.Name = "sessUnitId";
            // 
            // added
            // 
            this.added.HeaderText = "Active";
            this.added.Name = "added";
            this.added.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.added.Width = 150;
            // 
            // UnitId
            // 
            this.UnitId.HeaderText = "Unit ID";
            this.UnitId.Name = "UnitId";
            this.UnitId.ReadOnly = true;
            // 
            // unitCode
            // 
            this.unitCode.HeaderText = "Unit Code";
            this.unitCode.Name = "unitCode";
            this.unitCode.Width = 200;
            // 
            // unitName
            // 
            this.unitName.HeaderText = "Unit Name";
            this.unitName.Name = "unitName";
            this.unitName.Width = 400;
            // 
            // semester
            // 
            this.semester.HeaderText = "Semester";
            this.semester.Name = "semester";
            // 
            // lecturer
            // 
            this.lecturer.HeaderText = "Lecturer";
            this.lecturer.Name = "lecturer";
            // 
            // SessionCourseUnitList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 556);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "SessionCourseUnitList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseUnitList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CourseUnitList_Load);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView dtGridCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessUnitId;
        private System.Windows.Forms.DataGridViewButtonColumn added;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturer;
    }
}