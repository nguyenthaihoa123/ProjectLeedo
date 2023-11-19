using BanGiay_N11;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfLeedo.viewModel
{
    internal class doanhthuViewModel
    {
        public DataTable dataDoanhThuNam(String year)
        {
            String tukhoa = year;
            String sql = "TinhDoanhThu" ;

            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@nam",
                value = tukhoa
            });
            DataTable dt = new Database().SelectData(sql, list);
            return dt;
        }
        public DataTable dataDoanhThuNgay(String year, String month)
        {

            String sql = "TinhDoanhThuTheoNgay";

            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@thang",
                value = month
            }) ; 
            list.Add(new CustomParameter()
            {
                key = "@nam",
                value = year
            });
            DataTable dt = new Database().SelectData(sql, list);
            return dt;
        }
    }
}
