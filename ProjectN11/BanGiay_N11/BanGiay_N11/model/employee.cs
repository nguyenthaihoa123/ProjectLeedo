using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanGiay_N11
{
    internal class employee : person
    {
        public string CCCD { get; set; }
        public string Dept { get; set; }
        public string TKBank { get; set; }
        public string ChucVu { get; set; }
        public double Salary { get; set; }
        public string ImgNV { get; set; }

        public employee(string id, string name, string birth, string sex, string sdt, string email, string pwd, string cccd, string dept, string tkBank, string chucvu, double salary, string imgNV) : base(id, name, birth, sex, sdt, email, pwd)
        {
            CCCD = cccd;
            Dept = dept;
            TKBank = tkBank;
            ChucVu = chucvu;
            Salary = salary;
            ImgNV = imgNV;
        }
        /*employee emp = new employee(...);
        string cccdValue = emp.CCCD; // Lấy giá trị CCCD
        emp.Salary = 50000; // Đặt giá trị Salary*/
    }
}
