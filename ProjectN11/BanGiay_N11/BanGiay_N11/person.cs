using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanGiay_N11
{
    internal class person
    {
        protected string id;
        protected string name;
        protected string birth;
        protected string sex;
        protected string sdt;
        protected string email;
        protected string pwd;

        public person(string id, string name, string birth, string sex, string sdt, string email, string pwd) {
            this.id = id;
            this.name = name;
            this.birth = birth;
            this.sex = sex;
            this.sdt = sdt;
            this.email = email;
            this.pwd = pwd;
        }
        // phuong thuc get
        public string getId() { return id; }
        public string getName() { return name; }
        public string getBirth() { return birth;}
        public string getSex() {  return sex;}
        public string getSdt() { return sdt;}
        public string getEmail() { return email;}
        public string getPwd() { return pwd;}
        // phuong thuc set
        public void setID(string id) { this.id = id;}
        public void setName(string name) { this.name = name;}
        public void setBirth(string birth) {  this.birth = birth;}
        public void setSex(string sex) {  this.sex = sex;}
        public void setSdt(string sdt) {  this.sdt = sdt;}
        public void setEmail(string email) {  this.email = email;}
        public void setPwd(string pwd) {  this.pwd = pwd;}
    }
}
