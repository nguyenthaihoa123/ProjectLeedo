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
    public partial class frmDSGV : Form
    {
        public frmDSGV()
        {
            InitializeComponent();
        }
        private void loadDSGV()
        {
            string sql = "selectAllGV";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSGV.DataSource = new Database().SelectData(sql, list);
        }

        private void frmDSGV_Load(object sender, EventArgs e)
        {
            loadDSGV();
            dgvDSGV.Columns["magiaovien"].HeaderText = "Mã SV";
            dgvDSGV.Columns["hoten"].HeaderText = "Họ tên";
            dgvDSGV.Columns["gt"].HeaderText = "Giới tính";
            dgvDSGV.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvDSGV.Columns["email"].HeaderText = "Email";
            dgvDSGV.Columns["dienthoai"].HeaderText = "Điện thoại";

        }
        private string tukhoa = "";
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimkiem.Text;
            loadDSGV();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmGV(null).ShowDialog();
            loadDSGV();
        }

        private void dgvDSGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var mgv = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                new frmGV(mgv).ShowDialog();
                loadDSGV();
            }
        }

        private void dgvDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvDSGV.Columns["btnDelete"].Index)
                {
                    if(MessageBox.Show("Bạn chắc chắn muốn xóa giáo viên: "+ dgvDSGV.Rows[e.RowIndex].Cells["hoten"].Value.ToString() + " ?", "Xác nhận xóa!!!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){

                        var maGV = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                        var sql = "deleteGV";
                        List<CustomParameter> lst = new List<CustomParameter>();
                        lst.Add(new CustomParameter()
                        {
                            key = "@magiaovien",
                            value = maGV
                        });
                        var rs = new Database().ExeCute(sql, lst);
                        MessageBox.Show("Xóa giáo viên thành công!");
                        loadDSGV();
                        if (rs == 0)
                        {
                            MessageBox.Show("Xóa giáo viên thất bại!!");
                        }
                    }
                }
            }
        }
    }
}
