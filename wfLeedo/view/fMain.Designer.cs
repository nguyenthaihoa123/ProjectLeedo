namespace wfLeedo
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            btnQuanLy = new FontAwesome.Sharp.IconButton();
            btnSanPham = new FontAwesome.Sharp.IconButton();
            btnDangXuat = new FontAwesome.Sharp.IconButton();
            btnDonHang = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pnMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(btnQuanLy);
            kryptonPanel1.Controls.Add(btnSanPham);
            kryptonPanel1.Controls.Add(btnDangXuat);
            kryptonPanel1.Controls.Add(btnDonHang);
            kryptonPanel1.Controls.Add(panel1);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(117, 753);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(51, 51, 51);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(51, 51, 51);
            kryptonPanel1.StateCommon.ColorAngle = 90F;
            kryptonPanel1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonPanel1.TabIndex = 0;
            // 
            // btnQuanLy
            // 
            btnQuanLy.BackColor = Color.Transparent;
            btnQuanLy.Dock = DockStyle.Top;
            btnQuanLy.FlatAppearance.BorderSize = 0;
            btnQuanLy.FlatStyle = FlatStyle.Flat;
            btnQuanLy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuanLy.ForeColor = Color.LightGray;
            btnQuanLy.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            btnQuanLy.IconColor = Color.LightGray;
            btnQuanLy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuanLy.Location = new Point(0, 349);
            btnQuanLy.Name = "btnQuanLy";
            btnQuanLy.Size = new Size(117, 93);
            btnQuanLy.TabIndex = 8;
            btnQuanLy.Text = "Quản lý";
            btnQuanLy.TextImageRelation = TextImageRelation.ImageAboveText;
            btnQuanLy.UseVisualStyleBackColor = false;
            btnQuanLy.Click += btnQuanLy_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.Transparent;
            btnSanPham.Dock = DockStyle.Top;
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSanPham.ForeColor = Color.LightGray;
            btnSanPham.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            btnSanPham.IconColor = Color.LightGray;
            btnSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSanPham.Location = new Point(0, 256);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(117, 93);
            btnSanPham.TabIndex = 7;
            btnSanPham.Text = "Sản phẩm";
            btnSanPham.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Transparent;
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangXuat.ForeColor = Color.FromArgb(51, 51, 51);
            btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            btnDangXuat.IconColor = Color.FromArgb(51, 51, 51);
            btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDangXuat.Location = new Point(0, 677);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Rotation = 180D;
            btnDangXuat.Size = new Size(117, 76);
            btnDangXuat.TabIndex = 6;
            btnDangXuat.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // btnDonHang
            // 
            btnDonHang.BackColor = Color.Transparent;
            btnDonHang.Dock = DockStyle.Top;
            btnDonHang.FlatAppearance.BorderSize = 0;
            btnDonHang.FlatStyle = FlatStyle.Flat;
            btnDonHang.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDonHang.ForeColor = Color.LightGray;
            btnDonHang.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            btnDonHang.IconColor = Color.LightGray;
            btnDonHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDonHang.Location = new Point(0, 163);
            btnDonHang.Name = "btnDonHang";
            btnDonHang.Size = new Size(117, 93);
            btnDonHang.TabIndex = 4;
            btnDonHang.Text = "Đơn hàng";
            btnDonHang.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDonHang.UseVisualStyleBackColor = false;
            btnDonHang.Click += btnDonHang_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(117, 163);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.remove_bg;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.FromArgb(244, 244, 255);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(117, 0);
            pnMain.Name = "pnMain";
            pnMain.Padding = new Padding(0, 0, 0, 15);
            pnMain.Size = new Size(1165, 753);
            pnMain.TabIndex = 1;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 244, 255);
            ClientSize = new Size(1282, 753);
            Controls.Add(pnMain);
            Controls.Add(kryptonPanel1);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            Load += fMain_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnDonHang;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private Panel pnMain;
        private FontAwesome.Sharp.IconButton btnQuanLy;
        private FontAwesome.Sharp.IconButton btnSanPham;
    }
}