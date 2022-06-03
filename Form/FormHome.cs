using EmpManagement.Enity;
using System;
using System.Windows.Forms;

namespace EmpManagement
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private static FormHome instance;

        private static readonly object lockObject = new object();

        public static FormHome getInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new FormHome();
                    }
                }
            }
            return instance;
        }

        private void labelOpenEmployee_Click(object sender, EventArgs e)
        {
            handleOpenEmployee();
        }

        private void pictureOpenEmployee_Click(object sender, EventArgs e)
        {
            handleOpenEmployee();
        }

        private void handleOpenEmployee()
        {
            //Employee employee = new Employee();
            //employee.Show();
            FormEmployee.getInstance().Show();
            this.Hide();
        }

        private void openFormLogin_Click(object sender, EventArgs e)
        {
            Session.sessionUsername = null;
            //Login login = new Login();
            //login.Show();
            FormLogin.getInstance().Show();
            this.Hide();
        }

        private void openFormSearchEmp_Click(object sender, EventArgs e)
        {
            handleOpenFormSearchEmp();
        }

        private void pictureOpenFormSearchEmp_Click(object sender, EventArgs e)
        {
            handleOpenFormSearchEmp();
        }

        private void handleOpenFormSearchEmp()
        {
            //FilterEmployee filterEmp = new FilterEmployee();
            //filterEmp.Show();
            FormFilterEmployee.getInstance().Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureChangePassword_Click(object sender, EventArgs e)
        {
            handleShowFormPassword();
        }

        private void lbChangePassword_Click(object sender, EventArgs e)
        {
            handleShowFormPassword();
        }

        private void handleShowFormPassword()
        {
            //FormChangePassword formChangePassword = new FormChangePassword();
            //formChangePassword.Show();
            FormChangePassword.getInstance().Show();
            this.Hide();
        }
    }
}
