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

namespace wfLeedo
{
    public partial class fMain : Form
    {
        fNhanVien fnhanvien;
        fDonHang fdonhang;
        fKho fkho;
        fKhachHang fkhachhang;
        fDoanhThu fdoanhthu;
        public fMain()
        {
            InitializeComponent();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            fkho = new fKho();
            this.pnMain.Controls.Clear();
            fkho.TopLevel = false;
            fkho.AutoScroll = true;
            fkho.FormBorderStyle = FormBorderStyle.None;
            fkho.Dock = DockStyle.Fill;
            this.Text = fkho.Text;
            this.pnMain.Controls.Add(fkho);
            fkho.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            btnNhanVien.BackColor = Color.Transparent;
            btnNhanVien.IconColor = Color.White;
            btnNhanVien.ForeColor = Color.White;
            /*           if (fnhanvien == null)
                       {
                           fnhanvien = new fNhanVien();
                           fnhanvien.FormClosed += Fnhanvien_FormClosed;
                           fnhanvien.Dock = DockStyle.Fill;
                           fnhanvien.Show();
                       }
                       else
                       {
                           fnhanvien.Activate();
                       }*/

            fnhanvien = new fNhanVien();
            this.pnMain.Controls.Clear();
            fnhanvien.TopLevel = false;
            fnhanvien.AutoScroll = true;
            fnhanvien.FormBorderStyle = FormBorderStyle.None;
            fnhanvien.Dock = DockStyle.Fill;
            this.Text = fnhanvien.Text;
            this.pnMain.Controls.Add(fnhanvien);
            fnhanvien.Show();
        }

        private void Fnhanvien_FormClosed(object? sender, FormClosedEventArgs e)
        {
            fnhanvien = null;
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            fdonhang = new fDonHang();
            this.pnMain.Controls.Clear();
            fdonhang.TopLevel = false;
            fdonhang.AutoScroll = true;
            fdonhang.FormBorderStyle = FormBorderStyle.None;
            fdonhang.Dock = DockStyle.Fill;
            this.Text = fdonhang.Text;
            this.pnMain.Controls.Add(fdonhang);
            fdonhang.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            fkhachhang = new fKhachHang();
            this.pnMain.Controls.Clear();
            fkhachhang.TopLevel = false;
            fkhachhang.AutoScroll = true;
            fkhachhang.FormBorderStyle = FormBorderStyle.None;
            fkhachhang.Dock = DockStyle.Fill;
            this.Text = fkhachhang.Text;
            this.pnMain.Controls.Add(fkhachhang);
            fkhachhang.Show();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            fdoanhthu = new fDoanhThu();
            this.pnMain.Controls.Clear();
            fdoanhthu.TopLevel = false;
            fdoanhthu.AutoScroll = true;
            fdoanhthu.FormBorderStyle = FormBorderStyle.None;
            fdoanhthu.Dock = DockStyle.Fill;
            this.Text = fdoanhthu.Text;
            this.pnMain.Controls.Add(fdoanhthu);
            fdoanhthu.Show();
        }
        private void btn_click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }
    }
}
