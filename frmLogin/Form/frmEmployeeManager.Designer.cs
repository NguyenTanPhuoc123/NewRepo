
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeManager));
            this.label1 = new System.Windows.Forms.Label();
            this.cbSortEmployee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchEmployee = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFillEmployee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtgvListEmployee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkingDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.grpEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.richtxtAddress = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPosition = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpWorkingDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumberPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBirthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.grpFunctionEmployee = new System.Windows.Forms.GroupBox();
            this.btnSaveEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAllEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployeeDeleted = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchEmployee = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListEmployee)).BeginInit();
            this.grpEmployeeInfo.SuspendLayout();
            this.grpFunctionEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
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
            this.cbSortEmployee.Items.AddRange(new object[] {
            "Mặc định",
            "Tên nhân viên",
            "Mã nhân viên"});
            this.cbSortEmployee.Location = new System.Drawing.Point(36, 268);
            this.cbSortEmployee.Name = "cbSortEmployee";
            this.cbSortEmployee.Size = new System.Drawing.Size(163, 36);
            this.cbSortEmployee.TabIndex = 10;
            this.cbSortEmployee.SelectedIndexChanged += new System.EventHandler(this.cbSortEmployee_SelectedIndexChanged);
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
            this.txtSearchEmployee.Location = new System.Drawing.Point(378, 268);
            this.txtSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.PasswordChar = '\0';
            this.txtSearchEmployee.PlaceholderText = "";
            this.txtSearchEmployee.SelectedText = "";
            this.txtSearchEmployee.Size = new System.Drawing.Size(263, 36);
            this.txtSearchEmployee.TabIndex = 11;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
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
            this.cbFillEmployee.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbFillEmployee.Location = new System.Drawing.Point(852, 269);
            this.cbFillEmployee.Name = "cbFillEmployee";
            this.cbFillEmployee.Size = new System.Drawing.Size(163, 36);
            this.cbFillEmployee.TabIndex = 13;
            this.cbFillEmployee.SelectedIndexChanged += new System.EventHandler(this.cbFillEmployee_SelectedIndexChanged);
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
            this.dtgvListEmployee.ColumnHeadersHeight = 38;
            this.dtgvListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployeeID,
            this.colEmployeeFullName,
            this.colBirthDay,
            this.colSex,
            this.colNumberPhone,
            this.colAddress,
            this.colWorkingDay,
            this.colPosition,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvListEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListEmployee.Location = new System.Drawing.Point(36, 311);
            this.dtgvListEmployee.Name = "dtgvListEmployee";
            this.dtgvListEmployee.RowHeadersVisible = false;
            this.dtgvListEmployee.RowHeadersWidth = 51;
            this.dtgvListEmployee.RowTemplate.Height = 24;
            this.dtgvListEmployee.Size = new System.Drawing.Size(980, 179);
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
            this.dtgvListEmployee.ThemeStyle.HeaderStyle.Height = 38;
            this.dtgvListEmployee.ThemeStyle.ReadOnly = false;
            this.dtgvListEmployee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListEmployee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListEmployee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListEmployee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListEmployee.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvListEmployee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListEmployee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListEmployee_CellClick);
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.DataPropertyName = "MANV";
            this.colEmployeeID.HeaderText = "Mã nhân viên";
            this.colEmployeeID.MinimumWidth = 6;
            this.colEmployeeID.Name = "colEmployeeID";
            // 
            // colEmployeeFullName
            // 
            this.colEmployeeFullName.DataPropertyName = "TENNV";
            this.colEmployeeFullName.HeaderText = "Họ tên";
            this.colEmployeeFullName.MinimumWidth = 6;
            this.colEmployeeFullName.Name = "colEmployeeFullName";
            // 
            // colBirthDay
            // 
            this.colBirthDay.DataPropertyName = "NGAYSINH";
            this.colBirthDay.HeaderText = "Ngày sinh";
            this.colBirthDay.MinimumWidth = 6;
            this.colBirthDay.Name = "colBirthDay";
            // 
            // colSex
            // 
            this.colSex.DataPropertyName = "GIOITINH";
            this.colSex.HeaderText = "Giới tính";
            this.colSex.MinimumWidth = 6;
            this.colSex.Name = "colSex";
            // 
            // colNumberPhone
            // 
            this.colNumberPhone.DataPropertyName = "SODIENTHOAI";
            this.colNumberPhone.HeaderText = "Số điện thoai";
            this.colNumberPhone.MinimumWidth = 6;
            this.colNumberPhone.Name = "colNumberPhone";
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "DIACHI";
            this.colAddress.HeaderText = "Địa chỉ";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            // 
            // colWorkingDay
            // 
            this.colWorkingDay.DataPropertyName = "NGAYVAOLAM";
            this.colWorkingDay.HeaderText = "Ngày vào làm";
            this.colWorkingDay.MinimumWidth = 6;
            this.colWorkingDay.Name = "colWorkingDay";
            // 
            // colPosition
            // 
            this.colPosition.DataPropertyName = "TenChucVu";
            this.colPosition.HeaderText = "Chức vụ";
            this.colPosition.MinimumWidth = 6;
            this.colPosition.Name = "colPosition";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaChucVu";
            this.Column1.HeaderText = "MaChucVu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(852, 247);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(21, 15);
            this.guna2HtmlLabel1.TabIndex = 18;
            this.guna2HtmlLabel1.Text = "Lọc";
            // 
            // grpEmployeeInfo
            // 
            this.grpEmployeeInfo.Controls.Add(this.richtxtAddress);
            this.grpEmployeeInfo.Controls.Add(this.label9);
            this.grpEmployeeInfo.Controls.Add(this.cbPosition);
            this.grpEmployeeInfo.Controls.Add(this.label8);
            this.grpEmployeeInfo.Controls.Add(this.dtpWorkingDay);
            this.grpEmployeeInfo.Controls.Add(this.label7);
            this.grpEmployeeInfo.Controls.Add(this.txtNumberPhone);
            this.grpEmployeeInfo.Controls.Add(this.label6);
            this.grpEmployeeInfo.Controls.Add(this.radFemale);
            this.grpEmployeeInfo.Controls.Add(this.radMale);
            this.grpEmployeeInfo.Controls.Add(this.label5);
            this.grpEmployeeInfo.Controls.Add(this.dtpBirthday);
            this.grpEmployeeInfo.Controls.Add(this.label4);
            this.grpEmployeeInfo.Controls.Add(this.txtEmployeeName);
            this.grpEmployeeInfo.Controls.Add(this.label3);
            this.grpEmployeeInfo.Controls.Add(this.txtEmployeeID);
            this.grpEmployeeInfo.Controls.Add(this.label2);
            this.grpEmployeeInfo.Location = new System.Drawing.Point(12, 12);
            this.grpEmployeeInfo.Name = "grpEmployeeInfo";
            this.grpEmployeeInfo.Size = new System.Drawing.Size(681, 232);
            this.grpEmployeeInfo.TabIndex = 28;
            this.grpEmployeeInfo.TabStop = false;
            this.grpEmployeeInfo.Text = "Thông tin nhân viên";
            // 
            // richtxtAddress
            // 
            this.richtxtAddress.Location = new System.Drawing.Point(467, 157);
            this.richtxtAddress.Name = "richtxtAddress";
            this.richtxtAddress.Size = new System.Drawing.Size(207, 63);
            this.richtxtAddress.TabIndex = 16;
            this.richtxtAddress.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Địa chỉ:";
            // 
            // cbPosition
            // 
            this.cbPosition.BackColor = System.Drawing.Color.Transparent;
            this.cbPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPosition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPosition.ItemHeight = 30;
            this.cbPosition.Location = new System.Drawing.Point(467, 115);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(151, 36);
            this.cbPosition.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Chức vụ:";
            // 
            // dtpWorkingDay
            // 
            this.dtpWorkingDay.Checked = true;
            this.dtpWorkingDay.FillColor = System.Drawing.Color.GreenYellow;
            this.dtpWorkingDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpWorkingDay.ForeColor = System.Drawing.Color.White;
            this.dtpWorkingDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWorkingDay.Location = new System.Drawing.Point(467, 72);
            this.dtpWorkingDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpWorkingDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpWorkingDay.Name = "dtpWorkingDay";
            this.dtpWorkingDay.Size = new System.Drawing.Size(207, 36);
            this.dtpWorkingDay.TabIndex = 12;
            this.dtpWorkingDay.Value = new System.DateTime(2023, 4, 5, 20, 49, 55, 109);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày vào làm:";
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.BorderRadius = 10;
            this.txtNumberPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberPhone.DefaultText = "";
            this.txtNumberPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumberPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumberPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumberPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberPhone.Location = new System.Drawing.Point(467, 24);
            this.txtNumberPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.PasswordChar = '\0';
            this.txtNumberPhone.PlaceholderText = "";
            this.txtNumberPhone.SelectedText = "";
            this.txtNumberPhone.Size = new System.Drawing.Size(207, 38);
            this.txtNumberPhone.TabIndex = 10;
            this.txtNumberPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberPhone_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số điện thoại:";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(207, 175);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(41, 19);
            this.radFemale.TabIndex = 8;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(111, 175);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(52, 19);
            this.radMale.TabIndex = 7;
            this.radMale.TabStop = true;
            this.radMale.Text = "Nam";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giới tính:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Checked = true;
            this.dtpBirthday.FillColor = System.Drawing.Color.GreenYellow;
            this.dtpBirthday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBirthday.ForeColor = System.Drawing.Color.White;
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(111, 115);
            this.dtpBirthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(207, 36);
            this.dtpBirthday.TabIndex = 5;
            this.dtpBirthday.Value = new System.DateTime(2023, 4, 5, 20, 49, 55, 109);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
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
            this.txtEmployeeName.Location = new System.Drawing.Point(111, 70);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PasswordChar = '\0';
            this.txtEmployeeName.PlaceholderText = "";
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.Size = new System.Drawing.Size(207, 38);
            this.txtEmployeeName.TabIndex = 3;
            this.txtEmployeeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhân viên:";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BorderRadius = 10;
            this.txtEmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeeID.DefaultText = "";
            this.txtEmployeeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmployeeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmployeeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployeeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeID.Location = new System.Drawing.Point(111, 24);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.PasswordChar = '\0';
            this.txtEmployeeID.PlaceholderText = "";
            this.txtEmployeeID.SelectedText = "";
            this.txtEmployeeID.Size = new System.Drawing.Size(207, 38);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên:";
            // 
            // grpFunctionEmployee
            // 
            this.grpFunctionEmployee.Controls.Add(this.btnSaveEmployee);
            this.grpFunctionEmployee.Controls.Add(this.btnAddEmployee);
            this.grpFunctionEmployee.Controls.Add(this.btnEditEmployee);
            this.grpFunctionEmployee.Controls.Add(this.btnDeleteAllEmployee);
            this.grpFunctionEmployee.Controls.Add(this.btnDeleteEmployee);
            this.grpFunctionEmployee.Controls.Add(this.btnEmployeeDeleted);
            this.grpFunctionEmployee.Location = new System.Drawing.Point(699, 20);
            this.grpFunctionEmployee.Name = "grpFunctionEmployee";
            this.grpFunctionEmployee.Size = new System.Drawing.Size(323, 218);
            this.grpFunctionEmployee.TabIndex = 29;
            this.grpFunctionEmployee.TabStop = false;
            this.grpFunctionEmployee.Text = "Chức năng";
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.BorderRadius = 20;
            this.btnSaveEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveEmployee.Enabled = false;
            this.btnSaveEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnSaveEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnSaveEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveEmployee.Image")));
            this.btnSaveEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveEmployee.Location = new System.Drawing.Point(156, 27);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(161, 45);
            this.btnSaveEmployee.TabIndex = 30;
            this.btnSaveEmployee.Text = "Lưu";
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
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
            this.btnAddEmployee.Location = new System.Drawing.Point(8, 27);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(113, 45);
            this.btnAddEmployee.TabIndex = 14;
            this.btnAddEmployee.Text = "Thêm";
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
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
            this.btnEditEmployee.Location = new System.Drawing.Point(6, 78);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(115, 45);
            this.btnEditEmployee.TabIndex = 15;
            this.btnEditEmployee.Text = "Sửa";
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
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
            this.btnDeleteAllEmployee.Location = new System.Drawing.Point(157, 151);
            this.btnDeleteAllEmployee.Name = "btnDeleteAllEmployee";
            this.btnDeleteAllEmployee.Size = new System.Drawing.Size(159, 43);
            this.btnDeleteAllEmployee.TabIndex = 27;
            this.btnDeleteAllEmployee.Text = "Xóa tất cả";
            this.btnDeleteAllEmployee.Click += new System.EventHandler(this.btnDeleteAllEmployee_Click);
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
            this.btnDeleteEmployee.Location = new System.Drawing.Point(8, 149);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(113, 45);
            this.btnDeleteEmployee.TabIndex = 16;
            this.btnDeleteEmployee.Text = "Xóa";
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
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
            this.btnEmployeeDeleted.Location = new System.Drawing.Point(157, 78);
            this.btnEmployeeDeleted.Name = "btnEmployeeDeleted";
            this.btnEmployeeDeleted.Size = new System.Drawing.Size(160, 45);
            this.btnEmployeeDeleted.TabIndex = 26;
            this.btnEmployeeDeleted.Text = "Nhân viên đã xóa";
            this.btnEmployeeDeleted.Click += new System.EventHandler(this.btnEmployeeDeleted_Click);
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
            this.btnSearchEmployee.Location = new System.Drawing.Point(652, 269);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(72, 36);
            this.btnSearchEmployee.TabIndex = 12;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // frmEmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 497);
            this.Controls.Add(this.grpFunctionEmployee);
            this.Controls.Add(this.grpEmployeeInfo);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dtgvListEmployee);
            this.Controls.Add(this.cbFillEmployee);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.txtSearchEmployee);
            this.Controls.Add(this.cbSortEmployee);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployeeManager";
            this.Text = "frmEmployeeManager";
            this.Load += new System.EventHandler(this.frmEmployeeManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListEmployee)).EndInit();
            this.grpEmployeeInfo.ResumeLayout(false);
            this.grpEmployeeInfo.PerformLayout();
            this.grpFunctionEmployee.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpEmployeeInfo;
        private System.Windows.Forms.RichTextBox richtxtAddress;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cbPosition;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpWorkingDay;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtNumberPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtEmployeeName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtEmployeeID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.GroupBox grpFunctionEmployee;
        private Guna.UI2.WinForms.Guna2Button btnSaveEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkingDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}