using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace EmpManagement
{
    public partial class FormSignUp : Form
    {
        /*
            Connection to SQL Server
         */
        SqlConnection conn = Utils.connectionSqlServer;
        public FormSignUp()
        {
            InitializeComponent();
        }

        private static FormSignUp instance;

        private static readonly object lockObject = new object();

        public static FormSignUp getInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new FormSignUp();
                    }
                }
            }
            instance.resetForm();
            return instance;
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
            } else if (!isValidEmail(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Username require is a email!");
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
                    String query = Utils.getQueryInsertAccount(txtUsername.Text.Trim(), BCrypt.Net.BCrypt.HashPassword(txtPassword.Text.Trim()));
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success");
                    handleBackToLogin();
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
            handleBackToLogin();
        }

        private void handleBackToLogin()
        {
            resetForm();
            FormLogin.getInstance().Show();
            this.Hide();
        }

        private bool isValidEmail(String username)
        {
            return new EmailAddressAttribute().IsValid(username);
        }

        private void resetForm()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

    }
}
