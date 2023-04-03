
namespace frmLogin
{
    partial class frmBillManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillManagement));
            this.dtgvListCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtSearchBill = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFillBill = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSortBill = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAllBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnBillDeleted = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchBill = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCustomer)).BeginInit();
            this.SuspendLayout();
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
            this.dtgvListCustomer.Location = new System.Drawing.Point(15, 80);
            this.dtgvListCustomer.Name = "dtgvListCustomer";
            this.dtgvListCustomer.RowHeadersVisible = false;
            this.dtgvListCustomer.RowHeadersWidth = 51;
            this.dtgvListCustomer.RowTemplate.Height = 24;
            this.dtgvListCustomer.Size = new System.Drawing.Size(941, 419);
            this.dtgvListCustomer.TabIndex = 39;
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
            // txtSearchBill
            // 
            this.txtSearchBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBill.DefaultText = "";
            this.txtSearchBill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchBill.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBill.Location = new System.Drawing.Point(249, 38);
            this.txtSearchBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchBill.Name = "txtSearchBill";
            this.txtSearchBill.PasswordChar = '\0';
            this.txtSearchBill.PlaceholderText = "";
            this.txtSearchBill.SelectedText = "";
            this.txtSearchBill.Size = new System.Drawing.Size(272, 36);
            this.txtSearchBill.TabIndex = 37;
            // 
            // cbFillBill
            // 
            this.cbFillBill.BackColor = System.Drawing.Color.Transparent;
            this.cbFillBill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFillBill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillBill.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillBill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillBill.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFillBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFillBill.ItemHeight = 30;
            this.cbFillBill.Location = new System.Drawing.Point(785, 38);
            this.cbFillBill.Name = "cbFillBill";
            this.cbFillBill.Size = new System.Drawing.Size(171, 36);
            this.cbFillBill.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(782, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Lọc";
            // 
            // cbSortBill
            // 
            this.cbSortBill.BackColor = System.Drawing.Color.Transparent;
            this.cbSortBill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSortBill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortBill.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortBill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortBill.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSortBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSortBill.ItemHeight = 30;
            this.cbSortBill.Location = new System.Drawing.Point(12, 37);
            this.cbSortBill.Name = "cbSortBill";
            this.cbSortBill.Size = new System.Drawing.Size(146, 36);
            this.cbSortBill.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Sắp xếp";
            // 
            // btnDeleteAllBill
            // 
            this.btnDeleteAllBill.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteAllBill.BorderRadius = 10;
            this.btnDeleteAllBill.BorderThickness = 2;
            this.btnDeleteAllBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAllBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAllBill.FillColor = System.Drawing.Color.White;
            this.btnDeleteAllBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteAllBill.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAllBill.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllBill.Image")));
            this.btnDeleteAllBill.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteAllBill.Location = new System.Drawing.Point(967, 456);
            this.btnDeleteAllBill.Name = "btnDeleteAllBill";
            this.btnDeleteAllBill.Size = new System.Drawing.Size(203, 43);
            this.btnDeleteAllBill.TabIndex = 44;
            this.btnDeleteAllBill.Text = "Xóa tất cả";
            // 
            // btnBillDeleted
            // 
            this.btnBillDeleted.BorderRadius = 20;
            this.btnBillDeleted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBillDeleted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBillDeleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBillDeleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBillDeleted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(184)))));
            this.btnBillDeleted.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBillDeleted.ForeColor = System.Drawing.Color.Black;
            this.btnBillDeleted.Image = ((System.Drawing.Image)(resources.GetObject("btnBillDeleted.Image")));
            this.btnBillDeleted.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBillDeleted.Location = new System.Drawing.Point(967, 380);
            this.btnBillDeleted.Name = "btnBillDeleted";
            this.btnBillDeleted.Size = new System.Drawing.Size(203, 45);
            this.btnBillDeleted.TabIndex = 43;
            this.btnBillDeleted.Text = "Hóa đơn đã xóa";
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.BorderRadius = 20;
            this.btnDeleteBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.btnDeleteBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteBill.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteBill.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBill.Image")));
            this.btnDeleteBill.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteBill.Location = new System.Drawing.Point(967, 172);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(203, 45);
            this.btnDeleteBill.TabIndex = 42;
            this.btnDeleteBill.Text = "Xóa";
            // 
            // btnEditBill
            // 
            this.btnEditBill.BorderRadius = 20;
            this.btnEditBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btnEditBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditBill.ForeColor = System.Drawing.Color.Black;
            this.btnEditBill.Image = ((System.Drawing.Image)(resources.GetObject("btnEditBill.Image")));
            this.btnEditBill.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEditBill.Location = new System.Drawing.Point(967, 108);
            this.btnEditBill.Name = "btnEditBill";
            this.btnEditBill.Size = new System.Drawing.Size(203, 45);
            this.btnEditBill.TabIndex = 41;
            this.btnEditBill.Text = "Sửa";
            // 
            // btnSearchBill
            // 
            this.btnSearchBill.BorderRadius = 10;
            this.btnSearchBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchBill.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearchBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchBill.ForeColor = System.Drawing.Color.White;
            this.btnSearchBill.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchBill.Image")));
            this.btnSearchBill.Location = new System.Drawing.Point(527, 38);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(105, 36);
            this.btnSearchBill.TabIndex = 38;
            // 
            // frmBillManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 516);
            this.Controls.Add(this.btnDeleteAllBill);
            this.Controls.Add(this.btnBillDeleted);
            this.Controls.Add(this.btnDeleteBill);
            this.Controls.Add(this.btnEditBill);
            this.Controls.Add(this.dtgvListCustomer);
            this.Controls.Add(this.btnSearchBill);
            this.Controls.Add(this.txtSearchBill);
            this.Controls.Add(this.cbFillBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSortBill);
            this.Controls.Add(this.label1);
            this.Name = "frmBillManagement";
            this.Text = "frmBillManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDeleteAllBill;
        private Guna.UI2.WinForms.Guna2Button btnBillDeleted;
        private Guna.UI2.WinForms.Guna2Button btnDeleteBill;
        private Guna.UI2.WinForms.Guna2Button btnEditBill;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvListCustomer;
        private Guna.UI2.WinForms.Guna2Button btnSearchBill;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBill;
        private Guna.UI2.WinForms.Guna2ComboBox cbFillBill;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortBill;
        private System.Windows.Forms.Label label1;
    }
}