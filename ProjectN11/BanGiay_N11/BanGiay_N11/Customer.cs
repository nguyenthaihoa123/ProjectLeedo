using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanGiay_N11
{
    internal class Customer : Person
    {
        private string CusId;
        private string email;
        private string voucher;
        private string address;
        private int point;
        public Customer(string CusId, string name, string birth, string sex, string sdt, string email, string voucher, string address, int point) : base(name, birth, sex, sdt)
        {
            this.CusId = CusId;
            this.email = email;
            this.voucher = voucher;
            this.address = address;
            this.point = point;
        }
        //phương thức get
        public string SetCusId() {  return this.CusId; }
        public string SetEmail() { return this.email; }
        public string SetVoucher() {  return this.voucher; }
        public string SetAddress() { return this.address; }
        public int SetPoint() { return this.point; }
        //phương thức set
        public void SetCusID(string CusId) {  this.CusId = CusId; }
        public void SetEmail(string email) {  this.email = email; }
        public void SetVoucher(string voucher) { this.voucher = voucher; }
        public void SetAddress(string address) {  this.address = address; }
        public void SetPoint(int point) {  this.point = point; }
    }
}
