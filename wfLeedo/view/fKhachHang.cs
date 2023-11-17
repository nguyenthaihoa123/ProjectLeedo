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
    public partial class fKhachHang : Form
    {
        private fThemKhachHang form;
        public fKhachHang()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            form = new fThemKhachHang("");
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            customerViewModel viewAllEmp = new customerViewModel();
            dgvCustomer.DataSource = viewAllEmp.dataAllCustomer("");
        }

        private void dgvCustomer_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                customerViewModel dataCus = new customerViewModel();
                var mNV = dgvCustomer.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                form = new fThemKhachHang(mNV);
                form.Dock = DockStyle.Fill;
                form.Show();
            }
        }

        

        private void btnInsertCus_Click(object sender, EventArgs e)
        {
            form = new fThemKhachHang("");
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        

        private void timerCus_Tick(object sender, EventArgs e)
        {

        }

        private void txtSearchInfo_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }
        private void PerformSearch()
        {
            customerViewModel viewAllEmp = new customerViewModel();
            string info = txtSearchInfo.Text;
            dgvCustomer.DataSource = viewAllEmp.dataAllCustomer(info);
        }

        private void btnResetCus_Click(object sender, EventArgs e)
        {
            customerViewModel viewAllEmp = new customerViewModel();
            txtSearchInfo.Text = "";
            dgvCustomer.DataSource = viewAllEmp.dataAllCustomer("");
        }
    }
}
