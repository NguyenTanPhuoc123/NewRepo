
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.cbSortCustomer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFillCustomer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtgvListCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerNumberPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpFunctionCustomer = new System.Windows.Forms.GroupBox();
            this.btnRefreshCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAllCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDeleted = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCustomer)).BeginInit();
            this.grpCustomerInfo.SuspendLayout();
            this.grpFunctionCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 238);
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
            this.cbSortCustomer.Location = new System.Drawing.Point(57, 258);
            this.cbSortCustomer.Name = "cbSortCustomer";
            this.cbSortCustomer.Size = new System.Drawing.Size(146, 36);
            this.cbSortCustomer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(945, 238);
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
            this.cbFillCustomer.Location = new System.Drawing.Point(948, 258);
            this.cbFillCustomer.Name = "cbFillCustomer";
            this.cbFillCustomer.Size = new System.Drawing.Size(171, 36);
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
            this.txtSearchCustomer.Location = new System.Drawing.Point(403, 258);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.PasswordChar = '\0';
            this.txtSearchCustomer.PlaceholderText = "";
            this.txtSearchCustomer.SelectedText = "";
            this.txtSearchCustomer.Size = new System.Drawing.Size(272, 36);
            this.txtSearchCustomer.TabIndex = 4;
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
            this.dtgvListCustomer.Location = new System.Drawing.Point(57, 299);
            this.dtgvListCustomer.Name = "dtgvListCustomer";
            this.dtgvListCustomer.RowHeadersVisible = false;
            this.dtgvListCustomer.RowHeadersWidth = 51;
            this.dtgvListCustomer.RowTemplate.Height = 24;
            this.dtgvListCustomer.Size = new System.Drawing.Size(1062, 204);
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
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.txtCustomerNumberPhone);
            this.grpCustomerInfo.Controls.Add(this.label5);
            this.grpCustomerInfo.Controls.Add(this.txtCustomerName);
            this.grpCustomerInfo.Controls.Add(this.label4);
            this.grpCustomerInfo.Controls.Add(this.txtCustomerID);
            this.grpCustomerInfo.Controls.Add(this.label3);
            this.grpCustomerInfo.Location = new System.Drawing.Point(12, 12);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(525, 223);
            this.grpCustomerInfo.TabIndex = 33;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Thông tin khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã KH:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BorderRadius = 10;
            this.txtCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerID.DefaultText = "";
            this.txtCustomerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID.Location = new System.Drawing.Point(173, 22);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.PasswordChar = '\0';
            this.txtCustomerID.PlaceholderText = "";
            this.txtCustomerID.SelectedText = "";
            this.txtCustomerID.Size = new System.Drawing.Size(246, 35);
            this.txtCustomerID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên KH:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderRadius = 10;
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.DefaultText = "";
            this.txtCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerName.Location = new System.Drawing.Point(173, 66);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PlaceholderText = "";
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(246, 35);
            this.txtCustomerName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại:";
            // 
            // txtCustomerNumberPhone
            // 
            this.txtCustomerNumberPhone.BorderRadius = 10;
            this.txtCustomerNumberPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerNumberPhone.DefaultText = "";
            this.txtCustomerNumberPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerNumberPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerNumberPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerNumberPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerNumberPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerNumberPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerNumberPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerNumberPhone.Location = new System.Drawing.Point(173, 138);
            this.txtCustomerNumberPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerNumberPhone.Name = "txtCustomerNumberPhone";
            this.txtCustomerNumberPhone.PasswordChar = '\0';
            this.txtCustomerNumberPhone.PlaceholderText = "";
            this.txtCustomerNumberPhone.SelectedText = "";
            this.txtCustomerNumberPhone.Size = new System.Drawing.Size(246, 35);
            this.txtCustomerNumberPhone.TabIndex = 5;
            // 
            // grpFunctionCustomer
            // 
            this.grpFunctionCustomer.Controls.Add(this.btnRefreshCustomer);
            this.grpFunctionCustomer.Controls.Add(this.btnAddCustomer);
            this.grpFunctionCustomer.Controls.Add(this.btnEditCustomer);
            this.grpFunctionCustomer.Controls.Add(this.btnDeleteAllCustomer);
            this.grpFunctionCustomer.Controls.Add(this.btnDeleteCustomer);
            this.grpFunctionCustomer.Controls.Add(this.btnCustomerDeleted);
            this.grpFunctionCustomer.Location = new System.Drawing.Point(657, 12);
            this.grpFunctionCustomer.Name = "grpFunctionCustomer";
            this.grpFunctionCustomer.Size = new System.Drawing.Size(430, 223);
            this.grpFunctionCustomer.TabIndex = 34;
            this.grpFunctionCustomer.TabStop = false;
            this.grpFunctionCustomer.Text = "Chức năng";
            // 
            // btnRefreshCustomer
            // 
            this.btnRefreshCustomer.BorderRadius = 20;
            this.btnRefreshCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefreshCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefreshCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnRefreshCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshCustomer.Image")));
            this.btnRefreshCustomer.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefreshCustomer.Location = new System.Drawing.Point(250, 22);
            this.btnRefreshCustomer.Name = "btnRefreshCustomer";
            this.btnRefreshCustomer.Size = new System.Drawing.Size(174, 45);
            this.btnRefreshCustomer.TabIndex = 33;
            this.btnRefreshCustomer.Text = "Làm mới";
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
            this.btnAddCustomer.Location = new System.Drawing.Point(6, 27);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(140, 45);
            this.btnAddCustomer.TabIndex = 28;
            this.btnAddCustomer.Text = "Thêm";
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
            this.btnEditCustomer.Location = new System.Drawing.Point(6, 84);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(140, 45);
            this.btnEditCustomer.TabIndex = 29;
            this.btnEditCustomer.Text = "Sửa";
            // 
            // btnDeleteAllCustomer
            // 
            this.btnDeleteAllCustomer.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteAllCustomer.BorderRadius = 10;
            this.btnDeleteAllCustomer.BorderThickness = 2;
            this.btnDeleteAllCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAllCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAllCustomer.FillColor = System.Drawing.Color.White;
            this.btnDeleteAllCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteAllCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAllCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllCustomer.Image")));
            this.btnDeleteAllCustomer.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteAllCustomer.Location = new System.Drawing.Point(250, 158);
            this.btnDeleteAllCustomer.Name = "btnDeleteAllCustomer";
            this.btnDeleteAllCustomer.Size = new System.Drawing.Size(174, 43);
            this.btnDeleteAllCustomer.TabIndex = 32;
            this.btnDeleteAllCustomer.Text = "Xóa tất cả";
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
            this.btnDeleteCustomer.Location = new System.Drawing.Point(6, 156);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(140, 45);
            this.btnDeleteCustomer.TabIndex = 30;
            this.btnDeleteCustomer.Text = "Xóa";
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
            this.btnCustomerDeleted.Location = new System.Drawing.Point(250, 84);
            this.btnCustomerDeleted.Name = "btnCustomerDeleted";
            this.btnCustomerDeleted.Size = new System.Drawing.Size(174, 45);
            this.btnCustomerDeleted.TabIndex = 31;
            this.btnCustomerDeleted.Text = "Khách hàng đã xóa";
            this.btnCustomerDeleted.Click += new System.EventHandler(this.btnCustomerDeleted_Click);
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
            this.guna2Button1.Location = new System.Drawing.Point(681, 258);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(105, 36);
            this.guna2Button1.TabIndex = 5;
            // 
            // frmCustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 516);
            this.Controls.Add(this.grpFunctionCustomer);
            this.Controls.Add(this.grpCustomerInfo);
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
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpFunctionCustomer.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2Button btnDeleteAllCustomer;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDeleted;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCustomer;
        private Guna.UI2.WinForms.Guna2Button btnEditCustomer;
        private Guna.UI2.WinForms.Guna2Button btnAddCustomer;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerNumberPhone;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerName;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpFunctionCustomer;
        private Guna.UI2.WinForms.Guna2Button btnRefreshCustomer;
    }
}