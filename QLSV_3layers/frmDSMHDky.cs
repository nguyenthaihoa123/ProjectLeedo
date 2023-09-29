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
    public partial class frmDSMHDky : Form
    {
        public frmDSMHDky(string masv)
        {
            InitializeComponent();
            this.masv = masv;
        }
        private string masv;
        private void frmDSMHDky_Load(object sender, EventArgs e)
        {
            LoadMonDky();
        }
        private void LoadMonDky()
        {
            List<CustomParameter> lst = new List<CustomParameter>() {
                new CustomParameter()
                {
                    key = "@masinhvien",
                    value = masv
                }
            };
            dgvDSMHDky.DataSource = new Database().SelectData("monDangKy", lst);
        }

        private void btnDangKyMoi_Click(object sender, EventArgs e)
        {
            new frmDangKyMonHoc(masv).ShowDialog();
            LoadMonDky();
        }
    }
}
