namespace StudentRecordManagementSystem
{
    partial class DepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDepartmentName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDeparmentName = new MaterialSkin.Controls.MaterialLabel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.dtGridDepartment = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mainCenterPanel = new System.Windows.Forms.Panel();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.mainCenterPanel.SuspendLayout();
            this.gridPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(24, 126);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(137, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Depth = 0;
            this.btnClear.Location = new System.Drawing.Point(168, 126);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = false;
            this.btnClear.Size = new System.Drawing.Size(77, 36);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.txtDepartmentName);
            this.panel3.Controls.Add(this.lblDeparmentName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 399);
            this.panel3.TabIndex = 1;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Depth = 0;
            this.txtDepartmentName.Hint = "";
            this.txtDepartmentName.Location = new System.Drawing.Point(24, 97);
            this.txtDepartmentName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.PasswordChar = '\0';
            this.txtDepartmentName.SelectedText = "";
            this.txtDepartmentName.SelectionLength = 0;
            this.txtDepartmentName.SelectionStart = 0;
            this.txtDepartmentName.Size = new System.Drawing.Size(198, 32);
            this.txtDepartmentName.TabIndex = 3;
            this.txtDepartmentName.UseSystemPasswordChar = false;
            // 
            // lblDeparmentName
            // 
            this.lblDeparmentName.AutoSize = true;
            this.lblDeparmentName.Depth = 0;
            this.lblDeparmentName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDeparmentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDeparmentName.Location = new System.Drawing.Point(20, 75);
            this.lblDeparmentName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeparmentName.Name = "lblDeparmentName";
            this.lblDeparmentName.Size = new System.Drawing.Size(190, 27);
            this.lblDeparmentName.TabIndex = 2;
            this.lblDeparmentName.Text = "Department Name";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panel3);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLeft.Location = new System.Drawing.Point(471, 64);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(266, 399);
            this.panelLeft.TabIndex = 3;
            // 
            // dtGridDepartment
            // 
            this.dtGridDepartment.AllowUserToAddRows = false;
            this.dtGridDepartment.AllowUserToDeleteRows = false;
            this.dtGridDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridDepartment.Location = new System.Drawing.Point(0, 0);
            this.dtGridDepartment.Name = "dtGridDepartment";
            this.dtGridDepartment.ReadOnly = true;
            this.dtGridDepartment.Size = new System.Drawing.Size(471, 399);
            this.dtGridDepartment.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Enabled = false;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(737, 64);
            this.panelTop.TabIndex = 0;
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // mainCenterPanel
            // 
            this.mainCenterPanel.Controls.Add(this.gridPanel);
            this.mainCenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainCenterPanel.Location = new System.Drawing.Point(0, 64);
            this.mainCenterPanel.Name = "mainCenterPanel";
            this.mainCenterPanel.Size = new System.Drawing.Size(471, 399);
            this.mainCenterPanel.TabIndex = 4;
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.dtGridDepartment);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Location = new System.Drawing.Point(0, 0);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(471, 399);
            this.gridPanel.TabIndex = 4;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 463);
            this.Controls.Add(this.mainCenterPanel);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentForm";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.mainCenterPanel.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialFlatButton btnClear;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDepartmentName;
        private MaterialSkin.Controls.MaterialLabel lblDeparmentName;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridView dtGridDepartment;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Panel mainCenterPanel;
        private System.Windows.Forms.Panel gridPanel;
    }
}