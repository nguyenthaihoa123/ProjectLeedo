using BanGiay_N11.model;
using BanGiay_N11.viewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanGiay_N11
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Tạo Pen với màu đỏ và độ rộng 2
            //Pen borderPen = new Pen(Color.White, 5);

            //// Vẽ đường viền bằng Pen đã tạo
            //g.DrawRectangle(borderPen, panel9.Location.X, panel9.Location.Y, panel9.Width - 1, panel9.Height - 1);

            //// Vẽ đường viền bằng Pen đã tạo
            //g.DrawRectangle(borderPen, pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Width -1, pictureBox2.Height -1);
            //// Giải phóng Pen sau khi sử dụng
            //borderPen.Dispose();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            

            employeeViewModel viewAllEmp = new employeeViewModel();
            dgvEmployee.DataSource = viewAllEmp.dataAllEmploy();

            /*dgvEmployee.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dgvEmployee.Columns["HotenNV"].HeaderText = "Họ tên";
            dgvEmployee.Columns["CCCD"].HeaderText = "Căn cước";
            dgvEmployee.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvEmployee.Columns["GT"].HeaderText = "Giới tính";
            dgvEmployee.Columns["NgSinh"].HeaderText = "Ngày sinh";
            dgvEmployee.Columns["PhongBan"].HeaderText = "Phòng ban";
            dgvEmployee.Columns["TKBank"].HeaderText = "Số tài khoản";
            dgvEmployee.Columns["Email"].HeaderText = "Email";
            dgvEmployee.Columns["ChucVu"].HeaderText = "Chức vụ";
            dgvEmployee.Columns["Luong"].HeaderText = "Lương";
            dgvEmployee.Columns["MatKhau"].HeaderText = "Mật khẩu";*/
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                employeeViewModel dataCus = new employeeViewModel();
                var mNV = dgvEmployee.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                employee newCustomer = dataCus.dataEmployee(mNV);
                showData(newCustomer);
            }
        }
        private void showData(employee newEmp)
        {
            txtIDEmp.Text = newEmp.Id;
            txtNameEmp.Text = newEmp.Name;
            txtCCCDEmp.Text = newEmp.CCCD;
            txtSdtEmp.Text = newEmp.Sdt;
            cbbSexEmp.Text = newEmp.Sex;
            dtBirthEmp.Text = newEmp.Birth;
            txtDepartEmp.Text = newEmp.Dept;
            txtBankEmp.Text = newEmp.TKBank;
            txtEmailEmp.Text = newEmp.Email;
            txtLevelEmp.Text = newEmp.ChucVu;
            txtSalaryEmp.Text = newEmp.Salary.ToString();
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (txtIDEmp.Text != "")
            {
                var mKH = txtIDEmp.Text;
                employeeViewModel dataCus = new employeeViewModel();
                employee employ = dataCus.dataEmployee(mKH);

                if (employ != null)
                {
                    employ.Name = txtNameEmp.Text;
                    employ.CCCD = txtCCCDEmp.Text;
                    employ.Sdt = txtSdtEmp.Text;
                    employ.Sex = cbbSexEmp.Text;
                    employ.Birth = dtBirthEmp.Text;
                    employ.Dept = txtDepartEmp.Text;
                    employ.TKBank = txtBankEmp.Text;
                    employ.Email = txtEmailEmp.Text;
                    employ.ChucVu = txtLevelEmp.Text;
                    employ.Salary = double.Parse(txtSalaryEmp.Text) ;
                    dataCus.updateNhanVien(employ);
                    employeeViewModel viewAllEmp = new employeeViewModel();
                    dgvEmployee.DataSource = viewAllEmp.dataAllEmploy();
                }

            }
        }

        private void btnSelectAvt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imageFileName = @"..\asset\choose2.JPG"; // Đường dẫn tương đối đến tệp hình ảnh

                picEmp.Image = Image.FromFile(imageFileName);
                MessageBox.Show(openFileDialog.FileName);
            }

        }
    }
}
