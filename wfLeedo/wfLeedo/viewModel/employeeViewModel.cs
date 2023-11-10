using BanGiay_N11.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanGiay_N11.viewModel
{
    internal class employeeViewModel
    {
        public DataTable dataAllEmploy(string key)
        {
            string tukhoa = key;
            string sql = "selectAllNV";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            DataTable dt = new Database().SelectData(sql, list);
            return dt;
        }
        public employee dataEmployee(string id)
        {
            string mKH = id;
            var r = new Database().Select("selectAllNV '" + mKH + "'");

            if (r != null)
            {
                string idEmp = r["MaNV"].ToString();
                string name = r["HotenNV"].ToString();
                string Cccd = r["CCCD"].ToString();
                string number = r["SDT"].ToString();
                string sex = r["GT"].ToString();
                string birth = r["NgSinh"].ToString();
                string depart = r["PhongBan"].ToString();
                string bank = r["TKBank"].ToString();
                string email = r["Email"].ToString();
                string level = r["ChucVu"].ToString();
                double salary = double.Parse(r["Luong"].ToString()) ;
                string img = r["Img_NV"].ToString();
                string pwd = r["MatKhau"].ToString();

                employee empObject = new employee(idEmp, name, birth, sex, number, email, pwd, Cccd, depart, bank, level, salary, img);

                return empObject;
            }

            // Trả về null hoặc thực hiện xử lý lỗi tùy thuộc vào yêu cầu của bạn
            return null;
        }
        public Boolean updateNhanVien(employee emp)
        {
            string sql = "";
            List<CustomParameter> list = new List<CustomParameter>();
            
            sql = "updateNhanVien";
            list.Add(new CustomParameter()
            {
                key = "@MaNV",
                value = emp.Id
            });
            list.Add(new CustomParameter()
            {
                key = "@HotenNV",
                value = emp.Name
            });
            list.Add(new CustomParameter()
            {
                key = "@CCCD",
                value = emp.CCCD
            });
            list.Add(new CustomParameter()
            {
                key = "@SDT",
                value = emp.Sdt
            });
            list.Add(new CustomParameter()
            {
                key = "@GT",
                value = emp.Sex
            });
            list.Add(new CustomParameter()
            {
                key = "@NgSinh",
                value = emp.Birth
            });
            list.Add(new CustomParameter()
            {
                key = "@PhongBan",
                value = emp.Dept
            });
            list.Add(new CustomParameter()
            {
                key = "@TKBank",
                value = emp.TKBank
            });
            list.Add(new CustomParameter()
            {
                key = "@Email",
                value = emp.Email
            });
            list.Add(new CustomParameter()
            {
                key = "@ChucVu",
                value = emp.ChucVu
            });
            list.Add(new CustomParameter()
            {
                key = "@Luong",
                value = emp.Salary.ToString()
            });
            list.Add(new CustomParameter()
            {
                key = "@Img_NV",
                value = emp.ImgNV
            });
            list.Add(new CustomParameter()
            {
                key = "@MatKhau",
                value = emp.Pwd
            });
            var rs = new Database().ExeCute(sql, list);
            if (rs == 2)
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                return true;
            }
            else
            {
                MessageBox.Show("Thực thi truy vấn thất bại "+rs);
                return false;
            }
        }
        public Boolean insertEmployee(employee emp)
        {
            string sql = "";
            List<CustomParameter> list = new List<CustomParameter>();
            
            sql = "insertNhanVien";
            list.Add(new CustomParameter()
            {
                key = "@HotenNV",
                value = emp.Name
            });
            list.Add(new CustomParameter()
            {
                key = "@CCCD",
                value = emp.CCCD
            });
            list.Add(new CustomParameter()
            {
                key = "@SDT",
                value = emp.Sdt
            });
            list.Add(new CustomParameter()
            {
                key = "@GT",
                value = emp.Sex
            });
            list.Add(new CustomParameter()
            {
                key = "@NgSinh",
                value = emp.Birth
            });
            list.Add(new CustomParameter()
            {
                key = "@PhongBan",
                value = emp.Dept
            });
            list.Add(new CustomParameter()
            {
                key = "@TKBank",
                value = emp.TKBank
            });
            list.Add(new CustomParameter()
            {
                key = "@Email",
                value = emp.Email
            });
            list.Add(new CustomParameter()
            {
                key = "@ChucVu",
                value = emp.ChucVu
            });
            list.Add(new CustomParameter()
            {
                key = "@Luong",
                value = emp.Salary.ToString()
            });
            list.Add(new CustomParameter()
            {
                key = "@Img_NV",
                value = emp.ImgNV
            });
            list.Add(new CustomParameter()
            {
                key = "@MatKhau",
                value = emp.Pwd
            });
            var rs = new Database().ExeCute(sql, list);
            if (rs == 1)
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
                return true;
            }
            else
            {
                MessageBox.Show("Thực thi truy vấn thất bại");
                return false;
            }
        }

    }
}
