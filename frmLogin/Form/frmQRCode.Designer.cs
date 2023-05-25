
namespace frmLogin
{
    partial class frmQRCode
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
            this.btnScan = new System.Windows.Forms.Button();
            this.cboCamara = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(282, 402);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(89, 23);
            this.btnScan.TabIndex = 9;
            this.btnScan.Text = "Quét QR";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cboCamara
            // 
            this.cboCamara.FormattingEnabled = true;
            this.cboCamara.Location = new System.Drawing.Point(90, 9);
            this.cboCamara.Name = "cboCamara";
            this.cboCamara.Size = new System.Drawing.Size(208, 21);
            this.cboCamara.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn Camara";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picQR
            // 
            this.picQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQR.Location = new System.Drawing.Point(11, 36);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(360, 360);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQR.TabIndex = 7;
            this.picQR.TabStop = false;
            // 
            // frmQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.cboCamara);
            this.Controls.Add(this.label1);
            this.Name = "frmQRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQRCode_FormClosing);
            this.Load += new System.EventHandler(this.frmQRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.ComboBox cboCamara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}