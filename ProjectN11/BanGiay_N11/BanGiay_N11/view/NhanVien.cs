using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanGiay_N11
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Tạo Pen với màu đỏ và độ rộng 2
            //Pen borderPen = new Pen(Color.White, 5);

            //// Vẽ đường viền bằng Pen đã tạo
            //g.DrawRectangle(borderPen, panel9.Location.X, panel9.Location.Y, panel9.Width - 1, panel9.Height - 1);

            //// Vẽ đường viền bằng Pen đã tạo
            //g.DrawRectangle(borderPen, pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Width -1, pictureBox2.Height -1);
            //// Giải phóng Pen sau khi sử dụng
            //borderPen.Dispose();
        }
    }
}
