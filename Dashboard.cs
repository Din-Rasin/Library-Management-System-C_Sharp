using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Assignment_13
{
    public partial class Dashboard : Form
    {

        public static Form IsFormAlreadyOpen(Type formType)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() == formType)
                {
                    return openForm; 
                }
            }
            return null; 
        }

        public Dashboard()
        {
            InitializeComponent();
        }


        private void addNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {



            Form existingForm = IsFormAlreadyOpen(typeof(AddBooKs));
            if (existingForm != null)
            {
                existingForm.BringToFront(); 
            }
            else
            {
                AddBooKs addBooksForm = new AddBooKs(); 
                addBooksForm.Show(); 
            }



        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {



            Form existingForm = IsFormAlreadyOpen(typeof(View_Book));
            if (existingForm != null)
            {
                existingForm.BringToFront(); 
            }
            else
            {
                View_Book viewBooksForm = new View_Book(); 
                viewBooksForm.Show(); 
            }

        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existingForm = IsFormAlreadyOpen(typeof(AddStudent));
            if (existingForm != null)
            {
                existingForm.BringToFront(); 
            }
            else
            {
                AddStudent addStudentForm = new AddStudent(); 
                addStudentForm.Show(); 
            }
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existingForm = IsFormAlreadyOpen(typeof(ViewStudentInformation));
            if (existingForm != null)
            {
                existingForm.BringToFront(); 
            }
            else
            {
                ViewStudentInformation viewStudentForm = new ViewStudentInformation(); 
                viewStudentForm.Show(); 
            }
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existingForm = IsFormAlreadyOpen(typeof(IssueBooks));
            if (existingForm != null)
            {
                existingForm.BringToFront(); 
            }
            else
            {
                IssueBooks issueBooksForm = new IssueBooks(); 
                issueBooksForm.Show(); 
            }
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existingForm = IsFormAlreadyOpen(typeof(Return_Books));
            if (existingForm != null)
            {
                existingForm.BringToFront(); 
            }
            else
            {
                Return_Books returnBooksForm = new Return_Books(); 
                returnBooksForm.Show(); 
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void completeBooKsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existingForm = IsFormAlreadyOpen(typeof(completeBookDetail));
            if (existingForm != null)
            {
                existingForm.BringToFront(); 
            }
            else
            {
                completeBookDetail completeBooksForm = new completeBookDetail(); 
                completeBooksForm.Show();
                
            }

        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?",
                                         "Confirm Logout",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                foreach (Form openForm in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (openForm is Form1) 
                    {
                        continue;
                    }
                    openForm.Dispose(); 
                }

               
                Form1 loginForm = new Form1();
                loginForm.Show();

               
                this.Close();
            }
        }

    }
}
