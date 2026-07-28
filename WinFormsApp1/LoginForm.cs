using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "12345";

            if(txtUser.Text == username && txtPass.Text == password)
            {
                MessageBox.Show("Login Successful!", "POS System",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                lblInfo.Text = "Invalid Username or Password";
                txtPass.Clear();
                txtPass.Focus();
            }
        }
    }
}
