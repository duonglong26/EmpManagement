using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmpManagement
{
    public partial class Login : Form
    {
        /*
            Connection to SQL Server
         */
        SqlConnection conn = Utils.connectionSqlServer;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please fill username/password");
                return;
            }
            
            try
            {
                conn.Open();
                String query = Utils.getQueryAccountByUsername(txtUsername.Text.Trim());
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    bool checkPass = BCrypt.Net.BCrypt.Verify(txtPassword.Text.Trim(), sqlDataReader["password"].ToString());
                    
                    if (checkPass)
                    {
                        MessageBox.Show("Login success");
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    conn.Close();
                    return;
                }
                
                // account not found
                MessageBox.Show("Login fail!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
