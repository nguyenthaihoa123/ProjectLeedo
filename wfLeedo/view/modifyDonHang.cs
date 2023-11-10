using BanGiay_N11.model;
using BanGiay_N11.viewModel;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfLeedo.model;
using wfLeedo.viewModel;

namespace wfLeedo.view
{
    public partial class modifyDonHang : Form
    {
        private string mDH;
        public modifyDonHang(string mDH)
        {
            this.mDH = mDH;
            InitializeComponent();
        }

        private void modifyDonHang_Load(object sender, EventArgs e)
        {
            this.Text = "Chỉnh sửa đơn hàng";
            DonHangViewModel model = new DonHangViewModel();
            dgvModiBill.DataSource = model.dataDonHangChiTiet(mDH);



            DonHang donhang = model.dataDonHang(mDH);
            string tongBill = model.getTotalBill(mDH).ToString() + " VND";
            string idKH = donhang.MaKH;
            if (idKH == "")
            {
                lbIDDH.Text = mDH;
                lbNameKH.Text = "Vãng lai";
                lbTongBill.Text = tongBill;
            }
            else
            {
                customerViewModel cusData = new customerViewModel();
                customer cus = cusData.dataCustomer(donhang.MaKH);
                lbIDDH.Text = mDH;
                lbNameKH.Text = cus.Name;
                lbTongBill.Text = tongBill;

            }
        }

        private void dgvModiBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    var mSP = dgvModiBill.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
                    DonHangViewModel donHangViewModel = new DonHangViewModel();
                    donHangViewModel.deleteItemBill(mDH, mSP);
                    dgvModiBill.DataSource = donHangViewModel.dataDonHangChiTiet(mDH);
                    lbTongBill.Text = donHangViewModel.getTotalBill(mDH).ToString() + " VND";
                    // Đã xóa xong, có thể thực hiện các xử lý khác nếu cần
                }
            }
        }

        private void btnSaveModiBill_Click(object sender, EventArgs e)
        {
            String status = cbbStatus.Text;
            DonHangViewModel donhang = new DonHangViewModel();
            donhang.updateDonHang(mDH, status);

            this.Hide();
        }
    }
}
