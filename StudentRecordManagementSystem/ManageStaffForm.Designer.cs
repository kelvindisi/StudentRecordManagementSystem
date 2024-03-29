﻿namespace StudentRecordManagementSystem
{
    partial class ManageStaffForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.formPanel = new System.Windows.Forms.Panel();
            this.lblPasswordInfo = new System.Windows.Forms.Label();
            this.txtConfirmation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblConfirmation = new MaterialSkin.Controls.MaterialLabel();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNewPassword = new MaterialSkin.Controls.MaterialLabel();
            this.txtDepartment = new System.Windows.Forms.ComboBox();
            this.checkDepartmentAdmin = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkLecturer = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkAdmin = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblDepartment = new MaterialSkin.Controls.MaterialLabel();
            this.lblRoles = new MaterialSkin.Controls.MaterialLabel();
            this.rdoOther = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtFirstName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSurname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFirstName = new MaterialSkin.Controls.MaterialLabel();
            this.lblGender = new MaterialSkin.Controls.MaterialLabel();
            this.lblSurname = new MaterialSkin.Controls.MaterialLabel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 66);
            this.panel1.TabIndex = 0;
            // 
            // detailsPanel
            // 
            this.detailsPanel.Controls.Add(this.formPanel);
            this.detailsPanel.Controls.Add(this.buttonPanel);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.detailsPanel.Location = new System.Drawing.Point(642, 66);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(336, 497);
            this.detailsPanel.TabIndex = 1;
            // 
            // formPanel
            // 
            this.formPanel.Controls.Add(this.lblPasswordInfo);
            this.formPanel.Controls.Add(this.txtConfirmation);
            this.formPanel.Controls.Add(this.lblConfirmation);
            this.formPanel.Controls.Add(this.txtPassword);
            this.formPanel.Controls.Add(this.lblNewPassword);
            this.formPanel.Controls.Add(this.txtDepartment);
            this.formPanel.Controls.Add(this.checkDepartmentAdmin);
            this.formPanel.Controls.Add(this.checkLecturer);
            this.formPanel.Controls.Add(this.checkAdmin);
            this.formPanel.Controls.Add(this.lblDepartment);
            this.formPanel.Controls.Add(this.lblRoles);
            this.formPanel.Controls.Add(this.rdoOther);
            this.formPanel.Controls.Add(this.rdoFemale);
            this.formPanel.Controls.Add(this.rdoMale);
            this.formPanel.Controls.Add(this.txtFirstName);
            this.formPanel.Controls.Add(this.txtSurname);
            this.formPanel.Controls.Add(this.lblFirstName);
            this.formPanel.Controls.Add(this.lblGender);
            this.formPanel.Controls.Add(this.lblSurname);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(336, 444);
            this.formPanel.TabIndex = 1;
            // 
            // lblPasswordInfo
            // 
            this.lblPasswordInfo.AutoSize = true;
            this.lblPasswordInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordInfo.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordInfo.Location = new System.Drawing.Point(42, 25);
            this.lblPasswordInfo.Name = "lblPasswordInfo";
            this.lblPasswordInfo.Size = new System.Drawing.Size(249, 13);
            this.lblPasswordInfo.TabIndex = 36;
            this.lblPasswordInfo.Text = "*Leave password blank if you don\'t want to change";
            // 
            // txtConfirmation
            // 
            this.txtConfirmation.Depth = 0;
            this.txtConfirmation.Hint = "";
            this.txtConfirmation.Location = new System.Drawing.Point(49, 415);
            this.txtConfirmation.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConfirmation.Name = "txtConfirmation";
            this.txtConfirmation.PasswordChar = '\0';
            this.txtConfirmation.SelectedText = "";
            this.txtConfirmation.SelectionLength = 0;
            this.txtConfirmation.SelectionStart = 0;
            this.txtConfirmation.Size = new System.Drawing.Size(251, 23);
            this.txtConfirmation.TabIndex = 35;
            this.txtConfirmation.UseSystemPasswordChar = false;
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Depth = 0;
            this.lblConfirmation.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblConfirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConfirmation.Location = new System.Drawing.Point(45, 393);
            this.lblConfirmation.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(133, 19);
            this.lblConfirmation.TabIndex = 34;
            this.lblConfirmation.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "";
            this.txtPassword.Location = new System.Drawing.Point(49, 367);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(251, 23);
            this.txtPassword.TabIndex = 33;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Depth = 0;
            this.lblNewPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNewPassword.Location = new System.Drawing.Point(46, 345);
            this.lblNewPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(109, 19);
            this.lblNewPassword.TabIndex = 32;
            this.lblNewPassword.Text = "New Password";
            // 
            // txtDepartment
            // 
            this.txtDepartment.FormattingEnabled = true;
            this.txtDepartment.Location = new System.Drawing.Point(49, 314);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(247, 28);
            this.txtDepartment.TabIndex = 31;
            // 
            // checkDepartmentAdmin
            // 
            this.checkDepartmentAdmin.AutoSize = true;
            this.checkDepartmentAdmin.Depth = 0;
            this.checkDepartmentAdmin.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkDepartmentAdmin.Location = new System.Drawing.Point(45, 262);
            this.checkDepartmentAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.checkDepartmentAdmin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkDepartmentAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkDepartmentAdmin.Name = "checkDepartmentAdmin";
            this.checkDepartmentAdmin.Ripple = true;
            this.checkDepartmentAdmin.Size = new System.Drawing.Size(146, 30);
            this.checkDepartmentAdmin.TabIndex = 30;
            this.checkDepartmentAdmin.Text = "Department Admin";
            this.checkDepartmentAdmin.UseVisualStyleBackColor = true;
            // 
            // checkLecturer
            // 
            this.checkLecturer.AutoSize = true;
            this.checkLecturer.Depth = 0;
            this.checkLecturer.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkLecturer.Location = new System.Drawing.Point(115, 232);
            this.checkLecturer.Margin = new System.Windows.Forms.Padding(0);
            this.checkLecturer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkLecturer.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkLecturer.Name = "checkLecturer";
            this.checkLecturer.Ripple = true;
            this.checkLecturer.Size = new System.Drawing.Size(81, 30);
            this.checkLecturer.TabIndex = 29;
            this.checkLecturer.Text = "Lecturer";
            this.checkLecturer.UseVisualStyleBackColor = true;
            // 
            // checkAdmin
            // 
            this.checkAdmin.AutoSize = true;
            this.checkAdmin.Depth = 0;
            this.checkAdmin.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkAdmin.Location = new System.Drawing.Point(45, 232);
            this.checkAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.checkAdmin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkAdmin.Name = "checkAdmin";
            this.checkAdmin.Ripple = true;
            this.checkAdmin.Size = new System.Drawing.Size(70, 30);
            this.checkAdmin.TabIndex = 28;
            this.checkAdmin.Text = "Admin";
            this.checkAdmin.UseVisualStyleBackColor = true;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Depth = 0;
            this.lblDepartment.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDepartment.Location = new System.Drawing.Point(45, 292);
            this.lblDepartment.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(87, 19);
            this.lblDepartment.TabIndex = 27;
            this.lblDepartment.Text = "Department";
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Depth = 0;
            this.lblRoles.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRoles.Location = new System.Drawing.Point(45, 213);
            this.lblRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(47, 19);
            this.lblRoles.TabIndex = 26;
            this.lblRoles.Text = "Roles";
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Depth = 0;
            this.rdoOther.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoOther.Location = new System.Drawing.Point(178, 175);
            this.rdoOther.Margin = new System.Windows.Forms.Padding(0);
            this.rdoOther.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoOther.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Ripple = true;
            this.rdoOther.Size = new System.Drawing.Size(63, 30);
            this.rdoOther.TabIndex = 25;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Depth = 0;
            this.rdoFemale.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoFemale.Location = new System.Drawing.Point(104, 175);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(0);
            this.rdoFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Ripple = true;
            this.rdoFemale.Size = new System.Drawing.Size(74, 30);
            this.rdoFemale.TabIndex = 24;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Depth = 0;
            this.rdoMale.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoMale.Location = new System.Drawing.Point(45, 175);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(0);
            this.rdoMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Ripple = true;
            this.rdoMale.Size = new System.Drawing.Size(59, 30);
            this.rdoMale.TabIndex = 23;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Hint = "";
            this.txtFirstName.Location = new System.Drawing.Point(45, 130);
            this.txtFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.Size = new System.Drawing.Size(251, 23);
            this.txtFirstName.TabIndex = 22;
            this.txtFirstName.UseSystemPasswordChar = false;
            // 
            // txtSurname
            // 
            this.txtSurname.Depth = 0;
            this.txtSurname.Hint = "";
            this.txtSurname.Location = new System.Drawing.Point(45, 76);
            this.txtSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '\0';
            this.txtSurname.SelectedText = "";
            this.txtSurname.SelectionLength = 0;
            this.txtSurname.SelectionStart = 0;
            this.txtSurname.Size = new System.Drawing.Size(251, 23);
            this.txtSurname.TabIndex = 21;
            this.txtSurname.UseSystemPasswordChar = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Depth = 0;
            this.lblFirstName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFirstName.Location = new System.Drawing.Point(41, 108);
            this.lblFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 19);
            this.lblFirstName.TabIndex = 20;
            this.lblFirstName.Text = "First Name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Depth = 0;
            this.lblGender.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGender.Location = new System.Drawing.Point(41, 156);
            this.lblGender.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 19);
            this.lblGender.TabIndex = 19;
            this.lblGender.Text = "Gender";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Depth = 0;
            this.lblSurname.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSurname.Location = new System.Drawing.Point(41, 54);
            this.lblSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(68, 19);
            this.lblSurname.TabIndex = 18;
            this.lblSurname.Text = "Surname";
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.btnUpdate);
            this.buttonPanel.Controls.Add(this.btnClear);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 444);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(336, 53);
            this.buttonPanel.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(49, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(83, 36);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Depth = 0;
            this.btnClear.Location = new System.Drawing.Point(165, 6);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = false;
            this.btnClear.Size = new System.Drawing.Size(54, 36);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 497);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surname,
            this.firstName,
            this.gender,
            this.admin,
            this.departmentAdmin,
            this.lecturer});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(642, 497);
            this.dataGridView1.TabIndex = 0;
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // admin
            // 
            this.admin.HeaderText = "Admin";
            this.admin.Name = "admin";
            this.admin.ReadOnly = true;
            // 
            // departmentAdmin
            // 
            this.departmentAdmin.HeaderText = "Department Admin";
            this.departmentAdmin.Name = "departmentAdmin";
            this.departmentAdmin.ReadOnly = true;
            // 
            // lecturer
            // 
            this.lecturer.HeaderText = "Lecturer";
            this.lecturer.Name = "lecturer";
            this.lecturer.ReadOnly = true;
            // 
            // ManageStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 563);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStaffForm";
            this.Load += new System.EventHandler(this.ManageStaffForm_Load);
            this.detailsPanel.ResumeLayout(false);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel detailsPanel;
        private MaterialSkin.Controls.MaterialFlatButton btnClear;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Panel formPanel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialLabel lblNewPassword;
        private System.Windows.Forms.ComboBox txtDepartment;
        private MaterialSkin.Controls.MaterialCheckBox checkDepartmentAdmin;
        private MaterialSkin.Controls.MaterialCheckBox checkLecturer;
        private MaterialSkin.Controls.MaterialCheckBox checkAdmin;
        private MaterialSkin.Controls.MaterialLabel lblDepartment;
        private MaterialSkin.Controls.MaterialLabel lblRoles;
        private MaterialSkin.Controls.MaterialRadioButton rdoOther;
        private MaterialSkin.Controls.MaterialRadioButton rdoFemale;
        private MaterialSkin.Controls.MaterialRadioButton rdoMale;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFirstName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSurname;
        private MaterialSkin.Controls.MaterialLabel lblFirstName;
        private MaterialSkin.Controls.MaterialLabel lblGender;
        private MaterialSkin.Controls.MaterialLabel lblSurname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConfirmation;
        private MaterialSkin.Controls.MaterialLabel lblConfirmation;
        private System.Windows.Forms.Label lblPasswordInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturer;
    }
}