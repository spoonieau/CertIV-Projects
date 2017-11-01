namespace ACMEIICS
{
    partial class frmProducts
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
            this.lblProducts = new System.Windows.Forms.Label();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.chProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductTypeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chYearlyPremium = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbProductMaintenance = new System.Windows.Forms.GroupBox();
            this.btnProductsReturn = new System.Windows.Forms.Button();
            this.gbUpdateProduct = new System.Windows.Forms.GroupBox();
            this.cbUpdateProductId = new System.Windows.Forms.ComboBox();
            this.txtUpdatePremium = new System.Windows.Forms.TextBox();
            this.lblUpdatePremium = new System.Windows.Forms.Label();
            this.cbUpdateProductType = new System.Windows.Forms.ComboBox();
            this.lblUpdateProductType = new System.Windows.Forms.Label();
            this.txtUpdateProduct = new System.Windows.Forms.TextBox();
            this.lblUpdateProductName = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.lblUpdateProduct = new System.Windows.Forms.Label();
            this.gbDeleteProduct = new System.Windows.Forms.GroupBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.cbDeleteProduct = new System.Windows.Forms.ComboBox();
            this.lblDeleteProduct = new System.Windows.Forms.Label();
            this.gbAddProduct = new System.Windows.Forms.GroupBox();
            this.txtPremium = new System.Windows.Forms.TextBox();
            this.lblAddPremium = new System.Windows.Forms.Label();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.lblAddProductType = new System.Windows.Forms.Label();
            this.txtAddProduct = new System.Windows.Forms.TextBox();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.cmsSearchProducts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbProductMaintenance.SuspendLayout();
            this.gbUpdateProduct.SuspendLayout();
            this.gbDeleteProduct.SuspendLayout();
            this.gbAddProduct.SuspendLayout();
            this.cmsSearchProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(12, 9);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(140, 13);
            this.lblProducts.TabIndex = 0;
            this.lblProducts.Text = "ACME IICS stored Products:";
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProductId,
            this.chProductTypeId,
            this.chProductName,
            this.chYearlyPremium});
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.GridLines = true;
            this.lvProducts.Location = new System.Drawing.Point(12, 25);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(417, 480);
            this.lvProducts.TabIndex = 1;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // chProductId
            // 
            this.chProductId.Text = "Product ID:";
            this.chProductId.Width = 104;
            // 
            // chProductTypeId
            // 
            this.chProductTypeId.Text = "Product Type:";
            this.chProductTypeId.Width = 104;
            // 
            // chProductName
            // 
            this.chProductName.Text = "Product Name:";
            this.chProductName.Width = 104;
            // 
            // chYearlyPremium
            // 
            this.chYearlyPremium.Text = "Yearly Premium:";
            this.chYearlyPremium.Width = 104;
            // 
            // gbProductMaintenance
            // 
            this.gbProductMaintenance.Controls.Add(this.btnProductsReturn);
            this.gbProductMaintenance.Controls.Add(this.gbUpdateProduct);
            this.gbProductMaintenance.Controls.Add(this.gbDeleteProduct);
            this.gbProductMaintenance.Controls.Add(this.gbAddProduct);
            this.gbProductMaintenance.Location = new System.Drawing.Point(435, 25);
            this.gbProductMaintenance.Name = "gbProductMaintenance";
            this.gbProductMaintenance.Size = new System.Drawing.Size(459, 480);
            this.gbProductMaintenance.TabIndex = 0;
            this.gbProductMaintenance.TabStop = false;
            this.gbProductMaintenance.Text = "IICS Product Maintenance";
            // 
            // btnProductsReturn
            // 
            this.btnProductsReturn.Image = global::ACMEIICS.Properties.Resources.smallArrowLeft;
            this.btnProductsReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductsReturn.Location = new System.Drawing.Point(385, 447);
            this.btnProductsReturn.Name = "btnProductsReturn";
            this.btnProductsReturn.Size = new System.Drawing.Size(64, 27);
            this.btnProductsReturn.TabIndex = 3;
            this.btnProductsReturn.Text = "Return";
            this.btnProductsReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductsReturn.UseVisualStyleBackColor = true;
            this.btnProductsReturn.Click += new System.EventHandler(this.btnProductsReturn_Click);
            // 
            // gbUpdateProduct
            // 
            this.gbUpdateProduct.Controls.Add(this.cbUpdateProductId);
            this.gbUpdateProduct.Controls.Add(this.txtUpdatePremium);
            this.gbUpdateProduct.Controls.Add(this.lblUpdatePremium);
            this.gbUpdateProduct.Controls.Add(this.cbUpdateProductType);
            this.gbUpdateProduct.Controls.Add(this.lblUpdateProductType);
            this.gbUpdateProduct.Controls.Add(this.txtUpdateProduct);
            this.gbUpdateProduct.Controls.Add(this.lblUpdateProductName);
            this.gbUpdateProduct.Controls.Add(this.btnUpdateProduct);
            this.gbUpdateProduct.Controls.Add(this.lblUpdateProduct);
            this.gbUpdateProduct.Location = new System.Drawing.Point(7, 107);
            this.gbUpdateProduct.Name = "gbUpdateProduct";
            this.gbUpdateProduct.Size = new System.Drawing.Size(442, 105);
            this.gbUpdateProduct.TabIndex = 2;
            this.gbUpdateProduct.TabStop = false;
            this.gbUpdateProduct.Text = "Update Product";
            // 
            // cbUpdateProductId
            // 
            this.cbUpdateProductId.FormattingEnabled = true;
            this.cbUpdateProductId.Location = new System.Drawing.Point(9, 33);
            this.cbUpdateProductId.Name = "cbUpdateProductId";
            this.cbUpdateProductId.Size = new System.Drawing.Size(100, 21);
            this.cbUpdateProductId.TabIndex = 1;
            this.cbUpdateProductId.SelectedIndexChanged += new System.EventHandler(this.cbUpdateProductId_SelectedIndexChanged);
            // 
            // txtUpdatePremium
            // 
            this.txtUpdatePremium.Location = new System.Drawing.Point(221, 77);
            this.txtUpdatePremium.Name = "txtUpdatePremium";
            this.txtUpdatePremium.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePremium.TabIndex = 7;
            // 
            // lblUpdatePremium
            // 
            this.lblUpdatePremium.AutoSize = true;
            this.lblUpdatePremium.Location = new System.Drawing.Point(219, 57);
            this.lblUpdatePremium.Name = "lblUpdatePremium";
            this.lblUpdatePremium.Size = new System.Drawing.Size(82, 13);
            this.lblUpdatePremium.TabIndex = 6;
            this.lblUpdatePremium.Text = "Yearly Premium:";
            // 
            // cbUpdateProductType
            // 
            this.cbUpdateProductType.FormattingEnabled = true;
            this.cbUpdateProductType.Location = new System.Drawing.Point(115, 77);
            this.cbUpdateProductType.Name = "cbUpdateProductType";
            this.cbUpdateProductType.Size = new System.Drawing.Size(100, 21);
            this.cbUpdateProductType.TabIndex = 5;
            // 
            // lblUpdateProductType
            // 
            this.lblUpdateProductType.AutoSize = true;
            this.lblUpdateProductType.Location = new System.Drawing.Point(115, 57);
            this.lblUpdateProductType.Name = "lblUpdateProductType";
            this.lblUpdateProductType.Size = new System.Drawing.Size(77, 13);
            this.lblUpdateProductType.TabIndex = 4;
            this.lblUpdateProductType.Text = "Product Type: ";
            // 
            // txtUpdateProduct
            // 
            this.txtUpdateProduct.Location = new System.Drawing.Point(9, 77);
            this.txtUpdateProduct.Name = "txtUpdateProduct";
            this.txtUpdateProduct.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateProduct.TabIndex = 3;
            // 
            // lblUpdateProductName
            // 
            this.lblUpdateProductName.AutoSize = true;
            this.lblUpdateProductName.Location = new System.Drawing.Point(7, 57);
            this.lblUpdateProductName.Name = "lblUpdateProductName";
            this.lblUpdateProductName.Size = new System.Drawing.Size(78, 13);
            this.lblUpdateProductName.TabIndex = 2;
            this.lblUpdateProductName.Text = "Product Name:";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.AutoSize = true;
            this.btnUpdateProduct.Image = global::ACMEIICS.Properties.Resources.Pen;
            this.btnUpdateProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateProduct.Location = new System.Drawing.Point(327, 70);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(109, 27);
            this.btnUpdateProduct.TabIndex = 8;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // lblUpdateProduct
            // 
            this.lblUpdateProduct.AutoSize = true;
            this.lblUpdateProduct.Location = new System.Drawing.Point(6, 16);
            this.lblUpdateProduct.Name = "lblUpdateProduct";
            this.lblUpdateProduct.Size = new System.Drawing.Size(175, 13);
            this.lblUpdateProduct.TabIndex = 0;
            this.lblUpdateProduct.Text = "Please select Product ID to update:";
            // 
            // gbDeleteProduct
            // 
            this.gbDeleteProduct.Controls.Add(this.btnDeleteProduct);
            this.gbDeleteProduct.Controls.Add(this.cbDeleteProduct);
            this.gbDeleteProduct.Controls.Add(this.lblDeleteProduct);
            this.gbDeleteProduct.Location = new System.Drawing.Point(6, 218);
            this.gbDeleteProduct.Name = "gbDeleteProduct";
            this.gbDeleteProduct.Size = new System.Drawing.Size(442, 45);
            this.gbDeleteProduct.TabIndex = 2;
            this.gbDeleteProduct.TabStop = false;
            this.gbDeleteProduct.Text = "Delete Product";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.AutoSize = true;
            this.btnDeleteProduct.Image = global::ACMEIICS.Properties.Resources.Forbidden;
            this.btnDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProduct.Location = new System.Drawing.Point(331, 13);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(105, 27);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // cbDeleteProduct
            // 
            this.cbDeleteProduct.FormattingEnabled = true;
            this.cbDeleteProduct.Location = new System.Drawing.Point(236, 16);
            this.cbDeleteProduct.Name = "cbDeleteProduct";
            this.cbDeleteProduct.Size = new System.Drawing.Size(57, 21);
            this.cbDeleteProduct.TabIndex = 1;
            // 
            // lblDeleteProduct
            // 
            this.lblDeleteProduct.AutoSize = true;
            this.lblDeleteProduct.Location = new System.Drawing.Point(7, 20);
            this.lblDeleteProduct.Name = "lblDeleteProduct";
            this.lblDeleteProduct.Size = new System.Drawing.Size(223, 13);
            this.lblDeleteProduct.TabIndex = 0;
            this.lblDeleteProduct.Text = "Please Select the ID of the Product to Delete:";
            // 
            // gbAddProduct
            // 
            this.gbAddProduct.Controls.Add(this.txtPremium);
            this.gbAddProduct.Controls.Add(this.lblAddPremium);
            this.gbAddProduct.Controls.Add(this.cbProductType);
            this.gbAddProduct.Controls.Add(this.lblAddProductType);
            this.gbAddProduct.Controls.Add(this.txtAddProduct);
            this.gbAddProduct.Controls.Add(this.lblAddProductName);
            this.gbAddProduct.Controls.Add(this.btnAddProduct);
            this.gbAddProduct.Controls.Add(this.lblAddProduct);
            this.gbAddProduct.Location = new System.Drawing.Point(7, 19);
            this.gbAddProduct.Name = "gbAddProduct";
            this.gbAddProduct.Size = new System.Drawing.Size(442, 82);
            this.gbAddProduct.TabIndex = 1;
            this.gbAddProduct.TabStop = false;
            this.gbAddProduct.Text = "Add Product";
            // 
            // txtPremium
            // 
            this.txtPremium.Location = new System.Drawing.Point(222, 48);
            this.txtPremium.Name = "txtPremium";
            this.txtPremium.Size = new System.Drawing.Size(100, 20);
            this.txtPremium.TabIndex = 6;
            // 
            // lblAddPremium
            // 
            this.lblAddPremium.AutoSize = true;
            this.lblAddPremium.Location = new System.Drawing.Point(219, 32);
            this.lblAddPremium.Name = "lblAddPremium";
            this.lblAddPremium.Size = new System.Drawing.Size(82, 13);
            this.lblAddPremium.TabIndex = 5;
            this.lblAddPremium.Text = "Yearly Premium:";
            // 
            // cbProductType
            // 
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Location = new System.Drawing.Point(115, 48);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(100, 21);
            this.cbProductType.TabIndex = 4;
            // 
            // lblAddProductType
            // 
            this.lblAddProductType.AutoSize = true;
            this.lblAddProductType.Location = new System.Drawing.Point(115, 33);
            this.lblAddProductType.Name = "lblAddProductType";
            this.lblAddProductType.Size = new System.Drawing.Size(77, 13);
            this.lblAddProductType.TabIndex = 3;
            this.lblAddProductType.Text = "Product Type: ";
            // 
            // txtAddProduct
            // 
            this.txtAddProduct.Location = new System.Drawing.Point(9, 49);
            this.txtAddProduct.Name = "txtAddProduct";
            this.txtAddProduct.Size = new System.Drawing.Size(100, 20);
            this.txtAddProduct.TabIndex = 2;
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Location = new System.Drawing.Point(6, 33);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(78, 13);
            this.lblAddProductName.TabIndex = 1;
            this.lblAddProductName.Text = "Product Name:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AutoSize = true;
            this.btnAddProduct.Image = global::ACMEIICS.Properties.Resources.CircledPlus;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(344, 48);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(92, 27);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Location = new System.Drawing.Point(6, 16);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(168, 13);
            this.lblAddProduct.TabIndex = 0;
            this.lblAddProduct.Text = "Please enter new Product  details:";
            // 
            // cmsSearchProducts
            // 
            this.cmsSearchProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.cmsSearchProducts.Name = "cmsSearchProducts";
            this.cmsSearchProducts.Size = new System.Drawing.Size(110, 48);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = global::ACMEIICS.Properties.Resources.smallMagnifyingGlass;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Image = global::ACMEIICS.Properties.Resources.smallArrowLeft;
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 512);
            this.ContextMenuStrip = this.cmsSearchProducts;
            this.Controls.Add(this.gbProductMaintenance);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.lblProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProducts";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Maintenance";
            this.gbProductMaintenance.ResumeLayout(false);
            this.gbUpdateProduct.ResumeLayout(false);
            this.gbUpdateProduct.PerformLayout();
            this.gbDeleteProduct.ResumeLayout(false);
            this.gbDeleteProduct.PerformLayout();
            this.gbAddProduct.ResumeLayout(false);
            this.gbAddProduct.PerformLayout();
            this.cmsSearchProducts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.GroupBox gbProductMaintenance;
        private System.Windows.Forms.GroupBox gbDeleteProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.ComboBox cbDeleteProduct;
        private System.Windows.Forms.Label lblDeleteProduct;
        private System.Windows.Forms.GroupBox gbAddProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.ColumnHeader chProductId;
        private System.Windows.Forms.ColumnHeader chProductTypeId;
        private System.Windows.Forms.ColumnHeader chProductName;
        private System.Windows.Forms.ColumnHeader chYearlyPremium;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.Label lblAddProductType;
        private System.Windows.Forms.TextBox txtAddProduct;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.Label lblAddPremium;
        private System.Windows.Forms.TextBox txtPremium;
        private System.Windows.Forms.GroupBox gbUpdateProduct;
        private System.Windows.Forms.ComboBox cbUpdateProductId;
        private System.Windows.Forms.TextBox txtUpdatePremium;
        private System.Windows.Forms.Label lblUpdatePremium;
        private System.Windows.Forms.ComboBox cbUpdateProductType;
        private System.Windows.Forms.Label lblUpdateProductType;
        private System.Windows.Forms.TextBox txtUpdateProduct;
        private System.Windows.Forms.Label lblUpdateProductName;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Label lblUpdateProduct;
        private System.Windows.Forms.ContextMenuStrip cmsSearchProducts;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.Button btnProductsReturn;
    }
}