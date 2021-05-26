namespace StudentRecordManagementSystem
{
    partial class FingerprintVerify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FingerprintVerify));
            this.panelMessage = new System.Windows.Forms.Panel();
            this.txtMessage = new MaterialSkin.Controls.MaterialLabel();
            this.txtFingerPrintMsg = new MaterialSkin.Controls.MaterialLabel();
            this.groupFingerprint = new System.Windows.Forms.GroupBox();
            this.btnStop = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblFingerprintTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblLeftIndex = new MaterialSkin.Controls.MaterialLabel();
            this.PictureFingerPrint = new System.Windows.Forms.PictureBox();
            this.btnScan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFinish = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panelMessage.SuspendLayout();
            this.groupFingerprint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFingerPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.Color.Transparent;
            this.panelMessage.Controls.Add(this.txtMessage);
            this.panelMessage.Location = new System.Drawing.Point(28, 111);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(306, 151);
            this.panelMessage.TabIndex = 41;
            this.panelMessage.Tag = "";
            // 
            // txtMessage
            // 
            this.txtMessage.AutoSize = true;
            this.txtMessage.Depth = 0;
            this.txtMessage.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMessage.Location = new System.Drawing.Point(3, 0);
            this.txtMessage.MaximumSize = new System.Drawing.Size(300, 150);
            this.txtMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(228, 54);
            this.txtMessage.TabIndex = 37;
            this.txtMessage.Text = "Press scan to capture fingerprint";
            // 
            // txtFingerPrintMsg
            // 
            this.txtFingerPrintMsg.AutoSize = true;
            this.txtFingerPrintMsg.Depth = 0;
            this.txtFingerPrintMsg.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtFingerPrintMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFingerPrintMsg.Location = new System.Drawing.Point(25, 81);
            this.txtFingerPrintMsg.MaximumSize = new System.Drawing.Size(306, 0);
            this.txtFingerPrintMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFingerPrintMsg.Name = "txtFingerPrintMsg";
            this.txtFingerPrintMsg.Size = new System.Drawing.Size(175, 27);
            this.txtFingerPrintMsg.TabIndex = 40;
            this.txtFingerPrintMsg.Text = "Place your finger";
            this.txtFingerPrintMsg.Visible = false;
            // 
            // groupFingerprint
            // 
            this.groupFingerprint.Controls.Add(this.btnStop);
            this.groupFingerprint.Controls.Add(this.lblFingerprintTitle);
            this.groupFingerprint.Controls.Add(this.lblLeftIndex);
            this.groupFingerprint.Controls.Add(this.PictureFingerPrint);
            this.groupFingerprint.Controls.Add(this.btnScan);
            this.groupFingerprint.Location = new System.Drawing.Point(28, 268);
            this.groupFingerprint.Name = "groupFingerprint";
            this.groupFingerprint.Size = new System.Drawing.Size(306, 271);
            this.groupFingerprint.TabIndex = 39;
            this.groupFingerprint.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.AutoSize = true;
            this.btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStop.Depth = 0;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(165, 111);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStop.Name = "btnStop";
            this.btnStop.Primary = false;
            this.btnStop.Size = new System.Drawing.Size(66, 36);
            this.btnStop.TabIndex = 41;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblFingerprintTitle
            // 
            this.lblFingerprintTitle.AutoSize = true;
            this.lblFingerprintTitle.Depth = 0;
            this.lblFingerprintTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFingerprintTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFingerprintTitle.Location = new System.Drawing.Point(6, 22);
            this.lblFingerprintTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFingerprintTitle.Name = "lblFingerprintTitle";
            this.lblFingerprintTitle.Size = new System.Drawing.Size(213, 27);
            this.lblFingerprintTitle.TabIndex = 40;
            this.lblFingerprintTitle.Text = "Fingerprint Capturing";
            // 
            // lblLeftIndex
            // 
            this.lblLeftIndex.AutoSize = true;
            this.lblLeftIndex.Depth = 0;
            this.lblLeftIndex.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLeftIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLeftIndex.Location = new System.Drawing.Point(6, 49);
            this.lblLeftIndex.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLeftIndex.Name = "lblLeftIndex";
            this.lblLeftIndex.Size = new System.Drawing.Size(115, 27);
            this.lblLeftIndex.TabIndex = 38;
            this.lblLeftIndex.Text = "Fingerprint";
            // 
            // PictureFingerPrint
            // 
            this.PictureFingerPrint.Image = ((System.Drawing.Image)(resources.GetObject("PictureFingerPrint.Image")));
            this.PictureFingerPrint.Location = new System.Drawing.Point(11, 79);
            this.PictureFingerPrint.Name = "PictureFingerPrint";
            this.PictureFingerPrint.Size = new System.Drawing.Size(119, 105);
            this.PictureFingerPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureFingerPrint.TabIndex = 37;
            this.PictureFingerPrint.TabStop = false;
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.Red;
            this.btnScan.Depth = 0;
            this.btnScan.Enabled = false;
            this.btnScan.Location = new System.Drawing.Point(11, 204);
            this.btnScan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnScan.Name = "btnScan";
            this.btnScan.Primary = true;
            this.btnScan.Size = new System.Drawing.Size(289, 45);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Confirm Attendance";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.DarkRed;
            this.btnFinish.Depth = 0;
            this.btnFinish.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFinish.Location = new System.Drawing.Point(28, 558);
            this.btnFinish.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Primary = true;
            this.btnFinish.Size = new System.Drawing.Size(306, 45);
            this.btnFinish.TabIndex = 42;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            // 
            // FingerprintVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 624);
            this.ControlBox = false;
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.txtFingerPrintMsg);
            this.Controls.Add(this.groupFingerprint);
            this.DoubleBuffered = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FingerprintVerify";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Finger Print Scanner";
            this.Load += new System.EventHandler(this.FingerPrintScanner_Load);
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            this.groupFingerprint.ResumeLayout(false);
            this.groupFingerprint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFingerPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMessage;
        private MaterialSkin.Controls.MaterialLabel txtMessage;
        private MaterialSkin.Controls.MaterialLabel txtFingerPrintMsg;
        private System.Windows.Forms.GroupBox groupFingerprint;
        private MaterialSkin.Controls.MaterialLabel lblFingerprintTitle;
        private System.Windows.Forms.PictureBox PictureFingerPrint;
        private MaterialSkin.Controls.MaterialRaisedButton btnScan;
        private MaterialSkin.Controls.MaterialLabel lblLeftIndex;
        private MaterialSkin.Controls.MaterialFlatButton btnStop;
        private MaterialSkin.Controls.MaterialRaisedButton btnFinish;
    }
}