using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace MDB_ImageGallery
{
    public partial class FormMain : Form
    {
        public string loggedUserName;
        public int loggedUserID;


        public FormMain()
        {
            InitializeComponent();
            this.loggedUserName = FormLogin.loggedUserName;
            this.loggedUserID = FormLogin.loggedUserID;
            lbHello.Text = $"Hello, {this.loggedUserName}, ID = {this.loggedUserID} !";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imageGalleryDataSet.Photo' table. You can move, or remove it, as needed.
            this.photoTableAdapter.Fill(this.imageGalleryDataSet.Photo);

            // Load list image to data grid view
            LoadDataGridView();
        }

        public void LoadDataGridView()
        {
            string strConnectionString = @"Data Source=DESKTOP-NLPSM68\SQLEXPRESS;Initial Catalog=ImageGallery;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "SELECT * FROM Photo";
            SqlDataAdapter sdaResetGridView = new SqlDataAdapter(query, conn);
            DataTable dtResetGridView = new DataTable();
            sdaResetGridView.Fill(dtResetGridView);
            /*
            BindingSource bsGridView = new BindingSource();
            bsGridView.DataSource = dtResetGridView;
            */
            dataGridView.DataSource = dtResetGridView;
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Windows.Forms.Application.Exit();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            { Filter = "Image files(*.jpg; *.jpeg; *.png)|*.jpg|*.jpeg|*.png", Multiselect = false })
            {
                ofd.InitialDirectory = @"D:\Sources\C# winform application\MDB_ImageGallery\Data";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // When upload, choose image as current image
                    pbImage.Image = Image.FromFile(ofd.FileName);
                    txtImagePath.Text = ofd.FileName;
                    string currImagePath = ofd.FileName;

                    ImageClassificationModel icModel = new ImageClassificationModel(currImagePath);
                    string pred_category = icModel.Classification();
                    pred_category = pred_category.Replace("'", "");
                    MessageBox.Show(pred_category);


                    string strConnectionString = @"Data Source=DESKTOP-NLPSM68\SQLEXPRESS;Initial Catalog=ImageGallery;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(strConnectionString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "SELECT category_id FROM Category WHERE category_name = '" + pred_category.ToString() + "'";
                    SqlDataAdapter sdaGetCategoryId = new SqlDataAdapter(query, conn);
                    DataTable dtGetCategoryId = new DataTable();
                    sdaGetCategoryId.Fill(dtGetCategoryId);
                    int currCategoryId = Int32.Parse(dtGetCategoryId.Rows[0][0].ToString());


                    SqlCommand sqlCmd = new SqlCommand("InsertImage", conn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@PhotoPath", currImagePath.Trim());
                    sqlCmd.Parameters.AddWithValue("@AccountId", loggedUserID);
                    sqlCmd.Parameters.AddWithValue("@CategoryId", currCategoryId);
                    sqlCmd.ExecuteNonQuery();
                    conn.Close();

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    // Set Image user account and display information to form
                    int currImageAccountId = this.loggedUserID;
                    string currImageAccountName = this.loggedUserName;
                    lblImageAccountName.Text = "From account: " + currImageAccountName;
                    lblImageCategory.Text = "Category: " + pred_category;


                    LoadDataGridView();
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtImagePath.Text = "";
            DataTable dtImage = dataGridView.DataSource as DataTable;
            if (dtImage != null)
            {
                string strConnectionString = @"Data Source=DESKTOP-NLPSM68\SQLEXPRESS;Initial Catalog=ImageGallery;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConnectionString);
                if(e.RowIndex < dtImage.Rows.Count)
                {
                    DataRow row = dtImage.Rows[e.RowIndex];
                    // Visualize to Image ID label
                    int currImageId = Int32.Parse(row["photo_id"].ToString());
                    lblImageId.Text = "Image ID: " + currImageId.ToString();
                    // Visualize to From Account label
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    int currImageAccountId = Int32.Parse(row["account_id"].ToString());
                    string query = "SELECT account_name FROM Accounts WHERE account_id = '" + currImageAccountId.ToString() + "'";
                    SqlDataAdapter sdaGetAccountName = new SqlDataAdapter(query, conn);
                    DataTable dtGetAccountName = new DataTable();
                    sdaGetAccountName.Fill(dtGetAccountName);
                    string currImageAccountName = dtGetAccountName.Rows[0][0].ToString();
                    lblImageAccountName.Text = "From account: " + currImageAccountName;
                    // Visualize to Category 
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    int currCategoryId = Int32.Parse(row["category_id"].ToString());
                    query = "SELECT category_name FROM Category WHERE category_id = '" + currCategoryId.ToString() + "'";
                    SqlDataAdapter sdaGetCategory = new SqlDataAdapter(query, conn);
                    DataTable dtGetCategory = new DataTable();
                    sdaGetCategory.Fill(dtGetCategory);
                    string currImageCategory = dtGetCategory.Rows[0][0].ToString();
                    lblImageCategory.Text = "Category: " + currImageCategory;

                    // Visualize to Picture box
                    string currImagePath = row["photo_path"].ToString();
                    pbImage.Image = Image.FromFile(currImagePath);
                }
                else
                {
                    
                }
            }
        }

        private void txtImagePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
