﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3layers
{
    public partial class frmGV : Form
    {
        public frmGV(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }
        private string mgv;
        private string nguoicapnhat = "admin";

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmGV_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(mgv))
            {
                this.Text = "Thêm mới giáo viên";
            }
            else
            {
                this.Text = "Cập nhật giáo viên";
                var r = new Database().Select("selectGV '"+ int.Parse(mgv) + "'");
                txtHo.Text = r["ho"].ToString();
                txtTendem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                rbtNam.Checked = r["gioitinh"].ToString() == "1"? true : false;
                mbtNgaysinh.Text = r["ngsinh"].ToString();
                txtDienthoai.Text = r["dienthoai"].ToString();
                txtEmail.Text = r["email"].ToString();
                txtDiachi.Text = r["diachi"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            DateTime ngaysinh;
            List<CustomParameter> list = new List<CustomParameter>();
            try
            {
                ngaysinh = DateTime.ParseExact(mbtNgaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mbtNgaysinh.Select();
                return;
            }
            if(string.IsNullOrEmpty(mgv) )
            {
                sql = "insertGV";
                list.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoicapnhat
                });
            }
            else
            {
                sql = "updateGV";
                list.Add(new CustomParameter()
                {
                    key = "@magiaovien",
                    value = mgv
                });
                list.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoicapnhat
                });
            }
            list.Add(new CustomParameter()
            {
                key = "@ho",
                value = txtHo.Text
            });
            list.Add(new CustomParameter()
            {
                key = "@tendem",
                value = txtTendem.Text
            });
            list.Add(new CustomParameter()
            {
                key = "@ten",
                value = txtTen.Text
            });
            list.Add(new CustomParameter()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            list.Add(new CustomParameter()
            {
                key = "@gioitinh",
                value = rbtNam.Checked?"1":"0"
            });
            list.Add(new CustomParameter()
            {
                key = "@email",
                value = txtEmail.Text
            });
            list.Add(new CustomParameter()
            {
                key = "@diachi",
                value = txtDiachi.Text
            });
            list.Add(new CustomParameter()
            {
                key = "@dienthoai",
                value = txtDienthoai.Text
            });

            var rs = new Database().ExeCute(sql, list);
            if(rs == 1)
            {
                if(string.IsNullOrEmpty(mgv))
                {
                    MessageBox.Show("Thêm mới giáo viên thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin giáo viên thành công!");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi truy vấn thất bại");
            }
        }
    }
}
