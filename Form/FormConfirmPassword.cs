using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmpManagement
{
    public partial class FormConfirmPassword : Form
    {
        /*
            Connection to SQL Server
         */
        SqlConnection conn = Utils.connectionSqlServer;
        public FormConfirmPassword()
        {
            InitializeComponent();
        }

        private static FormConfirmPassword instance;

        private static readonly object lockObject = new object();

        public static FormConfirmPassword getInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new FormConfirmPassword();
                    }
                }
            }
            instance.resetForm();
            return instance;
        }

        private String username;

        public void setUsername(String username)
        {
            this.username = username;
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Require New Password same Confirm Password");
            }
            else
            {
                try
                {
                    conn.Open();

                    String query = Utils.getQueryUpdatePasswordUsername(BCrypt.Net.BCrypt.HashPassword(txtConfirmPassword.Text.Trim()), username);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success");

                    conn.Close();

                    FormLogin.getInstance().Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }

        private void resetForm()
        {
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
        }
    }
}
