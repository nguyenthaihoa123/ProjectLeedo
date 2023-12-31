﻿using BanGiay_N11;
using BanGiay_N11.viewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfLeedo.view
{
    public partial class fQuanLy : Form
    {
        fNhanVien fnhanvien;
        fDoanhThu fdoanhthu;
        fThongKe fthongke;
        fKhachHang fkhachhang;
        fKho fKhohang;
        string idNV;
        public fQuanLy(string idNV)
        {
            this.idNV = idNV;
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            fnhanvien = new fNhanVien();
            openPanel(fnhanvien);
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            fthongke = new fThongKe();
            openPanel(fthongke);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            fthongke = new fThongKe();
            openPanel(fthongke);
        }
        private void openPanel(Form form)
        {
            this.pnQuanLy.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.Text = form.Text;
            this.pnQuanLy.Controls.Add(form);
            form.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            fkhachhang = new fKhachHang();
            openPanel(fkhachhang);
        }

        private void btnDoanhThu_Click_1(object sender, EventArgs e)
        {
            fdoanhthu = new fDoanhThu();
            openPanel(fdoanhthu);
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            fthongke = new fThongKe();
            openPanel(fthongke);
        }

        private void btnKhohang_Click(object sender, EventArgs e)
        {
            fKhohang = new fKho();
            openPanel(fKhohang);
        }

        private void guna2GradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fQuanLy_Load(object sender, EventArgs e)
        {
            employeeViewModel model = new employeeViewModel();
            employee emp = model.dataEmployee(idNV);

            // Tạo một Font mới với thuộc tính bold và size lớn hơn
            Font boldFont = new Font(lbNameConer.Font, FontStyle.Bold);

            // Gán Font mới cho lbNameConer
            lbNameConer.Font = boldFont;

            // Gán nội dung cho Label
            lbNameConer.Text = "Xin chào, " + emp.Name;
        }
    }
}
