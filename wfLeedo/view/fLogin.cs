﻿using BanGiay_N11.viewModel;
using Krypton.Toolkit;

namespace wfLeedo
{
    public partial class fLogin : KryptonForm
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginViewModel check = new loginViewModel();
            String username = txtUsername.Text;
            String password = txtPwd.Text;
            check.loginCheck(username, password);
            if (check.loginCheck(username, password) == true)
            {
                this.Hide();
                fMain mainForm = new fMain(username);
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
            }
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}