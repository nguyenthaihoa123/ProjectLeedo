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
            txtInsertSdtHD.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtInsertSdtHD.Location = new Point(33, 76);
            txtInsertSdtHD.Margin = new Padding(3, 4, 3, 4);
            txtInsertSdtHD.Name = "txtInsertSdtHD";
            txtInsertSdtHD.PlaceholderText = "Nhập số điện thoại";
            txtInsertSdtHD.Size = new Size(256, 38);
            txtInsertSdtHD.TabIndex = 0;
            // 
            // btnInsertWithCus
            // 
            btnInsertWithCus.CornerRoundingRadius = 10F;
            btnInsertWithCus.Location = new Point(33, 200);
            btnInsertWithCus.Margin = new Padding(3, 4, 3, 4);
            btnInsertWithCus.Name = "btnInsertWithCus";
            btnInsertWithCus.Size = new Size(115, 52);
            btnInsertWithCus.StateCommon.Back.Color1 = Color.Blue;
            btnInsertWithCus.StateCommon.Back.Color2 = Color.Blue;
            btnInsertWithCus.StateCommon.Border.Color1 = Color.FromArgb(128, 128, 255);
            btnInsertWithCus.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnInsertWithCus.StateCommon.Border.Rounding = 10F;
            btnInsertWithCus.StateCommon.Border.Width = 5;
            btnInsertWithCus.StateCommon.Content.ShortText.Color1 = Color.White;
            btnInsertWithCus.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertWithCus.TabIndex = 8;
            btnInsertWithCus.Values.Text = "Thêm";
            btnInsertWithCus.Click += btnInsertWithCus_Click;
            // 
            // btnInsertVangLai
            // 
            btnInsertVangLai.CornerRoundingRadius = 10F;
            btnInsertVangLai.Location = new Point(174, 200);
            btnInsertVangLai.Margin = new Padding(3, 4, 3, 4);
            btnInsertVangLai.Name = "btnInsertVangLai";
            btnInsertVangLai.Size = new Size(115, 52);
            btnInsertVangLai.StateCommon.Back.Color1 = Color.White;
            btnInsertVangLai.StateCommon.Back.Color2 = Color.White;
            btnInsertVangLai.StateCommon.Border.Color1 = Color.Blue;
            btnInsertVangLai.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnInsertVangLai.StateCommon.Border.Rounding = 10F;
            btnInsertVangLai.StateCommon.Border.Width = 5;
            btnInsertVangLai.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertVangLai.TabIndex = 9;
            btnInsertVangLai.Values.Text = "Vãng lai";
            btnInsertVangLai.Click += btnInsertVangLai_Click;
            // 
            // dialogInsertHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 375);
            Controls.Add(btnInsertVangLai);
            Controls.Add(btnInsertWithCus);
            Controls.Add(txtInsertSdtHD);
            Margin = new Padding(3, 4, 3, 4);
            Name = "dialogInsertHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm hóa đơn";
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