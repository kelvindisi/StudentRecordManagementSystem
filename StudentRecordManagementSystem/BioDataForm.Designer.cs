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
            this.lblVillage = new MaterialSkin.Controls.MaterialLabel();
            this.txtVillage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblLocation = new MaterialSkin.Controls.MaterialLabel();
            this.txtLocation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCounty = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblCounty = new MaterialSkin.Controls.MaterialLabel();
            this.bioDataErrProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.rdoOther = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupReligion = new System.Windows.Forms.GroupBox();
            this.lblButhist = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoMuslim = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoChristian = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupFingerprint = new System.Windows.Forms.GroupBox();
            this.lblFingerprintTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblLeftIndex = new MaterialSkin.Controls.MaterialLabel();
            this.lblRightIndex = new MaterialSkin.Controls.MaterialLabel();
            this.btnScanRight = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnScanLeft = new MaterialSkin.Controls.MaterialRaisedButton();
            this.picRightIndex = new System.Windows.Forms.PictureBox();
            this.picLeftIndex = new System.Windows.Forms.PictureBox();
            this.txtFingerPrintMsg = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bioDataErrProvider)).BeginInit();
            this.groupGender.SuspendLayout();
            this.groupReligion.SuspendLayout();
            this.groupFingerprint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRightIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Depth = 0;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSurname.Location = new System.Drawing.Point(35, 75);
            this.lblSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(68, 18);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Depth = 0;
            this.txtSurname.Hint = "";
            this.txtSurname.Location = new System.Drawing.Point(39, 97);
            this.txtSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '\0';
            this.txtSurname.SelectedText = "";
            this.txtSurname.SelectionLength = 0;
            this.txtSurname.SelectionStart = 0;
            this.txtSurname.Size = new System.Drawing.Size(216, 23);
            this.txtSurname.TabIndex = 0;
            this.txtSurname.UseSystemPasswordChar = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Hint = "";
            this.txtFirstName.Location = new System.Drawing.Point(274, 97);
            this.txtFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.Size = new System.Drawing.Size(216, 23);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.UseSystemPasswordChar = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Depth = 0;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFirstName.Location = new System.Drawing.Point(270, 75);
            this.lblFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(81, 18);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Depth = 0;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDateOfBirth.Location = new System.Drawing.Point(270, 123);
            this.lblDateOfBirth.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(93, 18);
            this.lblDateOfBirth.TabIndex = 7;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // datePickerDOB
            // 
            this.datePickerDOB.Location = new System.Drawing.Point(274, 145);
            this.datePickerDOB.Name = "datePickerDOB";
            this.datePickerDOB.Size = new System.Drawing.Size(216, 26);
            this.datePickerDOB.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Depth = 0;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblID.Location = new System.Drawing.Point(38, 186);
            this.lblID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(110, 18);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID/Passport No";
            // 
            // txtID
            // 
            this.txtID.Depth = 0;
            this.txtID.Hint = "";
            this.txtID.Location = new System.Drawing.Point(42, 208);
            this.txtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.Size = new System.Drawing.Size(325, 23);
            this.txtID.TabIndex = 6;
            this.txtID.UseSystemPasswordChar = false;
            // 
            // lblBox
            // 
            this.lblBox.AutoSize = true;
            this.lblBox.Depth = 0;
            this.lblBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBox.Location = new System.Drawing.Point(38, 234);
            this.lblBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBox.Name = "lblBox";
            this.lblBox.Size = new System.Drawing.Size(64, 18);
            this.lblBox.TabIndex = 11;
            this.lblBox.Text = "P.O Box";
            // 
            // txtBox
            // 
            this.txtBox.Depth = 0;
            this.txtBox.Hint = "";
            this.txtBox.Location = new System.Drawing.Point(42, 256);
            this.txtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBox.Name = "txtBox";
            this.txtBox.PasswordChar = '\0';
            this.txtBox.SelectedText = "";
            this.txtBox.SelectionLength = 0;
            this.txtBox.SelectionStart = 0;
            this.txtBox.Size = new System.Drawing.Size(216, 23);
            this.txtBox.TabIndex = 7;
            this.txtBox.UseSystemPasswordChar = false;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Depth = 0;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTown.Location = new System.Drawing.Point(273, 234);
            this.lblTown.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(45, 18);
            this.lblTown.TabIndex = 13;
            this.lblTown.Text = "Town";
            // 
            // txtTown
            // 
            this.txtTown.Depth = 0;
            this.txtTown.Hint = "";
            this.txtTown.Location = new System.Drawing.Point(277, 256);
            this.txtTown.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTown.Name = "txtTown";
            this.txtTown.PasswordChar = '\0';
            this.txtTown.SelectedText = "";
            this.txtTown.SelectionLength = 0;
            this.txtTown.SelectionStart = 0;
            this.txtTown.Size = new System.Drawing.Size(216, 23);
            this.txtTown.TabIndex = 8;
            this.txtTown.UseSystemPasswordChar = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Depth = 0;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPhone.Location = new System.Drawing.Point(38, 282);
            this.lblPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(75, 18);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone No";
            // 
            // txtPhone
            // 
            this.txtPhone.Depth = 0;
            this.txtPhone.Hint = "";
            this.txtPhone.Location = new System.Drawing.Point(42, 304);
            this.txtPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.Size = new System.Drawing.Size(216, 23);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.UseSystemPasswordChar = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(273, 282);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 18);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(277, 304);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(216, 23);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // lblVillage
            // 
            this.lblVillage.AutoSize = true;
            this.lblVillage.Depth = 0;
            this.lblVillage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblVillage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVillage.Location = new System.Drawing.Point(42, 398);
            this.lblVillage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVillage.Name = "lblVillage";
            this.lblVillage.Size = new System.Drawing.Size(50, 18);
            this.lblVillage.TabIndex = 23;
            this.lblVillage.Text = "Village";
            // 
            // txtVillage
            // 
            this.txtVillage.Depth = 0;
            this.txtVillage.Hint = "";
            this.txtVillage.Location = new System.Drawing.Point(46, 420);
            this.txtVillage.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtVillage.Name = "txtVillage";
            this.txtVillage.PasswordChar = '\0';
            this.txtVillage.SelectedText = "";
            this.txtVillage.SelectionLength = 0;
            this.txtVillage.SelectionStart = 0;
            this.txtVillage.Size = new System.Drawing.Size(216, 23);
            this.txtVillage.TabIndex = 14;
            this.txtVillage.UseSystemPasswordChar = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Depth = 0;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLocation.Location = new System.Drawing.Point(277, 398);
            this.lblLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(65, 18);
            this.lblLocation.TabIndex = 25;
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Depth = 0;
            this.txtLocation.Hint = "";
            this.txtLocation.Location = new System.Drawing.Point(281, 420);
            this.txtLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.SelectedText = "";
            this.txtLocation.SelectionLength = 0;
            this.txtLocation.SelectionStart = 0;
            this.txtLocation.Size = new System.Drawing.Size(216, 23);
            this.txtLocation.TabIndex = 15;
            this.txtLocation.UseSystemPasswordChar = false;
            // 
            // txtCounty
            // 
            this.txtCounty.Depth = 0;
            this.txtCounty.Hint = "";
            this.txtCounty.Location = new System.Drawing.Point(46, 468);
            this.txtCounty.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.PasswordChar = '\0';
            this.txtCounty.SelectedText = "";
            this.txtCounty.SelectionLength = 0;
            this.txtCounty.SelectionStart = 0;
            this.txtCounty.Size = new System.Drawing.Size(216, 23);
            this.txtCounty.TabIndex = 16;
            this.txtCounty.UseSystemPasswordChar = false;
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(39, 522);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(216, 42);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Depth = 0;
            this.btnClear.Location = new System.Drawing.Point(274, 522);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(216, 42);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Depth = 0;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCounty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCounty.Location = new System.Drawing.Point(42, 446);
            this.lblCounty.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(55, 18);
            this.lblCounty.TabIndex = 30;
            this.lblCounty.Text = "County";
            // 
            // bioDataErrProvider
            // 
            this.bioDataErrProvider.ContainerControl = this;
            // 
            // groupGender
            // 
            this.groupGender.Controls.Add(this.rdoOther);
            this.groupGender.Controls.Add(this.rdoFemale);
            this.groupGender.Controls.Add(this.rdoMale);
            this.groupGender.Location = new System.Drawing.Point(39, 126);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(216, 57);
            this.groupGender.TabIndex = 34;
            this.groupGender.TabStop = false;
            this.groupGender.Text = "Gender";
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Depth = 0;
            this.rdoOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoOther.Location = new System.Drawing.Point(136, 22);
            this.rdoOther.Margin = new System.Windows.Forms.Padding(0);
            this.rdoOther.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoOther.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Ripple = true;
            this.rdoOther.Size = new System.Drawing.Size(63, 30);
            this.rdoOther.TabIndex = 4;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Depth = 0;
            this.rdoFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoFemale.Location = new System.Drawing.Point(62, 22);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(0);
            this.rdoFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Ripple = true;
            this.rdoFemale.Size = new System.Drawing.Size(74, 30);
            this.rdoFemale.TabIndex = 3;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Depth = 0;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoMale.Location = new System.Drawing.Point(3, 22);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(0);
            this.rdoMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Ripple = true;
            this.rdoMale.Size = new System.Drawing.Size(59, 30);
            this.rdoMale.TabIndex = 2;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // groupReligion
            // 
            this.groupReligion.Controls.Add(this.lblButhist);
            this.groupReligion.Controls.Add(this.rdoMuslim);
            this.groupReligion.Controls.Add(this.rdoChristian);
            this.groupReligion.Location = new System.Drawing.Point(42, 333);
            this.groupReligion.Name = "groupReligion";
            this.groupReligion.Size = new System.Drawing.Size(244, 62);
            this.groupReligion.TabIndex = 35;
            this.groupReligion.TabStop = false;
            this.groupReligion.Text = "Religion";
            // 
            // lblButhist
            // 
            this.lblButhist.AutoSize = true;
            this.lblButhist.Depth = 0;
            this.lblButhist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblButhist.Location = new System.Drawing.Point(163, 22);
            this.lblButhist.Margin = new System.Windows.Forms.Padding(0);
            this.lblButhist.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lblButhist.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblButhist.Name = "lblButhist";
            this.lblButhist.Ripple = true;
            this.lblButhist.Size = new System.Drawing.Size(73, 30);
            this.lblButhist.TabIndex = 13;
            this.lblButhist.TabStop = true;
            this.lblButhist.Text = "Buthist";
            this.lblButhist.UseVisualStyleBackColor = true;
            // 
            // rdoMuslim
            // 
            this.rdoMuslim.AutoSize = true;
            this.rdoMuslim.Depth = 0;
            this.rdoMuslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoMuslim.Location = new System.Drawing.Point(88, 22);
            this.rdoMuslim.Margin = new System.Windows.Forms.Padding(0);
            this.rdoMuslim.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoMuslim.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoMuslim.Name = "rdoMuslim";
            this.rdoMuslim.Ripple = true;
            this.rdoMuslim.Size = new System.Drawing.Size(75, 30);
            this.rdoMuslim.TabIndex = 12;
            this.rdoMuslim.TabStop = true;
            this.rdoMuslim.Text = "Muslim";
            this.rdoMuslim.UseVisualStyleBackColor = true;
            // 
            // rdoChristian
            // 
            this.rdoChristian.AutoSize = true;
            this.rdoChristian.Depth = 0;
            this.rdoChristian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoChristian.Location = new System.Drawing.Point(4, 22);
            this.rdoChristian.Margin = new System.Windows.Forms.Padding(0);
            this.rdoChristian.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoChristian.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoChristian.Name = "rdoChristian";
            this.rdoChristian.Ripple = true;
            this.rdoChristian.Size = new System.Drawing.Size(84, 30);
            this.rdoChristian.TabIndex = 11;
            this.rdoChristian.TabStop = true;
            this.rdoChristian.Text = "Christian";
            this.rdoChristian.UseVisualStyleBackColor = true;
            // 
            // groupFingerprint
            // 
            this.groupFingerprint.Controls.Add(this.lblFingerprintTitle);
            this.groupFingerprint.Controls.Add(this.lblLeftIndex);
            this.groupFingerprint.Controls.Add(this.lblRightIndex);
            this.groupFingerprint.Controls.Add(this.picRightIndex);
            this.groupFingerprint.Controls.Add(this.picLeftIndex);
            this.groupFingerprint.Controls.Add(this.btnScanRight);
            this.groupFingerprint.Controls.Add(this.btnScanLeft);
            this.groupFingerprint.Location = new System.Drawing.Point(514, 166);
            this.groupFingerprint.Name = "groupFingerprint";
            this.groupFingerprint.Size = new System.Drawing.Size(306, 325);
            this.groupFingerprint.TabIndex = 19;
            this.groupFingerprint.TabStop = false;
            // 
            // lblFingerprintTitle
            // 
            this.lblFingerprintTitle.AutoSize = true;
            this.lblFingerprintTitle.Depth = 0;
            this.lblFingerprintTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFingerprintTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFingerprintTitle.Location = new System.Drawing.Point(22, 22);
            this.lblFingerprintTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFingerprintTitle.Name = "lblFingerprintTitle";
            this.lblFingerprintTitle.Size = new System.Drawing.Size(144, 18);
            this.lblFingerprintTitle.TabIndex = 40;
            this.lblFingerprintTitle.Text = "Fingerprint Capturing";
            // 
            // lblLeftIndex
            // 
            this.lblLeftIndex.AutoSize = true;
            this.lblLeftIndex.Depth = 0;
            this.lblLeftIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblLeftIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLeftIndex.Location = new System.Drawing.Point(22, 68);
            this.lblLeftIndex.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLeftIndex.Name = "lblLeftIndex";
            this.lblLeftIndex.Size = new System.Drawing.Size(70, 18);
            this.lblLeftIndex.TabIndex = 38;
            this.lblLeftIndex.Text = "Left Index";
            // 
            // lblRightIndex
            // 
            this.lblRightIndex.AutoSize = true;
            this.lblRightIndex.Depth = 0;
            this.lblRightIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblRightIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRightIndex.Location = new System.Drawing.Point(161, 68);
            this.lblRightIndex.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRightIndex.Name = "lblRightIndex";
            this.lblRightIndex.Size = new System.Drawing.Size(80, 18);
            this.lblRightIndex.TabIndex = 39;
            this.lblRightIndex.Text = "Right Index";
            // 
            // btnScanRight
            // 
            this.btnScanRight.BackColor = System.Drawing.Color.Red;
            this.btnScanRight.Depth = 0;
            this.btnScanRight.Location = new System.Drawing.Point(165, 213);
            this.btnScanRight.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnScanRight.Name = "btnScanRight";
            this.btnScanRight.Primary = true;
            this.btnScanRight.Size = new System.Drawing.Size(119, 31);
            this.btnScanRight.TabIndex = 1;
            this.btnScanRight.Text = "Scan";
            this.btnScanRight.UseVisualStyleBackColor = false;
            // 
            // btnScanLeft
            // 
            this.btnScanLeft.BackColor = System.Drawing.Color.Red;
            this.btnScanLeft.Depth = 0;
            this.btnScanLeft.Location = new System.Drawing.Point(26, 213);
            this.btnScanLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnScanLeft.Name = "btnScanLeft";
            this.btnScanLeft.Primary = true;
            this.btnScanLeft.Size = new System.Drawing.Size(119, 31);
            this.btnScanLeft.TabIndex = 0;
            this.btnScanLeft.Text = "Scan";
            this.btnScanLeft.UseVisualStyleBackColor = false;
            this.btnScanLeft.Click += new System.EventHandler(this.btnScanLeft_Click);
            // 
            // picRightIndex
            // 
            this.picRightIndex.Image = ((System.Drawing.Image)(resources.GetObject("picRightIndex.Image")));
            this.picRightIndex.Location = new System.Drawing.Point(165, 90);
            this.picRightIndex.Name = "picRightIndex";
            this.picRightIndex.Size = new System.Drawing.Size(119, 105);
            this.picRightIndex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRightIndex.TabIndex = 36;
            this.picRightIndex.TabStop = false;
            // 
            // picLeftIndex
            // 
            this.picLeftIndex.Image = ((System.Drawing.Image)(resources.GetObject("picLeftIndex.Image")));
            this.picLeftIndex.Location = new System.Drawing.Point(26, 90);
            this.picLeftIndex.Name = "picLeftIndex";
            this.picLeftIndex.Size = new System.Drawing.Size(119, 105);
            this.picLeftIndex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLeftIndex.TabIndex = 37;
            this.picLeftIndex.TabStop = false;
            // 
            // txtFingerPrintMsg
            // 
            this.txtFingerPrintMsg.AutoSize = true;
            this.txtFingerPrintMsg.Depth = 0;
            this.txtFingerPrintMsg.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtFingerPrintMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFingerPrintMsg.Location = new System.Drawing.Point(510, 97);
            this.txtFingerPrintMsg.MaximumSize = new System.Drawing.Size(306, 0);
            this.txtFingerPrintMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFingerPrintMsg.Name = "txtFingerPrintMsg";
            this.txtFingerPrintMsg.Size = new System.Drawing.Size(121, 19);
            this.txtFingerPrintMsg.TabIndex = 36;
            this.txtFingerPrintMsg.Text = "Place your finger";
            // 
            // BioDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 585);
            this.Controls.Add(this.txtFingerPrintMsg);
            this.Controls.Add(this.groupFingerprint);
            this.Controls.Add(this.groupReligion);
            this.Controls.Add(this.groupGender);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCounty);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtVillage);
            this.Controls.Add(this.lblVillage);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lblBox);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.datePickerDOB);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "BioDataForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Bio Data";
            this.Load += new System.EventHandler(this.BioDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bioDataErrProvider)).EndInit();
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            this.groupReligion.ResumeLayout(false);
            this.groupReligion.PerformLayout();
            this.groupFingerprint.ResumeLayout(false);
            this.groupFingerprint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRightIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private MaterialSkin.Controls.MaterialLabel lblVillage;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtVillage;
        private MaterialSkin.Controls.MaterialLabel lblLocation;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLocation;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCounty;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
        private MaterialSkin.Controls.MaterialLabel lblCounty;
        private System.Windows.Forms.ErrorProvider bioDataErrProvider;
        private System.Windows.Forms.GroupBox groupReligion;
        private MaterialSkin.Controls.MaterialRadioButton lblButhist;
        private MaterialSkin.Controls.MaterialRadioButton rdoMuslim;
        private MaterialSkin.Controls.MaterialRadioButton rdoChristian;
        private System.Windows.Forms.GroupBox groupGender;
        private MaterialSkin.Controls.MaterialRadioButton rdoOther;
        private MaterialSkin.Controls.MaterialRadioButton rdoFemale;
        private MaterialSkin.Controls.MaterialRadioButton rdoMale;
        private System.Windows.Forms.GroupBox groupFingerprint;
        private MaterialSkin.Controls.MaterialLabel lblFingerprintTitle;
        private MaterialSkin.Controls.MaterialLabel lblLeftIndex;
        private MaterialSkin.Controls.MaterialLabel lblRightIndex;
        private System.Windows.Forms.PictureBox picRightIndex;
        private System.Windows.Forms.PictureBox picLeftIndex;
        private MaterialSkin.Controls.MaterialRaisedButton btnScanRight;
        private MaterialSkin.Controls.MaterialRaisedButton btnScanLeft;
        private MaterialSkin.Controls.MaterialLabel txtFingerPrintMsg;
    }
}