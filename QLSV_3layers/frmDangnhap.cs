using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3layers
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }
        public string tendangnhap = "";
        public string loaitk = "";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            #region ktr_rangbuoc
            if (cbbLoaiTaiKhoan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }
            if(string.IsNullOrEmpty(txtTenDangNhap.Text) ) { MessageBox.Show("Vui lòng nhập tên đăng nhập");
                txtTenDangNhap.Select();
                return; 
            }
            if(string.IsNullOrEmpty (txtMatKhau.Text) )
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                txtMatKhau.Select();
                return;
            }
            #endregion
            tendangnhap = txtTenDangNhap.Text;
            #region swtk
            switch (cbbLoaiTaiKhoan.Text)
            {
                case "Quản trị viên":
                    loaitk = "admin";
                    break;
                case "Giáo viên":
                    loaitk = "gv";
                    break;
                case "Sinh viên":
                    loaitk = "sv";
                    break;
            }
            #endregion
            List<CustomParameter> lst = new List<CustomParameter>() { 
                new CustomParameter()
                {
                    key = "@loaitaikhoan",
                    value = loaitk
                },
                new CustomParameter()
                {
                    key = "@taikhoan",
                    value = txtTenDangNhap.Text
                },
                new CustomParameter()
                {
                    key = "@matkhau",
                    value = txtMatKhau.Text
                },
            };
            var rs = new Database().SelectData("dangnhap", lst);

            if(rs.Rows.Count > 0 )
            {
                this.Hide();
                //new formMain().ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
            }
        }
    }
}
