
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSortAccount = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchAccount = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFillAccount = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtgvListAccount = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grpAccountInfo = new System.Windows.Forms.GroupBox();
            this.cbEmloyee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTypeAccount = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.grpFunctionAccount = new System.Windows.Forms.GroupBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAllAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccountDeleted = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchAccount = new Guna.UI2.WinForms.Guna2Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).BeginInit();
            this.grpAccountInfo.SuspendLayout();
            this.grpFunctionAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbSortAccount
            // 
            resources.ApplyResources(this.cbSortAccount, "cbSortAccount");
            this.cbSortAccount.BackColor = System.Drawing.Color.Transparent;
            this.cbSortAccount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSortAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortAccount.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSortAccount.Items.AddRange(new object[] {
            resources.GetString("cbSortAccount.Items"),
            resources.GetString("cbSortAccount.Items1"),
            resources.GetString("cbSortAccount.Items2")});
            this.cbSortAccount.Name = "cbSortAccount";
            this.cbSortAccount.SelectedIndexChanged += new System.EventHandler(this.cbSortAccount_SelectedIndexChanged);
            // 
            // txtSearchAccount
            // 
            resources.ApplyResources(this.txtSearchAccount, "txtSearchAccount");
            this.txtSearchAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchAccount.DefaultText = "";
            this.txtSearchAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.PasswordChar = '\0';
            this.txtSearchAccount.PlaceholderText = "";
            this.txtSearchAccount.SelectedText = "";
            this.txtSearchAccount.TextChanged += new System.EventHandler(this.txtSearchAccount_TextChanged);
            // 
            // cbFillAccount
            // 
            resources.ApplyResources(this.cbFillAccount, "cbFillAccount");
            this.cbFillAccount.BackColor = System.Drawing.Color.Transparent;
            this.cbFillAccount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFillAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillAccount.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFillAccount.Items.AddRange(new object[] {
            resources.GetString("cbFillAccount.Items"),
            resources.GetString("cbFillAccount.Items1"),
            resources.GetString("cbFillAccount.Items2")});
            this.cbFillAccount.Name = "cbFillAccount";
            this.cbFillAccount.SelectedIndexChanged += new System.EventHandler(this.cbFillAccount_SelectedIndexChanged);
            // 
            // dtgvListAccount
            // 
            resources.ApplyResources(this.dtgvListAccount, "dtgvListAccount");
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgvListAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvListAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListAccount.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvListAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListAccount.Name = "dtgvListAccount";
            this.dtgvListAccount.ReadOnly = true;
            this.dtgvListAccount.RowHeadersVisible = false;
            this.dtgvListAccount.RowTemplate.Height = 24;
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
            this.dtgvListAccount.ThemeStyle.ReadOnly = true;
            this.dtgvListAccount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListAccount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListAccount.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListAccount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListAccount.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvListAccount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListAccount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListAccount_CellClick);
            // 
            // grpAccountInfo
            // 
            resources.ApplyResources(this.grpAccountInfo, "grpAccountInfo");
            this.grpAccountInfo.Controls.Add(this.cbEmloyee);
            this.grpAccountInfo.Controls.Add(this.label6);
            this.grpAccountInfo.Controls.Add(this.cbTypeAccount);
            this.grpAccountInfo.Controls.Add(this.label5);
            this.grpAccountInfo.Controls.Add(this.txtPassword);
            this.grpAccountInfo.Controls.Add(this.label4);
            this.grpAccountInfo.Controls.Add(this.txtUsername);
            this.grpAccountInfo.Controls.Add(this.label2);
            this.grpAccountInfo.Name = "grpAccountInfo";
            this.grpAccountInfo.TabStop = false;
            // 
            // cbEmloyee
            // 
            resources.ApplyResources(this.cbEmloyee, "cbEmloyee");
            this.cbEmloyee.BackColor = System.Drawing.Color.Transparent;
            this.cbEmloyee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEmloyee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmloyee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbEmloyee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbEmloyee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbEmloyee.Name = "cbEmloyee";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // cbTypeAccount
            // 
            resources.ApplyResources(this.cbTypeAccount, "cbTypeAccount");
            this.cbTypeAccount.BackColor = System.Drawing.Color.Transparent;
            this.cbTypeAccount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeAccount.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTypeAccount.Name = "cbTypeAccount";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // grpFunctionAccount
            // 
            resources.ApplyResources(this.grpFunctionAccount, "grpFunctionAccount");
            this.grpFunctionAccount.Controls.Add(this.btnSave);
            this.grpFunctionAccount.Controls.Add(this.btnAddAccount);
            this.grpFunctionAccount.Controls.Add(this.btnEditAccount);
            this.grpFunctionAccount.Controls.Add(this.btnDeleteAllAccount);
            this.grpFunctionAccount.Controls.Add(this.btnDeleteAccount);
            this.grpFunctionAccount.Controls.Add(this.btnAccountDeleted);
            this.grpFunctionAccount.Name = "grpFunctionAccount";
            this.grpFunctionAccount.TabStop = false;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BorderRadius = 20;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddAccount
            // 
            resources.ApplyResources(this.btnAddAccount, "btnAddAccount");
            this.btnAddAccount.BorderRadius = 20;
            this.btnAddAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnAddAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAddAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAccount.Image")));
            this.btnAddAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnEditAccount
            // 
            resources.ApplyResources(this.btnEditAccount, "btnEditAccount");
            this.btnEditAccount.BorderRadius = 20;
            this.btnEditAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btnEditAccount.ForeColor = System.Drawing.Color.Black;
            this.btnEditAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnEditAccount.Image")));
            this.btnEditAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnDeleteAllAccount
            // 
            resources.ApplyResources(this.btnDeleteAllAccount, "btnDeleteAllAccount");
            this.btnDeleteAllAccount.BorderColor = System.Drawing.Color.Red;
            this.btnDeleteAllAccount.BorderRadius = 10;
            this.btnDeleteAllAccount.BorderThickness = 2;
            this.btnDeleteAllAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAllAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAllAccount.FillColor = System.Drawing.Color.White;
            this.btnDeleteAllAccount.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAllAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllAccount.Image")));
            this.btnDeleteAllAccount.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteAllAccount.Name = "btnDeleteAllAccount";
            this.btnDeleteAllAccount.Click += new System.EventHandler(this.btnDeleteAllAccount_Click);
            // 
            // btnDeleteAccount
            // 
            resources.ApplyResources(this.btnDeleteAccount, "btnDeleteAccount");
            this.btnDeleteAccount.BorderRadius = 20;
            this.btnDeleteAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAccount.Image")));
            this.btnDeleteAccount.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAccountDeleted
            // 
            resources.ApplyResources(this.btnAccountDeleted, "btnAccountDeleted");
            this.btnAccountDeleted.BorderRadius = 20;
            this.btnAccountDeleted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccountDeleted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccountDeleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccountDeleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccountDeleted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(184)))));
            this.btnAccountDeleted.ForeColor = System.Drawing.Color.Black;
            this.btnAccountDeleted.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountDeleted.Image")));
            this.btnAccountDeleted.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAccountDeleted.Name = "btnAccountDeleted";
            this.btnAccountDeleted.Click += new System.EventHandler(this.btnAccountDeleted_Click);
            // 
            // btnSearchAccount
            // 
            resources.ApplyResources(this.btnSearchAccount, "btnSearchAccount");
            this.btnSearchAccount.BorderRadius = 10;
            this.btnSearchAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchAccount.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearchAccount.ForeColor = System.Drawing.Color.White;
            this.btnSearchAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchAccount.Image")));
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Click += new System.EventHandler(this.btnSearchAccount_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Username";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Password";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TypeAccount";
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "EmployeeID";
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "EmployeeName";
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TypeName";
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmAccountManagement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.grpFunctionAccount);
            this.Controls.Add(this.grpAccountInfo);
            this.Controls.Add(this.dtgvListAccount);
            this.Controls.Add(this.cbFillAccount);
            this.Controls.Add(this.btnSearchAccount);
            this.Controls.Add(this.txtSearchAccount);
            this.Controls.Add(this.cbSortAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmAccountManagement";
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
        private Guna.UI2.WinForms.Guna2ComboBox cbSortAccount;
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
        private System.Windows.Forms.GroupBox grpFunctionAccount;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox cbEmloyee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}