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
            foreach (Form form in Application.OpenForms)
            {
                if (form != this) // Exclude the current form from being closed
                {
                    form.Close();
                }
            }

            this.Close(); // Close the current form (the form containing the button)
        }

    }
}
