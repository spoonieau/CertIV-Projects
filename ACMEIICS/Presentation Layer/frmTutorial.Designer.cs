namespace ACMEIICS
{
    partial class frmTutorial
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
            this.wbTutorial = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbTutorial
            // 
            this.wbTutorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbTutorial.Location = new System.Drawing.Point(0, 0);
            this.wbTutorial.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbTutorial.Name = "wbTutorial";
            this.wbTutorial.Size = new System.Drawing.Size(956, 638);
            this.wbTutorial.TabIndex = 0;
            this.wbTutorial.Url = new System.Uri("http://IICSTutorial.html", System.UriKind.Absolute);
            // 
            // frmTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 638);
            this.Controls.Add(this.wbTutorial);
            this.Name = "frmTutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTutorial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbTutorial;
    }
}