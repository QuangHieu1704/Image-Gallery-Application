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

namespace MDB_ImageGallery
{
    public partial class FormLogin : Form
    {
        public static string loggedUserName;
        public static int loggedUserID;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "Admin";
            txtPassword.Text = "1";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernname = txtUsername.Text;
            string password = txtPassword.Text;
            if(usernname == "")
            {
                MessageBox.Show("Username is empty");
                txtUsername.Focus();
            }
            if(password == "")
            {
                MessageBox.Show("Password is empty");
                txtPassword.Focus();
            }
            if(usernname != "" && password != "")
            {
                string strConnectionString = @"Data Source=DESKTOP-NLPSM68\SQLEXPRESS;Initial Catalog=ImageGallery;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT COUNT(*) FROM Accounts WHERE account_name = '" + txtUsername.Text + "' AND account_password='" + txtPassword.Text + "'";
                SqlDataAdapter sdaCheckUser = new SqlDataAdapter(query, conn);
                DataTable dtTableCheckUser = new DataTable();
                sdaCheckUser.Fill(dtTableCheckUser);
                if (dtTableCheckUser.Rows[0][0].ToString() == "1")
                {
                    loggedUserName = usernname;
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    query = "SELECT account_id FROM Accounts WHERE account_name = '" + txtUsername.Text + "'";
                    SqlDataAdapter sdaGetUserId = new SqlDataAdapter(query, conn);
                    DataTable dtTableGetUserId = new DataTable();
                    sdaGetUserId.Fill(dtTableGetUserId);
                    loggedUserID = Int32.Parse(dtTableGetUserId.Rows[0][0].ToString());
                    this.Hide();
                    FormMain formMain = new FormMain();
                    formMain.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
                conn.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Windows.Forms.Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
       
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
