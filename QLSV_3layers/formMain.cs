using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3layers
{
    public partial class formMain : System.Windows.Forms.Form
    {
        public formMain()
        {
            InitializeComponent();
        }
        private string taikhoan;
        private string loaitk;
        private void formMain_Load_1(object sender, EventArgs e)
        {
            var fn = new frmDangnhap();
            fn.ShowDialog();

            taikhoan = fn.tendangnhap;
            loaitk = fn.loaitk;
            if (loaitk.Equals("admin"))
            {
                quanLyLopToolStripMenuItem.Visible = false;
                chucNangToolStripMenuItem.Visible = false;
            }
            else
            {
                quanLyToolStripMenuItem.Visible = false;
                if (loaitk.Equals("gv"))
                {
                    chucNangToolStripMenuItem.Visible = false;
                }
                else
                {
                    quanLyLopToolStripMenuItem.Visible = false;
                }
            }

            frmWelcome f = new frmWelcome();
            AddForm(f);
        }
        private void AddForm(Form f)
        {
            this.panel1.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.panel1.Controls.Add(f);
            f.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSGV g = new frmDSGV();
            AddForm(g);
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDSSV g = new formDSSV();
            AddForm(g);
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDsMHDaDky g = new frmDsMHDaDky();
            AddForm(g);
        }

        private void diemThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSLopHoc g = new frmDSLopHoc();
            AddForm(g);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

  

        private void welcomeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmWelcome frm = new frmWelcome();
            AddForm(frm);
        }

        private void dangkyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void chamDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmQuanLyLop(taikhoan);
            AddForm(f);
        }

        private void traCuuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f =new frmKetQuaHocTap(taikhoan);
            AddForm(f);
        }

        private void dangKyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var f = new frmDSMHDky(taikhoan);
            AddForm(f);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
