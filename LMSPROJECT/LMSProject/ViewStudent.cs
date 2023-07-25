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
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void circularPicture1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            String CS = "data source=.; database = LMSDB; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {

                SqlCommand cmd = new SqlCommand("select * from tblStudentInfos", con);
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
            }
        }
        int stId;
        Int64 rowId;
        string stNumber;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                stId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            String CS = "data source=.; database = LMSDB; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {

                SqlCommand cmd = new SqlCommand("select *from tblStudentInfos where stId ='" + stId + "' ", con);
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                stNumber = dataset.Tables[0].Rows[0][2].ToString();
                rowId = Int64.Parse(dataset.Tables[0].Rows[0][0].ToString());
                txtStName.Text = dataset.Tables[0].Rows[0][1].ToString();
                txtStNumber.Text = dataset.Tables[0].Rows[0][2].ToString();
                txtStDepartment.Text = dataset.Tables[0].Rows[0][3].ToString();
                txtStSemester.Text = dataset.Tables[0].Rows[0][4].ToString();
                txtStContact.Text = dataset.Tables[0].Rows[0][5].ToString();
                txtStEmail.Text = dataset.Tables[0].Rows[0][6].ToString();
            }
        }

        private void txtStudentname_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentname.Text != "")
            {
                String CS = "data source=.; database = LMSDB; integrated security=SSPI";
                using (SqlConnection con = new SqlConnection(CS))
                {

                    SqlCommand cmd = new SqlCommand("select *from tblStudentInfos where stName like '" + txtStudentname.Text + "%'", con);
                    con.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    dataGridView1.DataSource = dataset.Tables[0];
                }
            }
            else
            {
                String CS = "data source=.; database = LMSDB; integrated security=SSPI";
                using (SqlConnection con = new SqlConnection(CS))
                {

                    SqlCommand cmd = new SqlCommand("select *from tblStudentInfos", con);
                    con.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    dataGridView1.DataSource = dataset.Tables[0];
                }
            }
        }

        private void btnStNameRefresh_Click(object sender, EventArgs e)
        {
            txtStudentname.Clear();
        }

        private void btnStInofRefresh_Click(object sender, EventArgs e)
        {
            txtStName.Clear();
            txtStNumber.Clear();
            txtStDepartment.Clear();
            txtStSemester.Clear();
            txtStContact.Clear();
            txtStEmail.Clear();
        }

        private void btnStUpdate_Click(object sender, EventArgs e)
        {
            String CS = "data source=.; database = LMSDB; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {
                if (MessageBox.Show("Dữ liệu sẽ được cập nhật.\nBạn có chắc chắn không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string sqlQuery = "UPDATE tblStudentInfos SET stName = @stName, stNumber = @stNumber, stDepartment = @stDepartment, " +
                          "stSemester = @stSemester, stContact = @stContact, stEmail = @stEmail WHERE stId = @stId";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@stName", txtStName.Text);
                    cmd.Parameters.AddWithValue("@stNumber", txtStNumber.Text);
                    cmd.Parameters.AddWithValue("@stDepartment", txtStDepartment.Text);
                    cmd.Parameters.AddWithValue("@stSemester", txtStSemester.Text);
                    cmd.Parameters.AddWithValue("@stContact", Int64.Parse(txtStContact.Text));
                    cmd.Parameters.AddWithValue("@stEmail", txtStEmail.Text);
                    cmd.Parameters.AddWithValue("@stId", rowId);
                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm dữ liệu thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công!\nVui lòng kiểm tra lại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi khi cập nhật dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtStName.Clear();
                    txtStNumber.Clear();
                    txtStDepartment.Clear();
                    txtStSemester.Clear();
                    txtStContact.Clear();
                    txtStEmail.Clear();
                    //refreshing datagridview
                    SqlCommand cmd1 = new SqlCommand("select * from tblStudentInfos", con);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd1);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    dataGridView1.DataSource = dataset.Tables[0];
                }

            }
        }

        private void btnStDelete_Click(object sender, EventArgs e)
        {
            String CS = "data source=.; database = LMSDB; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {
                if (MessageBox.Show("Dữ liệu sẽ bị xoá.\nBạn có chắc chắn không?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand("Delete from tblStudentInfos where stId =" + rowId + " ", con);
                    con.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    MessageBox.Show("Sinh viên có mã là  " + stNumber + "  đã được xoá!", " Success" + MessageBoxButtons.OK + MessageBoxIcon.Information);
                   
                }
                //refreshing datagridview
                SqlCommand cmd1 = new SqlCommand("select * from tblStudentInfos", con);
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(cmd1);
                DataSet dataset1 = new DataSet();
                dataAdapter1.Fill(dataset1);
                dataGridView1.DataSource = dataset1.Tables[0];

            }
        }
    }
}
