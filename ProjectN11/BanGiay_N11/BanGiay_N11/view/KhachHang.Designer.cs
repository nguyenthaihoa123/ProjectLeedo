namespace BanGiay_N11
{
    partial class KhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateCus = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.txtSexCustomer = new System.Windows.Forms.TextBox();
            this.txtNumberCustomer = new System.Windows.Forms.TextBox();
            this.txtAddCustomer = new System.Windows.Forms.TextBox();
            this.dtBirthCustomer = new System.Windows.Forms.DateTimePicker();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmailCus = new System.Windows.Forms.TextBox();
            this.txtPwdCus = new System.Windows.Forms.TextBox();
            this.txtVoucher = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDeleteCus = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 434);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(387, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(450, 41);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thay đổi thông tin khách hàng";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdateCus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearchCustomer, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNameCustomer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSexCustomer, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNumberCustomer, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAddCustomer, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtBirthCustomer, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtIdCustomer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEmailCus, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPwdCus, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtVoucher, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteCus, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(76, 42);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 374);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(588, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên KH";
            // 
            // btnUpdateCus
            // 
            this.btnUpdateCus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateCus.BackColor = System.Drawing.Color.Snow;
            this.btnUpdateCus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateCus.Location = new System.Drawing.Point(620, 2);
            this.btnUpdateCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateCus.Name = "btnUpdateCus";
            this.btnUpdateCus.Size = new System.Drawing.Size(143, 36);
            this.btnUpdateCus.TabIndex = 20;
            this.btnUpdateCus.Text = "Cập nhật\r\n";
            this.btnUpdateCus.UseVisualStyleBackColor = false;
            this.btnUpdateCus.Click += new System.EventHandler(this.btnUpdateCus_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchCustomer.BackColor = System.Drawing.Color.Snow;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchCustomer.Location = new System.Drawing.Point(883, 2);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(99, 36);
            this.btnSearchCustomer.TabIndex = 19;
            this.btnSearchCustomer.Text = "Tìm";
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(588, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(3, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(3, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNameCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCustomer.Location = new System.Drawing.Point(216, 43);
            this.txtNameCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(260, 34);
            this.txtNameCustomer.TabIndex = 13;
            // 
            // txtSexCustomer
            // 
            this.txtSexCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSexCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexCustomer.Location = new System.Drawing.Point(216, 126);
            this.txtSexCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSexCustomer.Name = "txtSexCustomer";
            this.txtSexCustomer.Size = new System.Drawing.Size(260, 34);
            this.txtSexCustomer.TabIndex = 14;
            // 
            // txtNumberCustomer
            // 
            this.txtNumberCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNumberCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberCustomer.Location = new System.Drawing.Point(801, 43);
            this.txtNumberCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumberCustomer.Name = "txtNumberCustomer";
            this.txtNumberCustomer.Size = new System.Drawing.Size(263, 34);
            this.txtNumberCustomer.TabIndex = 16;
            // 
            // txtAddCustomer
            // 
            this.txtAddCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCustomer.Location = new System.Drawing.Point(801, 126);
            this.txtAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddCustomer.Name = "txtAddCustomer";
            this.txtAddCustomer.Size = new System.Drawing.Size(263, 34);
            this.txtAddCustomer.TabIndex = 17;
            // 
            // dtBirthCustomer
            // 
            this.dtBirthCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthCustomer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthCustomer.Location = new System.Drawing.Point(216, 209);
            this.dtBirthCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtBirthCustomer.Name = "dtBirthCustomer";
            this.dtBirthCustomer.Size = new System.Drawing.Size(200, 34);
            this.dtBirthCustomer.TabIndex = 18;
            // 
            // txtIdCustomer
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtIdCustomer, 2);
            this.txtIdCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIdCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCustomer.Location = new System.Drawing.Point(216, 2);
            this.txtIdCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(366, 34);
            this.txtIdCustomer.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 207);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Email";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtEmailCus
            // 
            this.txtEmailCus.Location = new System.Drawing.Point(802, 211);
            this.txtEmailCus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailCus.Name = "txtEmailCus";
            this.txtEmailCus.Size = new System.Drawing.Size(252, 30);
            this.txtEmailCus.TabIndex = 22;
            // 
            // txtPwdCus
            // 
            this.txtPwdCus.Location = new System.Drawing.Point(217, 294);
            this.txtPwdCus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPwdCus.Name = "txtPwdCus";
            this.txtPwdCus.Size = new System.Drawing.Size(248, 30);
            this.txtPwdCus.TabIndex = 23;
            // 
            // txtVoucher
            // 
            this.txtVoucher.Location = new System.Drawing.Point(802, 294);
            this.txtVoucher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.Size = new System.Drawing.Size(252, 30);
            this.txtVoucher.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 290);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Mật khẩu";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(589, 290);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "Voucher";
            // 
            // btnDeleteCus
            // 
            this.btnDeleteCus.Location = new System.Drawing.Point(483, 45);
            this.btnDeleteCus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteCus.Name = "btnDeleteCus";
            this.btnDeleteCus.Size = new System.Drawing.Size(98, 28);
            this.btnDeleteCus.TabIndex = 12;
            this.btnDeleteCus.Text = "Delete";
            this.btnDeleteCus.UseVisualStyleBackColor = true;
            this.btnDeleteCus.Click += new System.EventHandler(this.btnDeleteCus_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 452);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(1239, 208);
            this.dgvKhachHang.TabIndex = 1;
            this.dgvKhachHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellDoubleClick);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1239, 660);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.TextBox txtSexCustomer;
        private System.Windows.Forms.TextBox txtNumberCustomer;
        private System.Windows.Forms.TextBox txtAddCustomer;
        private System.Windows.Forms.DateTimePicker dtBirthCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnUpdateCus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmailCus;
        private System.Windows.Forms.TextBox txtPwdCus;
        private System.Windows.Forms.TextBox txtVoucher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDeleteCus;
    }
}