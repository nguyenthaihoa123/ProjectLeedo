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
            DialogResult = DialogResult.OK;
            Close();
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

    }

}
