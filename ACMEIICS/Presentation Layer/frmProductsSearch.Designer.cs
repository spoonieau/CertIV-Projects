namespace ACMEIICS
{
    partial class frmProductsSearch
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
            this.gbProductSearch = new System.Windows.Forms.GroupBox();
            this.btnProductSearchReturn = new System.Windows.Forms.Button();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.gbSearchPremium = new System.Windows.Forms.GroupBox();
            this.gbSearchProductType = new System.Windows.Forms.GroupBox();
            this.cbSerarchType = new System.Windows.Forms.ComboBox();
            this.lblSearchProducts = new System.Windows.Forms.Label();
            this.txtSearchPremium = new System.Windows.Forms.TextBox();
            this.gbProductSearch.SuspendLayout();
            this.gbSearchPremium.SuspendLayout();
            this.gbSearchProductType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProductSearch
            // 
            this.gbProductSearch.Controls.Add(this.btnProductSearchReturn);
            this.gbProductSearch.Controls.Add(this.btnProductSearch);
            this.gbProductSearch.Controls.Add(this.gbSearchPremium);
            this.gbProductSearch.Controls.Add(this.gbSearchProductType);
            this.gbProductSearch.Controls.Add(this.lblSearchProducts);
            this.gbProductSearch.Location = new System.Drawing.Point(13, 13);
            this.gbProductSearch.Name = "gbProductSearch";
            this.gbProductSearch.Size = new System.Drawing.Size(267, 190);
            this.gbProductSearch.TabIndex = 0;
            this.gbProductSearch.TabStop = false;
            this.gbProductSearch.Text = "Search Products";
            // 
            // btnProductSearchReturn
            // 
            this.btnProductSearchReturn.Image = global::ACMEIICS.Properties.Resources.smallArrowLeft;
            this.btnProductSearchReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductSearchReturn.Location = new System.Drawing.Point(190, 157);
            this.btnProductSearchReturn.Name = "btnProductSearchReturn";
            this.btnProductSearchReturn.Size = new System.Drawing.Size(64, 27);
            this.btnProductSearchReturn.TabIndex = 4;
            this.btnProductSearchReturn.Text = "Return";
            this.btnProductSearchReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductSearchReturn.UseVisualStyleBackColor = true;
            this.btnProductSearchReturn.Click += new System.EventHandler(this.btnProductSearchReturn_Click);
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Image = global::ACMEIICS.Properties.Resources.smallMagnifyingGlass;
            this.btnProductSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductSearch.Location = new System.Drawing.Point(109, 157);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(75, 27);
            this.btnProductSearch.TabIndex = 3;
            this.btnProductSearch.Text = "   Search";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // gbSearchPremium
            // 
            this.gbSearchPremium.Controls.Add(this.txtSearchPremium);
            this.gbSearchPremium.Location = new System.Drawing.Point(10, 97);
            this.gbSearchPremium.Name = "gbSearchPremium";
            this.gbSearchPremium.Size = new System.Drawing.Size(244, 54);
            this.gbSearchPremium.TabIndex = 2;
            this.gbSearchPremium.TabStop = false;
            this.gbSearchPremium.Text = "Search Via Yearly Premium:";
            // 
            // gbSearchProductType
            // 
            this.gbSearchProductType.Controls.Add(this.cbSerarchType);
            this.gbSearchProductType.Location = new System.Drawing.Point(10, 37);
            this.gbSearchProductType.Name = "gbSearchProductType";
            this.gbSearchProductType.Size = new System.Drawing.Size(244, 54);
            this.gbSearchProductType.TabIndex = 1;
            this.gbSearchProductType.TabStop = false;
            this.gbSearchProductType.Text = "Search Via Product Type:";
            // 
            // cbSerarchType
            // 
            this.cbSerarchType.FormattingEnabled = true;
            this.cbSerarchType.Location = new System.Drawing.Point(7, 20);
            this.cbSerarchType.Name = "cbSerarchType";
            this.cbSerarchType.Size = new System.Drawing.Size(231, 21);
            this.cbSerarchType.TabIndex = 0;
            // 
            // lblSearchProducts
            // 
            this.lblSearchProducts.AutoSize = true;
            this.lblSearchProducts.Location = new System.Drawing.Point(7, 20);
            this.lblSearchProducts.Name = "lblSearchProducts";
            this.lblSearchProducts.Size = new System.Drawing.Size(250, 13);
            this.lblSearchProducts.TabIndex = 0;
            this.lblSearchProducts.Text = "To Search for a Product Please enter details below:";
            // 
            // txtSearchPremium
            // 
            this.txtSearchPremium.Location = new System.Drawing.Point(7, 20);
            this.txtSearchPremium.Name = "txtSearchPremium";
            this.txtSearchPremium.Size = new System.Drawing.Size(231, 20);
            this.txtSearchPremium.TabIndex = 0;
            // 
            // frmProductsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 213);
            this.Controls.Add(this.gbProductSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductsSearch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Products";
            this.gbProductSearch.ResumeLayout(false);
            this.gbProductSearch.PerformLayout();
            this.gbSearchPremium.ResumeLayout(false);
            this.gbSearchPremium.PerformLayout();
            this.gbSearchProductType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProductSearch;
        private System.Windows.Forms.Label lblSearchProducts;
        private System.Windows.Forms.GroupBox gbSearchProductType;
        private System.Windows.Forms.ComboBox cbSerarchType;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.GroupBox gbSearchPremium;
        private System.Windows.Forms.Button btnProductSearchReturn;
        private System.Windows.Forms.TextBox txtSearchPremium;
    }
}