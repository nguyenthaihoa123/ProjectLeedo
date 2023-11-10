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
using wfLeedo.viewModel;

namespace wfLeedo
{
    public partial class fDatHang : Form
    {
        private string idKH;
        private string idDH;
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
            }
            else
            {
                DonHangViewModel Bill = new DonHangViewModel();
                DonHang InfoBill = Bill.dataDonHangLastest();

                customerViewModel cusData = new customerViewModel();
                customer cus = cusData.dataCustomer(InfoBill.MaKH);
                this.Text = "Thêm mới đơn hàng";
                lbNameCus.Text = cus.Name;
                lbMaDH.Text = InfoBill.ID;
                idDH = InfoBill.ID;
                lbDateBill.Text = InfoBill.TG_create;
                idKH = cus.Id;
                dgvDonHangChiTiet.DataSource = Bill.dataDonHangChiTiet(idDH);
            }
        }
        private void setInfo(string info)
        {
            DonHangViewModel infoData = new DonHangViewModel();
        }

        private void btnCheckInfo_Click(object sender, EventArgs e)
        {
            if (txtIDSp.Text != "")
            {
                DonHangViewModel data = new DonHangViewModel();
                Product productData = data.selectPro(txtIDSp.Text);

                txtNameSp.Text = productData.Name;
                txtPriceSp.Text = productData.Price.ToString();
                txtSizeSp.Text = productData.Size.ToString();
                txtTypeSp.Text = productData.Type.ToString();

            }
        }

        private void btnDeleteInfoSp_Click(object sender, EventArgs e)
        {
            txtIDSp.Text = "";
            txtNameSp.Text = "";
            txtPriceSp.Text = "";
            txtSizeSp.Text = "";
            txtSLSp.Text = "";
            txtTypeSp.Text = "";
        }

        private void btnInsertItemToBill_Click(object sender, EventArgs e)
        {
            string idSp = txtIDSp.Text;
            string SL = txtSLSp.Text;
            DonHangViewModel model = new DonHangViewModel();
            model.InsertItemToBill(idDH, idSp, SL);
            
            dgvDonHangChiTiet.DataSource = model.dataDonHangChiTiet(idDH);
        }
    }
}
