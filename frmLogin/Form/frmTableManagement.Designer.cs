
namespace frmLogin
{
    partial class frmTableManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.cbSortTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFillTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchTable = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtgvListTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnTableDeleted = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAllTable = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sắp xếp";
            // 
            // cbSortTable
            // 
            this.cbSortTable.BackColor = System.Drawing.Color.Transparent;
            this.cbSortTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSortTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSortTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSortTable.ItemHeight = 30;
            this.cbSortTable.Location = new System.Drawing.Point(15, 56);
            this.cbSortTable.Name = "cbSortTable";
            this.cbSortTable.Size = new System.Drawing.Size(167, 36);
            this.cbSortTable.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lọc";
            // 
            // cbFillTable
            // 
            this.cbFillTable.BackColor = System.Drawing.Color.Transparent;
            this.cbFillTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFillTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFillTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFillTable.ItemHeight = 30;
            this.cbFillTable.Location = new System.Drawing.Point(720, 57);
            this.cbFillTable.Name = "cbFillTable";
            this.cbFillTable.Size = new System.Drawing.Size(167, 36);
            this.cbFillTable.TabIndex = 3;
            // 
            // txtSearchTable
            // 
            this.txtSearchTable.BorderRadius = 10;
            this.txtSearchTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchTable.DefaultText = "";
            this.txtSearchTable.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchTable.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchTable.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchTable.Location = new System.Drawing.Point(252, 52);
            this.txtSearchTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchTable.Name = "txtSearchTable";
            this.txtSearchTable.PasswordChar = '\0';
            this.txtSearchTable.PlaceholderText = "";
            this.txtSearchTable.SelectedText = "";
            this.txtSearchTable.Size = new System.Drawing.Size(282, 41);
            this.txtSearchTable.TabIndex = 4;
            // 
            // dtgvListTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvListTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvListTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListTable.Location = new System.Drawing.Point(15, 99);
            this.dtgvListTable.Name = "dtgvListTable";
            this.dtgvListTable.RowHeadersVisible = false;
            this.dtgvListTable.RowHeadersWidth = 51;
            this.dtgvListTable.RowTemplate.Height = 24;
            this.dtgvListTable.Size = new System.Drawing.Size(872, 405);
            this.dtgvListTable.TabIndex = 5;
            this.dtgvListTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvListTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvListTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvListTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvListTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvListTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvListTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvListTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListTable.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvListTable.ThemeStyle.ReadOnly = false;
            this.dtgvListTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListTable.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvListTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(540, 52);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(99, 41);
            this.guna2Button1.TabIndex = 6;
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddTable.BorderRadius = 20;
            this.btnAddTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnAddTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddTable.ForeColor = System.Drawing.Color.Black;
            this.btnAddTable.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTable.Image")));
            this.btnAddTable.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddTable.Location = new System.Drawing.Point(893, 123);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(148, 45);
            this.btnAddTable.TabIndex = 7;
            this.btnAddTable.Text = "Thêm";
            // 
            // btnEditTable
            // 
            this.btnEditTable.BorderRadius = 20;
            this.btnEditTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btnEditTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditTable.ForeColor = System.Drawing.Color.Black;
            this.btnEditTable.Image = ((System.Drawing.Image)(resources.GetObject("btnEditTable.Image")));
            this.btnEditTable.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEditTable.Location = new System.Drawing.Point(893, 195);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(148, 45);
            this.btnEditTable.TabIndex = 8;
            this.btnEditTable.Text = "Sửa";
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.BorderRadius = 20;
            this.btnDeleteTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.btnDeleteTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteTable.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteTable.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTable.Image")));
            this.btnDeleteTable.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteTable.Location = new System.Drawing.Point(893, 261);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(148, 45);
            this.btnDeleteTable.TabIndex = 9;
            this.btnDeleteTable.Text = "Xóa";
            // 
            // btnTableDeleted
            // 
            this.btnTableDeleted.BorderRadius = 20;
            this.btnTableDeleted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTableDeleted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTableDeleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTableDeleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTableDeleted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(184)))));
            this.btnTableDeleted.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTableDeleted.ForeColor = System.Drawing.Color.Black;
            this.btnTableDeleted.Image = ((System.Drawing.Image)(resources.GetObject("btnTableDeleted.Image")));
            this.btnTableDeleted.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTableDeleted.Location = new System.Drawing.Point(893, 352);
            this.btnTableDeleted.Name = "btnTableDeleted";
            this.btnTableDeleted.Size = new System.Drawing.Size(148, 45);
            this.btnTableDeleted.TabIndex = 10;
            this.btnTableDeleted.Text = "Bàn đã xóa";
            // 
            // btnDeleteAllTable
            // 
            this.btnDeleteAllTable.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteAllTable.BorderRadius = 10;
            this.btnDeleteAllTable.BorderThickness = 2;
            this.btnDeleteAllTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAllTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAllTable.FillColor = System.Drawing.Color.White;
            this.btnDeleteAllTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteAllTable.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAllTable.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllTable.Image")));
            this.btnDeleteAllTable.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteAllTable.Location = new System.Drawing.Point(893, 444);
            this.btnDeleteAllTable.Name = "btnDeleteAllTable";
            this.btnDeleteAllTable.Size = new System.Drawing.Size(148, 43);
            this.btnDeleteAllTable.TabIndex = 11;
            this.btnDeleteAllTable.Text = "Xóa tất cả";
            // 
            // frmTableManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 516);
            this.Controls.Add(this.btnDeleteAllTable);
            this.Controls.Add(this.btnTableDeleted);
            this.Controls.Add(this.btnDeleteTable);
            this.Controls.Add(this.btnEditTable);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.dtgvListTable);
            this.Controls.Add(this.txtSearchTable);
            this.Controls.Add(this.cbFillTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSortTable);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTableManagement";
            this.Text = "frmTableManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortTable;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbFillTable;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchTable;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvListTable;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnAddTable;
        private Guna.UI2.WinForms.Guna2Button btnEditTable;
        private Guna.UI2.WinForms.Guna2Button btnDeleteTable;
        private Guna.UI2.WinForms.Guna2Button btnTableDeleted;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAllTable;
    }
}