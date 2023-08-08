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
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                stId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
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
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStudentname_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentNumber.Text != "")
            {
                String CS = "data source=.; database = LMSDB; integrated security=SSPI";
                using (SqlConnection con = new SqlConnection(CS))
                {

                    SqlCommand cmd = new SqlCommand("select * from tblStudentInfos where stNumber like '" + txtStudentNumber.Text + "%'", con);
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
                    SqlCommand cmd = new SqlCommand("select * from tblStudentInfos", con);
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
            txtStudentNumber.Clear();
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
                            MessageBox.Show("Cập nhật dữ liệu thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sinh viên có mã là  " + stNumber + "  đã được xoá!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Xoá không thành công!\nVui lòng kiểm tra lại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi khi xoá dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                //refreshing datagridview
                SqlCommand cmd1 = new SqlCommand("select * from tblStudentInfos", con);
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(cmd1);
                DataSet dataset1 = new DataSet();
                dataAdapter1.Fill(dataset1);
                dataGridView1.DataSource = dataset1.Tables[0];

            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            //export the datagridview to excel file named "BooksInfo + today's date".xlsx
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "StudentInfo";
            // Add column headers
            for (int i = 1; i <= dataGridView1.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            // Add data from the datagridview to the worksheet
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 1; j <= dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j] = dataGridView1.Rows[i].Cells[j - 1].Value.ToString();
                }
            }
            // Add "Exported in 11AM" to the last row
            int lastRowIndex = dataGridView1.Rows.Count + 2; // +2 because you have headers and a 1-based index
            int lastColumnIndex = dataGridView1.Columns.Count + 1; // +1 because you're adding a new column
            //the time the file is exported
            string exportedAt = "File được xuất lúc: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            worksheet.Cells[lastRowIndex, lastColumnIndex] = exportedAt;

            //asking user to save file with a dialog box, file name is "BooksInfo + today's date".xlsx
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "DS SinhVien " + DateTime.Now.ToString("dd-MM-yyyy") + ".xlsx";
            saveFileDialog.DefaultExt = ".xlsx";
            saveFileDialog.Filter = "Excel Files|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save the workbook and release resources
                try
                {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Đã huỷ xuất dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Exit the method early
            }
            app.Quit();
        }
    }
}
