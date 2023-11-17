using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfLeedo.viewModel;

namespace wfLeedo.view
{
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
        }

        private void fThongKe_Load(object sender, EventArgs e)
        {
            moneyViewModel hehe = new moneyViewModel();
            dgvthongke.DataSource = hehe.dataChiTieu("");
        }
    }
}
