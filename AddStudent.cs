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
    public partial class AddStudent : Form
    { 

        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
        private string connectionString = "Server=DESKTOP-UEQEMOD; Database=library; Trusted_Connection=True;";

        

        private void SaveInfoButton_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text;
            string enrollmentNo = txtEnrollmentNo.Text;
            string department = txtDepartment.Text;
            string semester = txtSemester.Text;
            string contact = txtContact.Text;
            string email = txtEmail.Text;

            if (string.IsNullOrWhiteSpace(studentName) || string.IsNullOrWhiteSpace(enrollmentNo))
            {
                MessageBox.Show("Name and Enrollment No are required.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO students (StudentName, EnrollmentNo, Department, Semester, Contact, Email) " +
                               "VALUES (@StudentName, @EnrollmentNo, @Department, @Semester, @Contact, @Email)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentName", studentName);
                command.Parameters.AddWithValue("@EnrollmentNo", enrollmentNo);
                command.Parameters.AddWithValue("@Department", department);
                command.Parameters.AddWithValue("@Semester", semester);
                command.Parameters.AddWithValue("@Contact", contact);
                command.Parameters.AddWithValue("@Email", email);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student information saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtEnrollmentNo.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text;
            string enrollmentNo = txtEnrollmentNo.Text;
            string department = txtDepartment.Text;
            string semester = txtSemester.Text;
            string contact = txtContact.Text;
            string email = txtEmail.Text;

            if (string.IsNullOrWhiteSpace(studentName) || string.IsNullOrWhiteSpace(enrollmentNo))
            {
                MessageBox.Show("Name and Enrollment No are required.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO students (StudentName, EnrollmentNo, Department, Semester, Contact, Email) " +
                               "VALUES (@StudentName, @EnrollmentNo, @Department, @Semester, @Contact, @Email)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentName", studentName);
                command.Parameters.AddWithValue("@EnrollmentNo", enrollmentNo);
                command.Parameters.AddWithValue("@Department", department);
                command.Parameters.AddWithValue("@Semester", semester);
                command.Parameters.AddWithValue("@Contact", contact);
                command.Parameters.AddWithValue("@Email", email);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student information saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

     

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtEnrollmentNo.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }


    }

    
}
