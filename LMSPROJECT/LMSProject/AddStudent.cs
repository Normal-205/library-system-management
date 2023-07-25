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

namespace LMSProject
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void jFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void circularPicture1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveStInfo_Click(object sender, EventArgs e)
        {
            String CS = "data source=.; database = LMSDB; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {
                if (txtstName.Text != "" && txtstNumber.Text != "" && txtstDepartment.Text != "" && txtstClass.Text != "" && txtstContact.Text != "" && txtstEmail.Text != "")
                { 
                    string sqlQuery = "INSERT INTO tblStudentInfos (stName, stNumber, stDepartment, stSemester, stContact, stEmail) " +
                          "VALUES (@stName, @stNumber, @stDepartment, @stSemester, @stContact, @stEmail)";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@stName", txtstName.Text);
                    cmd.Parameters.AddWithValue("@stNumber", txtstNumber.Text);
                    cmd.Parameters.AddWithValue("@stDepartment", txtstDepartment.Text);
                    cmd.Parameters.AddWithValue("@stSemester", txtstClass.Text);
                    cmd.Parameters.AddWithValue("@stContact", Int64.Parse(txtstContact.Text));
                    cmd.Parameters.AddWithValue("@stEmail", txtstEmail.Text);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã thêm thành công!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi khi thêm dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //clear the textboxes
                    txtstName.Clear();
                    txtstNumber.Clear();
                    txtstDepartment.Clear();  
                    txtstClass.Clear();
                    txtstContact.Clear();
                    txtstEmail.Clear();


                }
                else
                {
                    MessageBox.Show("Bạn phải điền hết các trường", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnStInfoRefrsh_Click(object sender, EventArgs e)
        {
            txtstName.Clear();
            txtstNumber.Clear();
            txtstDepartment.Clear();
            txtstClass.Clear();
            txtstEmail.Clear();
            txtstContact.Clear();
        }

        private void txtstContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validate textbox only take numeric value
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            //setting for the backspace key
            if (e.KeyChar == (char)Keys.Back) //set for the backspace key
            {
                TextBox textBox = (TextBox)sender; // Cast the sender object to TextBox
                if (textBox.Text.Length > 0)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBox.SelectionStart = textBox.Text.Length; // Set the caret position to the end
                }
                e.Handled = true;
            }
            //allow maximum 10 digit
            if (txtstContact.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validate textbox only take numeric value
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            //setting for the backspace key
            if (e.KeyChar == (char)Keys.Back) //set for the backspace key
            {
                TextBox textBox = (TextBox)sender; // Cast the sender object to TextBox
                if (textBox.Text.Length > 0)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBox.SelectionStart = textBox.Text.Length; // Set the caret position to the end
                }
                e.Handled = true;
            }
        }
    }
}
