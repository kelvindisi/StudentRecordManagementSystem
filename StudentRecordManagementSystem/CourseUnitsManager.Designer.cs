namespace StudentRecordManagementSystem
{
    partial class CourseUnitsManager
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDescription = new MaterialSkin.Controls.MaterialLabel();
            this.txtUnitName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblUnitName = new MaterialSkin.Controls.MaterialLabel();
            this.txtCourse = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCourse = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtGridUnits = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRight.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Enabled = false;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(910, 67);
            this.panelTop.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.btnUpdate);
            this.panelRight.Controls.Add(this.btnSave);
            this.panelRight.Controls.Add(this.txtDescription);
            this.panelRight.Controls.Add(this.lblDescription);
            this.panelRight.Controls.Add(this.txtUnitName);
            this.panelRight.Controls.Add(this.lblUnitName);
            this.panelRight.Controls.Add(this.txtCourse);
            this.panelRight.Controls.Add(this.lblCourse);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(633, 67);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(277, 431);
            this.panelRight.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(9, 196);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(259, 38);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(6, 150);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(259, 38);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Depth = 0;
            this.txtDescription.Hint = "";
            this.txtDescription.Location = new System.Drawing.Point(3, 121);
            this.txtDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.Size = new System.Drawing.Size(262, 23);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.UseSystemPasswordChar = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Depth = 0;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescription.Location = new System.Drawing.Point(6, 99);
            this.lblDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 19);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Depth = 0;
            this.txtUnitName.Hint = "";
            this.txtUnitName.Location = new System.Drawing.Point(6, 73);
            this.txtUnitName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.PasswordChar = '\0';
            this.txtUnitName.SelectedText = "";
            this.txtUnitName.SelectionLength = 0;
            this.txtUnitName.SelectionStart = 0;
            this.txtUnitName.Size = new System.Drawing.Size(259, 23);
            this.txtUnitName.TabIndex = 3;
            this.txtUnitName.UseSystemPasswordChar = false;
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Depth = 0;
            this.lblUnitName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUnitName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUnitName.Location = new System.Drawing.Point(6, 51);
            this.lblUnitName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(80, 19);
            this.lblUnitName.TabIndex = 2;
            this.lblUnitName.Text = "Unit Name";
            // 
            // txtCourse
            // 
            this.txtCourse.Depth = 0;
            this.txtCourse.Hint = "";
            this.txtCourse.Location = new System.Drawing.Point(6, 25);
            this.txtCourse.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.PasswordChar = '\0';
            this.txtCourse.SelectedText = "";
            this.txtCourse.SelectionLength = 0;
            this.txtCourse.SelectionStart = 0;
            this.txtCourse.Size = new System.Drawing.Size(259, 23);
            this.txtCourse.TabIndex = 1;
            this.txtCourse.UseSystemPasswordChar = false;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Depth = 0;
            this.lblCourse.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCourse.Location = new System.Drawing.Point(3, 3);
            this.lblCourse.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(101, 19);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Course Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtGridUnits);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 431);
            this.panel3.TabIndex = 2;
            // 
            // dtGridUnits
            // 
            this.dtGridUnits.AllowUserToAddRows = false;
            this.dtGridUnits.AllowUserToDeleteRows = false;
            this.dtGridUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.unit_name});
            this.dtGridUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridUnits.Location = new System.Drawing.Point(0, 0);
            this.dtGridUnits.Name = "dtGridUnits";
            this.dtGridUnits.ReadOnly = true;
            this.dtGridUnits.Size = new System.Drawing.Size(633, 431);
            this.dtGridUnits.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // unit_name
            // 
            this.unit_name.HeaderText = "Unit-Name";
            this.unit_name.Name = "unit_name";
            this.unit_name.ReadOnly = true;
            // 
            // CourseUnitsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 498);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.Name = "CourseUnitsManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseUnitsManager";
            this.Load += new System.EventHandler(this.CourseUnitsManager_Load);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUnits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelRight;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescription;
        private MaterialSkin.Controls.MaterialLabel lblDescription;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUnitName;
        private MaterialSkin.Controls.MaterialLabel lblUnitName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCourse;
        private MaterialSkin.Controls.MaterialLabel lblCourse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtGridUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_name;
    }
}