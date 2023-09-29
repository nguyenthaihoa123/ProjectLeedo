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
    public partial class frmQuanLyLop : Form
    {
        public frmQuanLyLop(string magv)
        {
            InitializeComponent();
            this.magv = magv;
        }
        private string magv;
        private void frmQuanLyLop_Load(object sender, EventArgs e)
        {
            LoadQLLop();
            dgvQLLop.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvQLLop.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvQLLop.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvQLLop.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvQLLop.Columns["siso"].HeaderText = "Sỉ số";
        }
        private void LoadQLLop()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = this.magv
            });
            lst.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTimKiem.Text
            });
            dgvQLLop.DataSource = new Database().SelectData("tracuulop", lst);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadQLLop();
        }
    }
}
