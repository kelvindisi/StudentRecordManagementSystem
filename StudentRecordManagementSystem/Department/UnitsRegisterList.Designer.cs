namespace StudentRecordManagementSystem
{
    partial class UnitsRegisterList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitsRegisterList));
            this.topPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.registeredList = new System.Windows.Forms.Panel();
            this.listPanel = new System.Windows.Forms.Panel();
            this.dtGridSessCourseUnits = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enroll = new System.Windows.Forms.DataGridViewButtonColumn();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.btnSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new MaterialSkin.Controls.MaterialLabel();
            this.mainPanel.SuspendLayout();
            this.registeredList.SuspendLayout();
            this.listPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSessCourseUnits)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Enabled = false;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1080, 88);
            this.topPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.registeredList);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 88);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1080, 547);
            this.mainPanel.TabIndex = 1;
            // 
            // registeredList
            // 
            this.registeredList.Controls.Add(this.listPanel);
            this.registeredList.Controls.Add(this.searchPanel);
            this.registeredList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registeredList.Location = new System.Drawing.Point(0, 0);
            this.registeredList.Name = "registeredList";
            this.registeredList.Size = new System.Drawing.Size(1080, 547);
            this.registeredList.TabIndex = 1;
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.dtGridSessCourseUnits);
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanel.Location = new System.Drawing.Point(0, 69);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(1080, 478);
            this.listPanel.TabIndex = 1;
            // 
            // dtGridSessCourseUnits
            // 
            this.dtGridSessCourseUnits.AllowUserToAddRows = false;
            this.dtGridSessCourseUnits.AllowUserToDeleteRows = false;
            this.dtGridSessCourseUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSessCourseUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.unitId,
            this.unitCode,
            this.unitName,
            this.Enroll});
            this.dtGridSessCourseUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridSessCourseUnits.Location = new System.Drawing.Point(0, 0);
            this.dtGridSessCourseUnits.Name = "dtGridSessCourseUnits";
            this.dtGridSessCourseUnits.ReadOnly = true;
            this.dtGridSessCourseUnits.RowTemplate.Height = 28;
            this.dtGridSessCourseUnits.Size = new System.Drawing.Size(1080, 478);
            this.dtGridSessCourseUnits.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // unitId
            // 
            this.unitId.HeaderText = "UnitId";
            this.unitId.Name = "unitId";
            this.unitId.ReadOnly = true;
            this.unitId.Visible = false;
            // 
            // unitCode
            // 
            this.unitCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.unitCode.HeaderText = "Unit Code";
            this.unitCode.Name = "unitCode";
            this.unitCode.ReadOnly = true;
            this.unitCode.Width = 116;
            // 
            // unitName
            // 
            this.unitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitName.HeaderText = "Unit Name";
            this.unitName.Name = "unitName";
            this.unitName.ReadOnly = true;
            // 
            // Enroll
            // 
            this.Enroll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Enroll.DefaultCellStyle = dataGridViewCellStyle1;
            this.Enroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enroll.HeaderText = "Enroll";
            this.Enroll.Name = "Enroll";
            this.Enroll.ReadOnly = true;
            this.Enroll.Width = 55;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.btnSearch);
            this.searchPanel.Controls.Add(this.txtSearch);
            this.searchPanel.Controls.Add(this.lblSearch);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1080, 69);
            this.searchPanel.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Depth = 0;
            this.btnSearch.Location = new System.Drawing.Point(655, 18);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = true;
            this.btnSearch.Size = new System.Drawing.Size(118, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(71, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(578, 32);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Depth = 0;
            this.lblSearch.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSearch.Location = new System.Drawing.Point(12, 21);
            this.lblSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 27);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Find";
            // 
            // UnitsRegisterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 635);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnitsRegisterList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UnitsRegisterList";
            this.Load += new System.EventHandler(this.UnitsRegisterList_Load);
            this.mainPanel.ResumeLayout(false);
            this.registeredList.ResumeLayout(false);
            this.listPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSessCourseUnits)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel registeredList;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.DataGridView dtGridSessCourseUnits;
        private System.Windows.Forms.Panel searchPanel;
        private MaterialSkin.Controls.MaterialRaisedButton btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private MaterialSkin.Controls.MaterialLabel lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitName;
        private System.Windows.Forms.DataGridViewButtonColumn Enroll;
    }
}