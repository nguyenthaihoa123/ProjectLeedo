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
    public partial class fThemNVL : Form
    {
        string maNVL;
        public fThemNVL(string maNVL)
        {
            InitializeComponent();
            this.maNVL = maNVL;
        }

        private void fThemNVL_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maNVL))
            {
                this.Text = "Thêm nguyên vật liệu mới";
                saveBtn.Enabled = false;
            }
            else
            {
                this.Text = "Sửa thông tin nguyên vật liệu";
                insertBtn.Enabled = false;
                nvlViewModel dataNVL = new nvlViewModel();
                NguyenVatLieu newNVL = dataNVL.dataNVL(maNVL);
                showData(newNVL);
            }
        }
        private void showData(NguyenVatLieu newNVL)
        {
            txtMaNVL.Text = newNVL.Id;
            txtLoaiNVL.Text = newNVL.Type;
            txtTenNVL.Text = newNVL.Name;
            txtGiaNVL.Text = newNVL.Price.ToString();
            txtDvtNVL.Text = newNVL.DonVi;
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNVL.Text != "")
                {
                    nvlViewModel dataNVL = new nvlViewModel();
                    NguyenVatLieu newNVL = new NguyenVatLieu(txtMaNVL.Text, txtLoaiNVL.Text, txtTenNVL.Text, double.Parse(txtGiaNVL.Text), txtDvtNVL.Text);

                    if (dataNVL.insertNVL(newNVL))
                    {
                        this.Close();
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (txtMaNVL.Text != "")
            {
                var maNVL = txtMaNVL.Text;
                nvlViewModel dataNVL = new nvlViewModel();
                NguyenVatLieu newNVL = dataNVL.dataNVL(maNVL);

                if (newNVL != null)
                {
                    newNVL.Id = txtMaNVL.Text;
                    newNVL.Type = txtLoaiNVL.Text;
                    newNVL.Name = txtTenNVL.Text;
                    newNVL.Price = double.Parse(txtGiaNVL.Text);
                    newNVL.DonVi = txtDvtNVL.Text;
                    dataNVL.updateNVL(newNVL);
                }
            }
        }
    }
}
