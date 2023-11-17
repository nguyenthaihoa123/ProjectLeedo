using BanGiay_N11;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfLeedo.viewModel
{
    internal class moneyViewModel
    {
        public DataTable dataChiTieu(string tukhoa)
        {
            tukhoa = "2023";
            string sql = "TinhChiTieu";
            List<CustomParameter> list = new List<CustomParameter>();
            list.Add(new CustomParameter()
            {
                key = "@Nam",
                value = tukhoa
            });
            DataTable dt = new Database().SelectData(sql, list);
            return dt;
        }
    }
}
