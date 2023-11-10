using BanGiay_N11;
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
using wfLeedo.model;
using wfLeedo.view;
using wfLeedo.viewModel;

namespace wfLeedo
{
    public partial class fDatHang : Form
    {
        private string idKH;
        private string idDH;
        private string Total;
        private string voucher;
        public fDatHang(string idKH)
        {
            this.idKH = idKH;
            InitializeComponent();
        }

        private void fDatHang_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(idKH))
            {
                this.Text = "Thêm mới đơn hàng với khách vãng lai";
                DonHangViewModel Bill = new DonHangViewModel();
                DonHang InfoBill = Bill.dataDonHangLastest();
                lbNameCus.Text = "Vãng lai";
                lbMaDH.Text = InfoBill.ID;
                idDH = InfoBill.ID;
                lbDateBill.Text = InfoBill.TG_create;
                dgvDonHangChiTiet.DataSource = Bill.dataDonHangChiTiet(idDH);
                lbShowTotal.Text = Bill.getTotalBill(idDH).ToString() + " VND";
            }
            else
            {
                DonHangViewModel Bill = new DonHangViewModel();
                DonHang InfoBill = Bill.dataDonHangLastest();

                customerViewModel cusData = new customerViewModel();
                customer cus = cusData.dataCustomer(InfoBill.MaKH);

                voucher = cus.Voucher;
                this.Text = "Thêm mới đơn hàng";
                lbNameCus.Text = cus.Name;
                lbMaDH.Text = InfoBill.ID;
                idDH = InfoBill.ID;
                lbDateBill.Text = InfoBill.TG_create;
                idKH = cus.Id;
                dgvDonHangChiTiet.DataSource = Bill.dataDonHangChiTiet(idDH);
                lbShowTotal.Text = Bill.getTotalBill(idDH).ToString() + " VND";
            }
        }
        private void setInfo(string info)
        {
            DonHangViewModel infoData = new DonHangViewModel();
        }

        private void btnCheckInfo_Click(object sender, EventArgs e)
        {
            DonHangViewModel data = new DonHangViewModel();
            if (txtIDSp.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id sản phẩm");
            }
            else
            {
                if (txtSLSp.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số lượng");
                }
                else
                {
                    if (double.Parse(txtSLSp.Text) <= double.Parse(data.getSanPhamTonKho(txtIDSp.Text).ToString()))
                    {

                        Product productData = data.selectPro(txtIDSp.Text);

                        txtNameSp.Text = productData.Name;
                        txtPriceSp.Text = productData.Price.ToString();
                        txtSizeSp.Text = productData.Size.ToString();
                        txtTypeSp.Text = productData.Type.ToString();
                        lbShowSLTonKho.Text = data.getSanPhamTonKho(txtIDSp.Text).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Số lượng trong kho không đủ");
                        txtSLSp.Text = "";
                    }
                }
            }
        }

        private void btnDeleteInfoSp_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void btnInsertItemToBill_Click(object sender, EventArgs e)
        {
            if (txtIDSp.Text != "" && txtNameSp.Text != "" && txtSLSp.Text != "")
            {
                string idSp = txtIDSp.Text;
                string SL = txtSLSp.Text;
                DonHangViewModel model = new DonHangViewModel();
                model.InsertItemToBill(idDH, idSp, SL);
                model.insertDataToKhoSP(idSp, SL);

                if (string.IsNullOrEmpty(idKH))
                {
                    lbShowTotal.Text = model.getTotalBill(idDH).ToString() + " VND";
                }
                else
                {
                    /*lbShowTotal.Text = model.getTotalBill(idDH).ToString() + " VND";*/
                    double totalBefore = double.Parse(model.getTotalBill(idDH).ToString());
                    double totalAfter;
                    customerViewModel cusData = new customerViewModel();
                    customer cus = cusData.dataCustomer(idKH);
                    double discount = model.BillApplyVoucher(cus.Voucher, totalBefore);
                    totalAfter = totalBefore - discount;

                    lbShowTotal.Text = totalAfter.ToString() + " VND";
                    lbShowVoucher.Text = discount.ToString() + " VND";
                }



                dgvDonHangChiTiet.DataSource = model.dataDonHangChiTiet(idDH);
                resetData();
            }


        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idKH))
            {
                MessageBox.Show("Thanh toán thành công");
                this.Hide();
            }
            else
            {
                DonHangViewModel model = new DonHangViewModel();
                Total = model.getTotalBill(idDH).ToString();
                if (int.TryParse(Total, out int totalValue))
                {
                    int point = totalValue / 1000; // Tính giá trị point
                    customerViewModel cus = new customerViewModel();
                    cus.updatePoint(idKH, point); // Truyền giá trị point
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lỗi: Không thể chuyển đổi Total thành số nguyên.");
                };
            }
        }

        private void lbShowSLTonKho_Click(object sender, EventArgs e)
        {

        }

        private void dgvDonHangChiTiet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    var mSP = dgvDonHangChiTiet.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
                    DonHangViewModel donHangViewModel = new DonHangViewModel();
                    donHangViewModel.deleteItemBill(idDH, mSP);
                    dgvDonHangChiTiet.DataSource = donHangViewModel.dataDonHangChiTiet(idDH);
                    /*lbShowTotal.Text = donHangViewModel.getTotalBill(idDH).ToString() + " VND";*/
                    // Đã xóa xong, có thể thực hiện các xử lý khác nếu cần
                    if (string.IsNullOrEmpty(idKH))
                    {
                        lbShowTotal.Text = donHangViewModel.getTotalBill(idDH).ToString() + " VND";
                    }
                    else
                    {
                        /*lbShowTotal.Text = model.getTotalBill(idDH).ToString() + " VND";*/
                        double totalBefore = double.Parse(donHangViewModel.getTotalBill(idDH).ToString());
                        double totalAfter;
                        customerViewModel cusData = new customerViewModel();
                        customer cus = cusData.dataCustomer(idKH);
                        double discount = donHangViewModel.BillApplyVoucher(cus.Voucher, totalBefore);
                        totalAfter = totalBefore - discount;

                        lbShowTotal.Text = totalAfter.ToString() + " VND";
                        lbShowVoucher.Text = discount.ToString() + " VND";
                    }
                }
            }
        }
        private void resetData()
        {
            txtIDSp.Text = "";
            txtNameSp.Text = "";
            txtPriceSp.Text = "";
            txtSizeSp.Text = "";
            txtSLSp.Text = "";
            txtTypeSp.Text = "";
        }
    }
}
