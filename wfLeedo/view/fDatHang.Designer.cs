namespace wfLeedo
{
    partial class fDatHang
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDatHang));
            panel1 = new Panel();
            imgMomo = new PictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label7 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            pnfHoaDon2 = new Krypton.Toolkit.KryptonPanel();
            panel4 = new Panel();
            lbShowVoucher = new Label();
            label2 = new Label();
            btnThanhToan = new FontAwesome.Sharp.IconButton();
            lbShowTotal = new Label();
            label8 = new Label();
            dgvDonHangChiTiet = new Krypton.Toolkit.KryptonDataGridView();
            name = new DataGridViewTextBoxColumn();
            SL = new DataGridViewTextBoxColumn();
            money = new DataGridViewTextBoxColumn();
            pnfHoaDon1 = new Krypton.Toolkit.KryptonPanel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lbDateBill = new Label();
            lbNameCus = new Label();
            label3 = new Label();
            lbMaDH = new Label();
            label1 = new Label();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            pnfSanPham = new Krypton.Toolkit.KryptonPanel();
            btnInsertItemToBill = new Krypton.Toolkit.KryptonButton();
            btnDeleteInfoSp = new Krypton.Toolkit.KryptonButton();
            lbShowSLTonKho = new Label();
            label17 = new Label();
            btnCheckInfo = new FontAwesome.Sharp.IconButton();
            kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            label11 = new Label();
            label12 = new Label();
            label16 = new Label();
            label13 = new Label();
            label15 = new Label();
            label14 = new Label();
            txtIDSp = new TextBox();
            txtNameSp = new TextBox();
            txtTypeSp = new TextBox();
            txtPriceSp = new TextBox();
            txtSizeSp = new TextBox();
            txtSLSp = new TextBox();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgMomo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnfHoaDon2).BeginInit();
            pnfHoaDon2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonHangChiTiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnfHoaDon1).BeginInit();
            pnfHoaDon1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnfSanPham).BeginInit();
            pnfSanPham.SuspendLayout();
            kryptonTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(imgMomo);
            panel1.Controls.Add(iconPictureBox2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 11);
            panel1.Size = new Size(1147, 115);
            panel1.TabIndex = 2;
            // 
            // imgMomo
            // 
            imgMomo.Image = Properties.Resources.Momo_logo;
            imgMomo.Location = new Point(35, 12);
            imgMomo.Name = "imgMomo";
            imgMomo.Size = new Size(75, 75);
            imgMomo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgMomo.TabIndex = 10;
            imgMomo.TabStop = false;
            imgMomo.Click += imgMomo_Click;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            iconPictureBox2.BackColor = Color.FromArgb(244, 244, 255);
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 81;
            iconPictureBox2.Location = new Point(1041, 12);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(91, 81);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox2.TabIndex = 9;
            iconPictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(934, 57);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 8;
            label7.Text = "Admin";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(877, 32);
            label6.Name = "label6";
            label6.Size = new Size(154, 25);
            label6.TabIndex = 7;
            label6.Text = "Nguyen Thang";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(38, 630);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(pnfHoaDon2);
            panel3.Controls.Add(pnfHoaDon1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(697, 115);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(21, 0, 5, 5);
            panel3.Size = new Size(450, 630);
            panel3.TabIndex = 4;
            // 
            // pnfHoaDon2
            // 
            pnfHoaDon2.Controls.Add(panel4);
            pnfHoaDon2.Controls.Add(dgvDonHangChiTiet);
            pnfHoaDon2.Dock = DockStyle.Fill;
            pnfHoaDon2.Location = new Point(21, 88);
            pnfHoaDon2.Name = "pnfHoaDon2";
            pnfHoaDon2.Padding = new Padding(10, 0, 10, 11);
            pnfHoaDon2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            pnfHoaDon2.Size = new Size(424, 537);
            pnfHoaDon2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Controls.Add(lbShowVoucher);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnThanhToan);
            panel4.Controls.Add(lbShowTotal);
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(10, 386);
            panel4.Name = "panel4";
            panel4.Size = new Size(404, 140);
            panel4.TabIndex = 1;
            // 
            // lbShowVoucher
            // 
            lbShowVoucher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbShowVoucher.AutoSize = true;
            lbShowVoucher.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbShowVoucher.Location = new Point(100, 80);
            lbShowVoucher.Name = "lbShowVoucher";
            lbShowVoucher.Size = new Size(23, 25);
            lbShowVoucher.TabIndex = 13;
            lbShowVoucher.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(17, 80);
            label2.Name = "label2";
            label2.Size = new Size(98, 24);
            label2.TabIndex = 12;
            label2.Text = "Đã giảm: ";
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(254, 142, 102);
            btnThanhToan.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            btnThanhToan.IconColor = Color.White;
            btnThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThanhToan.ImageAlign = ContentAlignment.MiddleLeft;
            btnThanhToan.Location = new Point(224, 76);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(181, 61);
            btnThanhToan.TabIndex = 11;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.TextAlign = ContentAlignment.MiddleRight;
            btnThanhToan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // lbShowTotal
            // 
            lbShowTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbShowTotal.AutoSize = true;
            lbShowTotal.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbShowTotal.Location = new Point(148, 25);
            lbShowTotal.Name = "lbShowTotal";
            lbShowTotal.Size = new Size(97, 29);
            lbShowTotal.TabIndex = 10;
            lbShowTotal.Text = "500.000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(17, 25);
            label8.Name = "label8";
            label8.Size = new Size(152, 29);
            label8.TabIndex = 0;
            label8.Text = "Tổng cộng: ";
            // 
            // dgvDonHangChiTiet
            // 
            dgvDonHangChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonHangChiTiet.ColumnHeadersHeight = 36;
            dgvDonHangChiTiet.Columns.AddRange(new DataGridViewColumn[] { name, SL, money });
            dgvDonHangChiTiet.Dock = DockStyle.Fill;
            dgvDonHangChiTiet.Location = new Point(10, 0);
            dgvDonHangChiTiet.MultiSelect = false;
            dgvDonHangChiTiet.Name = "dgvDonHangChiTiet";
            dgvDonHangChiTiet.ReadOnly = true;
            dgvDonHangChiTiet.RowHeadersWidth = 51;
            dgvDonHangChiTiet.RowTemplate.Height = 29;
            dgvDonHangChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonHangChiTiet.Size = new Size(404, 526);
            dgvDonHangChiTiet.TabIndex = 0;
            dgvDonHangChiTiet.CellDoubleClick += dgvDonHangChiTiet_CellDoubleClick;
            // 
            // name
            // 
            name.DataPropertyName = "TenSP";
            name.HeaderText = "Tên SP";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // SL
            // 
            SL.DataPropertyName = "SoLuong";
            SL.HeaderText = "Số Lượng";
            SL.MinimumWidth = 6;
            SL.Name = "SL";
            SL.ReadOnly = true;
            // 
            // money
            // 
            money.DataPropertyName = "TongBill";
            money.HeaderText = "Tiền";
            money.MinimumWidth = 6;
            money.Name = "money";
            money.ReadOnly = true;
            // 
            // pnfHoaDon1
            // 
            pnfHoaDon1.Controls.Add(iconPictureBox1);
            pnfHoaDon1.Controls.Add(lbDateBill);
            pnfHoaDon1.Controls.Add(lbNameCus);
            pnfHoaDon1.Controls.Add(label3);
            pnfHoaDon1.Controls.Add(lbMaDH);
            pnfHoaDon1.Controls.Add(label1);
            pnfHoaDon1.Dock = DockStyle.Top;
            pnfHoaDon1.Location = new Point(21, 0);
            pnfHoaDon1.Name = "pnfHoaDon1";
            pnfHoaDon1.Padding = new Padding(5);
            pnfHoaDon1.Palette = kryptonPalette1;
            pnfHoaDon1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            pnfHoaDon1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelCustom1;
            pnfHoaDon1.Size = new Size(424, 88);
            pnfHoaDon1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(365, 28);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 5;
            iconPictureBox1.TabStop = false;
            // 
            // lbDateBill
            // 
            lbDateBill.AutoSize = true;
            lbDateBill.BackColor = Color.Transparent;
            lbDateBill.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDateBill.ForeColor = SystemColors.ActiveBorder;
            lbDateBill.Location = new Point(227, 5);
            lbDateBill.Name = "lbDateBill";
            lbDateBill.Size = new Size(122, 25);
            lbDateBill.TabIndex = 4;
            lbDateBill.Text = "10/10/2023";
            // 
            // lbNameCus
            // 
            lbNameCus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbNameCus.AutoSize = true;
            lbNameCus.BackColor = Color.Transparent;
            lbNameCus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbNameCus.ForeColor = Color.White;
            lbNameCus.Location = new Point(67, 43);
            lbNameCus.Name = "lbNameCus";
            lbNameCus.Size = new Size(165, 25);
            lbNameCus.TabIndex = 3;
            lbNameCus.Text = "Nguyễn Thái Hòa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(8, 43);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên:";
            // 
            // lbMaDH
            // 
            lbMaDH.AutoSize = true;
            lbMaDH.BackColor = Color.Transparent;
            lbMaDH.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbMaDH.ForeColor = Color.White;
            lbMaDH.Location = new Point(159, 11);
            lbMaDH.Name = "lbMaDH";
            lbMaDH.Size = new Size(45, 20);
            lbMaDH.TabIndex = 1;
            lbMaDH.Text = "5151";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 5);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã đơn hàng:";
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.FormStyles.FormMain.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateActive.Border.Rounding = 20F;
            kryptonPalette1.FormStyles.FormMain.StateActive.Border.Width = 5;
            kryptonPalette1.PanelStyles.PanelClient.StateCommon.Color1 = Color.FromArgb(255, 76, 32);
            kryptonPalette1.PanelStyles.PanelClient.StateCommon.Color2 = Color.FromArgb(255, 76, 32);
            kryptonPalette1.PanelStyles.PanelCustom1.StateCommon.Color1 = Color.FromArgb(255, 76, 32);
            kryptonPalette1.PanelStyles.PanelCustom1.StateCommon.Color2 = Color.FromArgb(254, 142, 102);
            kryptonPalette1.PanelStyles.PanelCustom1.StateCommon.ColorAngle = 180F;
            kryptonPalette1.PanelStyles.PanelCustom1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(pnfSanPham);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(38, 115);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Padding = new Padding(5);
            kryptonPanel1.Palette = kryptonPalette1;
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonPanel1.Size = new Size(659, 630);
            kryptonPanel1.TabIndex = 5;
            // 
            // pnfSanPham
            // 
            pnfSanPham.Controls.Add(btnInsertItemToBill);
            pnfSanPham.Controls.Add(btnDeleteInfoSp);
            pnfSanPham.Controls.Add(lbShowSLTonKho);
            pnfSanPham.Controls.Add(label17);
            pnfSanPham.Controls.Add(btnCheckInfo);
            pnfSanPham.Controls.Add(kryptonTableLayoutPanel1);
            pnfSanPham.Controls.Add(label10);
            pnfSanPham.Dock = DockStyle.Fill;
            pnfSanPham.Location = new Point(5, 5);
            pnfSanPham.Name = "pnfSanPham";
            pnfSanPham.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            pnfSanPham.Size = new Size(649, 620);
            pnfSanPham.TabIndex = 0;
            // 
            // btnInsertItemToBill
            // 
            btnInsertItemToBill.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnInsertItemToBill.CornerRoundingRadius = 10F;
            btnInsertItemToBill.Location = new Point(150, 555);
            btnInsertItemToBill.Name = "btnInsertItemToBill";
            btnInsertItemToBill.Size = new Size(193, 55);
            btnInsertItemToBill.StateCommon.Back.Color1 = Color.FromArgb(255, 76, 32);
            btnInsertItemToBill.StateCommon.Back.Color2 = Color.FromArgb(255, 76, 32);
            btnInsertItemToBill.StateCommon.Border.Color1 = Color.FromArgb(255, 128, 0);
            btnInsertItemToBill.StateCommon.Border.Color2 = Color.White;
            btnInsertItemToBill.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnInsertItemToBill.StateCommon.Border.Rounding = 10F;
            btnInsertItemToBill.StateCommon.Border.Width = 2;
            btnInsertItemToBill.StateCommon.Content.ShortText.Color1 = Color.White;
            btnInsertItemToBill.StateCommon.Content.ShortText.Color2 = Color.White;
            btnInsertItemToBill.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertItemToBill.StatePressed.Back.Color1 = Color.FromArgb(255, 224, 192);
            btnInsertItemToBill.StatePressed.Back.Color2 = Color.FromArgb(255, 224, 192);
            btnInsertItemToBill.StatePressed.Back.ColorAngle = 0F;
            btnInsertItemToBill.StatePressed.Border.Color1 = Color.White;
            btnInsertItemToBill.StatePressed.Border.Color2 = Color.White;
            btnInsertItemToBill.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnInsertItemToBill.StatePressed.Border.Width = 5;
            btnInsertItemToBill.StatePressed.Content.ShortText.Color1 = Color.White;
            btnInsertItemToBill.StatePressed.Content.ShortText.Color2 = Color.White;
            btnInsertItemToBill.TabIndex = 13;
            btnInsertItemToBill.Values.Text = "Thêm";
            btnInsertItemToBill.Click += btnInsertItemToBill_Click;
            // 
            // btnDeleteInfoSp
            // 
            btnDeleteInfoSp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteInfoSp.CornerRoundingRadius = 10F;
            btnDeleteInfoSp.Location = new Point(357, 555);
            btnDeleteInfoSp.Name = "btnDeleteInfoSp";
            btnDeleteInfoSp.Size = new Size(193, 55);
            btnDeleteInfoSp.StateCommon.Back.Color1 = Color.White;
            btnDeleteInfoSp.StateCommon.Back.Color2 = Color.White;
            btnDeleteInfoSp.StateCommon.Border.Color1 = Color.FromArgb(255, 128, 0);
            btnDeleteInfoSp.StateCommon.Border.Color2 = Color.White;
            btnDeleteInfoSp.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDeleteInfoSp.StateCommon.Border.Rounding = 10F;
            btnDeleteInfoSp.StateCommon.Border.Width = 2;
            btnDeleteInfoSp.StateCommon.Content.ShortText.Color1 = Color.FromArgb(240, 101, 57);
            btnDeleteInfoSp.StateCommon.Content.ShortText.Color2 = Color.FromArgb(240, 101, 57);
            btnDeleteInfoSp.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteInfoSp.StatePressed.Back.Color1 = Color.FromArgb(255, 224, 192);
            btnDeleteInfoSp.StatePressed.Back.Color2 = Color.FromArgb(255, 224, 192);
            btnDeleteInfoSp.StatePressed.Back.ColorAngle = 0F;
            btnDeleteInfoSp.StatePressed.Border.Color1 = Color.White;
            btnDeleteInfoSp.StatePressed.Border.Color2 = Color.White;
            btnDeleteInfoSp.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDeleteInfoSp.StatePressed.Border.Width = 5;
            btnDeleteInfoSp.StatePressed.Content.ShortText.Color1 = Color.White;
            btnDeleteInfoSp.StatePressed.Content.ShortText.Color2 = Color.White;
            btnDeleteInfoSp.TabIndex = 12;
            btnDeleteInfoSp.Values.Text = "Xóa";
            btnDeleteInfoSp.Click += btnDeleteInfoSp_Click;
            // 
            // lbShowSLTonKho
            // 
            lbShowSLTonKho.AutoSize = true;
            lbShowSLTonKho.BackColor = Color.Transparent;
            lbShowSLTonKho.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbShowSLTonKho.Location = new Point(357, 460);
            lbShowSLTonKho.Name = "lbShowSLTonKho";
            lbShowSLTonKho.Size = new Size(34, 25);
            lbShowSLTonKho.TabIndex = 11;
            lbShowSLTonKho.Text = "15";
            lbShowSLTonKho.Click += lbShowSLTonKho_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(182, 459);
            label17.Name = "label17";
            label17.Size = new Size(169, 25);
            label17.TabIndex = 9;
            label17.Text = "Số lượng hiện có: ";
            // 
            // btnCheckInfo
            // 
            btnCheckInfo.BackColor = Color.FromArgb(128, 255, 128);
            btnCheckInfo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheckInfo.ForeColor = Color.White;
            btnCheckInfo.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnCheckInfo.IconColor = Color.White;
            btnCheckInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCheckInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnCheckInfo.Location = new Point(29, 456);
            btnCheckInfo.Name = "btnCheckInfo";
            btnCheckInfo.Size = new Size(123, 45);
            btnCheckInfo.TabIndex = 8;
            btnCheckInfo.Text = "Kiểm tra";
            btnCheckInfo.TextAlign = ContentAlignment.MiddleRight;
            btnCheckInfo.UseVisualStyleBackColor = false;
            btnCheckInfo.Click += btnCheckInfo_Click;
            // 
            // kryptonTableLayoutPanel1
            // 
            kryptonTableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonTableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("kryptonTableLayoutPanel1.BackgroundImage");
            kryptonTableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            kryptonTableLayoutPanel1.ColumnCount = 2;
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            kryptonTableLayoutPanel1.Controls.Add(label11, 0, 0);
            kryptonTableLayoutPanel1.Controls.Add(label12, 0, 1);
            kryptonTableLayoutPanel1.Controls.Add(label16, 0, 5);
            kryptonTableLayoutPanel1.Controls.Add(label13, 0, 2);
            kryptonTableLayoutPanel1.Controls.Add(label15, 0, 4);
            kryptonTableLayoutPanel1.Controls.Add(label14, 0, 3);
            kryptonTableLayoutPanel1.Controls.Add(txtIDSp, 1, 0);
            kryptonTableLayoutPanel1.Controls.Add(txtNameSp, 1, 1);
            kryptonTableLayoutPanel1.Controls.Add(txtTypeSp, 1, 2);
            kryptonTableLayoutPanel1.Controls.Add(txtPriceSp, 1, 3);
            kryptonTableLayoutPanel1.Controls.Add(txtSizeSp, 1, 4);
            kryptonTableLayoutPanel1.Controls.Add(txtSLSp, 1, 5);
            kryptonTableLayoutPanel1.Location = new Point(29, 99);
            kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            kryptonTableLayoutPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonTableLayoutPanel1.RowCount = 6;
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            kryptonTableLayoutPanel1.Size = new Size(458, 335);
            kryptonTableLayoutPanel1.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(114, 23);
            label11.TabIndex = 1;
            label11.Text = "Mã sản phẩm";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(3, 55);
            label12.Name = "label12";
            label12.Size = new Size(116, 23);
            label12.TabIndex = 2;
            label12.Text = "Tên sản phẩm";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(3, 275);
            label16.Name = "label16";
            label16.Size = new Size(78, 23);
            label16.TabIndex = 6;
            label16.Text = "Số lượng";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(3, 110);
            label13.Name = "label13";
            label13.Size = new Size(121, 23);
            label13.TabIndex = 3;
            label13.Text = "Loại sản phẩm";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(3, 220);
            label15.Name = "label15";
            label15.Size = new Size(40, 23);
            label15.TabIndex = 5;
            label15.Text = "Size";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(3, 165);
            label14.Name = "label14";
            label14.Size = new Size(35, 23);
            label14.TabIndex = 4;
            label14.Text = "Giá";
            // 
            // txtIDSp
            // 
            txtIDSp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIDSp.BackColor = Color.LightGray;
            txtIDSp.BorderStyle = BorderStyle.None;
            txtIDSp.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDSp.Location = new Point(140, 3);
            txtIDSp.Name = "txtIDSp";
            txtIDSp.Size = new Size(315, 36);
            txtIDSp.TabIndex = 7;
            // 
            // txtNameSp
            // 
            txtNameSp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNameSp.BackColor = Color.LightGray;
            txtNameSp.BorderStyle = BorderStyle.None;
            txtNameSp.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameSp.Location = new Point(140, 58);
            txtNameSp.Name = "txtNameSp";
            txtNameSp.Size = new Size(315, 36);
            txtNameSp.TabIndex = 8;
            // 
            // txtTypeSp
            // 
            txtTypeSp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTypeSp.BackColor = Color.LightGray;
            txtTypeSp.BorderStyle = BorderStyle.None;
            txtTypeSp.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTypeSp.Location = new Point(140, 113);
            txtTypeSp.Name = "txtTypeSp";
            txtTypeSp.Size = new Size(315, 36);
            txtTypeSp.TabIndex = 9;
            // 
            // txtPriceSp
            // 
            txtPriceSp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPriceSp.BackColor = Color.LightGray;
            txtPriceSp.BorderStyle = BorderStyle.None;
            txtPriceSp.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPriceSp.Location = new Point(140, 168);
            txtPriceSp.Name = "txtPriceSp";
            txtPriceSp.Size = new Size(315, 36);
            txtPriceSp.TabIndex = 10;
            // 
            // txtSizeSp
            // 
            txtSizeSp.BackColor = Color.LightGray;
            txtSizeSp.BorderStyle = BorderStyle.None;
            txtSizeSp.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSizeSp.Location = new Point(140, 223);
            txtSizeSp.Name = "txtSizeSp";
            txtSizeSp.Size = new Size(161, 36);
            txtSizeSp.TabIndex = 11;
            // 
            // txtSLSp
            // 
            txtSLSp.BackColor = Color.LightGray;
            txtSLSp.BorderStyle = BorderStyle.None;
            txtSLSp.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSLSp.Location = new Point(140, 278);
            txtSLSp.Name = "txtSLSp";
            txtSLSp.Size = new Size(161, 36);
            txtSLSp.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(29, 35);
            label10.Name = "label10";
            label10.Size = new Size(242, 29);
            label10.TabIndex = 0;
            label10.Text = "Thông tin sản phẩm";
            // 
            // fDatHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 244, 255);
            ClientSize = new Size(1147, 745);
            Controls.Add(kryptonPanel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "fDatHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fDonHang";
            Load += fDatHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgMomo).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnfHoaDon2).EndInit();
            pnfHoaDon2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonHangChiTiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnfHoaDon1).EndInit();
            pnfHoaDon1.ResumeLayout(false);
            pnfHoaDon1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnfSanPham).EndInit();
            pnfSanPham.ResumeLayout(false);
            pnfSanPham.PerformLayout();
            kryptonTableLayoutPanel1.ResumeLayout(false);
            kryptonTableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonPanel pnfSanPham;
        private Krypton.Toolkit.KryptonPanel pnfHoaDon1;
        private Label lbMaDH;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lbDateBill;
        private Label lbNameCus;
        private Label label3;
        private Krypton.Toolkit.KryptonPanel pnfHoaDon2;
        private Label label6;
        private Label label7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Panel panel4;
        private Krypton.Toolkit.KryptonDataGridView dgvDonHangChiTiet;
        private Label lbShowTotal;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnThanhToan;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txtIDSp;
        private TextBox txtNameSp;
        private TextBox txtTypeSp;
        private TextBox txtPriceSp;
        private TextBox txtSizeSp;
        private TextBox txtSLSp;
        private Label label17;
        private FontAwesome.Sharp.IconButton btnCheckInfo;
        private Label lbShowSLTonKho;
        private Krypton.Toolkit.KryptonButton btnInsertItemToBill;
        private Krypton.Toolkit.KryptonButton btnDeleteInfoSp;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn money;
        private Label lbShowVoucher;
        private Label label2;
        private PictureBox imgMomo;
    }
}