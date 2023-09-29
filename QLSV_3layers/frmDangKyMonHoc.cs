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
    public partial class frmDangKyMonHoc : Form
    {
        public frmDangKyMonHoc(string masv)
        {
            InitializeComponent();
            this.masv = masv;
        }
        private string masv;
        private void frmDangKyMonHoc_Load(object sender, EventArgs e)
        {
            LoadDSLH();
            dgvDSLH.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvDSLH.Columns["tenmonhoc"].HeaderText = "Tên học phần";
            dgvDSLH.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvDSLH.Columns["gvien"].HeaderText = "Giáo viên";
            dgvDSLH.Columns["mamonhoc"].Visible = false;

        }
        private void LoadDSLH()
        {
            List<CustomParameter> lst = new List<CustomParameter>() {
                new CustomParameter()
                {
                    key = "@masinhvien",
                    value = this.masv
                }
            };
            dgvDSLH.DataSource = new Database().SelectData("dsLopChuaDky", lst);
        }

        private void dgvDSLH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSLH.Rows[e.RowIndex].Index >= 0)
            {
                if (DialogResult.Yes == MessageBox.Show(
                    "Bạn muốn đăng ký học phần [" + dgvDSLH.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString()+"]",
                    "Xác nhận đăng kí",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ))
                {
                    List<CustomParameter> lst = new List<CustomParameter>();
                    lst.Add(new CustomParameter()
                    {
                        key = "@masinhvien",
                        value = this.masv
                    });
                    lst.Add(new CustomParameter()
                    {
                        key = "@malophoc",
                        value = dgvDSLH.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()
                    });
                    var rs = new Database().ExeCute("[dkyhoc]",lst);
                    if(rs == -1)
                    {
                        MessageBox.Show("Học phần này bạn đã đăng kí", "Cảnh báo!!!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Đã đăng kí học phần thành công", "SUCCESS!!!");
                        LoadDSLH();
                        return;
                    }
                }
                //MessageBox.Show("Tên môn học đã được chọn" + dgvDSLH.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString());
            }
        }
    }
}
