using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSProject
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private ReturnBook returnbook = null;
        private void returNBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (returnbook == null)
            {
                returnbook = new ReturnBook();
                returnbook.FormClosed += ReturnBook_FormClosed;
                returnbook.Show();
            }
            else
            {
                // The form is already open, bring it to the front
                returnbook.BringToFront();
            }
        }
        private void ReturnBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reset the instance when the form is closed
            returnbook = null;
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private CompleteBookDetail completebookdetail = null;
        private void completeBookDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (completebookdetail == null)
            {
                completebookdetail = new CompleteBookDetail();
                completebookdetail.FormClosed += CompleteBookDetail_FormClosed;
                completebookdetail.Show();
            }
            else
            {
                // The form is already open, bring it to the front
                completebookdetail.BringToFront();
            }
        }
        private void CompleteBookDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reset the instance when the form is closed
            completebookdetail = null;
        }

        private void circularPicture1_Click(object sender, EventArgs e)
        {
            //
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }
        private AddBook addbook = null;
        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addbook == null)
            {
                addbook = new AddBook();
                addbook.FormClosed += AddBook_FormClosed;
                addbook.Show();
            }
            else
            {
                // The form is already open, bring it to the front
                addbook.BringToFront();
            }
        }
        private void AddBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reset the instance when the form is closed
            addbook = null;
        }
        private ViewBook viewbook = null;
        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //rewriting the above code
            if (viewbook == null)
            {
                viewbook = new ViewBook();
                viewbook.FormClosed += ViewBook_FormClosed;
                viewbook.Show();
            }
            else
            {
                // The form is already open, bring it to the front
                viewbook.BringToFront();
            }

            //ViewBook viewbook = new ViewBook();
            //viewbook.Show();
        }
        private void ViewBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reset the instance when the form is closed
            viewbook = null;
        }


        private ViewStudent viewstudent = null;
        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewstudent == null)
            {
                viewstudent = new ViewStudent();
                viewstudent.FormClosed += ViewStudent_FormClosed;
                viewstudent.Show();
            }
            else
            {
                // The form is already open, bring it to the front
                viewstudent.BringToFront();
            }
        }
        private void ViewStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reset the instance when the form is closed
            viewstudent = null;
        }


        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private AddStudent AddStudent = null;
        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AddStudent == null)
            {
                AddStudent = new AddStudent();
                AddStudent.FormClosed += AddStudent_FormClosed;
                AddStudent.Show();
            }
            else
            {
                // The form is already open, bring it to the front
                AddStudent.BringToFront();
            }
        }

        private void AddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reset the instance when the form is closed
            AddStudent = null;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            //show HomePage form
            HomePage home = new HomePage();
            home.Show();
        }

        private IssueBook issuebook = null;
        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (issuebook == null)
            {
                issuebook = new IssueBook();
                issuebook.FormClosed += IssueBook_FormClosed;
                issuebook.Show();
            }
            else
            {
                // The form is already open, bring it to the front
                issuebook.BringToFront();
            }
        }
        private void IssueBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reset the instance when the form is closed
            issuebook = null;
        }


        private void circularProgressBar4_Click(object sender, EventArgs e)
        {

        }
    }
}
