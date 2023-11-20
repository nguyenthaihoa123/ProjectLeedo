using Guna.Charts.WinForms;
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

namespace wfLeedo.view
{
    public partial class fThongKe : Form
    {

        public fThongKe()
        {
            InitializeComponent();
        }

        private void fThongKe_Load(object sender, EventArgs e)
        {
            cbb_year.SelectedIndex = 0;

            cbb_month.SelectedIndex = 0;

            cbb_topic.SelectedIndex = 0;

            cbb_month.Enabled = false;
        }

        private void toggleMonth_CheckedChanged(object sender, EventArgs e)
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
            DataTable dt = null;
            String labeltopic = "";
            String valuetopic = "";
            gunaBarDataset.Label = cbb_topic.Text;
            gunaBarDataset.DataPoints.Clear ();

            if (toggleMonth.Checked)
            {

                filterMonth = true;
                month = cbb_month.Text;
                lbFilter.Text = "Dữ liệu vào " + month + "/" + year;
                labeltopic = "Ngay";
            }
            else
            {
                labeltopic = "Thang";
                lbFilter.Text = "Dữ liệu vào " + year;
            }


            switch (topic)
            {
                case "Doanh thu":
                    doanhthuViewModel doanhthuViewModel = new doanhthuViewModel();
                    valuetopic = "DoanhThu";
                    if (!filterMonth)
                    {
                        dt = doanhthuViewModel.dataDoanhThuNam(year);
                    }
                    else
                    {
                        dt = doanhthuViewModel.dataDoanhThuNgay(year, month);
                    }

                    break;

                case "Chi tiêu":
                    chitieuViewModel chitieuViewModel = new chitieuViewModel();
                    valuetopic = "ChiTieu";

                    if (!filterMonth)
                    {
                        dt = chitieuViewModel.dataChiTieuNam(year);
                    }
                    else
                    {
                        dt = chitieuViewModel.dataChiTieuNgay(year, month);
                    }

                    break;

                case "Lợi nhuận":
                    loinhuanViewModel loinhuanViewModel = new loinhuanViewModel();
                    valuetopic = "LoiNhuan";


                    if (!filterMonth)
                    {
                        dt = loinhuanViewModel.dataLoiNhuanNam(year);
                    }
                    else
                    {
                        dt = loinhuanViewModel.dataLoiNhuanNgay(year, month);
                    }

                    break;

                default:
                    break;
            }


            gunaBarDataset.DataPoints.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string label = row[labeltopic].ToString(); // Thay "LabelColumnName" bằng tên cột chứa nhãn

                // Thay "ValueColumnName" bằng tên cột chứa giá trị
                string valueStr = row[valuetopic].ToString();

                // Thử chia giá trị cho 1000 trước khi chuyển đổi
                if (decimal.TryParse(valueStr, out decimal originalValue))
                {
                    int value = (int)(originalValue / 1000); // Chia cho 1000 để bớt đi 3 số 0
                    gunaBarDataset.DataPoints.Add(new Guna.Charts.WinForms.LPoint(label, value));
                    gunaBarDataset.TargetChart = chartThongKe;
                }
                else
                {
                    // Xử lý trường hợp không thể chuyển đổi thành decimal
                    // Ví dụ: Log hoặc hiển thị thông báo lỗi.
                }
            }


        }


    }
}
