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
    public partial class completeBookDetail : Form
    {
        string connectionString = "Server=DESKTOP-UEQEMOD; Database=library; Trusted_Connection=True;";

        public completeBookDetail()
        {
            InitializeComponent();
        }

        private void completeBookDetail_Load(object sender, EventArgs e)
        {
            LoadIssuedBooks();
            LoadStudentInformation();
            LoadBooks();
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            LoadIssuedBooks();
        }

        private void LoadIssuedBooks()
        {
            try
            {
                string query = "SELECT IssueID, EnrollmentNo, BookName, IssueDate FROM IssuedBooks";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewIssueBooks.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading issued books: " + ex.Message);
            }
        }

        private void ViewStudentInformation_Load(object sender, EventArgs e)
        {
            LoadStudentInformation();
        }

        private void LoadStudentInformation()
        {
            try
            {
                string query = "SELECT StudentID, StudentName, EnrollmentNo, Department, Semester, Contact, Email FROM students";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewStudentInformation.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student information: " + ex.Message);
            }
        }

        private void LoadBooks()
        {
            try
            {
                string query = "SELECT * FROM NewBook";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewView_Book.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string enrollmentNo = txtEnrollmentNo.Text.Trim();
                if (string.IsNullOrEmpty(enrollmentNo))
                {
                    LoadStudentInformation();
                    return;
                }

                string query = "SELECT StudentID, StudentName, EnrollmentNo, Department, Semester, Contact, Email FROM students WHERE EnrollmentNo = @EnrollmentNo";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@EnrollmentNo", enrollmentNo);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewStudentInformation.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching student information: " + ex.Message);
            }
        }

        private void btnIssueSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string enrollmentNo = txtIssueEnrollmentNo.Text.Trim();
                if (string.IsNullOrEmpty(enrollmentNo))
                {
                    LoadIssuedBooks();
                    return;
                }

                string query = "SELECT IssueID, EnrollmentNo, BookName, IssueDate FROM IssuedBooks WHERE EnrollmentNo = @EnrollmentNo";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@EnrollmentNo", enrollmentNo);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewIssueBooks.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching issued books: " + ex.Message);
            }
        }

        private void btnView_Book_Click(object sender, EventArgs e)
        {
            try
            {
                string bookName = txtsearch.Text.Trim(); // Assuming txtsearch is the TextBox for book name search
                if (string.IsNullOrEmpty(bookName))
                {
                    LoadBooks(); // Load all books if search field is empty
                    return;
                }

                string query = "SELECT * FROM NewBook WHERE bName LIKE '%' + @bName + '%'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@bName", bookName);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewView_Book.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching books: " + ex.Message);
            }
        }

        private void btnRefreshView_Book_Click(object sender, EventArgs e)
        {
            txtsearch.Text = ""; // Clear the search field
            LoadBooks(); // Reload all books
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollmentNo.Text = "";
            LoadStudentInformation();
            txtIssueEnrollmentNo.Text = "";
            LoadIssuedBooks();
            txtsearch.Text = "";
            LoadBooks();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txtrefresh_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIssueSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}