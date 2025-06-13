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
    public partial class ViewStudentInformation : Form
    {
        string connectionString = "Server=DESKTOP-UEQEMOD; Database=library; Trusted_Connection=True;";
        public ViewStudentInformation()
        {
            InitializeComponent();
        }
        private void ViewStudentInformation_Load(object sender, EventArgs e)
        {
            
            DisplayData();
        }
        private void DisplayData()
        {
            string connectionString = "Server=DESKTOP-UEQEMOD; Database=library; Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM students";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Ensure a row is selected
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE students SET StudentName = @StudentName, EnrollmentNo = @EnrollmentNo, " +
                                   "Department = @Department, Semester = @Semester, Contact = @Contact, Email = @Email " +
                                   "WHERE StudentID = @StudentID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentName", txtStudentName.Text);
                    command.Parameters.AddWithValue("@EnrollmentNo", txtEnrollmentNo.Text);
                    command.Parameters.AddWithValue("@Department", txtDepartment.Text);
                    command.Parameters.AddWithValue("@Semester", txtSemester.Text);
                    command.Parameters.AddWithValue("@Contact", txtContact.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@StudentID", dataGridView1.SelectedRows[0].Cells["StudentID"].Value);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Student record updated successfully!");
                        DisplayData(); // Refresh the DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update.");
            }
        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the selected row index is valid
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate the textboxes with data from the selected row
                txtStudentName.Text = row.Cells["StudentName"].Value.ToString();
                txtEnrollmentNo.Text = row.Cells["EnrollmentNo"].Value.ToString();
                txtDepartment.Text = row.Cells["Department"].Value.ToString();
                txtSemester.Text = row.Cells["Semester"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Ensure a row is selected
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM students WHERE StudentID = @StudentID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentID", dataGridView1.SelectedRows[0].Cells["StudentID"].Value);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Student record deleted successfully!");
                        DisplayData(); // Refresh the DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL Query to search by Enrollment No
                string query = "SELECT * FROM students WHERE EnrollmentNo LIKE @EnrollmentNo";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EnrollmentNo", "%" + txtrefresh.Text.Trim() + "%");

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No records found for the given Enrollment No.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayData();
            txtrefresh.Clear();
        }

        private void btncanecl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
