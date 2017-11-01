namespace ACMEIICS
{
    partial class frmSales
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
            this.lblSales = new System.Windows.Forms.Label();
            this.lvSales = new System.Windows.Forms.ListView();
            this.chSaleId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCustomerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCustomername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPayable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbAddSale = new System.Windows.Forms.GroupBox();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.dtpAddSale = new System.Windows.Forms.DateTimePicker();
            this.lblAddSaleStartDate = new System.Windows.Forms.Label();
            this.cbAddSalePayable = new System.Windows.Forms.ComboBox();
            this.lblAddSalePayable = new System.Windows.Forms.Label();
            this.cbAddSaleProduct = new System.Windows.Forms.ComboBox();
            this.lblAddSaleProduct = new System.Windows.Forms.Label();
            this.cbAddSaleCustomerID = new System.Windows.Forms.ComboBox();
            this.lblAddSaleCustomerID = new System.Windows.Forms.Label();
            this.lblAddSale = new System.Windows.Forms.Label();
            this.gbUpdateSale = new System.Windows.Forms.GroupBox();
            this.btnSaleUpdate = new System.Windows.Forms.Button();
            this.dtpUpdateSale = new System.Windows.Forms.DateTimePicker();
            this.lblUpdateSaleStartDate = new System.Windows.Forms.Label();
            this.cbUpdateSalePayable = new System.Windows.Forms.ComboBox();
            this.lblUpdateSalePayable = new System.Windows.Forms.Label();
            this.cbUpdateSaleProduct = new System.Windows.Forms.ComboBox();
            this.lblUpdateSaleProduct = new System.Windows.Forms.Label();
            this.cbUpdateSaleID = new System.Windows.Forms.ComboBox();
            this.lblUpdateSale = new System.Windows.Forms.Label();
            this.gbDeleteSale = new System.Windows.Forms.GroupBox();
            this.btnDeleteSale = new System.Windows.Forms.Button();
            this.cbDeleteSaleId = new System.Windows.Forms.ComboBox();
            this.lblDeleteSale = new System.Windows.Forms.Label();
            this.cmsSearchSale = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaleReturn = new System.Windows.Forms.Button();
            this.chPayableAmmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbAddSale.SuspendLayout();
            this.gbUpdateSale.SuspendLayout();
            this.gbDeleteSale.SuspendLayout();
            this.cmsSearchSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(12, 9);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(92, 13);
            this.lblSales.TabIndex = 1;
            this.lblSales.Text = "ACME IICS Sales:";
            // 
            // lvSales
            // 
            this.lvSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSaleId,
            this.chCustomerId,
            this.chCustomername,
            this.chProductId,
            this.chPayable,
            this.chPayableAmmount,
            this.chStartDate});
            this.lvSales.FullRowSelect = true;
            this.lvSales.GridLines = true;
            this.lvSales.Location = new System.Drawing.Point(12, 26);
            this.lvSales.Name = "lvSales";
            this.lvSales.Size = new System.Drawing.Size(418, 480);
            this.lvSales.TabIndex = 2;
            this.lvSales.UseCompatibleStateImageBehavior = false;
            this.lvSales.View = System.Windows.Forms.View.Details;
            // 
            // chSaleId
            // 
            this.chSaleId.Text = "Sale ID:";
            this.chSaleId.Width = 50;
            // 
            // chCustomerId
            // 
            this.chCustomerId.Text = "Customer ID:";
            this.chCustomerId.Width = 82;
            // 
            // chCustomername
            // 
            this.chCustomername.Text = "Customer";
            this.chCustomername.Width = 121;
            // 
            // chProductId
            // 
            this.chProductId.Text = "Product ID:";
            this.chProductId.Width = 160;
            // 
            // chPayable
            // 
            this.chPayable.Text = "Payable";
            this.chPayable.Width = 99;
            // 
            // chStartDate
            // 
            this.chStartDate.Text = "Start Date:";
            this.chStartDate.Width = 120;
            // 
            // gbAddSale
            // 
            this.gbAddSale.Controls.Add(this.btnAddSale);
            this.gbAddSale.Controls.Add(this.dtpAddSale);
            this.gbAddSale.Controls.Add(this.lblAddSaleStartDate);
            this.gbAddSale.Controls.Add(this.cbAddSalePayable);
            this.gbAddSale.Controls.Add(this.lblAddSalePayable);
            this.gbAddSale.Controls.Add(this.cbAddSaleProduct);
            this.gbAddSale.Controls.Add(this.lblAddSaleProduct);
            this.gbAddSale.Controls.Add(this.cbAddSaleCustomerID);
            this.gbAddSale.Controls.Add(this.lblAddSaleCustomerID);
            this.gbAddSale.Controls.Add(this.lblAddSale);
            this.gbAddSale.Location = new System.Drawing.Point(437, 26);
            this.gbAddSale.Name = "gbAddSale";
            this.gbAddSale.Size = new System.Drawing.Size(457, 159);
            this.gbAddSale.TabIndex = 3;
            this.gbAddSale.TabStop = false;
            this.gbAddSale.Text = "Add Sale";
            // 
            // btnAddSale
            // 
            this.btnAddSale.Image = global::ACMEIICS.Properties.Resources.CircledPlus;
            this.btnAddSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSale.Location = new System.Drawing.Point(375, 125);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(75, 27);
            this.btnAddSale.TabIndex = 9;
            this.btnAddSale.Text = "Add Sale";
            this.btnAddSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // dtpAddSale
            // 
            this.dtpAddSale.CustomFormat = "dd-MM-yyyy";
            this.dtpAddSale.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAddSale.Location = new System.Drawing.Point(268, 99);
            this.dtpAddSale.Name = "dtpAddSale";
            this.dtpAddSale.Size = new System.Drawing.Size(121, 20);
            this.dtpAddSale.TabIndex = 8;
            // 
            // lblAddSaleStartDate
            // 
            this.lblAddSaleStartDate.AutoSize = true;
            this.lblAddSaleStartDate.Location = new System.Drawing.Point(265, 80);
            this.lblAddSaleStartDate.Name = "lblAddSaleStartDate";
            this.lblAddSaleStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblAddSaleStartDate.TabIndex = 7;
            this.lblAddSaleStartDate.Text = "Start Date:";
            // 
            // cbAddSalePayable
            // 
            this.cbAddSalePayable.FormattingEnabled = true;
            this.cbAddSalePayable.Items.AddRange(new object[] {
            "Fortnightly",
            "Monthly",
            "Yearly"});
            this.cbAddSalePayable.Location = new System.Drawing.Point(140, 99);
            this.cbAddSalePayable.Name = "cbAddSalePayable";
            this.cbAddSalePayable.Size = new System.Drawing.Size(121, 21);
            this.cbAddSalePayable.TabIndex = 6;
            // 
            // lblAddSalePayable
            // 
            this.lblAddSalePayable.AutoSize = true;
            this.lblAddSalePayable.Location = new System.Drawing.Point(137, 81);
            this.lblAddSalePayable.Name = "lblAddSalePayable";
            this.lblAddSalePayable.Size = new System.Drawing.Size(48, 13);
            this.lblAddSalePayable.TabIndex = 5;
            this.lblAddSalePayable.Text = "Payable:";
            // 
            // cbAddSaleProduct
            // 
            this.cbAddSaleProduct.FormattingEnabled = true;
            this.cbAddSaleProduct.Location = new System.Drawing.Point(13, 99);
            this.cbAddSaleProduct.Name = "cbAddSaleProduct";
            this.cbAddSaleProduct.Size = new System.Drawing.Size(121, 21);
            this.cbAddSaleProduct.TabIndex = 4;
            // 
            // lblAddSaleProduct
            // 
            this.lblAddSaleProduct.AutoSize = true;
            this.lblAddSaleProduct.Location = new System.Drawing.Point(10, 83);
            this.lblAddSaleProduct.Name = "lblAddSaleProduct";
            this.lblAddSaleProduct.Size = new System.Drawing.Size(47, 13);
            this.lblAddSaleProduct.TabIndex = 3;
            this.lblAddSaleProduct.Text = "Product:";
            // 
            // cbAddSaleCustomerID
            // 
            this.cbAddSaleCustomerID.FormattingEnabled = true;
            this.cbAddSaleCustomerID.Location = new System.Drawing.Point(13, 54);
            this.cbAddSaleCustomerID.Name = "cbAddSaleCustomerID";
            this.cbAddSaleCustomerID.Size = new System.Drawing.Size(121, 21);
            this.cbAddSaleCustomerID.TabIndex = 2;
            // 
            // lblAddSaleCustomerID
            // 
            this.lblAddSaleCustomerID.AutoSize = true;
            this.lblAddSaleCustomerID.Location = new System.Drawing.Point(10, 37);
            this.lblAddSaleCustomerID.Name = "lblAddSaleCustomerID";
            this.lblAddSaleCustomerID.Size = new System.Drawing.Size(68, 13);
            this.lblAddSaleCustomerID.TabIndex = 1;
            this.lblAddSaleCustomerID.Text = "Customer ID:";
            // 
            // lblAddSale
            // 
            this.lblAddSale.AutoSize = true;
            this.lblAddSale.Location = new System.Drawing.Point(7, 20);
            this.lblAddSale.Name = "lblAddSale";
            this.lblAddSale.Size = new System.Drawing.Size(128, 13);
            this.lblAddSale.TabIndex = 0;
            this.lblAddSale.Text = "Please enter Sale Details:";
            // 
            // gbUpdateSale
            // 
            this.gbUpdateSale.Controls.Add(this.btnSaleUpdate);
            this.gbUpdateSale.Controls.Add(this.dtpUpdateSale);
            this.gbUpdateSale.Controls.Add(this.lblUpdateSaleStartDate);
            this.gbUpdateSale.Controls.Add(this.cbUpdateSalePayable);
            this.gbUpdateSale.Controls.Add(this.lblUpdateSalePayable);
            this.gbUpdateSale.Controls.Add(this.cbUpdateSaleProduct);
            this.gbUpdateSale.Controls.Add(this.lblUpdateSaleProduct);
            this.gbUpdateSale.Controls.Add(this.cbUpdateSaleID);
            this.gbUpdateSale.Controls.Add(this.lblUpdateSale);
            this.gbUpdateSale.Location = new System.Drawing.Point(437, 191);
            this.gbUpdateSale.Name = "gbUpdateSale";
            this.gbUpdateSale.Size = new System.Drawing.Size(457, 136);
            this.gbUpdateSale.TabIndex = 10;
            this.gbUpdateSale.TabStop = false;
            this.gbUpdateSale.Text = "Update Sale";
            // 
            // btnSaleUpdate
            // 
            this.btnSaleUpdate.Image = global::ACMEIICS.Properties.Resources.Pen;
            this.btnSaleUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaleUpdate.Location = new System.Drawing.Point(360, 103);
            this.btnSaleUpdate.Name = "btnSaleUpdate";
            this.btnSaleUpdate.Size = new System.Drawing.Size(91, 27);
            this.btnSaleUpdate.TabIndex = 9;
            this.btnSaleUpdate.Text = "Update Sale";
            this.btnSaleUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaleUpdate.UseVisualStyleBackColor = true;
            this.btnSaleUpdate.Click += new System.EventHandler(this.btnSaleUpdate_Click_Click);
            // 
            // dtpUpdateSale
            // 
            this.dtpUpdateSale.CustomFormat = "dd-MM-yyyy";
            this.dtpUpdateSale.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUpdateSale.Location = new System.Drawing.Point(264, 77);
            this.dtpUpdateSale.Name = "dtpUpdateSale";
            this.dtpUpdateSale.Size = new System.Drawing.Size(121, 20);
            this.dtpUpdateSale.TabIndex = 8;
            // 
            // lblUpdateSaleStartDate
            // 
            this.lblUpdateSaleStartDate.AutoSize = true;
            this.lblUpdateSaleStartDate.Location = new System.Drawing.Point(261, 61);
            this.lblUpdateSaleStartDate.Name = "lblUpdateSaleStartDate";
            this.lblUpdateSaleStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblUpdateSaleStartDate.TabIndex = 7;
            this.lblUpdateSaleStartDate.Text = "Start Date:";
            // 
            // cbUpdateSalePayable
            // 
            this.cbUpdateSalePayable.FormattingEnabled = true;
            this.cbUpdateSalePayable.Items.AddRange(new object[] {
            "Fortnightly",
            "Monthly",
            "Yearly"});
            this.cbUpdateSalePayable.Location = new System.Drawing.Point(137, 76);
            this.cbUpdateSalePayable.Name = "cbUpdateSalePayable";
            this.cbUpdateSalePayable.Size = new System.Drawing.Size(121, 21);
            this.cbUpdateSalePayable.TabIndex = 6;
            // 
            // lblUpdateSalePayable
            // 
            this.lblUpdateSalePayable.AutoSize = true;
            this.lblUpdateSalePayable.Location = new System.Drawing.Point(134, 60);
            this.lblUpdateSalePayable.Name = "lblUpdateSalePayable";
            this.lblUpdateSalePayable.Size = new System.Drawing.Size(48, 13);
            this.lblUpdateSalePayable.TabIndex = 5;
            this.lblUpdateSalePayable.Text = "Payable:";
            // 
            // cbUpdateSaleProduct
            // 
            this.cbUpdateSaleProduct.FormattingEnabled = true;
            this.cbUpdateSaleProduct.Location = new System.Drawing.Point(10, 76);
            this.cbUpdateSaleProduct.Name = "cbUpdateSaleProduct";
            this.cbUpdateSaleProduct.Size = new System.Drawing.Size(121, 21);
            this.cbUpdateSaleProduct.TabIndex = 4;
            // 
            // lblUpdateSaleProduct
            // 
            this.lblUpdateSaleProduct.AutoSize = true;
            this.lblUpdateSaleProduct.Location = new System.Drawing.Point(10, 60);
            this.lblUpdateSaleProduct.Name = "lblUpdateSaleProduct";
            this.lblUpdateSaleProduct.Size = new System.Drawing.Size(47, 13);
            this.lblUpdateSaleProduct.TabIndex = 3;
            this.lblUpdateSaleProduct.Text = "Product:";
            // 
            // cbUpdateSaleID
            // 
            this.cbUpdateSaleID.FormattingEnabled = true;
            this.cbUpdateSaleID.Location = new System.Drawing.Point(10, 36);
            this.cbUpdateSaleID.Name = "cbUpdateSaleID";
            this.cbUpdateSaleID.Size = new System.Drawing.Size(78, 21);
            this.cbUpdateSaleID.TabIndex = 2;
            this.cbUpdateSaleID.SelectedIndexChanged += new System.EventHandler(this.cbUpdateSaleID_SelectedIndexChanged);
            // 
            // lblUpdateSale
            // 
            this.lblUpdateSale.AutoSize = true;
            this.lblUpdateSale.Location = new System.Drawing.Point(7, 20);
            this.lblUpdateSale.Name = "lblUpdateSale";
            this.lblUpdateSale.Size = new System.Drawing.Size(157, 13);
            this.lblUpdateSale.TabIndex = 0;
            this.lblUpdateSale.Text = "Please enter Sale ID to Update:";
            // 
            // gbDeleteSale
            // 
            this.gbDeleteSale.Controls.Add(this.btnDeleteSale);
            this.gbDeleteSale.Controls.Add(this.cbDeleteSaleId);
            this.gbDeleteSale.Controls.Add(this.lblDeleteSale);
            this.gbDeleteSale.Location = new System.Drawing.Point(436, 333);
            this.gbDeleteSale.Name = "gbDeleteSale";
            this.gbDeleteSale.Size = new System.Drawing.Size(457, 45);
            this.gbDeleteSale.TabIndex = 11;
            this.gbDeleteSale.TabStop = false;
            this.gbDeleteSale.Text = "Delete Sale";
            // 
            // btnDeleteSale
            // 
            this.btnDeleteSale.Image = global::ACMEIICS.Properties.Resources.Forbidden;
            this.btnDeleteSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteSale.Location = new System.Drawing.Point(363, 11);
            this.btnDeleteSale.Name = "btnDeleteSale";
            this.btnDeleteSale.Size = new System.Drawing.Size(88, 27);
            this.btnDeleteSale.TabIndex = 11;
            this.btnDeleteSale.Text = "Delete Sale ";
            this.btnDeleteSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteSale.UseVisualStyleBackColor = true;
            this.btnDeleteSale.Click += new System.EventHandler(this.btnDeleteSale_Click);
            // 
            // cbDeleteSaleId
            // 
            this.cbDeleteSaleId.FormattingEnabled = true;
            this.cbDeleteSaleId.Location = new System.Drawing.Point(193, 17);
            this.cbDeleteSaleId.Name = "cbDeleteSaleId";
            this.cbDeleteSaleId.Size = new System.Drawing.Size(81, 21);
            this.cbDeleteSaleId.TabIndex = 10;
            // 
            // lblDeleteSale
            // 
            this.lblDeleteSale.AutoSize = true;
            this.lblDeleteSale.Location = new System.Drawing.Point(10, 20);
            this.lblDeleteSale.Name = "lblDeleteSale";
            this.lblDeleteSale.Size = new System.Drawing.Size(177, 13);
            this.lblDeleteSale.TabIndex = 0;
            this.lblDeleteSale.Text = "Please Select the Sale ID to Delete:";
            // 
            // cmsSearchSale
            // 
            this.cmsSearchSale.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.cmsSearchSale.Name = "cmsSearchSale";
            this.cmsSearchSale.Size = new System.Drawing.Size(110, 48);
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
            // btnSaleReturn
            // 
            this.btnSaleReturn.Image = global::ACMEIICS.Properties.Resources.smallArrowLeft;
            this.btnSaleReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaleReturn.Location = new System.Drawing.Point(830, 479);
            this.btnSaleReturn.Name = "btnSaleReturn";
            this.btnSaleReturn.Size = new System.Drawing.Size(64, 27);
            this.btnSaleReturn.TabIndex = 12;
            this.btnSaleReturn.Text = "Return";
            this.btnSaleReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaleReturn.UseVisualStyleBackColor = true;
            this.btnSaleReturn.Click += new System.EventHandler(this.btnSaleReturn_Click);
            // 
            // chPayableAmmount
            // 
            this.chPayableAmmount.Text = "Payable Ammount";
            this.chPayableAmmount.Width = 121;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 512);
            this.ContextMenuStrip = this.cmsSearchSale;
            this.Controls.Add(this.btnSaleReturn);
            this.Controls.Add(this.gbDeleteSale);
            this.Controls.Add(this.gbUpdateSale);
            this.Controls.Add(this.gbAddSale);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.lvSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSales";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Maintenance";
            this.gbAddSale.ResumeLayout(false);
            this.gbAddSale.PerformLayout();
            this.gbUpdateSale.ResumeLayout(false);
            this.gbUpdateSale.PerformLayout();
            this.gbDeleteSale.ResumeLayout(false);
            this.gbDeleteSale.PerformLayout();
            this.cmsSearchSale.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.ColumnHeader chSaleId;
        private System.Windows.Forms.ColumnHeader chCustomerId;
        private System.Windows.Forms.ColumnHeader chProductId;
        private System.Windows.Forms.ColumnHeader chPayable;
        private System.Windows.Forms.ColumnHeader chStartDate;
        private System.Windows.Forms.GroupBox gbAddSale;
        private System.Windows.Forms.Label lblAddSale;
        private System.Windows.Forms.Label lblAddSaleCustomerID;
        private System.Windows.Forms.ComboBox cbAddSaleCustomerID;
        private System.Windows.Forms.ComboBox cbAddSaleProduct;
        private System.Windows.Forms.Label lblAddSaleProduct;
        private System.Windows.Forms.DateTimePicker dtpAddSale;
        private System.Windows.Forms.Label lblAddSaleStartDate;
        private System.Windows.Forms.ComboBox cbAddSalePayable;
        private System.Windows.Forms.Label lblAddSalePayable;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.GroupBox gbUpdateSale;
        private System.Windows.Forms.Button btnSaleUpdate;
        private System.Windows.Forms.DateTimePicker dtpUpdateSale;
        private System.Windows.Forms.Label lblUpdateSaleStartDate;
        private System.Windows.Forms.ComboBox cbUpdateSalePayable;
        private System.Windows.Forms.Label lblUpdateSalePayable;
        private System.Windows.Forms.ComboBox cbUpdateSaleProduct;
        private System.Windows.Forms.Label lblUpdateSaleProduct;
        private System.Windows.Forms.ComboBox cbUpdateSaleID;
        private System.Windows.Forms.Label lblUpdateSale;
        private System.Windows.Forms.GroupBox gbDeleteSale;
        private System.Windows.Forms.Label lblDeleteSale;
        private System.Windows.Forms.Button btnDeleteSale;
        private System.Windows.Forms.ComboBox cbDeleteSaleId;
        private System.Windows.Forms.ContextMenuStrip cmsSearchSale;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.Button btnSaleReturn;
        private System.Windows.Forms.ColumnHeader chCustomername;
        public System.Windows.Forms.ListView lvSales;
        private System.Windows.Forms.ColumnHeader chPayableAmmount;
    }
}