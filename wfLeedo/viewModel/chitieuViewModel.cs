using BanGiay_N11;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfLeedo.viewModel
{
    internal class chitieuViewModel
    {
        public DataTable dataChiTieuNam(String year)
        {
            String tukhoa = year;
            String sql = "TinhChiTieu";

            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@nam",
                value = tukhoa
            });
            DataTable dt = new Database().SelectData(sql, list);
            return dt;
        }
        public DataTable dataChiTieuNgay(String year, String month)
        {

            String sql = "TinhChiTieuTheoNgay";

            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@thang",
                value = month
            });
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
