﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmpManagement
{
    public partial class Login : Form
    {
        /*
            Connection to SQL Server
         */
        SqlConnection conn = Utils.connectionSqlServer;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please fill username/password");
                return;
            }


            //Home home = new Home();
            //home.Show();
            //this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
