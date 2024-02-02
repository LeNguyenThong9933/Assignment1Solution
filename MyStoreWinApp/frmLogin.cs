using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessObject;
using System.Configuration;
using DataAccess.Repos;
using System.Text.Json;


namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "admin@fstore.com" && txtPassword.Text == "admin@@")
            {
                frmMemberManagement frmMemberManagement = new frmMemberManagement();
                frmMemberManagement.ShowDialog();

            }
            else 
            {
                MessageBox.Show("Username or password is incorrect", "Login failed", MessageBoxButtons.OK);
            }
        }
    }
}
