namespace StudentRecordManagementSystem.Common
{
    partial class SessionPick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionPick));
            this.lblSession = new MaterialSkin.Controls.MaterialLabel();
            this.cbxSessions = new System.Windows.Forms.ComboBox();
            this.btnChoose = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Depth = 0;
            this.lblSession.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSession.Location = new System.Drawing.Point(21, 165);
            this.lblSession.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(89, 27);
            this.lblSession.TabIndex = 0;
            this.lblSession.Text = "Session";
            // 
            // cbxSessions
            // 
            this.cbxSessions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSessions.FormattingEnabled = true;
            this.cbxSessions.Location = new System.Drawing.Point(138, 165);
            this.cbxSessions.Name = "cbxSessions";
            this.cbxSessions.Size = new System.Drawing.Size(335, 34);
            this.cbxSessions.TabIndex = 1;
            this.cbxSessions.SelectedValueChanged += new System.EventHandler(this.cbxSessions_SelectedValueChanged);
            // 
            // btnChoose
            // 
            this.btnChoose.Depth = 0;
            this.btnChoose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChoose.Location = new System.Drawing.Point(138, 218);
            this.btnChoose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Primary = true;
            this.btnChoose.Size = new System.Drawing.Size(147, 40);
            this.btnChoose.TabIndex = 2;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(326, 218);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(147, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(133, 106);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 27);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Choose sesssion";
            // 
            // SessionPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 270);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.cbxSessions);
            this.Controls.Add(this.lblSession);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SessionPick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Session Pick";
            this.Load += new System.EventHandler(this.SessionPick_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblSession;
        private System.Windows.Forms.ComboBox cbxSessions;
        private MaterialSkin.Controls.MaterialRaisedButton btnChoose;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
    }
}