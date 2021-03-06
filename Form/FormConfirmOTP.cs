using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmpManagement
{
    public partial class FormConfirmOTP : Form
    {
        /*
            Connection to SQL Server
         */
        SqlConnection conn = Utils.connectionSqlServer;
        public FormConfirmOTP()
        {
            InitializeComponent();
        }

        private static FormConfirmOTP instance;

        private static readonly object lockObject = new object();

        public static FormConfirmOTP getInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new FormConfirmOTP();
                    }
                }
            }
            instance.txtOtp.Text = "";
            return instance;
        }

        private String username;
        public void setUserName(String username)
        {
            this.username = username;
        }
        private void btnConfirmOtp_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String query = Utils.getQueryCheckOtp(txtOtp.Text.Trim(), username);
                SqlCommand cmd = new SqlCommand(query, conn);
                Int32 result = (Int32)cmd.ExecuteScalar();
                conn.Close();
                if (result > 0)
                {
                    conn.Open();
                    String queryDisableOtp = Utils.getQueryDisableOtpTransactionByOtp(txtOtp.Text.Trim());
                    SqlCommand cmdDisableOtp = new SqlCommand(queryDisableOtp, conn);
                    cmdDisableOtp.ExecuteNonQuery();
                    conn.Close();

                    FormConfirmPassword.getInstance().Show();
                    FormConfirmPassword.getInstance().setUsername(username);
                    FormForgotPassword.getInstance().Hide();
                    this.Hide();
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            MessageBox.Show("OTP wrong!");
        }

        private void ConfirmOTP_Load(object sender, EventArgs e)
        {
            
        }
    }
}
