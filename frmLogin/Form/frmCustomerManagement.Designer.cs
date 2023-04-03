
namespace frmLogin
{
    partial class frmCustomerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSortCustomer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFillCustomer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvListCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDeleteAllECustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDeleted = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCustomer = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sắp xếp";
            // 
            // cbSortCustomer
            // 
            this.cbSortCustomer.BackColor = System.Drawing.Color.Transparent;
            this.cbSortCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSortCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortCustomer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSortCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSortCustomer.ItemHeight = 30;
            this.cbSortCustomer.Location = new System.Drawing.Point(12, 42);
            this.cbSortCustomer.Name = "cbSortCustomer";
            this.cbSortCustomer.Size = new System.Drawing.Size(146, 36);
            this.cbSortCustomer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(725, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lọc";
            // 
            // cbFillCustomer
            // 
            this.cbFillCustomer.BackColor = System.Drawing.Color.Transparent;
            this.cbFillCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFillCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillCustomer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFillCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFillCustomer.ItemHeight = 30;
            this.cbFillCustomer.Location = new System.Drawing.Point(728, 43);
            this.cbFillCustomer.Name = "cbFillCustomer";
            this.cbFillCustomer.Size = new System.Drawing.Size(143, 36);
            this.cbFillCustomer.TabIndex = 3;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCustomer.DefaultText = "";
            this.txtSearchCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomer.Location = new System.Drawing.Point(249, 43);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.PasswordChar = '\0';
            this.txtSearchCustomer.PlaceholderText = "";
            this.txtSearchCustomer.SelectedText = "";
            this.txtSearchCustomer.Size = new System.Drawing.Size(272, 36);
            this.txtSearchCustomer.TabIndex = 4;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(527, 43);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(105, 36);
            this.guna2Button1.TabIndex = 5;
            // 
            // dtgvListCustomer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvListCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvListCustomer.ColumnHeadersHeight = 4;
            this.dtgvListCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvListCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListCustomer.Location = new System.Drawing.Point(15, 85);
            this.dtgvListCustomer.Name = "dtgvListCustomer";
            this.dtgvListCustomer.RowHeadersVisible = false;
            this.dtgvListCustomer.RowHeadersWidth = 51;
            this.dtgvListCustomer.RowTemplate.Height = 24;
            this.dtgvListCustomer.Size = new System.Drawing.Size(856, 419);
            this.dtgvListCustomer.TabIndex = 6;
            this.dtgvListCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListCustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvListCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvListCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvListCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvListCustomer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListCustomer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListCustomer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvListCustomer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvListCustomer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListCustomer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvListCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListCustomer.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvListCustomer.ThemeStyle.ReadOnly = false;
            this.dtgvListCustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListCustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListCustomer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListCustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListCustomer.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvListCustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListCustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnDeleteAllECustomer
            // 
            this.btnDeleteAllECustomer.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteAllECustomer.BorderRadius = 10;
            this.btnDeleteAllECustomer.BorderThickness = 2;
            this.btnDeleteAllECustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllECustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllECustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAllECustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAllECustomer.FillColor = System.Drawing.Color.White;
            this.btnDeleteAllECustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteAllECustomer.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAllECustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllECustomer.Image")));
            this.btnDeleteAllECustomer.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteAllECustomer.Location = new System.Drawing.Point(882, 461);
            this.btnDeleteAllECustomer.Name = "btnDeleteAllECustomer";
            this.btnDeleteAllECustomer.Size = new System.Drawing.Size(159, 43);
            this.btnDeleteAllECustomer.TabIndex = 32;
            this.btnDeleteAllECustomer.Text = "Xóa tất cả";
            // 
            // btnCustomerDeleted
            // 
            this.btnCustomerDeleted.BorderRadius = 20;
            this.btnCustomerDeleted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDeleted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDeleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerDeleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerDeleted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(184)))));
            this.btnCustomerDeleted.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCustomerDeleted.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerDeleted.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerDeleted.Image")));
            this.btnCustomerDeleted.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomerDeleted.Location = new System.Drawing.Point(882, 385);
            this.btnCustomerDeleted.Name = "btnCustomerDeleted";
            this.btnCustomerDeleted.Size = new System.Drawing.Size(159, 45);
            this.btnCustomerDeleted.TabIndex = 31;
            this.btnCustomerDeleted.Text = "Khách hàng đã xóa";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BorderRadius = 20;
            this.btnDeleteCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomer.Image")));
            this.btnDeleteCustomer.ImageSize = new System.Drawing.Size(45, 45);
            this.btnDeleteCustomer.Location = new System.Drawing.Point(877, 229);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(164, 45);
            this.btnDeleteCustomer.TabIndex = 30;
            this.btnDeleteCustomer.Text = "Xóa";
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BorderRadius = 20;
            this.btnEditCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btnEditCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnEditCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCustomer.Image")));
            this.btnEditCustomer.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEditCustomer.Location = new System.Drawing.Point(877, 159);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(164, 45);
            this.btnEditCustomer.TabIndex = 29;
            this.btnEditCustomer.Text = "Sửa";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BorderRadius = 20;
            this.btnAddCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.Image")));
            this.btnAddCustomer.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddCustomer.Location = new System.Drawing.Point(877, 96);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(164, 45);
            this.btnAddCustomer.TabIndex = 28;
            this.btnAddCustomer.Text = "Thêm";
            // 
            // frmCustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 516);
            this.Controls.Add(this.btnDeleteAllECustomer);
            this.Controls.Add(this.btnCustomerDeleted);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.dtgvListCustomer);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.cbFillCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSortCustomer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCustomerManagement";
            this.Text = "frmCustomerManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortCustomer;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbFillCustomer;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchCustomer;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvListCustomer;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAllECustomer;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDeleted;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCustomer;
        private Guna.UI2.WinForms.Guna2Button btnEditCustomer;
        private Guna.UI2.WinForms.Guna2Button btnAddCustomer;
    }
}