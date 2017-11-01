namespace ACMEIICS
{
    partial class frmCategories
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
            this.lblCategories = new System.Windows.Forms.Label();
            this.lvCategories = new System.Windows.Forms.ListView();
            this.chCategorieID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCategorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbCategoriesMaintenance = new System.Windows.Forms.GroupBox();
            this.cmCategories = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCatReturn = new System.Windows.Forms.Button();
            this.gbDeleteCategorie = new System.Windows.Forms.GroupBox();
            this.btnDeleteCategorie = new System.Windows.Forms.Button();
            this.cbDeleteCategorie = new System.Windows.Forms.ComboBox();
            this.lblDeleteCategorie = new System.Windows.Forms.Label();
            this.gbUpdateCategorie = new System.Windows.Forms.GroupBox();
            this.btnUpdateCategorie = new System.Windows.Forms.Button();
            this.txtUpdateCategorie = new System.Windows.Forms.TextBox();
            this.lblUpdateCat = new System.Windows.Forms.Label();
            this.cbUpdateCategories = new System.Windows.Forms.ComboBox();
            this.lblUpdateCategorie = new System.Windows.Forms.Label();
            this.gbAddCategorie = new System.Windows.Forms.GroupBox();
            this.btnAddCategorie = new System.Windows.Forms.Button();
            this.txtAddCategroie = new System.Windows.Forms.TextBox();
            this.lblAddCategorie = new System.Windows.Forms.Label();
            this.gbCategoriesMaintenance.SuspendLayout();
            this.cmCategories.SuspendLayout();
            this.gbDeleteCategorie.SuspendLayout();
            this.gbUpdateCategorie.SuspendLayout();
            this.gbAddCategorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(12, 9);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(148, 13);
            this.lblCategories.TabIndex = 0;
            this.lblCategories.Text = "ACME IICS stored Categories:";
            // 
            // lvCategories
            // 
            this.lvCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCategorieID,
            this.chCategorie});
            this.lvCategories.FullRowSelect = true;
            this.lvCategories.GridLines = true;
            this.lvCategories.Location = new System.Drawing.Point(12, 26);
            this.lvCategories.Name = "lvCategories";
            this.lvCategories.Size = new System.Drawing.Size(178, 423);
            this.lvCategories.TabIndex = 1;
            this.lvCategories.UseCompatibleStateImageBehavior = false;
            this.lvCategories.View = System.Windows.Forms.View.Details;
            // 
            // chCategorieID
            // 
            this.chCategorieID.Text = "CategorieID:";
            this.chCategorieID.Width = 87;
            // 
            // chCategorie
            // 
            this.chCategorie.Text = "Categorie:";
            this.chCategorie.Width = 87;
            // 
            // gbCategoriesMaintenance
            // 
            this.gbCategoriesMaintenance.ContextMenuStrip = this.cmCategories;
            this.gbCategoriesMaintenance.Controls.Add(this.btnCatReturn);
            this.gbCategoriesMaintenance.Controls.Add(this.gbDeleteCategorie);
            this.gbCategoriesMaintenance.Controls.Add(this.gbUpdateCategorie);
            this.gbCategoriesMaintenance.Controls.Add(this.gbAddCategorie);
            this.gbCategoriesMaintenance.Location = new System.Drawing.Point(197, 26);
            this.gbCategoriesMaintenance.Name = "gbCategoriesMaintenance";
            this.gbCategoriesMaintenance.Size = new System.Drawing.Size(512, 425);
            this.gbCategoriesMaintenance.TabIndex = 2;
            this.gbCategoriesMaintenance.TabStop = false;
            this.gbCategoriesMaintenance.Text = "Categorie Maintenance";
            // 
            // cmCategories
            // 
            this.cmCategories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem});
            this.cmCategories.Name = "cmCategories";
            this.cmCategories.Size = new System.Drawing.Size(110, 26);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Image = global::ACMEIICS.Properties.Resources.smallArrowLeft;
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // btnCatReturn
            // 
            this.btnCatReturn.Image = global::ACMEIICS.Properties.Resources.smallArrowLeft;
            this.btnCatReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatReturn.Location = new System.Drawing.Point(442, 392);
            this.btnCatReturn.Name = "btnCatReturn";
            this.btnCatReturn.Size = new System.Drawing.Size(64, 27);
            this.btnCatReturn.TabIndex = 4;
            this.btnCatReturn.Text = "Return";
            this.btnCatReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCatReturn.UseVisualStyleBackColor = true;
            this.btnCatReturn.Click += new System.EventHandler(this.btnCatReturn_Click);
            // 
            // gbDeleteCategorie
            // 
            this.gbDeleteCategorie.Controls.Add(this.btnDeleteCategorie);
            this.gbDeleteCategorie.Controls.Add(this.cbDeleteCategorie);
            this.gbDeleteCategorie.Controls.Add(this.lblDeleteCategorie);
            this.gbDeleteCategorie.Location = new System.Drawing.Point(7, 175);
            this.gbDeleteCategorie.Name = "gbDeleteCategorie";
            this.gbDeleteCategorie.Size = new System.Drawing.Size(499, 45);
            this.gbDeleteCategorie.TabIndex = 3;
            this.gbDeleteCategorie.TabStop = false;
            this.gbDeleteCategorie.Text = "Delete Categorie";
            // 
            // btnDeleteCategorie
            // 
            this.btnDeleteCategorie.Image = global::ACMEIICS.Properties.Resources.Forbidden;
            this.btnDeleteCategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCategorie.Location = new System.Drawing.Point(380, 12);
            this.btnDeleteCategorie.Name = "btnDeleteCategorie";
            this.btnDeleteCategorie.Size = new System.Drawing.Size(113, 27);
            this.btnDeleteCategorie.TabIndex = 1;
            this.btnDeleteCategorie.Text = "Delete Categorie";
            this.btnDeleteCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCategorie.UseVisualStyleBackColor = true;
            this.btnDeleteCategorie.Click += new System.EventHandler(this.btnDeleteCategorie_Click);
            // 
            // cbDeleteCategorie
            // 
            this.cbDeleteCategorie.FormattingEnabled = true;
            this.cbDeleteCategorie.Location = new System.Drawing.Point(244, 15);
            this.cbDeleteCategorie.Name = "cbDeleteCategorie";
            this.cbDeleteCategorie.Size = new System.Drawing.Size(57, 21);
            this.cbDeleteCategorie.TabIndex = 0;
            // 
            // lblDeleteCategorie
            // 
            this.lblDeleteCategorie.AutoSize = true;
            this.lblDeleteCategorie.Location = new System.Drawing.Point(7, 20);
            this.lblDeleteCategorie.Name = "lblDeleteCategorie";
            this.lblDeleteCategorie.Size = new System.Drawing.Size(231, 13);
            this.lblDeleteCategorie.TabIndex = 0;
            this.lblDeleteCategorie.Text = "Please Select the ID of the Categorie to Delete:";
            // 
            // gbUpdateCategorie
            // 
            this.gbUpdateCategorie.Controls.Add(this.btnUpdateCategorie);
            this.gbUpdateCategorie.Controls.Add(this.txtUpdateCategorie);
            this.gbUpdateCategorie.Controls.Add(this.lblUpdateCat);
            this.gbUpdateCategorie.Controls.Add(this.cbUpdateCategories);
            this.gbUpdateCategorie.Controls.Add(this.lblUpdateCategorie);
            this.gbUpdateCategorie.Location = new System.Drawing.Point(7, 89);
            this.gbUpdateCategorie.Name = "gbUpdateCategorie";
            this.gbUpdateCategorie.Size = new System.Drawing.Size(499, 79);
            this.gbUpdateCategorie.TabIndex = 2;
            this.gbUpdateCategorie.TabStop = false;
            this.gbUpdateCategorie.Text = "Update Categorie";
            // 
            // btnUpdateCategorie
            // 
            this.btnUpdateCategorie.Image = global::ACMEIICS.Properties.Resources.Pen;
            this.btnUpdateCategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCategorie.Location = new System.Drawing.Point(380, 46);
            this.btnUpdateCategorie.Name = "btnUpdateCategorie";
            this.btnUpdateCategorie.Size = new System.Drawing.Size(113, 27);
            this.btnUpdateCategorie.TabIndex = 3;
            this.btnUpdateCategorie.Text = "Update Categorie";
            this.btnUpdateCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCategorie.UseVisualStyleBackColor = true;
            this.btnUpdateCategorie.Click += new System.EventHandler(this.btnUpdateCategorie_Click);
            // 
            // txtUpdateCategorie
            // 
            this.txtUpdateCategorie.Location = new System.Drawing.Point(9, 50);
            this.txtUpdateCategorie.Name = "txtUpdateCategorie";
            this.txtUpdateCategorie.Size = new System.Drawing.Size(204, 20);
            this.txtUpdateCategorie.TabIndex = 1;
            // 
            // lblUpdateCat
            // 
            this.lblUpdateCat.AutoSize = true;
            this.lblUpdateCat.Location = new System.Drawing.Point(6, 34);
            this.lblUpdateCat.Name = "lblUpdateCat";
            this.lblUpdateCat.Size = new System.Drawing.Size(124, 13);
            this.lblUpdateCat.TabIndex = 1;
            this.lblUpdateCat.Text = "Update Categorie below:";
            // 
            // cbUpdateCategories
            // 
            this.cbUpdateCategories.FormattingEnabled = true;
            this.cbUpdateCategories.Location = new System.Drawing.Point(206, 13);
            this.cbUpdateCategories.Name = "cbUpdateCategories";
            this.cbUpdateCategories.Size = new System.Drawing.Size(57, 21);
            this.cbUpdateCategories.TabIndex = 0;
            this.cbUpdateCategories.SelectedIndexChanged += new System.EventHandler(this.cbUpdateCategories_SelectedIndexChanged);
            // 
            // lblUpdateCategorie
            // 
            this.lblUpdateCategorie.AutoSize = true;
            this.lblUpdateCategorie.Location = new System.Drawing.Point(6, 16);
            this.lblUpdateCategorie.Name = "lblUpdateCategorie";
            this.lblUpdateCategorie.Size = new System.Drawing.Size(194, 13);
            this.lblUpdateCategorie.TabIndex = 0;
            this.lblUpdateCategorie.Text = "Please Select a Categorie ID to update:";
            // 
            // gbAddCategorie
            // 
            this.gbAddCategorie.Controls.Add(this.btnAddCategorie);
            this.gbAddCategorie.Controls.Add(this.txtAddCategroie);
            this.gbAddCategorie.Controls.Add(this.lblAddCategorie);
            this.gbAddCategorie.Location = new System.Drawing.Point(7, 20);
            this.gbAddCategorie.Name = "gbAddCategorie";
            this.gbAddCategorie.Size = new System.Drawing.Size(499, 63);
            this.gbAddCategorie.TabIndex = 1;
            this.gbAddCategorie.TabStop = false;
            this.gbAddCategorie.Text = "Add Categorie";
            // 
            // btnAddCategorie
            // 
            this.btnAddCategorie.AutoSize = true;
            this.btnAddCategorie.Image = global::ACMEIICS.Properties.Resources.CircledPlus;
            this.btnAddCategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategorie.Location = new System.Drawing.Point(393, 30);
            this.btnAddCategorie.Name = "btnAddCategorie";
            this.btnAddCategorie.Size = new System.Drawing.Size(100, 27);
            this.btnAddCategorie.TabIndex = 2;
            this.btnAddCategorie.Text = "Add Categorie";
            this.btnAddCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCategorie.UseVisualStyleBackColor = true;
            this.btnAddCategorie.Click += new System.EventHandler(this.btnAddCategorie_Click);
            // 
            // txtAddCategroie
            // 
            this.txtAddCategroie.Location = new System.Drawing.Point(9, 33);
            this.txtAddCategroie.Name = "txtAddCategroie";
            this.txtAddCategroie.Size = new System.Drawing.Size(202, 20);
            this.txtAddCategroie.TabIndex = 0;
            // 
            // lblAddCategorie
            // 
            this.lblAddCategorie.AutoSize = true;
            this.lblAddCategorie.Location = new System.Drawing.Point(6, 16);
            this.lblAddCategorie.Name = "lblAddCategorie";
            this.lblAddCategorie.Size = new System.Drawing.Size(202, 13);
            this.lblAddCategorie.TabIndex = 0;
            this.lblAddCategorie.Text = "Please enter a new Categorie to the IICS:";
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 463);
            this.Controls.Add(this.gbCategoriesMaintenance);
            this.Controls.Add(this.lvCategories);
            this.Controls.Add(this.lblCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategories";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories Maintenance";
            this.gbCategoriesMaintenance.ResumeLayout(false);
            this.cmCategories.ResumeLayout(false);
            this.gbDeleteCategorie.ResumeLayout(false);
            this.gbDeleteCategorie.PerformLayout();
            this.gbUpdateCategorie.ResumeLayout(false);
            this.gbUpdateCategorie.PerformLayout();
            this.gbAddCategorie.ResumeLayout(false);
            this.gbAddCategorie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.ListView lvCategories;
        private System.Windows.Forms.GroupBox gbCategoriesMaintenance;
        private System.Windows.Forms.GroupBox gbAddCategorie;
        private System.Windows.Forms.Label lblAddCategorie;
        private System.Windows.Forms.GroupBox gbDeleteCategorie;
        private System.Windows.Forms.Label lblDeleteCategorie;
        private System.Windows.Forms.GroupBox gbUpdateCategorie;
        private System.Windows.Forms.Button btnUpdateCategorie;
        private System.Windows.Forms.TextBox txtUpdateCategorie;
        private System.Windows.Forms.Label lblUpdateCat;
        private System.Windows.Forms.ComboBox cbUpdateCategories;
        private System.Windows.Forms.Label lblUpdateCategorie;
        private System.Windows.Forms.Button btnAddCategorie;
        private System.Windows.Forms.TextBox txtAddCategroie;
        private System.Windows.Forms.ComboBox cbDeleteCategorie;
        private System.Windows.Forms.Button btnDeleteCategorie;
        private System.Windows.Forms.ColumnHeader chCategorieID;
        private System.Windows.Forms.ColumnHeader chCategorie;
        private System.Windows.Forms.ContextMenuStrip cmCategories;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.Button btnCatReturn;
    }
}