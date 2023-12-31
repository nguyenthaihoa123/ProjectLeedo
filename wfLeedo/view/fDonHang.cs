﻿using BanGiay_N11.viewModel;
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



        private void fDonHang_Load(object sender, EventArgs e)
        {
            DonHangViewModel viewModel = new DonHangViewModel();
            dgvDonHang.DataSource = viewModel.dataAllDonHang("");
            dgvDonHang.AllowUserToAddRows = false;
            dt_Search_Start.Format = DateTimePickerFormat.Custom;
            dt_Search_Start.CustomFormat = "MM-dd-yyyy";
            dt_Search_End.Format = DateTimePickerFormat.Custom;
            dt_Search_End.CustomFormat = "MM-dd-yyyy";


            dgvDonHang.Columns["MaDH"].HeaderText = "Mã đơn hàng";
            dgvDonHang.Columns["HotenKH"].HeaderText = "Họ tên khách hàng";
            dgvDonHang.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvDonHang.Columns["TG_lapBill"].HeaderText = "Thời gian lập hóa đơn";
            dgvDonHang.Columns["TongBill"].HeaderText = "Tổng hóa đơn";
            dgvDonHang.Columns["Status"].HeaderText = "Trạng thái";
        }


        private void btnResetDonHang_Click(object sender, EventArgs e)
        {
            //DonHangViewModel viewModel = new DonHangViewModel();
            //dgvDonHang.DataSource = viewModel.dataAllDonHang("");
            //txtSearchDonHang.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnInsertDH_Click(object sender, EventArgs e)
        {
            dialogInsertHoaDon inputDialog = new dialogInsertHoaDon();

            // Hiển thị dialog và lấy kết quả trả về khi dialog đóng
            DialogResult result = inputDialog.ShowDialog();
            DonHangViewModel Bill = new DonHangViewModel();
            // Kiểm tra kết quả khi dialog đã đóng
            if (result == DialogResult.OK)
            {
                string enteredText = inputDialog.InputText;
                //     Xử lý dữ liệu được nhập bởi người dùng, trong trường hợp này, là biến enteredText.
                //     Đây là nơi bạn thực hiện công việc liên quan đến nút "Tạo."
                fDatHang newDH = new fDatHang(enteredText);
                if (Bill.insertDonHang(enteredText))
                {
                    newDH.Dock = DockStyle.Fill;
                    newDH.Show();
                }

            }
            else if (result == DialogResult.Abort)
            {
                //     Xử lý khi người dùng nhấn nút "Vãng lai."
                fDatHang newDH = new fDatHang("");
                if (Bill.insertDonHang(""))
                {
                    newDH.Dock = DockStyle.Fill;
                    newDH.Show();
                }
            }
        }

        private void dgvDonHang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DonHangViewModel dataBill = new DonHangViewModel();
                var mDH = dgvDonHang.Rows[e.RowIndex].Cells["MaDH"].Value.ToString();
                dataBill.deleteBill(mDH);
                dgvDonHang.DataSource = dataBill.dataAllDonHang("");
            }
        }

        private void dgvDonHang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var mDH = dgvDonHang.Rows[e.RowIndex].Cells["MaDH"].Value.ToString();
                modifyDonHang formModi = new modifyDonHang(mDH);

                formModi.Show();
            }
        }

        private void btnSearchDonHang_Click(object sender, EventArgs e)
        {
            DonHangViewModel viewModel = new DonHangViewModel();
            dgvDonHang.DataSource = viewModel.dataAllDonHang(txtSearchDonHang.Text);
        }

        private void btn_filter_DH_RT_Click(object sender, EventArgs e)
        {
            string start = dt_Search_Start.Text;
            string end = dt_Search_End.Text;
            DonHangViewModel model = new DonHangViewModel();
            dgvDonHang.DataSource = model.dataAllDonHangByRangeTime(start, end);
        }
    }
}
