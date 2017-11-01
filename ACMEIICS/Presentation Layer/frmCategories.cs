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

namespace ACMEIICS
{
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Genius; //Set form Icon.
            fillCategories(); //Initialize method fillCategories.
        }

        //Add a Category.
        private void btnAddCategorie_Click(object sender, EventArgs e)
        {
            GlobalVariables.selectedCategorieID = 0;

            //Check to see if txtAddCategroie is empty.
            if (String.IsNullOrEmpty(txtAddCategroie.Text))
            {
                MessageBox.Show("Please enter a new Categroie in the required Feild", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //If txtAddCategroie is not empty, try and add string to database.
            else
            {
                //Ask user if they want to Commit adding txtAddCategroie.text to database.
                var result = MessageBox.Show("Commit to Adding new Categorie (" + txtAddCategroie.Text + ") to the DataBase?", "Add Categorie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //If user clicks yes.
                if (result == DialogResult.OK)
                {
                    //Try and add string to database.
                    try
                    {
                        //Create a new instance of the Categories class.
                        Categories categorie = new Categories(GlobalVariables.selectedCategorieID, txtAddCategroie.Text);

                        string addCategorieQuery;

                        //Set the Stored Procedure to use.
                        addCategorieQuery = "sp_Categories_CreateCategory ";

                        //Create a new instance of SqlConnection using the ConnectionManager class.  
                        SqlConnection conn = ConnectionManager.DatabaseConnection();

                        //Open the connection.
                        conn.Open();
                        //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                        SqlCommand cmd = new SqlCommand(addCategorieQuery, conn);
                        //Set the command type to Stored Procedure
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Create a new ID
                        cmd.Parameters.AddWithValue("@NewCategoryID", SqlDbType.Int).Direction = ParameterDirection.Output;
                        //Add string from the category call.
                        cmd.Parameters.AddWithValue("@Category", categorie.Category);
                                             
                        //Commit to database. 
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        //Close the connection, initialize refreshCategories and initialize fillCategories methods.   
                        conn.Close();
                        refreshCategories();
                        fillCategories();
                    }
                    //If try block fails display error to user.
                    catch (Exception)
                    {
                        MessageBox.Show("An Error has occoured trying to Commit " + txtAddCategroie.Text +
                                        " to DataBase, Please conntact System Administrator.", "Error Adding new Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        refreshCategories();
                        fillCategories();
                    }
                }
            }
        }

        //Update a Categorie
        private void btnUpdateCategorie_Click(object sender, EventArgs e)
        {
            //Check to see if cbUpdateCategories is empty.
            if (String.IsNullOrEmpty(cbUpdateCategories.Text))
            {
                MessageBox.Show("Please select a CategoryID you wish to update", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Check to see if txtUpdateCategorie is empty.
            else if  (String.IsNullOrEmpty(txtUpdateCategorie.Text))
            {
                MessageBox.Show("Please enter a new updated Category in the required Feild", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Set GlobalVariables.selectedCategorieID to number selected in cbUpdateCategories.
            GlobalVariables.selectedCategorieID = int.Parse(cbUpdateCategories.Text);
            
            //Ask user if they want to Commit updating categorie in database.
            var result = MessageBox.Show("Commit to updating Categorie at ID:" + cbUpdateCategories.Text + " with " + "(" + txtUpdateCategorie.Text + ") to the DataBase?", "Update Categorie", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //If user clicks yes.
            if (result == DialogResult.OK)
            {
                //Try and update string in database.
                try
                {
                    //Create a new instance of the Categories class.
                    Categories updateCategory = new Categories(GlobalVariables.selectedCategorieID, txtUpdateCategorie.Text);

                    string updateCategorieQuery;

                    //Set the Stored Procedure to use.
                    updateCategorieQuery = "sp_Categories_UpdateCategory ";

                    //Create a new instance of SqlConnection using the ConnectionManager class.  
                    SqlConnection conn = ConnectionManager.DatabaseConnection();

                    //Open the connection.
                    conn.Open();
                    //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                    SqlCommand cmd = new SqlCommand(updateCategorieQuery, conn);
                    //Set the command type to Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CategoryID", updateCategory.CategoryID);
                    cmd.Parameters.AddWithValue("@Category", updateCategory.Category);

                    //Commit to database. 
                    cmd.Transaction = conn.BeginTransaction();
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();

                    //Close the connection, initialize refreshCategories and initialize fillCategories method.   
                    conn.Close();
                    refreshCategories();
                    fillCategories();

                }
                //If try block fails display error to user.
                catch (Exception)
                {
                    MessageBox.Show("An Error has occoured trying to Commit Category update (" + txtUpdateCategorie.Text + ") at ID:" + cbUpdateCategories.Text + 
                                        " to DataBase, Please conntact System Administrator.", "Error Updating Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    refreshCategories();
                    fillCategories();
                }
            }

        }

        //Update Category feilds from stored data. 
        private void cbUpdateCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectQueryCategories;

            selectQueryCategories = "SELECT Categories.CategoryID, Categories.Category From Categories" +
                " WHERE Categories.CategoryID = " + cbUpdateCategories.Text;

            //Create a new instance of SqlConnection using the ConnectionManager class. 
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQueryCategories, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    txtUpdateCategorie.Text = (rdr["Category"].ToString());
                }

                conn.Close();//Close connection.
            }
            //error if unable to connect to data base.
            catch (Exception)
            {
                MessageBox.Show("Connection test to Acme DataBase has failed!!" + Environment.NewLine + "Please conntact System Administrator",
                    "DataBase Connection Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Delete a Category.
        private void btnDeleteCategorie_Click(object sender, EventArgs e)
        {
            int canDelete = 0;

            //Check to see if cbDeleteCategories is empty.
            if (String.IsNullOrEmpty(cbDeleteCategorie.Text))
            {
                MessageBox.Show("Please select a CategoryID you wish to Delete", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }          

            //Set GlobalVariables.selectedCategorieID to number selected in cbDeleteCategories.
            GlobalVariables.selectedCategorieID = int.Parse(cbDeleteCategorie.Text);

            //Ask user if they want to Commit deleting the categorie in database.
            var result = MessageBox.Show("Commit to Deleting Categorie at ID:" + cbDeleteCategorie.Text + " ?", "Delete Categorie", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //If user clicks yes.
            if (result == DialogResult.OK)
            {
                //Try and see if ID can be delected.
                try
                {
                    //Create a new instance of the Categories class.
                    Categories deleteCategotie = new Categories(GlobalVariables.selectedCategorieID, null);

                    string deleteCategorieQuery;

                    //Set the Stored Procedure to use.
                    deleteCategorieQuery = "sp_Categories_AllowDeleteCategory ";

                    //Create a new instance of SqlConnection using the ConnectionManager class.  
                    SqlConnection conn = ConnectionManager.DatabaseConnection();

                    //Open the connection.
                    conn.Open();
                    //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                    SqlCommand cmd = new SqlCommand(deleteCategorieQuery, conn);
                    //Set the command type to Stored Procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Set the paramaters.
                    cmd.Parameters.AddWithValue("@CategoryID", deleteCategotie.CategoryID);
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
                    MessageBox.Show("An Error has occoured trying to Commit delete Category at ID:" + cbDeleteCategorie.Text +
                                        " in the DataBase, Please conntact System Administrator.", "Error Deleting Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    refreshCategories();
                    fillCategories();
                }

                if (canDelete == 1)
                {
                    MessageBox.Show("Sorry unable to delete Category at ID: " + GlobalVariables.selectedCategorieID.ToString() +
                        Environment.NewLine + "The Catergory is attached to a record", "Unable to Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (canDelete == 0)
                {
                    deleteCatgory();
                }
            }
        }

        //Close form.
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Close form.
        private void btnCatReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * Required Methods. 
         */

        //Read and fill lvCategories method.
        private void fillCategories()
        {
            string selectQueryCategories;

            //Set needed SQL Commands
            selectQueryCategories = "SELECT Categories.CategoryID, Categories.Category From Categories";

            //Create a new instance of SqlConnection using the ConnectionManager class. 
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;
            
            //Try and read Categorys Table from database. 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQueryCategories, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ListViewItem catListView = new ListViewItem(rdr["CategoryID"].ToString());
                    catListView.SubItems.Add(rdr["Category"].ToString());
                    lvCategories.Items.Add(catListView);
                    cbUpdateCategories.Items.Add(rdr["CategoryID"].ToString());
                    cbDeleteCategorie.Items.Add(rdr["CategoryID"].ToString());
                }
                conn.Close();//Close connection.
            }
            //error if unable to connect to data base.
            catch (Exception)
            {
                
                MessageBox.Show("Connection test to Acme DataBase has failed!!" + Environment.NewLine + "Please conntact System Administrator",
                    "DataBase Connection Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        //Refresh frmCategories method. 
        private void refreshCategories()
        {
            lvCategories.Items.Clear();
            txtUpdateCategorie.Clear();
            txtAddCategroie.Clear();
            cbUpdateCategories.ResetText();
            cbUpdateCategories.Items.Clear();
            cbDeleteCategorie.ResetText();
            cbDeleteCategorie.Items.Clear();
        }

        //DeleteCategory method.
        private void deleteCatgory()
        {
            //Try and delete string in database.
            try
            {
                //Create a new instance of the Categories class.
                Categories deleteCategotie = new Categories(GlobalVariables.selectedCategorieID, null);

                string deleteCategorieQuery;

                //Set the Stored Procedure to use.
                deleteCategorieQuery = "sp_Categories_DeleteCategory ";

                //Create a new instance of SqlConnection using the ConnectionManager class.  
                SqlConnection conn = ConnectionManager.DatabaseConnection();

                //Open the connection.
                conn.Open();
                //Create a new instance of SqlConnection using the Stored Procedure and SqlConnection.                  
                SqlCommand cmd = new SqlCommand(deleteCategorieQuery, conn);
                //Set the command type to Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;

                //Set the paramaters.
                cmd.Parameters.AddWithValue("@CategoryID", deleteCategotie.CategoryID);

                //Commit to database. 
                cmd.Transaction = conn.BeginTransaction();
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();

                //Close the connection, initialize refreshCategories and initialize fillCategories method.   
                conn.Close();
                refreshCategories();
                fillCategories();

            }
            //If try block fails display error to user.
            catch (Exception)
            {
                MessageBox.Show("An Error has occoured trying to Commit delete Category at ID:" + cbDeleteCategorie.Text +
                                    " in the DataBase, Please conntact System Administrator.", "Error Deleting Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                refreshCategories();
                fillCategories();

            }
        }
    }

}
        

