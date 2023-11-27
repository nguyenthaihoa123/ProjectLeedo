namespace wfLeedo.view
{
    partial class modifyDonHang
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvModiBill = new Krypton.Toolkit.KryptonDataGridView();
            label1 = new Label();
            lbIDDH = new Krypton.Toolkit.KryptonLabel();
            label2 = new Label();
            lbNameKH = new Krypton.Toolkit.KryptonLabel();
            label3 = new Label();
            lbTongBill = new Krypton.Toolkit.KryptonLabel();
            btnSaveModiBill = new Krypton.Toolkit.KryptonButton();
            label4 = new Label();
            cbbStatus = new Krypton.Toolkit.KryptonComboBox();
            printBill = new System.Drawing.Printing.PrintDocument();
            btnPrint = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvModiBill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbbStatus).BeginInit();
            SuspendLayout();
            // 
            // dgvModiBill
            // 
            dgvModiBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvModiBill.ColumnHeadersHeight = 36;
            dgvModiBill.Location = new Point(14, 225);
            dgvModiBill.Margin = new Padding(3, 4, 3, 4);
            dgvModiBill.MultiSelect = false;
            dgvModiBill.Name = "dgvModiBill";
            dgvModiBill.ReadOnly = true;
            dgvModiBill.RowHeadersWidth = 51;
            dgvModiBill.RowTemplate.Height = 25;
            dgvModiBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModiBill.Size = new Size(433, 309);
            dgvModiBill.TabIndex = 0;
            dgvModiBill.CellDoubleClick += dgvModiBill_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Đơn hàng:";
            // 
            // lbIDDH
            // 
            lbIDDH.Location = new Point(112, 23);
            lbIDDH.Margin = new Padding(3, 4, 3, 4);
            lbIDDH.Name = "lbIDDH";
            lbIDDH.Size = new Size(6, 2);
            lbIDDH.TabIndex = 2;
            lbIDDH.Values.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 67);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên KH:";
            // 
            // lbNameKH
            // 
            lbNameKH.Location = new Point(95, 67);
            lbNameKH.Margin = new Padding(3, 4, 3, 4);
            lbNameKH.Name = "lbNameKH";
            lbNameKH.Size = new Size(6, 2);
            lbNameKH.TabIndex = 4;
            lbNameKH.Values.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 99);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 5;
            label3.Text = "Tổng tiền:";
            // 
            // lbTongBill
            // 
            lbTongBill.Location = new Point(110, 97);
            lbTongBill.Margin = new Padding(3, 4, 3, 4);
            lbTongBill.Name = "lbTongBill";
            lbTongBill.Size = new Size(6, 2);
            lbTongBill.TabIndex = 6;
            lbTongBill.Values.Text = "";
            // 
            // btnSaveModiBill
            // 
            btnSaveModiBill.CornerRoundingRadius = 10F;
            btnSaveModiBill.Location = new Point(136, 573);
            btnSaveModiBill.Margin = new Padding(3, 4, 3, 4);
            btnSaveModiBill.Name = "btnSaveModiBill";
            btnSaveModiBill.Size = new Size(190, 51);
            btnSaveModiBill.StateCommon.Back.Color1 = Color.White;
            btnSaveModiBill.StateCommon.Back.Color2 = Color.White;
            btnSaveModiBill.StateCommon.Border.Color1 = Color.Blue;
            btnSaveModiBill.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSaveModiBill.StateCommon.Border.Rounding = 10F;
            btnSaveModiBill.StateCommon.Border.Width = 5;
            btnSaveModiBill.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveModiBill.TabIndex = 7;
            btnSaveModiBill.Values.Text = "Lưu";
            btnSaveModiBill.Click += btnSaveModiBill_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 135);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 8;
            label4.Text = "Trạng thái: ";
            // 
            // cbbStatus
            // 
            cbbStatus.CornerRoundingRadius = -1F;
            cbbStatus.DropDownWidth = 121;
            cbbStatus.IntegralHeight = false;
            cbbStatus.Items.AddRange(new object[] { "Chuẩn bị", "Đang giao", "Đã giao" });
            cbbStatus.Location = new Point(115, 135);
            cbbStatus.Margin = new Padding(3, 4, 3, 4);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new Size(138, 25);
            cbbStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbbStatus.TabIndex = 9;
            cbbStatus.Text = "Chuẩn bị";
            // 
            // printBill
            // 
            printBill.PrintPage += printBill_PrintPage;
            // 
            // btnPrint
            // 
            btnPrint.BorderColor = Color.White;
            btnPrint.BorderRadius = 10;
            btnPrint.BorderThickness = 5;
            btnPrint.CustomizableEdges = customizableEdges1;
            btnPrint.DisabledState.BorderColor = Color.DarkGray;
            btnPrint.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPrint.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPrint.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.White;
            btnPrint.Image = Properties.Resources.printing;
            btnPrint.Location = new Point(323, 23);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnPrint.Size = new Size(124, 49);
            btnPrint.TabIndex = 10;
            btnPrint.Text = "In Hóa đơn";
            btnPrint.Click += btnPrint_Click;
            // 
            // modifyDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 643);
            Controls.Add(btnPrint);
            Controls.Add(cbbStatus);
            Controls.Add(label4);
            Controls.Add(btnSaveModiBill);
            Controls.Add(lbTongBill);
            Controls.Add(label3);
            Controls.Add(lbNameKH);
            Controls.Add(label2);
            Controls.Add(lbIDDH);
            Controls.Add(label1);
            Controls.Add(dgvModiBill);
            Margin = new Padding(3, 4, 3, 4);
            Name = "modifyDonHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin đơn hàng";
            Load += modifyDonHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvModiBill).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbbStatus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvModiBill;
        private Label label1;
        private Krypton.Toolkit.KryptonLabel lbIDDH;
        private Label label2;
        private Krypton.Toolkit.KryptonLabel lbNameKH;
        private Label label3;
        private Krypton.Toolkit.KryptonLabel lbTongBill;
        private Krypton.Toolkit.KryptonButton btnSaveModiBill;
        private Label label4;
        private Krypton.Toolkit.KryptonComboBox cbbStatus;
        private System.Drawing.Printing.PrintDocument printBill;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
    }
}