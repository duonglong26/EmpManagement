using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace EmpManagement
{
    public partial class FormForgotPassword : Form
    {
        /*
            Connection to SQL Server
         */
        SqlConnection conn = Utils.connectionSqlServer;
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private static FormForgotPassword instance;

        private static readonly object lockObject = new object();

        public static FormForgotPassword getInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new FormForgotPassword();
                    }
                }
            }
            instance.txtUsername.Text = "";
            return instance;
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnGetCodeResetPw_Click(object sender, EventArgs e)
        {
            if (!isExistUsername())
            {
                MessageBox.Show("Username does not exist!");
            }
            else
            {
                MessageBox.Show("Sending mail");

                // gen otp
                Random rnd = new Random();
                var otp = rnd.Next(1000, 9999);

                // save otp
                DateTime expireTimeOtp = DateTime.Now.AddMinutes(3);
                // expire time otp is 3 munites

                try
                {
                    // disable old OTP by username
                    conn.Open();
                    String queryDisableOtp = Utils.getQueryDisableOtpTransaction(txtUsername.Text.Trim());
                    SqlCommand cmd = new SqlCommand(queryDisableOtp, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    // gen OTP
                    conn.Open();
                    String query = Utils.getQueryInsertOtpTransaction(otp, expireTimeOtp, txtUsername.Text.Trim());
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                    return;
                }

                MailMessage mailMessage = new MailMessage("chuongtrinhngoaikiem@gmail.com", txtUsername.Text.Trim());
                mailMessage.Subject = "OTP_RESET_PASSWORD_FROM_SYSTEM";
                mailMessage.Body = "Code reset password for " + txtUsername.Text.Trim() + ": " + otp;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                NetworkCredential nc = new NetworkCredential("chuongtrinhngoaikiem@gmail.com",
                    System.Text.Encoding.UTF8.GetString(Convert.FromBase64String("dmlldG5hbTIwMjI=")));
                smtp.Credentials = nc;
                smtp.EnableSsl = true;
                smtp.Send(mailMessage);
                MessageBox.Show("OTP will expire in 3 minutes. Please check your email.");

                // show form input OTP
                FormConfirmOTP.getInstance().Show();
                FormConfirmOTP.getInstance().setUserName(txtUsername.Text.Trim());
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin.getInstance().Show();
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
    }
}
