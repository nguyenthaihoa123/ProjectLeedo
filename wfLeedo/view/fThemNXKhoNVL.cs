﻿using BanGiay_N11;
using BanGiay_N11.model;
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
    public partial class fThemNXKhoNVL : Form
    {
        string mode, modeNX;
        public fThemNXKhoNVL(string mode, string modeNX)
        {
            InitializeComponent();
            this.mode = mode;
            this.modeNX = modeNX;
        }

        private void fThemNXKhoNVL_Load(object sender, EventArgs e)
        {

            List<CustomParameter> list = new List<CustomParameter>();
            var dt = new Database().SelectData("selectMaKho", list);
            DateTime time = DateTime.Now;
            dtTGNhap.Value = time;
            dtTGXuat.Value = time;
            cbMaKho.Items.Clear();
            foreach (DataRow r in dt.Rows)
            {
                string idKho = r["MaKho"].ToString();
                cbMaKho.Items.Add(idKho);
            }

            if (mode == "Nguyên vật liệu")
            {
                dt = new Database().SelectData("selectMaNVL", list);
                cbMaNVL.Items.Clear();
                foreach (DataRow r in dt.Rows)
                {
                    string idNVL = r["MaNVL"].ToString();
                    cbMaNVL.Items.Add(idNVL);
                }
            }
            else if (mode == "Sản phẩm")
            {
                dt = new Database().SelectData("selectMaSP", list);
                cbMaNVL.Items.Clear();
                foreach (DataRow r in dt.Rows)
                {
                    string idSP = r["MaSP"].ToString();
                    cbMaNVL.Items.Add(idSP);
                }
            }

            if (modeNX == "Nhập")
            {
                this.Text = "Tạo phiếu nhập hàng";
                txtSLXuat.Enabled = false;
                dtTGXuat.Enabled = false;
            }
            else if (modeNX == "Xuất")
            {
                this.Text = "Tạo phiếu xuất hàng";
                txtSLNhap.Enabled = false;
                dtTGNhap.Enabled = false;
            }

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Now;
                dtTGNhap.Value = dt;
                dtTGXuat.Value = dt;
                if (cbMaKho.Text != "" && cbMaNVL.Text != "")
                {
                    if (mode == "Nguyên vật liệu")
                    {
                        nvlViewModel newNVL = new nvlViewModel();
                        if (modeNX == "Nhập")
                        {
                            if (newNVL.insertNhapKhoNVL(cbMaKho.Text, cbMaNVL.Text, int.Parse(txtSLNhap.Text), 0, dtTGNhap.Value, null))
                            {
                                this.Close();
                            }
                        }
                        else if (modeNX == "Xuất")
                        {

                            int slTon = newNVL.getSLTonNVL(cbMaNVL.Text);
                            if (slTon - int.Parse(txtSLXuat.Text) < 0)
                            {
                                MessageBox.Show("Vui lòng nhập lại số lượng xuất! Số lượng xuất không được lớn hơn số lượng tồn kho!");
                            }
                            else if (newNVL.insertXuatKhoNVL(cbMaKho.Text, cbMaNVL.Text, 0, int.Parse(txtSLXuat.Text), null, dtTGXuat.Value))
                            {
                                this.Close();
                            }
                        }
                    }
                    else if (mode == "Sản phẩm")
                    {
                        productViewModel newPro = new productViewModel();
                        if (modeNX == "Nhập")
                        {
                            if (newPro.insertNhapKhoSP(cbMaKho.Text, cbMaNVL.Text, int.Parse(txtSLNhap.Text), 0, dtTGNhap.Value, null))
                            {
                                this.Close();
                            }
                        }
                        else if (modeNX == "Xuất")
                        {

                            int slTon = newPro.getSLTonSP(cbMaNVL.Text);
                            if (slTon - int.Parse(txtSLXuat.Text) < 0)
                            {
                                MessageBox.Show("Vui lòng nhập lại số lượng xuất! Số lượng xuất không được lớn hơn số lượng tồn kho!");
                            }
                            else if (newPro.insertXuatKhoSP(cbMaKho.Text, cbMaNVL.Text, 0, int.Parse(txtSLXuat.Text), null, dtTGXuat.Value))
                            {
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (FormatException ex)
            {
                // Xử lý lỗi kiểu dữ liệu sai (ví dụ: nhập chuỗi không phải số vào salary)
                MessageBox.Show("Lỗi: Nhập liệu không hợp lệ. Vui lòng kiểm tra lại các thông tin nhập vào.");
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác có thể xảy ra
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
        }
    }
}
