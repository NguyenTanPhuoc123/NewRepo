
namespace frmLogin
{
    partial class frmSellManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellManagement));
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.cbLocationTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnExitFormSell = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstlblPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cbChangeTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.lstvMenuDish = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChangeTable = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToltalPrice = new System.Windows.Forms.Label();
            this.btnStoreManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelectDish = new Guna.UI2.WinForms.Guna2Button();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            resources.ApplyResources(this.flpTable, "flpTable");
            this.flpTable.Name = "flpTable";
            // 
            // cbLocationTable
            // 
            this.cbLocationTable.BackColor = System.Drawing.Color.White;
            this.cbLocationTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocationTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocationTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLocationTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.cbLocationTable, "cbLocationTable");
            this.cbLocationTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLocationTable.Name = "cbLocationTable";
            this.cbLocationTable.SelectedIndexChanged += new System.EventHandler(this.cbLocationTable_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnExitFormSell);
            this.panel1.Controls.Add(this.label2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnMinimize
            // 
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnSetting
            // 
            resources.ApplyResources(this.btnSetting, "btnSetting");
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnExitFormSell
            // 
            resources.ApplyResources(this.btnExitFormSell, "btnExitFormSell");
            this.btnExitFormSell.FlatAppearance.BorderSize = 0;
            this.btnExitFormSell.Name = "btnExitFormSell";
            this.btnExitFormSell.UseVisualStyleBackColor = true;
            this.btnExitFormSell.Click += new System.EventHandler(this.btnExitFormSell_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Name = "label2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstlblPosition,
            this.tsslblName,
            this.tsslblTime});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // tstlblPosition
            // 
            this.tstlblPosition.Name = "tstlblPosition";
            resources.ApplyResources(this.tstlblPosition, "tstlblPosition");
            // 
            // tsslblName
            // 
            this.tsslblName.Name = "tsslblName";
            resources.ApplyResources(this.tsslblName, "tsslblName");
            // 
            // tsslblTime
            // 
            this.tsslblTime.Margin = new System.Windows.Forms.Padding(900, 4, 0, 2);
            this.tsslblTime.Name = "tsslblTime";
            resources.ApplyResources(this.tsslblTime, "tsslblTime");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // cbChangeTable
            // 
            this.cbChangeTable.BackColor = System.Drawing.Color.White;
            this.cbChangeTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbChangeTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChangeTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChangeTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.cbChangeTable, "cbChangeTable");
            this.cbChangeTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbChangeTable.Name = "cbChangeTable";
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstvMenuDish
            // 
            this.lstvMenuDish.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstvMenuDish.FullRowSelect = true;
            this.lstvMenuDish.GridLines = true;
            this.lstvMenuDish.HideSelection = false;
            resources.ApplyResources(this.lstvMenuDish, "lstvMenuDish");
            this.lstvMenuDish.Name = "lstvMenuDish";
            this.lstvMenuDish.UseCompatibleStateImageBehavior = false;
            this.lstvMenuDish.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.BackColor = System.Drawing.Color.White;
            this.btnChangeTable.BorderRadius = 20;
            this.btnChangeTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangeTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btnChangeTable, "btnChangeTable");
            this.btnChangeTable.ForeColor = System.Drawing.Color.White;
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Click += new System.EventHandler(this.btnChangeTable_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblToltalPrice
            // 
            resources.ApplyResources(this.lblToltalPrice, "lblToltalPrice");
            this.lblToltalPrice.Name = "lblToltalPrice";
            // 
            // btnStoreManagement
            // 
            this.btnStoreManagement.BackColor = System.Drawing.Color.White;
            this.btnStoreManagement.BorderRadius = 20;
            this.btnStoreManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStoreManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStoreManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStoreManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStoreManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            resources.ApplyResources(this.btnStoreManagement, "btnStoreManagement");
            this.btnStoreManagement.ForeColor = System.Drawing.Color.White;
            this.btnStoreManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnStoreManagement.Image")));
            this.btnStoreManagement.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStoreManagement.Name = "btnStoreManagement";
            this.toolTip1.SetToolTip(this.btnStoreManagement, resources.GetString("btnStoreManagement.ToolTip"));
            this.btnStoreManagement.Click += new System.EventHandler(this.btnStoreManagement_Click);
            this.btnStoreManagement.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnStoreManagement_KeyDown);
            // 
            // btnSelectDish
            // 
            this.btnSelectDish.BackColor = System.Drawing.Color.White;
            this.btnSelectDish.BorderRadius = 10;
            this.btnSelectDish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectDish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectDish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectDish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectDish.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.btnSelectDish, "btnSelectDish");
            this.btnSelectDish.ForeColor = System.Drawing.Color.White;
            this.btnSelectDish.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectDish.Image")));
            this.btnSelectDish.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSelectDish.Name = "btnSelectDish";
            this.toolTip1.SetToolTip(this.btnSelectDish, resources.GetString("btnSelectDish.ToolTip"));
            this.btnSelectDish.Click += new System.EventHandler(this.btnSelectDish_Click);
            this.btnSelectDish.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSelectDish_KeyDown);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.White;
            this.btnPay.BorderRadius = 10;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.btnPay, "btnPay");
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPay.Name = "btnPay";
            this.toolTip1.SetToolTip(this.btnPay, resources.GetString("btnPay.ToolTip"));
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            this.btnPay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPay_KeyDown);
            // 
            // frmSellManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExitFormSell;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.lblToltalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeTable);
            this.Controls.Add(this.lstvMenuDish);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbChangeTable);
            this.Controls.Add(this.btnStoreManagement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbLocationTable);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSelectDish);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.btnPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSellManagement";
            this.Load += new System.EventHandler(this.frmSellManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSelectDish;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private Guna.UI2.WinForms.Guna2ComboBox cbLocationTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tstlblPosition;
        private System.Windows.Forms.ToolStripStatusLabel tsslblName;
        private System.Windows.Forms.ToolStripStatusLabel tsslblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnStoreManagement;
        private System.Windows.Forms.Button btnExitFormSell;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnSetting;
        private Guna.UI2.WinForms.Guna2ComboBox cbChangeTable;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.ListView lstvMenuDish;
        private Guna.UI2.WinForms.Guna2Button btnChangeTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToltalPrice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}