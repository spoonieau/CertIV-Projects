namespace ACMEIICS
{
    partial class frmProductTypes
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
            this.lblProductType = new System.Windows.Forms.Label();
            this.lvProductTypes = new System.Windows.Forms.ListView();
            this.chProductTypeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbProductType = new System.Windows.Forms.GroupBox();
            this.btnProductTypeReturn = new System.Windows.Forms.Button();
            this.gbDeleteProductType = new System.Windows.Forms.GroupBox();
            this.btnDeleteProductType = new System.Windows.Forms.Button();
            this.cbDeleteProductType = new System.Windows.Forms.ComboBox();
            this.lblDeleteProductType = new System.Windows.Forms.Label();
            this.gbUpdateProductType = new System.Windows.Forms.GroupBox();
            this.btnUpdateProductType = new System.Windows.Forms.Button();
            this.txtUpdateProductType = new System.Windows.Forms.TextBox();
            this.lblUpdateProdType = new System.Windows.Forms.Label();
            this.cbUpdateProductType = new System.Windows.Forms.ComboBox();
            this.lblUpdateProductType = new System.Windows.Forms.Label();
            this.gbAddProductTypeCategorie = new System.Windows.Forms.GroupBox();
            this.cmProductType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddProductType = new System.Windows.Forms.Button();
            this.txtAddProductType = new System.Windows.Forms.TextBox();
            this.lblAddProductType = new System.Windows.Forms.Label();
            this.gbProductType.SuspendLayout();
            this.gbDeleteProductType.SuspendLayout();
            this.gbUpdateProductType.SuspendLayout();
            this.gbAddProductTypeCategorie.SuspendLayout();
            this.cmProductType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(12, 9);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(130, 13);
            this.lblProductType.TabIndex = 0;
            this.lblProductType.Text = "ACME IICS Product Type:";
            // 
            // lvProductTypes
            // 
            this.lvProductTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProductTypeId,
            this.chProductType});
            this.lvProductTypes.Location = new System.Drawing.Point(12, 25);
            this.lvProductTypes.Name = "lvProductTypes";
            this.lvProductTypes.Size = new System.Drawing.Size(218, 423);
            this.lvProductTypes.TabIndex = 1;
            this.lvProductTypes.UseCompatibleStateImageBehavior = false;
            this.lvProductTypes.View = System.Windows.Forms.View.Details;
            // 
            // chProductTypeId
            // 
            this.chProductTypeId.Text = "Product Type ID:";
            this.chProductTypeId.Width = 107;
            // 
            // chProductType
            // 
            this.chProductType.Text = "Product Type:";
            this.chProductType.Width = 107;
            // 
            // gbProductType
            // 
            this.gbProductType.Controls.Add(this.btnProductTypeReturn);
            this.gbProductType.Controls.Add(this.gbDeleteProductType);
            this.gbProductType.Controls.Add(this.gbUpdateProductType);
            this.gbProductType.Controls.Add(this.gbAddProductTypeCategorie);
            this.gbProductType.Location = new System.Drawing.Point(236, 26);
            this.gbProductType.Name = "gbProductType";
            this.gbProductType.Size = new System.Drawing.Size(512, 425);
            this.gbProductType.TabIndex = 3;
            this.gbProductType.TabStop = false;
            this.gbProductType.Text = "IICS Product Type Maintenance";
            // 
            // btnProductTypeReturn
            // 
            this.btnProductTypeReturn.Image = global::ACMEIICS.Properties.Resources.smallArrowLeft;
            this.btnProductTypeReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductTypeReturn.Location = new System.Drawing.Point(442, 392);
            this.btnProductTypeReturn.Name = "btnProductTypeReturn";
            this.btnProductTypeReturn.Size = new System.Drawing.Size(64, 27);
            this.btnProductTypeReturn.TabIndex = 4;
            this.btnProductTypeReturn.Text = "Return";
            this.btnProductTypeReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductTypeReturn.UseVisualStyleBackColor = true;
            this.btnProductTypeReturn.Click += new System.EventHandler(this.btnProductTypeReturn_Click);
            // 
            // gbDeleteProductType
            // 
            this.gbDeleteProductType.Controls.Add(this.btnDeleteProductType);
            this.gbDeleteProductType.Controls.Add(this.cbDeleteProductType);
            this.gbDeleteProductType.Controls.Add(this.lblDeleteProductType);
            this.gbDeleteProductType.Location = new System.Drawing.Point(7, 175);
            this.gbDeleteProductType.Name = "gbDeleteProductType";
            this.gbDeleteProductType.Size = new System.Drawing.Size(499, 45);
            this.gbDeleteProductType.TabIndex = 3;
            this.gbDeleteProductType.TabStop = false;
            this.gbDeleteProductType.Text = "Delete Product Type";
            // 
            // btnDeleteProductType
            // 
            this.btnDeleteProductType.AutoSize = true;
            this.btnDeleteProductType.Location = new System.Drawing.Point(378, 10);
            this.btnDeleteProductType.Name = "btnDeleteProductType";
            this.btnDeleteProductType.Size = new System.Drawing.Size(115, 23);
            this.btnDeleteProductType.TabIndex = 2;
            this.btnDeleteProductType.Text = "Delete Product Type";
            this.btnDeleteProductType.UseVisualStyleBackColor = true;
            this.btnDeleteProductType.Click += new System.EventHandler(this.btnDeleteProductType_Click);
            // 
            // cbDeleteProductType
            // 
            this.cbDeleteProductType.FormattingEnabled = true;
            this.cbDeleteProductType.Location = new System.Drawing.Point(244, 15);
            this.cbDeleteProductType.Name = "cbDeleteProductType";
            this.cbDeleteProductType.Size = new System.Drawing.Size(57, 21);
            this.cbDeleteProductType.TabIndex = 1;
            // 
            // lblDeleteProductType
            // 
            this.lblDeleteProductType.AutoSize = true;
            this.lblDeleteProductType.Location = new System.Drawing.Point(7, 20);
            this.lblDeleteProductType.Name = "lblDeleteProductType";
            this.lblDeleteProductType.Size = new System.Drawing.Size(231, 13);
            this.lblDeleteProductType.TabIndex = 0;
            this.lblDeleteProductType.Text = "Please Select the ID of the Categorie to Delete:";
            // 
            // gbUpdateProductType
            // 
            this.gbUpdateProductType.Controls.Add(this.btnUpdateProductType);
            this.gbUpdateProductType.Controls.Add(this.txtUpdateProductType);
            this.gbUpdateProductType.Controls.Add(this.lblUpdateProdType);
            this.gbUpdateProductType.Controls.Add(this.cbUpdateProductType);
            this.gbUpdateProductType.Controls.Add(this.lblUpdateProductType);
            this.gbUpdateProductType.Location = new System.Drawing.Point(7, 89);
            this.gbUpdateProductType.Name = "gbUpdateProductType";
            this.gbUpdateProductType.Size = new System.Drawing.Size(499, 79);
            this.gbUpdateProductType.TabIndex = 2;
            this.gbUpdateProductType.TabStop = false;
            this.gbUpdateProductType.Text = "Update Product Type";
            // 
            // btnUpdateProductType
            // 
            this.btnUpdateProductType.AutoSize = true;
            this.btnUpdateProductType.Image = global::ACMEIICS.Properties.Resources.Pen;
            this.btnUpdateProductType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateProductType.Location = new System.Drawing.Point(360, 42);
            this.btnUpdateProductType.Name = "btnUpdateProductType";
            this.btnUpdateProductType.Size = new System.Drawing.Size(133, 27);
            this.btnUpdateProductType.TabIndex = 4;
            this.btnUpdateProductType.Text = "Update Product Type";
            this.btnUpdateProductType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateProductType.UseVisualStyleBackColor = true;
            this.btnUpdateProductType.Click += new System.EventHandler(this.btnUpdateProductType_Click);
            // 
            // txtUpdateProductType
            // 
            this.txtUpdateProductType.Location = new System.Drawing.Point(9, 49);
            this.txtUpdateProductType.Name = "txtUpdateProductType";
            this.txtUpdateProductType.Size = new System.Drawing.Size(204, 20);
            this.txtUpdateProductType.TabIndex = 3;
            // 
            // lblUpdateProdType
            // 
            this.lblUpdateProdType.AutoSize = true;
            this.lblUpdateProdType.Location = new System.Drawing.Point(6, 34);
            this.lblUpdateProdType.Name = "lblUpdateProdType";
            this.lblUpdateProdType.Size = new System.Drawing.Size(143, 13);
            this.lblUpdateProdType.TabIndex = 2;
            this.lblUpdateProdType.Text = "Update Product Type below:";
            // 
            // cbUpdateProductType
            // 
            this.cbUpdateProductType.FormattingEnabled = true;
            this.cbUpdateProductType.Location = new System.Drawing.Point(225, 13);
            this.cbUpdateProductType.Name = "cbUpdateProductType";
            this.cbUpdateProductType.Size = new System.Drawing.Size(57, 21);
            this.cbUpdateProductType.TabIndex = 1;
            this.cbUpdateProductType.SelectedIndexChanged += new System.EventHandler(this.cbUpdateProductType_SelectedIndexChanged);
            // 
            // lblUpdateProductType
            // 
            this.lblUpdateProductType.AutoSize = true;
            this.lblUpdateProductType.Location = new System.Drawing.Point(6, 16);
            this.lblUpdateProductType.Name = "lblUpdateProductType";
            this.lblUpdateProductType.Size = new System.Drawing.Size(213, 13);
            this.lblUpdateProductType.TabIndex = 0;
            this.lblUpdateProductType.Text = "Please Select a Product Type ID to update:";
            // 
            // gbAddProductTypeCategorie
            // 
            this.gbAddProductTypeCategorie.ContextMenuStrip = this.cmProductType;
            this.gbAddProductTypeCategorie.Controls.Add(this.btnAddProductType);
            this.gbAddProductTypeCategorie.Controls.Add(this.txtAddProductType);
            this.gbAddProductTypeCategorie.Controls.Add(this.lblAddProductType);
            this.gbAddProductTypeCategorie.Location = new System.Drawing.Point(7, 20);
            this.gbAddProductTypeCategorie.Name = "gbAddProductTypeCategorie";
            this.gbAddProductTypeCategorie.Size = new System.Drawing.Size(499, 63);
            this.gbAddProductTypeCategorie.TabIndex = 1;
            this.gbAddProductTypeCategorie.TabStop = false;
            this.gbAddProductTypeCategorie.Text = "Add Categorie";
            // 
            // cmProductType
            // 
            this.cmProductType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem});
            this.cmProductType.Name = "cmProductType";
            this.cmProductType.Size = new System.Drawing.Size(110, 26);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Image = global::ACMEIICS.Properties.Resources.smallArrowLeft;
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // btnAddProductType
            // 
            this.btnAddProductType.AutoSize = true;
            this.btnAddProductType.Image = global::ACMEIICS.Properties.Resources.CircledPlus;
            this.btnAddProductType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProductType.Location = new System.Drawing.Point(374, 26);
            this.btnAddProductType.Name = "btnAddProductType";
            this.btnAddProductType.Size = new System.Drawing.Size(119, 27);
            this.btnAddProductType.TabIndex = 2;
            this.btnAddProductType.Text = "Add Product Type";
            this.btnAddProductType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProductType.UseVisualStyleBackColor = true;
            this.btnAddProductType.Click += new System.EventHandler(this.btnAddProductType_Click);
            // 
            // txtAddProductType
            // 
            this.txtAddProductType.Location = new System.Drawing.Point(9, 33);
            this.txtAddProductType.Name = "txtAddProductType";
            this.txtAddProductType.Size = new System.Drawing.Size(202, 20);
            this.txtAddProductType.TabIndex = 1;
            // 
            // lblAddProductType
            // 
            this.lblAddProductType.AutoSize = true;
            this.lblAddProductType.Location = new System.Drawing.Point(6, 16);
            this.lblAddProductType.Name = "lblAddProductType";
            this.lblAddProductType.Size = new System.Drawing.Size(221, 13);
            this.lblAddProductType.TabIndex = 0;
            this.lblAddProductType.Text = "Please enter a new Product Type to the IICS:";
            // 
            // frmProductTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 463);
            this.Controls.Add(this.gbProductType);
            this.Controls.Add(this.lvProductTypes);
            this.Controls.Add(this.lblProductType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductTypes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Type Maintenance";
            this.gbProductType.ResumeLayout(false);
            this.gbDeleteProductType.ResumeLayout(false);
            this.gbDeleteProductType.PerformLayout();
            this.gbUpdateProductType.ResumeLayout(false);
            this.gbUpdateProductType.PerformLayout();
            this.gbAddProductTypeCategorie.ResumeLayout(false);
            this.gbAddProductTypeCategorie.PerformLayout();
            this.cmProductType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ListView lvProductTypes;
        private System.Windows.Forms.GroupBox gbProductType;
        private System.Windows.Forms.GroupBox gbDeleteProductType;
        private System.Windows.Forms.Button btnDeleteProductType;
        private System.Windows.Forms.ComboBox cbDeleteProductType;
        private System.Windows.Forms.Label lblDeleteProductType;
        private System.Windows.Forms.GroupBox gbUpdateProductType;
        private System.Windows.Forms.Button btnUpdateProductType;
        private System.Windows.Forms.TextBox txtUpdateProductType;
        private System.Windows.Forms.Label lblUpdateProdType;
        private System.Windows.Forms.ComboBox cbUpdateProductType;
        private System.Windows.Forms.Label lblUpdateProductType;
        private System.Windows.Forms.GroupBox gbAddProductTypeCategorie;
        private System.Windows.Forms.Button btnAddProductType;
        private System.Windows.Forms.TextBox txtAddProductType;
        private System.Windows.Forms.Label lblAddProductType;
        private System.Windows.Forms.ColumnHeader chProductTypeId;
        private System.Windows.Forms.ColumnHeader chProductType;
        private System.Windows.Forms.ContextMenuStrip cmProductType;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.Button btnProductTypeReturn;
    }
}