using BanGiay_N11;
using BanGiay_N11.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfLeedo.model;

namespace wfLeedo.viewModel
{
    internal class DonHangViewModel
    {
        public DataTable dataAllDonHang(string tukhoa)
        {
            string sql = "SelectDonHangByKeyword";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            DataTable dt = new Database().SelectData(sql, list);
            return dt;
        }
        public DonHang dataDonHang(string id)
        {
            string mDH = id;
            var r = new Database().Select("SelectDonHangByKeyword '" + mDH + "'");

            if (r != null)
            {
                string idDH = r["MaDH"].ToString();
                string idKH = r["MaKH"].ToString();
                string time = r["TG_lapBill"].ToString();
                
                DonHang DH = new DonHang(idDH, idKH, time);

                return DH;
            }

            // Trả về null hoặc thực hiện xử lý lỗi tùy thuộc vào yêu cầu của bạn
            return null;
        }
        public DonHang dataDonHangLastest()
        {
            var r = new Database().Select("GetLatestBill ");

            if (r != null)
            {
                string idDH = r["MaDH"].ToString();
                string idKH = r["MaKH"].ToString();
                string time = r["TG_lapBill"].ToString();

                DonHang DH = new DonHang(idDH, idKH, time);

                return DH;
            }

            // Trả về null hoặc thực hiện xử lý lỗi tùy thuộc vào yêu cầu của bạn
            return null;
        }
        public Boolean insertDonHang(string sdt)
        {
            if(sdt != "")
            {
                string sql = "";
                List<CustomParameter> list = new List<CustomParameter>();
                sql = "insertDonHang";

                list.Add(new CustomParameter()
                {
                    key = "@SDT",
                    value = sdt
                });
                var rs = new Database().ExeCute(sql, list);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm đơn hàng thành công!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Thực thi truy vấn thất bại");
                    return false;
                }
            }
            else {
                string sql = "";
                List<CustomParameter> list = new List<CustomParameter>();
                sql = "insertDonHangVangLai";

                
                var rs = new Database().ExeCute(sql, list);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm đơn hàng thành công!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Thực thi truy vấn thất bại");
                    return false;
                }
            }
            
        }
        public Product selectPro(string ID)
        {
            string mSP = ID;
            var r = new Database().Select("selectALlSanPham '" + mSP + "'");

            if (r != null)
            {
                string id = r["MaSP"].ToString();
                string name = r["TenSP"].ToString();
                string type = r["LoaiSP"].ToString();

                double price = double.Parse(r["GiaSP"].ToString());
                

                string sizeString = r["SizeSP"].ToString();
                int size;
                int.TryParse(sizeString, out size);

                string dv = r["DonViTinh"].ToString();
                string img = r["Img_Sp"].ToString();
                
                Product addPro = new Product(id, type, name, price, size,dv,img);

                return addPro;
            }

            // Trả về null hoặc thực hiện xử lý lỗi tùy thuộc vào yêu cầu của bạn
            return null;
        }
        public void InsertItemToBill(string id, string idSP, string SL)
        {
            if (id != "" && idSP != "")
            {
                string sql = "AddProductToOrder";
                List<CustomParameter> list = new List<CustomParameter>();

                list.Add(new CustomParameter()
                {
                    key = "@MaDH",
                    value = id
                });
                list.Add(new CustomParameter()
                {
                    key = "@MaSP",
                    value = idSP
                });
                list.Add(new CustomParameter()
                {
                    key = "@SoLuong",
                    value = SL
                });
                var rs = new Database().ExeCute(sql, list);
                if (rs == 2)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Thực thi truy vấn thất bại");
                }
            }
        }
        public DataTable dataDonHangChiTiet(string tukhoa)
        {
            string sql = "SelectDonHangDetail";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@MaDh",
                value = tukhoa
            });
            DataTable dt = new Database().SelectData(sql, list);
            return dt;
        }
    }
}
