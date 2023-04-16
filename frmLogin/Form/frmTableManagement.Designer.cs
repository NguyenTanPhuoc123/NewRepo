
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
            this.colTableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTableInfo = new System.Windows.Forms.GroupBox();
            this.cbLocation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTableName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTableID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpFunctionTable = new System.Windows.Forms.GroupBox();
            this.btnSaveTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAllTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnTableDeleted = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchTable = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListTable)).BeginInit();
            this.grpTableInfo.SuspendLayout();
            this.grpFunctionTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 221);
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
            this.cbSortTable.Items.AddRange(new object[] {
            "Mặc định",
            "Sắp xếp theo tên bàn",
            "Sắp xếp theo vị trí"});
            this.cbSortTable.Location = new System.Drawing.Point(36, 242);
            this.cbSortTable.Name = "cbSortTable";
            this.cbSortTable.Size = new System.Drawing.Size(203, 36);
            this.cbSortTable.TabIndex = 1;
            this.cbSortTable.SelectedIndexChanged += new System.EventHandler(this.cbSortTable_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(847, 221);
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
            this.cbFillTable.Items.AddRange(new object[] {
            "Tất cả",
            "Bên trong tầng 1",
            "Bên ngoài tầng 1",
            "Bên trong tầng 2",
            "Bên ngoài tầng 2 "});
            this.cbFillTable.Location = new System.Drawing.Point(850, 242);
            this.cbFillTable.Name = "cbFillTable";
            this.cbFillTable.Size = new System.Drawing.Size(167, 36);
            this.cbFillTable.TabIndex = 3;
            this.cbFillTable.SelectedIndexChanged += new System.EventHandler(this.cbFillTable_SelectedIndexChanged);
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
            this.txtSearchTable.Location = new System.Drawing.Point(349, 237);
            this.txtSearchTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchTable.Name = "txtSearchTable";
            this.txtSearchTable.PasswordChar = '\0';
            this.txtSearchTable.PlaceholderText = "";
            this.txtSearchTable.SelectedText = "";
            this.txtSearchTable.Size = new System.Drawing.Size(282, 41);
            this.txtSearchTable.TabIndex = 4;
            this.txtSearchTable.TextChanged += new System.EventHandler(this.txtSearchTable_TextChanged);
            // 
            // dtgvListTable
            // 
            this.dtgvListTable.AllowUserToAddRows = false;
            this.dtgvListTable.AllowUserToDeleteRows = false;
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
            this.dtgvListTable.ColumnHeadersHeight = 25;
            this.dtgvListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTableID,
            this.colTableName,
            this.colLocation,
            this.colStatus,
            this.colLocationID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvListTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListTable.Location = new System.Drawing.Point(36, 284);
            this.dtgvListTable.Name = "dtgvListTable";
            this.dtgvListTable.RowHeadersVisible = false;
            this.dtgvListTable.RowHeadersWidth = 51;
            this.dtgvListTable.RowTemplate.Height = 24;
            this.dtgvListTable.Size = new System.Drawing.Size(981, 220);
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
            this.dtgvListTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListTable.ThemeStyle.HeaderStyle.Height = 25;
            this.dtgvListTable.ThemeStyle.ReadOnly = false;
            this.dtgvListTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListTable.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvListTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListTable_CellContentClick);
            this.dtgvListTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListTable_CellContentClick);
            // 
            // colTableID
            // 
            this.colTableID.DataPropertyName = "MaBanAn";
            this.colTableID.HeaderText = "Mã bàn ăn";
            this.colTableID.MinimumWidth = 6;
            this.colTableID.Name = "colTableID";
            // 
            // colTableName
            // 
            this.colTableName.DataPropertyName = "TenBan";
            this.colTableName.HeaderText = "Tên bàn ăn";
            this.colTableName.MinimumWidth = 6;
            this.colTableName.Name = "colTableName";
            // 
            // colLocation
            // 
            this.colLocation.DataPropertyName = "TenViTri";
            this.colLocation.HeaderText = "Vị trí";
            this.colLocation.MinimumWidth = 6;
            this.colLocation.Name = "colLocation";
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "TrangThai";
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            // 
            // colLocationID
            // 
            this.colLocationID.DataPropertyName = "MaViTri";
            this.colLocationID.HeaderText = "Mã vị trí";
            this.colLocationID.MinimumWidth = 6;
            this.colLocationID.Name = "colLocationID";
            this.colLocationID.Visible = false;
            // 
            // grpTableInfo
            // 
            this.grpTableInfo.Controls.Add(this.cbLocation);
            this.grpTableInfo.Controls.Add(this.label5);
            this.grpTableInfo.Controls.Add(this.txtTableName);
            this.grpTableInfo.Controls.Add(this.label4);
            this.grpTableInfo.Controls.Add(this.txtTableID);
            this.grpTableInfo.Controls.Add(this.label3);
            this.grpTableInfo.Location = new System.Drawing.Point(12, 12);
            this.grpTableInfo.Name = "grpTableInfo";
            this.grpTableInfo.Size = new System.Drawing.Size(415, 206);
            this.grpTableInfo.TabIndex = 12;
            this.grpTableInfo.TabStop = false;
            this.grpTableInfo.Text = "Thông tin bàn ăn";
            // 
            // cbLocation
            // 
            this.cbLocation.BackColor = System.Drawing.Color.Transparent;
            this.cbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLocation.ItemHeight = 30;
            this.cbLocation.Location = new System.Drawing.Point(112, 143);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(229, 36);
            this.cbLocation.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vị trí:";
            // 
            // txtTableName
            // 
            this.txtTableName.BorderRadius = 10;
            this.txtTableName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTableName.DefaultText = "";
            this.txtTableName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTableName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTableName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTableName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTableName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTableName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTableName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTableName.Location = new System.Drawing.Point(112, 80);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.PasswordChar = '\0';
            this.txtTableName.PlaceholderText = "";
            this.txtTableName.SelectedText = "";
            this.txtTableName.Size = new System.Drawing.Size(229, 48);
            this.txtTableName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên bàn ăn:";
            // 
            // txtTableID
            // 
            this.txtTableID.BorderRadius = 10;
            this.txtTableID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTableID.DefaultText = "";
            this.txtTableID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTableID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTableID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTableID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTableID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTableID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTableID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTableID.Location = new System.Drawing.Point(112, 24);
            this.txtTableID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTableID.Name = "txtTableID";
            this.txtTableID.PasswordChar = '\0';
            this.txtTableID.PlaceholderText = "";
            this.txtTableID.ReadOnly = true;
            this.txtTableID.SelectedText = "";
            this.txtTableID.Size = new System.Drawing.Size(229, 48);
            this.txtTableID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã bàn ăn:";
            // 
            // grpFunctionTable
            // 
            this.grpFunctionTable.Controls.Add(this.btnSaveTable);
            this.grpFunctionTable.Controls.Add(this.btnAddTable);
            this.grpFunctionTable.Controls.Add(this.btnEditTable);
            this.grpFunctionTable.Controls.Add(this.btnDeleteAllTable);
            this.grpFunctionTable.Controls.Add(this.btnDeleteTable);
            this.grpFunctionTable.Controls.Add(this.btnTableDeleted);
            this.grpFunctionTable.Location = new System.Drawing.Point(583, 12);
            this.grpFunctionTable.Name = "grpFunctionTable";
            this.grpFunctionTable.Size = new System.Drawing.Size(434, 206);
            this.grpFunctionTable.TabIndex = 13;
            this.grpFunctionTable.TabStop = false;
            this.grpFunctionTable.Text = "Chức năng";
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.BorderRadius = 20;
            this.btnSaveTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveTable.Enabled = false;
            this.btnSaveTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnSaveTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveTable.ForeColor = System.Drawing.Color.Black;
            this.btnSaveTable.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveTable.Image")));
            this.btnSaveTable.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveTable.Location = new System.Drawing.Point(280, 27);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(148, 45);
            this.btnSaveTable.TabIndex = 27;
            this.btnSaveTable.Text = "Lưu";
            this.btnSaveTable.Click += new System.EventHandler(this.btnSaveTable_Click);
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
            this.btnAddTable.Location = new System.Drawing.Point(6, 27);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(148, 45);
            this.btnAddTable.TabIndex = 7;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
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
            this.btnEditTable.Location = new System.Drawing.Point(6, 83);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(148, 45);
            this.btnEditTable.TabIndex = 8;
            this.btnEditTable.Text = "Sửa";
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
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
            this.btnDeleteAllTable.Location = new System.Drawing.Point(280, 154);
            this.btnDeleteAllTable.Name = "btnDeleteAllTable";
            this.btnDeleteAllTable.Size = new System.Drawing.Size(148, 43);
            this.btnDeleteAllTable.TabIndex = 11;
            this.btnDeleteAllTable.Text = "Xóa tất cả";
            this.btnDeleteAllTable.Click += new System.EventHandler(this.btnDeleteAllTable_Click);
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
            this.btnDeleteTable.Location = new System.Drawing.Point(6, 152);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(148, 45);
            this.btnDeleteTable.TabIndex = 9;
            this.btnDeleteTable.Text = "Xóa";
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
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
            this.btnTableDeleted.Location = new System.Drawing.Point(280, 83);
            this.btnTableDeleted.Name = "btnTableDeleted";
            this.btnTableDeleted.Size = new System.Drawing.Size(148, 45);
            this.btnTableDeleted.TabIndex = 10;
            this.btnTableDeleted.Text = "Bàn đã xóa";
            this.btnTableDeleted.Click += new System.EventHandler(this.btnTableDeleted_Click);
            // 
            // btnSearchTable
            // 
            this.btnSearchTable.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchTable.BorderRadius = 10;
            this.btnSearchTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchTable.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearchTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchTable.ForeColor = System.Drawing.Color.White;
            this.btnSearchTable.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTable.Image")));
            this.btnSearchTable.Location = new System.Drawing.Point(637, 237);
            this.btnSearchTable.Name = "btnSearchTable";
            this.btnSearchTable.Size = new System.Drawing.Size(99, 41);
            this.btnSearchTable.TabIndex = 6;
            this.btnSearchTable.Click += new System.EventHandler(this.btnSearchTable_Click);
            // 
            // frmTableManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 516);
            this.Controls.Add(this.grpFunctionTable);
            this.Controls.Add(this.grpTableInfo);
            this.Controls.Add(this.btnSearchTable);
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
            this.Load += new System.EventHandler(this.frmTableManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListTable)).EndInit();
            this.grpTableInfo.ResumeLayout(false);
            this.grpTableInfo.PerformLayout();
            this.grpFunctionTable.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2Button btnSearchTable;
        private Guna.UI2.WinForms.Guna2Button btnAddTable;
        private Guna.UI2.WinForms.Guna2Button btnEditTable;
        private Guna.UI2.WinForms.Guna2Button btnDeleteTable;
        private Guna.UI2.WinForms.Guna2Button btnTableDeleted;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAllTable;
        private System.Windows.Forms.GroupBox grpTableInfo;
        private Guna.UI2.WinForms.Guna2ComboBox cbLocation;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtTableName;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtTableID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpFunctionTable;
        private Guna.UI2.WinForms.Guna2Button btnSaveTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocationID;
    }
}