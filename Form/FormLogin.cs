using EmpManagement.Enity;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmpManagement
{
    public partial class FormLogin : Form
    {
        /*
            Connection to SQL Server
         */
        SqlConnection conn = Utils.connectionSqlServer;
        public FormLogin()
        {
            InitializeComponent();
        }

        private static FormLogin instance;

        private static readonly object lockObject = new object();

        public static FormLogin getInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new FormLogin();
                    }
                }
            }
            instance.resetForm();
            return instance;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
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
                        Session.sessionUsername = txtUsername.Text.Trim();
                        MessageBox.Show("Login success");
                        FormHome.getInstance().Show();
                        this.Hide();
                    }
                }

                conn.Close();

                // account not found
                if (Session.sessionUsername == null)
                {
                    MessageBox.Show("Login fail!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp.getInstance().Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            
        }

        private void forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormForgotPassword.getInstance().Show();
            this.Hide();
        }

        private void resetForm()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
