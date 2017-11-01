using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ACMEIICS.DataAccessLayer;
using ACMEIICS.BusinessLogicLayer;
using System.Reflection;
namespace ACMEIICS
{
    public partial class frmMain : Form
    {
        const string formTitle = "ACME IICS"; 
        const string appName = "ACME Insurance Information Control System ";

        public frmMain()
        {
            InitializeComponent();
            this.Text = formTitle + " Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString(); // set frmMain tilte.
            lblDateTime.Text = appName; //Set lable to variable appName.
            tDateTime.Enabled = true; //Initialize timmer to show current time in frmMain.
            tRefresh.Enabled = true; //Initialize timmer to refresh dash board every 10sec.
            this.Icon = Properties.Resources.Genius; //Set form icon.

            //Test to see it UI can connect to database.
            try
            {
                SqlConnection conn = ConnectionManager.DatabaseConnection();
                conn.Open(); //Open connection.
                this.Text = this.Text + " Connected to " + conn.Database; // Update frmMain title with name of connected database.
                fillDashboard(); //Initialize method fillDashboard 
                conn.Close();//Close connection.
            }
            catch (Exception)
            {
                //Display error if unable to connect to data base.
                MessageBox.Show("Connection test to Acme DataBase has failed!!" + Environment.NewLine + "Please conntact System Administrator",
                    "DataBase Connection Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //What happen every tick of timer, handles current time.
        private void tDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = appName + DateTime.Now.ToString("dd -MMM-yyyy hh:mm:ss tt");
        }

        //Show frmCategories form.
        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmCategories();
            frm1.Show();
        }

        //Show frmCustomer form.
        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmCustomers();
            frm1.Show();
        }

        //Show frmProducts form.
        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmProducts();
            frm1.Show();
        }

        //Show frmProductTypes form.
        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmProductTypes();
            frm1.Show();
        }

        //Show frmSales from.
        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmSales();
            frm1.Show();
        }

        //Exit Application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Show frmTutorial form.
        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmTutorial();
            frm1.ShowDialog(this);
        }

        //Show About form.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmAbout();
            frm1.ShowDialog(this);
        }

        //Close the program cleanly.
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Method to Get required Data from the database and display dashboard (lvDashboard)
        private void fillDashboard()
        {
            string selectQueryDashBoard;

            selectQueryDashBoard = "SELECT count(dbo.Sales.ProductID) as NumberOFCustomers, dbo.Sales.ProductID, dbo.Products.ProductName, ";
            selectQueryDashBoard = selectQueryDashBoard + "dbo.ProductTypes.ProductType From dbo.Sales ";
            selectQueryDashBoard = selectQueryDashBoard + "Join Products ON Products.ProductID = Sales.ProductID ";
            selectQueryDashBoard = selectQueryDashBoard + "join ProductTypes on Products.ProductTypeID = ProductTypes.ProductTypeID ";
            selectQueryDashBoard = selectQueryDashBoard + "Group BY dbo.Sales.ProductID, dbo.Products.ProductName, ProductTypes.ProductType";

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQueryDashBoard, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ListViewItem test = new ListViewItem(rdr["NumberOFCustomers"].ToString());
                    test.SubItems.Add(rdr["ProductName"].ToString());
                    test.SubItems.Add(rdr["ProductType"].ToString());
                    lvDashBoard.Items.Add(test);
                }
                conn.Close();//Close connection.
            }
            catch (Exception)
            {
                //Display error if unable to connect to data base.
                MessageBox.Show("Connection test to Acme DataBase has failed!!" + Environment.NewLine + "Please conntact System Administrator",
                    "DataBase Connection Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //What happen every tick of timer, every 10 seconds it will refresh lvDashBoard.
        private void tRefresh_Tick(object sender, EventArgs e)
        {
            lvDashBoard.Items.Clear();
            fillDashboard();
        }
    }
}
