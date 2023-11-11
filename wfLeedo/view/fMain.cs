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

namespace wfLeedo
{
    public partial class fMain : Form
    {
        fDonHang fdonhang;
        fQuanLy fquanly;
        fSanPham fsanpham;
        public fMain()
        {
            InitializeComponent();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void Fnhanvien_FormClosed(object? sender, FormClosedEventArgs e)
        {

        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            fdonhang = new fDonHang();
            openPanel(fdonhang);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {

        }
        private void btn_click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            fquanly = new fQuanLy();
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
    }
}
