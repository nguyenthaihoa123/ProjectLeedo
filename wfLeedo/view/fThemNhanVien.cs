using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanGiay_N11;
using BanGiay_N11.viewModel;
using Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace wfLeedo
{
    public partial class fThemNhanVien : Krypton.Toolkit.KryptonForm
    {
        private string maNV;
        public fThemNhanVien(string maNV)
        {
            this.maNV = maNV;
            InitializeComponent();
        }

        private void btnInsertEmp_Click(object sender, EventArgs e)
        {
            string userInput = txtPwdEmp.Text;

            if (IsInputValid(userInput))
            {
                // Chuỗi hợp lệ (có ít nhất 6 ký tự)
                // Thực hiện các xử lý khác ở đây
                try
                {
                    string name = txtNameEmp.Text;
                    string cccd = txtCCCDEmp.Text;
                    string sdt = txtSDTEmp.Text;
                    string sex = cbbSexEmp.Text;
                    string birth = dtBirthEmp.Text;
                    string depart = cbbDepartEmp.Text;
                    string email = txtEmailEmp.Text;
                    string level = cbbLevelEmp.Text;
                    double salary = double.Parse(txtSalary.Text);
                    string tkBank = txtNumberBank.Text;
                    string password = txtPwdEmp.Text;
                    employee empObject = new employee("", name, birth, sex, sdt, email, password, cccd, depart, tkBank, level, salary, "");
                    employeeViewModel insertNewEmp = new employeeViewModel();
                    //insertNewEmp.insertEmployee(empObject);
                    if (insertNewEmp.insertEmployee(empObject))
                    {
                        this.Close();
                    }
                    // Thực hiện các thao tác khác với dữ liệu đã nhập
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
            else
            {
                // Chuỗi không hợp lệ
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwdEmp.Focus();
            }


        }

        private void fThemNhanVien_Load(object sender, EventArgs e)
        {
            dtBirthEmp.Format = DateTimePickerFormat.Custom;
            dtBirthEmp.CustomFormat = "MM-dd-yyyy";

            if (string.IsNullOrEmpty(maNV))
            {
                this.Text = "Thêm mới nhân viên";
                btnSuaEmp.Enabled = false;
            }
            else
            {
                this.Text = "Sửa thông tin nhân viên";
                btnInsertEmp.Enabled = false;
                employeeViewModel dataCus = new employeeViewModel();
                employee newCustomer = dataCus.dataEmployee(maNV);
                ShowData(newCustomer);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowData(employee emp)
        {
            txtNameEmp.Text = emp.Name;
            txtCCCDEmp.Text = emp.CCCD;
            txtSDTEmp.Text = emp.Sdt;
            cbbSexEmp.Text = emp.Sex;
            dtBirthEmp.Text = emp.Birth;
            cbbDepartEmp.Text = emp.Dept;
            txtEmailEmp.Text = emp.Email;
            cbbLevelEmp.Text = emp.ChucVu;
            txtSalary.Text = emp.Salary.ToString();
            txtNumberBank.Text = emp.TKBank.ToString();
            txtPwdEmp.Text = emp.Pwd;
        }

        private void btnSuaEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNameEmp.Text;
                string cccd = txtCCCDEmp.Text;
                string sdt = txtSDTEmp.Text;
                string sex = cbbSexEmp.Text;
                string birth = dtBirthEmp.Text;
                string depart = cbbDepartEmp.Text;
                string email = txtEmailEmp.Text;
                string level = cbbLevelEmp.Text;
                double salary = double.Parse(txtSalary.Text);
                string tkBank = txtNumberBank.Text;
                string password = txtPwdEmp.Text;
                employee empObject = new employee(maNV, name, birth, sex, sdt, email, password, cccd, depart, tkBank, level, salary, "");
                employeeViewModel updateEmp = new employeeViewModel();
                //insertNewEmp.insertEmployee(empObject);
                if (updateEmp.updateNhanVien(empObject))
                {
                    this.Close();
                }
                // Thực hiện các thao tác khác với dữ liệu đã nhập
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

        private void txtCCCDEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCCCDEmp_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCCCDEmp.Text))
                return;

            // Kiểm tra xem nếu chuỗi có chứa kí tự chữ cái
            if (ContainsLetter(txtCCCDEmp.Text))
            {
                MessageBox.Show("Vui lòng chỉ nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCCCDEmp.Focus();
            }
        }

        private void txtSDTEmp_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSDTEmp.Text))
                return;

            // Kiểm tra xem nếu giá trị không phải là số
            if (!int.TryParse(txtSDTEmp.Text, out _))
            {
                MessageBox.Show("Vui lòng chỉ nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDTEmp.Focus();
            }
        }

        private void txtEmailEmp_Leave(object sender, EventArgs e)
        {
            string emailAddress = txtEmailEmp.Text.Trim();

            if (IsValidEmail(emailAddress))
            {
                // Email hợp lệ
            }
            else
            {
                // Email không hợp lệ
                MessageBox.Show("Email không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailEmp.Focus();
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

        private void txtNumberBank_Leave(object sender, EventArgs e)
        {

        }

        private void txtPwdEmp_Leave(object sender, EventArgs e)
        {
            string number = txtPwdEmp.Text.Trim();

            if (IsInputValid(number))
            {
                // Email hợp lệ
            }
            else
            {
                // Email không hợp lệ
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự..", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwdEmp.Focus();
            }
        }
        private bool IsInputValid(string input)
        {
            return input.Length >= 6;
        }
        private bool ContainsLetter(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
