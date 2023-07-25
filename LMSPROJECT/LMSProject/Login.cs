using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static WinFormAnimation.AnimationFunctions;

namespace LMSProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool PerformLogin()
        {
            String CS = "data source=.; database = LMSDB; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select *from tblLogin where UserName='" + txtusername.Text + "' and Password ='" + txtpassword.Text + "' ", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    Dashboard das = new Dashboard();
                    this.Hide();
                    das.Show();
                    return true;
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Perform login logic
            bool loginSuccessful = PerformLogin();

            if (loginSuccessful)
            {
                // Set the DialogResult to OK to indicate success
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void circularPicture1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtusername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtusername.Text == "Tên đăng nhập")
            {
                txtusername.Clear();
            }
        }

        private void txtpassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtpassword.Text == "Mật khẩu")
            {
                txtpassword.Clear();
                txtpassword.PasswordChar = '*';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Perform login logic
            bool loginSuccessful = PerformLogin();

            if (loginSuccessful)
            {
                // Set the DialogResult to OK to indicate success
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
