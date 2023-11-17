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
using wfLeedo.view;

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


       

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var mNV = dgvEmployee.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                employeeViewModel dataCus = new employeeViewModel();
                dataCus.deleteEmployee(mNV);
                dgvEmployee.DataSource = dataCus.dataAllEmploy("");
            }
        }

        private void btnInsertEmp_Click(object sender, EventArgs e)
        {
            fthemnhanvien = new fThemNhanVien("");
            fthemnhanvien.FormClosed += Fthemnhanvien_FormClosed;
            fthemnhanvien.Dock = DockStyle.Fill;
            fthemnhanvien.Show();
        }

        private void dgvEmployee_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                employeeViewModel dataCus = new employeeViewModel();
                var mNV = dgvEmployee.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                fthemnhanvien = new fThemNhanVien(mNV);
                fthemnhanvien.FormClosed += Fthemnhanvien_FormClosed;
                fthemnhanvien.Dock = DockStyle.Fill;
                fthemnhanvien.Show();
            }
        }
        private void PerformSearch()
        {
            customerViewModel viewAllEmp = new customerViewModel();
            string info = txtInputInfoEmp.Text;
            dgvEmployee.DataSource = viewAllEmp.dataAllCustomer(info);
        }

        private void txtInputInfoEmp_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void btnResetEmp_Click(object sender, EventArgs e)
        {
            employeeViewModel viewAllEmp = new employeeViewModel();
            dgvEmployee.DataSource = viewAllEmp.dataAllEmploy("");
            txtInputInfoEmp.Text = "";
        }
    }
}
