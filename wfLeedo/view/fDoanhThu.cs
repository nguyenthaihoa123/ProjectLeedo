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
            /*DataGridViewButtonColumn buttonColumn =
            new DataGridViewButtonColumn();
            buttonColumn.Name = "Details";
            buttonColumn.HeaderText = "Details";
            buttonColumn.Text = "View Details";

            // Use the Text property for the button text for all cells rather
            // than using each cell's value as the text for its own button.
            buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the control.
            test.Columns.Insert(0, buttonColumn);*/


            cbb_year.SelectedIndex = 0;

            cbb_month.SelectedIndex = 0;

            cbb_topic.SelectedIndex = 0;

            cbb_month.Enabled = false;



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
    }
}
