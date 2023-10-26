using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using BanGiay_N11.viewModel;

namespace BanGiay_N11
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void Login_Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, this.Width-1, this.Height-1);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(250, 128, 114), Color.FromArgb(255,204,204), LinearGradientMode.Vertical);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            loginViewModel check = new loginViewModel();
            String username = txtUsername.Text;
            String password = txtPwd.Text;
            check.loginCheck(username, password);
            if(check.loginCheck(username, password) == true)
            {
                this.Hide();
                Main_Form mainForm = new Main_Form();
                mainForm.ShowDialog(); // Hiển thị Main_Form
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
            }
        }
    }
/*    public class RoundedButton : Button
    {
        public int radius = 10;
        System.Drawing.Drawing2D.GraphicsPath getRoundPath(Rectangle r, int radius) { }
    }*/
}
