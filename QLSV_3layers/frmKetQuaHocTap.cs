using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3layers
{
    public partial class frmKetQuaHocTap : Form
    {
        public frmKetQuaHocTap(string masv)
        {
            InitializeComponent();
            this.masv = masv;
        }
        private string masv;
        private void frmKetQuaHocTap_Load(object sender, EventArgs e)
        {
            LoadKQHT();
            dgvKQHT.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvKQHT.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvKQHT.Columns["gvien"].HeaderText = "Giáo viên";
            dgvKQHT.Columns["lanhoc"].HeaderText = "Số lần học";
            dgvKQHT.Columns["diemlan1"].HeaderText = "Điểm lần 1";
            dgvKQHT.Columns["diemlan2"].HeaderText = "Điểm lần 2";
        }
        private void LoadKQHT()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = this.masv
            });
            lst.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTimKiem.Text
            });
            dgvKQHT.DataSource = new Database().SelectData("tracuudiem",lst);
        }
    }
}
