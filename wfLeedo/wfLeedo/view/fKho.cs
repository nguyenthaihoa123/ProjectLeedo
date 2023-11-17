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
using wfLeedo.view;

namespace wfLeedo
{
    public partial class fKho : Form
    {
        private fThemSP formSP;
        private fThemNVL formNVL;
        private fThemNXKhoNVL formNXKhoNVL;
        private static string mode;
        private static string modeNX;
        public fKho()
        {
            InitializeComponent();
            mode = cbModel.SelectedItem.ToString();
            modeNX = cbNXMode.SelectedItem.ToString();
        }
        private void fKho_Load_1(object sender, EventArgs e)
        {
            nvlViewModel dataAllNVL = new nvlViewModel();
            dgvKho.DataSource = dataAllNVL.dataAllNVL();
            dgvNXMode.DataSource = dataAllNVL.dataAllKhoNVL();

            dgvKho.ReadOnly = true;
            dgvNXMode.ReadOnly = true;
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            //mode = cbModel.SelectedItem.ToString();
            if (mode == "Sản phẩm")
            {
                formSP = new fThemSP("");
                formSP.Dock = DockStyle.Fill;
                formSP.Show();
            }
            else if (mode == "Nguyên vật liệu")
            {
                formNVL = new fThemNVL("");
                formNVL.Dock = DockStyle.Fill;
                formNVL.Show();
            }
        }

        private void dgvKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //mode = cbModel.SelectedItem.ToString();
            if (e.RowIndex >= 0)
            {
                if (mode == "Sản phẩm")
                {
                    productViewModel dataPro = new productViewModel();
                    var maSP = dgvKho.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
                    formSP = new fThemSP(maSP);
                    formSP.Dock = DockStyle.Fill;
                    formSP.Show();
                }
                else if (mode == "Nguyên vật liệu")
                {
                    nvlViewModel dataNVL = new nvlViewModel();
                    var maNVL = dgvKho.Rows[e.RowIndex].Cells["MaNVL"].Value.ToString();
                    formNVL = new fThemNVL(maNVL);
                    formNVL.Dock = DockStyle.Fill;
                    formNVL.Show();
                }
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            //mode = cbModel.SelectedItem.ToString();

            txtSearch.Text = "";

            if (mode == "Sản phẩm")
            {
                productViewModel dataAllPro = new productViewModel();
                dgvKho.DataSource = dataAllPro.dataAllProduct();
            }
            else if (mode == "Nguyên vật liệu")
            {
                nvlViewModel dataAllNVL = new nvlViewModel();
                dgvKho.DataSource = dataAllNVL.dataAllNVL();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //mode = cbModel.SelectedItem.ToString();
            if (txtSearch.Text != "")
            {
                if (mode == "Sản phẩm")
                {
                    var maSP = txtSearch.Text;
                    productViewModel dataPro = new productViewModel();
                    Product newPro = dataPro.dataProduct(maSP);
                    if (newPro != null)
                    {
                        formSP = new fThemSP(maSP);
                        formSP.Dock = DockStyle.Fill;
                        formSP.Show();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin sản phẩm.");
                    }
                }
                else if (mode == "Nguyên vật liệu")
                {
                    var maNVL = txtSearch.Text;
                    nvlViewModel dataNVL = new nvlViewModel();
                    NguyenVatLieu newNVL = dataNVL.dataNVL(maNVL);
                    if (newNVL != null)
                    {
                        formNVL = new fThemNVL(maNVL);
                        formNVL.Dock = DockStyle.Fill;
                        formNVL.Show();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin nguyên vật liệu.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập thông tin để thực hiện quá trình tìm kiếm!");

            }
        }

        private void reloadNXBtn_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";

            if (mode == "Sản phẩm")
            {
                productViewModel dataAllPro = new productViewModel();
            }
            else if (mode == "Nguyên vật liệu")
            {
                nvlViewModel dataAllNVL = new nvlViewModel();
                if (modeNX == "Tất cả")
                {
                    dgvNXMode.DataSource = dataAllNVL.dataAllKhoNVL();
                }
                else if (modeNX == "Nhập")
                {
                    dgvNXMode.DataSource = dataAllNVL.dataNhapKhoNVL();
                }
                else if (modeNX == "Xuất")
                {
                    dgvNXMode.DataSource = dataAllNVL.dataXuatKhoNVL();
                }
            }
        }

        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = cbModel.SelectedItem.ToString();

            if (mode == "Sản phẩm")
            {
                productViewModel dataAllPro = new productViewModel();
                dgvKho.DataSource = dataAllPro.dataAllProduct();
            }
            else if (mode == "Nguyên vật liệu")
            {
                nvlViewModel dataAllNVL = new nvlViewModel();
                dgvKho.DataSource = dataAllNVL.dataAllNVL();
                dgvNXMode.DataSource = dataAllNVL.dataAllKhoNVL();
            }

            dgvKho.ReadOnly = true;
            dgvNXMode.ReadOnly = true;
        }

        private void cbNXMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            modeNX = cbNXMode.SelectedItem.ToString();
            if (mode == "Sản phẩm")
            {
                productViewModel dataAllPro = new productViewModel();
            }
            else if (mode == "Nguyên vật liệu")
            {
                nvlViewModel dataAllNVL = new nvlViewModel();
                if (modeNX == "Tất cả")
                {
                    dgvNXMode.DataSource = dataAllNVL.dataAllKhoNVL();
                }
                else if (modeNX == "Nhập")
                {
                    dgvNXMode.DataSource = dataAllNVL.dataNhapKhoNVL();
                }
                else if (modeNX == "Xuất")
                {
                    dgvNXMode.DataSource = dataAllNVL.dataXuatKhoNVL();
                }
            }
        }

        private void insertNXBtn_Click(object sender, EventArgs e)
        {
            if (mode == "Sản phẩm")
            {
                /*formSP = new fThemSP("");
                formSP.Dock = DockStyle.Fill;
                formSP.Show();*/
            }
            else if (mode == "Nguyên vật liệu")
            {
                if(modeNX == "Nhập" || modeNX == "Xuất")
                {
                    formNXKhoNVL = new fThemNXKhoNVL("", modeNX);
                    formNXKhoNVL.Dock = DockStyle.Fill;
                    formNXKhoNVL.Show();
                }
                else if (modeNX == "Tất cả")
                {
                    MessageBox.Show("Vui lòng chọn 1 trong 2 chức năng nhập/xuất!");
                }
            }
        }
    }
}
