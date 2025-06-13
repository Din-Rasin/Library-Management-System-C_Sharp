using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Assignment_13
{
    public partial class AddBooKs : Form
    {
        public AddBooKs()
        {
            InitializeComponent();
            
        }

        private void savebtn_Click(object sender, EventArgs e)
        {

            string connectionString = "Server=DESKTOP-UEQEMOD; Database=library; Trusted_Connection=True;";

         

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Get user input
                    string bookName = txtBookName.Text.Trim();
                    string authorName = txtAuthorName.Text.Trim();
                    string publisher = txtPublisher.Text.Trim();
                    string dateInput = txtDate.Text.Trim(); // Date entered by the user
                    string priceInput = txtPrice.Text.Trim();
                    string quantityInput = txtQuantity.Text.Trim();

                    // Validate and parse the date
                    if (!DateTime.TryParse(dateInput, out DateTime publishDate))
                    {
                        MessageBox.Show("Please enter a valid date in the format YYYY-MM-DD.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validate numeric fields
                    if (!decimal.TryParse(priceInput, out decimal price) || !int.TryParse(quantityInput, out int quantity))
                    {
                        MessageBox.Show("Please enter valid numeric values for Price and Quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insert query
                    string query = "INSERT INTO NewBook (bName, bAuther, bPublic, bDate, bPrice, bQty) " +
                                   "VALUES (@bName, @bAuther, @bPublic, @bDate, @bPrice, @bQty)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Bind parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@bName", bookName);
                        cmd.Parameters.AddWithValue("@bAuther", authorName);
                        cmd.Parameters.AddWithValue("@bPublic", publisher);
                        cmd.Parameters.AddWithValue("@bDate", publishDate); // Pass the validated DateTime
                        cmd.Parameters.AddWithValue("@bPrice", price);
                        cmd.Parameters.AddWithValue("@bQty", quantity);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to save the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cancelbtn_Click(object sender, EventArgs e)
        {


            txtBookName.Text = string.Empty;
            txtAuthorName.Text = string.Empty;
            txtPublisher.Text = string.Empty;
            txtDate.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;

            // Optionally focus on the first input field
            txtBookName.Focus();

            // Display a message for feedback (optional)
            MessageBox.Show("All input fields have been cleared.", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void AddBooKs_Load(object sender, EventArgs e)
        {
           
        }

      
      
    }
}
