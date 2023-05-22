
namespace frmLogin
{
    partial class frmQuanLyAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyAdmin));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnTableManagement = new System.Windows.Forms.Button();
            this.btnBillManagement = new System.Windows.Forms.Button();
            this.btnCategoryManagement = new System.Windows.Forms.Button();
            this.btnEmployeeManager = new System.Windows.Forms.Button();
            this.btnAccountManagement = new System.Windows.Forms.Button();
            this.btnProducManagement = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbpRevenue = new System.Windows.Forms.TabPage();
            this.rpvRevenue = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStatisticalRevenue = new Guna.UI2.WinForms.Guna2Button();
            this.dtpRevenueEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpRevenueStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tpbProduct = new System.Windows.Forms.TabPage();
            this.chartProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFillProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnStatisticalProduct = new Guna.UI2.WinForms.Guna2Button();
            this.dtpProductEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpProductStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tbpBill = new System.Windows.Forms.TabPage();
            this.chartEmployeeCreateBill = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReportEmployCreateBill = new Guna.UI2.WinForms.Guna2Button();
            this.cbTypeStatisticalBill = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbtnStatisticalBill = new Guna.UI2.WinForms.Guna2Button();
            this.dtpBillEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpBillStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.tbpRevenue.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).BeginInit();
            this.panel2.SuspendLayout();
            this.tbpBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeeCreateBill)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnTableManagement);
            this.panelMenu.Controls.Add(this.btnBillManagement);
            this.panelMenu.Controls.Add(this.btnCategoryManagement);
            this.panelMenu.Controls.Add(this.btnEmployeeManager);
            this.panelMenu.Controls.Add(this.btnAccountManagement);
            this.panelMenu.Controls.Add(this.btnProducManagement);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Name = "panelMenu";
            // 
            // btnTableManagement
            // 
            resources.ApplyResources(this.btnTableManagement, "btnTableManagement");
            this.btnTableManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnTableManagement.FlatAppearance.BorderSize = 0;
            this.btnTableManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTableManagement.Name = "btnTableManagement";
            this.btnTableManagement.UseVisualStyleBackColor = false;
            this.btnTableManagement.Click += new System.EventHandler(this.btnTableManagement_Click);
            // 
            // btnBillManagement
            // 
            resources.ApplyResources(this.btnBillManagement, "btnBillManagement");
            this.btnBillManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnBillManagement.FlatAppearance.BorderSize = 0;
            this.btnBillManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBillManagement.Name = "btnBillManagement";
            this.btnBillManagement.UseVisualStyleBackColor = false;
            this.btnBillManagement.Click += new System.EventHandler(this.btnBillManagement_Click);
            // 
            // btnCategoryManagement
            // 
            resources.ApplyResources(this.btnCategoryManagement, "btnCategoryManagement");
            this.btnCategoryManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnCategoryManagement.FlatAppearance.BorderSize = 0;
            this.btnCategoryManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCategoryManagement.Name = "btnCategoryManagement";
            this.btnCategoryManagement.UseVisualStyleBackColor = false;
            this.btnCategoryManagement.Click += new System.EventHandler(this.btnCategoryManagement_Click);
            // 
            // btnEmployeeManager
            // 
            resources.ApplyResources(this.btnEmployeeManager, "btnEmployeeManager");
            this.btnEmployeeManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnEmployeeManager.FlatAppearance.BorderSize = 0;
            this.btnEmployeeManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmployeeManager.Name = "btnEmployeeManager";
            this.btnEmployeeManager.UseVisualStyleBackColor = false;
            this.btnEmployeeManager.Click += new System.EventHandler(this.btnEmployeeManager_Click);
            // 
            // btnAccountManagement
            // 
            resources.ApplyResources(this.btnAccountManagement, "btnAccountManagement");
            this.btnAccountManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnAccountManagement.FlatAppearance.BorderSize = 0;
            this.btnAccountManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAccountManagement.Name = "btnAccountManagement";
            this.btnAccountManagement.UseVisualStyleBackColor = false;
            this.btnAccountManagement.Click += new System.EventHandler(this.btnAccountManagement_Click);
            // 
            // btnProducManagement
            // 
            resources.ApplyResources(this.btnProducManagement, "btnProducManagement");
            this.btnProducManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnProducManagement.FlatAppearance.BorderSize = 0;
            this.btnProducManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducManagement.Name = "btnProducManagement";
            this.btnProducManagement.UseVisualStyleBackColor = false;
            this.btnProducManagement.Click += new System.EventHandler(this.btnProducManagement_Click);
            // 
            // panelLogo
            // 
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Name = "panelLogo";
            // 
            // pbLogo
            // 
            resources.ApplyResources(this.pbLogo, "pbLogo");
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // panelTitle
            // 
            resources.ApplyResources(this.panelTitle, "panelTitle");
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.btnExit);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Name = "panelTitle";
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            // 
            // panelMain
            // 
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Controls.Add(this.guna2TabControl1);
            this.panelMain.Name = "panelMain";
            // 
            // guna2TabControl1
            // 
            resources.ApplyResources(this.guna2TabControl1, "guna2TabControl1");
            this.guna2TabControl1.Controls.Add(this.tbpRevenue);
            this.guna2TabControl1.Controls.Add(this.tpbProduct);
            this.guna2TabControl1.Controls.Add(this.tbpBill);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tbpRevenue
            // 
            resources.ApplyResources(this.tbpRevenue, "tbpRevenue");
            this.tbpRevenue.Controls.Add(this.rpvRevenue);
            this.tbpRevenue.Controls.Add(this.panel1);
            this.tbpRevenue.Name = "tbpRevenue";
            this.tbpRevenue.UseVisualStyleBackColor = true;
            // 
            // rpvRevenue
            // 
            resources.ApplyResources(this.rpvRevenue, "rpvRevenue");
            this.rpvRevenue.Name = "rpvRevenue";
            this.rpvRevenue.ServerReport.BearerToken = null;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btnStatisticalRevenue);
            this.panel1.Controls.Add(this.dtpRevenueEnd);
            this.panel1.Controls.Add(this.dtpRevenueStart);
            this.panel1.Name = "panel1";
            // 
            // btnStatisticalRevenue
            // 
            resources.ApplyResources(this.btnStatisticalRevenue, "btnStatisticalRevenue");
            this.btnStatisticalRevenue.BorderRadius = 20;
            this.btnStatisticalRevenue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatisticalRevenue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatisticalRevenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatisticalRevenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatisticalRevenue.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnStatisticalRevenue.ForeColor = System.Drawing.Color.White;
            this.btnStatisticalRevenue.Name = "btnStatisticalRevenue";
            // 
            // dtpRevenueEnd
            // 
            resources.ApplyResources(this.dtpRevenueEnd, "dtpRevenueEnd");
            this.dtpRevenueEnd.Checked = true;
            this.dtpRevenueEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.dtpRevenueEnd.ForeColor = System.Drawing.Color.White;
            this.dtpRevenueEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRevenueEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpRevenueEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpRevenueEnd.Name = "dtpRevenueEnd";
            this.dtpRevenueEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpRevenueEnd.Value = new System.DateTime(2023, 4, 3, 16, 27, 38, 427);
            // 
            // dtpRevenueStart
            // 
            resources.ApplyResources(this.dtpRevenueStart, "dtpRevenueStart");
            this.dtpRevenueStart.Checked = true;
            this.dtpRevenueStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.dtpRevenueStart.ForeColor = System.Drawing.Color.White;
            this.dtpRevenueStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRevenueStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpRevenueStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpRevenueStart.Name = "dtpRevenueStart";
            this.dtpRevenueStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpRevenueStart.Value = new System.DateTime(2023, 4, 3, 16, 27, 38, 427);
            // 
            // tpbProduct
            // 
            resources.ApplyResources(this.tpbProduct, "tpbProduct");
            this.tpbProduct.Controls.Add(this.chartProduct);
            this.tpbProduct.Controls.Add(this.panel2);
            this.tpbProduct.Name = "tpbProduct";
            this.tpbProduct.UseVisualStyleBackColor = true;
            // 
            // chartProduct
            // 
            resources.ApplyResources(this.chartProduct, "chartProduct");
            chartArea1.Name = "ChartArea1";
            this.chartProduct.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProduct.Legends.Add(legend1);
            this.chartProduct.Name = "chartProduct";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            this.chartProduct.Series.Add(series1);
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            title1.Name = "Product";
            title1.Text = "SẢN PHẨM";
            this.chartProduct.Titles.Add(title1);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.cbCategory);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbFillProduct);
            this.panel2.Controls.Add(this.btnStatisticalProduct);
            this.panel2.Controls.Add(this.dtpProductEnd);
            this.panel2.Controls.Add(this.dtpProductStart);
            this.panel2.Name = "panel2";
            // 
            // cbCategory
            // 
            resources.ApplyResources(this.cbCategory, "cbCategory");
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategory.Items.AddRange(new object[] {
            resources.GetString("cbCategory.Items")});
            this.cbCategory.Name = "cbCategory";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbFillProduct
            // 
            resources.ApplyResources(this.cbFillProduct, "cbFillProduct");
            this.cbFillProduct.BackColor = System.Drawing.Color.Transparent;
            this.cbFillProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFillProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillProduct.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFillProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFillProduct.Items.AddRange(new object[] {
            resources.GetString("cbFillProduct.Items"),
            resources.GetString("cbFillProduct.Items1"),
            resources.GetString("cbFillProduct.Items2")});
            this.cbFillProduct.Name = "cbFillProduct";
            // 
            // btnStatisticalProduct
            // 
            resources.ApplyResources(this.btnStatisticalProduct, "btnStatisticalProduct");
            this.btnStatisticalProduct.BorderRadius = 10;
            this.btnStatisticalProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatisticalProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatisticalProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatisticalProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatisticalProduct.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnStatisticalProduct.ForeColor = System.Drawing.Color.White;
            this.btnStatisticalProduct.Name = "btnStatisticalProduct";
            // 
            // dtpProductEnd
            // 
            resources.ApplyResources(this.dtpProductEnd, "dtpProductEnd");
            this.dtpProductEnd.Checked = true;
            this.dtpProductEnd.ForeColor = System.Drawing.Color.White;
            this.dtpProductEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpProductEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpProductEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpProductEnd.Name = "dtpProductEnd";
            this.dtpProductEnd.Value = new System.DateTime(2023, 4, 3, 16, 27, 38, 427);
            // 
            // dtpProductStart
            // 
            resources.ApplyResources(this.dtpProductStart, "dtpProductStart");
            this.dtpProductStart.Checked = true;
            this.dtpProductStart.ForeColor = System.Drawing.Color.White;
            this.dtpProductStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpProductStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpProductStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpProductStart.Name = "dtpProductStart";
            this.dtpProductStart.Value = new System.DateTime(2023, 4, 3, 16, 27, 38, 427);
            // 
            // tbpBill
            // 
            resources.ApplyResources(this.tbpBill, "tbpBill");
            this.tbpBill.Controls.Add(this.chartEmployeeCreateBill);
            this.tbpBill.Controls.Add(this.panel3);
            this.tbpBill.Name = "tbpBill";
            this.tbpBill.UseVisualStyleBackColor = true;
            // 
            // chartEmployeeCreateBill
            // 
            resources.ApplyResources(this.chartEmployeeCreateBill, "chartEmployeeCreateBill");
            chartArea2.Name = "ChartArea1";
            this.chartEmployeeCreateBill.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartEmployeeCreateBill.Legends.Add(legend2);
            this.chartEmployeeCreateBill.Name = "chartEmployeeCreateBill";
            this.chartEmployeeCreateBill.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Số hóa đơn lập";
            this.chartEmployeeCreateBill.Series.Add(series2);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.btnReportEmployCreateBill);
            this.panel3.Controls.Add(this.cbTypeStatisticalBill);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnbtnStatisticalBill);
            this.panel3.Controls.Add(this.dtpBillEnd);
            this.panel3.Controls.Add(this.dtpBillStart);
            this.panel3.Name = "panel3";
            // 
            // btnReportEmployCreateBill
            // 
            resources.ApplyResources(this.btnReportEmployCreateBill, "btnReportEmployCreateBill");
            this.btnReportEmployCreateBill.BorderRadius = 10;
            this.btnReportEmployCreateBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReportEmployCreateBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReportEmployCreateBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReportEmployCreateBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReportEmployCreateBill.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReportEmployCreateBill.ForeColor = System.Drawing.Color.White;
            this.btnReportEmployCreateBill.Name = "btnReportEmployCreateBill";
            this.btnReportEmployCreateBill.Click += new System.EventHandler(this.btnReportEmployCreateBill_Click);
            // 
            // cbTypeStatisticalBill
            // 
            resources.ApplyResources(this.cbTypeStatisticalBill, "cbTypeStatisticalBill");
            this.cbTypeStatisticalBill.BackColor = System.Drawing.Color.Transparent;
            this.cbTypeStatisticalBill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeStatisticalBill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeStatisticalBill.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeStatisticalBill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeStatisticalBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTypeStatisticalBill.Items.AddRange(new object[] {
            resources.GetString("cbTypeStatisticalBill.Items"),
            resources.GetString("cbTypeStatisticalBill.Items1")});
            this.cbTypeStatisticalBill.Name = "cbTypeStatisticalBill";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnbtnStatisticalBill
            // 
            resources.ApplyResources(this.btnbtnStatisticalBill, "btnbtnStatisticalBill");
            this.btnbtnStatisticalBill.BorderRadius = 10;
            this.btnbtnStatisticalBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnbtnStatisticalBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnbtnStatisticalBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnbtnStatisticalBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnbtnStatisticalBill.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnbtnStatisticalBill.ForeColor = System.Drawing.Color.White;
            this.btnbtnStatisticalBill.Name = "btnbtnStatisticalBill";
            this.btnbtnStatisticalBill.Click += new System.EventHandler(this.btnbtnStatisticalBill_Click);
            // 
            // dtpBillEnd
            // 
            resources.ApplyResources(this.dtpBillEnd, "dtpBillEnd");
            this.dtpBillEnd.Checked = true;
            this.dtpBillEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dtpBillEnd.ForeColor = System.Drawing.Color.White;
            this.dtpBillEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBillEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBillEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBillEnd.Name = "dtpBillEnd";
            this.dtpBillEnd.Value = new System.DateTime(2023, 4, 3, 16, 27, 38, 427);
            // 
            // dtpBillStart
            // 
            resources.ApplyResources(this.dtpBillStart, "dtpBillStart");
            this.dtpBillStart.Checked = true;
            this.dtpBillStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dtpBillStart.ForeColor = System.Drawing.Color.White;
            this.dtpBillStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBillStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBillStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBillStart.Name = "dtpBillStart";
            this.dtpBillStart.Value = new System.DateTime(2023, 4, 3, 16, 27, 38, 427);
            // 
            // frmQuanLyAdmin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyAdmin_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.guna2TabControl1.ResumeLayout(false);
            this.tbpRevenue.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tpbProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tbpBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeeCreateBill)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnProducManagement;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAccountManagement;
        private System.Windows.Forms.Button btnCategoryManagement;
        private System.Windows.Forms.Button btnEmployeeManager;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnBillManagement;
        private System.Windows.Forms.Button btnTableManagement;
        private System.Windows.Forms.Panel panelMain;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tbpRevenue;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnStatisticalRevenue;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpRevenueEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpRevenueStart;
        private System.Windows.Forms.TabPage tpbProduct;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFillProduct;
        private Guna.UI2.WinForms.Guna2Button btnStatisticalProduct;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpProductEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpProductStart;
        private System.Windows.Forms.TabPage tbpBill;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmployeeCreateBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnbtnStatisticalBill;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBillEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBillStart;
        private Microsoft.Reporting.WinForms.ReportViewer rpvRevenue;
        private Guna.UI2.WinForms.Guna2Button btnReportEmployCreateBill;
        private Guna.UI2.WinForms.Guna2ComboBox cbTypeStatisticalBill;
    }
}