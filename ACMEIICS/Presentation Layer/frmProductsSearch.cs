using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACMEIICS.BusinessLogicLayer;
using ACMEIICS.DataAccessLayer;
using System.Data.SqlClient;

namespace ACMEIICS
{
    public partial class frmProductsSearch : Form
    {
        public frmProductsSearch()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Genius;
            fillsearchproducts();
        }

        private void btnProductSearchReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbSerarchType.Text) && String.IsNullOrEmpty(txtSearchPremium.Text))
            {
                GlobalVariables.searchCretia = null;

                // Check to see what ceritra the user will search by and set up string for sqlQuery
                var result = MessageBox.Show("Search via Product Type " + cbSerarchType.Text + "?", "Search Products", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //Search By Product Type
                if (result == DialogResult.OK)
                {
                    GlobalVariables.searchCretia = "ProductTypes.ProductType = " + "'" + cbSerarchType.Text + "'";
                    searchProducts();
                }
                else
                {
                    return;
                }
                return;
            }
            //Search by Premium Ammount.
            else if (String.IsNullOrEmpty(cbSerarchType.Text) && !String.IsNullOrEmpty(txtSearchPremium.Text))
            {
                var result = MessageBox.Show("Search via Yearly Premium " + "$" + txtSearchPremium.Text + "?", "Search Products", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    GlobalVariables.searchCretia = "Products.YearlyPremium = " + "'" + txtSearchPremium.Text + "'";
                    searchProducts();
                }
                else
                {
                    return;
                }
                return;
            }
            //If nothing is filled or selected.
            else
            {
                MessageBox.Show("Plese enter a search cretia (Product Type or Yearly Premium)", "Search Customers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
        }

        //Fill cbSerarchType.
        private void fillsearchproducts()
        {
            string selectQueryProducts;

            //Set needed SQL Commands


            //selectQueryProducts = "SELECT Products.ProductID, ProductTypes.ProductType, Products.ProductName, Products.YearlyPremium " +
            // "FROM Products JOIN ProductTypes ON Products.ProductTypeID = ProductTypes.ProductTypeID";

            selectQueryProducts = "SELECT ProductTypes.ProductTypeID, ProductTypes.ProductType From ProductTypes";

            //Create a new instance of SqlConnection using the ConnectionManager class. 
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            //Try and read Porducts Table from database. 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQueryProducts, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cbSerarchType.Items.Add(rdr["ProductType"].ToString());
                }
                conn.Close();//Close connection.

            }
            //Error if unable to connect to data base.
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Connection test to Acme DataBase has failed!!" + Environment.NewLine + "Please conntact System Administrator",
                    "DataBase Connection Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Search method.
        private void searchProducts()
        {

            List<int> SearchResults = new List<int>();
            string selectQuery;

            selectQuery = "SELECT Products.ProductID, ProductTypes.ProductType, Products.ProductName, Products.YearlyPremium " +
               "FROM Products JOIN ProductTypes ON Products.ProductTypeID = ProductTypes.ProductTypeID " +
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
                    SearchResults.Add(int.Parse(rdr["ProductID"].ToString()));
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
                MessageBox.Show("Sorry no Product Records where found", "No Result Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbSerarchType.ResetText();
                txtSearchPremium.Clear();
                return;
            }
            //If list contains ID's and ask yser if thats what they will like to search for.
            else
            {
                var mbresults = MessageBox.Show("Product Records Found at ID: " + string.Join(" , ", SearchResults) + Environment.NewLine + "Click OK to Display or Cancel", "Results Found", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //Create a new frmsale and invoke searchSaleResults(). 
                if (mbresults == DialogResult.OK)
                {
                    frmProducts pResults = new frmProducts();
                    pResults.Show();
                    pResults.Focus();
                    pResults.BringToFront();
                    pResults.Text = "Returned Search from Products";
                    pResults.searchProductResults();
                    this.Close();

                    //Close the Sale Form.
                    frmProducts closeProducts = (frmProducts)Application.OpenForms["frmProducts"];
                    closeProducts.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }

    }
}
