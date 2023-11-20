namespace wfLeedo.view
{
    partial class fSanPham
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
            panelShowProduct = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // panelShowProduct
            // 
            panelShowProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelShowProduct.AutoScroll = true;
            panelShowProduct.Location = new Point(0, 57);
            panelShowProduct.Margin = new Padding(3, 2, 3, 2);
            panelShowProduct.Name = "panelShowProduct";
            panelShowProduct.Padding = new Padding(18, 22, 0, 22);
            panelShowProduct.Size = new Size(1025, 508);
            panelShowProduct.TabIndex = 0;
            panelShowProduct.Scroll += panelShowProduct_Scroll;
            panelShowProduct.Paint += panelShowProduct_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(334, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 37);
            label1.TabIndex = 1;
            label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // fSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(1019, 565);
            Controls.Add(label1);
            Controls.Add(panelShowProduct);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "fSanPham";
            Text = "fSanPham";
            Load += fSanPham_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel panelShowProduct;
        private Label label1;
    }
}