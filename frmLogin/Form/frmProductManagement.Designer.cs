
namespace frmLogin
{
    partial class frmProductManagement
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
            this.lvwListProducts = new System.Windows.Forms.ListView();
            this.colIDProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProductType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescribe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbStyleView = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.cbArrage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwListProducts
            // 
            this.lvwListProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIDProduct,
            this.colProductName,
            this.colProductType,
            this.colPrice,
            this.colQuantity,
            this.colDescribe,
            this.colStatus});
            this.lvwListProducts.HideSelection = false;
            this.lvwListProducts.Location = new System.Drawing.Point(12, 87);
            this.lvwListProducts.Name = "lvwListProducts";
            this.lvwListProducts.Size = new System.Drawing.Size(1006, 381);
            this.lvwListProducts.TabIndex = 0;
            this.lvwListProducts.UseCompatibleStateImageBehavior = false;
            // 
            // colIDProduct
            // 
            this.colIDProduct.Text = "Mã sản phẩm";
            // 
            // colProductName
            // 
            this.colProductName.Text = "Tên Sản Phẩm";
            // 
            // colProductType
            // 
            this.colProductType.Text = "Loại sản phẩm";
            // 
            // colPrice
            // 
            this.colPrice.Text = "Đơn giá";
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "Số lượng";
            // 
            // colDescribe
            // 
            this.colDescribe.Text = "Mô tả";
            // 
            // colStatus
            // 
            this.colStatus.Text = "Trạng thái";
            // 
            // cbStyleView
            // 
            this.cbStyleView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStyleView.FormattingEnabled = true;
            this.cbStyleView.Items.AddRange(new object[] {
            "LargeIcon",
            "Detail",
            "SmallIcon",
            "List",
            "Title"});
            this.cbStyleView.Location = new System.Drawing.Point(872, 55);
            this.cbStyleView.Name = "cbStyleView";
            this.cbStyleView.Size = new System.Drawing.Size(146, 26);
            this.cbStyleView.TabIndex = 1;
            this.cbStyleView.SelectedIndexChanged += new System.EventHandler(this.cbStyleView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(869, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Style View:";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.Location = new System.Drawing.Point(258, 51);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(294, 27);
            this.txtSearchProduct.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(579, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(739, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lọc:";
            // 
            // cbSort
            // 
            this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Tất cả",
            "Thức uống",
            "Trà sữa",
            "Thức ăn",
            "Kem",
            "Lẩu",
            "Cà phê"});
            this.cbSort.Location = new System.Drawing.Point(742, 55);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(108, 26);
            this.cbSort.TabIndex = 7;
            // 
            // cbArrage
            // 
            this.cbArrage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArrage.FormattingEnabled = true;
            this.cbArrage.Items.AddRange(new object[] {
            "Theo mã sản phẩm",
            "Theo tên sản phẩm",
            "Theo đơn giá",
            "Theo số lượng"});
            this.cbArrage.Location = new System.Drawing.Point(12, 52);
            this.cbArrage.Name = "cbArrage";
            this.cbArrage.Size = new System.Drawing.Size(199, 26);
            this.cbArrage.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sắp xếp:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1024, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 39);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1024, 211);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 39);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1024, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 39);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa ";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolsslTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1213, 26);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(184, 20);
            this.toolStripStatusLabel1.Text = "Admin: Nguyễn Tấn Phước";
            // 
            // toolsslTime
            // 
            this.toolsslTime.Name = "toolsslTime";
            this.toolsslTime.Size = new System.Drawing.Size(42, 20);
            this.toolsslTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 506);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbArrage);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStyleView);
            this.Controls.Add(this.lvwListProducts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmProductManagement";
            this.Text = "frmProductManagement";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwListProducts;
        private System.Windows.Forms.ComboBox cbStyleView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colIDProduct;
        private System.Windows.Forms.ColumnHeader colProductName;
        private System.Windows.Forms.ColumnHeader colProductType;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.ColumnHeader colDescribe;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.ComboBox cbArrage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolsslTime;
        private System.Windows.Forms.Timer timer1;
    }
}