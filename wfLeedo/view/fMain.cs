using BanGiay_N11;
using BanGiay_N11.viewModel;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfLeedo.view;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace wfLeedo
{
    public partial class fMain : Form
    {
        fDonHang fdonhang;
        fQuanLy fquanly;
        fSanPham fsanpham;
        private string idNV;
        public fMain(string id)
        {
            InitializeComponent();
            this.idNV = id;
        }







        private void btnDonHang_Click(object sender, EventArgs e)
        {
            fdonhang = new fDonHang();
            openPanel(fdonhang);
        }






        private void fMain_Load(object sender, EventArgs e)
        {
            employeeViewModel employeeViewModel = new employeeViewModel();

            employee emp = employeeViewModel.dataEmployee(idNV);
            string chucvu = emp.ChucVu;

            if (chucvu == "Chuyên viên quản lý kho" || chucvu == "Chuyên viên kế toán tài chính" || chucvu == "Chuyên viên quản lý nhân sự")
            {
                btnDonHang.Enabled = false;
            }
            else if (chucvu == "Chuyên viên chăm sóc khách hàng" || chucvu == "Chuyên viên tư vấn sản phẩm")
            {
                btnQuanLy.Enabled = false;
            }
            else if (chucvu == "Quản trị viên")
            {
                btnDonHang.Enabled = true;
                btnQuanLy.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            fquanly = new fQuanLy(idNV);
            openPanel(fquanly);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            fsanpham = new fSanPham();
            openPanel(fsanpham);
        }

        private void openPanel(Form form)
        {
            this.pnMain.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.Text = form.Text;
            this.pnMain.Controls.Add(form);
            form.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                this.Hide();
                fLogin fLogin = new fLogin();
                fLogin.ShowDialog();
                this.Close();
            }
            if (res == DialogResult.Cancel)
            {

            }
        }
    }
}
