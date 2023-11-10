namespace wfLeedo
{
    partial class fNhanVien
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
            btnThem = new FontAwesome.Sharp.IconButton();
            btnResetDataEmp = new FontAwesome.Sharp.IconButton();
            btnSearchEmp = new FontAwesome.Sharp.IconButton();
            txtInputInfoEmp = new Krypton.Toolkit.KryptonTextBox();
            dgvEmployee = new Krypton.Toolkit.KryptonDataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconButton4);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnResetDataEmp);
            panel1.Controls.Add(btnSearchEmp);
            panel1.Controls.Add(txtInputInfoEmp);
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
            label1.Location = new Point(742, 20);
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
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(128, 255, 128);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.Transparent;
            btnThem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnThem.IconColor = Color.White;
            btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThem.IconSize = 32;
            btnThem.Location = new Point(561, 40);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(57, 32);
            btnThem.TabIndex = 4;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnResetDataEmp
            // 
            btnResetDataEmp.BackColor = Color.FromArgb(255, 76, 32);
            btnResetDataEmp.FlatAppearance.BorderSize = 0;
            btnResetDataEmp.FlatStyle = FlatStyle.Flat;
            btnResetDataEmp.ForeColor = Color.Transparent;
            btnResetDataEmp.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            btnResetDataEmp.IconColor = Color.White;
            btnResetDataEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnResetDataEmp.IconSize = 32;
            btnResetDataEmp.Location = new Point(481, 40);
            btnResetDataEmp.Margin = new Padding(3, 2, 3, 2);
            btnResetDataEmp.Name = "btnResetDataEmp";
            btnResetDataEmp.Size = new Size(57, 32);
            btnResetDataEmp.TabIndex = 3;
            btnResetDataEmp.UseVisualStyleBackColor = false;
            btnResetDataEmp.Click += btnResetDataEmp_Click;
            // 
            // btnSearchEmp
            // 
            btnSearchEmp.BackColor = Color.FromArgb(255, 76, 32);
            btnSearchEmp.FlatAppearance.BorderSize = 0;
            btnSearchEmp.FlatStyle = FlatStyle.Flat;
            btnSearchEmp.ForeColor = Color.Transparent;
            btnSearchEmp.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearchEmp.IconColor = Color.White;
            btnSearchEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearchEmp.IconSize = 32;
            btnSearchEmp.Location = new Point(419, 40);
            btnSearchEmp.Margin = new Padding(3, 2, 3, 2);
            btnSearchEmp.Name = "btnSearchEmp";
            btnSearchEmp.Size = new Size(57, 32);
            btnSearchEmp.TabIndex = 2;
            btnSearchEmp.UseVisualStyleBackColor = false;
            btnSearchEmp.Click += btnSearchEmp_Click;
            // 
            // txtInputInfoEmp
            // 
            txtInputInfoEmp.Location = new Point(32, 40);
            txtInputInfoEmp.Margin = new Padding(3, 2, 3, 2);
            txtInputInfoEmp.Name = "txtInputInfoEmp";
            txtInputInfoEmp.Size = new Size(382, 34);
            txtInputInfoEmp.StateActive.Back.Color1 = Color.White;
            txtInputInfoEmp.StateActive.Border.Color1 = Color.White;
            txtInputInfoEmp.StateActive.Border.Color2 = Color.White;
            txtInputInfoEmp.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtInputInfoEmp.StateActive.Border.Rounding = 10F;
            txtInputInfoEmp.StateActive.Border.Width = 0;
            txtInputInfoEmp.StateActive.Content.Color1 = Color.DarkGray;
            txtInputInfoEmp.StateActive.Content.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtInputInfoEmp.TabIndex = 1;
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeight = 36;
            dgvEmployee.Dock = DockStyle.Fill;
            dgvEmployee.Location = new Point(0, 74);
            dgvEmployee.Margin = new Padding(3, 2, 3, 2);
            dgvEmployee.MultiSelect = false;
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 29;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(1004, 456);
            dgvEmployee.TabIndex = 1;
            dgvEmployee.CellDoubleClick += dgvEmployee_CellDoubleClick;
            // 
            // fNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 244, 255);
            ClientSize = new Size(1004, 530);
            Controls.Add(dgvEmployee);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "fNhanVien";
            Text = "fNhanVien";
            Load += fNhanVien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Krypton.Toolkit.KryptonTextBox txtInputInfoEmp;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnResetDataEmp;
        private FontAwesome.Sharp.IconButton btnSearchEmp;
        private Label label2;
        private Label label1;
        private Krypton.Toolkit.KryptonDataGridView dgvEmployee;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}