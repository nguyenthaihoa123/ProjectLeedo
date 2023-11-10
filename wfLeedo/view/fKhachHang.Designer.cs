namespace wfLeedo
{
    partial class fKhachHang

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
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            label1 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            btnInsertKH = new FontAwesome.Sharp.IconButton();
            btnReset = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtSearchInfo = new Krypton.Toolkit.KryptonTextBox();
            dgvCustomer = new Krypton.Toolkit.KryptonDataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconButton4);
            panel1.Controls.Add(btnInsertKH);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearchInfo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1004, 74);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            iconPictureBox1.Location = new Point(882, 11);
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
            label2.Location = new Point(774, 40);
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
            label1.Location = new Point(733, 22);
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
            iconButton4.Location = new Point(623, 40);
            iconButton4.Margin = new Padding(3, 2, 3, 2);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(57, 32);
            iconButton4.TabIndex = 5;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // btnInsertKH
            // 
            btnInsertKH.BackColor = Color.FromArgb(128, 255, 128);
            btnInsertKH.FlatAppearance.BorderSize = 0;
            btnInsertKH.FlatStyle = FlatStyle.Flat;
            btnInsertKH.ForeColor = Color.Transparent;
            btnInsertKH.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnInsertKH.IconColor = Color.White;
            btnInsertKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInsertKH.IconSize = 32;
            btnInsertKH.Location = new Point(561, 40);
            btnInsertKH.Margin = new Padding(3, 2, 3, 2);
            btnInsertKH.Name = "btnInsertKH";
            btnInsertKH.Size = new Size(57, 32);
            btnInsertKH.TabIndex = 4;
            btnInsertKH.UseVisualStyleBackColor = false;
            btnInsertKH.Click += iconButton3_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 76, 32);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.Transparent;
            btnReset.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            btnReset.IconColor = Color.White;
            btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReset.IconSize = 32;
            btnReset.Location = new Point(452, 40);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(57, 32);
            btnReset.TabIndex = 3;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 76, 32);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.Transparent;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearch.IconColor = Color.White;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 32;
            btnSearch.Location = new Point(389, 40);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(57, 32);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchInfo
            // 
            txtSearchInfo.Location = new Point(1, 33);
            txtSearchInfo.Margin = new Padding(3, 2, 3, 2);
            txtSearchInfo.Name = "txtSearchInfo";
            txtSearchInfo.Size = new Size(382, 34);
            txtSearchInfo.StateActive.Back.Color1 = Color.White;
            txtSearchInfo.StateActive.Border.Color1 = Color.White;
            txtSearchInfo.StateActive.Border.Color2 = Color.White;
            txtSearchInfo.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSearchInfo.StateActive.Border.Rounding = 10F;
            txtSearchInfo.StateActive.Border.Width = 0;
            txtSearchInfo.StateActive.Content.Color1 = Color.DarkGray;
            txtSearchInfo.StateActive.Content.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchInfo.TabIndex = 1;
            txtSearchInfo.TextChanged += kryptonTextBox1_TextChanged;
            // 
            // dgvCustomer
            // 
            dgvCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.ColumnHeadersHeight = 36;
            dgvCustomer.Location = new Point(0, 74);
            dgvCustomer.Margin = new Padding(3, 2, 3, 2);
            dgvCustomer.MultiSelect = false;
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.Size = new Size(1004, 456);
            dgvCustomer.TabIndex = 1;
            dgvCustomer.CellDoubleClick += dgvCustomer_CellDoubleClick;
            // 
            // fKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 244, 255);
            ClientSize = new Size(1004, 530);
            Controls.Add(dgvCustomer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "fKhachHang";
            Text = "fKhachHang";
            Load += fKhachHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Krypton.Toolkit.KryptonTextBox txtSearchInfo;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnInsertKH;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton btnSearch;
        private Label label2;
        private Label label1;
        private Krypton.Toolkit.KryptonDataGridView dgvCustomer;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}