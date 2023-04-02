
namespace frmLogin
{
    partial class frmQuanLyAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyAdmin));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.btnEmployeeManager = new System.Windows.Forms.Button();
            this.btnAccountManagement = new System.Windows.Forms.Button();
            this.btnProducManagement = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCustomerManagement = new System.Windows.Forms.Button();
            this.btnBillManagement = new System.Windows.Forms.Button();
            this.btnTableManagement = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnTableManagement);
            this.panelMenu.Controls.Add(this.btnBillManagement);
            this.panelMenu.Controls.Add(this.btnCustomerManagement);
            this.panelMenu.Controls.Add(this.btnStatistical);
            this.panelMenu.Controls.Add(this.btnEmployeeManager);
            this.panelMenu.Controls.Add(this.btnAccountManagement);
            this.panelMenu.Controls.Add(this.btnProducManagement);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(209, 702);
            this.panelMenu.TabIndex = 0;
            // 
            // btnStatistical
            // 
            this.btnStatistical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnStatistical.FlatAppearance.BorderSize = 0;
            this.btnStatistical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistical.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStatistical.Location = new System.Drawing.Point(0, 627);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(209, 75);
            this.btnStatistical.TabIndex = 4;
            this.btnStatistical.Text = "Thống kê";
            this.btnStatistical.UseVisualStyleBackColor = false;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // btnEmployeeManager
            // 
            this.btnEmployeeManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnEmployeeManager.FlatAppearance.BorderSize = 0;
            this.btnEmployeeManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmployeeManager.Location = new System.Drawing.Point(3, 323);
            this.btnEmployeeManager.Name = "btnEmployeeManager";
            this.btnEmployeeManager.Size = new System.Drawing.Size(209, 70);
            this.btnEmployeeManager.TabIndex = 3;
            this.btnEmployeeManager.Text = "Quản lý nhân viên";
            this.btnEmployeeManager.UseVisualStyleBackColor = false;
            this.btnEmployeeManager.Click += new System.EventHandler(this.btnEmployeeManager_Click);
            // 
            // btnAccountManagement
            // 
            this.btnAccountManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnAccountManagement.FlatAppearance.BorderSize = 0;
            this.btnAccountManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAccountManagement.Location = new System.Drawing.Point(-3, 237);
            this.btnAccountManagement.Name = "btnAccountManagement";
            this.btnAccountManagement.Size = new System.Drawing.Size(209, 80);
            this.btnAccountManagement.TabIndex = 2;
            this.btnAccountManagement.Text = "Quản lý tài khoản";
            this.btnAccountManagement.UseVisualStyleBackColor = false;
            this.btnAccountManagement.Click += new System.EventHandler(this.btnAccountManagement_Click);
            // 
            // btnProducManagement
            // 
            this.btnProducManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnProducManagement.FlatAppearance.BorderSize = 0;
            this.btnProducManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducManagement.Location = new System.Drawing.Point(0, 161);
            this.btnProducManagement.Name = "btnProducManagement";
            this.btnProducManagement.Size = new System.Drawing.Size(209, 70);
            this.btnProducManagement.TabIndex = 1;
            this.btnProducManagement.Text = "Quản lý sản phẩm";
            this.btnProducManagement.UseVisualStyleBackColor = false;
            this.btnProducManagement.Click += new System.EventHandler(this.btnProducManagement_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(209, 158);
            this.panelLogo.TabIndex = 1;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.btnExit);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(209, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1198, 154);
            this.panelTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(416, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(307, 69);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Trang chủ";
            // 
            // btnCustomerManagement
            // 
            this.btnCustomerManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnCustomerManagement.FlatAppearance.BorderSize = 0;
            this.btnCustomerManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCustomerManagement.Location = new System.Drawing.Point(0, 399);
            this.btnCustomerManagement.Name = "btnCustomerManagement";
            this.btnCustomerManagement.Size = new System.Drawing.Size(209, 70);
            this.btnCustomerManagement.TabIndex = 5;
            this.btnCustomerManagement.Text = "Quản lý khách hàng";
            this.btnCustomerManagement.UseVisualStyleBackColor = false;
            this.btnCustomerManagement.Click += new System.EventHandler(this.btnCustomerManagement_Click);
            // 
            // btnBillManagement
            // 
            this.btnBillManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnBillManagement.FlatAppearance.BorderSize = 0;
            this.btnBillManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBillManagement.Location = new System.Drawing.Point(-3, 475);
            this.btnBillManagement.Name = "btnBillManagement";
            this.btnBillManagement.Size = new System.Drawing.Size(209, 70);
            this.btnBillManagement.TabIndex = 6;
            this.btnBillManagement.Text = "Quản lý hóa đơn";
            this.btnBillManagement.UseVisualStyleBackColor = false;
            this.btnBillManagement.Click += new System.EventHandler(this.btnBillManagement_Click);
            // 
            // btnTableManagement
            // 
            this.btnTableManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnTableManagement.FlatAppearance.BorderSize = 0;
            this.btnTableManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTableManagement.Location = new System.Drawing.Point(0, 551);
            this.btnTableManagement.Name = "btnTableManagement";
            this.btnTableManagement.Size = new System.Drawing.Size(209, 70);
            this.btnTableManagement.TabIndex = 5;
            this.btnTableManagement.Text = "Quản lý bàn ăn";
            this.btnTableManagement.UseVisualStyleBackColor = false;
            this.btnTableManagement.Click += new System.EventHandler(this.btnTableManagement_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(209, 154);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1198, 548);
            this.panelMain.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(179, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(907, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "ℂỬ𝔸 ℍÀℕ𝔾 Ăℕ 𝕍Ặ𝕋 𝕋𝕀𝕄𝕆";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1154, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 41);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(209, 158);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // frmQuanLyAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 702);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyAdmin_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnProducManagement;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAccountManagement;
        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.Button btnEmployeeManager;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnBillManagement;
        private System.Windows.Forms.Button btnCustomerManagement;
        private System.Windows.Forms.Button btnTableManagement;
    }
}