using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmpManagement
{
    public partial class SignUp : Form
    {
        /*
            Connection to SQL Server
         */
        SqlConnection conn = Utils.connectionSqlServer;
        public SignUp()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (isExistUsername())
            {
                MessageBox.Show("Username is already exist!");
                return;
            }
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Missing data");
            } else
            {
                try
                {
                    conn.Open();
                    String query = Utils.getQueryInsertAccount(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success");
                    conn.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }

        private bool isExistUsername()
        {
            try
            {
                conn.Open();
                String query = Utils.getQueryCheckExistUsernameAccount(txtUsername.Text.Trim());
                SqlCommand cmd = new SqlCommand(query, conn);
                Int32 result = (Int32)cmd.ExecuteScalar();
                conn.Close();
                if (result > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
