using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmpManagement
{
    public partial class Employee : Form
    {

        /*
            Connection to SQL Server
         */
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6E8C1ESV\SQLEXPRESS;Initial Catalog=MyEmployeeDb;Integrated Security=True");

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void txtEmpCode_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            if (isEmptyField())
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = Utils.getQueryInsertEmp(txtEmpCode.Text, txtEmpName.Text, txtEmpAddress.Text,
                       cbbEmpPosition.Text, cbbEmpGender.Text, empDateOfBirth.Value.Date.ToString("yyyy-MM-dd"), txtEmpPhone.Text, txtEmpEducation.Text);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Added");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }


        private bool isEmptyField()
        {
            return txtEmpCode.Text == "" || txtEmpName.Text == "" || txtEmpPhone.Text == "" ||
                txtEmpEducation.Text == "" || txtEmpAddress.Text == "" ||
                cbbEmpPosition.Text == Utils.NO_OPTION;
        }

        private void empDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void exitAppication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
