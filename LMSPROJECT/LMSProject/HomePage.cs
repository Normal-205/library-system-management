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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login admin = new Login();
            if (admin.ShowDialog() == DialogResult.OK)
            {
                // Login was successful
                this.Hide();
            }
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentLogin stlogin = new StudentLogin();
            stlogin.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookSearch bksearch = new BookSearch();
            bksearch.Show();
        }

        private void circularPicture1_Click_1(object sender, EventArgs e)
        {
            // Create a list to store the forms to close
            List<Form> formsToClose = new List<Form>();

            // Add all open forms to the list
            foreach (Form form in Application.OpenForms)
            {
                if (form != this) // Exclude the current form from the list
                {
                    formsToClose.Add(form);
                }
            }

            // Close all forms in the list
            foreach (Form form in formsToClose)
            {
                form.Close();
            }

            // Close the current form (this form)
            this.Close();
        }

    }
}
