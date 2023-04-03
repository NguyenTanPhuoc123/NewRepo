
namespace frmLogin
{
    partial class frmEmployeeManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSortEmployee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchEmployee = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearchEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.cbFillEmployee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvListEmployee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnDeleteAllEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployeeDeleted = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sắp xếp";
            // 
            // cbSortEmployee
            // 
            this.cbSortEmployee.BackColor = System.Drawing.Color.Transparent;
            this.cbSortEmployee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSortEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortEmployee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortEmployee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSortEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSortEmployee.ItemHeight = 30;
            this.cbSortEmployee.Location = new System.Drawing.Point(12, 29);
            this.cbSortEmployee.Name = "cbSortEmployee";
            this.cbSortEmployee.Size = new System.Drawing.Size(163, 36);
            this.cbSortEmployee.TabIndex = 10;
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchEmployee.DefaultText = "";
            this.txtSearchEmployee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchEmployee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchEmployee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchEmployee.Location = new System.Drawing.Point(289, 29);
            this.txtSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.PasswordChar = '\0';
            this.txtSearchEmployee.PlaceholderText = "";
            this.txtSearchEmployee.SelectedText = "";
            this.txtSearchEmployee.Size = new System.Drawing.Size(263, 36);
            this.txtSearchEmployee.TabIndex = 11;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.BorderRadius = 10;
            this.btnSearchEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchEmployee.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearchEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchEmployee.ForeColor = System.Drawing.Color.White;
            this.btnSearchEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchEmployee.Image")));
            this.btnSearchEmployee.Location = new System.Drawing.Point(581, 29);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(72, 36);
            this.btnSearchEmployee.TabIndex = 12;
            // 
            // cbFillEmployee
            // 
            this.cbFillEmployee.BackColor = System.Drawing.Color.Transparent;
            this.cbFillEmployee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFillEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillEmployee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillEmployee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFillEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFillEmployee.ItemHeight = 30;
            this.cbFillEmployee.Location = new System.Drawing.Point(708, 33);
            this.cbFillEmployee.Name = "cbFillEmployee";
            this.cbFillEmployee.Size = new System.Drawing.Size(163, 36);
            this.cbFillEmployee.TabIndex = 13;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BorderRadius = 20;
            this.btnAddEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddEmployee.Location = new System.Drawing.Point(882, 93);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(164, 45);
            this.btnAddEmployee.TabIndex = 14;
            this.btnAddEmployee.Text = "Thêm";
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.BorderRadius = 20;
            this.btnEditEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btnEditEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnEditEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEditEmployee.Image")));
            this.btnEditEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEditEmployee.Location = new System.Drawing.Point(882, 164);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(164, 45);
            this.btnEditEmployee.TabIndex = 15;
            this.btnEditEmployee.Text = "Sửa";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BorderRadius = 20;
            this.btnDeleteEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteEmployee.Image")));
            this.btnDeleteEmployee.ImageSize = new System.Drawing.Size(45, 45);
            this.btnDeleteEmployee.Location = new System.Drawing.Point(882, 234);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(164, 45);
            this.btnDeleteEmployee.TabIndex = 16;
            this.btnDeleteEmployee.Text = "Xóa";
            // 
            // dtgvListEmployee
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvListEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvListEmployee.ColumnHeadersHeight = 4;
            this.dtgvListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvListEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListEmployee.Location = new System.Drawing.Point(12, 71);
            this.dtgvListEmployee.Name = "dtgvListEmployee";
            this.dtgvListEmployee.RowHeadersVisible = false;
            this.dtgvListEmployee.RowHeadersWidth = 51;
            this.dtgvListEmployee.RowTemplate.Height = 24;
            this.dtgvListEmployee.Size = new System.Drawing.Size(859, 418);
            this.dtgvListEmployee.TabIndex = 17;
            this.dtgvListEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListEmployee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvListEmployee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvListEmployee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvListEmployee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvListEmployee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListEmployee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListEmployee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvListEmployee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvListEmployee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListEmployee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvListEmployee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListEmployee.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvListEmployee.ThemeStyle.ReadOnly = false;
            this.dtgvListEmployee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListEmployee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListEmployee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListEmployee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListEmployee.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvListEmployee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListEmployee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(708, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(25, 18);
            this.guna2HtmlLabel1.TabIndex = 18;
            this.guna2HtmlLabel1.Text = "Lọc";
            // 
            // btnDeleteAllEmployee
            // 
            this.btnDeleteAllEmployee.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteAllEmployee.BorderRadius = 10;
            this.btnDeleteAllEmployee.BorderThickness = 2;
            this.btnDeleteAllEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAllEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAllEmployee.FillColor = System.Drawing.Color.White;
            this.btnDeleteAllEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteAllEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAllEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllEmployee.Image")));
            this.btnDeleteAllEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteAllEmployee.Location = new System.Drawing.Point(882, 446);
            this.btnDeleteAllEmployee.Name = "btnDeleteAllEmployee";
            this.btnDeleteAllEmployee.Size = new System.Drawing.Size(159, 43);
            this.btnDeleteAllEmployee.TabIndex = 27;
            this.btnDeleteAllEmployee.Text = "Xóa tất cả";
            // 
            // btnEmployeeDeleted
            // 
            this.btnEmployeeDeleted.BorderRadius = 20;
            this.btnEmployeeDeleted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployeeDeleted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployeeDeleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployeeDeleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployeeDeleted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(184)))));
            this.btnEmployeeDeleted.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEmployeeDeleted.ForeColor = System.Drawing.Color.Black;
            this.btnEmployeeDeleted.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeDeleted.Image")));
            this.btnEmployeeDeleted.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEmployeeDeleted.Location = new System.Drawing.Point(882, 372);
            this.btnEmployeeDeleted.Name = "btnEmployeeDeleted";
            this.btnEmployeeDeleted.Size = new System.Drawing.Size(159, 45);
            this.btnEmployeeDeleted.TabIndex = 26;
            this.btnEmployeeDeleted.Text = "Nhân viên đã xóa";
            // 
            // frmEmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 514);
            this.Controls.Add(this.btnDeleteAllEmployee);
            this.Controls.Add(this.btnEmployeeDeleted);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dtgvListEmployee);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.cbFillEmployee);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.txtSearchEmployee);
            this.Controls.Add(this.cbSortEmployee);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEmployeeManager";
            this.Text = "frmEmployeeManager";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortEmployee;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchEmployee;
        private Guna.UI2.WinForms.Guna2Button btnSearchEmployee;
        private Guna.UI2.WinForms.Guna2ComboBox cbFillEmployee;
        private Guna.UI2.WinForms.Guna2Button btnAddEmployee;
        private Guna.UI2.WinForms.Guna2Button btnEditEmployee;
        private Guna.UI2.WinForms.Guna2Button btnDeleteEmployee;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvListEmployee;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAllEmployee;
        private Guna.UI2.WinForms.Guna2Button btnEmployeeDeleted;
    }
}