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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //NhanVien nv = new NhanVien();
            //this.panel10.Controls.Clear();
            //nv.TopLevel = false;
            //nv.AutoScroll = true;
            //nv.FormBorderStyle = FormBorderStyle.None;
            //nv.Dock = DockStyle.Fill;
            //this.Text = nv.Text;
            //this.panel10.Controls.Add(nv);
            //nv.Show();

            /*DonHang dh = new DonHang();
            this.panel10.Controls.Clear();
            dh.TopLevel = false;
            dh.AutoScroll = true;
            dh.FormBorderStyle = FormBorderStyle.None;
            dh.Dock = DockStyle.Fill;
            this.Text = dh.Text;
            this.panel10.Controls.Add(dh);
            dh.Show();*/

            /*
            KhachHang kh = new KhachHang();
            this.panel10.Controls.Clear();
            kh.TopLevel = false;
            kh.AutoScroll = true;
            kh.FormBorderStyle = FormBorderStyle.None;
            kh.Dock = DockStyle.Fill;
            this.Text = kh.Text;
            this.panel10.Controls.Add(kh);
            kh.Show();
           */

            /*
            Kho kh = new Kho();
            this.panel10.Controls.Clear();
            kh.TopLevel = false;
            kh.AutoScroll = true;
            kh.FormBorderStyle = FormBorderStyle.None;
            kh.Dock = DockStyle.Fill;
            this.Text = kh.Text;
            this.panel10.Controls.Add(kh);
            kh.Show();
            */

            KhachHang kh = new KhachHang();
            this.panel10.Controls.Clear();
            kh.TopLevel = false;
            kh.AutoScroll = true;
            kh.FormBorderStyle = FormBorderStyle.None;
            kh.Dock = DockStyle.Fill;
            this.Text = kh.Text;
            this.panel10.Controls.Add(kh);
            kh.Show();
        }

        private void btn_donhang_Click(object sender, EventArgs e)
        {

        }

        private void btn_Nhanvien_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {



        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            // Lấy đối tượng Graphics để vẽ

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
