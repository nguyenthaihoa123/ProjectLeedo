using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanGiay_N11.viewModel
{
    internal class loginViewModel
    {
        public bool loginCheck(String username, String pwd)
        {
            List<CustomParameter> lst = new List<CustomParameter>() {
                new CustomParameter()
                {
                    key = "@taikhoan",
                    value = username
                },
                new CustomParameter()
                {
                    key = "@matkhau",
                    value = pwd
                },
            };
            var rs = new Database().SelectData("dangnhap", lst);

            if (rs.Rows.Count > 0)
            {
                return true;
                //new formMain().ShowDialog();
            }
            else
            {
                return false;
            }
        }
    }
}
