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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtusername.Text == "UserName")
            {
                txtusername.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxshowpassword.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else {
                
                txtpassword.UseSystemPasswordChar= false;
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Clear();
                
            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            // Connection string
            string connectionString = "Server=DESKTOP-UEQEMOD; Database=Logins; Trusted_Connection=True;";

            // SQL query
            string query = "SELECT COUNT(*) FROM logintb WHERE username = @username AND pass = @password";


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@username", txtusername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());

                        // Execute query
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cenecl_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
        }

        private void pictureBoxfb_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.facebook.com/");
        }

        private void pictureBoxtiktok_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void pictureBoxIn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiktok.com/");
        }
    }
}

