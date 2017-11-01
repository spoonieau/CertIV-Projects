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
    public partial class frmCustomers: Form
    {
        public frmCustomers()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Genius;
            fillCustomers();
        }

        //Add a Customer.
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            GlobalVariables.selectedCategorieID = 0;

            //Check to see if all feilds are full.
            if (String.IsNullOrEmpty(txtAddFirstName.Text))
            {
                MessageBox.Show("Please enter Customers Firstname.", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(txtAddLastName.Text))
            {
                MessageBox.Show("Please enter Customers Lastname.", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(cbAddGender.Text))
            {
                MessageBox.Show("Please select Customers Gender.", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(cbAddGroup.Text))
            {
                MessageBox.Show("Please select Customers status.", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(txtAddAddress.Text))
            {
                MessageBox.Show("Please enter Customers address.", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(txtAddSuburb.Text))
            {
                MessageBox.Show("Please enter Customers suburb.", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(cbAddSate.Text))
            {
                MessageBox.Show("Please select Customers state.", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(txtAddPostCode.Text)) 
            {
                MessageBox.Show("Please enter Customers postcode.", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //Ask user if they want to Commit adding Customer Feilds to database.
                var result = MessageBox.Show("Commit to Adding new Customer " + txtAddFirstName.Text + " " + txtAddLastName.Text +
                    " to the DataBase?", "Add Categorie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //If user clicks yes.
                if (result == DialogResult.OK)
                {
                    //Try and add string to database.
                    try
                    { 
                        //Create a new instance of the Customers class.
                        Customers customer = new Customers(GlobalVariables.selectedCustomersID, cbAddGroup.SelectedIndex + 1, txtAddFirstName.Text, txtAddLastName.Text, txtAddAddress.Text,
                            txtAddSuburb.Text, cbAddSate.Text, int.Parse(txtAddPostCode.Text), cbAddGender.Text, dtpAddBirthDate.Text);

                        string addCustomerQuery;

                        //Set the Stored Procedure to use.
                        addCustomerQuery = "sp_Customers_CreateCustomer ";

                        //Create a new instance of SqlConnection using the ConnectionManager class.  
                        SqlConnection conn = ConnectionManager.DatabaseConnection();

                        //Open the connection.
                        conn.Open();
                        //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                        SqlCommand cmd = new SqlCommand(addCustomerQuery, conn);
                        //Set the command type to Stored Procedure
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Create a new ID
                        cmd.Parameters.AddWithValue("@NewCustomerID", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.AddWithValue("@CategoryID", customer.CategoryID);
                        cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                        cmd.Parameters.AddWithValue("@Address", customer.Address);
                        cmd.Parameters.AddWithValue("@Suburb", customer.Suburb);
                        cmd.Parameters.AddWithValue("@State", customer.State);
                        cmd.Parameters.AddWithValue("@PostCode", customer.PostCode);
                        cmd.Parameters.AddWithValue("@BirthDate", DateTime.ParseExact(customer.BirthDate, "dd-MM-yyyy", CultureInfo.InvariantCulture));

                        // Set correct gender string.
                        if (cbAddGender.Text == "Male")
                            cmd.Parameters.AddWithValue("@Gender", "M");

                        else if (cbAddGender.Text == "Female")
                            cmd.Parameters.AddWithValue("@Gender", "F");


                        //Commit to database. 
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        //Close the connection, initialize refreshCustomers and initialize fillCustomers method.   
                        conn.Close();
                        refreshCustomers();
                        fillCustomers();
                    }
                    //If try block fails display error to user.
                    catch (Exception)
                    {
                        
                        MessageBox.Show("An Error has occoured trying to Commit " + txtAddFirstName.Text + " " + txtAddLastName.Text +
                                        " to DataBase, Please conntact System Administrator.", "Error Adding new Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Initialize refreshCustomers and initialize fillCustomers methods.
                        refreshCustomers();
                        fillCustomers();
                    }
                }
            }
        
        }

        //Update a Customer.
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {

                //Check to see if all feilds are full.
                if (String.IsNullOrEmpty(txtUpdateFirstName.Text))
                {
                    MessageBox.Show("Please enter Customers Firstname.", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (String.IsNullOrEmpty(txtUpdateLastName.Text))
                {
                    MessageBox.Show("Please enter Customers Lastname", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (String.IsNullOrEmpty(cbUpdateGender.Text))
                {
                    MessageBox.Show("Please select Customers Gender", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (String.IsNullOrEmpty(cbUpdateGroup.Text))
                {
                    MessageBox.Show("Please select Customers status.", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (String.IsNullOrEmpty(txtUpdateAddress.Text))
                {
                    MessageBox.Show("Please enter Customers address.", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (String.IsNullOrEmpty(txtUpdateSuburb.Text))
                {
                    MessageBox.Show("Please enter Customers suburb.", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (String.IsNullOrEmpty(cbUpdateState.Text))
                {
                    MessageBox.Show("Please select Customers state.", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (String.IsNullOrEmpty(txtUpdatePostCode.Text))
                {
                    MessageBox.Show("Please enter Customers postcode.", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    //Set GlobalVariables.selectedCategorieID to number selected in cbUpdateCategories.
                    GlobalVariables.selectedCustomersID = int.Parse(cbCustomerUpdateID.Text);

                //Get first letter from gender selection.
                string updateGender = cbUpdateGender.Text.Substring(0, 1);

                //Convert date to string.
                string formatedDate = dtpUpdateBirthDate.Value.ToString();

                //Ask user if they want to Commit updating Customer in database.
                var result = MessageBox.Show("Commit to Updateing Customer ID: " + cbCustomerUpdateID.Text + " "
                    + txtUpdateFirstName.Text + " " + txtUpdateLastName.Text + " to the DataBase?", "Update Customer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    //If user clicks yes.
                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            //Create a new instance of the Customers class.
                            Customers updateCustomer = new Customers(GlobalVariables.selectedCustomersID, cbUpdateGroup.SelectedIndex +1, txtUpdateFirstName.Text, txtUpdateLastName.Text, txtUpdateAddress.Text,
                            txtUpdateSuburb.Text, cbUpdateState.Text, int.Parse(txtUpdatePostCode.Text), updateGender, formatedDate);

                            string updateCustomerQuery;

                            updateCustomerQuery = "sp_Customers_UpdateCustomer ";

                            //Create a new instance of SqlConnection using the ConnectionManager class.  
                            SqlConnection conn = ConnectionManager.DatabaseConnection();

                            //Open the connection.
                            conn.Open();
                            //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                            SqlCommand cmd = new SqlCommand(updateCustomerQuery, conn);
                            //Set the command type to Stored Procedure
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@CustomerID", updateCustomer.CustomerID);
                            cmd.Parameters.AddWithValue("@CategoryID", updateCustomer.CategoryID);
                            cmd.Parameters.AddWithValue("@FirstName", updateCustomer.FirstName);
                            cmd.Parameters.AddWithValue("@LastName", updateCustomer.LastName);
                            cmd.Parameters.AddWithValue("@Address", updateCustomer.Address);
                            cmd.Parameters.AddWithValue("@Suburb", updateCustomer.Suburb);
                            cmd.Parameters.AddWithValue("@State", updateCustomer.State);
                            cmd.Parameters.AddWithValue("@PostCode", updateCustomer.PostCode);
                            cmd.Parameters.AddWithValue("@Gender", updateCustomer.Gender);
                            cmd.Parameters.AddWithValue("@BirthDate", Convert.ToDateTime(formatedDate));

                            //Commit to database. 
                            cmd.Transaction = conn.BeginTransaction();
                            cmd.ExecuteNonQuery();
                            cmd.Transaction.Commit();

                            //Close the connection, initialize refreshCustomers and initialize fillCustomers method.   
                            conn.Close();
                            refreshCustomers();
                            fillCustomers();
                        }
                        catch (Exception)
                        {
                           
                            MessageBox.Show("An Error has occoured trying to Commit update to customer " + cbCustomerUpdateID.Text + " "
                            + txtUpdateFirstName.Text + " " + txtUpdateLastName.Text + " to DataBase, Please conntact System Administrator.", "Error Updateing Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                            //Initialize refreshCategories and initialize fillCustomers methods.
                            refreshCustomers();
                            fillCustomers();
                        }

                    }
                }

            
                
        }

        //Update Customer feilds from stored data. 
        private void cbCustomerUpdateID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectQueryCustomers;

            //Set needed SQL Commands
            selectQueryCustomers = "SELECT Customers.CustomerID, Categories.Category, Customers.FirstName, Customers.LastName, Customers.Address," +
                " Customers.Suburb, Customers.State, Customers.PostCode, Customers.Gender, Customers.BirthDate" +
                " FROM Customers Join Categories ON Customers.CategoryID = Categories.CategoryID " +
                "WHERE Customers.CustomerID = " + cbCustomerUpdateID.Text;

            //Create a new instance of SqlConnection using the ConnectionManager class. 
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            //Try and read Customer Table from database. 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQueryCustomers, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //Set gender 
                    string gender = "Male";
                    if (rdr["Gender"].ToString() == "F")
                    {
                        gender = "Female";
                    }

                    cbUpdateGroup.SelectedItem = (rdr["Category"].ToString());
                    txtUpdateFirstName.Text = (rdr["FirstName"].ToString());
                    txtUpdateLastName.Text = (rdr["LastName"].ToString());
                    txtUpdateAddress.Text = (rdr["Address"].ToString());
                    txtUpdateSuburb.Text = (rdr["Suburb"].ToString());
                    cbUpdateState.SelectedItem = (rdr["State"].ToString());
                    txtUpdatePostCode.Text = (rdr["PostCode"].ToString());
                    cbUpdateGender.SelectedItem = gender;
                    dtpUpdateBirthDate.Value = DateTime.Parse(rdr["BirthDate"].ToString()); 

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

        //Close form.
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Show Customer Serarch Form.
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmCustomerSearch();
            frm1.ShowDialog(this);
        }

        //Delete a Customer.
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int canDelete = 0;

            //Check to see if cbDeleteCustomer is empty.
            if (String.IsNullOrEmpty(cbDeleteCustomer.Text))
            {
                MessageBox.Show("Please select a CustomerID you wish to Delete", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Set GlobalVariables.selectedcustomerID to number selected in cbDeleteCategories.
            GlobalVariables.selectedCustomersID = int.Parse(cbDeleteCustomer.Text);

            //Ask user if they want to Commit deleting the Customer in database.
            var result = MessageBox.Show("Commit to Deleting Customer at ID:" + cbDeleteCustomer.Text + " ?", "Delete Customer", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //If user clicks yes.
            if (result == DialogResult.OK)
            {
                //Try and see if ID can be delected.
                try
                {
                    //Create a new instance of the Customers class.
                    Customers deleteCustomers = new Customers(GlobalVariables.selectedCustomersID, 0, null, null, null, null, null, 0, null, null);

                    string deleteCustomerQuery;

                    //Set the Stored Procedure to use.
                    deleteCustomerQuery = "sp_Customers_AllowDeleteCustomer ";

                    //Create a new instance of SqlConnection using the ConnectionManager class.  
                    SqlConnection conn = ConnectionManager.DatabaseConnection();

                    //Open the connection.
                    conn.Open();
                    //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                    SqlCommand cmd = new SqlCommand(deleteCustomerQuery, conn);
                    //Set the command type to Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Set the paramaters.
                    cmd.Parameters.AddWithValue("@CustomerID", deleteCustomers.CustomerID);
                    cmd.Parameters.Add("@RecordCount", SqlDbType.Int);
                    cmd.Parameters["@RecordCount"].Direction = ParameterDirection.Output;

                    //Get the value of @RecordCount. 
                    cmd.ExecuteNonQuery();
                    canDelete = (int)cmd.Parameters["@RecordCount"].Value;

                    //Close the connection, initialize refreshCategories and initialize fillCategories method.   
                    conn.Close();
                }
                //If try block fails display error to user.
                catch (Exception)
                {
                    MessageBox.Show("An Error has occoured trying to Commit delete Customer at ID:" + cbDeleteCustomer.Text +
                                    " in the DataBase, Please conntact System Administrator.", "Error Deleting Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    refreshCustomers();
                    fillCustomers();
                }

                if (canDelete == 1)
                {
                   MessageBox.Show("Sorry unable to delete Customer at ID: " + GlobalVariables.selectedCustomersID.ToString() +
                        Environment.NewLine + "The Customer is attached to a record", "Unable to Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (canDelete == 0)
                {
                    deleteCustomer();
                }
            }
        }

        //Close form.
        private void btnCusReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * Required Methods. 
         */

        //Read and fill lvCustomers method.
        private void fillCustomers()
        {
            string selectQueryCustomers;

            //Set needed SQL Commands
            selectQueryCustomers = "SELECT Customers.CustomerID, Categories.Category, Customers.FirstName, Customers.LastName, Customers.Address," +
                " Customers.Suburb, Customers.State, Customers.PostCode, Customers.Gender, Customers.BirthDate" +
                " FROM Customers Join Categories ON Customers.CategoryID = Categories.CategoryID ";

            //Create a new instance of SqlConnection using the ConnectionManager class. 
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            //Try and read Customer Table from database. 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQueryCustomers, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //Set gender 
                    string gender = "Male";
                    if (rdr["Gender"].ToString() == "F")
                    {
                        gender = "Female";
                    }

                   //Format date to AUS format and remove time stamp.
                   string formatedDate = String.Format("{0:dd/MM/yyyy}", rdr["BirthDate"]);
                    
                    ListViewItem cusListView = new ListViewItem(rdr["CustomerID"].ToString());
                    cusListView.SubItems.Add(rdr["Category"].ToString());
                    cusListView.SubItems.Add(rdr["FirstName"].ToString());
                    cusListView.SubItems.Add(rdr["LastName"].ToString());
                    cusListView.SubItems.Add(rdr["Address"].ToString());
                    cusListView.SubItems.Add(rdr["Suburb"].ToString());
                    cusListView.SubItems.Add(rdr["State"].ToString());
                    cusListView.SubItems.Add(rdr["PostCode"].ToString());
                    cusListView.SubItems.Add(gender);
                    cusListView.SubItems.Add(formatedDate);
                    lvCustomers.Items.Add(cusListView);
                    cbCustomerUpdateID.Items.Add(rdr["CustomerID"].ToString());
                    cbDeleteCustomer.Items.Add(rdr["CustomerID"].ToString());
                }
                conn.Close();//Close connection.

                fillcbAddUpdateCustomer(); //Initialize method fillcbAddUpdateCustomer.
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
        private void fillcbAddUpdateCustomer()
        {
            cbAddGroup.Items.Clear();
            cbUpdateGroup.Items.Clear();

            string selectQueryCustomers;

            //Set needed SQL Commands
            selectQueryCustomers = "SELECT Categories.Category, Categories.CategoryID FROM Categories";

            //Create a new instance of SqlConnection using the ConnectionManager class. 
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            conn.Open();
            SqlCommand cmd = new SqlCommand(selectQueryCustomers, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
                {
                    cbAddGroup.Items.Add(rdr["Category"].ToString());
                    cbUpdateGroup.Items.Add(rdr["Category"].ToString());
            }
            conn.Close();//Close connection.
        }

        //Reset and clear required feilds.
        private void refreshCustomers()
        {
            lvCustomers.Items.Clear();
            txtAddFirstName.Clear();
            txtAddLastName.Clear();
            cbAddGender.ResetText();
            cbAddGroup.Items.Clear();
            txtAddAddress.Clear();
            txtAddSuburb.Clear();
            cbAddSate.ResetText();
            txtAddPostCode.Clear();

            cbCustomerUpdateID.Items.Clear();
            cbCustomerUpdateID.ResetText();
            cbUpdateGroup.ResetText();
            cbUpdateGender.ResetText();
            cbUpdateState.ResetText();
            txtUpdateFirstName.Clear();
            txtUpdateLastName.Clear();
            cbUpdateGroup.Items.Clear();
            txtUpdateAddress.Clear();
            txtUpdateSuburb.Clear();
            txtAddPostCode.Clear();            
            txtUpdatePostCode.Clear();

            cbDeleteCustomer.ResetText();
            cbDeleteCustomer.Items.Clear();
        }

        //Delete Customer method.
        private void deleteCustomer()
        {
            //Try and delete string in database.
            try
            {
                //Create a new instance of the Customers class.
                Customers deleteCustomers = new Customers(GlobalVariables.selectedCustomersID, 0, null, null, null, null, null, 0, null, null);

                string deleteCustomerQuery;

                //Set the Stored Procedure to use.
                deleteCustomerQuery = "sp_Customers_DeleteCustomer ";

                //Create a new instance of SqlConnection using the ConnectionManager class.  
                SqlConnection conn = ConnectionManager.DatabaseConnection();

                //Open the connection.
                conn.Open();
                //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                SqlCommand cmd = new SqlCommand(deleteCustomerQuery, conn);
                //Set the command type to Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;

                //Set the paramaters.
                cmd.Parameters.AddWithValue("@CustomerID", deleteCustomers.CustomerID);

                //Commit to database. 
                cmd.Transaction = conn.BeginTransaction();
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();

                //Close the connection, initialize refreshCustomers and initialize fillCustomers methods.   
                conn.Close();
                refreshCustomers();
                fillCustomers();
            }
            //If try block fails display error to user.
            catch (Exception)
            {
                MessageBox.Show("An Error has occoured trying to Commit delete Category at ID:" +cbDeleteCustomer.Text +
                                    " in the DataBase, Please conntact System Administrator.", "Error Deleting Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                refreshCustomers();
                fillCustomers();
            }
        }

        public void searchCustomerResults()
        {
            refreshCustomers();

            string selectQueryCustomers;

            //Set needed SQL Commands
            selectQueryCustomers = "SELECT Customers.CustomerID, Categories.Category, Customers.FirstName, Customers.LastName, Customers.Address," +
                " Customers.Suburb, Customers.State, Customers.PostCode, Customers.Gender, Customers.BirthDate" +
                " FROM Customers Join Categories ON Customers.CategoryID = Categories.CategoryID" +
                " WHERE " + GlobalVariables.searchCretia;

            //Create a new instance of SqlConnection using the ConnectionManager class. 
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            //Try and read Customer Table from database. 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQueryCustomers, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //Set gender 
                    string gender = "Male";
                    if (rdr["Gender"].ToString() == "F")
                    {
                        gender = "Female";
                    }

                    //Format date to AUS format and remove time stamp.
                    string formatedDate = String.Format("{0:dd/MM/yyyy}", rdr["BirthDate"]);

                    ListViewItem cusListView = new ListViewItem(rdr["CustomerID"].ToString());
                    cusListView.SubItems.Add(rdr["Category"].ToString());
                    cusListView.SubItems.Add(rdr["FirstName"].ToString());
                    cusListView.SubItems.Add(rdr["LastName"].ToString());
                    cusListView.SubItems.Add(rdr["Address"].ToString());
                    cusListView.SubItems.Add(rdr["Suburb"].ToString());
                    cusListView.SubItems.Add(rdr["State"].ToString());
                    cusListView.SubItems.Add(rdr["PostCode"].ToString());
                    cusListView.SubItems.Add(gender);
                    cusListView.SubItems.Add(formatedDate);
                    lvCustomers.Items.Add(cusListView);
                    cbCustomerUpdateID.Items.Add(rdr["CustomerID"].ToString());
                    cbDeleteCustomer.Items.Add(rdr["CustomerID"].ToString());
                }
                conn.Close();//Close connection.

                fillcbAddUpdateCustomer(); //Initialize method fillcbAddUpdateCustomer.
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
