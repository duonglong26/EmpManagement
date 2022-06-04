using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmpManagement
{
    public partial class FormFilterEmployee : Form
    {
        /*
            Connection to SQL Server
         */
        SqlConnection conn = Utils.connectionSqlServer;
        public FormFilterEmployee()
        {
            InitializeComponent();
        }

        private static FormFilterEmployee instance;

        private static readonly object lockObject = new object();

        public static FormFilterEmployee getInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new FormFilterEmployee();
                    }
                }
            }
            instance.resetForm();
            instance.loadTableEmpData();
            return instance;
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String query = Utils.getQuerySearchEmp(txtEmpCode.Text.Trim(), txtEmpName.Text.Trim(), txtEmpAddress.Text.Trim(),
                   cbbEmpPosition.Text.Trim(), cbbEmpGender.Text.Trim());
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var listEmp = new DataSet();
                adapter.Fill(listEmp);
                dataGridViewEmps.DataSource = listEmp.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void FilterEmployee_Load(object sender, EventArgs e)
        {
            loadTableEmpData();
        }

        private void loadTableEmpData()
        {
            try
            {
                conn.Open();
                String query = Utils.getQueryGetAllEmp();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var listEmp = new DataSet();
                adapter.Fill(listEmp);
                dataGridViewEmps.DataSource = listEmp.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewEmps_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGoToHome_Click(object sender, EventArgs e)
        {
            FormHome.getInstance().Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetForm()
        {
            cbbEmpGender.SelectedIndex = 0;
            cbbEmpPosition.SelectedIndex = 0;
            txtEmpCode.Text = "";
            txtEmpName.Text = "";
            txtEmpAddress.Text = "";
        }
    }
}
