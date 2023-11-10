namespace wfLeedo.view.dialog
{
    partial class dialogInsertHoaDon
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
            txtInsertSdtHD = new TextBox();
            btnInsertWithCus = new Krypton.Toolkit.KryptonButton();
            btnInsertVangLai = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // txtInsertSdtHD
            // 
            txtInsertSdtHD.Location = new Point(59, 53);
            txtInsertSdtHD.Name = "txtInsertSdtHD";
            txtInsertSdtHD.PlaceholderText = "Nhập số điện thoại";
            txtInsertSdtHD.Size = new Size(194, 23);
            txtInsertSdtHD.TabIndex = 0;
            // 
            // btnInsertWithCus
            // 
            btnInsertWithCus.CornerRoundingRadius = -1F;
            btnInsertWithCus.Location = new Point(40, 150);
            btnInsertWithCus.Name = "btnInsertWithCus";
            btnInsertWithCus.Size = new Size(90, 25);
            btnInsertWithCus.TabIndex = 1;
            btnInsertWithCus.Values.Text = "Thêm";
            btnInsertWithCus.Click += btnInsertWithCus_Click;
            // 
            // btnInsertVangLai
            // 
            btnInsertVangLai.CornerRoundingRadius = -1F;
            btnInsertVangLai.Location = new Point(163, 150);
            btnInsertVangLai.Name = "btnInsertVangLai";
            btnInsertVangLai.Size = new Size(90, 25);
            btnInsertVangLai.TabIndex = 2;
            btnInsertVangLai.Values.Text = "Vãng lai";
            btnInsertVangLai.Click += btnInsertVangLai_Click;
            // 
            // dialogInsertHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 281);
            Controls.Add(btnInsertVangLai);
            Controls.Add(btnInsertWithCus);
            Controls.Add(txtInsertSdtHD);
            Name = "dialogInsertHoaDon";
            Text = "dialogInsertHoaDon";
            Load += dialogInsertHoaDon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInsertSdtHD;
        private Krypton.Toolkit.KryptonButton btnInsertWithCus;
        private Krypton.Toolkit.KryptonButton btnInsertVangLai;
    }
}