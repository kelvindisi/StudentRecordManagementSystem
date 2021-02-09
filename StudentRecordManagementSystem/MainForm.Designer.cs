namespace StudentRecordManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.activeMenu = new System.Windows.Forms.Panel();
            this.btnHospital = new System.Windows.Forms.Button();
            this.btnLecturer = new System.Windows.Forms.Button();
            this.btnDepartmentAdmin = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSignOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminControl = new StudentRecordManagementSystem.AdminControl();
            this.dashboardControl = new StudentRecordManagementSystem.Dashboard();
            this.departmentControl = new StudentRecordManagementSystem.DepartmentControl();
            this.lecturerControl = new StudentRecordManagementSystem.LecturerControl();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.activeMenu);
            this.panel1.Controls.Add(this.btnHospital);
            this.panel1.Controls.Add(this.btnLecturer);
            this.panel1.Controls.Add(this.btnDepartmentAdmin);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 467);
            this.panel1.TabIndex = 0;
            // 
            // activeMenu
            // 
            this.activeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.activeMenu.Location = new System.Drawing.Point(0, 63);
            this.activeMenu.Name = "activeMenu";
            this.activeMenu.Size = new System.Drawing.Size(7, 66);
            this.activeMenu.TabIndex = 2;
            // 
            // btnHospital
            // 
            this.btnHospital.FlatAppearance.BorderSize = 0;
            this.btnHospital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHospital.ForeColor = System.Drawing.Color.White;
            this.btnHospital.Image = ((System.Drawing.Image)(resources.GetObject("btnHospital.Image")));
            this.btnHospital.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHospital.Location = new System.Drawing.Point(3, 351);
            this.btnHospital.Name = "btnHospital";
            this.btnHospital.Size = new System.Drawing.Size(232, 66);
            this.btnHospital.TabIndex = 4;
            this.btnHospital.Text = "    Hospital";
            this.btnHospital.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHospital.UseVisualStyleBackColor = true;
            this.btnHospital.Visible = false;
            this.btnHospital.Click += new System.EventHandler(this.btnHospital_Click);
            // 
            // btnLecturer
            // 
            this.btnLecturer.FlatAppearance.BorderSize = 0;
            this.btnLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecturer.ForeColor = System.Drawing.Color.White;
            this.btnLecturer.Image = ((System.Drawing.Image)(resources.GetObject("btnLecturer.Image")));
            this.btnLecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLecturer.Location = new System.Drawing.Point(3, 279);
            this.btnLecturer.Name = "btnLecturer";
            this.btnLecturer.Size = new System.Drawing.Size(232, 66);
            this.btnLecturer.TabIndex = 3;
            this.btnLecturer.Text = "    Lecturer";
            this.btnLecturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLecturer.UseVisualStyleBackColor = true;
            this.btnLecturer.Click += new System.EventHandler(this.btnLecturer_Click);
            // 
            // btnDepartmentAdmin
            // 
            this.btnDepartmentAdmin.FlatAppearance.BorderSize = 0;
            this.btnDepartmentAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentAdmin.ForeColor = System.Drawing.Color.White;
            this.btnDepartmentAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartmentAdmin.Image")));
            this.btnDepartmentAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartmentAdmin.Location = new System.Drawing.Point(3, 207);
            this.btnDepartmentAdmin.Name = "btnDepartmentAdmin";
            this.btnDepartmentAdmin.Size = new System.Drawing.Size(232, 66);
            this.btnDepartmentAdmin.TabIndex = 2;
            this.btnDepartmentAdmin.Text = "    Department Admin";
            this.btnDepartmentAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepartmentAdmin.UseVisualStyleBackColor = true;
            this.btnDepartmentAdmin.Click += new System.EventHandler(this.btnDepartmentAdmin_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(3, 135);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(232, 66);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "    Admin";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 63);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(232, 66);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "    Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 11);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.toolStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(552, 30);
            this.panel4.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSignOut,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(552, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSignOut
            // 
            this.btnSignOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(23, 22);
            this.btnSignOut.Text = "Sign-Out";
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabel1.Text = "Kelvin Ndisi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(238, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 42);
            this.panel2.TabIndex = 1;
            // 
            // adminControl
            // 
            this.adminControl.AutoSize = true;
            this.adminControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminControl.Location = new System.Drawing.Point(238, 41);
            this.adminControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminControl.Name = "adminControl";
            this.adminControl.Size = new System.Drawing.Size(552, 426);
            this.adminControl.TabIndex = 3;
            // 
            // dashboardControl
            // 
            this.dashboardControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardControl.Location = new System.Drawing.Point(238, 47);
            this.dashboardControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboardControl.Name = "dashboardControl";
            this.dashboardControl.Size = new System.Drawing.Size(552, 420);
            this.dashboardControl.TabIndex = 2;
            // 
            // departmentControl
            // 
            this.departmentControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentControl.Location = new System.Drawing.Point(238, 47);
            this.departmentControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departmentControl.Name = "departmentControl";
            this.departmentControl.Size = new System.Drawing.Size(552, 420);
            this.departmentControl.TabIndex = 4;
            // 
            // lecturerControl
            // 
            this.lecturerControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerControl.Location = new System.Drawing.Point(238, 47);
            this.lecturerControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lecturerControl.Name = "lecturerControl";
            this.lecturerControl.Size = new System.Drawing.Size(552, 420);
            this.lecturerControl.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 467);
            this.Controls.Add(this.lecturerControl);
            this.Controls.Add(this.departmentControl);
            this.Controls.Add(this.adminControl);
            this.Controls.Add(this.dashboardControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrom";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSignOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHospital;
        private System.Windows.Forms.Button btnLecturer;
        private System.Windows.Forms.Button btnDepartmentAdmin;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel activeMenu;
        private Dashboard dashboardControl;
        private AdminControl adminControl;
        private DepartmentControl departmentControl;
        private LecturerControl lecturerControl;
    }
}