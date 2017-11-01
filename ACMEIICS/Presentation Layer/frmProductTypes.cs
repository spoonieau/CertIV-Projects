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

namespace ACMEIICS
{
    public partial class frmProductTypes : Form
    {
        public frmProductTypes()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Genius;
            fillProductTypes();
        }

        //Add a ProductType.
        private void btnAddProductType_Click(object sender, EventArgs e)
        {
            GlobalVariables.selectedProductTypeID = 0;

            //Check to see if all feilds are full.
            if (String.IsNullOrEmpty(txtAddProductType.Text))
            {
                MessageBox.Show("Please Enter a new Product Type .", "Add Product Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //Ask user if they want to Commit adding Product Type Field to database.
                var result = MessageBox.Show("Commit to Adding new Product Type " + txtAddProductType.Text +
                    " to the DataBase?", "Add Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //If user clicks yes.
                if (result == DialogResult.OK)
                { 
                    //Try and add string to database.
                    try
                    {
                        //Create a new instance of the ProductType class.
                        ProductTypes productType = new ProductTypes(GlobalVariables.selectedProductTypeID, txtAddProductType.Text);

                        string addProductTypeQuery;

                        //Set the Stored Procedure to use.
                        addProductTypeQuery = "sp_ProductTypes_CreateProductType ";

                        //Create a new instance of SqlConnection using the ConnectionManager class.  
                        SqlConnection conn = ConnectionManager.DatabaseConnection();

                        //Open the connection.
                        conn.Open();
                        //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                        SqlCommand cmd = new SqlCommand(addProductTypeQuery, conn);
                        //Set the command type to Stored Procedure
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Create a new ID
                        cmd.Parameters.AddWithValue("@NewProductTypeID", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.AddWithValue("@ProductType", productType.ProductType);
                        
                        //Commit to database. 
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        //Close the connection, initialize refreshProductTypes and initialize fillProductTypes methods.   
                        conn.Close();

                        refreshProductTypes();
                        fillProductTypes();
                    }
                    //If try block fails display error to user.
                    catch (Exception)
                    {
                        MessageBox.Show("An Error has occoured trying to Commit " + txtAddProductType.Text +
                                        " to DataBase, Please conntact System Administrator.", "Error Adding new Product Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        //initialize refreshProductsTypes and initialize fillProductTypes methods.
                        refreshProductTypes();
                        fillProductTypes();
                    }
                }

            }
        }

        //Update a ProductType.
        private void btnUpdateProductType_Click(object sender, EventArgs e)
        {
            //Check to see if all feilds are full.
            if (String.IsNullOrEmpty(txtUpdateProductType.Text))
            {
                MessageBox.Show("Please enter updated Product Type", "Update Product Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Set GlobalVariables.selectedProductID to number selected in cbUpdateProductTypeId.
                GlobalVariables.selectedProductTypeID = int.Parse(cbUpdateProductType.Text);

                //Ask user if they want to Commit updating productType in database.
                var result = MessageBox.Show("Commit to Updating Product Type ID: " + cbUpdateProductType.Text + " "
                      + " to the DataBase?", "Update Customer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //If user clicks yes.
                if (result == DialogResult.OK)
                {
                    try
                    {
                        //Create a new instance of the ProductTypes class.
                        ProductTypes updateProductType = new ProductTypes(GlobalVariables.selectedProductTypeID, txtUpdateProductType.Text);

                        string updateProductTypeQuery;

                        updateProductTypeQuery = "sp_ProductTypes_UpdateProductType ";

                        //Create a new instance of SqlConnection using the ConnectionManager class.  
                        SqlConnection conn = ConnectionManager.DatabaseConnection();

                        //Open the connection.
                        conn.Open();
                        //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                        SqlCommand cmd = new SqlCommand(updateProductTypeQuery, conn);
                        //Set the command type to Stored Procedure
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ProductTypeID", updateProductType.ProductTypeID);
                        cmd.Parameters.AddWithValue("@ProductType", updateProductType.ProductType);

                        //Commit to database. 
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        //Close the connection, initialize refreshProductTypes and initialize fillProductTypes methods.   
                        conn.Close();
                        refreshProductTypes();
                        fillProductTypes();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An Error has occoured trying to Commit update to Product Type ID: " + cbUpdateProductType.Text + " "
                        + txtUpdateProductType.Text + " to DataBase, Please conntact System Administrator.", "Error Updateing Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //initialize refreshCategories and initialize refreshProductTypes and initialize fillProductTypes methods.
                        refreshProductTypes();
                        fillProductTypes();
                    }
                }
            }
        }

        //Update ProductType fields from stored data.
        private void cbUpdateProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectQueryProductTypes;

            //Set needed SQL Commands
            selectQueryProductTypes = "SELECT ProductTypes.ProductTypeID, ProductTypes.ProductType  "+
                "FROM ProductTypes " +
                "WHERE ProductTypes.ProductTypeID = " + cbUpdateProductType.Text;


            //Create a new instance of SqlConnection using the ConnectionManager class. 
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            //Try and read Customer Table from database. 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQueryProductTypes, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtUpdateProductType.Text = (rdr["ProductType"].ToString());
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

        //Check to see if ProductType can be Deleted, if so delete
        private void btnDeleteProductType_Click(object sender, EventArgs e)
        {
            int canDelete = 0;

            //Check to see if cbDeleteProductType is empty.
            if (String.IsNullOrEmpty(cbDeleteProductType.Text))
            {
                MessageBox.Show("Please select a ProductTypeID you wish to Delete", "Delete Product Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Set GlobalVariables.selectedProductsID to number selected in cbDeleteProductType.
            GlobalVariables.selectedProductTypeID = int.Parse(cbDeleteProductType.Text);

            //Ask user if they want to Commit deleting the Product in database.
            var result = MessageBox.Show("Commit to Deleting ProductType at ID: " + cbDeleteProductType.Text + " ?", "Delete Product Type", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //If user clicks yes.
            if (result == DialogResult.OK)
            {
                //Try and see if ID can be delected.
                try
                {
                    //Create a new instance of the ProductTypes class.
                    ProductTypes deleteProductType = new ProductTypes(GlobalVariables.selectedProductTypeID, null);

                    string deleteProductTypeQuery;

                    //Set the Stored Procedure to use.
                    deleteProductTypeQuery = "sp_ProductTypes_AllowDeleteProductType ";

                    //Create a new instance of SqlConnection using the ConnectionManager class.  
                    SqlConnection conn = ConnectionManager.DatabaseConnection();

                    //Open the connection.
                    conn.Open();
                    //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                    SqlCommand cmd = new SqlCommand(deleteProductTypeQuery, conn);
                    //Set the command type to Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Set the paramaters.
                    cmd.Parameters.AddWithValue("@ProductTypeID", deleteProductType.ProductTypeID);
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
                    MessageBox.Show("An Error has occoured trying to Commit delete ProductType at ID:" + cbDeleteProductType.Text +
                                    " in the DataBase, Please conntact System Administrator.", "Error Deleting ProductType", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    refreshProductTypes();
                    fillProductTypes();
                }

                
                if (canDelete == 1)
                {
                    MessageBox.Show("Sorry unable to delete ProductType at ID: " + GlobalVariables.selectedProductTypeID.ToString() +
                         Environment.NewLine + "The Product is attached to a record", "Unable to Delete ProductType", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (canDelete == 0)
                {
                    deleteProductType();
                }
            }

        }

        //Close Form.
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Close Form.
        private void btnProductTypeReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Read and fill lvProductsTypes method.
        private void fillProductTypes()
        {
            string selectQueryProductsTypes;

            //Set needed SQL Commands
            selectQueryProductsTypes = "SELECT ProductTypes.ProductTypeID, ProductTypes.ProductType FROM ProductTypes ";

            //Create a new instance of SqlConnection using the ConnectionManager class. 
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            //Try and read Customer Table from database. 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQueryProductsTypes, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    
                    ListViewItem proTypListView = new ListViewItem(rdr["ProductTypeID"].ToString());
                    proTypListView.SubItems.Add(rdr["ProductType"].ToString());
                    lvProductTypes.Items.Add(proTypListView);
                    cbUpdateProductType.Items.Add(rdr["ProductTypeID"].ToString());
                    cbDeleteProductType.Items.Add(rdr["ProductTypeID"].ToString());
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

        //Read and fill needed combo boxes method
        private void refreshProductTypes()
        {
            lvProductTypes.Items.Clear();
            txtAddProductType.Clear();
            cbUpdateProductType.ResetText();
            cbUpdateProductType.Items.Clear();
        }

        //Delete Product Type method.
        private void deleteProductType()
        {
            //Try and delete string in database.
            try
            {
                //Create a new instance of the ProductType class.
                ProductTypes deleteProductType = new ProductTypes(GlobalVariables.selectedProductTypeID, null);

                string deleteProductTypeQuery;

                //Set the Stored Procedure to use.
                deleteProductTypeQuery = "sp_ProductTypes_DeleteProductType ";

                //Create a new instance of SqlConnection using the ConnectionManager class.  
                SqlConnection conn = ConnectionManager.DatabaseConnection();

                //Open the connection.
                conn.Open();
                //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                SqlCommand cmd = new SqlCommand(deleteProductTypeQuery, conn);
                //Set the command type to Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;

                //Set the paramaters.
                cmd.Parameters.AddWithValue("@ProductTypeID", deleteProductType.ProductTypeID);

                //Commit to database. 
                cmd.Transaction = conn.BeginTransaction();
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();

                //Close the connection,initialize refreshProductTypes and initialize fillProductTypes methods.
                conn.Close();
                refreshProductTypes();
                fillProductTypes();
            }
            //If try block fails display error to user.
            catch (Exception)
            {
                MessageBox.Show("An Error has occoured trying to Commit delete Product Type at ID: " + cbDeleteProductType.Text +
                                    " in the DataBase, Please conntact System Administrator.", "Error Deleting Product Type", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Initialize refreshProductTypes and initialize fillProductTypes methods.
                refreshProductTypes();
                fillProductTypes();
            }
        }


    }
}
