using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C_Sharp_Assignment_13
{
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            // Optional: Load book list into cmbBooks
        }

        private void btnsearchstudent_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-UEQEMOD; Database=library; Trusted_Connection=True;";
            string enrollmentNo = txtEnrollmentNo.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM students WHERE EnrollmentNo = @EnrollmentNo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EnrollmentNo", enrollmentNo);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);

                if (studentTable.Rows.Count > 0)
                {
                    DataRow student = studentTable.Rows[0];
                    txtStudentName.Text = student["StudentName"].ToString();
                    txtDepartment.Text = student["Department"].ToString();
                    txtSemester.Text = student["Semester"].ToString();
                    txtContact.Text = student["Contact"].ToString();
                    txtEmail.Text = student["Email"].ToString();
                }
                else
                {
                    MessageBox.Show("Student not found!");
                }
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-UEQEMOD; Database=library; Trusted_Connection=True;";
            string enrollmentNo = txtEnrollmentNo.Text.Trim();
            string bookName = cmbBooks.Text.Trim();
            DateTime issueDate = dtpIssueDate.Value;

            if (string.IsNullOrWhiteSpace(bookName))
            {
                MessageBox.Show("Please enter a valid book name.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Only count books that have not been returned yet
                string countQuery = "SELECT COUNT(*) FROM IssuedBooks WHERE EnrollmentNo = @EnrollmentNo AND BookReturnDate IS NULL";
                SqlCommand countCmd = new SqlCommand(countQuery, conn);
                countCmd.Parameters.AddWithValue("@EnrollmentNo", enrollmentNo);
                int issuedCount = (int)countCmd.ExecuteScalar();

                if (issuedCount >= 3)
                {
                    MessageBox.Show("Maximum limit reached. A student can only issue up to 3 books.");
                    return;
                }

                string query = "INSERT INTO IssuedBooks (EnrollmentNo, BookName, IssueDate) VALUES (@EnrollmentNo, @BookName, @IssueDate)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EnrollmentNo", enrollmentNo);
                cmd.Parameters.AddWithValue("@BookName", bookName);
                cmd.Parameters.AddWithValue("@IssueDate", issueDate);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book issued successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to issue the book. Please check the details.");
                }
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtEnrollmentNo.Clear();
            txtStudentName.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            txtEmail.Clear();

            if (cmbBooks.Items.Count > 0)
            {
                cmbBooks.SelectedIndex = 0;
            }

            dtpIssueDate.Value = DateTime.Now;
        }

        private void cmbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: book-specific logic
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
