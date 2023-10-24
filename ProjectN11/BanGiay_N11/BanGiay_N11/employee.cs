﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanGiay_N11
{
    internal class employee : person
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


        public employee(string EmpId, string name, string birth, string sex, string sdt, string email, string pwd, string cccd, string dept, string tkBank, string chucvu, double salary, string imgNV) : base(name, birth, sex, sdt) { 
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
        public string getCCCD() {  return cccd; }
        public string getDept() {  return dept; }
        public string getBank() { return tkBank;}
        public string getChucvu() {  return chucvu; }
        public double getSalary() {  return salary; }
        public string getImgNV() {  return imgNV;}
        // phuong thuc set
        public void setCCCD(string cccd) {  this.cccd = cccd; }
        public void setDept(string dept) {  this.dept = dept; }
        public void setTKBank(string tkBank) { this.tkBank = tkBank; }
        public void setChucvu(string chucvu) { this.chucvu = chucvu; }
        public void setSalary(double salary) { this.salary = salary; }
        public void setImgNV(string imgNV) {  this.imgNV = imgNV; }
    }
}
