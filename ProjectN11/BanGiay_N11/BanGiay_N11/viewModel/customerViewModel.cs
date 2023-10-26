using BanGiay_N11.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanGiay_N11.viewModel
{
    internal class customerViewModel
    {
        public DataTable dataAllCustomer()
        {
            string tukhoa = "";
            string sql = "selectAllKhachHang";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            DataTable dt = new Database().SelectData(sql, list);
            return dt;
        }

        public customer dataCustomer(string id)
        {
            string mKH = id;
            var r = new Database().Select("selectAllKhachHang '" + mKH + "'");

            if (r != null)
            {
                string idCus = r["MaKH"].ToString();
                string name = r["HotenKH"].ToString();
                string sex = r["GT"].ToString();
                string birth = r["NgSinh"].ToString();
                string number = r["SDT"].ToString();
                string email = r["Email"].ToString();
                string address = r["DiaChi"].ToString();
                string pwd = r["MatKhau"].ToString();
                string point = r["TichDiem"].ToString();
                string voucher = r["Voucher"].ToString();

                customer customerObject = new customer(idCus, name, birth, sex, number, email, address, pwd, int.Parse(point), voucher);

                return customerObject;
            }

            // Trả về null hoặc thực hiện xử lý lỗi tùy thuộc vào yêu cầu của bạn
            return null;
        }
        public void updateKhachHang(customer cus)
        {
            string sql = "";
            //DateTime ngSinh;
            List<CustomParameter> list = new List<CustomParameter>();
            /*try
            {
                ngSinh = DateTime.ParseExact(cus.Birth, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                return;
            }*/
            sql = "updateKhachHang";
            list.Add(new CustomParameter()
            {
                key = "@MaKH",
                value = cus.Id
            });
            list.Add(new CustomParameter()
            {
                key = "@HotenKH",
                value = cus.Name
            });
            list.Add(new CustomParameter()
            {
                key = "@GT",
                value = cus.Sex
            });
            list.Add(new CustomParameter()
            {
                key = "@NgSinh",
                value = cus.Birth
            });
            list.Add(new CustomParameter()
            {
                key = "@SDT",
                value = cus.Sdt
            });
            list.Add(new CustomParameter()
            {
                key = "@Email",
                value = cus.Email
            });
            list.Add(new CustomParameter()
            {
                key = "@DiaChi",
                value = cus.DiaChi
            });
            list.Add(new CustomParameter()
            {
                key = "@MatKhau",
                value = cus.Pwd
            });
            list.Add(new CustomParameter()
            {
                key = "@Voucher",
                value = cus.Voucher
            });
            var rs = new Database().ExeCute(sql, list);
            if (rs == 1)
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
            }
            else
            {
                MessageBox.Show("Thực thi truy vấn thất bại");
            }
        }
        public void deleteCustomer(customer cus)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa Khách hàng: " + cus.Name.ToString() + " ?", "Xác nhận xóa!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var sql = "deleteKhachHang";
                List<CustomParameter> lst = new List<CustomParameter>();
                lst.Add(new CustomParameter()
                {
                    key = "@maKH",
                    value = cus.Id
                });
                var rs = new Database().ExeCute(sql, lst);
                MessageBox.Show("Xóa khách hàng thành công!");
                if (rs == 0)
                {
                    MessageBox.Show("Xóa khách hàng thất bại!!");
                }
            }
        }
    }
}
