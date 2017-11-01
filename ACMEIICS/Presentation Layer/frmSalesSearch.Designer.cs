namespace ACMEIICS
{
    partial class frmSalesSearch
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
            this.gbSaleSearch = new System.Windows.Forms.GroupBox();
            this.btnSalesSearchReturn = new System.Windows.Forms.Button();
            this.btnSaleSearch = new System.Windows.Forms.Button();
            this.gbSearchDOP = new System.Windows.Forms.GroupBox();
            this.dtpSearchDOP = new System.Windows.Forms.DateTimePicker();
            this.lblSearchSales = new System.Windows.Forms.Label();
            this.gbSearchSaleName = new System.Windows.Forms.GroupBox();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.lblSearchLastName = new System.Windows.Forms.Label();
            this.lblSearchFirstName = new System.Windows.Forms.Label();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.gbSaleSearch.SuspendLayout();
            this.gbSearchDOP.SuspendLayout();
            this.gbSearchSaleName.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSaleSearch
            // 
            this.gbSaleSearch.Controls.Add(this.btnSalesSearchReturn);
            this.gbSaleSearch.Controls.Add(this.btnSaleSearch);
            this.gbSaleSearch.Controls.Add(this.gbSearchDOP);
            this.gbSaleSearch.Controls.Add(this.lblSearchSales);
            this.gbSaleSearch.Controls.Add(this.gbSearchSaleName);
            this.gbSaleSearch.Location = new System.Drawing.Point(12, 10);
            this.gbSaleSearch.Name = "gbSaleSearch";
            this.gbSaleSearch.Size = new System.Drawing.Size(269, 229);
            this.gbSaleSearch.TabIndex = 3;
            this.gbSaleSearch.TabStop = false;
            this.gbSaleSearch.Text = "Search Sales";
            // 
            // btnSalesSearchReturn
            // 
            this.btnSalesSearchReturn.Image = global::ACMEIICS.Properties.Resources.smallArrowLeft;
            this.btnSalesSearchReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesSearchReturn.Location = new System.Drawing.Point(191, 196);
            this.btnSalesSearchReturn.Name = "btnSalesSearchReturn";
            this.btnSalesSearchReturn.Size = new System.Drawing.Size(64, 27);
            this.btnSalesSearchReturn.TabIndex = 8;
            this.btnSalesSearchReturn.Text = "Return";
            this.btnSalesSearchReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalesSearchReturn.UseVisualStyleBackColor = true;
            this.btnSalesSearchReturn.Click += new System.EventHandler(this.btnSalesSearchReturn_Click);
            // 
            // btnSaleSearch
            // 
            this.btnSaleSearch.Image = global::ACMEIICS.Properties.Resources.smallMagnifyingGlass;
            this.btnSaleSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaleSearch.Location = new System.Drawing.Point(110, 196);
            this.btnSaleSearch.Name = "btnSaleSearch";
            this.btnSaleSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSaleSearch.TabIndex = 7;
            this.btnSaleSearch.Text = "   Search";
            this.btnSaleSearch.UseVisualStyleBackColor = true;
            this.btnSaleSearch.Click += new System.EventHandler(this.btnSaleSearch_Click);
            // 
            // gbSearchDOP
            // 
            this.gbSearchDOP.Controls.Add(this.dtpSearchDOP);
            this.gbSearchDOP.Location = new System.Drawing.Point(10, 148);
            this.gbSearchDOP.Name = "gbSearchDOP";
            this.gbSearchDOP.Size = new System.Drawing.Size(245, 45);
            this.gbSearchDOP.TabIndex = 6;
            this.gbSearchDOP.TabStop = false;
            this.gbSearchDOP.Text = "Search via purchase date";
            // 
            // dtpSearchDOP
            // 
            this.dtpSearchDOP.CustomFormat = "dd-MM-yyyy";
            this.dtpSearchDOP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchDOP.Location = new System.Drawing.Point(7, 20);
            this.dtpSearchDOP.Name = "dtpSearchDOP";
            this.dtpSearchDOP.Size = new System.Drawing.Size(200, 20);
            this.dtpSearchDOP.TabIndex = 0;
            this.dtpSearchDOP.ValueChanged += new System.EventHandler(this.dtpSearchDOP_ValueChanged);
            // 
            // lblSearchSales
            // 
            this.lblSearchSales.AutoSize = true;
            this.lblSearchSales.Location = new System.Drawing.Point(7, 20);
            this.lblSearchSales.Name = "lblSearchSales";
            this.lblSearchSales.Size = new System.Drawing.Size(212, 13);
            this.lblSearchSales.TabIndex = 0;
            this.lblSearchSales.Text = "To Search Sale, please enter details below:";
            // 
            // gbSearchSaleName
            // 
            this.gbSearchSaleName.Controls.Add(this.txtSearchLastName);
            this.gbSearchSaleName.Controls.Add(this.lblSearchLastName);
            this.gbSearchSaleName.Controls.Add(this.lblSearchFirstName);
            this.gbSearchSaleName.Controls.Add(this.txtSearchFirstName);
            this.gbSearchSaleName.Location = new System.Drawing.Point(10, 36);
            this.gbSearchSaleName.Name = "gbSearchSaleName";
            this.gbSearchSaleName.Size = new System.Drawing.Size(245, 105);
            this.gbSearchSaleName.TabIndex = 5;
            this.gbSearchSaleName.TabStop = false;
            this.gbSearchSaleName.Text = "Search via Customers Name";
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(6, 79);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(200, 20);
            this.txtSearchLastName.TabIndex = 4;
            // 
            // lblSearchLastName
            // 
            this.lblSearchLastName.AutoSize = true;
            this.lblSearchLastName.Location = new System.Drawing.Point(3, 62);
            this.lblSearchLastName.Name = "lblSearchLastName";
            this.lblSearchLastName.Size = new System.Drawing.Size(61, 13);
            this.lblSearchLastName.TabIndex = 3;
            this.lblSearchLastName.Text = "Last Name:";
            // 
            // lblSearchFirstName
            // 
            this.lblSearchFirstName.AutoSize = true;
            this.lblSearchFirstName.Location = new System.Drawing.Point(3, 18);
            this.lblSearchFirstName.Name = "lblSearchFirstName";
            this.lblSearchFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblSearchFirstName.TabIndex = 1;
            this.lblSearchFirstName.Text = "First Name:";
            // 
            // txtSearchFirstName
            // 
            this.txtSearchFirstName.Location = new System.Drawing.Point(6, 35);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtSearchFirstName.TabIndex = 2;
            // 
            // frmSalesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 249);
            this.Controls.Add(this.gbSaleSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalesSearch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Sales";
            this.gbSaleSearch.ResumeLayout(false);
            this.gbSaleSearch.PerformLayout();
            this.gbSearchDOP.ResumeLayout(false);
            this.gbSearchSaleName.ResumeLayout(false);
            this.gbSearchSaleName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSaleSearch;
        private System.Windows.Forms.Button btnSaleSearch;
        private System.Windows.Forms.GroupBox gbSearchDOP;
        private System.Windows.Forms.DateTimePicker dtpSearchDOP;
        private System.Windows.Forms.Label lblSearchSales;
        private System.Windows.Forms.GroupBox gbSearchSaleName;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.Label lblSearchLastName;
        private System.Windows.Forms.Label lblSearchFirstName;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.Button btnSalesSearchReturn;
    }
}