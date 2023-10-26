using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BanGiay_N11
{
    internal class person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Birth { get; set; }
        public string Sex { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }

        public person(string id, string name, string birth, string sex, string sdt, string email, string pwd)
        {
            Id = id;
            Name = name;
            Birth = birth;
            Sex = sex;
            Sdt = sdt;
            Email = email;
            Pwd = pwd;
        }
    }
}
