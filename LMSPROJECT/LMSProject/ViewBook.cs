using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSProject
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            String CS = "data source=.; database = LMSDB; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {

                SqlCommand cmd = new SqlCommand("select * from tblBookInfos", con);
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                // Call to the CellFormatting event before setting the DataSource
                dataGridView1.CellFormatting += dataGridView1_CellFormatting;
                dataGridView1.DataSource = dataset.Tables[0];
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Check if the cell value is an int, then format it with commas
                if (dataGridView1.Columns[e.ColumnIndex].ValueType == typeof(int))
                {
                    if (int.TryParse(e.Value?.ToString(), out int number))
                    {
                        e.Value = number.ToString("N0");
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void circularPicture1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int bkId;
        Int64 rowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                bkId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                String CS = "data source=.; database = LMSDB; integrated security=SSPI";
                using (SqlConnection con = new SqlConnection(CS))
                {

                    SqlCommand cmd = new SqlCommand("select * from tblBookInfos where bkId ='" + bkId + "' ", con);
                    con.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    rowId = Int64.Parse(dataset.Tables[0].Rows[0][0].ToString());
                    txtbkName.Text = dataset.Tables[0].Rows[0][1].ToString();
                    txtbkAuthor.Text = dataset.Tables[0].Rows[0][2].ToString();
                    txtbkPublication.Text = dataset.Tables[0].Rows[0][3].ToString();
                    txtbkDate.Text = dataset.Tables[0].Rows[0][4].ToString();
                    txtbkPrice.Text = dataset.Tables[0].Rows[0][5].ToString();
                    txtbkQuantity.Text = dataset.Tables[0].Rows[0][6].ToString();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if (txtBookName.Text != "")
            {
                String CS = "data source=.; database = LMSDB; integrated security=SSPI";
                using (SqlConnection con = new SqlConnection(CS))
                {

                    SqlCommand cmd = new SqlCommand("select * from tblBookInfos where bkName like N'" + txtBookName.Text + "%'", con);
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

                    SqlCommand cmd = new SqlCommand("select * from tblBookInfos", con);
                    con.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    dataGridView1.DataSource = dataset.Tables[0];
                }
            }
        }

        private void btnBkInfosRefresh_Click(object sender, EventArgs e)
        {
            txtbkName.Clear();
            txtbkAuthor.Clear();
            txtbkPublication.Clear();
            txtbkDate.Clear();
            txtbkPrice.Clear();
            txtbkQuantity.Clear();
        }

        private void btnBkInfosUpdate_Click(object sender, EventArgs e)
        {
            String CS = "data source=.; database = LMSDB; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {
                if (MessageBox.Show("Dữ liệu sẽ được cập nhật!\nBạn có chắc chắn không?", "Cập nhật sách", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    string sqlQuery = "UPDATE tblBookInfos SET bkName = @bkName, bkAuthor = @bkAuthor, bkPublication = @bkPublication, bkDate = @bkDate, bkPrice = @bkPrice, bkQuanity = @bkQuantity WHERE bkId = @bkId";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@bkName", txtbkName.Text);
                    cmd.Parameters.AddWithValue("@bkAuthor", txtbkAuthor.Text);
                    cmd.Parameters.AddWithValue("@bkPublication", txtbkPublication.Text);
                    cmd.Parameters.AddWithValue("@bkDate", txtbkDate.Text);
                    cmd.Parameters.AddWithValue("@bkPrice", txtbkPrice.Text);
                    cmd.Parameters.AddWithValue("@bkQuantity", txtbkQuantity.Text);
                    cmd.Parameters.AddWithValue("@bkId", bkId);
                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sách có mã ID =  " + bkId + "  đã được cập nhật.", " Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công!\nVui lòng kiểm tra lại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    txtbkName.Clear();
                    txtbkAuthor.Clear();
                    txtbkPublication.Clear();
                    txtbkDate.Clear();
                    txtbkPrice.Clear();
                    txtbkQuantity.Clear();
                    //refreshing datagridview
                    String sqlQuery2 = "select * from tblBookInfos";
                    SqlCommand cmd2 = new SqlCommand(sqlQuery2, con);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd2);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    dataGridView1.DataSource = dataset.Tables[0];
                }

            }
        }

        private void btnBkDelete_Click(object sender, EventArgs e)
        {
            String CS = "data source=.; database = LMSDB; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {
                if (MessageBox.Show("Dữ liệu sẽ bị xoá!\nBạn có chắn chắn không?", "Xoá sách", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    SqlCommand cmd = new SqlCommand("Delete from tblBookInfos where bkId =" + rowId + " ", con);
                    con.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    MessageBox.Show("Sách có mã ID =  " + bkId + " đã xoá thành công.", " Success" + MessageBoxButtons.OK + MessageBoxIcon.Information);
                    //clearing textboxes
                    txtbkName.Clear();
                    txtbkAuthor.Clear();
                    txtbkPublication.Clear();
                    //txtbkDate.Clear();
                    txtbkPrice.Clear();
                    txtbkQuantity.Clear();
                    //refreshing datagridview
                    String CS1 = "data source=.; database = LMSDB; integrated security=SSPI";
                    using (SqlConnection con1 = new SqlConnection(CS1))
                    {

                        SqlCommand cmd1 = new SqlCommand("select *from tblBookInfos", con1);
                        con1.Open();
                        SqlDataAdapter dataAdapter1 = new SqlDataAdapter(cmd1);
                        DataSet dataset1 = new DataSet();
                        dataAdapter1.Fill(dataset1);
                        dataGridView1.DataSource = dataset1.Tables[0];
                    }
                }

            }
        }

        private void txtbkPrice_TxtChanged(object sender, EventArgs e)
        {
            // Remove the event handler temporarily to prevent recursion
            txtbkPrice.TextChanged -= txtbkPrice_TxtChanged;

            // Replace thousand separators from the current text
            string cleanedText = txtbkPrice.Text.Replace(",", "");

            if (double.TryParse(cleanedText, out double value))
            {
                // Format the number with thousand separators
                txtbkPrice.Text = value.ToString("N0");
                txtbkPrice.SelectionStart = txtbkPrice.Text.Length;
            }

            // Reattach the event handler
            txtbkPrice.TextChanged += txtbkPrice_TxtChanged;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            //export the datagridview to excel file named "BooksInfo + today's date".xlsx
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "BooksInfo";
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
            saveFileDialog.FileName = "DS Sách " + DateTime.Now.ToString("dd-MM-yyyy") + ".xlsx";
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
