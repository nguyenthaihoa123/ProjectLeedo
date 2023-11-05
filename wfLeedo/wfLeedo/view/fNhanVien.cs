using BanGiay_N11;
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

namespace wfLeedo
{
    public partial class fNhanVien : Form
    {
        fThemNhanVien fthemnhanvien;
        public fNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (fthemnhanvien == null)
            {
                fthemnhanvien = new fThemNhanVien("");
                fthemnhanvien.FormClosed += Fthemnhanvien_FormClosed;
                fthemnhanvien.Dock = DockStyle.Fill;
                fthemnhanvien.Show();
            }
            else
            {
                fthemnhanvien.Activate();
            }
        }

        private void Fthemnhanvien_FormClosed(object? sender, FormClosedEventArgs e)
        {
            fthemnhanvien = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            employeeViewModel viewAllEmp = new employeeViewModel();
            dgvEmployee.DataSource = viewAllEmp.dataAllEmploy("");
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            employeeViewModel viewAllEmp = new employeeViewModel();

            string info = txtInputInfoEmp.Text;
            dgvEmployee.DataSource = viewAllEmp.dataAllEmploy(info);

        }

        private void btnResetDataEmp_Click(object sender, EventArgs e)
        {
            employeeViewModel viewAllEmp = new employeeViewModel();
            dgvEmployee.DataSource = viewAllEmp.dataAllEmploy("");
            txtInputInfoEmp.Text = "";
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                employeeViewModel dataCus = new employeeViewModel();
                var mNV = dgvEmployee.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                //employee newCustomer = dataCus.dataEmployee(mNV);
                fthemnhanvien = new fThemNhanVien(mNV);
                fthemnhanvien.FormClosed += Fthemnhanvien_FormClosed;
                fthemnhanvien.Dock = DockStyle.Fill;
                fthemnhanvien.Show();
            }
        }
    }
}
