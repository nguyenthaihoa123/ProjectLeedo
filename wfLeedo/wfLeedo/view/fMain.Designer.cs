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
            btnDangXuat = new FontAwesome.Sharp.IconButton();
            btnKhachHang = new FontAwesome.Sharp.IconButton();
            btnDonHang = new FontAwesome.Sharp.IconButton();
            btnDoanhThu = new FontAwesome.Sharp.IconButton();
            btnKho = new FontAwesome.Sharp.IconButton();
            btnNhanVien = new FontAwesome.Sharp.IconButton();
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
            kryptonPanel1.Controls.Add(btnDangXuat);
            kryptonPanel1.Controls.Add(btnKhachHang);
            kryptonPanel1.Controls.Add(btnDonHang);
            kryptonPanel1.Controls.Add(btnDoanhThu);
            kryptonPanel1.Controls.Add(btnKho);
            kryptonPanel1.Controls.Add(btnNhanVien);
            kryptonPanel1.Controls.Add(panel1);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Margin = new Padding(3, 2, 3, 2);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(102, 565);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(255, 76, 32);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(254, 141, 101);
            kryptonPanel1.StateCommon.ColorAngle = 90F;
            kryptonPanel1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonPanel1.TabIndex = 0;
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
            btnDangXuat.Location = new Point(0, 508);
            btnDangXuat.Margin = new Padding(3, 2, 3, 2);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Rotation = 180D;
            btnDangXuat.Size = new Size(102, 57);
            btnDangXuat.TabIndex = 6;
            btnDangXuat.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.Transparent;
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhachHang.ForeColor = Color.DimGray;
            btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnKhachHang.IconColor = Color.DimGray;
            btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKhachHang.Location = new Point(0, 404);
            btnKhachHang.Margin = new Padding(3, 2, 3, 2);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(102, 71);
            btnKhachHang.TabIndex = 5;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.TextImageRelation = TextImageRelation.ImageAboveText;
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnDonHang
            // 
            btnDonHang.BackColor = Color.Transparent;
            btnDonHang.Dock = DockStyle.Top;
            btnDonHang.FlatAppearance.BorderSize = 0;
            btnDonHang.FlatStyle = FlatStyle.Flat;
            btnDonHang.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDonHang.ForeColor = Color.DimGray;
            btnDonHang.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            btnDonHang.IconColor = Color.DimGray;
            btnDonHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDonHang.Location = new Point(0, 334);
            btnDonHang.Margin = new Padding(3, 2, 3, 2);
            btnDonHang.Name = "btnDonHang";
            btnDonHang.Size = new Size(102, 70);
            btnDonHang.TabIndex = 4;
            btnDonHang.Text = "Đơn hàng";
            btnDonHang.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDonHang.UseVisualStyleBackColor = false;
            btnDonHang.Click += btnDonHang_Click;
            // 
            // btnDoanhThu
            // 
            btnDoanhThu.BackColor = Color.Transparent;
            btnDoanhThu.Dock = DockStyle.Top;
            btnDoanhThu.FlatAppearance.BorderSize = 0;
            btnDoanhThu.FlatStyle = FlatStyle.Flat;
            btnDoanhThu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDoanhThu.ForeColor = Color.DimGray;
            btnDoanhThu.IconChar = FontAwesome.Sharp.IconChar.Coins;
            btnDoanhThu.IconColor = Color.DimGray;
            btnDoanhThu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDoanhThu.Location = new Point(0, 262);
            btnDoanhThu.Margin = new Padding(3, 2, 3, 2);
            btnDoanhThu.Name = "btnDoanhThu";
            btnDoanhThu.Size = new Size(102, 72);
            btnDoanhThu.TabIndex = 3;
            btnDoanhThu.Text = "Doanh thu";
            btnDoanhThu.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDoanhThu.UseVisualStyleBackColor = false;
            btnDoanhThu.Click += btnDoanhThu_Click;
            // 
            // btnKho
            // 
            btnKho.BackColor = Color.Transparent;
            btnKho.Dock = DockStyle.Top;
            btnKho.FlatAppearance.BorderSize = 0;
            btnKho.FlatStyle = FlatStyle.Flat;
            btnKho.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKho.ForeColor = Color.DimGray;
            btnKho.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            btnKho.IconColor = Color.DimGray;
            btnKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKho.Location = new Point(0, 192);
            btnKho.Margin = new Padding(3, 2, 3, 2);
            btnKho.Name = "btnKho";
            btnKho.Size = new Size(102, 70);
            btnKho.TabIndex = 2;
            btnKho.Text = "Kho";
            btnKho.TextImageRelation = TextImageRelation.ImageAboveText;
            btnKho.UseVisualStyleBackColor = false;
            btnKho.Click += btnKho_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.Transparent;
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhanVien.ForeColor = Color.DimGray;
            btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            btnNhanVien.IconColor = Color.DimGray;
            btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhanVien.Location = new Point(0, 122);
            btnNhanVien.Margin = new Padding(3, 2, 3, 2);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(102, 70);
            btnNhanVien.TabIndex = 1;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(102, 122);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.remove_bg;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.FromArgb(244, 244, 255);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(102, 0);
            pnMain.Margin = new Padding(3, 2, 3, 2);
            pnMain.Name = "pnMain";
            pnMain.Padding = new Padding(0, 0, 0, 11);
            pnMain.Size = new Size(1020, 565);
            pnMain.TabIndex = 1;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 244, 255);
            ClientSize = new Size(1122, 565);
            Controls.Add(pnMain);
            Controls.Add(kryptonPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fMain";
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
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnDoanhThu;
        private FontAwesome.Sharp.IconButton btnKho;
        private FontAwesome.Sharp.IconButton btnKhachHang;
        private FontAwesome.Sharp.IconButton btnDonHang;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private Panel pnMain;
    }
}