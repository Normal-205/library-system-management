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
    public partial class BookSearch : Form
    {
        public BookSearch()
        {
            InitializeComponent();
        }

        private void BookSearch_Load(object sender, EventArgs e)
        {
            String CS = "data source=.; database = LMSDB; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(CS))
            {

                SqlCommand cmd = new SqlCommand("select bkId, bkName, bkAuthor, bkPublication,bkDate from tblBookInfos", con);
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        /*
        private void LoadAllBooks()
        {
            string connectionString = "data source=.; database=LMSDB; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "SELECT bkName as BookName, bkAuthor as BookAuthor, bkPublication as BookPublication, bkDate as BookDate " +
                             "FROM tblBookInfos";

                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Load the data to the DataGridView
                LoadDataToDataGridView(dataTable);
            }
        }
        */
        private DataTable dataTable; 
        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            string searchName = txtBookName.Text.Trim();
            /*
            if (string.IsNullOrEmpty(searchName))
            {
                LoadAllBooks();
                return;
            }
            */
            if (txtBookName.Text != "")
            {
                String CS = "data source=.; database = LMSDB; integrated security=SSPI";
                using (SqlConnection con = new SqlConnection(CS))
                {

                    SqlCommand cmd = new SqlCommand("select bkId, bkName, bkAuthor, bkPublication, bkDate from tblBookInfos where bkName like N'" + txtBookName.Text + "%'", con);
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

                    SqlCommand cmd = new SqlCommand("select bkId, bkName, bkAuthor, bkPublication, bkDate from tblBookInfos", con);
                    con.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    dataGridView1.DataSource = dataset.Tables[0];
                }
            }
        }
        


        private void btnRefreshbkname_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
        }

        private void circularPicture1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
