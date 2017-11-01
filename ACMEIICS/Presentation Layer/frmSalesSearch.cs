using System;
using System.Windows.Forms;
using ACMEIICS.DataAccessLayer;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Globalization;

namespace ACMEIICS
{
    public partial class frmSalesSearch : Form
    {
        int useDate = 0;

        public frmSalesSearch()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Genius;
        }

        private void btnSalesSearchReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaleSearch_Click(object sender, EventArgs e)
        {
            GlobalVariables.searchCretia = null;

            // Check to see what ceritra the user will search by and set up string for sqlQuery

            //Search by customer first name
            if (!String.IsNullOrEmpty(txtSearchFirstName.Text) && !String.IsNullOrEmpty(txtSearchLastName.Text))
            {
                var result = MessageBox.Show("Search via customers name " + txtSearchFirstName.Text + " " + txtSearchLastName.Text + "?", "Search Sales", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {

                    GlobalVariables.searchCretia = "Customers.FirstName + ' ' + Customers.LastName = " + "'" + txtSearchFirstName.Text + " " + txtSearchLastName.Text + "'";
                    searchSales();
                }
                else
                {
                    return;
                }
                return;
            }
            //Search via D.O.P
            else if (String.IsNullOrEmpty(txtSearchFirstName.Text) && String.IsNullOrEmpty(txtSearchLastName.Text) && useDate == 1)
            {

                var result = MessageBox.Show("Search via Purchase date " + dtpSearchDOP.Text + "?","Search Sales",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {

                    string formatteddate = dtpSearchDOP.Value.ToShortDateString().ToString();
                    GlobalVariables.searchCretia = "Sales.StartDate = '" + formatteddate + "'";
                    searchSales();
                }
                else
                {
                    return;
                }
                return;

            }
            //If nothing is filled or selected 
            else
            {
                MessageBox.Show("Plese enter a search cretia (Customers Name or Customers D.O.B)", "Search Customers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
        
        //Get if user sets date.
        private void dtpSearchDOP_ValueChanged(object sender, EventArgs e)
        {
            useDate = 1;
        }

        //Search method.
        private void searchSales()
        {
            List<int> SearchResults = new List<int>();
            string selectQuery;

            selectQuery = "SELECT Sales.SaleID, Sales.CustomerID, Customers.FirstName, Customers.LastName, Sales.StartDate " +
                          "FROM Sales " +
                          "JOIN Products ON Sales.ProductID = Products.ProductID " +
                          "JOIN Customers ON Sales.CustomerID = Customers.CustomerID " +
                          "WHERE " + GlobalVariables.searchCretia;

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();
                
                //read form table and fill in to list
                while (rdr.Read())
                {  
                 SearchResults.Add(int.Parse(rdr["SaleID"].ToString()));
                }

                if (rdr != null)
                    rdr.Close();
                conn.Close();

                
            }
            catch (Exception)
            {
                MessageBox.Show("Unsuccessful");
            }

            //If list is empty.
            if (SearchResults.Count == 0)
            {
                MessageBox.Show("Sorry no Sale Records where found", "No Result Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearchFirstName.Clear();
                txtSearchLastName.Clear();
                return;
            }
            //If list contains ID's and ask yser if thats what they will like to search for.
            else
            {
                var mbresults = MessageBox.Show("Sale Records Found at ID: " + string.Join(" , ", SearchResults) + Environment.NewLine + "Click OK to Display or Cancel", "Results Found", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //Create a new frmsale and invoke searchSaleResults(). 
                if (mbresults == DialogResult.OK)
                {
                    frmSales sResults = new frmSales();
                    sResults.Show();
                    sResults.Focus();
                    sResults.BringToFront();
                    sResults.Text = "Returned Search from Sales";
                    sResults.searchSaleResults();

                    //Close the Sale Form.
                    frmSales closeSale = (frmSales)Application.OpenForms["frmSales"];
                    closeSale.Close();
                    
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }

        }

    }
}
