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
using wfLeedo.view.dialog;
using wfLeedo.viewModel;

namespace wfLeedo
{
    public partial class fDonHang : Form
    {
        public fDonHang()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            dialogInsertHoaDon inputDialog = new dialogInsertHoaDon();

            // Hiển thị dialog và lấy kết quả trả về khi dialog đóng
            DialogResult result = inputDialog.ShowDialog();
            DonHangViewModel Bill = new DonHangViewModel();
            // Kiểm tra kết quả khi dialog đã đóng
            if (result == DialogResult.OK)
            {
                string enteredText = inputDialog.InputText;
                // Xử lý dữ liệu được nhập bởi người dùng, trong trường hợp này, là biến enteredText.
                // Đây là nơi bạn thực hiện công việc liên quan đến nút "Tạo."
                fDatHang newDH = new fDatHang(enteredText);
                if (Bill.insertDonHang(enteredText))
                {
                    newDH.Dock = DockStyle.Fill;
                    newDH.Show();
                }
                
            }
            else if (result == DialogResult.Cancel)
            {
                // Xử lý khi người dùng nhấn nút "Vãng lai."
                fDatHang newDH = new fDatHang("");
                if (Bill.insertDonHang(""))
                {
                    newDH.Dock = DockStyle.Fill;
                    newDH.Show();
                }
            }

        }

        private void fDonHang_Load(object sender, EventArgs e)
        {
            DonHangViewModel viewModel = new DonHangViewModel();
            dgvDonHang.DataSource = viewModel.dataAllDonHang("");
        }

        private void btnSearchDonHang_Click(object sender, EventArgs e)
        {
            DonHangViewModel viewModel = new DonHangViewModel();
            dgvDonHang.DataSource = viewModel.dataAllDonHang(txtSearchDonHang.Text);
        }

        private void btnResetDonHang_Click(object sender, EventArgs e)
        {
            DonHangViewModel viewModel = new DonHangViewModel();
            dgvDonHang.DataSource = viewModel.dataAllDonHang("");
            txtSearchDonHang.Text = "";
        }

        private void dgvDonHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                employeeViewModel dataCus = new employeeViewModel();
                var mDH = dgvDonHang.Rows[e.RowIndex].Cells["MaDH"].Value.ToString();
                //employee newCustomer = dataCus.dataEmployee(mNV);
                /*fDatHang updateDH = new fDatHang(mDH);
                updateDH.Dock = DockStyle.Fill;
                updateDH.Show();*/
            }
        }
    }
}
