using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Assignment_13
{
    public partial class View_Book : Form
    {
        string connectionString = "Server=DESKTOP-UEQEMOD; Database=library; Trusted_Connection=True;";
        public View_Book()
        {
            InitializeComponent();
        }

        private void View_Book_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }
        private void LoadBooks()
        {
            string connectionString = "Server=DESKTOP-UEQEMOD; Database=library; Trusted_Connection=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NewBook";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // Bind the data to DataGridView
                dataGridView.DataSource = dt;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-UEQEMOD; Database=library; Trusted_Connection=True;";
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the selected Book ID
                int bookId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["bid"].Value);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE NewBook SET bName = @bName, bAuther = @bAuther, bPublic = @bPublic, " +
                                   "bDate = @bDate, bPrice = @bPrice, bQty = @bQty WHERE bid = @bid";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@bName", txtbookname.Text);
                    cmd.Parameters.AddWithValue("@bAuther", txtbookAuther.Text);
                    cmd.Parameters.AddWithValue("@bPublic", txtpublication.Text);
                    cmd.Parameters.AddWithValue("@bDate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@bPrice", Convert.ToInt64(txtbookprice.Text));
                    cmd.Parameters.AddWithValue("@bQty", Convert.ToInt64(txtbookqty.Text));
                    cmd.Parameters.AddWithValue("@bid", bookId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record updated successfully.");
                    LoadBooks();
                }
            }
            else
            {
                MessageBox.Show("Please select a book to update.");
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void brtcancel_Click(object sender, EventArgs e)
        {
            txtbookname.Text = string.Empty;
            txtbookAuther.Text = string.Empty;
            txtpublication.Text = string.Empty;
            txtbookprice.Text = string.Empty;
            txtbookqty.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {

                // Get the selected Book ID
                int bookId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["bid"].Value);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM NewBook WHERE bid = @bid";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@bid", bookId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record deleted successfully.");
                    LoadBooks();
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                txtbookname.Text = row.Cells["bName"].Value.ToString();
                txtbookAuther.Text = row.Cells["bAuther"].Value.ToString();
                txtpublication.Text = row.Cells["bPublic"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["bDate"].Value);
                txtbookprice.Text = row.Cells["bPrice"].Value.ToString();
                txtbookqty.Text = row.Cells["bQty"].Value.ToString();
            }
        }
   

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            if (dataGridView.DataSource is DataTable dt)
            {
                // Get the search keyword from the TextBox (replace txtSearch with your TextBox name)
                string searchKeyword = txtsearch.Text.Trim();

                // Apply a filter to the DataTable
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    dt.DefaultView.RowFilter = $"bName LIKE '%{searchKeyword}%' OR bAuther LIKE '%{searchKeyword}%'";
                }
                else
                {
                    // If the search box is empty, clear the filter
                    dt.DefaultView.RowFilter = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("No data to search. Please load data into the view first.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
