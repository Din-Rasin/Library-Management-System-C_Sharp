using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace C_Sharp_Assignment_13
{
    public partial class Return_Books : Form
    {
        string connectionString = "Server=DESKTOP-UEQEMOD; Database=library; Trusted_Connection=True;";

        public Return_Books()
        {
            InitializeComponent();
            this.dataGridViewIssuedBooks.DataBindingComplete += dataGridViewIssuedBooks_DataBindingComplete;
        }

        private void Return_Books_Load(object sender, EventArgs e)
        {
            // Optional: defaults
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            string enrollmentNo = txtEnrollmentNo.Text.Trim();

            if (string.IsNullOrEmpty(enrollmentNo))
            {
                MessageBox.Show("Please enter the enrollment number.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Show only books that are not yet returned
                string query = "SELECT BookName, IssueDate FROM IssuedBooks WHERE EnrollmentNo = @EnrollmentNo AND BookReturnDate IS NULL";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EnrollmentNo", enrollmentNo);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dataGridViewIssuedBooks.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No books to return for this enrollment number.");
                    dataGridViewIssuedBooks.DataSource = null;
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string enrollmentNo = txtEnrollmentNo.Text.Trim();
            string bookName = txtBookName.Text.Trim();
            DateTime returnDate = dtpReturnDate.Value;

            if (string.IsNullOrEmpty(bookName))
            {
                MessageBox.Show("Please select a book to return.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE IssuedBooks SET BookReturnDate = @ReturnDate WHERE EnrollmentNo = @EnrollmentNo AND BookName = @BookName AND BookReturnDate IS NULL";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ReturnDate", returnDate);
                command.Parameters.AddWithValue("@EnrollmentNo", enrollmentNo);
                command.Parameters.AddWithValue("@BookName", bookName);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book returned successfully!");
                    btnSearchStudent.PerformClick(); // Refresh grid
                }
                else
                {
                    MessageBox.Show("Error: Book return failed or already returned.");
                }

                txtBookName.Text = "";
                txtIssueDate.Text = "";
            }
        }

        private void dataGridViewIssuedBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewIssuedBooks.Rows[e.RowIndex];
                txtBookName.Text = selectedRow.Cells["BookName"].Value.ToString();
                txtIssueDate.Text = selectedRow.Cells["IssueDate"].Value.ToString();
                dtpReturnDate.Value = DateTime.Today;
            }
        }

        private void btnCancelReturn_Click_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            txtIssueDate.Clear();
            dtpReturnDate.Value = DateTime.Today;

            if (dataGridViewIssuedBooks.SelectedRows.Count > 0)
            {
                dataGridViewIssuedBooks.ClearSelection();
            }

            dataGridViewIssuedBooks.DataSource = null;
            MessageBox.Show("Return Book form has been canceled.");
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtEnrollmentNo.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewIssuedBooks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewIssuedBooks.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }
    }
}
