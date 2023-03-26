
namespace frmLogin
{
    partial class frmAccountManagement
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
            this.dtgvListAccount = new System.Windows.Forms.DataGridView();
            this.txtSearchAccount = new System.Windows.Forms.TextBox();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSortAccount = new System.Windows.Forms.ComboBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbArrageAccount = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvListAccount
            // 
            this.dtgvListAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListAccount.Location = new System.Drawing.Point(14, 70);
            this.dtgvListAccount.Name = "dtgvListAccount";
            this.dtgvListAccount.RowHeadersWidth = 51;
            this.dtgvListAccount.RowTemplate.Height = 24;
            this.dtgvListAccount.Size = new System.Drawing.Size(989, 408);
            this.dtgvListAccount.TabIndex = 1;
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAccount.Location = new System.Drawing.Point(271, 32);
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.Size = new System.Drawing.Size(300, 27);
            this.txtSearchAccount.TabIndex = 2;
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.Location = new System.Drawing.Point(589, 30);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(98, 30);
            this.btnSearchAccount.TabIndex = 3;
            this.btnSearchAccount.Text = "Tìm kiếm";
            this.btnSearchAccount.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(782, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lọc";
            // 
            // cbSortAccount
            // 
            this.cbSortAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortAccount.FormattingEnabled = true;
            this.cbSortAccount.Items.AddRange(new object[] {
            "Tất cả",
            "Nhân viên bán hàng",
            "Nhân viên quản lý"});
            this.cbSortAccount.Location = new System.Drawing.Point(836, 34);
            this.cbSortAccount.Name = "cbSortAccount";
            this.cbSortAccount.Size = new System.Drawing.Size(167, 26);
            this.cbSortAccount.TabIndex = 5;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(1009, 148);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(91, 39);
            this.btnAddAccount.TabIndex = 6;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(1009, 209);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(91, 39);
            this.btnEditAccount.TabIndex = 7;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(1009, 273);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(91, 39);
            this.btnDeleteAccount.TabIndex = 8;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sắp xếp";
            // 
            // cbArrageAccount
            // 
            this.cbArrageAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArrageAccount.FormattingEnabled = true;
            this.cbArrageAccount.Items.AddRange(new object[] {
            "Theo mã",
            "Theo tên tài khoản"});
            this.cbArrageAccount.Location = new System.Drawing.Point(15, 34);
            this.cbArrageAccount.Name = "cbArrageAccount";
            this.cbArrageAccount.Size = new System.Drawing.Size(165, 26);
            this.cbArrageAccount.TabIndex = 10;
            // 
            // frmAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 490);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbArrageAccount);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnEditAccount);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.cbSortAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchAccount);
            this.Controls.Add(this.txtSearchAccount);
            this.Controls.Add(this.dtgvListAccount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAccountManagement";
            this.Text = "frmAccountManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvListAccount;
        private System.Windows.Forms.TextBox txtSearchAccount;
        private System.Windows.Forms.Button btnSearchAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSortAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbArrageAccount;
    }
}