using BanGiay_N11.model;
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

namespace wfLeedo.view
{
    public partial class fThemSP : Form
    {
        string maSP;
        private string imgPath;
        public fThemSP(string maSP)
        {
            InitializeComponent();
            this.maSP = maSP;
        }

        private void fThemSP_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maSP))
            {
                this.Text = "Thêm mới sản phẩm";
                saveBtn.Enabled = false;
            }
            else
            {
                this.Text = "Sửa thông tin sản phẩm";
                insertBtn.Enabled = false;
                productViewModel dataPro = new productViewModel();
                Product newPro = dataPro.dataProduct(maSP);
                showData(newPro);
            }
        }
        private void showData(Product newPro)
        {
            txtMaSP.Text = newPro.Id;
            txtLoaiSP.Text = newPro.Type;
            txtTenSP.Text = newPro.Name;
            txtGiaSP.Text = newPro.Price.ToString();
            txtSizeSP.Text = newPro.Size.ToString();
            txtDonViTinh.Text = newPro.DonVi;
            //imgSP.Image = Image.FromFile(newPro.ImgSP);
            loadImg(newPro.ImgSP);
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSP.Text != "")
                {
                    productViewModel dataPro = new productViewModel();
                    Product newPro = new Product(txtMaSP.Text, txtLoaiSP.Text, txtTenSP.Text, double.Parse(txtGiaSP.Text), int.Parse(txtSizeSP.Text), txtDonViTinh.Text, imgPath);

                    if (dataPro.insertSP(newPro))
                    {
                        this.Close();
                    }

                }
            }
            catch (FormatException ex)
            {
                // Xử lý lỗi kiểu dữ liệu sai (ví dụ: nhập chuỗi không phải số vào salary)
                MessageBox.Show("Lỗi: Nhập liệu không hợp lệ. Vui lòng kiểm tra lại các thông tin nhập vào.");
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác có thể xảy ra
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void imgBtn_Click(object sender, EventArgs e)
        {
            productViewModel dataPro = new productViewModel();
            imgPath = dataPro.getImgPath();
            loadImg(imgPath);
        }
        private void loadImg(string imgPath)
        {
            if (imgPath != null)
            {
                //imgSP.Image = Image.FromFile(imgPath);
                //MessageBox.Show("Hiển thị hình ảnh thành công!");
            }
            else
            {
                imgSP.Image = null;
                MessageBox.Show("Không thể hiển thị hình ảnh!");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text != "")
            {
                var maSP = txtMaSP.Text;
                productViewModel dataPro = new productViewModel();
                Product product = dataPro.dataProduct(maSP);

                if (product != null)
                {
                    product.Id = txtMaSP.Text;
                    product.Type = txtLoaiSP.Text;
                    product.Name = txtTenSP.Text;
                    product.Price = double.Parse(txtGiaSP.Text);
                    product.Size = int.Parse(txtSizeSP.Text);
                    product.DonVi = txtDonViTinh.Text;
                    product.ImgSP = imgPath;
                    dataPro.updateSP(product);
                }
            }
        }
    }
}
