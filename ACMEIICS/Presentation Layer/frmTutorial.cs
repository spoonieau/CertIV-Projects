using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ACMEIICS
{
    public partial class frmTutorial : Form
    {
        public frmTutorial()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Genius;
            this.Text = "ACMEIICS Tutorial";

            string curDir = Directory.GetCurrentDirectory(); //Get working Dir.
            wbTutorial.Url = new Uri(String.Format("file:///{0}/IICSTutorial.html", curDir)); //load URL form working Dir.
           
        }
    }
}
