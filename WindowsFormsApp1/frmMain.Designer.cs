namespace WindowsFormsApp1
{
    partial class frmMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Customer = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemCustomer = new System.Windows.Forms.TextBox();
            this.btnReloadCustomer = new System.Windows.Forms.Button();
            this.btnLuuCustomer = new System.Windows.Forms.Button();
            this.btnXoaCustomer = new System.Windows.Forms.Button();
            this.btnThemCustomer = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.home = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Product = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiemProduct = new System.Windows.Forms.TextBox();
            this.btnReloadProduct = new System.Windows.Forms.Button();
            this.btnLuuProduct = new System.Windows.Forms.Button();
            this.btnXoaProduct = new System.Windows.Forms.Button();
            this.btnThemProduct = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.Order = new System.Windows.Forms.TabPage();
            this.btnXoaOrderDetail = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiemOrderDetail = new System.Windows.Forms.TextBox();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiemOrder = new System.Windows.Forms.TextBox();
            this.btnXoaOrder = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.txtTriggerInfo = new System.Windows.Forms.TextBox();
            this.dgvRevenue = new System.Windows.Forms.DataGridView();
            this.dgvInStock = new System.Windows.Forms.DataGridView();
            this.chartPurchaseHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.home.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.Order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPurchaseHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // Customer
            // 
            this.Customer.Controls.Add(this.label1);
            this.Customer.Controls.Add(this.txtTimKiemCustomer);
            this.Customer.Controls.Add(this.btnReloadCustomer);
            this.Customer.Controls.Add(this.btnLuuCustomer);
            this.Customer.Controls.Add(this.btnXoaCustomer);
            this.Customer.Controls.Add(this.btnThemCustomer);
            this.Customer.Controls.Add(this.dgvCustomer);
            this.Customer.Location = new System.Drawing.Point(4, 22);
            this.Customer.Name = "Customer";
            this.Customer.Padding = new System.Windows.Forms.Padding(3);
            this.Customer.Size = new System.Drawing.Size(979, 551);
            this.Customer.TabIndex = 1;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tìm kiếm:";
            // 
            // txtTimKiemCustomer
            // 
            this.txtTimKiemCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemCustomer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTimKiemCustomer.Location = new System.Drawing.Point(314, 40);
            this.txtTimKiemCustomer.Name = "txtTimKiemCustomer";
            this.txtTimKiemCustomer.Size = new System.Drawing.Size(605, 26);
            this.txtTimKiemCustomer.TabIndex = 30;
            this.txtTimKiemCustomer.TextChanged += new System.EventHandler(this.txtTimKiemCustomer_TextChanged);
            // 
            // btnReloadCustomer
            // 
            this.btnReloadCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadCustomer.Location = new System.Drawing.Point(55, 379);
            this.btnReloadCustomer.Name = "btnReloadCustomer";
            this.btnReloadCustomer.Size = new System.Drawing.Size(125, 54);
            this.btnReloadCustomer.TabIndex = 29;
            this.btnReloadCustomer.Text = "Tải lại";
            this.btnReloadCustomer.UseVisualStyleBackColor = true;
            this.btnReloadCustomer.Click += new System.EventHandler(this.btnReloadCustomer_Click);
            // 
            // btnLuuCustomer
            // 
            this.btnLuuCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCustomer.Location = new System.Drawing.Point(55, 295);
            this.btnLuuCustomer.Name = "btnLuuCustomer";
            this.btnLuuCustomer.Size = new System.Drawing.Size(125, 54);
            this.btnLuuCustomer.TabIndex = 28;
            this.btnLuuCustomer.Text = "Lưu";
            this.btnLuuCustomer.UseVisualStyleBackColor = true;
            this.btnLuuCustomer.Click += new System.EventHandler(this.btnLuuCustomer_Click);
            // 
            // btnXoaCustomer
            // 
            this.btnXoaCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCustomer.Location = new System.Drawing.Point(55, 210);
            this.btnXoaCustomer.Name = "btnXoaCustomer";
            this.btnXoaCustomer.Size = new System.Drawing.Size(125, 54);
            this.btnXoaCustomer.TabIndex = 27;
            this.btnXoaCustomer.Text = "Xóa";
            this.btnXoaCustomer.UseVisualStyleBackColor = true;
            this.btnXoaCustomer.Click += new System.EventHandler(this.btnXoaCustomer_Click);
            // 
            // btnThemCustomer
            // 
            this.btnThemCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCustomer.Location = new System.Drawing.Point(55, 126);
            this.btnThemCustomer.Name = "btnThemCustomer";
            this.btnThemCustomer.Size = new System.Drawing.Size(125, 54);
            this.btnThemCustomer.TabIndex = 25;
            this.btnThemCustomer.Text = "Thêm";
            this.btnThemCustomer.UseVisualStyleBackColor = true;
            this.btnThemCustomer.Click += new System.EventHandler(this.btnThemCustomer_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(241, 93);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(678, 405);
            this.dgvCustomer.TabIndex = 24;
            // 
            // home
            // 
            this.home.Controls.Add(this.chartPurchaseHistory);
            this.home.Controls.Add(this.dgvInStock);
            this.home.Controls.Add(this.dgvRevenue);
            this.home.Controls.Add(this.txtTriggerInfo);
            this.home.Location = new System.Drawing.Point(4, 22);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(979, 551);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.home);
            this.tabControl.Controls.Add(this.Customer);
            this.tabControl.Controls.Add(this.Product);
            this.tabControl.Controls.Add(this.Order);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(987, 577);
            this.tabControl.TabIndex = 0;
            // 
            // Product
            // 
            this.Product.Controls.Add(this.label2);
            this.Product.Controls.Add(this.txtTimKiemProduct);
            this.Product.Controls.Add(this.btnReloadProduct);
            this.Product.Controls.Add(this.btnLuuProduct);
            this.Product.Controls.Add(this.btnXoaProduct);
            this.Product.Controls.Add(this.btnThemProduct);
            this.Product.Controls.Add(this.dgvProduct);
            this.Product.Location = new System.Drawing.Point(4, 22);
            this.Product.Name = "Product";
            this.Product.Padding = new System.Windows.Forms.Padding(3);
            this.Product.Size = new System.Drawing.Size(979, 604);
            this.Product.TabIndex = 2;
            this.Product.Text = "Product";
            this.Product.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tìm kiếm:";
            // 
            // txtTimKiemProduct
            // 
            this.txtTimKiemProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemProduct.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTimKiemProduct.Location = new System.Drawing.Point(314, 40);
            this.txtTimKiemProduct.Name = "txtTimKiemProduct";
            this.txtTimKiemProduct.Size = new System.Drawing.Size(605, 26);
            this.txtTimKiemProduct.TabIndex = 37;
            this.txtTimKiemProduct.TextChanged += new System.EventHandler(this.txtTimKiemProduct_TextChanged);
            // 
            // btnReloadProduct
            // 
            this.btnReloadProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadProduct.Location = new System.Drawing.Point(55, 379);
            this.btnReloadProduct.Name = "btnReloadProduct";
            this.btnReloadProduct.Size = new System.Drawing.Size(125, 54);
            this.btnReloadProduct.TabIndex = 36;
            this.btnReloadProduct.Text = "Tải lại";
            this.btnReloadProduct.UseVisualStyleBackColor = true;
            this.btnReloadProduct.Click += new System.EventHandler(this.btnReloadProduct_Click);
            // 
            // btnLuuProduct
            // 
            this.btnLuuProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuProduct.Location = new System.Drawing.Point(55, 295);
            this.btnLuuProduct.Name = "btnLuuProduct";
            this.btnLuuProduct.Size = new System.Drawing.Size(125, 54);
            this.btnLuuProduct.TabIndex = 35;
            this.btnLuuProduct.Text = "Lưu";
            this.btnLuuProduct.UseVisualStyleBackColor = true;
            this.btnLuuProduct.Click += new System.EventHandler(this.btnLuuProduct_Click);
            // 
            // btnXoaProduct
            // 
            this.btnXoaProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaProduct.Location = new System.Drawing.Point(55, 210);
            this.btnXoaProduct.Name = "btnXoaProduct";
            this.btnXoaProduct.Size = new System.Drawing.Size(125, 54);
            this.btnXoaProduct.TabIndex = 34;
            this.btnXoaProduct.Text = "Xóa";
            this.btnXoaProduct.UseVisualStyleBackColor = true;
            this.btnXoaProduct.Click += new System.EventHandler(this.btnXoaProduct_Click);
            // 
            // btnThemProduct
            // 
            this.btnThemProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemProduct.Location = new System.Drawing.Point(55, 126);
            this.btnThemProduct.Name = "btnThemProduct";
            this.btnThemProduct.Size = new System.Drawing.Size(125, 54);
            this.btnThemProduct.TabIndex = 33;
            this.btnThemProduct.Text = "Thêm";
            this.btnThemProduct.UseVisualStyleBackColor = true;
            this.btnThemProduct.Click += new System.EventHandler(this.btnThemProduct_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(241, 93);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(678, 405);
            this.dgvProduct.TabIndex = 32;
            // 
            // Order
            // 
            this.Order.Controls.Add(this.btnXoaOrderDetail);
            this.Order.Controls.Add(this.label4);
            this.Order.Controls.Add(this.txtTimKiemOrderDetail);
            this.Order.Controls.Add(this.dgvOrderDetail);
            this.Order.Controls.Add(this.label3);
            this.Order.Controls.Add(this.txtTimKiemOrder);
            this.Order.Controls.Add(this.btnXoaOrder);
            this.Order.Controls.Add(this.dgvOrder);
            this.Order.Location = new System.Drawing.Point(4, 22);
            this.Order.Name = "Order";
            this.Order.Padding = new System.Windows.Forms.Padding(3);
            this.Order.Size = new System.Drawing.Size(979, 604);
            this.Order.TabIndex = 3;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = true;
            // 
            // btnXoaOrderDetail
            // 
            this.btnXoaOrderDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaOrderDetail.Location = new System.Drawing.Point(55, 395);
            this.btnXoaOrderDetail.Name = "btnXoaOrderDetail";
            this.btnXoaOrderDetail.Size = new System.Drawing.Size(125, 54);
            this.btnXoaOrderDetail.TabIndex = 42;
            this.btnXoaOrderDetail.Text = "Xóa";
            this.btnXoaOrderDetail.UseVisualStyleBackColor = true;
            this.btnXoaOrderDetail.Click += new System.EventHandler(this.btnXoaOrderDetail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Chi tiết đơn:";
            // 
            // txtTimKiemOrderDetail
            // 
            this.txtTimKiemOrderDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemOrderDetail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTimKiemOrderDetail.Location = new System.Drawing.Point(314, 285);
            this.txtTimKiemOrderDetail.Name = "txtTimKiemOrderDetail";
            this.txtTimKiemOrderDetail.Size = new System.Drawing.Size(595, 26);
            this.txtTimKiemOrderDetail.TabIndex = 40;
            this.txtTimKiemOrderDetail.TextChanged += new System.EventHandler(this.txtTimKiemOrderDetail_TextChanged);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AllowUserToAddRows = false;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(241, 317);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.Size = new System.Drawing.Size(668, 211);
            this.dgvOrderDetail.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Đơn hàng:";
            // 
            // txtTimKiemOrder
            // 
            this.txtTimKiemOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemOrder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTimKiemOrder.Location = new System.Drawing.Point(314, 24);
            this.txtTimKiemOrder.Name = "txtTimKiemOrder";
            this.txtTimKiemOrder.Size = new System.Drawing.Size(595, 26);
            this.txtTimKiemOrder.TabIndex = 37;
            this.txtTimKiemOrder.TextChanged += new System.EventHandler(this.txtTimKiemOrder_TextChanged);
            // 
            // btnXoaOrder
            // 
            this.btnXoaOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaOrder.Location = new System.Drawing.Point(55, 126);
            this.btnXoaOrder.Name = "btnXoaOrder";
            this.btnXoaOrder.Size = new System.Drawing.Size(125, 54);
            this.btnXoaOrder.TabIndex = 34;
            this.btnXoaOrder.Text = "Xóa";
            this.btnXoaOrder.UseVisualStyleBackColor = true;
            this.btnXoaOrder.Click += new System.EventHandler(this.btnXoaOrder_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(241, 56);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(668, 211);
            this.dgvOrder.TabIndex = 32;
            // 
            // txtTriggerInfo
            // 
            this.txtTriggerInfo.Location = new System.Drawing.Point(22, 22);
            this.txtTriggerInfo.Multiline = true;
            this.txtTriggerInfo.Name = "txtTriggerInfo";
            this.txtTriggerInfo.Size = new System.Drawing.Size(542, 146);
            this.txtTriggerInfo.TabIndex = 0;
            // 
            // dgvRevenue
            // 
            this.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenue.Location = new System.Drawing.Point(634, 185);
            this.dgvRevenue.Name = "dgvRevenue";
            this.dgvRevenue.Size = new System.Drawing.Size(326, 152);
            this.dgvRevenue.TabIndex = 1;
            // 
            // dgvInStock
            // 
            this.dgvInStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInStock.Location = new System.Drawing.Point(22, 185);
            this.dgvInStock.Name = "dgvInStock";
            this.dgvInStock.Size = new System.Drawing.Size(606, 152);
            this.dgvInStock.TabIndex = 2;
            // 
            // chartPurchaseHistory
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPurchaseHistory.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPurchaseHistory.Legends.Add(legend1);
            this.chartPurchaseHistory.Location = new System.Drawing.Point(22, 343);
            this.chartPurchaseHistory.Name = "chartPurchaseHistory";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPurchaseHistory.Series.Add(series1);
            this.chartPurchaseHistory.Size = new System.Drawing.Size(938, 200);
            this.chartPurchaseHistory.TabIndex = 3;
            this.chartPurchaseHistory.Text = "chart1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 577);
            this.Controls.Add(this.tabControl);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý shop mỹ phẩm";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Customer.ResumeLayout(false);
            this.Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.home.ResumeLayout(false);
            this.home.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.Product.ResumeLayout(false);
            this.Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.Order.ResumeLayout(false);
            this.Order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPurchaseHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Customer;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Product;
        private System.Windows.Forms.TabPage Order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiemProduct;
        private System.Windows.Forms.Button btnReloadProduct;
        private System.Windows.Forms.Button btnLuuProduct;
        private System.Windows.Forms.Button btnXoaProduct;
        private System.Windows.Forms.Button btnThemProduct;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiemOrder;
        private System.Windows.Forms.Button btnXoaOrder;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiemCustomer;
        private System.Windows.Forms.Button btnReloadCustomer;
        private System.Windows.Forms.Button btnLuuCustomer;
        private System.Windows.Forms.Button btnXoaCustomer;
        private System.Windows.Forms.Button btnThemCustomer;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimKiemOrderDetail;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Button btnXoaOrderDetail;
        private System.Windows.Forms.TextBox txtTriggerInfo;
        private System.Windows.Forms.DataGridView dgvRevenue;
        private System.Windows.Forms.DataGridView dgvInStock;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPurchaseHistory;
    }
}

