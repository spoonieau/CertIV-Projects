namespace ACMEIICS
{
    partial class frmCustomerSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbCustomerSearch = new System.Windows.Forms.GroupBox();
            this.btnCustomerSearchReturn = new System.Windows.Forms.Button();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.gbSearchDOB = new System.Windows.Forms.GroupBox();
            this.dtpCustomerSearch = new System.Windows.Forms.DateTimePicker();
            this.lblSearchCustomers = new System.Windows.Forms.Label();
            this.gbSearchName = new System.Windows.Forms.GroupBox();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.lblSearchLastName = new System.Windows.Forms.Label();
            this.lblSearchFirstName = new System.Windows.Forms.Label();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.gbCustomerSearch.SuspendLayout();
            this.gbSearchDOB.SuspendLayout();
            this.gbSearchName.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // gbCustomerSearch
            // 
            this.gbCustomerSearch.Controls.Add(this.btnCustomerSearchReturn);
            this.gbCustomerSearch.Controls.Add(this.btnCustomerSearch);
            this.gbCustomerSearch.Controls.Add(this.gbSearchDOB);
            this.gbCustomerSearch.Controls.Add(this.lblSearchCustomers);
            this.gbCustomerSearch.Controls.Add(this.gbSearchName);
            this.gbCustomerSearch.Location = new System.Drawing.Point(12, 9);
            this.gbCustomerSearch.Name = "gbCustomerSearch";
            this.gbCustomerSearch.Size = new System.Drawing.Size(268, 229);
            this.gbCustomerSearch.TabIndex = 2;
            this.gbCustomerSearch.TabStop = false;
            this.gbCustomerSearch.Text = "Search Customers";
            // 
            // btnCustomerSearchReturn
            // 
            this.btnCustomerSearchReturn.Image = global::ACMEIICS.Properties.Resources.smallArrowLeft;
            this.btnCustomerSearchReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerSearchReturn.Location = new System.Drawing.Point(191, 196);
            this.btnCustomerSearchReturn.Name = "btnCustomerSearchReturn";
            this.btnCustomerSearchReturn.Size = new System.Drawing.Size(64, 27);
            this.btnCustomerSearchReturn.TabIndex = 8;
            this.btnCustomerSearchReturn.Text = "Return";
            this.btnCustomerSearchReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerSearchReturn.UseVisualStyleBackColor = true;
            this.btnCustomerSearchReturn.Click += new System.EventHandler(this.btnCustomerSearchReturn_Click);
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Image = global::ACMEIICS.Properties.Resources.smallMagnifyingGlass;
            this.btnCustomerSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerSearch.Location = new System.Drawing.Point(110, 196);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(75, 27);
            this.btnCustomerSearch.TabIndex = 7;
            this.btnCustomerSearch.Text = "   Search";
            this.btnCustomerSearch.UseVisualStyleBackColor = true;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // gbSearchDOB
            // 
            this.gbSearchDOB.Controls.Add(this.dtpCustomerSearch);
            this.gbSearchDOB.Location = new System.Drawing.Point(10, 148);
            this.gbSearchDOB.Name = "gbSearchDOB";
            this.gbSearchDOB.Size = new System.Drawing.Size(245, 45);
            this.gbSearchDOB.TabIndex = 6;
            this.gbSearchDOB.TabStop = false;
            this.gbSearchDOB.Text = "Search via Birth Date";
            // 
            // dtpCustomerSearch
            // 
            this.dtpCustomerSearch.CustomFormat = "dd-MM-yyyy";
            this.dtpCustomerSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCustomerSearch.Location = new System.Drawing.Point(7, 20);
            this.dtpCustomerSearch.Name = "dtpCustomerSearch";
            this.dtpCustomerSearch.Size = new System.Drawing.Size(200, 20);
            this.dtpCustomerSearch.TabIndex = 0;
            this.dtpCustomerSearch.ValueChanged += new System.EventHandler(this.dtpCustomerSearch_ValueChanged);
            // 
            // lblSearchCustomers
            // 
            this.lblSearchCustomers.AutoSize = true;
            this.lblSearchCustomers.Location = new System.Drawing.Point(7, 20);
            this.lblSearchCustomers.Name = "lblSearchCustomers";
            this.lblSearchCustomers.Size = new System.Drawing.Size(248, 13);
            this.lblSearchCustomers.TabIndex = 0;
            this.lblSearchCustomers.Text = "To Search for Customer Please enter details below:";
            // 
            // gbSearchName
            // 
            this.gbSearchName.Controls.Add(this.txtSearchLastName);
            this.gbSearchName.Controls.Add(this.lblSearchLastName);
            this.gbSearchName.Controls.Add(this.lblSearchFirstName);
            this.gbSearchName.Controls.Add(this.txtSearchFirstName);
            this.gbSearchName.Location = new System.Drawing.Point(10, 36);
            this.gbSearchName.Name = "gbSearchName";
            this.gbSearchName.Size = new System.Drawing.Size(245, 105);
            this.gbSearchName.TabIndex = 5;
            this.gbSearchName.TabStop = false;
            this.gbSearchName.Text = "Search via Customers Name";
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
            // frmCustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 249);
            this.Controls.Add(this.gbCustomerSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerSearch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Customers";
            this.gbCustomerSearch.ResumeLayout(false);
            this.gbCustomerSearch.PerformLayout();
            this.gbSearchDOB.ResumeLayout(false);
            this.gbSearchName.ResumeLayout(false);
            this.gbSearchName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCustomerSearch;
        private System.Windows.Forms.GroupBox gbSearchDOB;
        private System.Windows.Forms.Label lblSearchCustomers;
        private System.Windows.Forms.GroupBox gbSearchName;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.Label lblSearchLastName;
        private System.Windows.Forms.Label lblSearchFirstName;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.DateTimePicker dtpCustomerSearch;
        private System.Windows.Forms.Button btnCustomerSearchReturn;
    }
}