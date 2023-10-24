using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanGiay_N11.model
{
    public class NguyenVatLieu
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string DonVi { get; set; }

        public NguyenVatLieu(string id, string type, string name, double price, string donvi)
        {
            Id = id;
            Type = type;
            Name = name;
            Price = price;
            DonVi = donvi;
        }
    }
}
