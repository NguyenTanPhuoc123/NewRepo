
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbSortEmployee
            // 
            resources.ApplyResources(this.cbSortEmployee, "cbSortEmployee");
            this.cbSortEmployee.BackColor = System.Drawing.Color.Transparent;
            this.cbSortEmployee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSortEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortEmployee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSortEmployee.Items.AddRange(new object[] {
            resources.GetString("cbSortEmployee.Items"),
            resources.GetString("cbSortEmployee.Items1"),
            resources.GetString("cbSortEmployee.Items2")});
            this.cbSortEmployee.Name = "cbSortEmployee";
            this.cbSortEmployee.SelectedIndexChanged += new System.EventHandler(this.cbSortEmployee_SelectedIndexChanged);
            // 
            // txtSearchEmployee
            // 
            resources.ApplyResources(this.txtSearchEmployee, "txtSearchEmployee");
            this.txtSearchEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchEmployee.DefaultText = "";
            this.txtSearchEmployee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchEmployee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchEmployee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.PasswordChar = '\0';
            this.txtSearchEmployee.PlaceholderText = "";
            this.txtSearchEmployee.SelectedText = "";
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // cbFillEmployee
            // 
            resources.ApplyResources(this.cbFillEmployee, "cbFillEmployee");
            this.cbFillEmployee.BackColor = System.Drawing.Color.Transparent;
            this.cbFillEmployee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFillEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillEmployee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFillEmployee.Items.AddRange(new object[] {
            resources.GetString("cbFillEmployee.Items")});
            this.cbFillEmployee.Name = "cbFillEmployee";
            this.cbFillEmployee.SelectedIndexChanged += new System.EventHandler(this.cbFillEmployee_SelectedIndexChanged);
            // 
            // dtgvListEmployee
            // 
            resources.ApplyResources(this.dtgvListEmployee, "dtgvListEmployee");
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgvListEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListEmployee.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvListEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListEmployee.Name = "dtgvListEmployee";
            this.dtgvListEmployee.RowHeadersVisible = false;
            this.dtgvListEmployee.RowTemplate.Height = 24;
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
            resources.ApplyResources(this.colEmployeeID, "colEmployeeID");
            this.colEmployeeID.Name = "colEmployeeID";
            // 
            // colEmployeeFullName
            // 
            this.colEmployeeFullName.DataPropertyName = "TENNV";
            resources.ApplyResources(this.colEmployeeFullName, "colEmployeeFullName");
            this.colEmployeeFullName.Name = "colEmployeeFullName";
            // 
            // colBirthDay
            // 
            this.colBirthDay.DataPropertyName = "NGAYSINH";
            resources.ApplyResources(this.colBirthDay, "colBirthDay");
            this.colBirthDay.Name = "colBirthDay";
            // 
            // colSex
            // 
            this.colSex.DataPropertyName = "GIOITINH";
            resources.ApplyResources(this.colSex, "colSex");
            this.colSex.Name = "colSex";
            // 
            // colNumberPhone
            // 
            this.colNumberPhone.DataPropertyName = "SODIENTHOAI";
            resources.ApplyResources(this.colNumberPhone, "colNumberPhone");
            this.colNumberPhone.Name = "colNumberPhone";
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "DIACHI";
            resources.ApplyResources(this.colAddress, "colAddress");
            this.colAddress.Name = "colAddress";
            // 
            // colWorkingDay
            // 
            this.colWorkingDay.DataPropertyName = "NGAYVAOLAM";
            resources.ApplyResources(this.colWorkingDay, "colWorkingDay");
            this.colWorkingDay.Name = "colWorkingDay";
            // 
            // colPosition
            // 
            this.colPosition.DataPropertyName = "TenChucVu";
            resources.ApplyResources(this.colPosition, "colPosition");
            this.colPosition.Name = "colPosition";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaChucVu";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // guna2HtmlLabel1
            // 
            resources.ApplyResources(this.guna2HtmlLabel1, "guna2HtmlLabel1");
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            // 
            // grpEmployeeInfo
            // 
            resources.ApplyResources(this.grpEmployeeInfo, "grpEmployeeInfo");
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
            this.grpEmployeeInfo.Name = "grpEmployeeInfo";
            this.grpEmployeeInfo.TabStop = false;
            // 
            // richtxtAddress
            // 
            resources.ApplyResources(this.richtxtAddress, "richtxtAddress");
            this.richtxtAddress.Name = "richtxtAddress";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // cbPosition
            // 
            resources.ApplyResources(this.cbPosition, "cbPosition");
            this.cbPosition.BackColor = System.Drawing.Color.Transparent;
            this.cbPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPosition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPosition.Name = "cbPosition";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // dtpWorkingDay
            // 
            resources.ApplyResources(this.dtpWorkingDay, "dtpWorkingDay");
            this.dtpWorkingDay.Checked = true;
            this.dtpWorkingDay.FillColor = System.Drawing.Color.GreenYellow;
            this.dtpWorkingDay.ForeColor = System.Drawing.Color.White;
            this.dtpWorkingDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWorkingDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpWorkingDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpWorkingDay.Name = "dtpWorkingDay";
            this.dtpWorkingDay.Value = new System.DateTime(2023, 4, 5, 20, 49, 55, 109);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtNumberPhone
            // 
            resources.ApplyResources(this.txtNumberPhone, "txtNumberPhone");
            this.txtNumberPhone.BorderRadius = 10;
            this.txtNumberPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberPhone.DefaultText = "";
            this.txtNumberPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumberPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumberPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.PasswordChar = '\0';
            this.txtNumberPhone.PlaceholderText = "";
            this.txtNumberPhone.SelectedText = "";
            this.txtNumberPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberPhone_KeyPress);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // radFemale
            // 
            resources.ApplyResources(this.radFemale, "radFemale");
            this.radFemale.Name = "radFemale";
            this.radFemale.TabStop = true;
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            resources.ApplyResources(this.radMale, "radMale");
            this.radMale.Name = "radMale";
            this.radMale.TabStop = true;
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // dtpBirthday
            // 
            resources.ApplyResources(this.dtpBirthday, "dtpBirthday");
            this.dtpBirthday.Checked = true;
            this.dtpBirthday.FillColor = System.Drawing.Color.GreenYellow;
            this.dtpBirthday.ForeColor = System.Drawing.Color.White;
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Value = new System.DateTime(2023, 4, 5, 20, 49, 55, 109);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtEmployeeName
            // 
            resources.ApplyResources(this.txtEmployeeName, "txtEmployeeName");
            this.txtEmployeeName.BorderRadius = 10;
            this.txtEmployeeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeeName.DefaultText = "";
            this.txtEmployeeName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmployeeName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmployeeName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PasswordChar = '\0';
            this.txtEmployeeName.PlaceholderText = "";
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeName_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtEmployeeID
            // 
            resources.ApplyResources(this.txtEmployeeID, "txtEmployeeID");
            this.txtEmployeeID.BorderRadius = 10;
            this.txtEmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeeID.DefaultText = "";
            this.txtEmployeeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmployeeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmployeeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.PasswordChar = '\0';
            this.txtEmployeeID.PlaceholderText = "";
            this.txtEmployeeID.SelectedText = "";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // grpFunctionEmployee
            // 
            resources.ApplyResources(this.grpFunctionEmployee, "grpFunctionEmployee");
            this.grpFunctionEmployee.Controls.Add(this.btnSaveEmployee);
            this.grpFunctionEmployee.Controls.Add(this.btnAddEmployee);
            this.grpFunctionEmployee.Controls.Add(this.btnEditEmployee);
            this.grpFunctionEmployee.Controls.Add(this.btnDeleteAllEmployee);
            this.grpFunctionEmployee.Controls.Add(this.btnDeleteEmployee);
            this.grpFunctionEmployee.Controls.Add(this.btnEmployeeDeleted);
            this.grpFunctionEmployee.Name = "grpFunctionEmployee";
            this.grpFunctionEmployee.TabStop = false;
            // 
            // btnSaveEmployee
            // 
            resources.ApplyResources(this.btnSaveEmployee, "btnSaveEmployee");
            this.btnSaveEmployee.BorderRadius = 20;
            this.btnSaveEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnSaveEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnSaveEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveEmployee.Image")));
            this.btnSaveEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // btnAddEmployee
            // 
            resources.ApplyResources(this.btnAddEmployee, "btnAddEmployee");
            this.btnAddEmployee.BorderRadius = 20;
            this.btnAddEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnEditEmployee
            // 
            resources.ApplyResources(this.btnEditEmployee, "btnEditEmployee");
            this.btnEditEmployee.BorderRadius = 20;
            this.btnEditEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btnEditEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnEditEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEditEmployee.Image")));
            this.btnEditEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnDeleteAllEmployee
            // 
            resources.ApplyResources(this.btnDeleteAllEmployee, "btnDeleteAllEmployee");
            this.btnDeleteAllEmployee.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteAllEmployee.BorderRadius = 10;
            this.btnDeleteAllEmployee.BorderThickness = 2;
            this.btnDeleteAllEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAllEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAllEmployee.FillColor = System.Drawing.Color.White;
            this.btnDeleteAllEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAllEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllEmployee.Image")));
            this.btnDeleteAllEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteAllEmployee.Name = "btnDeleteAllEmployee";
            this.btnDeleteAllEmployee.Click += new System.EventHandler(this.btnDeleteAllEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            resources.ApplyResources(this.btnDeleteEmployee, "btnDeleteEmployee");
            this.btnDeleteEmployee.BorderRadius = 20;
            this.btnDeleteEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteEmployee.Image")));
            this.btnDeleteEmployee.ImageSize = new System.Drawing.Size(45, 45);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnEmployeeDeleted
            // 
            resources.ApplyResources(this.btnEmployeeDeleted, "btnEmployeeDeleted");
            this.btnEmployeeDeleted.BorderRadius = 20;
            this.btnEmployeeDeleted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployeeDeleted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployeeDeleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployeeDeleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployeeDeleted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(184)))));
            this.btnEmployeeDeleted.ForeColor = System.Drawing.Color.Black;
            this.btnEmployeeDeleted.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeDeleted.Image")));
            this.btnEmployeeDeleted.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEmployeeDeleted.Name = "btnEmployeeDeleted";
            this.btnEmployeeDeleted.Click += new System.EventHandler(this.btnEmployeeDeleted_Click);
            // 
            // btnSearchEmployee
            // 
            resources.ApplyResources(this.btnSearchEmployee, "btnSearchEmployee");
            this.btnSearchEmployee.BorderRadius = 10;
            this.btnSearchEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchEmployee.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearchEmployee.ForeColor = System.Drawing.Color.White;
            this.btnSearchEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchEmployee.Image")));
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // frmEmployeeManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.grpFunctionEmployee);
            this.Controls.Add(this.grpEmployeeInfo);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dtgvListEmployee);
            this.Controls.Add(this.cbFillEmployee);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.txtSearchEmployee);
            this.Controls.Add(this.cbSortEmployee);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployeeManager";
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