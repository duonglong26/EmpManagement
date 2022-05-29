using EmpManagement.Enity;
using System;
using System.Windows.Forms;

namespace EmpManagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void openFormLogin_Click(object sender, EventArgs e)
        {
            Session.sessionUsername = null;
            Login login = new Login();
            login.Show();
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
            FilterEmployee filterEmp = new FilterEmployee();
            filterEmp.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
