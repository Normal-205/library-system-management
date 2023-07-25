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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            String CS = "data source=.; database = LMSDB; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {
                if(txtbkName.Text!="" && txtbkAuthor.Text!="" && txtbkPublication.Text!="" && bkPurchaseDate.Text!="" && txtbkPrice.Text!="" && txtbkQuantity.Text!="")
                {
                    SqlCommand cmd = new SqlCommand("insert into tblBookInfos(bkName,bkAuthor,bkPublication,bkDate,bkPrice,bkQuanity) values(N'" + txtbkName.Text + "', N'" + txtbkAuthor.Text + "',N'" + txtbkPublication.Text + "', '" + bkPurchaseDate.Text + "', '" + double.Parse(txtbkPrice.Text) + "', '" + int.Parse(txtbkQuantity.Text) + "') ", con);
                    cmd.Parameters.AddWithValue("@bkName", SqlDbType.NVarChar).Value = txtbkName.Text;
                    cmd.Parameters.AddWithValue("@bkAuthor", SqlDbType.NVarChar).Value = txtbkAuthor.Text;
                    cmd.Parameters.AddWithValue("@bkPublication", SqlDbType.NVarChar).Value = txtbkPublication.Text;
                    cmd.Parameters.AddWithValue("@bkDate", SqlDbType.DateTime).Value = bkPurchaseDate.Value;
                    cmd.Parameters.AddWithValue("@bkPrice", SqlDbType.Float).Value = double.Parse(txtbkPrice.Text);
                    cmd.Parameters.AddWithValue("@bkQuantity", SqlDbType.Int).Value = int.Parse(txtbkQuantity.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã lưu thông tin sách.", "Thành công!",MessageBoxButtons.OK ,MessageBoxIcon.Information);
                    txtbkName.Clear();
                    txtbkAuthor.Clear();
                    txtbkPublication.Clear();
                    // bkPurchaseDate.Clear();
                    txtbkPrice.Clear();
                    txtbkQuantity.Clear();
                }
                else
                {
                    MessageBox.Show("Không được để trống các ô nhập dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
        }

        private void btnBookCancel_Click(object sender, EventArgs e)
        {
            txtbkName.Clear();
            txtbkAuthor.Clear();
            txtbkPublication.Clear();
            // bkPurchaseDate.Clear();
            txtbkPrice.Clear();
            txtbkQuantity.Clear();
        }

        private void bkPrice_Keypress(object sender, KeyPressEventArgs e)
        {
            //validate textbox only take numeric value
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            //prevent user from entering a dot or decimal point if one already exists
            else if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(','))
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

        private void bkQuantity_Keypress(object sender, KeyPressEventArgs e)
        {
            //validate textbox only take numeric value
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            //prevent user from entering a dot or decimal point if one already exists
            else if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(','))
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbkPrice_TextChanged(object sender, EventArgs e)
        {
            // Remove the event handler temporarily to prevent recursion
            txtbkPrice.TextChanged -= txtbkPrice_TextChanged;

            // Replace thousand separators from the current text
            string cleanedText = txtbkPrice.Text.Replace(",", "");

            if (double.TryParse(cleanedText, out double value))
            {
                // Format the number with thousand separators
                txtbkPrice.Text = value.ToString("N0");
                txtbkPrice.SelectionStart = txtbkPrice.Text.Length;
            }

            // Reattach the event handler
            txtbkPrice.TextChanged += txtbkPrice_TextChanged;
        }
    }
}
