
namespace frmLogin
{
    partial class frmOutputBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutputBill));
            this.rpvOutputBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvOutputBill
            // 
            this.rpvOutputBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvOutputBill.LocalReport.ReportEmbeddedResource = "frmLogin.Bill.rdlc";
            this.rpvOutputBill.Location = new System.Drawing.Point(0, 0);
            this.rpvOutputBill.Margin = new System.Windows.Forms.Padding(4);
            this.rpvOutputBill.Name = "rpvOutputBill";
            this.rpvOutputBill.ServerReport.BearerToken = null;
            this.rpvOutputBill.Size = new System.Drawing.Size(825, 554);
            this.rpvOutputBill.TabIndex = 0;
            // 
            // frmOutputBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 554);
            this.Controls.Add(this.rpvOutputBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOutputBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất hóa đơn";
            this.Load += new System.EventHandler(this.frmOutputBill_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOutputBill_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvOutputBill;
    }
}