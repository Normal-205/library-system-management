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
    public partial class CompleteBookDetail : Form
    {
        public CompleteBookDetail()
        {
            InitializeComponent();
        }

        private void circularPicture1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompleteBookDetail_Load(object sender, EventArgs e)
        {
            String CS = "data source=.; database = LMSDB; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = " select *from tblIssueBooks where bkReturnDate is null";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);
                dgvIssueBooks.DataSource = dataSet.Tables[0];
                /* 2nd gridview reurn book part*/
                cmd.CommandText = " select *from tblIssueBooks where bkReturnDate is not null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet dataSet1 = new DataSet();
                da1.Fill(dataSet1);
                dgvReturnBooks.DataSource = dataSet1.Tables[0];
            }
        }

        private void btnExportIssue_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvIssueBooks, "Sách đã được mượn ");
        }

        private void btnExportReturn_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvReturnBooks, "Sách đã được trả ");
        }

        private void ExportToExcel(DataGridView urDataGridView, string fileName)
        {
            //export the datagridview to excel file named "BooksInfo + today's date".xlsx
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "StudentInfo";
            // Add column headers
            for (int i = 1; i <= urDataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = urDataGridView.Columns[i - 1].HeaderText;
            }

            // Add data from the datagridview to the worksheet
            for (int i = 0; i < urDataGridView.Rows.Count; i++)
            {
                for (int j = 1; j <= urDataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j] = urDataGridView.Rows[i].Cells[j - 1].Value.ToString();
                }
            }
            int lastRowIndex = urDataGridView.Rows.Count + 2; // +2 because you have headers and a 1-based index
            int lastColumnIndex = urDataGridView.Columns.Count + 1; // +1 because you're adding a new column
            //the time the file is exported
            string exportedAt = "File được xuất lúc: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            worksheet.Cells[lastRowIndex, lastColumnIndex] = exportedAt;

            //asking user to save file with a dialog box, file name is "BooksInfo + today's date".xlsx
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName + DateTime.Now.ToString("dd-MM-yyyy") + ".xlsx";
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
