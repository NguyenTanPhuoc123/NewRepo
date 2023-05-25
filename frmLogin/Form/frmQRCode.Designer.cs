
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
            this.cboCamara = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picQR = new System.Windows.Forms.PictureBox();
            this.btnScan = new Guna.UI2.WinForms.Guna2Button();
            this.btnExitFormQR = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCamara
            // 
            this.cboCamara.BackColor = System.Drawing.Color.White;
            this.cboCamara.FormattingEnabled = true;
            this.cboCamara.Location = new System.Drawing.Point(122, 9);
            this.cboCamara.Margin = new System.Windows.Forms.Padding(4);
            this.cboCamara.Name = "cboCamara";
            this.cboCamara.Size = new System.Drawing.Size(276, 24);
            this.cboCamara.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn Camera";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picQR
            // 
            this.picQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQR.Location = new System.Drawing.Point(15, 59);
            this.picQR.Margin = new System.Windows.Forms.Padding(4);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(479, 401);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQR.TabIndex = 7;
            this.picQR.TabStop = false;
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.White;
            this.btnScan.BorderRadius = 20;
            this.btnScan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnScan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnScan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnScan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnScan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnScan.ForeColor = System.Drawing.Color.White;
            this.btnScan.Location = new System.Drawing.Point(15, 483);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(125, 45);
            this.btnScan.TabIndex = 10;
            this.btnScan.Text = "Quét";
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnExitFormQR
            // 
            this.btnExitFormQR.BackColor = System.Drawing.Color.White;
            this.btnExitFormQR.BorderRadius = 20;
            this.btnExitFormQR.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExitFormQR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExitFormQR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExitFormQR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExitFormQR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExitFormQR.ForeColor = System.Drawing.Color.White;
            this.btnExitFormQR.Location = new System.Drawing.Point(369, 483);
            this.btnExitFormQR.Name = "btnExitFormQR";
            this.btnExitFormQR.Size = new System.Drawing.Size(125, 45);
            this.btnExitFormQR.TabIndex = 11;
            this.btnExitFormQR.Text = "Thoát";
            this.btnExitFormQR.Click += new System.EventHandler(this.btnExitFormQR_Click);
            // 
            // frmQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 554);
            this.Controls.Add(this.btnExitFormQR);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.cboCamara);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR thanh toán";
            this.Load += new System.EventHandler(this.frmQRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.ComboBox cboCamara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnScan;
        private Guna.UI2.WinForms.Guna2Button btnExitFormQR;
    }
}