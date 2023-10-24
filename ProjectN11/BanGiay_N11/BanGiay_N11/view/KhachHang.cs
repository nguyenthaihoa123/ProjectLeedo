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

namespace BanGiay_N11
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            customerViewModel viewAllCus = new customerViewModel();
            dgvKhachHang.DataSource = viewAllCus.dataAllCustomer();

            dgvKhachHang.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            dgvKhachHang.Columns["HotenKH"].HeaderText = "Họ tên";
            dgvKhachHang.Columns["GT"].HeaderText = "Giới tính";
            dgvKhachHang.Columns["NgSinh"].HeaderText = "Ngày sinh";
            dgvKhachHang.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvKhachHang.Columns["Email"].HeaderText = "Email";
            dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dgvKhachHang.Columns["TichDiem"].HeaderText = "Tích điểm";
            dgvKhachHang.Columns["Voucher"].HeaderText = "Voucher";

        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                customerViewModel dataCus = new customerViewModel();
                var mKH = dgvKhachHang.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                customer newCustomer = dataCus.dataCustomer(mKH);
                showData(newCustomer);          
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdCustomer.Text != "")
            {
                var mKH = txtIdCustomer.Text;
                customerViewModel dataCus = new customerViewModel();
                customer newCustomer = dataCus.dataCustomer(mKH);

                if (newCustomer != null)
                {
                    showData(newCustomer);
                }
                else
                {
                    // Xử lý trường hợp `newCustomer` không hợp lệ, ví dụ: hiển thị thông báo lỗi.
                    MessageBox.Show("Không tìm thấy thông tin khách hàng.");
                }
            }
        }

        private void showData(customer newCus)
        {
            txtIdCustomer.Text = newCus.Id;
            txtNameCustomer.Text = newCus.Name;
            txtSexCustomer.Text = newCus.Sex;
            txtNumberCustomer.Text = newCus.Sdt;
            txtAddCustomer.Text = newCus.DiaChi;
            dtBirthCustomer.Text = newCus.Birth;
            txtEmailCus.Text = newCus.Email;
            txtPwdCus.Text = newCus.Pwd;
            txtVoucher.Text = newCus.Voucher;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateCus_Click(object sender, EventArgs e)
        {
            if (txtIdCustomer.Text != "")
            {
                var mKH = txtIdCustomer.Text;
                customerViewModel dataCus = new customerViewModel();
                customer Customer = dataCus.dataCustomer(mKH);
            
                if (Customer != null)
                {
                    Customer.Name = txtNameCustomer.Text;
                    Customer.Sex = txtSexCustomer.Text;
                    Customer.Sdt = txtNumberCustomer.Text;
                    Customer.DiaChi = txtAddCustomer.Text;
                    Customer.Birth = dtBirthCustomer.Text;
                    Customer.Email = txtEmailCus.Text;
                    Customer.Pwd = txtPwdCus.Text;
                    Customer.Voucher = txtVoucher.Text;
                    dataCus.updateKhachHang(Customer);
                    customerViewModel viewAllCus = new customerViewModel();
                    dgvKhachHang.DataSource = viewAllCus.dataAllCustomer();
                }
                
            }
        }

        private void btnDeleteCus_Click(object sender, EventArgs e)
        {
            if (txtIdCustomer.Text != "")
            {
                var mKH = txtIdCustomer.Text;
                customerViewModel dataCus = new customerViewModel();
                customer Customer = dataCus.dataCustomer(mKH);

                if (Customer != null)
                {
                    Customer.Name = txtNameCustomer.Text;
                    Customer.Sex = txtSexCustomer.Text;
                    Customer.Sdt = txtNumberCustomer.Text;
                    Customer.DiaChi = txtAddCustomer.Text;
                    Customer.Birth = dtBirthCustomer.Text;
                    Customer.Email = txtEmailCus.Text;
                    Customer.Pwd = txtPwdCus.Text;
                    Customer.Voucher = txtVoucher.Text;
                    dataCus.deleteCustomer(Customer);
                    customerViewModel viewAllCus = new customerViewModel();
                    dgvKhachHang.DataSource = viewAllCus.dataAllCustomer();
                }

            }
        }
    }
}
