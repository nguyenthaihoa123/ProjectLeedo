using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanGiay_N11
{
    internal class Person
    {
        protected string name;
        protected string birth;
        protected string sex;
        protected string sdt;

        public Person(string name, string birth, string sex, string sdt) {
            this.name = name;
            this.birth = birth;
            this.sex = sex;
            this.sdt = sdt;
        }
        // phuong thuc get
        public string GetName() { return name; }
        public string GetBirth() { return birth;}
        public string GetSex() {  return sex;}
        public string GetSdt() { return sdt;}
        // phuong thuc set
        public void SetName(string name) { this.name = name;}
        public void SetBirth(string birth) {  this.birth = birth;}
        public void SetSex(string sex) {  this.sex = sex;}
        public void SetSdt(string sdt) {  this.sdt = sdt;}
    }
}
