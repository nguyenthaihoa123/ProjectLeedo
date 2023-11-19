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
    public partial class uc_product : UserControl
    {
        public uc_product()
        {
            InitializeComponent();
        }
        // Thuộc tính cho BackgroundImage của Panel
        
        
        public string PanelBackgroundImagePath
        {
            get { return null; } // Trả về null vì bạn không muốn đọc đường dẫn từ UserControl
            set
            {
                // Kiểm tra xem đường dẫn hình ảnh có giá trị không rỗng
                if (!string.IsNullOrEmpty(value))
                {
                    // Tạo một đối tượng Image từ đường dẫn và đặt làm BackgroundImage cho UserControl
                    imgProShow.Image = Image.FromFile(value);
                    panelItem.BackgroundImage = Properties.Resources.shoes1;
                }
                else
                {
                    // Nếu đường dẫn rỗng, bạn có thể đặt hình ảnh mặc định hoặc xử lý khác tùy thuộc vào yêu cầu của bạn.
                    imgProShow.Image = Image.FromFile("AnhSanPham/yay2.jpg");
                    panelItem.BackgroundImage = Properties.Resources.shoes1; // Đặt làm null hoặc hình ảnh mặc định khác.
                }
            }
        }

        // Thuộc tính cho Text của TextBox1
        public string price
        {
            get { return txtPriceShow.Text; }
            set
            {
                txtPriceShow.Text = value;
            }
        }

        // Thuộc tính cho Text của TextBox2
        public string name
        {
            get { return txtNameShow.Text; }
            set
            {
                txtNameShow.Text = value;
                txtNameShow.Font = new Font(txtNameShow.Font, FontStyle.Bold);

            }
        }
        public string id
        {
            get { return txtIDShow.Text; }
            set
            {
                txtIDShow.Text = value;
                txtIDShow.Font = new Font(txtIDShow.Font, FontStyle.Bold);

            }
        }
    }
}
