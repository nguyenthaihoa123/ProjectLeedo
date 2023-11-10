using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
