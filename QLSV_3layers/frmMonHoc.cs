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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc(string mamh)
        {
            this.mamh = mamh;
            InitializeComponent();
        }
        private string mamh;
        private string nguoithuchien = "admin";
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(mamh))
            {
                this.Text = "Thêm mới môn học";
            }
            else
            {
                this.Text = "Cập nhật môn học";
                var r = new Database().Select("exec selectMH '" + mamh + "'");
                cbbMonHoc.Text = r["tenmonhoc"].ToString();
                txtSoTC.Text = r["sotinchi"].ToString();
            }
        }

        private void txtSoTC_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var stc = int.Parse(txtSoTC.Text);
                if(stc < 0)
                {
                    MessageBox.Show("Số tín chỉ phải lớn hơn 0");
                    txtSoTC.Select();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Số tín chỉ phải là kiểu số nguyên");
                txtSoTC.Select();
                return;
            }
            if(string.IsNullOrEmpty(cbbMonHoc.Text))
            {
                MessageBox.Show("Tên môn học không được để trống");
                cbbMonHoc.Select();
                return;
            }
            string sql = "";
            List<CustomParameter> lstpara = new List<CustomParameter>();
            if(string.IsNullOrEmpty(this.mamh) )
            {
                sql = "insertMH";
                lstpara.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithuchien
                });
            }
            else
            {
                sql = "updateMH";
                lstpara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithuchien
                });
                lstpara.Add(new CustomParameter()
                {
                    key = "@mamonhoc",
                    value = mamh
                });
            }
            lstpara.Add(new CustomParameter()
            {
                key = "@tenmonhoc",
                value = cbbMonHoc.Text
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@sotinchi",
                value = txtSoTC.Text
            });

            var rs = new Database().ExeCute(sql, lstpara);
            if(rs == 1)
            {
                if(string.IsNullOrEmpty(mamh) )
                {
                    MessageBox.Show("Thêm mới môn học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật môn học thành công");
                }
            }
            else
            {
                MessageBox.Show("Thực hiện truy vấn thất bại");
            }
            this.Dispose();
        }
    }
}
