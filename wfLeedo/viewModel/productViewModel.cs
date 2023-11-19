using BanGiay_N11.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanGiay_N11.viewModel
{
    internal class productViewModel
    {
        public DataTable dataAllProduct()
        {
            string tukhoa = "";
            string sql = "SelectAllSanPhamWithTonKho";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            DataTable dt = new Database().SelectData(sql, list);
            return dt;
        }
        public DataTable dataAllProductLite()
        {
            string tukhoa = "";
            string sql = "SelectAllSanPham";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            DataTable dt = new Database().SelectData(sql, list);
            return dt;
        }
        public List<Product> GetAllProducts()
        {
            string tukhoa = "";
            string sql = "SelectAllSanPham";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            DataTable dt = new Database().SelectData(sql, list);

            // Tạo danh sách để lưu trữ các đối tượng Product
            List<Product> productList = new List<Product>();

            // Duyệt qua từng dòng trong DataTable
            foreach (DataRow row in dt.Rows)
            {
                string idPro = row["MaSP"].ToString();
                string type = row["LoaiSP"].ToString();
                string name = row["TenSP"].ToString();
                string price = row["GiaSP"].ToString();
                string size = row["SizeSP"].ToString();
                string donvi = row["Donvitinh"].ToString();
                string img = row["ImgSP"].ToString();

                // Tạo đối tượng Product và thêm vào danh sách
                Product productObject = new Product(idPro, type, name, double.Parse(price), int.Parse(size), donvi, img);
                productList.Add(productObject);
            }

            return productList;
        }

        public Product dataProduct(string id)
        {
            string maSP = id;
            var r = new Database().Select("SelectAllSanPham '" + maSP + "'");

            if (r != null)
            {
                string idPro = r["MaSP"].ToString();
                string type = r["LoaiSP"].ToString();
                string name = r["TenSP"].ToString();
                string price = r["GiaSP"].ToString();
                string size = r["SizeSP"].ToString();
                string donvi = r["Donvitinh"].ToString();
                string img = r["ImgSP"].ToString();

                Product productObject = new Product(idPro, type, name, double.Parse(price), int.Parse(size), donvi, img);

                return productObject;
            }

            // Trả về null hoặc thực hiện xử lý lỗi tùy thuộc vào yêu cầu của bạn
            return null;
        }

        public Boolean insertSP(Product product)
        {
            string sql = "insertSanPham";
            List<CustomParameter> list = new List<CustomParameter>();

            list.Add(new CustomParameter()
            {
                key = "@MaSP",
                value = product.Id
            });
            list.Add(new CustomParameter()
            {
                key = "@LoaiSP",
                value = product.Type
            });
            list.Add(new CustomParameter()
            {
                key = "@TenSP",
                value = product.Name
            });
            list.Add(new CustomParameter()
            {
                key = "@GiaSP",
                value = product.Price.ToString()
            });
            list.Add(new CustomParameter()
            {
                key = "@SizeSP",
                value = product.Size.ToString()
            });
            list.Add(new CustomParameter()
            {
                key = "@Donvitinh",
                value = product.DonVi
            });
            list.Add(new CustomParameter()
            {
                key = "@ImgSP",
                value = product.ImgSP
            }); ;
            var rs = new Database().ExeCute(sql, list);
            if (rs == 1)
            {
                MessageBox.Show("Thêm sản phẩm mới thành công!");
                return true;
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm mới thất bại!");
                return false;
            }
        }

        public void updateSP(Product product)
        {
            string sql = "updateSanPham";
            List<CustomParameter> list = new List<CustomParameter>();

            list.Add(new CustomParameter()
            {
                key = "@MaSP",
                value = product.Id
            });
            list.Add(new CustomParameter()
            {
                key = "@LoaiSP",
                value = product.Type
            });
            list.Add(new CustomParameter()
            {
                key = "@TenSP",
                value = product.Name
            });
            list.Add(new CustomParameter()
            {
                key = "@GiaSP",
                value = product.Price.ToString()
            });
            list.Add(new CustomParameter()
            {
                key = "@SizeSP",
                value = product.Size.ToString()
            });
            list.Add(new CustomParameter()
            {
                key = "@DonViTinh",
                value = product.DonVi
            });
            list.Add(new CustomParameter()
            {
                key = "@ImgSP",
                value = product.ImgSP
            });
            var rs = new Database().ExeCute(sql, list);
            if (rs == 1)
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thất bại!");
            }
        }

        public string getImgPath()
        {
            string imgPath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Hình ảnh (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgPath = openFileDialog.FileName;
                return imgPath;
            }
            return null;
        }


    }
}
