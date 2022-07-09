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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string usernname = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            
            if(usernname == "")
            {
                MessageBox.Show("Username is empty!");
                txtUsername.Focus();
            }
            if (password == "")
            {
                MessageBox.Show("Password is empty!");
                txtPassword.Focus();
            }
            if (confirmPassword == "")
            {
                MessageBox.Show("Confirm password is empty!");
                txtConfirmPassword.Focus();
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Password didn't match!");
                txtConfirmPassword.Focus();
            }
            else
            {
                string strConnectionString = @"Data Source=DESKTOP-NLPSM68\SQLEXPRESS;Initial Catalog=ImageGallery;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT COUNT(*) FROM Accounts WHERE account_name = '" + usernname + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtTable = new DataTable();
                sda.Fill(dtTable);
                if (dtTable.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Username exists!");
                    txtUsername.Focus();
                }
                else
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand sqlCmd = new SqlCommand("AddUser", conn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Username", usernname.Trim());
                    sqlCmd.Parameters.AddWithValue("@Userpassword", password.Trim());
                    sqlCmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Created");
                    this.Hide();
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                }
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Windows.Forms.Application.Exit();
        }

        private void FormRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}
