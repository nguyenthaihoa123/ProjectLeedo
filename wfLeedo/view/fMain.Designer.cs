﻿namespace wfLeedo
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
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            kryptonPanel1.Margin = new Padding(3, 2, 3, 2);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(102, 565);
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
            btnQuanLy.Location = new Point(0, 262);
            btnQuanLy.Margin = new Padding(3, 2, 3, 2);
            btnQuanLy.Name = "btnQuanLy";
            btnQuanLy.Size = new Size(102, 70);
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
            btnSanPham.Location = new Point(0, 192);
            btnSanPham.Margin = new Padding(3, 2, 3, 2);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(102, 70);
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
            btnDangXuat.IconColor = Color.White;
            btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDangXuat.Location = new Point(0, 500);
            btnDangXuat.Margin = new Padding(3, 2, 3, 2);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Rotation = 180D;
            btnDangXuat.Size = new Size(102, 65);
            btnDangXuat.TabIndex = 6;
            btnDangXuat.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
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
            btnDonHang.Location = new Point(0, 122);
            btnDonHang.Margin = new Padding(3, 2, 3, 2);
            btnDonHang.Name = "btnDonHang";
            btnDonHang.Size = new Size(102, 70);
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(102, 122);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.remove_bg;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.Coral;
            pnMain.Controls.Add(guna2HtmlLabel1);
            pnMain.Controls.Add(pictureBox2);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(102, 0);
            pnMain.Margin = new Padding(3, 2, 3, 2);
            pnMain.Name = "pnMain";
            pnMain.Padding = new Padding(0, 0, 0, 11);
            pnMain.Size = new Size(1020, 565);
            pnMain.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Times New Roman", 36F, FontStyle.Italic, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.Black;
            guna2HtmlLabel1.Location = new Point(223, 370);
            guna2HtmlLabel1.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(536, 57);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Chúc bạn một ngày tốt lành";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.remove_bg;
            pictureBox2.Location = new Point(274, 35);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(420, 304);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
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
            Text = "Trang chủ";
            Load += fMain_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private PictureBox pictureBox2;
    }
}