using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanGiay_N11
{
    internal class Employee : Person
    {
        private string EmpId;
        private string cccd;
        private string dept;
        private string email;
        private string tkBank;
        private string chucvu;
        private double salary;
        private string pwd;
        private string imgNV;


        public Employee(string EmpId, string name, string birth, string sex, string sdt, string email, string pwd, string cccd, string dept, string tkBank, string chucvu, double salary, string imgNV) : base(name, birth, sex, sdt) { 
            this.EmpId = EmpId;
            this.cccd = cccd;
            this.dept = dept;
            this.email = email;
            this.tkBank = tkBank;
            this.chucvu = chucvu;
            this.salary = salary;
            this.pwd = pwd;
            this.imgNV = imgNV;
        }
        // phuong thuc get
        public string GetEmpId() { return this.EmpId; }
        public string GetCCCD() {  return this.cccd; }
        public string GetDept() {  return this.dept; }
        public string GetEmail() { return this.email; }
        public string GetBank() { return this.tkBank; }
        public string GetChucvu() {  return this.chucvu; }
        public double GetSalary() {  return this.salary; }
        public string GetPwd() { return this.pwd; }
        public string GetImgNV() {  return this.imgNV; }
        // phuong thuc set
        public void SetEmpId(string empId) {  this.EmpId = empId; }
        public void SetCCCD(string cccd) {  this.cccd = cccd; }
        public void SetDept(string dept) {  this.dept = dept; }
        public void SetEmail(string email) {  this.email = email; }
        public void SetTKBank(string tkBank) { this.tkBank = tkBank; }
        public void SetChucvu(string chucvu) { this.chucvu = chucvu; }
        public void SetSalary(double salary) { this.salary = salary; }
        public void SetPwd(string pwd) {  this.pwd = pwd; }
        public void SetImgNV(string imgNV) {  this.imgNV = imgNV; }
    }
}
