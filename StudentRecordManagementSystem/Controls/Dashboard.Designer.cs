namespace StudentRecordManagementSystem
{
    partial class Dashboard
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
            this.checkAdmin = new System.Windows.Forms.CheckBox();
            this.checkDepartmentAdmin = new System.Windows.Forms.CheckBox();
            this.checkLecture = new System.Windows.Forms.CheckBox();
            this.lblPermissionsList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkAdmin
            // 
            this.checkAdmin.AutoSize = true;
            this.checkAdmin.Enabled = false;
            this.checkAdmin.Location = new System.Drawing.Point(174, 130);
            this.checkAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkAdmin.Name = "checkAdmin";
            this.checkAdmin.Size = new System.Drawing.Size(107, 33);
            this.checkAdmin.TabIndex = 0;
            this.checkAdmin.Text = "Admin";
            this.checkAdmin.UseVisualStyleBackColor = true;
            // 
            // checkDepartmentAdmin
            // 
            this.checkDepartmentAdmin.AutoSize = true;
            this.checkDepartmentAdmin.Enabled = false;
            this.checkDepartmentAdmin.Location = new System.Drawing.Point(174, 173);
            this.checkDepartmentAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkDepartmentAdmin.Name = "checkDepartmentAdmin";
            this.checkDepartmentAdmin.Size = new System.Drawing.Size(238, 33);
            this.checkDepartmentAdmin.TabIndex = 0;
            this.checkDepartmentAdmin.Text = "Department Admin";
            this.checkDepartmentAdmin.UseVisualStyleBackColor = true;
            // 
            // checkLecture
            // 
            this.checkLecture.AutoSize = true;
            this.checkLecture.Enabled = false;
            this.checkLecture.Location = new System.Drawing.Point(174, 216);
            this.checkLecture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkLecture.Name = "checkLecture";
            this.checkLecture.Size = new System.Drawing.Size(127, 33);
            this.checkLecture.TabIndex = 0;
            this.checkLecture.Text = "Lecturer";
            this.checkLecture.UseVisualStyleBackColor = true;
            // 
            // lblPermissionsList
            // 
            this.lblPermissionsList.AutoSize = true;
            this.lblPermissionsList.Location = new System.Drawing.Point(138, 96);
            this.lblPermissionsList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPermissionsList.Name = "lblPermissionsList";
            this.lblPermissionsList.Size = new System.Drawing.Size(252, 29);
            this.lblPermissionsList.TabIndex = 1;
            this.lblPermissionsList.Text = "Permissions Assigned";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPermissionsList);
            this.Controls.Add(this.checkLecture);
            this.Controls.Add(this.checkDepartmentAdmin);
            this.Controls.Add(this.checkAdmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(552, 420);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkAdmin;
        private System.Windows.Forms.CheckBox checkDepartmentAdmin;
        private System.Windows.Forms.CheckBox checkLecture;
        private System.Windows.Forms.Label lblPermissionsList;
    }
}
