
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
            this.components = new System.ComponentModel.Container();
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
            this.btnShowDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchBill = new Guna.UI2.WinForms.Guna2Button();
            this.grpBillInfo = new System.Windows.Forms.GroupBox();
            this.cbStatusCheckOut = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTable = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBillID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnEditBill = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCustomer)).BeginInit();
            this.grpBillInfo.SuspendLayout();
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
            this.dtgvListCustomer.Location = new System.Drawing.Point(11, 228);
            this.dtgvListCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvListCustomer.Name = "dtgvListCustomer";
            this.dtgvListCustomer.RowHeadersVisible = false;
            this.dtgvListCustomer.RowHeadersWidth = 51;
            this.dtgvListCustomer.RowTemplate.Height = 24;
            this.dtgvListCustomer.Size = new System.Drawing.Size(866, 190);
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
            this.txtSearchBill.Location = new System.Drawing.Point(248, 193);
            this.txtSearchBill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearchBill.Name = "txtSearchBill";
            this.txtSearchBill.PasswordChar = '\0';
            this.txtSearchBill.PlaceholderText = "";
            this.txtSearchBill.SelectedText = "";
            this.txtSearchBill.Size = new System.Drawing.Size(263, 29);
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
            this.cbFillBill.Location = new System.Drawing.Point(749, 194);
            this.cbFillBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFillBill.Name = "cbFillBill";
            this.cbFillBill.Size = new System.Drawing.Size(129, 36);
            this.cbFillBill.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
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
            this.cbSortBill.Location = new System.Drawing.Point(11, 194);
            this.cbSortBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSortBill.Name = "cbSortBill";
            this.cbSortBill.Size = new System.Drawing.Size(110, 36);
            this.cbSortBill.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Sắp xếp";
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.BorderRadius = 20;
            this.btnShowDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(110)))));
            this.btnShowDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowDetail.ForeColor = System.Drawing.Color.Black;
            this.btnShowDetail.Location = new System.Drawing.Point(655, 140);
            this.btnShowDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Size = new System.Drawing.Size(116, 36);
            this.btnShowDetail.TabIndex = 40;
            this.btnShowDetail.Text = "Xem chi tiết";
            this.btnShowDetail.Click += new System.EventHandler(this.btnShowDetail_Click);
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
            this.btnSearchBill.Location = new System.Drawing.Point(516, 193);
            this.btnSearchBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(79, 29);
            this.btnSearchBill.TabIndex = 38;
            // 
            // grpBillInfo
            // 
            this.grpBillInfo.Controls.Add(this.cbStatusCheckOut);
            this.grpBillInfo.Controls.Add(this.label8);
            this.grpBillInfo.Controls.Add(this.txtTable);
            this.grpBillInfo.Controls.Add(this.label7);
            this.grpBillInfo.Controls.Add(this.txtCustomerName);
            this.grpBillInfo.Controls.Add(this.label6);
            this.grpBillInfo.Controls.Add(this.dtpInvoiceDate);
            this.grpBillInfo.Controls.Add(this.label5);
            this.grpBillInfo.Controls.Add(this.txtEmployeeName);
            this.grpBillInfo.Controls.Add(this.label4);
            this.grpBillInfo.Controls.Add(this.txtBillID);
            this.grpBillInfo.Controls.Add(this.label3);
            this.grpBillInfo.Location = new System.Drawing.Point(9, 10);
            this.grpBillInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBillInfo.Name = "grpBillInfo";
            this.grpBillInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBillInfo.Size = new System.Drawing.Size(641, 166);
            this.grpBillInfo.TabIndex = 41;
            this.grpBillInfo.TabStop = false;
            this.grpBillInfo.Text = "Thông tin hóa đơn";
            // 
            // cbStatusCheckOut
            // 
            this.cbStatusCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.cbStatusCheckOut.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatusCheckOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusCheckOut.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatusCheckOut.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatusCheckOut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatusCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbStatusCheckOut.ItemHeight = 30;
            this.cbStatusCheckOut.Location = new System.Drawing.Point(484, 115);
            this.cbStatusCheckOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStatusCheckOut.Name = "cbStatusCheckOut";
            this.cbStatusCheckOut.Size = new System.Drawing.Size(108, 36);
            this.cbStatusCheckOut.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Trạng thái thanh toán:";
            // 
            // txtTable
            // 
            this.txtTable.BorderRadius = 10;
            this.txtTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTable.DefaultText = "";
            this.txtTable.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTable.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTable.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTable.Location = new System.Drawing.Point(484, 58);
            this.txtTable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTable.Name = "txtTable";
            this.txtTable.PasswordChar = '\0';
            this.txtTable.PlaceholderText = "";
            this.txtTable.SelectedText = "";
            this.txtTable.Size = new System.Drawing.Size(153, 33);
            this.txtTable.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Số bàn:";
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
            this.txtCustomerName.Location = new System.Drawing.Point(484, 18);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PlaceholderText = "";
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(153, 33);
            this.txtCustomerName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Khách hàng:";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Checked = true;
            this.dtpInvoiceDate.FillColor = System.Drawing.Color.GreenYellow;
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(75, 122);
            this.dtpInvoiceDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpInvoiceDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpInvoiceDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(150, 29);
            this.dtpInvoiceDate.TabIndex = 5;
            this.dtpInvoiceDate.Value = new System.DateTime(2023, 4, 6, 10, 13, 44, 377);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày lập:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BorderRadius = 10;
            this.txtEmployeeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeeName.DefaultText = "";
            this.txtEmployeeName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmployeeName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmployeeName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployeeName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeName.Location = new System.Drawing.Point(74, 58);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PasswordChar = '\0';
            this.txtEmployeeName.PlaceholderText = "";
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.Size = new System.Drawing.Size(153, 33);
            this.txtEmployeeName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhân viên:";
            // 
            // txtBillID
            // 
            this.txtBillID.BorderRadius = 10;
            this.txtBillID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBillID.DefaultText = "";
            this.txtBillID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBillID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBillID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBillID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBillID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBillID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBillID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBillID.Location = new System.Drawing.Point(74, 18);
            this.txtBillID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.PasswordChar = '\0';
            this.txtBillID.PlaceholderText = "";
            this.txtBillID.SelectedText = "";
            this.txtBillID.Size = new System.Drawing.Size(153, 33);
            this.txtBillID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hóa đơn:";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnEditBill
            // 
            this.btnEditBill.BorderRadius = 20;
            this.btnEditBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditBill.ForeColor = System.Drawing.Color.Black;
            this.btnEditBill.Location = new System.Drawing.Point(655, 100);
            this.btnEditBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditBill.Name = "btnEditBill";
            this.btnEditBill.Size = new System.Drawing.Size(116, 36);
            this.btnEditBill.TabIndex = 42;
            this.btnEditBill.Text = "Sửa";
            // 
            // frmBillManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 419);
            this.Controls.Add(this.btnEditBill);
            this.Controls.Add(this.grpBillInfo);
            this.Controls.Add(this.btnShowDetail);
            this.Controls.Add(this.dtgvListCustomer);
            this.Controls.Add(this.btnSearchBill);
            this.Controls.Add(this.txtSearchBill);
            this.Controls.Add(this.cbFillBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSortBill);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBillManagement";
            this.Text = "frmBillManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCustomer)).EndInit();
            this.grpBillInfo.ResumeLayout(false);
            this.grpBillInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dtgvListCustomer;
        private Guna.UI2.WinForms.Guna2Button btnSearchBill;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBill;
        private Guna.UI2.WinForms.Guna2ComboBox cbFillBill;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortBill;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnShowDetail;
        private System.Windows.Forms.GroupBox grpBillInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtEmployeeName;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtBillID;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatusCheckOut;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtTable;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerName;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnEditBill;
    }
}