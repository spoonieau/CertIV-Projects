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
using ACMEIICS.BusinessLogicLayer;
using ACMEIICS.DataAccessLayer;
using System.Globalization;

namespace ACMEIICS
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Genius;
            fillSales();
        }

        //Close Form.
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Show Products Search Form.
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmSalesSearch();
            frm1.Show(this);
        }
        
        //Add a Sale.
        private void btnAddSale_Click(object sender, EventArgs e)
        {
            GlobalVariables.selectedSalesID = 0;

            //Check to see if all feilds are full.
            if (String.IsNullOrEmpty(cbAddSaleCustomerID.Text))
            {
                MessageBox.Show("Please select a Customers ID.", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(cbAddSaleProduct.Text))
            {
                MessageBox.Show("Please select a Product.", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(cbAddSalePayable.Text))
            {
                MessageBox.Show("Please select a form of Payablity.", "Add Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                //Ask user if they want to Commit adding Customer Feilds to database.
                var result = MessageBox.Show("Commit to Adding new Sale attached to customer ID: " + cbAddSaleCustomerID.Text +
                    " to the DataBase?", "Add Sale", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //If user clicks yes.
                if (result == DialogResult.OK)
                {
                    int salCusID = cbAddSaleCustomerID.SelectedIndex + 1;
                    int salProID = cbAddSaleProduct.SelectedIndex + 1;
                    char salPay = char.Parse(cbAddSalePayable.Text.Substring(0, 1));

                    //Try and add string to database.
                    try
                    {
                        //Create a new instance of the Customers class.
                        Sales sale = new Sales(GlobalVariables.selectedSalesID, salCusID, salProID, salPay, dtpAddSale.Text);

                        string addSaleQuery;

                        //Set the Stored Procedure to use.
                        addSaleQuery = "sp_Sales_CreateSale ";

                        //Create a new instance of SqlConnection using the ConnectionManager class.  
                        SqlConnection conn = ConnectionManager.DatabaseConnection();

                        //Open the connection.
                        conn.Open();
                        //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                        SqlCommand cmd = new SqlCommand(addSaleQuery, conn);
                        //Set the command type to Stored Procedure
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Create a new ID
                        cmd.Parameters.AddWithValue("@NewSaleID", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.AddWithValue("@CustomerID", sale.CustomerID);
                        cmd.Parameters.AddWithValue("@ProductID", sale.ProductID);
                        cmd.Parameters.AddWithValue("@Payable", sale.Payable);
                        cmd.Parameters.AddWithValue("@StartDate", DateTime.ParseExact(sale.StartDate, "dd-MM-yyyy", CultureInfo.InvariantCulture));

                        //Commit to database. 
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        //Close the connection, initialize refreshCategories and initialize fillCategories method.   
                        conn.Close();
                        refreshSales();
                        fillSales();
                    }
                    //If try block fails display error to user.
                    catch (Exception)
                    {
                        MessageBox.Show("An Error has occoured trying to Commit new Sale to Customer ID: " + cbAddSaleCustomerID.Text +
                                        " to DataBase, Please conntact System Administrator.", "Error Adding new Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //initialize refreshCategories and initialize fillCategories method.
                        refreshSales();
                        fillSales();
                    }
                }
            }
        }

        //Update a Sale.
        private void btnSaleUpdate_Click_Click(object sender, EventArgs e)
        {
            //Check to see if all feilds are full.
            if (String.IsNullOrEmpty(cbUpdateSaleID.Text))
            {
                MessageBox.Show("Please select a SaleID", "Update Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(cbUpdateSaleProduct.Text))
            {
                MessageBox.Show("Please select a Product.", "Update Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(cbUpdateSalePayable.Text))
            {
                MessageBox.Show("Please select a Payable type.", "Update Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //Set GlobalVariables.selectedCategorieID to number selected in cbUpdateCategories.
                GlobalVariables.selectedSalesID = int.Parse(cbUpdateSaleID.Text);

                //Get first letter from payable selection.
                char updatePayable = char.Parse(cbUpdateSalePayable.Text.Substring(0, 1));

                //Convert date to string.
                string formatedDate = dtpUpdateSale.Value.ToString();

                //Ask user if they want to Commit updating Sale in database.
                var result = MessageBox.Show("Commit to Updateing Sale ID: " + cbUpdateSaleID.Text + " "
                    + " to the DataBase?", "Update Sale", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //If user clicks yes.
                if (result == DialogResult.OK)
                {
                    try
                    {
                        //Create a new instance of the Customers class.
                        Sales updateSale = new Sales(GlobalVariables.selectedSalesID, GlobalVariables.selectedCustomersID, cbUpdateSaleProduct.SelectedIndex + 1, updatePayable, formatedDate);

                        string updateSaleQuery;

                        updateSaleQuery = "sp_Sales_UpdateSale ";

                        //Create a new instance of SqlConnection using the ConnectionManager class.  
                        SqlConnection conn = ConnectionManager.DatabaseConnection();

                        //Open the connection.
                        conn.Open();
                        //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                        SqlCommand cmd = new SqlCommand(updateSaleQuery, conn);
                        //Set the command type to Stored Procedure
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@SaleID", updateSale.SaleID);
                        cmd.Parameters.AddWithValue("@CustomerID", updateSale.CustomerID);
                        cmd.Parameters.AddWithValue("@ProductID", updateSale.ProductID);
                        cmd.Parameters.AddWithValue("@Payable", updateSale.Payable);
                        cmd.Parameters.AddWithValue("@StartDate", Convert.ToDateTime(formatedDate));

                        //Commit to database. 
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        //Close the connection, initialize refreshCategories and initialize fillCategories method.   
                        conn.Close();
                        refreshSales();
                        fillSales();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        //MessageBox.Show("An Error has occoured trying to Commit update to Sale ID: " + cbUpdateSaleID.Text + " "
                        //+ " to DataBase, Please conntact System Administrator.", "Error Updateing Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //Initialize refreshSales and initialize fillSales method.   
                        refreshSales();
                        fillSales();
                    }

                }
            }
        }

        //Update Sale fields from stored data.
        private void cbUpdateSaleID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectQuerySales;

            //Set needed SQL Commands
            selectQuerySales = "SELECT Sales.SaleID, Sales.CustomerID, Customers.FirstName, Customers.LastName, Products.ProductName, Sales.Payable, Sales.StartDate " +
                "FROM Sales " +
                "JOIN Products ON Sales.ProductID = Products.ProductID " +
                "JOIN Customers ON Sales.CustomerID = Customers.CustomerID " +
                "WHERE Sales.SaleID = " + cbUpdateSaleID.Text;

            //Create a new instance of SqlConnection using the ConnectionManager class. 
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            //Try and read Sales Table from database. 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuerySales, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //Convert char data stored in Payable table to there full word.
                    string payType = "";

                    switch (rdr["Payable"].ToString())
                    {
                        case "F":
                            payType = "Fortnightly";
                            break;

                        case "M":
                            payType = "Monthly";
                            break;

                        case "Y":
                            payType = "Yearly";
                            break;

                        default:
                            payType = "";
                            break;
                    }

                    GlobalVariables.selectedCustomersID = int.Parse(rdr["CustomerID"].ToString());
                    cbUpdateSaleProduct.SelectedItem = (rdr["ProductName"].ToString());
                    cbUpdateSalePayable.SelectedItem = payType;
                    dtpUpdateSale.Value = DateTime.Parse(rdr["StartDate"].ToString());

                }
                conn.Close();//Close connection.

            }
            //Error if unable to connect to data base.
            catch (Exception)
            {
                MessageBox.Show("Connection test to Acme DataBase has failed!!" + Environment.NewLine + "Please conntact System Administrator",
                "DataBase Connection Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        //Delete Sale.
        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            //Check to see if cbDeleteCustomer is empty.
            if (String.IsNullOrEmpty(cbDeleteSaleId.Text))
            {
                MessageBox.Show("Please select a ID you wish to Delete", "Delete Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Set GlobalVariables.selectedSalesID to number selected in cbDeletCustomerID.
            GlobalVariables.selectedSalesID = int.Parse(cbDeleteSaleId.Text);

            //Ask user if they want to Commit deleting the Sale in database.
            var result = MessageBox.Show("Commit to Deleting Sale at ID: " + cbDeleteSaleId.Text + " ?", "Delete Sale", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //If user clicks yes.
            if (result == DialogResult.OK)
            {
                //Try and delete string in database.
                try
                {
                    //Create a new instance of the Customer class.
                    Sales deleteSale = new Sales(GlobalVariables.selectedSalesID, 0, 0, '\0', null);

                    string deleteSaleQuery;

                    //Set the Stored Procedure to use.
                    deleteSaleQuery = "sp_Sales_DeleteSale ";

                    //Create a new instance of SqlConnection using the ConnectionManager class.  
                    SqlConnection conn = ConnectionManager.DatabaseConnection();

                    //Open the connection.
                    conn.Open();
                    //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                    SqlCommand cmd = new SqlCommand(deleteSaleQuery, conn);
                    //Set the command type to Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Set the paramaters.
                    cmd.Parameters.AddWithValue("@SaleID", deleteSale.SaleID);

                    //Commit to database. 
                    cmd.Transaction = conn.BeginTransaction();
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();

                    //Close the connection, initialize refreshCategories and initialize fillCategories method.   
                    conn.Close();
                    refreshSales();
                    fillSales();


                }
                //If try block fails display error to user.
                catch (Exception)
                {
                    MessageBox.Show("An Error has occoured trying to Commit delete Sale at ID: " + cbDeleteSaleId.Text +
                                        " in the DataBase, Please conntact System Administrator.", "Error Deleting Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    refreshSales();
                    fillSales();

                }
            }
        }

        //Read and fill lvSales method.
        private void fillSales()
        {
            string selectQuerySales;

            //Set needed SQL Commands
            selectQuerySales = "SELECT Sales.SaleID, Sales.CustomerID, Customers.FirstName, Customers.LastName, Products.ProductName, Sales.Payable, Products.YearlyPremium, Sales.StartDate " +
                "FROM Sales " +
                "JOIN Products ON Sales.ProductID = Products.ProductID " +
                "JOIN Customers ON Sales.CustomerID = Customers.CustomerID ";

            //Create a new instance of SqlConnection using the ConnectionManager class. 
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            //Try and read Sales Table from database. 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuerySales, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //Get customers first and last name and combind to make full name.
                    string customerFirstName = (rdr["FirstName"].ToString());
                    string customerLastName = (rdr["LastName"].ToString());
                    string customerFullName = customerFirstName + " " + customerLastName;

                    //Updated 24/5/17 to get paymant ammount pre Fortnightly, Monthly, Yearly.
                    //Convert char data stored in Payable table to there full word.

                    string payAmmount = "";
                    string payType = "";

                    switch (Convert.ToChar(rdr["Payable"]))
                    {
                        case 'F':
                            payType = "Fortnightly";
                            payAmmount = "$" + ((Convert.ToDecimal(rdr["YearlyPremium"])) / 26).ToString("#.##") + " A Fortnight";
                            break;
                        case 'M':
                            payType = "Monthly";
                            payAmmount = "$" + ((Convert.ToDecimal(rdr["YearlyPremium"])) / 12).ToString("#.##") + " A Month";
                            break;
                        case 'Y':
                            payType = "Yearly";
                            payAmmount = "$" + (Convert.ToDecimal(rdr["YearlyPremium"])).ToString("#.##") + " A Year";
                            break;
                    }

                   


                    //Format date to AUS format and remove time stamp.
                    string formatedDate = String.Format("{0:dd/MM/yyyy}", rdr["StartDate"]);

                    ListViewItem salListView = new ListViewItem(rdr["SaleID"].ToString());
                    salListView.SubItems.Add(rdr["CustomerID"].ToString());
                    salListView.SubItems.Add(customerFullName);
                    salListView.SubItems.Add(rdr["ProductName"].ToString());
                    salListView.SubItems.Add(payType);
                    salListView.SubItems.Add(payAmmount);  //Added 24/5/17
                    salListView.SubItems.Add(formatedDate);
                    lvSales.Items.Add(salListView);
                    cbDeleteSaleId.Items.Add(rdr["SaleID"].ToString());
                    cbUpdateSaleID.Items.Add(rdr["SaleID"].ToString());
                }
                conn.Close();//Close connection.

                fillCbAddDelete();
                fillCbAddUpdateProducts();
            }
            //Error if unable to connect to data base.
            catch (Exception)
            {
                MessageBox.Show("Connection test to Acme DataBase has failed!!" + Environment.NewLine + "Please conntact System Administrator",
                  "DataBase Connection Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Read and fill needed combo boxes method.
        private void fillCbAddDelete()
        {
            string selectQuerySales;

            //Set needed SQL Commands
            selectQuerySales = "SELECT Customers.CustomerID FROM Customers";

            //Create a new instance of SqlConnection using the ConnectionManager class. 
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            //Try and read CustomerID Table from database. 
            conn.Open();
            SqlCommand cmd = new SqlCommand(selectQuerySales, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cbAddSaleCustomerID.Items.Add(rdr["CustomerID"].ToString());
            }
            conn.Close();//Close connection.
        }
        
        //Read and fill needed combo boxes method.
        private void fillCbAddUpdateProducts()
        {
            string selectQueryProducts;

            //Set needed SQL Commands
            selectQueryProducts = "SELECT Products.ProductName FROM Products";

            //Create a new instance of SqlConnection using the ConnectionManager class. 
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            //Try and read ProductNames Table from database. 
            conn.Open();
            SqlCommand cmdP = new SqlCommand(selectQueryProducts, conn);
            rdr = cmdP.ExecuteReader();
            while (rdr.Read())
            {
                cbAddSaleProduct.Items.Add(rdr["ProductName"].ToString());
                cbUpdateSaleProduct.Items.Add(rdr["ProductName"].ToString());

            }
            conn.Close();//Close connection.
        }

        //Reset and clear required feilds.
        private void refreshSales()
        {
            lvSales.Items.Clear();
            cbAddSaleCustomerID.ResetText();
            cbAddSaleCustomerID.Items.Clear();
            cbAddSaleProduct.ResetText();
            cbAddSaleProduct.Items.Clear();
            cbAddSalePayable.ResetText();
            cbAddSalePayable.Items.Clear();

            cbUpdateSaleID.ResetText();
            cbUpdateSaleID.Items.Clear();
            cbUpdateSaleID.ResetText();
            cbUpdateSaleID.Items.Clear();
            cbUpdateSaleProduct.ResetText();
            cbUpdateSaleProduct.Items.Clear();
            cbUpdateSalePayable.ResetText();

            cbDeleteSaleId.ResetText();
            cbDeleteSaleId.Items.Clear();
        }

        ////Close Form.
        private void btnSaleReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Search Sales method.
        public void searchSaleResults()
        {
            refreshSales();

            string selectQuerySales;

            //Set needed SQL Commands
            selectQuerySales = "SELECT Sales.SaleID, Sales.CustomerID, Customers.FirstName, Customers.LastName, Products.ProductName, Sales.Payable, Sales.StartDate " +
                "FROM Sales " +
                "JOIN Products ON Sales.ProductID = Products.ProductID " +
                "JOIN Customers ON Sales.CustomerID = Customers.CustomerID " +
                "WHERE " + GlobalVariables.searchCretia;

            //Create a new instance of SqlConnection using the ConnectionManager class. 
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            //Try and read Sales Table from database. 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuerySales, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //Get customers first and last name and combind to make full name.
                    string customerFirstName = (rdr["FirstName"].ToString());
                    string customerLastName = (rdr["LastName"].ToString());
                    string customerFullName = customerFirstName + " " + customerLastName;

                    //Convert char data stored in Payable table to there full word.
                    string payType = "";
                    switch (Convert.ToChar(rdr["Payable"]))
                    {
                        case 'F':
                            payType = "Fortnightly";
                            break;
                        case 'M':
                            payType = "Monthly";
                            break;
                        case 'Y':
                            payType = "Yearly";
                            break;
                    }

                    //Format date to AUS format and remove time stamp.
                    string formatedDate = String.Format("{0:dd/MM/yyyy}", rdr["StartDate"]);

                    ListViewItem salListView = new ListViewItem(rdr["SaleID"].ToString());
                    salListView.SubItems.Add(rdr["CustomerID"].ToString());
                    salListView.SubItems.Add(customerFullName);
                    salListView.SubItems.Add(rdr["ProductName"].ToString());
                    salListView.SubItems.Add(payType);
                    salListView.SubItems.Add(formatedDate);
                    lvSales.Items.Add(salListView);
                    cbDeleteSaleId.Items.Add(rdr["SaleID"].ToString());
                    cbUpdateSaleID.Items.Add(rdr["SaleID"].ToString());
                }
                conn.Close();//Close connection.

                fillCbAddDelete();
                fillCbAddUpdateProducts();
            }
            //Error if unable to connect to data base.
            catch (Exception)
            {
                MessageBox.Show("Connection test to Acme DataBase has failed!!" + Environment.NewLine + "Please conntact System Administrator",
                  "DataBase Connection Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
