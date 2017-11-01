namespace ACMEIICS
{
    partial class frmCustomers
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
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lvCustomers = new System.Windows.Forms.ListView();
            this.chCustomerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSuburb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPostCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbCustomerMaintenance = new System.Windows.Forms.GroupBox();
            this.btnCusReturn = new System.Windows.Forms.Button();
            this.gbDeleteCustomer = new System.Windows.Forms.GroupBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.cbDeleteCustomer = new System.Windows.Forms.ComboBox();
            this.lblDeleteCustomer = new System.Windows.Forms.Label();
            this.gbUpdateCustomer = new System.Windows.Forms.GroupBox();
            this.lblUpdatePostCode = new System.Windows.Forms.Label();
            this.cbCustomerUpdateID = new System.Windows.Forms.ComboBox();
            this.lblUpdateCustomerDetalis = new System.Windows.Forms.Label();
            this.txtUpdatePostCode = new System.Windows.Forms.TextBox();
            this.dtpUpdateBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.lblUpdateFirstName = new System.Windows.Forms.Label();
            this.txtUpdateSuburb = new System.Windows.Forms.TextBox();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.lblUpdateSuburb = new System.Windows.Forms.Label();
            this.lblUpdateLastName = new System.Windows.Forms.Label();
            this.cbUpdateGroup = new System.Windows.Forms.ComboBox();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.lblUpdateGroup = new System.Windows.Forms.Label();
            this.lblUpdateGender = new System.Windows.Forms.Label();
            this.cbUpdateGender = new System.Windows.Forms.ComboBox();
            this.lblUpdateCustomerDOB = new System.Windows.Forms.Label();
            this.lblUpdateCustomer = new System.Windows.Forms.Label();
            this.cbUpdateState = new System.Windows.Forms.ComboBox();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.lblUpdateState = new System.Windows.Forms.Label();
            this.gbAddCustomer = new System.Windows.Forms.GroupBox();
            this.txtAddPostCode = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtAddSuburb = new System.Windows.Forms.TextBox();
            this.lblAddSuburb = new System.Windows.Forms.Label();
            this.cbAddGroup = new System.Windows.Forms.ComboBox();
            this.lblAddGroup = new System.Windows.Forms.Label();
            this.dtpAddBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblCustomerBirthDate = new System.Windows.Forms.Label();
            this.lblAddPostcode = new System.Windows.Forms.Label();
            this.cbAddSate = new System.Windows.Forms.ComboBox();
            this.lblAddSate = new System.Windows.Forms.Label();
            this.txtAddAddress = new System.Windows.Forms.TextBox();
            this.lblAddAddress = new System.Windows.Forms.Label();
            this.cbAddGender = new System.Windows.Forms.ComboBox();
            this.lblAddGender = new System.Windows.Forms.Label();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.lblAddLastName = new System.Windows.Forms.Label();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.lblAddFirstName = new System.Windows.Forms.Label();
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.cmSearchReturn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbCustomerMaintenance.SuspendLayout();
            this.gbDeleteCustomer.SuspendLayout();
            this.gbUpdateCustomer.SuspendLayout();
            this.gbAddCustomer.SuspendLayout();
            this.cmSearchReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(12, 9);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(147, 13);
            this.lblCustomers.TabIndex = 0;
            this.lblCustomers.Text = "ACME IICS stored Customers:";
            // 
            // lvCustomers
            // 
            this.lvCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCustomerId,
            this.chCategory,
            this.chFirstName,
            this.chLastName,
            this.chAddress,
            this.chSuburb,
            this.chState,
            this.chPostCode,
            this.chGender,
            this.chBirthDate});
            this.lvCustomers.FullRowSelect = true;
            this.lvCustomers.GridLines = true;
            this.lvCustomers.Location = new System.Drawing.Point(12, 26);
            this.lvCustomers.Name = "lvCustomers";
            this.lvCustomers.Size = new System.Drawing.Size(613, 514);
            this.lvCustomers.TabIndex = 1;
            this.lvCustomers.UseCompatibleStateImageBehavior = false;
            this.lvCustomers.View = System.Windows.Forms.View.Details;
            // 
            // chCustomerId
            // 
            this.chCustomerId.Text = "Customer ID:";
            // 
            // chCategory
            // 
            this.chCategory.Text = "Category:";
            this.chCategory.Width = 82;
            // 
            // chFirstName
            // 
            this.chFirstName.Text = "FirstName:";
            this.chFirstName.Width = 85;
            // 
            // chLastName
            // 
            this.chLastName.Text = "LastName:";
            this.chLastName.Width = 100;
            // 
            // chAddress
            // 
            this.chAddress.Text = "Address:";
            this.chAddress.Width = 200;
            // 
            // chSuburb
            // 
            this.chSuburb.Text = "Suburb:";
            this.chSuburb.Width = 110;
            // 
            // chState
            // 
            this.chState.Text = "State:";
            // 
            // chPostCode
            // 
            this.chPostCode.Text = "PostCode:";
            // 
            // chGender
            // 
            this.chGender.Text = "Gender:";
            // 
            // chBirthDate
            // 
            this.chBirthDate.Text = "BirthDate:";
            this.chBirthDate.Width = 100;
            // 
            // gbCustomerMaintenance
            // 
            this.gbCustomerMaintenance.Controls.Add(this.btnCusReturn);
            this.gbCustomerMaintenance.Controls.Add(this.gbDeleteCustomer);
            this.gbCustomerMaintenance.Controls.Add(this.gbUpdateCustomer);
            this.gbCustomerMaintenance.Controls.Add(this.gbAddCustomer);
            this.gbCustomerMaintenance.Location = new System.Drawing.Point(624, 26);
            this.gbCustomerMaintenance.Name = "gbCustomerMaintenance";
            this.gbCustomerMaintenance.Size = new System.Drawing.Size(459, 514);
            this.gbCustomerMaintenance.TabIndex = 2;
            this.gbCustomerMaintenance.TabStop = false;
            this.gbCustomerMaintenance.Text = "IICS Customer Maintenance";
            // 
            // btnCusReturn
            // 
            this.btnCusReturn.Image = global::ACMEIICS.Properties.Resources.smallArrowLeft;
            this.btnCusReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCusReturn.Location = new System.Drawing.Point(379, 481);
            this.btnCusReturn.Name = "btnCusReturn";
            this.btnCusReturn.Size = new System.Drawing.Size(64, 27);
            this.btnCusReturn.TabIndex = 4;
            this.btnCusReturn.Text = "Return";
            this.btnCusReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCusReturn.UseVisualStyleBackColor = true;
            this.btnCusReturn.Click += new System.EventHandler(this.btnCusReturn_Click);
            // 
            // gbDeleteCustomer
            // 
            this.gbDeleteCustomer.Controls.Add(this.btnDeleteCustomer);
            this.gbDeleteCustomer.Controls.Add(this.cbDeleteCustomer);
            this.gbDeleteCustomer.Controls.Add(this.lblDeleteCustomer);
            this.gbDeleteCustomer.Location = new System.Drawing.Point(7, 429);
            this.gbDeleteCustomer.Name = "gbDeleteCustomer";
            this.gbDeleteCustomer.Size = new System.Drawing.Size(442, 45);
            this.gbDeleteCustomer.TabIndex = 3;
            this.gbDeleteCustomer.TabStop = false;
            this.gbDeleteCustomer.Text = "Delete Customer";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.AutoSize = true;
            this.btnDeleteCustomer.Image = global::ACMEIICS.Properties.Resources.Forbidden;
            this.btnDeleteCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(322, 12);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(111, 27);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // cbDeleteCustomer
            // 
            this.cbDeleteCustomer.FormattingEnabled = true;
            this.cbDeleteCustomer.Location = new System.Drawing.Point(244, 15);
            this.cbDeleteCustomer.Name = "cbDeleteCustomer";
            this.cbDeleteCustomer.Size = new System.Drawing.Size(57, 21);
            this.cbDeleteCustomer.TabIndex = 1;
            // 
            // lblDeleteCustomer
            // 
            this.lblDeleteCustomer.AutoSize = true;
            this.lblDeleteCustomer.Location = new System.Drawing.Point(7, 20);
            this.lblDeleteCustomer.Name = "lblDeleteCustomer";
            this.lblDeleteCustomer.Size = new System.Drawing.Size(230, 13);
            this.lblDeleteCustomer.TabIndex = 0;
            this.lblDeleteCustomer.Text = "Please Select the ID of the Customer to Delete:";
            // 
            // gbUpdateCustomer
            // 
            this.gbUpdateCustomer.Controls.Add(this.lblUpdatePostCode);
            this.gbUpdateCustomer.Controls.Add(this.cbCustomerUpdateID);
            this.gbUpdateCustomer.Controls.Add(this.lblUpdateCustomerDetalis);
            this.gbUpdateCustomer.Controls.Add(this.txtUpdatePostCode);
            this.gbUpdateCustomer.Controls.Add(this.dtpUpdateBirthDate);
            this.gbUpdateCustomer.Controls.Add(this.btnUpdateCustomer);
            this.gbUpdateCustomer.Controls.Add(this.lblUpdateFirstName);
            this.gbUpdateCustomer.Controls.Add(this.txtUpdateSuburb);
            this.gbUpdateCustomer.Controls.Add(this.txtUpdateFirstName);
            this.gbUpdateCustomer.Controls.Add(this.lblUpdateSuburb);
            this.gbUpdateCustomer.Controls.Add(this.lblUpdateLastName);
            this.gbUpdateCustomer.Controls.Add(this.cbUpdateGroup);
            this.gbUpdateCustomer.Controls.Add(this.txtUpdateLastName);
            this.gbUpdateCustomer.Controls.Add(this.lblUpdateGroup);
            this.gbUpdateCustomer.Controls.Add(this.lblUpdateGender);
            this.gbUpdateCustomer.Controls.Add(this.cbUpdateGender);
            this.gbUpdateCustomer.Controls.Add(this.lblUpdateCustomerDOB);
            this.gbUpdateCustomer.Controls.Add(this.lblUpdateCustomer);
            this.gbUpdateCustomer.Controls.Add(this.cbUpdateState);
            this.gbUpdateCustomer.Controls.Add(this.txtUpdateAddress);
            this.gbUpdateCustomer.Controls.Add(this.lblUpdateState);
            this.gbUpdateCustomer.Location = new System.Drawing.Point(7, 210);
            this.gbUpdateCustomer.Name = "gbUpdateCustomer";
            this.gbUpdateCustomer.Size = new System.Drawing.Size(442, 213);
            this.gbUpdateCustomer.TabIndex = 2;
            this.gbUpdateCustomer.TabStop = false;
            this.gbUpdateCustomer.Text = "Update Customer";
            // 
            // lblUpdatePostCode
            // 
            this.lblUpdatePostCode.AutoSize = true;
            this.lblUpdatePostCode.Location = new System.Drawing.Point(340, 140);
            this.lblUpdatePostCode.Name = "lblUpdatePostCode";
            this.lblUpdatePostCode.Size = new System.Drawing.Size(56, 13);
            this.lblUpdatePostCode.TabIndex = 18;
            this.lblUpdatePostCode.Text = "PostCode:";
            // 
            // cbCustomerUpdateID
            // 
            this.cbCustomerUpdateID.FormattingEnabled = true;
            this.cbCustomerUpdateID.Location = new System.Drawing.Point(9, 36);
            this.cbCustomerUpdateID.Name = "cbCustomerUpdateID";
            this.cbCustomerUpdateID.Size = new System.Drawing.Size(100, 21);
            this.cbCustomerUpdateID.TabIndex = 1;
            this.cbCustomerUpdateID.SelectedIndexChanged += new System.EventHandler(this.cbCustomerUpdateID_SelectedIndexChanged);
            // 
            // lblUpdateCustomerDetalis
            // 
            this.lblUpdateCustomerDetalis.AutoSize = true;
            this.lblUpdateCustomerDetalis.Location = new System.Drawing.Point(10, 20);
            this.lblUpdateCustomerDetalis.Name = "lblUpdateCustomerDetalis";
            this.lblUpdateCustomerDetalis.Size = new System.Drawing.Size(184, 13);
            this.lblUpdateCustomerDetalis.TabIndex = 0;
            this.lblUpdateCustomerDetalis.Text = "Please select Customer ID to Update:";
            // 
            // txtUpdatePostCode
            // 
            this.txtUpdatePostCode.Location = new System.Drawing.Point(343, 156);
            this.txtUpdatePostCode.Name = "txtUpdatePostCode";
            this.txtUpdatePostCode.Size = new System.Drawing.Size(90, 20);
            this.txtUpdatePostCode.TabIndex = 19;
            // 
            // dtpUpdateBirthDate
            // 
            this.dtpUpdateBirthDate.CustomFormat = "dd-MM-yyyy";
            this.dtpUpdateBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUpdateBirthDate.Location = new System.Drawing.Point(118, 78);
            this.dtpUpdateBirthDate.Name = "dtpUpdateBirthDate";
            this.dtpUpdateBirthDate.Size = new System.Drawing.Size(100, 20);
            this.dtpUpdateBirthDate.TabIndex = 9;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.AutoSize = true;
            this.btnUpdateCustomer.Image = global::ACMEIICS.Properties.Resources.Pen;
            this.btnUpdateCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(322, 180);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(111, 27);
            this.btnUpdateCustomer.TabIndex = 20;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // lblUpdateFirstName
            // 
            this.lblUpdateFirstName.AutoSize = true;
            this.lblUpdateFirstName.Location = new System.Drawing.Point(6, 62);
            this.lblUpdateFirstName.Name = "lblUpdateFirstName";
            this.lblUpdateFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblUpdateFirstName.TabIndex = 2;
            this.lblUpdateFirstName.Text = "First Name:";
            // 
            // txtUpdateSuburb
            // 
            this.txtUpdateSuburb.Location = new System.Drawing.Point(233, 117);
            this.txtUpdateSuburb.Name = "txtUpdateSuburb";
            this.txtUpdateSuburb.Size = new System.Drawing.Size(200, 20);
            this.txtUpdateSuburb.TabIndex = 15;
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Location = new System.Drawing.Point(9, 78);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateFirstName.TabIndex = 3;
            // 
            // lblUpdateSuburb
            // 
            this.lblUpdateSuburb.AutoSize = true;
            this.lblUpdateSuburb.Location = new System.Drawing.Point(230, 101);
            this.lblUpdateSuburb.Name = "lblUpdateSuburb";
            this.lblUpdateSuburb.Size = new System.Drawing.Size(44, 13);
            this.lblUpdateSuburb.TabIndex = 14;
            this.lblUpdateSuburb.Text = "Suburb:";
            // 
            // lblUpdateLastName
            // 
            this.lblUpdateLastName.AutoSize = true;
            this.lblUpdateLastName.Location = new System.Drawing.Point(7, 101);
            this.lblUpdateLastName.Name = "lblUpdateLastName";
            this.lblUpdateLastName.Size = new System.Drawing.Size(61, 13);
            this.lblUpdateLastName.TabIndex = 4;
            this.lblUpdateLastName.Text = "Last Name:";
            // 
            // cbUpdateGroup
            // 
            this.cbUpdateGroup.FormattingEnabled = true;
            this.cbUpdateGroup.Location = new System.Drawing.Point(118, 117);
            this.cbUpdateGroup.Name = "cbUpdateGroup";
            this.cbUpdateGroup.Size = new System.Drawing.Size(100, 21);
            this.cbUpdateGroup.TabIndex = 11;
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Location = new System.Drawing.Point(9, 117);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateLastName.TabIndex = 5;
            // 
            // lblUpdateGroup
            // 
            this.lblUpdateGroup.AutoSize = true;
            this.lblUpdateGroup.Location = new System.Drawing.Point(115, 101);
            this.lblUpdateGroup.Name = "lblUpdateGroup";
            this.lblUpdateGroup.Size = new System.Drawing.Size(92, 13);
            this.lblUpdateGroup.TabIndex = 10;
            this.lblUpdateGroup.Text = "Customers Status:";
            // 
            // lblUpdateGender
            // 
            this.lblUpdateGender.AutoSize = true;
            this.lblUpdateGender.Location = new System.Drawing.Point(7, 140);
            this.lblUpdateGender.Name = "lblUpdateGender";
            this.lblUpdateGender.Size = new System.Drawing.Size(97, 13);
            this.lblUpdateGender.TabIndex = 6;
            this.lblUpdateGender.Text = "Customers Gender:";
            // 
            // cbUpdateGender
            // 
            this.cbUpdateGender.FormattingEnabled = true;
            this.cbUpdateGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbUpdateGender.Location = new System.Drawing.Point(9, 156);
            this.cbUpdateGender.Name = "cbUpdateGender";
            this.cbUpdateGender.Size = new System.Drawing.Size(100, 21);
            this.cbUpdateGender.TabIndex = 7;
            // 
            // lblUpdateCustomerDOB
            // 
            this.lblUpdateCustomerDOB.AutoSize = true;
            this.lblUpdateCustomerDOB.Location = new System.Drawing.Point(115, 62);
            this.lblUpdateCustomerDOB.Name = "lblUpdateCustomerDOB";
            this.lblUpdateCustomerDOB.Size = new System.Drawing.Size(109, 13);
            this.lblUpdateCustomerDOB.TabIndex = 8;
            this.lblUpdateCustomerDOB.Text = "Customers Birth Date:";
            // 
            // lblUpdateCustomer
            // 
            this.lblUpdateCustomer.AutoSize = true;
            this.lblUpdateCustomer.Location = new System.Drawing.Point(230, 62);
            this.lblUpdateCustomer.Name = "lblUpdateCustomer";
            this.lblUpdateCustomer.Size = new System.Drawing.Size(94, 13);
            this.lblUpdateCustomer.TabIndex = 12;
            this.lblUpdateCustomer.Text = "Customers Adress:";
            // 
            // cbUpdateState
            // 
            this.cbUpdateState.FormattingEnabled = true;
            this.cbUpdateState.Items.AddRange(new object[] {
            "NSW",
            "VIC",
            "QLD",
            "WA",
            "ACT",
            "SA",
            "TAS"});
            this.cbUpdateState.Location = new System.Drawing.Point(233, 156);
            this.cbUpdateState.Name = "cbUpdateState";
            this.cbUpdateState.Size = new System.Drawing.Size(90, 21);
            this.cbUpdateState.TabIndex = 17;
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Location = new System.Drawing.Point(233, 78);
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(200, 20);
            this.txtUpdateAddress.TabIndex = 13;
            // 
            // lblUpdateState
            // 
            this.lblUpdateState.AutoSize = true;
            this.lblUpdateState.Location = new System.Drawing.Point(230, 140);
            this.lblUpdateState.Name = "lblUpdateState";
            this.lblUpdateState.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateState.TabIndex = 16;
            this.lblUpdateState.Text = "State:";
            // 
            // gbAddCustomer
            // 
            this.gbAddCustomer.Controls.Add(this.txtAddPostCode);
            this.gbAddCustomer.Controls.Add(this.btnAddCustomer);
            this.gbAddCustomer.Controls.Add(this.txtAddSuburb);
            this.gbAddCustomer.Controls.Add(this.lblAddSuburb);
            this.gbAddCustomer.Controls.Add(this.cbAddGroup);
            this.gbAddCustomer.Controls.Add(this.lblAddGroup);
            this.gbAddCustomer.Controls.Add(this.dtpAddBirthDate);
            this.gbAddCustomer.Controls.Add(this.lblCustomerBirthDate);
            this.gbAddCustomer.Controls.Add(this.lblAddPostcode);
            this.gbAddCustomer.Controls.Add(this.cbAddSate);
            this.gbAddCustomer.Controls.Add(this.lblAddSate);
            this.gbAddCustomer.Controls.Add(this.txtAddAddress);
            this.gbAddCustomer.Controls.Add(this.lblAddAddress);
            this.gbAddCustomer.Controls.Add(this.cbAddGender);
            this.gbAddCustomer.Controls.Add(this.lblAddGender);
            this.gbAddCustomer.Controls.Add(this.txtAddLastName);
            this.gbAddCustomer.Controls.Add(this.lblAddLastName);
            this.gbAddCustomer.Controls.Add(this.txtAddFirstName);
            this.gbAddCustomer.Controls.Add(this.lblAddFirstName);
            this.gbAddCustomer.Controls.Add(this.lblAddCustomer);
            this.gbAddCustomer.Location = new System.Drawing.Point(7, 19);
            this.gbAddCustomer.Name = "gbAddCustomer";
            this.gbAddCustomer.Size = new System.Drawing.Size(442, 185);
            this.gbAddCustomer.TabIndex = 1;
            this.gbAddCustomer.TabStop = false;
            this.gbAddCustomer.Text = "Add Customer";
            // 
            // txtAddPostCode
            // 
            this.txtAddPostCode.Location = new System.Drawing.Point(343, 127);
            this.txtAddPostCode.Name = "txtAddPostCode";
            this.txtAddPostCode.Size = new System.Drawing.Size(90, 20);
            this.txtAddPostCode.TabIndex = 18;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.AutoSize = true;
            this.btnAddCustomer.Image = global::ACMEIICS.Properties.Resources.CircledPlus;
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCustomer.Location = new System.Drawing.Point(337, 154);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(99, 27);
            this.btnAddCustomer.TabIndex = 19;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtAddSuburb
            // 
            this.txtAddSuburb.Location = new System.Drawing.Point(233, 88);
            this.txtAddSuburb.Name = "txtAddSuburb";
            this.txtAddSuburb.Size = new System.Drawing.Size(200, 20);
            this.txtAddSuburb.TabIndex = 14;
            // 
            // lblAddSuburb
            // 
            this.lblAddSuburb.AutoSize = true;
            this.lblAddSuburb.Location = new System.Drawing.Point(230, 72);
            this.lblAddSuburb.Name = "lblAddSuburb";
            this.lblAddSuburb.Size = new System.Drawing.Size(44, 13);
            this.lblAddSuburb.TabIndex = 13;
            this.lblAddSuburb.Text = "Suburb:";
            // 
            // cbAddGroup
            // 
            this.cbAddGroup.FormattingEnabled = true;
            this.cbAddGroup.Location = new System.Drawing.Point(118, 88);
            this.cbAddGroup.Name = "cbAddGroup";
            this.cbAddGroup.Size = new System.Drawing.Size(100, 21);
            this.cbAddGroup.TabIndex = 10;
            // 
            // lblAddGroup
            // 
            this.lblAddGroup.AutoSize = true;
            this.lblAddGroup.Location = new System.Drawing.Point(115, 72);
            this.lblAddGroup.Name = "lblAddGroup";
            this.lblAddGroup.Size = new System.Drawing.Size(92, 13);
            this.lblAddGroup.TabIndex = 9;
            this.lblAddGroup.Text = "Customers Status:";
            // 
            // dtpAddBirthDate
            // 
            this.dtpAddBirthDate.CustomFormat = "dd-MM-yyyy";
            this.dtpAddBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAddBirthDate.Location = new System.Drawing.Point(118, 49);
            this.dtpAddBirthDate.Name = "dtpAddBirthDate";
            this.dtpAddBirthDate.Size = new System.Drawing.Size(100, 20);
            this.dtpAddBirthDate.TabIndex = 8;
            // 
            // lblCustomerBirthDate
            // 
            this.lblCustomerBirthDate.AutoSize = true;
            this.lblCustomerBirthDate.Location = new System.Drawing.Point(115, 33);
            this.lblCustomerBirthDate.Name = "lblCustomerBirthDate";
            this.lblCustomerBirthDate.Size = new System.Drawing.Size(109, 13);
            this.lblCustomerBirthDate.TabIndex = 7;
            this.lblCustomerBirthDate.Text = "Customers Birth Date:";
            // 
            // lblAddPostcode
            // 
            this.lblAddPostcode.AutoSize = true;
            this.lblAddPostcode.Location = new System.Drawing.Point(340, 111);
            this.lblAddPostcode.Name = "lblAddPostcode";
            this.lblAddPostcode.Size = new System.Drawing.Size(56, 13);
            this.lblAddPostcode.TabIndex = 17;
            this.lblAddPostcode.Text = "PostCode:";
            // 
            // cbAddSate
            // 
            this.cbAddSate.FormattingEnabled = true;
            this.cbAddSate.Items.AddRange(new object[] {
            "NSW",
            "VIC",
            "QLD",
            "WA",
            "ACT",
            "SA",
            "TAS"});
            this.cbAddSate.Location = new System.Drawing.Point(233, 127);
            this.cbAddSate.Name = "cbAddSate";
            this.cbAddSate.Size = new System.Drawing.Size(90, 21);
            this.cbAddSate.TabIndex = 16;
            // 
            // lblAddSate
            // 
            this.lblAddSate.AutoSize = true;
            this.lblAddSate.Location = new System.Drawing.Point(230, 111);
            this.lblAddSate.Name = "lblAddSate";
            this.lblAddSate.Size = new System.Drawing.Size(35, 13);
            this.lblAddSate.TabIndex = 15;
            this.lblAddSate.Text = "State:";
            // 
            // txtAddAddress
            // 
            this.txtAddAddress.Location = new System.Drawing.Point(233, 49);
            this.txtAddAddress.Name = "txtAddAddress";
            this.txtAddAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddAddress.TabIndex = 12;
            // 
            // lblAddAddress
            // 
            this.lblAddAddress.AutoSize = true;
            this.lblAddAddress.Location = new System.Drawing.Point(230, 33);
            this.lblAddAddress.Name = "lblAddAddress";
            this.lblAddAddress.Size = new System.Drawing.Size(94, 13);
            this.lblAddAddress.TabIndex = 11;
            this.lblAddAddress.Text = "Customers Adress:";
            // 
            // cbAddGender
            // 
            this.cbAddGender.FormattingEnabled = true;
            this.cbAddGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbAddGender.Location = new System.Drawing.Point(9, 127);
            this.cbAddGender.Name = "cbAddGender";
            this.cbAddGender.Size = new System.Drawing.Size(100, 21);
            this.cbAddGender.TabIndex = 6;
            // 
            // lblAddGender
            // 
            this.lblAddGender.AutoSize = true;
            this.lblAddGender.Location = new System.Drawing.Point(7, 111);
            this.lblAddGender.Name = "lblAddGender";
            this.lblAddGender.Size = new System.Drawing.Size(94, 13);
            this.lblAddGender.TabIndex = 5;
            this.lblAddGender.Text = "Customers Gender";
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Location = new System.Drawing.Point(9, 88);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(100, 20);
            this.txtAddLastName.TabIndex = 4;
            // 
            // lblAddLastName
            // 
            this.lblAddLastName.AutoSize = true;
            this.lblAddLastName.Location = new System.Drawing.Point(7, 72);
            this.lblAddLastName.Name = "lblAddLastName";
            this.lblAddLastName.Size = new System.Drawing.Size(61, 13);
            this.lblAddLastName.TabIndex = 3;
            this.lblAddLastName.Text = "Last Name:";
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Location = new System.Drawing.Point(9, 49);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtAddFirstName.TabIndex = 2;
            // 
            // lblAddFirstName
            // 
            this.lblAddFirstName.AutoSize = true;
            this.lblAddFirstName.Location = new System.Drawing.Point(6, 33);
            this.lblAddFirstName.Name = "lblAddFirstName";
            this.lblAddFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblAddFirstName.TabIndex = 1;
            this.lblAddFirstName.Text = "First Name:";
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Location = new System.Drawing.Point(6, 16);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(181, 13);
            this.lblAddCustomer.TabIndex = 0;
            this.lblAddCustomer.Text = "Please enter a new Customer details:";
            // 
            // cmSearchReturn
            // 
            this.cmSearchReturn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.cmSearchReturn.Name = "searchReturn";
            this.cmSearchReturn.Size = new System.Drawing.Size(110, 48);
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
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 552);
            this.ContextMenuStrip = this.cmSearchReturn;
            this.Controls.Add(this.lvCustomers);
            this.Controls.Add(this.gbCustomerMaintenance);
            this.Controls.Add(this.lblCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomers";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers Maintenance";
            this.gbCustomerMaintenance.ResumeLayout(false);
            this.gbDeleteCustomer.ResumeLayout(false);
            this.gbDeleteCustomer.PerformLayout();
            this.gbUpdateCustomer.ResumeLayout(false);
            this.gbUpdateCustomer.PerformLayout();
            this.gbAddCustomer.ResumeLayout(false);
            this.gbAddCustomer.PerformLayout();
            this.cmSearchReturn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.ListView lvCustomers;
        private System.Windows.Forms.GroupBox gbCustomerMaintenance;
        private System.Windows.Forms.GroupBox gbAddCustomer;
        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.GroupBox gbDeleteCustomer;
        private System.Windows.Forms.Label lblDeleteCustomer;
        private System.Windows.Forms.GroupBox gbUpdateCustomer;
        private System.Windows.Forms.ComboBox cbDeleteCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.Label lblAddLastName;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.Label lblAddFirstName;
        private System.Windows.Forms.ComboBox cbAddGender;
        private System.Windows.Forms.Label lblAddGender;
        private System.Windows.Forms.Label lblAddPostcode;
        private System.Windows.Forms.ComboBox cbAddSate;
        private System.Windows.Forms.Label lblAddSate;
        private System.Windows.Forms.TextBox txtAddAddress;
        private System.Windows.Forms.Label lblAddAddress;
        private System.Windows.Forms.ComboBox cbAddGroup;
        private System.Windows.Forms.Label lblAddGroup;
        private System.Windows.Forms.DateTimePicker dtpAddBirthDate;
        private System.Windows.Forms.Label lblCustomerBirthDate;
        private System.Windows.Forms.TextBox txtAddSuburb;
        private System.Windows.Forms.Label lblAddSuburb;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtAddPostCode;
        private System.Windows.Forms.ComboBox cbCustomerUpdateID;
        private System.Windows.Forms.Label lblUpdateCustomerDetalis;
        private System.Windows.Forms.TextBox txtUpdatePostCode;
        private System.Windows.Forms.DateTimePicker dtpUpdateBirthDate;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Label lblUpdateFirstName;
        private System.Windows.Forms.TextBox txtUpdateSuburb;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.Label lblUpdateSuburb;
        private System.Windows.Forms.Label lblUpdateLastName;
        private System.Windows.Forms.ComboBox cbUpdateGroup;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.Label lblUpdateGroup;
        private System.Windows.Forms.Label lblUpdateGender;
        private System.Windows.Forms.ComboBox cbUpdateGender;
        private System.Windows.Forms.Label lblUpdateCustomerDOB;
        private System.Windows.Forms.Label lblUpdateCustomer;
        private System.Windows.Forms.ComboBox cbUpdateState;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.Label lblUpdateState;
        private System.Windows.Forms.Label lblUpdatePostCode;
        private System.Windows.Forms.ColumnHeader chCustomerId;
        private System.Windows.Forms.ColumnHeader chCategory;
        private System.Windows.Forms.ColumnHeader chFirstName;
        private System.Windows.Forms.ColumnHeader chLastName;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.ColumnHeader chSuburb;
        private System.Windows.Forms.ColumnHeader chState;
        private System.Windows.Forms.ColumnHeader chPostCode;
        private System.Windows.Forms.ColumnHeader chGender;
        private System.Windows.Forms.ColumnHeader chBirthDate;
        private System.Windows.Forms.ContextMenuStrip cmSearchReturn;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.Button btnCusReturn;
    }
}