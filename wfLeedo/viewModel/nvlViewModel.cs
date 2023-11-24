using BanGiay_N11.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfLeedo;

namespace BanGiay_N11.viewModel
{
    internal class nvlViewModel
    {
        public DataTable dataAllNVL()
        {
            string tukhoa = "";
            string sql = "SelectAllNVLWithTonKho";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            DataTable dt = new Database().SelectData(sql, list);
            return dt;
        }
        public NguyenVatLieu dataNVL(string id)
        {
            string maNVL = id;
            var r = new Database().Select("SelectAllNVL '" + maNVL + "'");

            if (r != null)
            {
                string idNVL = r["MaNVL"].ToString();
                string type = r["LoaiNVL"].ToString();
                string name = r["TenNVL"].ToString();
                string price = r["GiaNVL"].ToString();
                string donvi = r["Donvitinh"].ToString();

                NguyenVatLieu nvlObject = new NguyenVatLieu(idNVL, type, name, double.Parse(price), donvi);

                return nvlObject;
            }

            // Trả về null hoặc thực hiện xử lý lỗi tùy thuộc vào yêu cầu của bạn
            return null;
        }
        public Boolean insertNVL(NguyenVatLieu nvl)
        {
            string sql = "insertNVL";
            List<CustomParameter> list = new List<CustomParameter>();

            list.Add(new CustomParameter()
            {
                key = "@MaNVL",
                value = nvl.Id
            });
            list.Add(new CustomParameter()
            {
                key = "@LoaiNVL",
                value = nvl.Type
            });
            list.Add(new CustomParameter()
            {
                key = "@TenNVL",
                value = nvl.Name
            });
            list.Add(new CustomParameter()
            {
                key = "@GiaNVL",
                value = nvl.Price.ToString()
            });
            list.Add(new CustomParameter()
            {
                key = "@Donvitinh",
                value = nvl.DonVi
            });

            var rs = new Database().ExeCute(sql, list);
            if (rs == 1)
            {
                MessageBox.Show("Thêm nguyên vật liệu mới thành công!");
                return true;
            }
            else
            {
                MessageBox.Show("Thêm nguyên vật liệu mới thất bại!");
                return false;
            }
        }
        public void updateNVL(NguyenVatLieu nvl)
        {
            string sql = "updateNVL";
            List<CustomParameter> list = new List<CustomParameter>();

            list.Add(new CustomParameter()
            {
                key = "@MaNVL",
                value = nvl.Id
            });
            list.Add(new CustomParameter()
            {
                key = "@LoaiNVL",
                value = nvl.Type
            });
            list.Add(new CustomParameter()
            {
                key = "@TenNVL",
                value = nvl.Name
            });
            list.Add(new CustomParameter()
            {
                key = "@GiaNVL",
                value = nvl.Price.ToString()
            });
            list.Add(new CustomParameter()
            {
                key = "@Donvitinh",
                value = nvl.DonVi
            });

            var rs = new Database().ExeCute(sql, list);
            if (rs == 1)
            {
                MessageBox.Show("Cập nhật thông tin nguyên vật liệu thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin nguyên vật liệu thất bại!");
            }
        }
        public DataTable dataAllKhoNVL()
        {
            string sql = "SelectAllKhoNVL";
            List<CustomParameter> list = new List<CustomParameter>();
            DataTable dt = new Database().SelectData(sql, list);
            return dt;
        }
        public DataTable dataNhapKhoNVL()
        {
            string sql = "selectNhapKhoNVL";
            List<CustomParameter> list = new List<CustomParameter>();
            DataTable dt = new Database().SelectData(sql, list);
            return dt;
        }
        public DataTable dataXuatKhoNVL()
        {
            string sql = "selectXuatKhoNVL";
            List<CustomParameter> list = new List<CustomParameter>();
            DataTable dt = new Database().SelectData(sql, list);
            return dt;
        }
        public Boolean insertNhapKhoNVL(string maKho, string maNVL, int slNhap, int slXuat, DateTime tgNhap, DateTime? tgXuat)
        {
            string sql = "insertNhapKhoNVL";
            List<CustomParameter> list = new List<CustomParameter>();

            list.Add(new CustomParameter()
            {
                key = "@MaKho",
                value = maKho
            });
            list.Add(new CustomParameter()
            {
                key = "@MaNVL",
                value = maNVL
            });
            list.Add(new CustomParameter()
            {
                key = "@SL_NhapNVL",
                value = slNhap.ToString()
            });
            list.Add(new CustomParameter()
            {
                key = "@SL_XuatNVL",
                value = slXuat.ToString()
            });
            list.Add(new CustomParameter()
            {
                key = "@TG_NhapNVL",
                value = tgNhap.ToString()
            });
            list.Add(new CustomParameter()
            {
                key = "@TG_XuatNVL",
                value = tgXuat.ToString()
            });

            var rs = new Database().ExeCute(sql, list);
            if (rs == 1)
            {
                MessageBox.Show("Tạo phiếu nhập hàng mới thành công!");
                return true;
            }
            else
            {
                MessageBox.Show("Tạo phiếu nhập hàng mới thất bại!");
                return false;
            }
        }
        public Boolean insertXuatKhoNVL(string maKho, string maNVL, int slNhap, int slXuat, DateTime? tgNhap, DateTime tgXuat)
        {
            string sql = "insertXuatKhoNVL";
            List<CustomParameter> list = new List<CustomParameter>();

            list.Add(new CustomParameter()
            {
                key = "@MaKho",
                value = maKho
            });
            list.Add(new CustomParameter()
            {
                key = "@MaNVL",
                value = maNVL
            });
            list.Add(new CustomParameter()
            {
                key = "@SL_NhapNVL",
                value = slNhap.ToString()
            });
            list.Add(new CustomParameter()
            {
                key = "@SL_XuatNVL",
                value = slXuat.ToString()
            });
            list.Add(new CustomParameter()
            {
                key = "@TG_NhapNVL",
                value = tgNhap.ToString()
            });
            list.Add(new CustomParameter()
            {
                key = "@TG_XuatNVL",
                value = tgXuat.ToString()
            });

            var rs = new Database().ExeCute(sql, list);
            if (rs == 1)
            {
                MessageBox.Show("Tạo phiếu xuất hàng mới thành công!");
                return true;
            }
            else
            {
                MessageBox.Show("Tạo phiếu xuất hàng mới thất bại!");
                return false;
            }
        }
        public Boolean deleteNKhoNVL(DateTime? tg_nhap)
        {
            string sql = "deleteNhapKhoNVL";
            List<CustomParameter> list = new List<CustomParameter>();

            list.Add(new CustomParameter()
            {
                key = "@tg_nhap",
                value = tg_nhap.ToString()
            });

            var rs = new Database().ExeCute(sql, list);
            if (rs == 1)
            {
                MessageBox.Show("Xóa phiếu nhập thành công!");
                return true;
            }
            else
            {
                MessageBox.Show("Xóa phiếu nhập thất bại!");
                return false;
            }
        }
        public Boolean deleteXKhoNVL(DateTime? tg_xuat)
        {
            string sql = "deleteXuatKhoNVL";
            List<CustomParameter> list = new List<CustomParameter>();

            list.Add(new CustomParameter()
            {
                key = "@tg_xuat",
                value = tg_xuat.ToString()
            });

            var rs = new Database().ExeCute(sql, list);
            if (rs == 1)
            {
                MessageBox.Show("Xóa phiếu xuất thành công!");
                return true;
            }
            else
            {
                MessageBox.Show("Xóa phiếu xuất thất bại!");
                return false;
            }
        }
        public DataTable dataNKhoNVLbyTime(DateTime sTime, DateTime eTime)
        {
            string sql = "selectNKhoNVLbyTime";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@sTime",
                value = sTime.ToString()
            });
            list.Add(new CustomParameter()
            {
                key = "@eTime",
                value = eTime.ToString()
            });
            DataTable dt = new Database().SelectData(sql, list);
            return dt;
        }
        public DataTable dataXKhoNVLbyTime(DateTime sTime, DateTime eTime)
        {
            string sql = "selectXKhoNVLbyTime";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@sTime",
                value = sTime.ToString()
            });
            list.Add(new CustomParameter()
            {
                key = "@eTime",
                value = eTime.ToString()
            });
            DataTable dt = new Database().SelectData(sql, list);
            return dt;
        }
        public int getSLTonNVL(string maNVL)
        {

            string sql = "SelectSLTonNVL";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@MaNVL",
                value = maNVL
            });
            DataTable dt = new Database().SelectData(sql, list);

            var slTon = dt.Rows[0]["SL_Ton"];
            return Convert.ToInt32(slTon);
        }
    }
}
