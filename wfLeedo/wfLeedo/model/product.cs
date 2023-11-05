using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanGiay_N11.model
{
    public class Product
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }
        public string DonVi { get; set; }
        public string ImgSP { get; set; }

        public Product(string id, string type, string name, double price, int size, string donvi, string imgSP)
        {
            Id = id;
            Type = type;
            Name = name;
            Price = price;
            Size = size;
            DonVi = donvi;
            ImgSP = imgSP;
        }
    }
}
