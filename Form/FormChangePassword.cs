using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmpManagement
{
    public partial class FormChangePassword : Form
    {
        /*
            Connection to SQL Server
         */
        SqlConnection conn = Utils.connectionSqlServer;


        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGoToHome_Click(object sender, EventArgs e)
        {
            handleGoToHome();
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            if (isEmptyData())
            {
                MessageBox.Show("Please fill all data");
            }
            else
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
                        String query = Utils.getQueryPasswordByCurrentUser();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataReader sqlDataReader = cmd.ExecuteReader();
                        SqlDataReader sqlDataReader2 = sqlDataReader;
                        while (sqlDataReader2.Read())
                        {
                            bool checkPass = BCrypt.Net.BCrypt.Verify(txtOldPassword.Text.Trim(), sqlDataReader["password"].ToString());

                            if (checkPass)
                            {
                                conn.Close();
                                conn.Open();

                                query = Utils.getQueryUpdatePasswordByCurrentUser(BCrypt.Net.BCrypt.HashPassword(txtConfirmPassword.Text.Trim()));
                                cmd = new SqlCommand(query, conn);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Success");

                                conn.Close();

                                handleGoToHome();

                                return;
                            }
                            else
                            {
                                MessageBox.Show("Old password wrong!");
                            }

                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        conn.Close();
                    }
                }
            }
        }

        private bool isEmptyData()
        {
            return txtOldPassword.Text.Trim() == "" || txtNewPassword.Text.Trim() == ""
                || txtConfirmPassword.Text.Trim() == "";
        }

        private void txtOldPassword_Click(object sender, EventArgs e)
        {

        }

        private void handleGoToHome()
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}
