namespace wfLeedo.view
{
    partial class fThongKe
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvthongke = new Guna.UI2.WinForms.Guna2DataGridView();
            Month = new DataGridViewTextBoxColumn();
            Money = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvthongke).BeginInit();
            SuspendLayout();
            // 
            // dgvthongke
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvthongke.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvthongke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvthongke.ColumnHeadersHeight = 4;
            dgvthongke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvthongke.Columns.AddRange(new DataGridViewColumn[] { Month, Money });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvthongke.DefaultCellStyle = dataGridViewCellStyle3;
            dgvthongke.GridColor = Color.FromArgb(231, 229, 255);
            dgvthongke.Location = new Point(12, 136);
            dgvthongke.Name = "dgvthongke";
            dgvthongke.RowHeadersVisible = false;
            dgvthongke.RowTemplate.Height = 25;
            dgvthongke.Size = new Size(738, 330);
            dgvthongke.TabIndex = 0;
            dgvthongke.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvthongke.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvthongke.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvthongke.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvthongke.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvthongke.ThemeStyle.BackColor = Color.White;
            dgvthongke.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvthongke.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvthongke.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvthongke.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvthongke.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvthongke.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvthongke.ThemeStyle.HeaderStyle.Height = 4;
            dgvthongke.ThemeStyle.ReadOnly = false;
            dgvthongke.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvthongke.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvthongke.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvthongke.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvthongke.ThemeStyle.RowsStyle.Height = 25;
            dgvthongke.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvthongke.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Month
            // 
            Month.DataPropertyName = "Thang";
            Month.HeaderText = "Tháng";
            Month.Name = "Month";
            // 
            // Money
            // 
            Money.DataPropertyName = "ChiTieu";
            Money.HeaderText = "Tiền";
            Money.Name = "Money";
            // 
            // fThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(762, 478);
            Controls.Add(dgvthongke);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "fThongKe";
            Text = "fThongKe";
            Load += fThongKe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvthongke).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvthongke;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn Money;
    }
}