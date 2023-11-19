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
        public DataTable dataAllDonHangByRangeTime(string start, string end)
        {
            string sql = "GetOrdersByTimeRange";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@StartTime",
                value = start
            });
            list.Add(new CustomParameter()
            {
                key = "@EndTime",
                value = end
            });
            DataTable dt = new Database().SelectData(sql, list);
            return dt;
        }
        public DonHang dataDonHang(string id)
        {
            string mDH = id;
            var r = new Database().Select("SelectDonHangLite '" + mDH + "'");

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
        public double getTotalBill(string id)
        {
            string mDH = id;
            var r = new Database().Select("SelectDonHangByKeyword '" + mDH + "'");

            if (r != null)
            {
                double total = double.Parse(r["TongBill"].ToString());
                return total;
            }

            // Trả về null hoặc thực hiện xử lý lỗi tùy thuộc vào yêu cầu của bạn
            return 0;
        }
        public DonHang dataDonHangLastest()
        {
            var r = new Database().Select("GetLatestBill ");

            if (r != null)
            {
                DonHang DH;
                if (r["MaKH"].ToString() == "")
                {
                    string idDH = r["MaDH"].ToString();
                    string time = r["TG_lapBill"].ToString();

                    DH = new DonHang(idDH, "", time);
                }
                else
                {
                    string idDH = r["MaDH"].ToString();
                    string idKH = r["MaKH"].ToString();
                    string time = r["TG_lapBill"].ToString();

                    DH = new DonHang(idDH, idKH, time);
                }
                

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
                string img = r["ImgSP"].ToString();
                
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
        public int getSanPhamTonKho(string tukhoa)
        {
            string mSP = tukhoa;
            var r = new Database().Select("GetSanPhamTonKho '" + mSP + "'");

            if (r != null)
            {
                double total = double.Parse(r["SoLuongTonKho"].ToString());
                int totalInt = (int)total; // Chuyển đổi từ double sang int
                return totalInt;
            }

            // Trả về null hoặc thực hiện xử lý lỗi tùy thuộc vào yêu cầu của bạn
            return 0;
        }
        public bool checkSoLuong(int hand, int data)
        {
            if (hand <= data)
            {
                return true;
            }
            return false;
        }
        public bool deleteItemBill(string idDH, string idSP)
        {

            string sql = "";
            List<CustomParameter> list = new List<CustomParameter>();
            sql = "DeleteProductFromOrder";

            list.Add(new CustomParameter()
            {
                key = "@MaDH",
                value = idDH
            });
            list.Add(new CustomParameter()
            {
                key = "@MaSP",
                value = idSP
            });
            var rs = new Database().ExeCute(sql, list);
            if (rs >= 1)
            {
                MessageBox.Show("Xóa sản phẩm thành công!");
                return true;
            }
            else
            {
                MessageBox.Show("Thực thi truy vấn thất bại");
                return false;
            }

        }
        public void insertDataToKhoSP(string idSP, string sl)
        {
            string sql = "";
            List<CustomParameter> list = new List<CustomParameter>();
            sql = "AddSanPhamXuatKho";
            list.Add(new CustomParameter()
            {
                key = "@MaKho",
                value = "KTB02"
            });
            list.Add(new CustomParameter()
            {
                key = "@MaSP",
                value = idSP
            });
            list.Add(new CustomParameter()
            {
                key = "@SoLuongXuat",
                value = sl
            });
            var rs = new Database().ExeCute(sql, list);
            
        } 
        public bool deleteBill(string id)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa Đơn hàng: " + id.Trim() + " ?", "Xác nhận xóa!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Thực hiện xóa đơn hàng
                string sql = "DeleteDonHang";
                List<CustomParameter> list = new List<CustomParameter>();
                list.Add(new CustomParameter()
                {
                    key = "@MaDH",
                    value = id
                });

                var rs = new Database().ExeCute(sql, list);

                if (rs >= 1)
                {
                    MessageBox.Show("Xóa đơn hàng thành công!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Thực thi truy vấn thất bại");
                    return false;
                }
            }

            // Người dùng đã chọn "No" trong hộp thoại xác nhận
            return false;
        }
        public bool updateDonHang(string id, string status)
        {
            string sql = "";
            List<CustomParameter> list = new List<CustomParameter>();
            sql = "UpdateDonHangStatus";

            list.Add(new CustomParameter()
            {
                key = "@MaDH",
                value = id
            });
            list.Add(new CustomParameter()
            {
                key = "@NewStatus",
                value = status
            });
            var rs = new Database().ExeCute(sql, list);
            if (rs >= 1)
            {
                MessageBox.Show("Cập nhật đơn hàng thành công!");
                return true;
            }
            else
            {
                MessageBox.Show("Thực thi truy vấn thất bại");
                return false;
            }
        }
        public double BillApplyVoucher(string voucher, double bill)
        {
            double discount = 0;

            switch (voucher)
            {
                case "Siêu sale":
                    // Giảm giá 10% cho VoucherA
                    discount = bill * 0.10;
                    break;
                case "Mua lần đầu":
                    // Giảm giá 10% cho VoucherA
                    discount = bill * 0.20;
                    break;
            }

            // Trả về tổng số tiền đã giảm giá
            return discount;
        }

    }
}
