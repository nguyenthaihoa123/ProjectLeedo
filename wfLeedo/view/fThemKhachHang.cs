﻿using BanGiay_N11.viewModel;
using BanGiay_N11;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanGiay_N11.model;
using System.Text.RegularExpressions;

namespace wfLeedo.view
{
    public partial class fThemKhachHang : Form
    {
        string mKH;
        public fThemKhachHang(string mKH)
        {
            this.mKH = mKH;
            InitializeComponent();
        }

        private void fThemKhachHang_Load(object sender, EventArgs e)
        {
            dtBirth.Format = DateTimePickerFormat.Custom;
            dtBirth.CustomFormat = "MM-dd-yyyy";
            if (string.IsNullOrEmpty(mKH))
            {
                this.Text = "Thêm mới khách hàng";
                btnSaveCus.Enabled = false;
                txtPoint.Enabled = false;
                txtPoint.Text = "0";
            }
            else
            {
                this.Text = "Sửa thông tin khách hàng";
                btnInsertCus.Enabled = false;
                customerViewModel dataCus = new customerViewModel();
                customer newCustomer = dataCus.dataCustomer(mKH);
                ShowData(newCustomer);
            }
        }
        private void ShowData(customer cus)
        {
            txtName.Text = cus.Name;
            txtNumber.Text = cus.Sdt;
            cbbSex.Text = cus.Sex;
            dtBirth.Text = cus.Birth;
            txtEmail.Text = cus.Email;
            txtPass.Text = cus.Pwd;
            txtAddress.Text = cus.DiaChi;
            txtPoint.Text = cus.TichDiem.ToString();
            txtVoucher.Text = cus.Voucher;
            txtPass.Text = cus.Pwd;

        }

        private void btnSaveCus_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string number = txtNumber.Text;
                string sex = cbbSex.Text;
                string birth = dtBirth.Text;
                string email = txtEmail.Text;
                string pass = txtPass.Text;
                string address = txtAddress.Text;
                string point = txtPoint.Text;
                string voucher = txtVoucher.Text;
                string pass2 = txtPass.Text;

                customer customerObject = new customer(mKH, name, birth, sex, number, email, address, pass, int.Parse(point), voucher);
                customerViewModel cusModel = new customerViewModel();
                if (cusModel.updateKhachHang(customerObject))
                {
                    this.Close();
                }
            }
            catch (FormatException ex)
            {
                // Xử lý lỗi kiểu dữ liệu sai (ví dụ: nhập chuỗi không phải số vào salary)
                MessageBox.Show("Lỗi: Nhập liệu không hợp lệ. Vui lòng kiểm tra lại các trường số.");
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác có thể xảy ra
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btncc_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnInsertCus_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string number = txtNumber.Text;
                string sex = cbbSex.Text;
                string birth = dtBirth.Text;
                string email = txtEmail.Text;
                string pass = txtPass.Text;
                string address = txtAddress.Text;
                string point = txtPoint.Text;
                string voucher = txtVoucher.Text;
                string pass2 = txtPass.Text;

                customer customerObject = new customer(mKH, name, birth, sex, number, email, address, pass, int.Parse(point), voucher);
                customerViewModel cusModel = new customerViewModel();
                if (cusModel.insertCustomer(customerObject))
                {
                    this.Close();
                }
            }
            catch (FormatException ex)
            {
                // Xử lý lỗi kiểu dữ liệu sai (ví dụ: nhập chuỗi không phải số vào salary)
                MessageBox.Show("Lỗi: Nhập liệu không hợp lệ. Vui lòng kiểm tra lại các trường số.");
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác có thể xảy ra
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumber.Text))
                return;

            // Kiểm tra xem nếu giá trị không phải là số
            if (!int.TryParse(txtNumber.Text, out _))
            {
                MessageBox.Show("Vui lòng chỉ nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.Focus();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string emailAddress = txtEmail.Text.Trim();

            if (IsValidEmail(emailAddress))
            {
                // Email hợp lệ
            }
            else
            {
                // Email không hợp lệ
                MessageBox.Show("Email không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                // Sử dụng biểu thức chính quy để kiểm tra định dạng email
                var regex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
                return regex.IsMatch(email);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            string number = txtPass.Text.Trim();

            if (IsInputValid(number))
            {
                // Email hợp lệ
            }
            else
            {
                // Email không hợp lệ
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự..", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
            }
        }
        private bool IsInputValid(string input)
        {
            return input.Length >= 6;
        }
    }
}
