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
            dgvModiBill.Location = new Point(12, 169);
            dgvModiBill.MultiSelect = false;
            dgvModiBill.Name = "dgvModiBill";
            dgvModiBill.ReadOnly = true;
            dgvModiBill.RowHeadersWidth = 51;
            dgvModiBill.RowTemplate.Height = 25;
            dgvModiBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModiBill.Size = new Size(379, 232);
            dgvModiBill.TabIndex = 0;
            dgvModiBill.CellDoubleClick += dgvModiBill_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 17);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Đơn hàng:";
            // 
            // lbIDDH
            // 
            lbIDDH.Location = new Point(98, 17);
            lbIDDH.Name = "lbIDDH";
            lbIDDH.Size = new Size(6, 2);
            lbIDDH.TabIndex = 2;
            lbIDDH.Values.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 50);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Tên KH:";
            // 
            // lbNameKH
            // 
            lbNameKH.Location = new Point(83, 50);
            lbNameKH.Name = "lbNameKH";
            lbNameKH.Size = new Size(6, 2);
            lbNameKH.TabIndex = 4;
            lbNameKH.Values.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 74);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Tổng tiền:";
            // 
            // lbTongBill
            // 
            lbTongBill.Location = new Point(96, 73);
            lbTongBill.Name = "lbTongBill";
            lbTongBill.Size = new Size(6, 2);
            lbTongBill.TabIndex = 6;
            lbTongBill.Values.Text = "";
            // 
            // btnSaveModiBill
            // 
            btnSaveModiBill.CornerRoundingRadius = -1F;
            btnSaveModiBill.Location = new Point(119, 430);
            btnSaveModiBill.Name = "btnSaveModiBill";
            btnSaveModiBill.Size = new Size(166, 38);
            btnSaveModiBill.TabIndex = 7;
            btnSaveModiBill.Values.Text = "Lưu";
            btnSaveModiBill.Click += btnSaveModiBill_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 101);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 8;
            label4.Text = "Trạng thái: ";
            // 
            // cbbStatus
            // 
            cbbStatus.CornerRoundingRadius = -1F;
            cbbStatus.DropDownWidth = 121;
            cbbStatus.IntegralHeight = false;
            cbbStatus.Items.AddRange(new object[] { "Chuẩn bị", "Đang giao", "Đã giao" });
            cbbStatus.Location = new Point(101, 101);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new Size(121, 21);
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
            btnPrint.CustomizableEdges = customizableEdges1;
            btnPrint.DisabledState.BorderColor = Color.DarkGray;
            btnPrint.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPrint.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPrint.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(321, 17);
            btnPrint.Name = "btnPrint";
            btnPrint.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnPrint.Size = new Size(70, 37);
            btnPrint.TabIndex = 10;
            btnPrint.Text = "In Hóa đơn";
            btnPrint.Click += btnPrint_Click;
            // 
            // modifyDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 482);
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
            Name = "modifyDonHang";
            Text = "modifyDonHang";
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