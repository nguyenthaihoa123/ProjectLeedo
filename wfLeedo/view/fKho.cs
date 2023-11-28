using BanGiay_N11.model;
using BanGiay_N11.viewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using wfLeedo.view;

namespace wfLeedo
{
    public partial class fKho : Form
    {
        private fThemSP formSP;
        private fThemNVL formNVL;
        private fThemNXKhoNVL formNXKhoNVL;
        private static string mode;
        private static string modeNX;
        public fKho()
        {
            InitializeComponent();
            mode = cbModel.SelectedItem.ToString();
            modeNX = cbNXMode.SelectedItem.ToString();
        }
        private void fKho_Load_1(object sender, EventArgs e)
        {
            nvlViewModel dataAllNVL = new nvlViewModel();
            dgvKho.DataSource = dataAllNVL.dataAllNVL();
            dgvNXMode.DataSource = dataAllNVL.dataAllKhoNVL();

            dgvKho.ReadOnly = true;
            dgvNXMode.ReadOnly = true;
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            //mode = cbModel.SelectedItem.ToString();
            if (mode == "Sản phẩm")
            {
                formSP = new fThemSP("");
                formSP.Dock = DockStyle.Fill;
                formSP.Show();
            }
            else if (mode == "Nguyên vật liệu")
            {
                formNVL = new fThemNVL("");
                formNVL.Dock = DockStyle.Fill;
                formNVL.Show();
            }
        }

        private void dgvKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //mode = cbModel.SelectedItem.ToString();
            if (e.RowIndex >= 0)
            {
                if (mode == "Sản phẩm")
                {
                    productViewModel dataPro = new productViewModel();
                    var maSP = dgvKho.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
                    formSP = new fThemSP(maSP);
                    formSP.Dock = DockStyle.Fill;
                    formSP.Show();
                }
                else if (mode == "Nguyên vật liệu")
                {
                    nvlViewModel dataNVL = new nvlViewModel();
                    var maNVL = dgvKho.Rows[e.RowIndex].Cells["MaNVL"].Value.ToString();
                    formNVL = new fThemNVL(maNVL);
                    formNVL.Dock = DockStyle.Fill;
                    formNVL.Show();
                }
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            //mode = cbModel.SelectedItem.ToString();

            txtSearch.Text = "";

            if (mode == "Sản phẩm")
            {
                productViewModel dataAllPro = new productViewModel();
                dgvKho.DataSource = dataAllPro.dataAllProduct();
                if (modeNX == "Tất cả")
                {
                    dgvNXMode.DataSource = dataAllPro.dataAllKhoSP();
                }
                else if (modeNX == "Nhập")
                {
                    dgvNXMode.DataSource = dataAllPro.dataNhapKhoSP();
                }
                else if (modeNX == "Xuất")
                {
                    dgvNXMode.DataSource = dataAllPro.dataXuatKhoSP();
                }
            }
            else if (mode == "Nguyên vật liệu")
            {
                nvlViewModel dataAllNVL = new nvlViewModel();
                dgvKho.DataSource = dataAllNVL.dataAllNVL();
                if (modeNX == "Tất cả")
                {
                    dgvNXMode.DataSource = dataAllNVL.dataAllKhoNVL();
                }
                else if (modeNX == "Nhập")
                {
                    dgvNXMode.DataSource = dataAllNVL.dataNhapKhoNVL();
                }
                else if (modeNX == "Xuất")
                {
                    dgvNXMode.DataSource = dataAllNVL.dataXuatKhoNVL();
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //mode = cbModel.SelectedItem.ToString();
            if (txtSearch.Text != "")
            {
                if (mode == "Sản phẩm")
                {
                    var maSP = txtSearch.Text;
                    productViewModel dataPro = new productViewModel();
                    Product newPro = dataPro.dataProduct(maSP);
                    if (newPro != null)
                    {
                        formSP = new fThemSP(maSP);
                        formSP.Dock = DockStyle.Fill;
                        formSP.Show();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin sản phẩm.");
                    }
                }
                else if (mode == "Nguyên vật liệu")
                {
                    var maNVL = txtSearch.Text;
                    nvlViewModel dataNVL = new nvlViewModel();
                    NguyenVatLieu newNVL = dataNVL.dataNVL(maNVL);
                    if (newNVL != null)
                    {
                        formNVL = new fThemNVL(maNVL);
                        formNVL.Dock = DockStyle.Fill;
                        formNVL.Show();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin nguyên vật liệu.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập thông tin để thực hiện quá trình tìm kiếm!");

            }
        }

        private void deleteNXBtn_Click(object sender, EventArgs e)
        {
            if (dgvNXMode.SelectedRows.Count > 0)
            {
                DateTime? time;
                if (mode == "Nguyên vật liệu")
                {
                    nvlViewModel newNVL = new nvlViewModel();
                    int rowIndex = dgvNXMode.SelectedRows[0].Index;
                    dgvNXMode.Rows.RemoveAt(rowIndex);

                    string tgNhap = dgvNXMode.SelectedRows[0].Cells["TG_NhapNVL"].Value.ToString();
                    string tgXuat = dgvNXMode.SelectedRows[0].Cells["TG_XuatNVL"].Value.ToString();

                    if (string.IsNullOrEmpty(tgXuat))
                    {
                        time = Convert.ToDateTime(tgNhap);
                        newNVL.deleteNKhoNVL(time);
                    }
                    else
                    {
                        time = Convert.ToDateTime(tgXuat);
                        newNVL.deleteXKhoNVL(time);
                    }
                }
                else if (mode == "Sản phẩm")
                {
                    productViewModel newPro = new productViewModel();
                    int rowIndex = dgvNXMode.SelectedRows[0].Index;
                    dgvNXMode.Rows.RemoveAt(rowIndex);

                    string tgNhap = dgvNXMode.SelectedRows[0].Cells["TG_NhapSP"].Value.ToString();
                    string tgXuat = dgvNXMode.SelectedRows[0].Cells["TG_XuatSP"].Value.ToString();

                    if (string.IsNullOrEmpty(tgXuat))
                    {
                        time = Convert.ToDateTime(tgNhap);
                        newPro.deleteNKhoSP(time);
                    }
                    else
                    {
                        time = Convert.ToDateTime(tgXuat);
                        newPro.deleteXKhoSP(time);
                    }
                }
            }
        }

        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = cbModel.SelectedItem.ToString();

            if (mode == "Sản phẩm")
            {
                productViewModel dataAllPro = new productViewModel();
                dgvKho.DataSource = dataAllPro.dataAllProduct();
                dgvNXMode.DataSource = dataAllPro.dataAllKhoSP();
            }
            else if (mode == "Nguyên vật liệu")
            {
                nvlViewModel dataAllNVL = new nvlViewModel();
                dgvKho.DataSource = dataAllNVL.dataAllNVL();
                dgvNXMode.DataSource = dataAllNVL.dataAllKhoNVL();
            }

            dgvKho.ReadOnly = true;
            dgvNXMode.ReadOnly = true;
        }

        private void cbNXMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            modeNX = cbNXMode.SelectedItem.ToString();
            if (mode == "Sản phẩm")
            {
                productViewModel dataAllPro = new productViewModel();
                if (modeNX == "Tất cả")
                {
                    dgvNXMode.DataSource = dataAllPro.dataAllKhoSP();
                }
                else if (modeNX == "Nhập")
                {
                    dgvNXMode.DataSource = dataAllPro.dataNhapKhoSP();
                }
                else if (modeNX == "Xuất")
                {
                    dgvNXMode.DataSource = dataAllPro.dataXuatKhoSP();
                }
            }
            else if (mode == "Nguyên vật liệu")
            {
                nvlViewModel dataAllNVL = new nvlViewModel();
                if (modeNX == "Tất cả")
                {
                    dgvNXMode.DataSource = dataAllNVL.dataAllKhoNVL();
                }
                else if (modeNX == "Nhập")
                {
                    dgvNXMode.DataSource = dataAllNVL.dataNhapKhoNVL();
                }
                else if (modeNX == "Xuất")
                {
                    dgvNXMode.DataSource = dataAllNVL.dataXuatKhoNVL();
                }
            }
        }

        private void insertNXBtn_Click(object sender, EventArgs e)
        {
            if (mode == "Sản phẩm")
            {
                if (modeNX == "Nhập" || modeNX == "Xuất")
                {
                    formNXKhoNVL = new fThemNXKhoNVL(mode, modeNX);
                    formNXKhoNVL.Dock = DockStyle.Fill;
                    formNXKhoNVL.Show();
                }
                else if (modeNX == "Tất cả")
                {
                    MessageBox.Show("Vui lòng chọn 1 trong 2 chức năng nhập/xuất!");
                }
            }
            else if (mode == "Nguyên vật liệu")
            {
                if (modeNX == "Nhập" || modeNX == "Xuất")
                {
                    formNXKhoNVL = new fThemNXKhoNVL(mode, modeNX);
                    formNXKhoNVL.Dock = DockStyle.Fill;
                    formNXKhoNVL.Show();
                }
                else if (modeNX == "Tất cả")
                {
                    MessageBox.Show("Vui lòng chọn 1 trong 2 chức năng nhập/xuất!");
                }
            }
        }

        private void filterTimeBtn_Click(object sender, EventArgs e)
        {
            DateTime sTime, eTime;
            sTime = dtBSearchNX.Value;
            eTime = dtESearchNX.Value;

            if (mode == "Nguyên vật liệu")
            {
                nvlViewModel newNVL = new nvlViewModel();

                if (modeNX == "Tất cả")
                {
                    MessageBox.Show("Vui lòng chọn chức năng nhập/xuất để thực hiện bộ lọc!");
                }
                else if (modeNX == "Nhập")
                {
                    dgvNXMode.DataSource = newNVL.dataNKhoNVLbyTime(sTime, eTime);
                }
                else if (modeNX == "Xuất")
                {
                    dgvNXMode.DataSource = newNVL.dataXKhoNVLbyTime(sTime, eTime);
                }
            }
            else if (mode == "Sản phẩm")
            {
                productViewModel newPro = new productViewModel();

                if (modeNX == "Tất cả")
                {
                    MessageBox.Show("Vui lòng chọn chức năng nhập/xuất để thực hiện bộ lọc!");
                }
                else if (modeNX == "Nhập")
                {
                    dgvNXMode.DataSource = newPro.dataNKhoSPbyTime(sTime, eTime);
                }
                else if (modeNX == "Xuất")
                {
                    dgvNXMode.DataSource = newPro.dataXKhoSPbyTime(sTime, eTime);
                }
            }
        }

        private void printBillNX_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            DateTime dt = DateTime.Now;
            string label = "";
            string now;

            now = dt.ToString();

            if (mode == "Nguyên vật liệu")
            {
                if (modeNX == "Nhập")
                {
                    label = "HÓA ĐƠN NHẬP NGUYÊN VẬT LIỆU";
                }
                else if (modeNX == "Xuất")
                {
                    label = "HÓA ĐƠN XUẤT NGUYÊN VẬT LIỆU";
                }
            }
            else if (mode == "Sản phẩm")
            {
                if (modeNX == "Nhập")
                {
                    label = "HÓA ĐƠN NHẬP SẢN PHẨM";
                }
                else if (modeNX == "Xuất")
                {
                    label = "HÓA ĐƠN XUẤT SẢN PHẨM";
                }
            }

            DataTable dtSource = dgvNXMode.DataSource as DataTable;

            g.DrawString(label, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(250, 100));
            g.DrawString("Thời gian tạo hóa đơn: " + now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(220, 120));
            g.DrawString("-----------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(200, 140));

            float yPosition = 160;
            int lineHeight = 70; // Khoảng cách giữa các dòng
            int lineWidth = 300;

            string cID = "";
            string cKho = dgvNXMode.SelectedRows[0].Cells["MaKho"].Value.ToString();
            if (mode == "Nguyên vật liệu")
            {
                cID = dgvNXMode.SelectedRows[0].Cells["MaNVL"].Value.ToString();
            }
            else if (mode == "Sản phẩm")
            {
                cID = dgvNXMode.SelectedRows[0].Cells["MaSP"].Value.ToString();
            }

            int countK = 0;
            int countID = 0;
            int tong = 0;
            for (int i = 0; i < dtSource.Rows.Count; i++)
            {
                DataRow row = dtSource.Rows[i];
                string maKho = row["MaKho"].ToString();
                if (maKho == cKho)
                {
                    if (countK == 0)
                    {
                        g.DrawString("Mã kho: " + cKho, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(220, yPosition));
                    }
                    if (mode == "Nguyên vật liệu")
                    {
                        string maNVL = row["MaNVL"].ToString();
                        if (countID == 0)
                        {
                            g.DrawString("- Mã nguyên vật liệu: " + cID, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(240, yPosition += 20));
                        }
                        if (modeNX == "Nhập" && maNVL == cID)
                        {
                            string sl_nhap = row["SL_NhapNVL"].ToString();
                            string tg_nhap = row["TG_NhapNVL"].ToString();

                            g.DrawString("+ Thời gian nhập: " + tg_nhap, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(260, yPosition += 20));
                            g.DrawString("• Số lượng nhập: " + sl_nhap, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(280, yPosition += 20));
                            tong += int.Parse(sl_nhap);
                        }
                        else if (modeNX == "Xuất" && maNVL == cID)
                        {
                            string sl_xuat = row["SL_XuatNVL"].ToString();
                            string tg_xuat = row["TG_XuatNVL"].ToString();

                            g.DrawString("+ Thời gian xuất: " + tg_xuat, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(260, yPosition += 20));
                            g.DrawString("• Số lượng xuất: " + sl_xuat, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(280, yPosition += 20));
                            tong += int.Parse(sl_xuat);
                        }
                    }
                    else if (mode == "Sản phẩm")
                    {
                        string maSP = row["MaSP"].ToString();
                        if (countID == 0)
                        {
                            g.DrawString("- Mã sản phẩm: " + cID, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(240, yPosition += 20));
                        }
                        if (modeNX == "Nhập" && maSP == cID)
                        {
                            string sl_nhap = row["SL_NhapSP"].ToString();
                            string tg_nhap = row["TG_NhapSP"].ToString();

                            g.DrawString("+ Thời gian nhập: " + tg_nhap, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(260, yPosition += 20));
                            g.DrawString("• Số lượng nhập: " + sl_nhap, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(280, yPosition += 20));
                            tong += int.Parse(sl_nhap);
                        }
                        else if (modeNX == "Xuất" && maSP == cID)
                        {
                            string sl_xuat = row["SL_XuatSP"].ToString();
                            string tg_xuat = row["TG_XuatSP"].ToString();

                            g.DrawString("+ Thời gian xuất: " + tg_xuat, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(260, yPosition += 20));
                            g.DrawString("• Số lượng xuất: " + sl_xuat, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(280, yPosition += 20));
                            tong += int.Parse(sl_xuat);
                        }
                    }
                    countK++;
                    countID++;
                }
            }
            g.DrawString("+ Tổng số lượng: " + tong, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(260, yPosition += 20));
            g.DrawString("-----------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(200, yPosition += 20));
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (modeNX == "Tất cả")
            {
                MessageBox.Show("Vui lòng chọn chức năng nhập/xuất để thực hiện chức năng in phiếu!");
            }
            else
            {
                DateTime now = DateTime.Now;
                printBillNX = new PrintDocument();
                printBillNX.PrintPage += new PrintPageEventHandler(printBillNX_PrintPage);

                string pdfPath = @"D:\Bill\BillNX_" + now + ".pdf";

                PrintController printController = new StandardPrintController();
                //printController = new PrintControllerWithStatusDialog(new StandardPrintController());
                printBillNX.PrintController = printController;

                printBillNX.PrinterSettings.PrintFileName = "BillNX_" + now;

                try
                {
                    // Print the document to the specified PDF file
                    printBillNX.Print();

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
}
