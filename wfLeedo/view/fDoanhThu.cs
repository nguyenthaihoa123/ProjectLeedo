using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfLeedo.viewModel;
using OfficeOpenXml;
using System.IO;

namespace wfLeedo
{
    public partial class fDoanhThu : Form
    {
        public fDoanhThu()
        {
            InitializeComponent();
        }

        private void fDoanhThu_Load(object sender, EventArgs e)
        {
            doanhthuViewModel doanhthuViewModel = new doanhthuViewModel();
            lbFilter.Text = "Dữ liệu vào " + cbb_year.Text;
            dgvDoanhThu.DataSource = doanhthuViewModel.dataDoanhThuNam(cbb_year.Text);

            cbb_month.Enabled = false;

            dgvDoanhThu.Columns["Thang"].HeaderText = "Tháng";
            dgvDoanhThu.Columns["DoanhThu"].HeaderText = "Doanh thu";
            
        }

        private void swMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleMonth.Checked)
            {
                cbb_month.Enabled = true;
            }
            else
            {
                cbb_month.Enabled = false;
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            String topic = cbb_topic.Text;
            String year = cbb_year.Text;
            String month = "";
            Boolean filterMonth = false;
            if (toggleMonth.Checked)
            {

                filterMonth = true;
                month = cbb_month.Text;
                lbFilter.Text = "Dữ liệu vào " + month + "/" + year;
            }
            else
            {
                lbFilter.Text = "Dữ liệu vào " + year;
            }

            switch (topic)
            {
                case "Doanh thu":
                    doanhthuViewModel doanhthuViewModel = new doanhthuViewModel();
                    if (!filterMonth)
                    {
                        dgvDoanhThu.DataSource = doanhthuViewModel.dataDoanhThuNam(year);
                    }
                    else
                    {
                        dgvDoanhThu.DataSource = doanhthuViewModel.dataDoanhThuNgay(year, month);
                    }

                    break;

                case "Chi tiêu":
                    chitieuViewModel chitieuViewModel = new chitieuViewModel();

                    if (!filterMonth)
                    {
                        dgvDoanhThu.DataSource = chitieuViewModel.dataChiTieuNam(year);
                    }
                    else
                    {
                        dgvDoanhThu.DataSource = chitieuViewModel.dataChiTieuNgay(year, month);
                    }

                    break;

                case "Lợi nhuận":
                    loinhuanViewModel loinhuanViewModel = new loinhuanViewModel();

                    if (!filterMonth)
                    {
                        dgvDoanhThu.DataSource = loinhuanViewModel.dataLoiNhuanNam(year);
                    }
                    else
                    {
                        dgvDoanhThu.DataSource = loinhuanViewModel.dataLoiNhuanNgay(year, month);
                    }

                    break;

                default:
                    break;
            }
        }

        private void dgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Thiết lập các thuộc tính của SaveFileDialog
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí để lưu tệp CSV";
            //saveFileDialog.InitialDirectory = "C:\\"; // Đường dẫn mặc định khi mở hộp thoại

            // Hiển thị hộp thoại SaveFileDialog
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Build the CSV file data as a Comma separated string.
                string csv = string.Empty;

                // Add the Header row for CSV file.
                foreach (DataGridViewColumn column in dgvDoanhThu.Columns)
                {
                    csv += column.HeaderText + ',';
                }

                // Add new line.
                csv += "\r\n";

                // Adding the Rows
                foreach (DataGridViewRow row in dgvDoanhThu.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Add the Data rows.
                        csv += cell.Value?.ToString().Replace(",", ";") + ','; // Check for null values
                    }

                    // Add new line.
                    csv += "\r\n";
                }

                // Lưu tệp CSV vào địa chỉ đã chọn
                File.WriteAllText(saveFileDialog.FileName, csv);
                MessageBox.Show("Xuất file báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
