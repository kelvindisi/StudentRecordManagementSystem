namespace StudentRecordManagementSystem
{
    partial class AddStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStaffForm));
            this.lblSurname = new MaterialSkin.Controls.MaterialLabel();
            this.txtSurname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFirstName = new MaterialSkin.Controls.MaterialLabel();
            this.txtFirstName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblGender = new MaterialSkin.Controls.MaterialLabel();
            this.rdoMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoOther = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblPasswordConfirmation = new MaterialSkin.Controls.MaterialLabel();
            this.txtPasswordConfirmation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxAdmin = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbxLecturer = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbxDepartmentAdmin = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Depth = 0;
            this.lblSurname.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSurname.Location = new System.Drawing.Point(23, 86);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(99, 27);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Depth = 0;
            this.txtSurname.Hint = "";
            this.txtSurname.Location = new System.Drawing.Point(27, 110);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '\0';
            this.txtSurname.SelectedText = "";
            this.txtSurname.SelectionLength = 0;
            this.txtSurname.SelectionStart = 0;
            this.txtSurname.Size = new System.Drawing.Size(251, 32);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.UseSystemPasswordChar = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Depth = 0;
            this.lblFirstName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFirstName.Location = new System.Drawing.Point(291, 86);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(118, 27);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Hint = "";
            this.txtFirstName.Location = new System.Drawing.Point(295, 110);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.Size = new System.Drawing.Size(262, 32);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.UseSystemPasswordChar = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(23, 138);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 27);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(27, 162);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(251, 32);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Depth = 0;
            this.lblGender.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGender.Location = new System.Drawing.Point(23, 190);
            this.lblGender.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(82, 27);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Depth = 0;
            this.rdoMale.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoMale.Location = new System.Drawing.Point(27, 209);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(0);
            this.rdoMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Ripple = true;
            this.rdoMale.Size = new System.Drawing.Size(77, 30);
            this.rdoMale.TabIndex = 7;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Depth = 0;
            this.rdoFemale.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoFemale.Location = new System.Drawing.Point(86, 209);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(0);
            this.rdoFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Ripple = true;
            this.rdoFemale.Size = new System.Drawing.Size(99, 30);
            this.rdoFemale.TabIndex = 8;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Depth = 0;
            this.rdoOther.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoOther.Location = new System.Drawing.Point(160, 209);
            this.rdoOther.Margin = new System.Windows.Forms.Padding(0);
            this.rdoOther.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoOther.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Ripple = true;
            this.rdoOther.Size = new System.Drawing.Size(82, 30);
            this.rdoOther.TabIndex = 9;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Depth = 0;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPassword.Location = new System.Drawing.Point(23, 292);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(109, 27);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "";
            this.txtPassword.Location = new System.Drawing.Point(27, 314);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(251, 32);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // lblPasswordConfirmation
            // 
            this.lblPasswordConfirmation.AutoSize = true;
            this.lblPasswordConfirmation.Depth = 0;
            this.lblPasswordConfirmation.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPasswordConfirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPasswordConfirmation.Location = new System.Drawing.Point(291, 292);
            this.lblPasswordConfirmation.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPasswordConfirmation.Name = "lblPasswordConfirmation";
            this.lblPasswordConfirmation.Size = new System.Drawing.Size(241, 27);
            this.lblPasswordConfirmation.TabIndex = 12;
            this.lblPasswordConfirmation.Text = "Password Confirmation";
            // 
            // txtPasswordConfirmation
            // 
            this.txtPasswordConfirmation.Depth = 0;
            this.txtPasswordConfirmation.Hint = "";
            this.txtPasswordConfirmation.Location = new System.Drawing.Point(295, 314);
            this.txtPasswordConfirmation.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            this.txtPasswordConfirmation.PasswordChar = '*';
            this.txtPasswordConfirmation.SelectedText = "";
            this.txtPasswordConfirmation.SelectionLength = 0;
            this.txtPasswordConfirmation.SelectionStart = 0;
            this.txtPasswordConfirmation.Size = new System.Drawing.Size(262, 32);
            this.txtPasswordConfirmation.TabIndex = 13;
            this.txtPasswordConfirmation.UseSystemPasswordChar = false;
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(27, 368);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(251, 45);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Depth = 0;
            this.btnClear.Location = new System.Drawing.Point(295, 368);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(251, 45);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(291, 138);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 27);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Roles";
            // 
            // cbxAdmin
            // 
            this.cbxAdmin.AutoSize = true;
            this.cbxAdmin.Depth = 0;
            this.cbxAdmin.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbxAdmin.Location = new System.Drawing.Point(295, 162);
            this.cbxAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.cbxAdmin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxAdmin.Name = "cbxAdmin";
            this.cbxAdmin.Ripple = true;
            this.cbxAdmin.Size = new System.Drawing.Size(92, 30);
            this.cbxAdmin.TabIndex = 16;
            this.cbxAdmin.Text = "Admin";
            this.cbxAdmin.UseVisualStyleBackColor = true;
            // 
            // cbxLecturer
            // 
            this.cbxLecturer.AutoSize = true;
            this.cbxLecturer.Depth = 0;
            this.cbxLecturer.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbxLecturer.Location = new System.Drawing.Point(365, 162);
            this.cbxLecturer.Margin = new System.Windows.Forms.Padding(0);
            this.cbxLecturer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxLecturer.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxLecturer.Name = "cbxLecturer";
            this.cbxLecturer.Ripple = true;
            this.cbxLecturer.Size = new System.Drawing.Size(109, 30);
            this.cbxLecturer.TabIndex = 17;
            this.cbxLecturer.Text = "Lecturer";
            this.cbxLecturer.UseVisualStyleBackColor = true;
            // 
            // cbxDepartmentAdmin
            // 
            this.cbxDepartmentAdmin.AutoSize = true;
            this.cbxDepartmentAdmin.Depth = 0;
            this.cbxDepartmentAdmin.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbxDepartmentAdmin.Location = new System.Drawing.Point(295, 192);
            this.cbxDepartmentAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.cbxDepartmentAdmin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxDepartmentAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxDepartmentAdmin.Name = "cbxDepartmentAdmin";
            this.cbxDepartmentAdmin.Ripple = true;
            this.cbxDepartmentAdmin.Size = new System.Drawing.Size(206, 30);
            this.cbxDepartmentAdmin.TabIndex = 18;
            this.cbxDepartmentAdmin.Text = "Department Admin";
            this.cbxDepartmentAdmin.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(23, 239);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(126, 27);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Department";
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(27, 261);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(204, 37);
            this.cboDepartment.TabIndex = 20;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 440);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cbxDepartmentAdmin);
            this.Controls.Add(this.cbxLecturer);
            this.Controls.Add(this.cbxAdmin);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPasswordConfirmation);
            this.Controls.Add(this.lblPasswordConfirmation);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.rdoOther);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AddStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Staff";
            this.Load += new System.EventHandler(this.AddStaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblSurname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSurname;
        private MaterialSkin.Controls.MaterialLabel lblFirstName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFirstName;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialLabel lblGender;
        private MaterialSkin.Controls.MaterialRadioButton rdoMale;
        private MaterialSkin.Controls.MaterialRadioButton rdoFemale;
        private MaterialSkin.Controls.MaterialRadioButton rdoOther;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialLabel lblPasswordConfirmation;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPasswordConfirmation;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox cbxAdmin;
        private MaterialSkin.Controls.MaterialCheckBox cbxLecturer;
        private MaterialSkin.Controls.MaterialCheckBox cbxDepartmentAdmin;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}