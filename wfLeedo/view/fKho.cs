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

namespace wfLeedo
{
    public partial class fKho : Form
    {
        public fKho()
        {
            InitializeComponent();
        }

        private void fKho_Load(object sender, EventArgs e)
        {
            DonHangViewModel viewModel = new DonHangViewModel();
            test.DataSource = viewModel.dataAllDonHang("");
            test.AllowUserToAddRows = false;
        }
    }
}
