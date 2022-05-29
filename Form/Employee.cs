using System;
using System.Data;
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
            loadTableEmpData();
        }

        private void txtEmpCode_Click(object sender, EventArgs e)
        {

        }

        private bool isEmptyField()
        {
            return txtEmpCode.Text == "" || txtEmpName.Text == "" || txtEmpPhone.Text == "" ||
                txtEmpEducation.Text == "" || txtEmpAddress.Text == "";
        }

        private void empDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void loadTableEmpData()
        {
            try
            {
                resetFormInput();
                conn.Open();
                String query = Utils.getQueryGetAllEmp();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var listEmp = new DataSet();
                adapter.Fill(listEmp);
                empDataGridViews.DataSource = listEmp.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitAppication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reloadDataGirdViews_Click(object sender, EventArgs e)
        {
            loadTableEmpData();
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            if (idEmp.Text == Utils.ID_EMPLOYEE_DEFAULT)
            {
                MessageBox.Show("Please choose employee");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = Utils.getQueryInactiveEmp(txtEmpCode.Text);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Success!");
                    conn.Close();
                    loadTableEmpData();
                    resetFormInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void empDataGridViews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            resetFormInput();
            idEmp.Text = empDataGridViews.CurrentRow.Cells[1].Value.ToString();
            txtEmpCode.Text = empDataGridViews.CurrentRow.Cells[2].Value.ToString();
            txtEmpName.Text = empDataGridViews.CurrentRow.Cells[3].Value.ToString();
            txtEmpAddress.Text = empDataGridViews.CurrentRow.Cells[4].Value.ToString();
            cbbEmpPosition.Text = empDataGridViews.CurrentRow.Cells[5].Value.ToString();
            cbbEmpGender.Text = empDataGridViews.CurrentRow.Cells[6].Value.ToString();
            empDateOfBirth.Text = empDataGridViews.CurrentRow.Cells[7].Value.ToString();
            txtEmpPhone.Text = empDataGridViews.CurrentRow.Cells[8].Value.ToString();
            txtEmpEducation.Text = empDataGridViews.CurrentRow.Cells[9].Value.ToString();
            cbbEmpGender.Focus();
            cbbEmpPosition.Focus();
        }

        private void resetFormInput()
        {
            idEmp.Text = "ID";
            txtEmpCode.Text = " ";
            txtEmpName.Text = " ";
            txtEmpAddress.Text = " ";
            cbbEmpPosition.Text = " ";
            cbbEmpGender.Text = " ";
            empDateOfBirth.Text = "";
            txtEmpPhone.Text = " ";
            txtEmpEducation.Text = " ";
        }

        private void saveEmp()
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
                    String query = Utils.getQueryInsertEmp(txtEmpCode.Text.Trim(), txtEmpName.Text.Trim(), txtEmpAddress.Text.Trim(),
                       cbbEmpPosition.Text.Trim(), cbbEmpGender.Text.Trim(), empDateOfBirth.Value.Date.ToString("yyyy-MM-dd"), txtEmpPhone.Text.Trim(), txtEmpEducation.Text.Trim());
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Added");
                    conn.Close();
                    loadTableEmpData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }

        private void updateEmp()
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
                    String query = Utils.getQueryUpdateEmpByCode(idEmp.Text.Trim(), txtEmpCode.Text.Trim(), txtEmpName.Text.Trim(), txtEmpAddress.Text.Trim(),
                       cbbEmpPosition.Text.Trim(), cbbEmpGender.Text.Trim(), empDateOfBirth.Value.Date.ToString("yyyy-MM-dd"), txtEmpPhone.Text.Trim(), txtEmpEducation.Text.Trim());
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Edited");
                    conn.Close();
                    loadTableEmpData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }

        private void saveOrUpdateEmp_Click(object sender, EventArgs e)
        {
            if (idEmp.Text == Utils.ID_EMPLOYEE_DEFAULT)
            {
                saveEmp();
            }
            else
            {
                updateEmp();
            }
        }
    }
}
