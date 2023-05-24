
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbSortTable
            // 
            this.cbSortTable.BackColor = System.Drawing.Color.Transparent;
            this.cbSortTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSortTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.cbSortTable, "cbSortTable");
            this.cbSortTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSortTable.Items.AddRange(new object[] {
            resources.GetString("cbSortTable.Items"),
            resources.GetString("cbSortTable.Items1"),
            resources.GetString("cbSortTable.Items2"),
            resources.GetString("cbSortTable.Items3"),
            resources.GetString("cbSortTable.Items4")});
            this.cbSortTable.Name = "cbSortTable";
            this.cbSortTable.SelectedIndexChanged += new System.EventHandler(this.cbSortTable_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cbFillTable
            // 
            this.cbFillTable.BackColor = System.Drawing.Color.Transparent;
            this.cbFillTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFillTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.cbFillTable, "cbFillTable");
            this.cbFillTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFillTable.Name = "cbFillTable";
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
            resources.ApplyResources(this.txtSearchTable, "txtSearchTable");
            this.txtSearchTable.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchTable.Name = "txtSearchTable";
            this.txtSearchTable.PasswordChar = '\0';
            this.txtSearchTable.PlaceholderText = "";
            this.txtSearchTable.SelectedText = "";
            this.txtSearchTable.TextChanged += new System.EventHandler(this.txtSearchTable_TextChanged);
            // 
            // dtgvListTable
            // 
            this.dtgvListTable.AllowUserToAddRows = false;
            this.dtgvListTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgvListTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.dtgvListTable, "dtgvListTable");
            this.dtgvListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTableID,
            this.colTableName,
            this.colLocation,
            this.colStatus,
            this.colLocationID});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvListTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListTable.Name = "dtgvListTable";
            this.dtgvListTable.RowHeadersVisible = false;
            this.dtgvListTable.RowTemplate.Height = 24;
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
            resources.ApplyResources(this.colTableID, "colTableID");
            this.colTableID.Name = "colTableID";
            // 
            // colTableName
            // 
            this.colTableName.DataPropertyName = "TenBan";
            resources.ApplyResources(this.colTableName, "colTableName");
            this.colTableName.Name = "colTableName";
            // 
            // colLocation
            // 
            this.colLocation.DataPropertyName = "TenViTri";
            resources.ApplyResources(this.colLocation, "colLocation");
            this.colLocation.Name = "colLocation";
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "TrangThai";
            resources.ApplyResources(this.colStatus, "colStatus");
            this.colStatus.Name = "colStatus";
            // 
            // colLocationID
            // 
            this.colLocationID.DataPropertyName = "MaViTri";
            resources.ApplyResources(this.colLocationID, "colLocationID");
            this.colLocationID.Name = "colLocationID";
            // 
            // grpTableInfo
            // 
            this.grpTableInfo.Controls.Add(this.cbLocation);
            this.grpTableInfo.Controls.Add(this.label5);
            this.grpTableInfo.Controls.Add(this.txtTableName);
            this.grpTableInfo.Controls.Add(this.label4);
            this.grpTableInfo.Controls.Add(this.txtTableID);
            this.grpTableInfo.Controls.Add(this.label3);
            resources.ApplyResources(this.grpTableInfo, "grpTableInfo");
            this.grpTableInfo.Name = "grpTableInfo";
            this.grpTableInfo.TabStop = false;
            // 
            // cbLocation
            // 
            this.cbLocation.BackColor = System.Drawing.Color.Transparent;
            this.cbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.cbLocation, "cbLocation");
            this.cbLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLocation.Name = "cbLocation";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
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
            resources.ApplyResources(this.txtTableName, "txtTableName");
            this.txtTableName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.PasswordChar = '\0';
            this.txtTableName.PlaceholderText = "";
            this.txtTableName.SelectedText = "";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
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
            resources.ApplyResources(this.txtTableID, "txtTableID");
            this.txtTableID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTableID.Name = "txtTableID";
            this.txtTableID.PasswordChar = '\0';
            this.txtTableID.PlaceholderText = "";
            this.txtTableID.ReadOnly = true;
            this.txtTableID.SelectedText = "";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // grpFunctionTable
            // 
            this.grpFunctionTable.Controls.Add(this.btnSaveTable);
            this.grpFunctionTable.Controls.Add(this.btnAddTable);
            this.grpFunctionTable.Controls.Add(this.btnEditTable);
            this.grpFunctionTable.Controls.Add(this.btnDeleteAllTable);
            this.grpFunctionTable.Controls.Add(this.btnDeleteTable);
            this.grpFunctionTable.Controls.Add(this.btnTableDeleted);
            resources.ApplyResources(this.grpFunctionTable, "grpFunctionTable");
            this.grpFunctionTable.Name = "grpFunctionTable";
            this.grpFunctionTable.TabStop = false;
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.BorderRadius = 20;
            this.btnSaveTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btnSaveTable, "btnSaveTable");
            this.btnSaveTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.btnSaveTable.ForeColor = System.Drawing.Color.Black;
            this.btnSaveTable.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveTable.Image")));
            this.btnSaveTable.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Click += new System.EventHandler(this.btnSaveTable_Click);
            // 
            // btnAddTable
            // 
            resources.ApplyResources(this.btnAddTable, "btnAddTable");
            this.btnAddTable.BorderRadius = 20;
            this.btnAddTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.btnAddTable.ForeColor = System.Drawing.Color.Black;
            this.btnAddTable.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTable.Image")));
            this.btnAddTable.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddTable.Name = "btnAddTable";
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
            resources.ApplyResources(this.btnEditTable, "btnEditTable");
            this.btnEditTable.ForeColor = System.Drawing.Color.Black;
            this.btnEditTable.Image = ((System.Drawing.Image)(resources.GetObject("btnEditTable.Image")));
            this.btnEditTable.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEditTable.Name = "btnEditTable";
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
            resources.ApplyResources(this.btnDeleteAllTable, "btnDeleteAllTable");
            this.btnDeleteAllTable.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAllTable.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllTable.Image")));
            this.btnDeleteAllTable.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteAllTable.Name = "btnDeleteAllTable";
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
            resources.ApplyResources(this.btnDeleteTable, "btnDeleteTable");
            this.btnDeleteTable.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteTable.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTable.Image")));
            this.btnDeleteTable.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteTable.Name = "btnDeleteTable";
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
            resources.ApplyResources(this.btnTableDeleted, "btnTableDeleted");
            this.btnTableDeleted.ForeColor = System.Drawing.Color.Black;
            this.btnTableDeleted.Image = ((System.Drawing.Image)(resources.GetObject("btnTableDeleted.Image")));
            this.btnTableDeleted.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTableDeleted.Name = "btnTableDeleted";
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
            resources.ApplyResources(this.btnSearchTable, "btnSearchTable");
            this.btnSearchTable.ForeColor = System.Drawing.Color.White;
            this.btnSearchTable.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTable.Image")));
            this.btnSearchTable.Name = "btnSearchTable";
            this.btnSearchTable.Click += new System.EventHandler(this.btnSearchTable_Click);
            // 
            // frmTableManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.grpFunctionTable);
            this.Controls.Add(this.grpTableInfo);
            this.Controls.Add(this.btnSearchTable);
            this.Controls.Add(this.dtgvListTable);
            this.Controls.Add(this.txtSearchTable);
            this.Controls.Add(this.cbFillTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSortTable);
            this.Controls.Add(this.label1);
            this.Name = "frmTableManagement";
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