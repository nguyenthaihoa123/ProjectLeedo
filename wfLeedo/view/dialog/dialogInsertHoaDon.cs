using BanGiay_N11;
using BanGiay_N11.viewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfLeedo.view.dialog
{
    public partial class dialogInsertHoaDon : Form
    {
        public dialogInsertHoaDon()
        {
            InitializeComponent();
        }

        private void dialogInsertHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertWithCus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputText))
            {
                MessageBox.Show("Vui lòng nhập lại số điện thoại khách hàng! Hoặc chọn chức năng khách hàng vãng lai!");
            }
            else
            {
                if (checkInput(InputText))
                {
                    var r = new Database().Select("checkSDTKhach '" + InputText + "'");
                    if (r != null)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        txtInsertSdtHD.Text = "";
                        txtInsertSdtHD.Focus();
                        MessageBox.Show("Khách hàng không tồn tại! Vui lòng kiểm tra lại số điện thoại!");
                    }
                }
            }
        }

        private void btnInsertVangLai_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        public string InputText
        {
            get { return txtInsertSdtHD.Text; }
        }

        private Boolean checkInput(string input)
        {
            if (input.Length != 10 || !int.TryParse(input, out _))
            {
                txtInsertSdtHD.Text = "";
                txtInsertSdtHD.Focus();
                MessageBox.Show("Số điện thoại nhập vào không phù hợp! Vui lòng nhập lại!");
                return false;
            }
            return true;
        }
    }

}
