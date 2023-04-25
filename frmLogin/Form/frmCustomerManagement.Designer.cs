
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
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTypeCustomer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerNumberPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpFunctionCustomer = new System.Windows.Forms.GroupBox();
            this.btnSaveCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAllCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDeleted = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCustomer)).BeginInit();
            this.grpCustomerInfo.SuspendLayout();
            this.grpFunctionCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 273);
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
            this.cbSortCustomer.Location = new System.Drawing.Point(12, 293);
            this.cbSortCustomer.Name = "cbSortCustomer";
            this.cbSortCustomer.Size = new System.Drawing.Size(186, 36);
            this.cbSortCustomer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(991, 273);
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
            this.cbFillCustomer.Location = new System.Drawing.Point(994, 293);
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
            this.txtSearchCustomer.Location = new System.Drawing.Point(393, 292);
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
            this.dtgvListCustomer.AllowUserToAddRows = false;
            this.dtgvListCustomer.AllowUserToDeleteRows = false;
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
            this.dtgvListCustomer.ColumnHeadersHeight = 20;
            this.dtgvListCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvListCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListCustomer.Location = new System.Drawing.Point(12, 335);
            this.dtgvListCustomer.Name = "dtgvListCustomer";
            this.dtgvListCustomer.RowHeadersVisible = false;
            this.dtgvListCustomer.RowHeadersWidth = 51;
            this.dtgvListCustomer.RowTemplate.Height = 24;
            this.dtgvListCustomer.Size = new System.Drawing.Size(1153, 168);
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
            this.dtgvListCustomer.ThemeStyle.HeaderStyle.Height = 20;
            this.dtgvListCustomer.ThemeStyle.ReadOnly = false;
            this.dtgvListCustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListCustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListCustomer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListCustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListCustomer.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvListCustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListCustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListCustomer.SelectionChanged += new System.EventHandler(this.dtgvListCustomer_SelectionChanged);
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.radFemale);
            this.grpCustomerInfo.Controls.Add(this.radMale);
            this.grpCustomerInfo.Controls.Add(this.label7);
            this.grpCustomerInfo.Controls.Add(this.cbTypeCustomer);
            this.grpCustomerInfo.Controls.Add(this.label6);
            this.grpCustomerInfo.Controls.Add(this.txtCustomerNumberPhone);
            this.grpCustomerInfo.Controls.Add(this.label5);
            this.grpCustomerInfo.Controls.Add(this.txtCustomerName);
            this.grpCustomerInfo.Controls.Add(this.label4);
            this.grpCustomerInfo.Controls.Add(this.txtCustomerID);
            this.grpCustomerInfo.Controls.Add(this.label3);
            this.grpCustomerInfo.Location = new System.Drawing.Point(12, 12);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(525, 243);
            this.grpCustomerInfo.TabIndex = 33;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Thông tin khách hàng";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(290, 112);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(47, 21);
            this.radFemale.TabIndex = 10;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(173, 112);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(58, 21);
            this.radMale.TabIndex = 9;
            this.radMale.TabStop = true;
            this.radMale.Text = "Nam";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Giới tính:";
            // 
            // cbTypeCustomer
            // 
            this.cbTypeCustomer.BackColor = System.Drawing.Color.Transparent;
            this.cbTypeCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeCustomer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTypeCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTypeCustomer.ItemHeight = 30;
            this.cbTypeCustomer.Location = new System.Drawing.Point(173, 201);
            this.cbTypeCustomer.Name = "cbTypeCustomer";
            this.cbTypeCustomer.Size = new System.Drawing.Size(175, 36);
            this.cbTypeCustomer.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Loại khách hàng:";
            // 
            // txtCustomerNumberPhone
            // 
            this.txtCustomerNumberPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerNumberPhone.BorderRadius = 20;
            this.txtCustomerNumberPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerNumberPhone.DefaultText = "";
            this.txtCustomerNumberPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerNumberPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerNumberPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerNumberPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerNumberPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerNumberPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerNumberPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerNumberPhone.Location = new System.Drawing.Point(159, 156);
            this.txtCustomerNumberPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerNumberPhone.Name = "txtCustomerNumberPhone";
            this.txtCustomerNumberPhone.PasswordChar = '\0';
            this.txtCustomerNumberPhone.PlaceholderText = "";
            this.txtCustomerNumberPhone.SelectedText = "";
            this.txtCustomerNumberPhone.Size = new System.Drawing.Size(246, 35);
            this.txtCustomerNumberPhone.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerName.BorderRadius = 20;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên KH:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerID.BorderRadius = 20;
            this.txtCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerID.DefaultText = "";
            this.txtCustomerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID.Enabled = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã KH:";
            // 
            // grpFunctionCustomer
            // 
            this.grpFunctionCustomer.Controls.Add(this.btnSaveCustomer);
            this.grpFunctionCustomer.Controls.Add(this.btnAddCustomer);
            this.grpFunctionCustomer.Controls.Add(this.btnEditCustomer);
            this.grpFunctionCustomer.Controls.Add(this.btnDeleteAllCustomer);
            this.grpFunctionCustomer.Controls.Add(this.btnDeleteCustomer);
            this.grpFunctionCustomer.Controls.Add(this.btnCustomerDeleted);
            this.grpFunctionCustomer.Location = new System.Drawing.Point(735, 12);
            this.grpFunctionCustomer.Name = "grpFunctionCustomer";
            this.grpFunctionCustomer.Size = new System.Drawing.Size(430, 243);
            this.grpFunctionCustomer.TabIndex = 34;
            this.grpFunctionCustomer.TabStop = false;
            this.grpFunctionCustomer.Text = "Chức năng";
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.BorderRadius = 20;
            this.btnSaveCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveCustomer.Enabled = false;
            this.btnSaveCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnSaveCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnSaveCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCustomer.Image")));
            this.btnSaveCustomer.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveCustomer.Location = new System.Drawing.Point(250, 27);
            this.btnSaveCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(174, 44);
            this.btnSaveCustomer.TabIndex = 40;
            this.btnSaveCustomer.Text = "Lưu";
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
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
            this.btnAddCustomer.Size = new System.Drawing.Size(165, 45);
            this.btnAddCustomer.TabIndex = 28;
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
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
            this.btnEditCustomer.Size = new System.Drawing.Size(165, 45);
            this.btnEditCustomer.TabIndex = 29;
            this.btnEditCustomer.Text = "Sửa";
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
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
            this.btnDeleteAllCustomer.Click += new System.EventHandler(this.btnDeleteAllCustomer_Click);
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
            this.btnDeleteCustomer.Size = new System.Drawing.Size(165, 45);
            this.btnDeleteCustomer.TabIndex = 30;
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
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
            this.guna2Button1.Location = new System.Drawing.Point(671, 292);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(105, 36);
            this.guna2Button1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Gender";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Phone";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TypeName";
            this.Column5.HeaderText = "Loại khách hàng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TypeID";
            this.Column6.HeaderText = "Mã loại khách hàng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
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
            this.Load += new System.EventHandler(this.frmCustomerManagement_Load);
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
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cbTypeCustomer;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnSaveCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}