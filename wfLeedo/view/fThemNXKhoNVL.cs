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

namespace wfLeedo.view
{
    public partial class fThemNXKhoNVL : Form
    {
        string modeNX;
        public fThemNXKhoNVL(string modeNX)
        {
            InitializeComponent();
            this.modeNX = modeNX;
        }

        private void fThemNXKhoNVL_Load(object sender, EventArgs e)
        {
           
            List<CustomParameter> list = new List<CustomParameter>();
            var dt = new Database().SelectData("selectMaKho", list);
            DateTime time = DateTime.Now;
            dtTGNhap.Value = time;
            dtTGXuat.Value = time;
            cbMaKho.Items.Clear();
            foreach (DataRow r in dt.Rows)
            {
                string idKho = r["MaKho"].ToString();
                cbMaKho.Items.Add(idKho);
            }

            dt = new Database().SelectData("selectMaNVL", list);
            cbMaNVL.Items.Clear();
            foreach (DataRow r in dt.Rows)
            {
                string idNVL = r["MaNVL"].ToString();
                cbMaNVL.Items.Add(idNVL);
            }

            if (modeNX == "Nhập")
            {
                this.Text = "Tạo phiếu nhập hàng";
                txtSLXuat.Enabled = false;
                dtTGXuat.Enabled = false;
            }
            else if (modeNX == "Xuất")
            {
                this.Text = "Tạo phiếu xuất hàng";
                txtSLNhap.Enabled = false;
                dtTGNhap.Enabled = false;
            }
            
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Now;
                dtTGNhap.Value = dt;
                dtTGXuat.Value = dt;
                if (cbMaKho.Text != "" && cbMaNVL.Text != "")
                {
                    nvlViewModel newNVL = new nvlViewModel();
                    if (modeNX == "Nhập")
                    {
                        if (newNVL.insertNhapKhoNVL(cbMaKho.Text, cbMaNVL.Text, int.Parse(txtSLNhap.Text), 0, dtTGNhap.Value, null))
                        {
                            this.Close();
                        }
                    }
                    else if (modeNX == "Xuất")
                    {

                        int slTon = newNVL.getSLTonNVL(cbMaNVL.Text);
                        if(slTon - int.Parse(txtSLXuat.Text) < 0)
                        {
                            MessageBox.Show("Vui lòng nhập lại số lượng xuất! Số lượng xuất không được lớn hơn số lượng tồn kho!");
                        }
                        else if (newNVL.insertXuatKhoNVL(cbMaKho.Text, cbMaNVL.Text, 0, int.Parse(txtSLXuat.Text), null, dtTGXuat.Value))
                        {
                            this.Close();
                        }
                    }
                }
            }
            catch (FormatException ex)
            {
                // Xử lý lỗi kiểu dữ liệu sai (ví dụ: nhập chuỗi không phải số vào salary)
                MessageBox.Show("Lỗi: Nhập liệu không hợp lệ. Vui lòng kiểm tra lại các thông tin nhập vào.");
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác có thể xảy ra
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
