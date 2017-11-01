using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACMEIICS.DataAccessLayer;
using System.Data.SqlClient;
using ACMEIICS.BusinessLogicLayer;

namespace ACMEIICS
{
    public partial class frmCustomerSearch : Form
    {
        int useDate = 0;

        public frmCustomerSearch()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Genius;
            
        }

        private void btnCustomerSearchReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
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
                    searchCustomer();
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

                var result = MessageBox.Show("Search via Customers D.O.B " + dtpCustomerSearch.Text + "?", "Search Sales", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {

                    string formatteddate = dtpCustomerSearch.Value.ToShortDateString().ToString();
                    GlobalVariables.searchCretia = "Customers.BirthDate = '" + formatteddate + "'";
                    searchCustomer();
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
        private void dtpCustomerSearch_ValueChanged(object sender, EventArgs e)
        {
            useDate = 1;
        }

        //Search method.
        private void searchCustomer()
        {
            List<int> SearchResults = new List<int>();
            string selectQuery;

            selectQuery = "SELECT Customers.CustomerID, Categories.Category, Customers.FirstName, Customers.LastName, Customers.Address," +
                " Customers.Suburb, Customers.State, Customers.PostCode, Customers.Gender, Customers.BirthDate" +
                " FROM Customers Join Categories ON Customers.CategoryID = Categories.CategoryID" +
                " WHERE " + GlobalVariables.searchCretia;

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
                    SearchResults.Add(int.Parse(rdr["CustomerID"].ToString()));
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
                MessageBox.Show("Sorry no Customer Records where found", "No Result Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearchFirstName.Clear();
                txtSearchLastName.Clear();
                return;
            }
            //If list contains ID's and ask yser if thats what they will like to search for.
            else
            {
                var mbresults = MessageBox.Show("Customer Records Found at ID: " + string.Join(" , ", SearchResults) + Environment.NewLine + "Click OK to Display or Cancel", "Results Found", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //Create a new frmsale and invoke searchSaleResults(). 
                if (mbresults == DialogResult.OK)
                {
                    frmCustomers cResults = new frmCustomers();
                    cResults.Show();
                    cResults.Focus();
                    cResults.BringToFront();
                    cResults.Text = "Returned Search from Customers";
                    cResults.searchCustomerResults();
                    this.Close();

                    //Close the Sale Form.
                    frmCustomers closeCustomers = (frmCustomers)Application.OpenForms["frmCustomers"];
                    closeCustomers.Close();
                }
                else
                {
                    this.Close();
                }
            }

        }
    }
}
