
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SortAccount = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchAccount = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearchAccount = new Guna.UI2.WinForms.Guna2Button();
            this.cbFillAccount = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAccount = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvListAccount = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(788, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lọc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sắp xếp";
            // 
            // SortAccount
            // 
            this.SortAccount.BackColor = System.Drawing.Color.Transparent;
            this.SortAccount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SortAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortAccount.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SortAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SortAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SortAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SortAccount.ItemHeight = 30;
            this.SortAccount.Location = new System.Drawing.Point(12, 48);
            this.SortAccount.Name = "SortAccount";
            this.SortAccount.Size = new System.Drawing.Size(140, 36);
            this.SortAccount.TabIndex = 12;
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchAccount.DefaultText = "";
            this.txtSearchAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchAccount.Location = new System.Drawing.Point(292, 48);
            this.txtSearchAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.PasswordChar = '\0';
            this.txtSearchAccount.PlaceholderText = "";
            this.txtSearchAccount.SelectedText = "";
            this.txtSearchAccount.Size = new System.Drawing.Size(285, 36);
            this.txtSearchAccount.TabIndex = 13;
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.BorderRadius = 10;
            this.btnSearchAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchAccount.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearchAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchAccount.ForeColor = System.Drawing.Color.White;
            this.btnSearchAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchAccount.Image")));
            this.btnSearchAccount.Location = new System.Drawing.Point(583, 49);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(92, 36);
            this.btnSearchAccount.TabIndex = 14;
            // 
            // cbFillAccount
            // 
            this.cbFillAccount.BackColor = System.Drawing.Color.Transparent;
            this.cbFillAccount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFillAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillAccount.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFillAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFillAccount.ItemHeight = 30;
            this.cbFillAccount.Location = new System.Drawing.Point(791, 49);
            this.cbFillAccount.Name = "cbFillAccount";
            this.cbFillAccount.Size = new System.Drawing.Size(150, 36);
            this.cbFillAccount.TabIndex = 16;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BorderRadius = 20;
            this.btnAddAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnAddAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAddAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAccount.Image")));
            this.btnAddAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddAccount.Location = new System.Drawing.Point(969, 118);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(170, 45);
            this.btnAddAccount.TabIndex = 17;
            this.btnAddAccount.Text = "Thêm";
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.BorderRadius = 20;
            this.btnEditAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btnEditAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditAccount.ForeColor = System.Drawing.Color.Black;
            this.btnEditAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnEditAccount.Image")));
            this.btnEditAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEditAccount.Location = new System.Drawing.Point(969, 205);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(170, 45);
            this.btnEditAccount.TabIndex = 18;
            this.btnEditAccount.Text = "Sửa";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BorderRadius = 20;
            this.btnDeleteAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.btnDeleteAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAccount.Image")));
            this.btnDeleteAccount.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDeleteAccount.Location = new System.Drawing.Point(969, 299);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(170, 45);
            this.btnDeleteAccount.TabIndex = 19;
            this.btnDeleteAccount.Text = "Xóa";
            // 
            // dtgvListAccount
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgvListAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvListAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListAccount.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvListAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListAccount.Location = new System.Drawing.Point(12, 91);
            this.dtgvListAccount.Name = "dtgvListAccount";
            this.dtgvListAccount.RowHeadersVisible = false;
            this.dtgvListAccount.RowHeadersWidth = 51;
            this.dtgvListAccount.RowTemplate.Height = 24;
            this.dtgvListAccount.Size = new System.Drawing.Size(929, 387);
            this.dtgvListAccount.TabIndex = 20;
            this.dtgvListAccount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListAccount.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvListAccount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvListAccount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvListAccount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvListAccount.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListAccount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListAccount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvListAccount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvListAccount.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListAccount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvListAccount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListAccount.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvListAccount.ThemeStyle.ReadOnly = false;
            this.dtgvListAccount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListAccount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListAccount.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListAccount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListAccount.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvListAccount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListAccount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 514);
            this.Controls.Add(this.dtgvListAccount);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnEditAccount);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.cbFillAccount);
            this.Controls.Add(this.btnSearchAccount);
            this.Controls.Add(this.txtSearchAccount);
            this.Controls.Add(this.SortAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAccountManagement";
            this.Text = "frmAccountManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox SortAccount;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchAccount;
        private Guna.UI2.WinForms.Guna2Button btnSearchAccount;
        private Guna.UI2.WinForms.Guna2ComboBox cbFillAccount;
        private Guna.UI2.WinForms.Guna2Button btnAddAccount;
        private Guna.UI2.WinForms.Guna2Button btnEditAccount;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAccount;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvListAccount;
    }
}