using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanGiay_N11.model
{
    internal class customer : person
    {
        public int TichDiem { get; set; }
        public string Voucher { get; set; }
        
        public string DiaChi { get; set; }

        public customer(string id, string name, string birth, string sex, string sdt, string email,string diachi, string pwd, int diem, string voucher) : base(id, name, birth, sex, sdt, email, pwd)
        {
            TichDiem = diem;
            Voucher = voucher;
            DiaChi = diachi;
        }
        /*employee emp = new employee(...);
        string cccdValue = emp.CCCD; // Lấy giá trị CCCD
        emp.Salary = 50000; // Đặt giá trị Salary*/
    }
}
