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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }


        private void circularPicture1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jFlatButton5_Click(object sender, EventArgs e)
        {
            txtBkName.Clear();
            txtBkIssueDate.Clear();
        }

        private void btnStSearch_Click(object sender, EventArgs e)
        {
            string studentNumber = txtStNumber.Text.Trim();
            if (!string.IsNullOrEmpty(studentNumber))
            {
                string connectionString = "data source=.; database=LMSDB; integrated security=SSPI";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Check if the student ID exists in the database
                    string checkQuery = "SELECT COUNT(*) FROM tblIssueBooks WHERE stNumber = @StudentNumber";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    int studentCount = (int)checkCmd.ExecuteScalar();
                    if (studentCount > 0)
                    {
                        // If the student exists, retrieve the data
                        string query = "SELECT Id, stName, stDepartment, stSemester, stContact, stEmail, bkName, bkIssueDate FROM tblIssueBooks WHERE stNumber = @StudentNumber and bkReturnDate is null";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@StudentNumber", studentNumber);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên có mã " + studentNumber + " không tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Thầy/ cô vui lòng nhập mã SV", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        string bkName;
        string bkIssueDate;
        Int64 rowId;
        int stID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                stID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                string connectionString = "data source=.; database=LMSDB; integrated security=SSPI";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Id, stName, stDepartment, stSemester, stContact, stEmail, bkName, bkIssueDate FROM tblIssueBooks WHERE Id = @StudentID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@StudentID", stID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    rowId = Int64.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                    txtBkName.Text = ds.Tables[0].Rows[0]["bkName"].ToString();
                    bkName = ds.Tables[0].Rows[0]["bkName"].ToString();
                    txtBkIssueDate.Text = ds.Tables[0].Rows[0]["bkIssueDate"].ToString();
                    bkIssueDate = ds.Tables[0].Rows[0]["bkIssueDate"].ToString();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đúng hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnbkreturn_Click(object sender, EventArgs e)
        {
            //check if the txtBkIssueDate and the txtBkName is empty or not
            if (string.IsNullOrEmpty(txtBkIssueDate.Text) || string.IsNullOrEmpty(txtBkName.Text))
            {
                MessageBox.Show("Vui lòng chọn sách", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                String CS = "data source=.; database = LMSDB; integrated security=SSPI";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "Update tblIssueBooks set bkReturnDate='" + returnDate.Text + "' where stNumber='" + txtStNumber.Text + "' and Id=" + rowId + " ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sách " + bkName + " đã trả thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //clear the textboxes
                txtBkName.Clear();
                txtBkIssueDate.Clear();
                txtStNumber.Clear();
                dataGridView1.DataSource = null;
            }

        }

        private void txtStNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtStNumber.Text == "")
            {
                dataGridView1.DataSource = null;
                txtBkName.Clear();
                txtBkIssueDate.Clear();
            }
        }

        private void btnStRefresh_Click(object sender, EventArgs e)
        {
            txtStNumber.Clear();
        }
    }
}
