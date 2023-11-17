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
        string maNVL;
        string modeNX;
        public fThemNXKhoNVL(string maNVL, string modeNX)
        {
            InitializeComponent();
            this.maNVL = maNVL;
            this.modeNX = modeNX;
        }

        private void fThemNXKhoNVL_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maNVL))
            {
                List<CustomParameter> list = new List<CustomParameter>();
                var dt = new Database().SelectData("selectMaKho", list);
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
                }
                else if (modeNX == "Xuất")
                {
                    this.Text = "Tạo phiếu xuất hàng";
                }
                saveBtn.Enabled = false;
            }
            else
            {
                this.Text = "Sửa thông tin nguyên vật liệu";
                insertBtn.Enabled = false;
                nvlViewModel dataNVL = new nvlViewModel();
                NguyenVatLieu newNVL = dataNVL.dataNVL(maNVL);
                //showData(newNVL);
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
