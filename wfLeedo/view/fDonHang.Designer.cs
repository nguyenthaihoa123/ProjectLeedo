namespace wfLeedo
{
    partial class fDonHang
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
            panel1 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            label1 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            btnInsertDonHang = new FontAwesome.Sharp.IconButton();
            btnResetDonHang = new FontAwesome.Sharp.IconButton();
            btnSearchDonHang = new FontAwesome.Sharp.IconButton();
            txtSearchDonHang = new Krypton.Toolkit.KryptonTextBox();
            dgvDonHang = new Krypton.Toolkit.KryptonDataGridView();
            btnDelete = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconButton4);
            panel1.Controls.Add(btnInsertDonHang);
            panel1.Controls.Add(btnResetDonHang);
            panel1.Controls.Add(btnSearchDonHang);
            panel1.Controls.Add(txtSearchDonHang);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1004, 74);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(146, 11);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(109, 23);
            dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(19, 11);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(109, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.FromArgb(244, 244, 255);
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 61;
            iconPictureBox1.Location = new Point(914, 9);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(80, 61);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox1.TabIndex = 8;
            iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(844, 40);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "Admin";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(766, 22);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 6;
            label1.Text = "Nguyen Thang";
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.Red;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.Transparent;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Minus;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 32;
            iconButton4.Location = new Point(581, 40);
            iconButton4.Margin = new Padding(3, 2, 3, 2);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(46, 32);
            iconButton4.TabIndex = 5;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // btnInsertDonHang
            // 
            btnInsertDonHang.BackColor = Color.FromArgb(128, 255, 128);
            btnInsertDonHang.FlatAppearance.BorderSize = 0;
            btnInsertDonHang.FlatStyle = FlatStyle.Flat;
            btnInsertDonHang.ForeColor = Color.Transparent;
            btnInsertDonHang.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnInsertDonHang.IconColor = Color.White;
            btnInsertDonHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInsertDonHang.IconSize = 32;
            btnInsertDonHang.Location = new Point(529, 40);
            btnInsertDonHang.Margin = new Padding(3, 2, 3, 2);
            btnInsertDonHang.Name = "btnInsertDonHang";
            btnInsertDonHang.Size = new Size(46, 32);
            btnInsertDonHang.TabIndex = 4;
            btnInsertDonHang.UseVisualStyleBackColor = false;
            btnInsertDonHang.Click += iconButton3_Click;
            // 
            // btnResetDonHang
            // 
            btnResetDonHang.BackColor = Color.FromArgb(255, 76, 32);
            btnResetDonHang.FlatAppearance.BorderSize = 0;
            btnResetDonHang.FlatStyle = FlatStyle.Flat;
            btnResetDonHang.ForeColor = Color.Transparent;
            btnResetDonHang.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            btnResetDonHang.IconColor = Color.White;
            btnResetDonHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnResetDonHang.IconSize = 32;
            btnResetDonHang.Location = new Point(452, 40);
            btnResetDonHang.Margin = new Padding(3, 2, 3, 2);
            btnResetDonHang.Name = "btnResetDonHang";
            btnResetDonHang.Size = new Size(57, 32);
            btnResetDonHang.TabIndex = 3;
            btnResetDonHang.UseVisualStyleBackColor = false;
            btnResetDonHang.Click += btnResetDonHang_Click;
            // 
            // btnSearchDonHang
            // 
            btnSearchDonHang.BackColor = Color.FromArgb(255, 76, 32);
            btnSearchDonHang.FlatAppearance.BorderSize = 0;
            btnSearchDonHang.FlatStyle = FlatStyle.Flat;
            btnSearchDonHang.ForeColor = Color.Transparent;
            btnSearchDonHang.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearchDonHang.IconColor = Color.White;
            btnSearchDonHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearchDonHang.IconSize = 32;
            btnSearchDonHang.Location = new Point(389, 40);
            btnSearchDonHang.Margin = new Padding(3, 2, 3, 2);
            btnSearchDonHang.Name = "btnSearchDonHang";
            btnSearchDonHang.Size = new Size(57, 32);
            btnSearchDonHang.TabIndex = 2;
            btnSearchDonHang.UseVisualStyleBackColor = false;
            btnSearchDonHang.Click += btnSearchDonHang_Click;
            // 
            // txtSearchDonHang
            // 
            txtSearchDonHang.Location = new Point(3, 40);
            txtSearchDonHang.Margin = new Padding(3, 2, 3, 2);
            txtSearchDonHang.Name = "txtSearchDonHang";
            txtSearchDonHang.Size = new Size(382, 34);
            txtSearchDonHang.StateActive.Back.Color1 = Color.White;
            txtSearchDonHang.StateActive.Border.Color1 = Color.White;
            txtSearchDonHang.StateActive.Border.Color2 = Color.White;
            txtSearchDonHang.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSearchDonHang.StateActive.Border.Rounding = 10F;
            txtSearchDonHang.StateActive.Border.Width = 0;
            txtSearchDonHang.StateActive.Content.Color1 = Color.DarkGray;
            txtSearchDonHang.StateActive.Content.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchDonHang.TabIndex = 1;
            // 
            // dgvDonHang
            // 
            dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonHang.ColumnHeadersHeight = 36;
            dgvDonHang.Columns.AddRange(new DataGridViewColumn[] { btnDelete });
            dgvDonHang.Dock = DockStyle.Fill;
            dgvDonHang.Location = new Point(0, 74);
            dgvDonHang.Margin = new Padding(3, 2, 3, 2);
            dgvDonHang.MultiSelect = false;
            dgvDonHang.Name = "dgvDonHang";
            dgvDonHang.ReadOnly = true;
            dgvDonHang.RowHeadersWidth = 51;
            dgvDonHang.RowTemplate.Height = 29;
            dgvDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonHang.Size = new Size(1004, 456);
            dgvDonHang.TabIndex = 1;
            dgvDonHang.CellClick += dgvDonHang_CellClick;
            dgvDonHang.CellDoubleClick += dgvDonHang_CellDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "";
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Text = "Chỉnh sửa";
            btnDelete.UseColumnTextForButtonValue = true;
            // 
            // fDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 244, 255);
            ClientSize = new Size(1004, 530);
            Controls.Add(dgvDonHang);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "fDonHang";
            Text = "fDonHang";
            Load += fDonHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Krypton.Toolkit.KryptonTextBox txtSearchDonHang;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnInsertDonHang;
        private FontAwesome.Sharp.IconButton btnResetDonHang;
        private FontAwesome.Sharp.IconButton btnSearchDonHang;
        private Label label2;
        private Label label1;
        private Krypton.Toolkit.KryptonDataGridView dgvDonHang;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private DataGridViewButtonColumn btnDelete;
    }
}