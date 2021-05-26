namespace StudentRecordManagementSystem
{
    partial class StudentBioManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentBioManager));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCenterMain = new System.Windows.Forms.Panel();
            this.dtGridBio = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCenterMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridBio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Enabled = false;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(832, 86);
            this.panelTop.TabIndex = 0;
            // 
            // panelCenterMain
            // 
            this.panelCenterMain.BackColor = System.Drawing.Color.Transparent;
            this.panelCenterMain.Controls.Add(this.dtGridBio);
            this.panelCenterMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenterMain.Location = new System.Drawing.Point(0, 86);
            this.panelCenterMain.Name = "panelCenterMain";
            this.panelCenterMain.Size = new System.Drawing.Size(832, 381);
            this.panelCenterMain.TabIndex = 1;
            // 
            // dtGridBio
            // 
            this.dtGridBio.AllowUserToAddRows = false;
            this.dtGridBio.AllowUserToDeleteRows = false;
            this.dtGridBio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridBio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.firstName,
            this.surname,
            this.email,
            this.gender});
            this.dtGridBio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridBio.Location = new System.Drawing.Point(0, 0);
            this.dtGridBio.Name = "dtGridBio";
            this.dtGridBio.ReadOnly = true;
            this.dtGridBio.RowTemplate.Height = 28;
            this.dtGridBio.Size = new System.Drawing.Size(832, 381);
            this.dtGridBio.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First-Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // StudentBioManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 467);
            this.Controls.Add(this.panelCenterMain);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentBioManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Students";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageStudents_Load);
            this.panelCenterMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridBio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenterMain;
        private System.Windows.Forms.DataGridView dtGridBio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
    }
}