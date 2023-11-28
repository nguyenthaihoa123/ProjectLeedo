using BanGiay_N11.model;
using BanGiay_N11.viewModel;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfLeedo.view
{
    public partial class fSanPham : Form
    {
        public fSanPham()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void fSanPham_Load(object sender, EventArgs e)
        {
            this.Text = "Danh mục Sản Phẩm";
            productViewModel model = new productViewModel();
            List<Product> list = model.GetAllProducts();
            foreach (Product productItem in list)
            {
                // Tạo một UserControl Product
                uc_product productControl = new uc_product();

                // Đặt các thuộc tính của UserControl từ dữ liệu sản phẩm
                productControl.PanelBackgroundImagePath = productItem.ImgSP;
                productControl.price = productItem.Price.ToString() + " VNĐ";
                productControl.name = productItem.Name;
                productControl.id = productItem.Id;

                // Thêm UserControl vào Panel
                panelShowProduct.Controls.Add(productControl);
            }

        }

        private void panelShowProduct_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelShowProduct_Scroll(object sender, ScrollEventArgs e)
        {
            panelShowProduct.AutoScroll = true;

            panelShowProduct.VerticalScroll.Value = e.NewValue;
        }
    }
}
