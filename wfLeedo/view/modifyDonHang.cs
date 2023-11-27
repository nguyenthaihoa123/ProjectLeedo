using BanGiay_N11.model;
using BanGiay_N11.viewModel;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfLeedo.model;
using wfLeedo.viewModel;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;

namespace wfLeedo.view
{
    public partial class modifyDonHang : Form
    {
        private string mDH;
        private PrintDocument printDocument;
        private DataTable dataSource;
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

        private void printBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Thực hiện vẽ nội dung hóa đơn trên trang in
            Graphics g = e.Graphics;

            // Vẽ thông tin hóa đơn
            string idDH = lbIDDH.Text;
            string tenKH = lbNameKH.Text;
            string tongBill = lbTongBill.Text;

            // Vẽ danh sách món hàng từ dgvModiBill.DataSource
            DataTable dataSource = dgvModiBill.DataSource as DataTable;

            // Thực hiện vẽ danh sách món hàng
            // ...

            // Ví dụ vẽ thông tin hóa đơn
            g.DrawString("ID Đơn Hàng: " + idDH, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(100, 100));
            g.DrawString("Tên Khách Hàng: " + tenKH, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(100, 120));
            g.DrawString("Tổng Bill: " + tongBill, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(100, 140));
            g.DrawString("=============================", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(100, 160));

            float yPosition = 180;
            int lineHeight = 90; // Khoảng cách giữa các dòng
            int lineWidth = 300; // Độ dài của đường kẻ ngang

            // Vẽ thông tin cho sản phẩm đầu tiên
            DataRow firstRow = dataSource.Rows[0];
            string maSP1 = firstRow["MaSP"].ToString();
            string tenSP1 = firstRow["TenSP"].ToString();
            string sl1 = firstRow["SoLuong"].ToString();
            string giaSP1 = firstRow["TongBill"].ToString();

            g.DrawString("Mã SP: " + maSP1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(100, yPosition));
            g.DrawString("Tên SP: " + tenSP1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(100, yPosition + 20));
            g.DrawString("Số lượng: " + sl1, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(100, yPosition + 40));
            g.DrawString("Giá SP: " + giaSP1 + " VNĐ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(100, yPosition + 60));

            yPosition += lineHeight; // Dịch vị trí vẽ xuống

            // Vẽ thông tin cho các sản phẩm từ sản phẩm thứ hai trở đi
            for (int i = 1; i < dataSource.Rows.Count; i++)
            {
                // Vẽ đường kẻ ngang
                g.DrawLine(new Pen(Brushes.Black), new PointF(100, yPosition - 10), new PointF(100 + lineWidth, yPosition - 10));

                DataRow row = dataSource.Rows[i];
                string maSP = row["MaSP"].ToString();
                string tenSP = row["TenSP"].ToString();
                string sl = row["SoLuong"].ToString();
                string giaSP = row["TongBill"].ToString();

                // Vẽ thông tin món hàng
                g.DrawString("Mã SP: " + maSP, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(100, yPosition));
                g.DrawString("Tên SP: " + tenSP, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(100, yPosition + 20));
                g.DrawString("Số lượng: " + sl, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(100, yPosition + 40));
                g.DrawString("Giá SP: " + giaSP + " VNĐ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new PointF(100, yPosition + 60));

                yPosition += lineHeight; // Dịch vị trí vẽ xuống
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printBill_PrintPage);

            // Specify the file path for saving the PDF
            string pdfPath = @"D:\Bill\" + lbIDDH.Text + ".pdf";

            // Set up the print controller for silent printing
            PrintController printController = new StandardPrintController();

            // Uncomment the following line if you want to show a print status dialog
            // printController = new PrintControllerWithStatusDialog(new StandardPrintController());

            printDocument.PrintController = printController;

            // Set the file name for saving the PDF
            printDocument.PrinterSettings.PrintFileName = lbIDDH.Text;

            try
            {
                // Print the document to the specified PDF file
                printDocument.Print();

                // Open the printed PDF file
                if (File.Exists(pdfPath))
                    System.Diagnostics.Process.Start(pdfPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing: " + ex.Message);
            }
        }
    }
}
