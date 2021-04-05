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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDepartmentName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDeparmentName = new MaterialSkin.Controls.MaterialLabel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContainerGrid = new System.Windows.Forms.Panel();
            this.dtGridDepartment = new System.Windows.Forms.DataGridView();
            this.flowLayoutSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelContainerGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDepartment)).BeginInit();
            this.flowLayoutSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 215);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(266, 184);
            this.panelButtons.TabIndex = 0;
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
            this.btnClear.Size = new System.Drawing.Size(54, 36);
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
            this.panel3.Size = new System.Drawing.Size(266, 215);
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
            this.txtDepartmentName.Size = new System.Drawing.Size(198, 23);
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
            this.lblDeparmentName.Size = new System.Drawing.Size(131, 19);
            this.lblDeparmentName.TabIndex = 2;
            this.lblDeparmentName.Text = "Department Name";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panel3);
            this.panelLeft.Controls.Add(this.panelButtons);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLeft.Location = new System.Drawing.Point(471, 64);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(266, 399);
            this.panelLeft.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelContainerGrid);
            this.panel2.Controls.Add(this.flowLayoutSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 399);
            this.panel2.TabIndex = 2;
            // 
            // panelContainerGrid
            // 
            this.panelContainerGrid.Controls.Add(this.dtGridDepartment);
            this.panelContainerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainerGrid.Location = new System.Drawing.Point(0, 57);
            this.panelContainerGrid.Name = "panelContainerGrid";
            this.panelContainerGrid.Size = new System.Drawing.Size(737, 342);
            this.panelContainerGrid.TabIndex = 2;
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
            this.dtGridDepartment.Size = new System.Drawing.Size(737, 342);
            this.dtGridDepartment.TabIndex = 1;
            // 
            // flowLayoutSearch
            // 
            this.flowLayoutSearch.Controls.Add(this.txtSearch);
            this.flowLayoutSearch.Controls.Add(this.btnSearch);
            this.flowLayoutSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutSearch.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutSearch.Name = "flowLayoutSearch";
            this.flowLayoutSearch.Size = new System.Drawing.Size(737, 57);
            this.flowLayoutSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(5, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 10, 3, 3);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(288, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Depth = 0;
            this.btnSearch.Location = new System.Drawing.Point(300, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = false;
            this.btnSearch.Size = new System.Drawing.Size(64, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 463);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentForm";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelContainerGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDepartment)).EndInit();
            this.flowLayoutSearch.ResumeLayout(false);
            this.flowLayoutSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialFlatButton btnClear;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDepartmentName;
        private MaterialSkin.Controls.MaterialLabel lblDeparmentName;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutSearch;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContainerGrid;
        private System.Windows.Forms.DataGridView dtGridDepartment;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialFlatButton btnSearch;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}