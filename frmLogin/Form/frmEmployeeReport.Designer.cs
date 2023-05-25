
namespace frmLogin
{
    partial class frmEmployeeReport
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
            this.rpvStoreReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BillMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BillMenuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvStoreReport
            // 
            this.rpvStoreReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvStoreReport.Location = new System.Drawing.Point(0, 0);
            this.rpvStoreReport.Name = "rpvStoreReport";
            this.rpvStoreReport.ServerReport.BearerToken = null;
            this.rpvStoreReport.Size = new System.Drawing.Size(800, 450);
            this.rpvStoreReport.TabIndex = 0;
            // 
            // BillMenuBindingSource
            // 
            this.BillMenuBindingSource.DataSource = typeof(DTO.BillMenu);
            // 
            // frmStoreReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvStoreReport);
            this.Name = "frmStoreReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê cửa hàng";
            this.Load += new System.EventHandler(this.frmStoreReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillMenuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvStoreReport;
        private System.Windows.Forms.BindingSource BillMenuBindingSource;
    }
}