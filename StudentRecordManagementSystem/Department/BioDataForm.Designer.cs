namespace StudentRecordManagementSystem
{
    partial class BioDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BioDataForm));
            this.lblSurname = new MaterialSkin.Controls.MaterialLabel();
            this.txtSurname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFirstName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFirstName = new MaterialSkin.Controls.MaterialLabel();
            this.lblDateOfBirth = new MaterialSkin.Controls.MaterialLabel();
            this.datePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.lblID = new MaterialSkin.Controls.MaterialLabel();
            this.txtID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblBox = new MaterialSkin.Controls.MaterialLabel();
            this.txtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTown = new MaterialSkin.Controls.MaterialLabel();
            this.txtTown = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblPhone = new MaterialSkin.Controls.MaterialLabel();
            this.txtPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bioDataErrProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.rdoOther = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupReligion = new System.Windows.Forms.GroupBox();
            this.rdoButhist = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoMuslim = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoChristian = new MaterialSkin.Controls.MaterialRadioButton();
            this.name = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCounty = new MaterialSkin.Controls.MaterialLabel();
            this.txtCounty = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLocation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblLocation = new MaterialSkin.Controls.MaterialLabel();
            this.txtVillage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblVillage = new MaterialSkin.Controls.MaterialLabel();
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.bioDataErrProvider)).BeginInit();
            this.groupGender.SuspendLayout();
            this.groupReligion.SuspendLayout();
            this.name.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Depth = 0;
            this.lblSurname.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSurname.Location = new System.Drawing.Point(422, 27);
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
            this.txtSurname.Location = new System.Drawing.Point(512, 22);
            this.txtSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '\0';
            this.txtSurname.SelectedText = "";
            this.txtSurname.SelectionLength = 0;
            this.txtSurname.SelectionStart = 0;
            this.txtSurname.Size = new System.Drawing.Size(224, 32);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.UseSystemPasswordChar = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Hint = "";
            this.txtFirstName.Location = new System.Drawing.Point(135, 22);
            this.txtFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.Size = new System.Drawing.Size(228, 32);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.UseSystemPasswordChar = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Depth = 0;
            this.lblFirstName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFirstName.Location = new System.Drawing.Point(28, 27);
            this.lblFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(118, 27);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Depth = 0;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDateOfBirth.Location = new System.Drawing.Point(14, 62);
            this.lblDateOfBirth.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(135, 27);
            this.lblDateOfBirth.TabIndex = 7;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // datePickerDOB
            // 
            this.datePickerDOB.Location = new System.Drawing.Point(135, 55);
            this.datePickerDOB.Name = "datePickerDOB";
            this.datePickerDOB.Size = new System.Drawing.Size(229, 30);
            this.datePickerDOB.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Depth = 0;
            this.lblID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblID.Location = new System.Drawing.Point(368, 59);
            this.lblID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(162, 27);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID/Passport No";
            // 
            // txtID
            // 
            this.txtID.Depth = 0;
            this.txtID.Hint = "";
            this.txtID.Location = new System.Drawing.Point(512, 55);
            this.txtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.Size = new System.Drawing.Size(224, 32);
            this.txtID.TabIndex = 3;
            this.txtID.UseSystemPasswordChar = false;
            // 
            // lblBox
            // 
            this.lblBox.AutoSize = true;
            this.lblBox.Depth = 0;
            this.lblBox.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBox.Location = new System.Drawing.Point(52, 27);
            this.lblBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBox.Name = "lblBox";
            this.lblBox.Size = new System.Drawing.Size(90, 27);
            this.lblBox.TabIndex = 11;
            this.lblBox.Text = "P.O Box";
            // 
            // txtBox
            // 
            this.txtBox.Depth = 0;
            this.txtBox.Hint = "";
            this.txtBox.Location = new System.Drawing.Point(135, 22);
            this.txtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBox.Name = "txtBox";
            this.txtBox.PasswordChar = '\0';
            this.txtBox.SelectedText = "";
            this.txtBox.SelectionLength = 0;
            this.txtBox.SelectionStart = 0;
            this.txtBox.Size = new System.Drawing.Size(228, 32);
            this.txtBox.TabIndex = 7;
            this.txtBox.UseSystemPasswordChar = false;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Depth = 0;
            this.lblTown.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTown.Location = new System.Drawing.Point(439, 27);
            this.lblTown.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(67, 27);
            this.lblTown.TabIndex = 13;
            this.lblTown.Text = "Town";
            // 
            // txtTown
            // 
            this.txtTown.Depth = 0;
            this.txtTown.Hint = "";
            this.txtTown.Location = new System.Drawing.Point(501, 22);
            this.txtTown.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTown.Name = "txtTown";
            this.txtTown.PasswordChar = '\0';
            this.txtTown.SelectedText = "";
            this.txtTown.SelectionLength = 0;
            this.txtTown.SelectionStart = 0;
            this.txtTown.Size = new System.Drawing.Size(228, 32);
            this.txtTown.TabIndex = 8;
            this.txtTown.UseSystemPasswordChar = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Depth = 0;
            this.lblPhone.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPhone.Location = new System.Drawing.Point(36, 28);
            this.lblPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(109, 27);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone No";
            // 
            // txtPhone
            // 
            this.txtPhone.Depth = 0;
            this.txtPhone.Hint = "";
            this.txtPhone.Location = new System.Drawing.Point(135, 23);
            this.txtPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.Size = new System.Drawing.Size(228, 32);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.UseSystemPasswordChar = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(440, 19);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 27);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(501, 15);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(228, 32);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // bioDataErrProvider
            // 
            this.bioDataErrProvider.ContainerControl = this;
            // 
            // groupGender
            // 
            this.groupGender.Controls.Add(this.rdoOther);
            this.groupGender.Controls.Add(this.rdoMale);
            this.groupGender.Controls.Add(this.rdoFemale);
            this.groupGender.Location = new System.Drawing.Point(11, 91);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(274, 49);
            this.groupGender.TabIndex = 34;
            this.groupGender.TabStop = false;
            this.groupGender.Text = "Gender";
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Depth = 0;
            this.rdoOther.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoOther.Location = new System.Drawing.Point(157, 19);
            this.rdoOther.Margin = new System.Windows.Forms.Padding(0);
            this.rdoOther.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoOther.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Ripple = true;
            this.rdoOther.Size = new System.Drawing.Size(82, 30);
            this.rdoOther.TabIndex = 6;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Depth = 0;
            this.rdoMale.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoMale.Location = new System.Drawing.Point(3, 19);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(0);
            this.rdoMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Ripple = true;
            this.rdoMale.Size = new System.Drawing.Size(77, 30);
            this.rdoMale.TabIndex = 4;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Depth = 0;
            this.rdoFemale.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoFemale.Location = new System.Drawing.Point(72, 19);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(0);
            this.rdoFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Ripple = true;
            this.rdoFemale.Size = new System.Drawing.Size(99, 30);
            this.rdoFemale.TabIndex = 5;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // groupReligion
            // 
            this.groupReligion.Controls.Add(this.rdoButhist);
            this.groupReligion.Controls.Add(this.rdoMuslim);
            this.groupReligion.Controls.Add(this.rdoChristian);
            this.groupReligion.Location = new System.Drawing.Point(372, 91);
            this.groupReligion.Name = "groupReligion";
            this.groupReligion.Size = new System.Drawing.Size(378, 53);
            this.groupReligion.TabIndex = 35;
            this.groupReligion.TabStop = false;
            this.groupReligion.Text = "Religion";
            // 
            // rdoButhist
            // 
            this.rdoButhist.AutoSize = true;
            this.rdoButhist.Depth = 0;
            this.rdoButhist.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoButhist.Location = new System.Drawing.Point(187, 19);
            this.rdoButhist.Margin = new System.Windows.Forms.Padding(0);
            this.rdoButhist.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoButhist.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoButhist.Name = "rdoButhist";
            this.rdoButhist.Ripple = true;
            this.rdoButhist.Size = new System.Drawing.Size(97, 30);
            this.rdoButhist.TabIndex = 9;
            this.rdoButhist.TabStop = true;
            this.rdoButhist.Text = "Buthist";
            this.rdoButhist.UseVisualStyleBackColor = true;
            // 
            // rdoMuslim
            // 
            this.rdoMuslim.AutoSize = true;
            this.rdoMuslim.Depth = 0;
            this.rdoMuslim.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoMuslim.Location = new System.Drawing.Point(101, 19);
            this.rdoMuslim.Margin = new System.Windows.Forms.Padding(0);
            this.rdoMuslim.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoMuslim.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoMuslim.Name = "rdoMuslim";
            this.rdoMuslim.Ripple = true;
            this.rdoMuslim.Size = new System.Drawing.Size(100, 30);
            this.rdoMuslim.TabIndex = 8;
            this.rdoMuslim.TabStop = true;
            this.rdoMuslim.Text = "Muslim";
            this.rdoMuslim.UseVisualStyleBackColor = true;
            // 
            // rdoChristian
            // 
            this.rdoChristian.AutoSize = true;
            this.rdoChristian.Depth = 0;
            this.rdoChristian.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdoChristian.Location = new System.Drawing.Point(3, 19);
            this.rdoChristian.Margin = new System.Windows.Forms.Padding(0);
            this.rdoChristian.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoChristian.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoChristian.Name = "rdoChristian";
            this.rdoChristian.Ripple = true;
            this.rdoChristian.Size = new System.Drawing.Size(114, 30);
            this.rdoChristian.TabIndex = 7;
            this.rdoChristian.TabStop = true;
            this.rdoChristian.Text = "Christian";
            this.rdoChristian.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.Controls.Add(this.lblSurname);
            this.name.Controls.Add(this.txtSurname);
            this.name.Controls.Add(this.groupReligion);
            this.name.Controls.Add(this.groupGender);
            this.name.Controls.Add(this.lblFirstName);
            this.name.Controls.Add(this.txtFirstName);
            this.name.Controls.Add(this.lblDateOfBirth);
            this.name.Controls.Add(this.datePickerDOB);
            this.name.Controls.Add(this.lblID);
            this.name.Controls.Add(this.txtID);
            this.name.Location = new System.Drawing.Point(31, 70);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(755, 157);
            this.name.TabIndex = 36;
            this.name.TabStop = false;
            this.name.Text = "Personal Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBox);
            this.groupBox1.Controls.Add(this.txtBox);
            this.groupBox1.Controls.Add(this.lblTown);
            this.groupBox1.Controls.Add(this.txtTown);
            this.groupBox1.Location = new System.Drawing.Point(31, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 80);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Box Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Location = new System.Drawing.Point(31, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 56);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contacts";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCounty);
            this.groupBox3.Controls.Add(this.txtCounty);
            this.groupBox3.Controls.Add(this.txtLocation);
            this.groupBox3.Controls.Add(this.lblLocation);
            this.groupBox3.Controls.Add(this.txtVillage);
            this.groupBox3.Controls.Add(this.lblVillage);
            this.groupBox3.Location = new System.Drawing.Point(31, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(755, 115);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Home Address";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Depth = 0;
            this.lblCounty.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCounty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCounty.Location = new System.Drawing.Point(61, 64);
            this.lblCounty.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(80, 27);
            this.lblCounty.TabIndex = 38;
            this.lblCounty.Text = "County";
            // 
            // txtCounty
            // 
            this.txtCounty.Depth = 0;
            this.txtCounty.Hint = "";
            this.txtCounty.Location = new System.Drawing.Point(135, 59);
            this.txtCounty.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.PasswordChar = '\0';
            this.txtCounty.SelectedText = "";
            this.txtCounty.SelectionLength = 0;
            this.txtCounty.SelectionStart = 0;
            this.txtCounty.Size = new System.Drawing.Size(228, 32);
            this.txtCounty.TabIndex = 33;
            this.txtCounty.UseSystemPasswordChar = false;
            // 
            // txtLocation
            // 
            this.txtLocation.Depth = 0;
            this.txtLocation.Hint = "";
            this.txtLocation.Location = new System.Drawing.Point(501, 22);
            this.txtLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.SelectedText = "";
            this.txtLocation.SelectionLength = 0;
            this.txtLocation.SelectionStart = 0;
            this.txtLocation.Size = new System.Drawing.Size(228, 32);
            this.txtLocation.TabIndex = 32;
            this.txtLocation.UseSystemPasswordChar = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Depth = 0;
            this.lblLocation.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLocation.Location = new System.Drawing.Point(412, 27);
            this.lblLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(98, 27);
            this.lblLocation.TabIndex = 37;
            this.lblLocation.Text = "Location";
            // 
            // txtVillage
            // 
            this.txtVillage.Depth = 0;
            this.txtVillage.Hint = "";
            this.txtVillage.Location = new System.Drawing.Point(135, 22);
            this.txtVillage.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtVillage.Name = "txtVillage";
            this.txtVillage.PasswordChar = '\0';
            this.txtVillage.SelectedText = "";
            this.txtVillage.SelectionLength = 0;
            this.txtVillage.SelectionStart = 0;
            this.txtVillage.Size = new System.Drawing.Size(228, 32);
            this.txtVillage.TabIndex = 31;
            this.txtVillage.UseSystemPasswordChar = false;
            // 
            // lblVillage
            // 
            this.lblVillage.AutoSize = true;
            this.lblVillage.Depth = 0;
            this.lblVillage.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblVillage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVillage.Location = new System.Drawing.Point(63, 27);
            this.lblVillage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVillage.Name = "lblVillage";
            this.lblVillage.Size = new System.Drawing.Size(77, 27);
            this.lblVillage.TabIndex = 36;
            this.lblVillage.Text = "Village";
            // 
            // btnClear
            // 
            this.btnClear.Depth = 0;
            this.btnClear.Location = new System.Drawing.Point(435, 498);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(185, 36);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(234, 498);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(185, 36);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BioDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 551);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "BioDataForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Bio Data";
            this.Load += new System.EventHandler(this.BioDataForm_Load);
            this.Enter += new System.EventHandler(this.btnSave_Click);
            ((System.ComponentModel.ISupportInitialize)(this.bioDataErrProvider)).EndInit();
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            this.groupReligion.ResumeLayout(false);
            this.groupReligion.PerformLayout();
            this.name.ResumeLayout(false);
            this.name.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblSurname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSurname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFirstName;
        private MaterialSkin.Controls.MaterialLabel lblFirstName;
        private MaterialSkin.Controls.MaterialLabel lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker datePickerDOB;
        private MaterialSkin.Controls.MaterialLabel lblID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtID;
        private MaterialSkin.Controls.MaterialLabel lblBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBox;
        private MaterialSkin.Controls.MaterialLabel lblTown;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTown;
        private MaterialSkin.Controls.MaterialLabel lblPhone;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPhone;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private System.Windows.Forms.ErrorProvider bioDataErrProvider;
        private System.Windows.Forms.GroupBox groupReligion;
        private MaterialSkin.Controls.MaterialRadioButton rdoButhist;
        private MaterialSkin.Controls.MaterialRadioButton rdoMuslim;
        private MaterialSkin.Controls.MaterialRadioButton rdoChristian;
        private System.Windows.Forms.GroupBox groupGender;
        private MaterialSkin.Controls.MaterialRadioButton rdoOther;
        private MaterialSkin.Controls.MaterialRadioButton rdoFemale;
        private MaterialSkin.Controls.MaterialRadioButton rdoMale;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialLabel lblCounty;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCounty;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLocation;
        private MaterialSkin.Controls.MaterialLabel lblLocation;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtVillage;
        private MaterialSkin.Controls.MaterialLabel lblVillage;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox name;
    }
}