
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillManagement));
            this.dtgvListBill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtSearchBill = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFillBill = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSortBill = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchBill = new Guna.UI2.WinForms.Guna2Button();
            this.grpBillInfo = new System.Windows.Forms.GroupBox();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDayCheckOut = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDayCheckIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbStatusCheckOut = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTable = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalBill = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBillID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBill)).BeginInit();
            this.grpBillInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvListBill
            // 
            this.dtgvListBill.AllowUserToAddRows = false;
            this.dtgvListBill.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgvListBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvListBill.ColumnHeadersHeight = 20;
            this.dtgvListBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column4,
            this.Column8,
            this.Column9,
            this.Column11,
            this.Column12});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListBill.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvListBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListBill.Location = new System.Drawing.Point(15, 353);
            this.dtgvListBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvListBill.Name = "dtgvListBill";
            this.dtgvListBill.RowHeadersVisible = false;
            this.dtgvListBill.RowHeadersWidth = 51;
            this.dtgvListBill.RowTemplate.Height = 24;
            this.dtgvListBill.Size = new System.Drawing.Size(1154, 152);
            this.dtgvListBill.TabIndex = 39;
            this.dtgvListBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvListBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvListBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvListBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvListBill.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListBill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvListBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvListBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvListBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListBill.ThemeStyle.HeaderStyle.Height = 20;
            this.dtgvListBill.ThemeStyle.ReadOnly = false;
            this.dtgvListBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListBill.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvListBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListBill.SelectionChanged += new System.EventHandler(this.dtgvListBill_SelectionChanged);
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
            this.txtSearchBill.Location = new System.Drawing.Point(303, 295);
            this.txtSearchBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchBill.Name = "txtSearchBill";
            this.txtSearchBill.PasswordChar = '\0';
            this.txtSearchBill.PlaceholderText = "";
            this.txtSearchBill.SelectedText = "";
            this.txtSearchBill.Size = new System.Drawing.Size(351, 36);
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
            this.cbFillBill.Location = new System.Drawing.Point(998, 295);
            this.cbFillBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFillBill.Name = "cbFillBill";
            this.cbFillBill.Size = new System.Drawing.Size(171, 36);
            this.cbFillBill.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(995, 276);
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
            this.cbSortBill.Items.AddRange(new object[] {
            "Mặc định",
            "Mã HD(Tăng)",
            "Mã HD(Giảm)",
            "Ngày lập(Tăng)",
            "Ngày lập(Giảm)",
            "Tổng tiền(tăng)",
            "Tổng tiền(giảm)"});
            this.cbSortBill.Location = new System.Drawing.Point(15, 295);
            this.cbSortBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSortBill.Name = "cbSortBill";
            this.cbSortBill.Size = new System.Drawing.Size(192, 36);
            this.cbSortBill.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
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
            this.btnShowDetail.Location = new System.Drawing.Point(871, 198);
            this.btnShowDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Size = new System.Drawing.Size(155, 44);
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
            this.btnSearchBill.Location = new System.Drawing.Point(680, 295);
            this.btnSearchBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(105, 36);
            this.btnSearchBill.TabIndex = 38;
            // 
            // grpBillInfo
            // 
            this.grpBillInfo.Controls.Add(this.txtDiscount);
            this.grpBillInfo.Controls.Add(this.label10);
            this.grpBillInfo.Controls.Add(this.txtDayCheckOut);
            this.grpBillInfo.Controls.Add(this.label9);
            this.grpBillInfo.Controls.Add(this.txtDayCheckIn);
            this.grpBillInfo.Controls.Add(this.cbStatusCheckOut);
            this.grpBillInfo.Controls.Add(this.label8);
            this.grpBillInfo.Controls.Add(this.txtTable);
            this.grpBillInfo.Controls.Add(this.label7);
            this.grpBillInfo.Controls.Add(this.txtTotalBill);
            this.grpBillInfo.Controls.Add(this.label6);
            this.grpBillInfo.Controls.Add(this.label5);
            this.grpBillInfo.Controls.Add(this.txtEmployeeName);
            this.grpBillInfo.Controls.Add(this.label4);
            this.grpBillInfo.Controls.Add(this.txtBillID);
            this.grpBillInfo.Controls.Add(this.label3);
            this.grpBillInfo.Location = new System.Drawing.Point(12, 12);
            this.grpBillInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBillInfo.Name = "grpBillInfo";
            this.grpBillInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBillInfo.Size = new System.Drawing.Size(855, 230);
            this.grpBillInfo.TabIndex = 41;
            this.grpBillInfo.TabStop = false;
            this.grpBillInfo.Text = "Thông tin hóa đơn";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderRadius = 10;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.Location = new System.Drawing.Point(645, 21);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.Size = new System.Drawing.Size(204, 41);
            this.txtDiscount.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(542, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Giảm giá :";
            // 
            // txtDayCheckOut
            // 
            this.txtDayCheckOut.BorderRadius = 10;
            this.txtDayCheckOut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDayCheckOut.DefaultText = "";
            this.txtDayCheckOut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDayCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDayCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDayCheckOut.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDayCheckOut.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDayCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDayCheckOut.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDayCheckOut.Location = new System.Drawing.Point(99, 169);
            this.txtDayCheckOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDayCheckOut.Name = "txtDayCheckOut";
            this.txtDayCheckOut.PasswordChar = '\0';
            this.txtDayCheckOut.PlaceholderText = "";
            this.txtDayCheckOut.SelectedText = "";
            this.txtDayCheckOut.Size = new System.Drawing.Size(204, 41);
            this.txtDayCheckOut.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ngày xuất:";
            // 
            // txtDayCheckIn
            // 
            this.txtDayCheckIn.BorderRadius = 10;
            this.txtDayCheckIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDayCheckIn.DefaultText = "";
            this.txtDayCheckIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDayCheckIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDayCheckIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDayCheckIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDayCheckIn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDayCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDayCheckIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDayCheckIn.Location = new System.Drawing.Point(99, 120);
            this.txtDayCheckIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDayCheckIn.Name = "txtDayCheckIn";
            this.txtDayCheckIn.PasswordChar = '\0';
            this.txtDayCheckIn.PlaceholderText = "";
            this.txtDayCheckIn.SelectedText = "";
            this.txtDayCheckIn.Size = new System.Drawing.Size(204, 41);
            this.txtDayCheckIn.TabIndex = 12;
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
            this.cbStatusCheckOut.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cbStatusCheckOut.Location = new System.Drawing.Point(645, 174);
            this.cbStatusCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatusCheckOut.Name = "cbStatusCheckOut";
            this.cbStatusCheckOut.Size = new System.Drawing.Size(204, 36);
            this.cbStatusCheckOut.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 17);
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
            this.txtTable.Location = new System.Drawing.Point(645, 71);
            this.txtTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTable.Name = "txtTable";
            this.txtTable.PasswordChar = '\0';
            this.txtTable.PlaceholderText = "";
            this.txtTable.SelectedText = "";
            this.txtTable.Size = new System.Drawing.Size(204, 41);
            this.txtTable.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Số bàn:";
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.BorderRadius = 10;
            this.txtTotalBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalBill.DefaultText = "";
            this.txtTotalBill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalBill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalBill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalBill.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalBill.Location = new System.Drawing.Point(645, 120);
            this.txtTotalBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.PasswordChar = '\0';
            this.txtTotalBill.PlaceholderText = "";
            this.txtTotalBill.SelectedText = "";
            this.txtTotalBill.Size = new System.Drawing.Size(204, 41);
            this.txtTotalBill.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
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
            this.txtEmployeeName.Location = new System.Drawing.Point(99, 71);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PasswordChar = '\0';
            this.txtEmployeeName.PlaceholderText = "";
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.Size = new System.Drawing.Size(204, 41);
            this.txtEmployeeName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
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
            this.txtBillID.Location = new System.Drawing.Point(99, 22);
            this.txtBillID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.PasswordChar = '\0';
            this.txtBillID.PlaceholderText = "";
            this.txtBillID.SelectedText = "";
            this.txtBillID.Size = new System.Drawing.Size(204, 41);
            this.txtBillID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hóa đơn:";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DayCheckIn";
            this.Column2.HeaderText = "Ngày lập hóa đơn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "EmployeeName";
            this.Column3.HeaderText = "Nhân viên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DiscountName";
            this.Column5.HeaderText = "Giảm giá";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TableName";
            this.Column6.HeaderText = "Bàn ăn";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DayCheckOut";
            this.Column7.HeaderText = "Ngày xuất hóa đơn";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Total";
            this.Column4.HeaderText = "Tổng tiền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "StatusCheckOut";
            this.Column8.HeaderText = "Trạng thái thanh toán";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "EmployeeID";
            this.Column9.HeaderText = "Mã nhân viên";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "TableID";
            this.Column11.HeaderText = "Số bàn";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "DiscountID";
            this.Column12.HeaderText = "Mã giảm giá";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Visible = false;
            // 
            // frmBillManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 516);
            this.Controls.Add(this.grpBillInfo);
            this.Controls.Add(this.btnShowDetail);
            this.Controls.Add(this.dtgvListBill);
            this.Controls.Add(this.btnSearchBill);
            this.Controls.Add(this.txtSearchBill);
            this.Controls.Add(this.cbFillBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSortBill);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBillManagement";
            this.Text = "frmBillManagement";
            this.Load += new System.EventHandler(this.frmBillManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBill)).EndInit();
            this.grpBillInfo.ResumeLayout(false);
            this.grpBillInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dtgvListBill;
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
        private Guna.UI2.WinForms.Guna2TextBox txtTotalBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtDayCheckOut;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtDayCheckIn;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}