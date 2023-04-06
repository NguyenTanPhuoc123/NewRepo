
namespace frmLogin
{
    partial class frmAccountManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SortAccount = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchAccount = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFillAccount = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtgvListAccount = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grpAccountInfo = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTypeAccount = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtEmployee = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.grpFunctionAccount = new System.Windows.Forms.GroupBox();
            this.btnRefreshAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAllAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccountDeleted = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchAccount = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).BeginInit();
            this.grpAccountInfo.SuspendLayout();
            this.grpFunctionAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lọc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sắp xếp";
            // 
            // SortAccount
            // 
            this.SortAccount.BackColor = System.Drawing.Color.Transparent;
            this.SortAccount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SortAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortAccount.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SortAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SortAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SortAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SortAccount.ItemHeight = 30;
            this.SortAccount.Location = new System.Drawing.Point(67, 278);
            this.SortAccount.Name = "SortAccount";
            this.SortAccount.Size = new System.Drawing.Size(140, 36);
            this.SortAccount.TabIndex = 12;
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchAccount.DefaultText = "";
            this.txtSearchAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchAccount.Location = new System.Drawing.Point(267, 278);
            this.txtSearchAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.PasswordChar = '\0';
            this.txtSearchAccount.PlaceholderText = "";
            this.txtSearchAccount.SelectedText = "";
            this.txtSearchAccount.Size = new System.Drawing.Size(285, 36);
            this.txtSearchAccount.TabIndex = 13;
            // 
            // cbFillAccount
            // 
            this.cbFillAccount.BackColor = System.Drawing.Color.Transparent;
            this.cbFillAccount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFillAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillAccount.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFillAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFillAccount.ItemHeight = 30;
            this.cbFillAccount.Location = new System.Drawing.Point(769, 278);
            this.cbFillAccount.Name = "cbFillAccount";
            this.cbFillAccount.Size = new System.Drawing.Size(150, 36);
            this.cbFillAccount.TabIndex = 16;
            // 
            // dtgvListAccount
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvListAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvListAccount.ColumnHeadersHeight = 20;
            this.dtgvListAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvListAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListAccount.Location = new System.Drawing.Point(67, 320);
            this.dtgvListAccount.Name = "dtgvListAccount";
            this.dtgvListAccount.RowHeadersVisible = false;
            this.dtgvListAccount.RowHeadersWidth = 51;
            this.dtgvListAccount.RowTemplate.Height = 24;
            this.dtgvListAccount.Size = new System.Drawing.Size(852, 182);
            this.dtgvListAccount.TabIndex = 20;
            this.dtgvListAccount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListAccount.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvListAccount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvListAccount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvListAccount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvListAccount.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListAccount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListAccount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvListAccount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvListAccount.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListAccount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvListAccount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListAccount.ThemeStyle.HeaderStyle.Height = 20;
            this.dtgvListAccount.ThemeStyle.ReadOnly = false;
            this.dtgvListAccount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListAccount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListAccount.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListAccount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListAccount.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvListAccount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListAccount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // grpAccountInfo
            // 
            this.grpAccountInfo.Controls.Add(this.label6);
            this.grpAccountInfo.Controls.Add(this.cbTypeAccount);
            this.grpAccountInfo.Controls.Add(this.txtEmployee);
            this.grpAccountInfo.Controls.Add(this.label5);
            this.grpAccountInfo.Controls.Add(this.txtPassword);
            this.grpAccountInfo.Controls.Add(this.label4);
            this.grpAccountInfo.Controls.Add(this.txtUsername);
            this.grpAccountInfo.Controls.Add(this.label2);
            this.grpAccountInfo.Location = new System.Drawing.Point(12, 12);
            this.grpAccountInfo.Name = "grpAccountInfo";
            this.grpAccountInfo.Size = new System.Drawing.Size(483, 242);
            this.grpAccountInfo.TabIndex = 28;
            this.grpAccountInfo.TabStop = false;
            this.grpAccountInfo.Text = "Thông tin tài khoản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Loại tài khoản:";
            // 
            // cbTypeAccount
            // 
            this.cbTypeAccount.BackColor = System.Drawing.Color.Transparent;
            this.cbTypeAccount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeAccount.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTypeAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTypeAccount.ItemHeight = 30;
            this.cbTypeAccount.Location = new System.Drawing.Point(161, 164);
            this.cbTypeAccount.Name = "cbTypeAccount";
            this.cbTypeAccount.Size = new System.Drawing.Size(154, 36);
            this.cbTypeAccount.TabIndex = 6;
            // 
            // txtEmployee
            // 
            this.txtEmployee.BorderRadius = 10;
            this.txtEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployee.DefaultText = "";
            this.txtEmployee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployee.Location = new System.Drawing.Point(161, 119);
            this.txtEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.PasswordChar = '\0';
            this.txtEmployee.PlaceholderText = "";
            this.txtEmployee.SelectedText = "";
            this.txtEmployee.Size = new System.Drawing.Size(200, 38);
            this.txtEmployee.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhân viên:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(161, 73);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(200, 38);
            this.txtPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(161, 24);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(200, 38);
            this.txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // grpFunctionAccount
            // 
            this.grpFunctionAccount.Controls.Add(this.btnRefreshAccount);
            this.grpFunctionAccount.Controls.Add(this.btnAddAccount);
            this.grpFunctionAccount.Controls.Add(this.btnEditAccount);
            this.grpFunctionAccount.Controls.Add(this.btnDeleteAllAccount);
            this.grpFunctionAccount.Controls.Add(this.btnDeleteAccount);
            this.grpFunctionAccount.Controls.Add(this.btnAccountDeleted);
            this.grpFunctionAccount.Location = new System.Drawing.Point(558, 12);
            this.grpFunctionAccount.Name = "grpFunctionAccount";
            this.grpFunctionAccount.Size = new System.Drawing.Size(428, 242);
            this.grpFunctionAccount.TabIndex = 29;
            this.grpFunctionAccount.TabStop = false;
            this.grpFunctionAccount.Text = "Chức năng";
            // 
            // btnRefreshAccount
            // 
            this.btnRefreshAccount.BorderRadius = 20;
            this.btnRefreshAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefreshAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefreshAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnRefreshAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshAccount.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshAccount.Image")));
            this.btnRefreshAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefreshAccount.Location = new System.Drawing.Point(261, 23);
            this.btnRefreshAccount.Name = "btnRefreshAccount";
            this.btnRefreshAccount.Size = new System.Drawing.Size(161, 45);
            this.btnRefreshAccount.TabIndex = 28;
            this.btnRefreshAccount.Text = "Làm mới";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BorderRadius = 20;
            this.btnAddAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnAddAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAddAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAccount.Image")));
            this.btnAddAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddAccount.Location = new System.Drawing.Point(6, 23);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(123, 45);
            this.btnAddAccount.TabIndex = 17;
            this.btnAddAccount.Text = "Thêm";
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.BorderRadius = 20;
            this.btnEditAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btnEditAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditAccount.ForeColor = System.Drawing.Color.Black;
            this.btnEditAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnEditAccount.Image")));
            this.btnEditAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEditAccount.Location = new System.Drawing.Point(0, 103);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(129, 45);
            this.btnEditAccount.TabIndex = 18;
            this.btnEditAccount.Text = "Sửa";
            // 
            // btnDeleteAllAccount
            // 
            this.btnDeleteAllAccount.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteAllAccount.BorderRadius = 10;
            this.btnDeleteAllAccount.BorderThickness = 2;
            this.btnDeleteAllAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAllAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAllAccount.FillColor = System.Drawing.Color.White;
            this.btnDeleteAllAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteAllAccount.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAllAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllAccount.Image")));
            this.btnDeleteAllAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteAllAccount.Location = new System.Drawing.Point(261, 173);
            this.btnDeleteAllAccount.Name = "btnDeleteAllAccount";
            this.btnDeleteAllAccount.Size = new System.Drawing.Size(161, 43);
            this.btnDeleteAllAccount.TabIndex = 27;
            this.btnDeleteAllAccount.Text = "Xóa tất cả";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BorderRadius = 20;
            this.btnDeleteAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.btnDeleteAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAccount.Image")));
            this.btnDeleteAccount.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDeleteAccount.Location = new System.Drawing.Point(6, 173);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(123, 45);
            this.btnDeleteAccount.TabIndex = 19;
            this.btnDeleteAccount.Text = "Xóa";
            // 
            // btnAccountDeleted
            // 
            this.btnAccountDeleted.BorderRadius = 20;
            this.btnAccountDeleted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccountDeleted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccountDeleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccountDeleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccountDeleted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(184)))));
            this.btnAccountDeleted.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAccountDeleted.ForeColor = System.Drawing.Color.Black;
            this.btnAccountDeleted.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountDeleted.Image")));
            this.btnAccountDeleted.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAccountDeleted.Location = new System.Drawing.Point(261, 103);
            this.btnAccountDeleted.Name = "btnAccountDeleted";
            this.btnAccountDeleted.Size = new System.Drawing.Size(161, 45);
            this.btnAccountDeleted.TabIndex = 26;
            this.btnAccountDeleted.Text = "Tài khoản đã xóa";
            this.btnAccountDeleted.Click += new System.EventHandler(this.btnAccountDeleted_Click);
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.BorderRadius = 10;
            this.btnSearchAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchAccount.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearchAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchAccount.ForeColor = System.Drawing.Color.White;
            this.btnSearchAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchAccount.Image")));
            this.btnSearchAccount.Location = new System.Drawing.Point(558, 278);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(92, 36);
            this.btnSearchAccount.TabIndex = 14;
            // 
            // frmAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 514);
            this.Controls.Add(this.grpFunctionAccount);
            this.Controls.Add(this.grpAccountInfo);
            this.Controls.Add(this.dtgvListAccount);
            this.Controls.Add(this.cbFillAccount);
            this.Controls.Add(this.btnSearchAccount);
            this.Controls.Add(this.txtSearchAccount);
            this.Controls.Add(this.SortAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAccountManagement";
            this.Text = "frmAccountManagement";
            this.Load += new System.EventHandler(this.frmAccountManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).EndInit();
            this.grpAccountInfo.ResumeLayout(false);
            this.grpAccountInfo.PerformLayout();
            this.grpFunctionAccount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox SortAccount;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchAccount;
        private Guna.UI2.WinForms.Guna2Button btnSearchAccount;
        private Guna.UI2.WinForms.Guna2ComboBox cbFillAccount;
        private Guna.UI2.WinForms.Guna2Button btnAddAccount;
        private Guna.UI2.WinForms.Guna2Button btnEditAccount;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAccount;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvListAccount;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAllAccount;
        private Guna.UI2.WinForms.Guna2Button btnAccountDeleted;
        private System.Windows.Forms.GroupBox grpAccountInfo;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbTypeAccount;
        private Guna.UI2.WinForms.Guna2TextBox txtEmployee;
        private System.Windows.Forms.GroupBox grpFunctionAccount;
        private Guna.UI2.WinForms.Guna2Button btnRefreshAccount;
    }
}