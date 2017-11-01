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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Genius;
            fillProducts();
        }

        //Add a Product.
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            GlobalVariables.selectedProductsID = 0;

            //Check to see if all feilds are full.
            if (String.IsNullOrEmpty(txtAddProduct.Text))
            {
                MessageBox.Show("Please enter new Product Name.", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(cbProductType.Text))
            {
                MessageBox.Show("Please Select a Product Type.", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(txtPremium.Text))
            {
                MessageBox.Show("Please Enter a new Premium.", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //Ask user if they want to Commit adding Product Feilds to database.
                var result = MessageBox.Show("Commit to Adding new Product " + txtAddProduct.Text +
                    " to the DataBase?", "Add Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //If user clicks yes.
                if (result == DialogResult.OK)
                {
                    Decimal formattedMoney = Decimal.Parse(txtPremium.Text);

                    //Try and add string to database.
                    try
                    {
                        //Create a new instance of the Products class.
                        Products product = new Products(GlobalVariables.selectedProductsID, cbProductType.SelectedIndex + 1, txtAddProduct.Text, formattedMoney);

                        string addProductrQuery;

                        //Set the Stored Procedure to use.
                        addProductrQuery = "sp_Products_CreateProduct ";

                        //Create a new instance of SqlConnection using the ConnectionManager class.  
                        SqlConnection conn = ConnectionManager.DatabaseConnection();

                        //Open the connection.
                        conn.Open();
                        //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                        SqlCommand cmd = new SqlCommand(addProductrQuery, conn);
                        //Set the command type to Stored Procedure
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Create a new ID
                        cmd.Parameters.AddWithValue("@NewProductID", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.AddWithValue("@ProductTypeID", product.ProductTypeID);
                        cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                        cmd.Parameters.AddWithValue("@YearlyPremium", product.YearlyPremium);

                        //Commit to database. 
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        //Close the connection, initialize refreshProducts and initialize fillProducts methods.   
                        conn.Close();
                        refreshProducts();
                        fillProducts();
                    }
                    //If try block fails display error to user.
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                        //MessageBox.Show("An Error has occoured trying to Commit " + txtAddProduct.Text +
                           //             " to DataBase, Please conntact System Administrator.", "Error Adding new Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Initialize refreshProducts and initialize fillProducts methods.
                        refreshProducts();
                        fillProducts();
                    }
                }

            }
        }

        //Update a Product.
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            //Check to see if all feilds are full.
            if (String.IsNullOrEmpty(txtUpdateProduct.Text))
            {
                MessageBox.Show("Please enter updated Product Name.", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(cbUpdateProductType.Text))
            {
                MessageBox.Show("Please slected updated Product Type", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(txtUpdatePremium.Text))
            {
                MessageBox.Show("Please enter updated Product Premium", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Decimal formattedMoney = Decimal.Parse(txtUpdatePremium.Text);
                //Set GlobalVariables.selectedCategorieID to number selected in cbUpdateProductId.
                GlobalVariables.selectedProductsID = int.Parse(cbUpdateProductId.Text);

                //Ask user if they want to Commit updating product in database.
                var result = MessageBox.Show("Commit to Updateing Product ID: " + cbUpdateProductId.Text + " "
                    + txtUpdateProduct.Text + " to the DataBase?", "Update Customer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //If user clicks yes.
                if (result == DialogResult.OK)
                {
                    try
                    {
                        //Create a new instance of the Customers class.
                        Products updateProducts = new Products(GlobalVariables.selectedProductsID, cbUpdateProductType.SelectedIndex + 1, txtUpdateProduct.Text, formattedMoney);

                        string updateProductsQuery;

                        updateProductsQuery = "sp_Products_UpdateProduct ";

                        //Create a new instance of SqlConnection using the ConnectionManager class.  
                        SqlConnection conn = ConnectionManager.DatabaseConnection();

                        //Open the connection.
                        conn.Open();
                        //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                        SqlCommand cmd = new SqlCommand(updateProductsQuery, conn);
                        //Set the command type to Stored Procedure
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ProductID", updateProducts.ProductID);
                        cmd.Parameters.AddWithValue("@ProductTypeID", updateProducts.ProductTypeID);
                        cmd.Parameters.AddWithValue("@ProductName", updateProducts.ProductName);
                        cmd.Parameters.AddWithValue("@YearlyPremium", updateProducts.YearlyPremium);


                        //Commit to database. 
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        //Close the connection, initialize refreshProducts and initialize fillProducts methods.   
                        conn.Close();
                        refreshProducts();
                        fillProducts();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An Error has occoured trying to Commit update to Products ID: " + cbUpdateProductId.Text + " "
                        + txtUpdateProduct.Text + " to DataBase, Please conntact System Administrator.", "Error Updateing Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //Initialize refreshProducts and initialize fillfillProducts methods.
                        refreshProducts();
                        fillProducts();
                    }

                }
            }
        }

        //Update Product fields from stored data.
        private void cbUpdateProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectQueryProducts;

            //Set needed SQL Commands
            selectQueryProducts = "SELECT Products.ProductID, ProductTypes.ProductType, Products.ProductName, Products.YearlyPremium " +
                "FROM Products JOIN ProductTypes ON Products.ProductTypeID = ProductTypes.ProductTypeID " +
                "WHERE Products.ProductID = " + cbUpdateProductId.Text;


            //Create a new instance of SqlConnection using the ConnectionManager class. 
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            //Try and read Customer Table from database. 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQueryProducts, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtUpdateProduct.Text = (rdr["ProductName"].ToString());
                    cbUpdateProductType.SelectedItem = (rdr["ProductType"].ToString());
                    txtUpdatePremium.Text = (rdr["YearlyPremium"].ToString());
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

        //Check to see if Product can be Deleted, if so delete
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int canDelete = 0;

            //Check to see if cbDeleteProduct is empty.
            if (String.IsNullOrEmpty(cbDeleteProduct.Text))
            {
                MessageBox.Show("Please select a ProductID you wish to Delete", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Set GlobalVariables.selectedProductsID to number selected in cbDeletCustomerID.
            GlobalVariables.selectedProductsID = int.Parse(cbDeleteProduct.Text);

            //Ask user if they want to Commit deleting the Product in database.
            var result = MessageBox.Show("Commit to Deleting Product at ID: " + cbDeleteProduct.Text + " ?", "Delete Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //If user clicks yes.
            if (result == DialogResult.OK)
            {
                //Try and see if ID can be delected.
                try
                {
                    //Create a new instance of the Product class.
                    Products deleteProduct = new Products(GlobalVariables.selectedProductsID, 0, null, 0);

                    string deleteProductQuery;

                    //Set the Stored Procedure to use.
                    deleteProductQuery = "sp_Products_AllowDeleteProduct ";

                    //Create a new instance of SqlConnection using the ConnectionManager class.  
                    SqlConnection conn = ConnectionManager.DatabaseConnection();

                    //Open the connection.
                    conn.Open();
                    //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                    SqlCommand cmd = new SqlCommand(deleteProductQuery, conn);
                    //Set the command type to Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Set the paramaters.
                    cmd.Parameters.AddWithValue("@ProductID", deleteProduct.ProductID);
                    cmd.Parameters.Add("@RecordCount", SqlDbType.Int);
                    cmd.Parameters["@RecordCount"].Direction = ParameterDirection.Output;

                    //Get the value of @RecordCount. 
                    cmd.ExecuteNonQuery();
                    canDelete = (int)cmd.Parameters["@RecordCount"].Value;

                    //Close the connection.    
                    conn.Close();
                }
                //If try block fails display error to user.
                catch (Exception)
                {
                    MessageBox.Show("An Error has occoured trying to Commit delete Product at ID:" + cbDeleteProduct.Text +
                                    " in the DataBase, Please conntact System Administrator.", "Error Deleting Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    refreshProducts();
                    fillProducts();
                }

                if (canDelete == 1)
                {
                    MessageBox.Show("Sorry unable to delete Product at ID: " + GlobalVariables.selectedProductsID.ToString() +
                         Environment.NewLine + "The Product is attached to a record", "Unable to Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (canDelete == 0)
                {
                    deleteProduct();
                }
            }

        }
    
        //Close Form.
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Show Products Search Form.
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmProductsSearch();
            frm1.ShowDialog(this);
        }

        //Close Form.
        private void btnProductsReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * Required Methods. 
         */

        //Read and fill lvProducts method.
        private void fillProducts()
        {
            string selectQueryProducts;

            //Set needed SQL Commands
            selectQueryProducts = "SELECT Products.ProductID, ProductTypes.ProductType, Products.ProductName, Products.YearlyPremium " +
                "FROM Products JOIN ProductTypes ON Products.ProductTypeID = ProductTypes.ProductTypeID";


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
                    
                    ListViewItem proListView = new ListViewItem(rdr["ProductID"].ToString());
                    proListView.SubItems.Add(rdr["ProductType"].ToString());
                    proListView.SubItems.Add(rdr["ProductName"].ToString());
                    proListView.SubItems.Add("$" + Convert.ToDecimal(rdr["YearlyPremium"]).ToString("#.##")); // updated 24/5/17
                    lvProducts.Items.Add(proListView);
                    cbUpdateProductId.Items.Add(rdr["ProductID"].ToString());
                    cbDeleteProduct.Items.Add(rdr["ProductID"].ToString());
                }
                conn.Close();//Close connection.

                fillcbAddUpdateProduct(); //Initialize method fillcbAddUpdateProduct.
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
        
        //Read and fill needed combo boxes method.
        private void fillcbAddUpdateProduct()
        {
            string selectQueryProducts;

            //Set needed SQL Commands
            selectQueryProducts = "SELECT ProductTypes.ProductTypeID, ProductTypes.ProductType FROM ProductTypes";

            //Create a new instance of SqlConnection using the ConnectionManager class. 
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            conn.Open();
            SqlCommand cmd = new SqlCommand(selectQueryProducts, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                 cbProductType .Items.Add(rdr["ProductType"].ToString());
                 cbUpdateProductType.Items.Add(rdr["ProductType"].ToString());
            }
            conn.Close();//Close connection.
        }

        //Reset and clear required feilds.
        private void refreshProducts()
        {
            lvProducts.Items.Clear();
            txtAddProduct.Clear();
            txtPremium.Clear();
            cbProductType.ResetText();
            cbProductType.Items.Clear();

            txtUpdatePremium.Clear();
            txtUpdateProduct.Clear();
            cbUpdateProductId.ResetText();
            cbUpdateProductId.Items.Clear();
            cbUpdateProductType.ResetText();
            cbUpdateProductType.Items.Clear();

            cbDeleteProduct.ResetText();
            cbDeleteProduct.Items.Clear();
        }

        //Delete Customer method.
        private void deleteProduct()
        {
                //Try and delete string in database.
                try
                {
                    //Create a new instance of the Product class.
                    Products deleteProduct = new Products(GlobalVariables.selectedProductsID, 0, null, 0);

                    string deleteProductQuery;

                    //Set the Stored Procedure to use.
                    deleteProductQuery = "sp_Products_DeleteProduct ";

                    //Create a new instance of SqlConnection using the ConnectionManager class.  
                    SqlConnection conn = ConnectionManager.DatabaseConnection();

                    //Open the connection.
                    conn.Open();
                    //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                    SqlCommand cmd = new SqlCommand(deleteProductQuery, conn);
                    //Set the command type to Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Set the paramaters.
                    cmd.Parameters.AddWithValue("@ProductID", deleteProduct.ProductID);

                    //Commit to database. 
                    cmd.Transaction = conn.BeginTransaction();
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();

                    //Close the connection, initialize refreshProducts and initialize fillProducts methods.   
                    conn.Close();

                    refreshProducts();
                    fillProducts();

                }
                //If try block fails display error to user.
                catch (Exception)
                {
                    MessageBox.Show("An Error has occoured trying to Commit delete Product at ID: " + cbUpdateProductId.Text +
                                        " in the DataBase, Please conntact System Administrator.", "Error Deleting Product", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Initialize refreshProducts and initialize fillProducts methods.
                    refreshProducts();
                    fillProducts();
                }
            }

        //Search Product method.
        public void searchProductResults()
        {
            refreshProducts();

            string selectQueryProducts;

            //Set needed SQL Commands
            selectQueryProducts = "SELECT Products.ProductID, ProductTypes.ProductType, Products.ProductName, Products.YearlyPremium " +
                "FROM Products JOIN ProductTypes ON Products.ProductTypeID = ProductTypes.ProductTypeID " +
                "WHERE " + GlobalVariables.searchCretia;


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

                    ListViewItem proListView = new ListViewItem(rdr["ProductID"].ToString());
                    proListView.SubItems.Add(rdr["ProductType"].ToString());
                    proListView.SubItems.Add(rdr["ProductName"].ToString());
                    proListView.SubItems.Add("$" + rdr["YearlyPremium"].ToString());
                    lvProducts.Items.Add(proListView);
                    cbUpdateProductId.Items.Add(rdr["ProductID"].ToString());
                    cbDeleteProduct.Items.Add(rdr["ProductID"].ToString());
                }
                conn.Close();//Close connection.

                fillcbAddUpdateProduct(); //Initialize method fillcbAddUpdateProduct.
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
    }
}

