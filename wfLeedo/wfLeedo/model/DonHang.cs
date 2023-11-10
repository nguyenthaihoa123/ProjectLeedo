using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfLeedo.model
{
    internal class DonHang
    {
        public string ID { get; set; }
        public string MaKH { get; set; }

        public string TG_create { get; set; }
        public DonHang(string idDH, string idKH, string time)
        {
            ID = idDH;
            MaKH = idKH;
            TG_create = time;
        }
    }
}
