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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseUnitsManager));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCourseValue = new MaterialSkin.Controls.MaterialLabel();
            this.numSemester = new System.Windows.Forms.NumericUpDown();
            this.lblSemester = new MaterialSkin.Controls.MaterialLabel();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtUnitCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblUnitCode = new MaterialSkin.Controls.MaterialLabel();
            this.txtUnitName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblUnitName = new MaterialSkin.Controls.MaterialLabel();
            this.lblCourse = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtGridUnits = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelRight.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSemester)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Enabled = false;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1548, 103);
            this.panelTop.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.panel1);
            this.panelRight.Controls.Add(this.numSemester);
            this.panelRight.Controls.Add(this.lblSemester);
            this.panelRight.Controls.Add(this.btnUpdate);
            this.panelRight.Controls.Add(this.btnSave);
            this.panelRight.Controls.Add(this.txtUnitCode);
            this.panelRight.Controls.Add(this.lblUnitCode);
            this.panelRight.Controls.Add(this.txtUnitName);
            this.panelRight.Controls.Add(this.lblUnitName);
            this.panelRight.Controls.Add(this.lblCourse);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1132, 103);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(416, 823);
            this.panelRight.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCourseValue);
            this.panel1.Location = new System.Drawing.Point(15, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 127);
            this.panel1.TabIndex = 9;
            // 
            // lblCourseValue
            // 
            this.lblCourseValue.AutoSize = true;
            this.lblCourseValue.Depth = 0;
            this.lblCourseValue.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCourseValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCourseValue.Location = new System.Drawing.Point(4, 0);
            this.lblCourseValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseValue.MaximumSize = new System.Drawing.Size(387, 123);
            this.lblCourseValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCourseValue.Name = "lblCourseValue";
            this.lblCourseValue.Size = new System.Drawing.Size(81, 27);
            this.lblCourseValue.TabIndex = 11;
            this.lblCourseValue.Text = "Course";
            // 
            // numSemester
            // 
            this.numSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSemester.Location = new System.Drawing.Point(10, 352);
            this.numSemester.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSemester.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSemester.Name = "numSemester";
            this.numSemester.Size = new System.Drawing.Size(87, 33);
            this.numSemester.TabIndex = 4;
            this.numSemester.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Depth = 0;
            this.lblSemester.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSemester.Location = new System.Drawing.Point(3, 318);
            this.lblSemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSemester.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(105, 27);
            this.lblSemester.TabIndex = 8;
            this.lblSemester.Text = "Semester";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(10, 466);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(388, 58);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(10, 398);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(388, 58);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUnitCode
            // 
            this.txtUnitCode.Depth = 0;
            this.txtUnitCode.Hint = "";
            this.txtUnitCode.Location = new System.Drawing.Point(4, 278);
            this.txtUnitCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUnitCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUnitCode.Name = "txtUnitCode";
            this.txtUnitCode.PasswordChar = '\0';
            this.txtUnitCode.SelectedText = "";
            this.txtUnitCode.SelectionLength = 0;
            this.txtUnitCode.SelectionStart = 0;
            this.txtUnitCode.Size = new System.Drawing.Size(393, 32);
            this.txtUnitCode.TabIndex = 3;
            this.txtUnitCode.UseSystemPasswordChar = false;
            // 
            // lblUnitCode
            // 
            this.lblUnitCode.AutoSize = true;
            this.lblUnitCode.Depth = 0;
            this.lblUnitCode.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUnitCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUnitCode.Location = new System.Drawing.Point(9, 245);
            this.lblUnitCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUnitCode.Name = "lblUnitCode";
            this.lblUnitCode.Size = new System.Drawing.Size(106, 27);
            this.lblUnitCode.TabIndex = 4;
            this.lblUnitCode.Text = "Unit Code";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Depth = 0;
            this.txtUnitName.Hint = "";
            this.txtUnitName.Location = new System.Drawing.Point(15, 208);
            this.txtUnitName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUnitName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.PasswordChar = '\0';
            this.txtUnitName.SelectedText = "";
            this.txtUnitName.SelectionLength = 0;
            this.txtUnitName.SelectionStart = 0;
            this.txtUnitName.Size = new System.Drawing.Size(388, 32);
            this.txtUnitName.TabIndex = 2;
            this.txtUnitName.UseSystemPasswordChar = false;
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Depth = 0;
            this.lblUnitName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUnitName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUnitName.Location = new System.Drawing.Point(9, 171);
            this.lblUnitName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(114, 27);
            this.lblUnitName.TabIndex = 2;
            this.lblUnitName.Text = "Unit Name";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Depth = 0;
            this.lblCourse.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCourse.Location = new System.Drawing.Point(9, 5);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(145, 27);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Course Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtGridUnits);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 103);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1132, 823);
            this.panel3.TabIndex = 2;
            // 
            // dtGridUnits
            // 
            this.dtGridUnits.AllowUserToAddRows = false;
            this.dtGridUnits.AllowUserToDeleteRows = false;
            this.dtGridUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.unitCode,
            this.unitName,
            this.semester});
            this.dtGridUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridUnits.Location = new System.Drawing.Point(0, 0);
            this.dtGridUnits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtGridUnits.Name = "dtGridUnits";
            this.dtGridUnits.ReadOnly = true;
            this.dtGridUnits.Size = new System.Drawing.Size(1132, 823);
            this.dtGridUnits.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // unitCode
            // 
            this.unitCode.HeaderText = "Unit-Code";
            this.unitCode.Name = "unitCode";
            this.unitCode.ReadOnly = true;
            // 
            // unitName
            // 
            this.unitName.HeaderText = "Unit-Name";
            this.unitName.Name = "unitName";
            this.unitName.ReadOnly = true;
            // 
            // semester
            // 
            this.semester.HeaderText = "Semester";
            this.semester.Name = "semester";
            this.semester.ReadOnly = true;
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // CourseUnitsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 926);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CourseUnitsManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Units Manager";
            this.Load += new System.EventHandler(this.CourseUnitsManager_Load);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSemester)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelRight;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUnitCode;
        private MaterialSkin.Controls.MaterialLabel lblUnitCode;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUnitName;
        private MaterialSkin.Controls.MaterialLabel lblUnitName;
        private MaterialSkin.Controls.MaterialLabel lblCourse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtGridUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn semester;
        private System.Windows.Forms.NumericUpDown numSemester;
        private MaterialSkin.Controls.MaterialLabel lblSemester;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel lblCourseValue;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}