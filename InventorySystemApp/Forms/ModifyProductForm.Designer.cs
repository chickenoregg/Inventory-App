namespace InventorySystemApp.Forms
{
    partial class ModifyProductForm
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
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.btnCancelProduct = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewB = new System.Windows.Forms.DataGridView();
            this.dataGridViewA = new System.Windows.Forms.DataGridView();
            this.lblProducts = new System.Windows.Forms.Label();
            this.txtProductMin = new System.Windows.Forms.TextBox();
            this.txtProductMax = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductInventory = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductMin = new System.Windows.Forms.Label();
            this.lblProductMax = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(997, 16);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(100, 22);
            this.txtSearchProduct.TabIndex = 42;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // btnCancelProduct
            // 
            this.btnCancelProduct.Location = new System.Drawing.Point(928, 458);
            this.btnCancelProduct.Name = "btnCancelProduct";
            this.btnCancelProduct.Size = new System.Drawing.Size(75, 23);
            this.btnCancelProduct.TabIndex = 41;
            this.btnCancelProduct.Text = "Cancel";
            this.btnCancelProduct.UseVisualStyleBackColor = true;
            this.btnCancelProduct.Click += new System.EventHandler(this.btnCancelProduct_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Location = new System.Drawing.Point(836, 458);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(75, 23);
            this.btnSaveProduct.TabIndex = 40;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(1019, 426);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 39;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(1019, 206);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 38;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Parts Associated with this Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(941, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Search";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewB
            // 
            this.dataGridViewB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewB.Location = new System.Drawing.Point(568, 259);
            this.dataGridViewB.Name = "dataGridViewB";
            this.dataGridViewB.RowHeadersWidth = 51;
            this.dataGridViewB.RowTemplate.Height = 24;
            this.dataGridViewB.Size = new System.Drawing.Size(526, 150);
            this.dataGridViewB.TabIndex = 35;
            // 
            // dataGridViewA
            // 
            this.dataGridViewA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA.Location = new System.Drawing.Point(568, 50);
            this.dataGridViewA.Name = "dataGridViewA";
            this.dataGridViewA.RowHeadersWidth = 51;
            this.dataGridViewA.RowTemplate.Height = 24;
            this.dataGridViewA.Size = new System.Drawing.Size(526, 150);
            this.dataGridViewA.TabIndex = 34;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(565, 16);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(119, 16);
            this.lblProducts.TabIndex = 33;
            this.lblProducts.Text = "All candidate Parts";
            // 
            // txtProductMin
            // 
            this.txtProductMin.Location = new System.Drawing.Point(343, 226);
            this.txtProductMin.Name = "txtProductMin";
            this.txtProductMin.Size = new System.Drawing.Size(100, 22);
            this.txtProductMin.TabIndex = 24;
            this.txtProductMin.TextChanged += new System.EventHandler(this.txtProductMin_TextChanged);
            // 
            // txtProductMax
            // 
            this.txtProductMax.Location = new System.Drawing.Point(141, 223);
            this.txtProductMax.Name = "txtProductMax";
            this.txtProductMax.Size = new System.Drawing.Size(100, 22);
            this.txtProductMax.TabIndex = 27;
            this.txtProductMax.TextChanged += new System.EventHandler(this.txtProductMax_TextChanged);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(237, 167);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 22);
            this.txtProductPrice.TabIndex = 23;
            this.txtProductPrice.TextChanged += new System.EventHandler(this.txtProductPrice_TextChanged);
            // 
            // txtProductInventory
            // 
            this.txtProductInventory.Location = new System.Drawing.Point(237, 124);
            this.txtProductInventory.Name = "txtProductInventory";
            this.txtProductInventory.Size = new System.Drawing.Size(100, 22);
            this.txtProductInventory.TabIndex = 22;
            this.txtProductInventory.TextChanged += new System.EventHandler(this.txtProductInventory_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(237, 82);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 22);
            this.txtProductName.TabIndex = 21;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(237, 50);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(100, 22);
            this.txtProductID.TabIndex = 32;
            // 
            // lblProductMin
            // 
            this.lblProductMin.AutoSize = true;
            this.lblProductMin.Location = new System.Drawing.Point(276, 229);
            this.lblProductMin.Name = "lblProductMin";
            this.lblProductMin.Size = new System.Drawing.Size(28, 16);
            this.lblProductMin.TabIndex = 25;
            this.lblProductMin.Text = "Min";
            // 
            // lblProductMax
            // 
            this.lblProductMax.AutoSize = true;
            this.lblProductMax.Location = new System.Drawing.Point(79, 223);
            this.lblProductMax.Name = "lblProductMax";
            this.lblProductMax.Size = new System.Drawing.Size(32, 16);
            this.lblProductMax.TabIndex = 26;
            this.lblProductMax.Text = "Max";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(79, 173);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(68, 16);
            this.lblProductPrice.TabIndex = 28;
            this.lblProductPrice.Text = "Part / Cost";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(79, 130);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(61, 16);
            this.lblInventory.TabIndex = 29;
            this.lblInventory.Text = "Inventory";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(79, 88);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(44, 16);
            this.lblProductName.TabIndex = 30;
            this.lblProductName.Text = "Name";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(79, 50);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(20, 16);
            this.lblProductID.TabIndex = 31;
            this.lblProductID.Text = "ID";
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 493);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.btnCancelProduct);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewB);
            this.Controls.Add(this.dataGridViewA);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.txtProductMin);
            this.Controls.Add(this.txtProductMax);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductInventory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductMin);
            this.Controls.Add(this.lblProductMax);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductID);
            this.Name = "ModifyProductForm";
            this.Text = "ModifyProductForm";
            this.Load += new System.EventHandler(this.ModifyProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnCancelProduct;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewB;
        private System.Windows.Forms.DataGridView dataGridViewA;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.TextBox txtProductMin;
        private System.Windows.Forms.TextBox txtProductMax;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductInventory;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductMin;
        private System.Windows.Forms.Label lblProductMax;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
    }
}