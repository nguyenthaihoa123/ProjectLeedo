namespace wfLeedo
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel2 = new Panel();
            panel1 = new Panel();
            txtPwd = new Krypton.Toolkit.KryptonTextBox();
            exitBtn = new Krypton.Toolkit.KryptonButton();
            txtUsername = new Krypton.Toolkit.KryptonTextBox();
            btnLogin = new Krypton.Toolkit.KryptonButton();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.remove_bg;
            pictureBox1.Location = new Point(75, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.shoes;
            pictureBox2.Location = new Point(75, 308);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(310, 283);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(guna2HtmlLabel2);
            kryptonPanel1.Controls.Add(guna2HtmlLabel1);
            kryptonPanel1.Controls.Add(panel2);
            kryptonPanel1.Controls.Add(panel1);
            kryptonPanel1.Controls.Add(txtPwd);
            kryptonPanel1.Controls.Add(exitBtn);
            kryptonPanel1.Controls.Add(txtUsername);
            kryptonPanel1.Controls.Add(btnLogin);
            kryptonPanel1.Controls.Add(iconPictureBox3);
            kryptonPanel1.Controls.Add(iconPictureBox2);
            kryptonPanel1.Controls.Add(label1);
            kryptonPanel1.Controls.Add(iconPictureBox1);
            kryptonPanel1.Dock = DockStyle.Right;
            kryptonPanel1.Location = new Point(571, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(511, 653);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(240, 101, 57);
            kryptonPanel1.TabIndex = 2;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel2.ForeColor = Color.White;
            guna2HtmlLabel2.Location = new Point(101, 352);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(84, 27);
            guna2HtmlLabel2.TabIndex = 12;
            guna2HtmlLabel2.Text = "Mật khẩu";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(101, 267);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(136, 27);
            guna2HtmlLabel1.TabIndex = 11;
            guna2HtmlLabel1.Text = "Tên đăng nhập";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(299, 179);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 5);
            panel2.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(3, 179);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 5);
            panel1.TabIndex = 9;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(102, 385);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '●';
            txtPwd.Size = new Size(337, 41);
            txtPwd.StateActive.Back.Color1 = Color.FromArgb(240, 101, 57);
            txtPwd.StateActive.Border.Color1 = Color.LightGray;
            txtPwd.StateActive.Border.Color2 = Color.LightGray;
            txtPwd.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtPwd.StateActive.Border.Width = 2;
            txtPwd.StateActive.Content.Color1 = Color.LightGray;
            txtPwd.StateActive.Content.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPwd.TabIndex = 2;
            txtPwd.UseSystemPasswordChar = true;
            // 
            // exitBtn
            // 
            exitBtn.CornerRoundingRadius = 15F;
            exitBtn.Location = new Point(38, 484);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(165, 69);
            exitBtn.StateCommon.Back.Color1 = Color.FromArgb(240, 101, 57);
            exitBtn.StateCommon.Back.Color2 = Color.FromArgb(240, 101, 57);
            exitBtn.StateCommon.Border.Color1 = Color.White;
            exitBtn.StateCommon.Border.Color2 = Color.White;
            exitBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            exitBtn.StateCommon.Border.Rounding = 15F;
            exitBtn.StateCommon.Border.Width = 2;
            exitBtn.StateCommon.Content.ShortText.Color1 = Color.White;
            exitBtn.StateCommon.Content.ShortText.Color2 = Color.White;
            exitBtn.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.StatePressed.Back.Color1 = Color.White;
            exitBtn.StatePressed.Back.Color2 = Color.White;
            exitBtn.StatePressed.Content.ShortText.Color1 = Color.FromArgb(255, 128, 0);
            exitBtn.StatePressed.Content.ShortText.Color2 = Color.FromArgb(255, 128, 0);
            exitBtn.TabIndex = 4;
            exitBtn.Values.Text = "Hủy";
            exitBtn.Click += exitBtn_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(102, 295);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(337, 41);
            txtUsername.StateActive.Back.Color1 = Color.FromArgb(240, 101, 57);
            txtUsername.StateActive.Border.Color1 = Color.LightGray;
            txtUsername.StateActive.Border.Color2 = Color.LightGray;
            txtUsername.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            txtUsername.StateActive.Border.Width = 2;
            txtUsername.StateActive.Content.Color1 = Color.LightGray;
            txtUsername.StateActive.Content.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.CornerRoundingRadius = 15F;
            btnLogin.Location = new Point(209, 484);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(268, 69);
            btnLogin.StateCommon.Back.Color1 = Color.White;
            btnLogin.StateCommon.Back.Color2 = Color.White;
            btnLogin.StateCommon.Border.Color1 = Color.White;
            btnLogin.StateCommon.Border.Color2 = Color.White;
            btnLogin.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogin.StateCommon.Border.Rounding = 15F;
            btnLogin.StateCommon.Border.Width = 1;
            btnLogin.StateCommon.Content.ShortText.Color1 = Color.FromArgb(240, 101, 57);
            btnLogin.StateCommon.Content.ShortText.Color2 = Color.FromArgb(240, 101, 57);
            btnLogin.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.StatePressed.Back.Color1 = Color.FromArgb(255, 224, 192);
            btnLogin.StatePressed.Back.Color2 = Color.FromArgb(255, 224, 192);
            btnLogin.StatePressed.Back.ColorAngle = 0F;
            btnLogin.StatePressed.Border.Color1 = Color.White;
            btnLogin.StatePressed.Border.Color2 = Color.White;
            btnLogin.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogin.StatePressed.Border.Width = 5;
            btnLogin.StatePressed.Content.ShortText.Color1 = Color.White;
            btnLogin.StatePressed.Content.ShortText.Color2 = Color.White;
            btnLogin.TabIndex = 3;
            btnLogin.Values.Text = "Đăng nhập";
            btnLogin.Click += btnLogin_Click;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Transparent;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox3.IconColor = Color.White;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 40;
            iconPictureBox3.Location = new Point(38, 388);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(40, 40);
            iconPictureBox3.TabIndex = 4;
            iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Transparent;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 40;
            iconPictureBox2.Location = new Point(38, 299);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(40, 40);
            iconPictureBox2.TabIndex = 3;
            iconPictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(114, 64);
            label1.Name = "label1";
            label1.Size = new Size(279, 58);
            label1.TabIndex = 1;
            label1.Text = "Đăng nhập";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 131;
            iconPictureBox1.Location = new Point(141, 125);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(223, 131);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SignUp_Light;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 653);
            Controls.Add(kryptonPanel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            StateActive.Back.Image = Properties.Resources.SignUp_Light;
            StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateActive.Border.Width = 0;
            StateActive.Header.Back.Color1 = Color.FromArgb(255, 128, 0);
            StateActive.Header.Back.Color2 = Color.FromArgb(255, 224, 192);
            StateActive.Header.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "Đăng nhập";
            Load += fLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Krypton.Toolkit.KryptonButton btnLogin;
        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private Krypton.Toolkit.KryptonTextBox txtPwd;
        private Panel panel2;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Krypton.Toolkit.KryptonButton exitBtn;
    }
}