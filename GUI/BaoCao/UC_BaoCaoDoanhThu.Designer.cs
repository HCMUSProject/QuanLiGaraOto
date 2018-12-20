namespace GUI.BaoCao
{
    partial class UC_BaoCaoDoanhThu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.dtgvTienNhapVatTu = new System.Windows.Forms.DataGridView();
            this.HangSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvTienPhiSuaChua = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuatHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDoanhThu = new System.Windows.Forms.Label();
            this.lbTongTienNhapVatTu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnXuatExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTienNhapVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTienPhiSuaChua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm";
            // 
            // cmbThang
            // 
            this.cmbThang.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Location = new System.Drawing.Point(86, 24);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(40, 27);
            this.cmbThang.TabIndex = 0;
            // 
            // cmbNam
            // 
            this.cmbNam.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Location = new System.Drawing.Point(198, 24);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(77, 27);
            this.cmbNam.TabIndex = 1;
            // 
            // dtgvTienNhapVatTu
            // 
            this.dtgvTienNhapVatTu.AllowUserToAddRows = false;
            this.dtgvTienNhapVatTu.AllowUserToDeleteRows = false;
            this.dtgvTienNhapVatTu.AllowUserToResizeRows = false;
            this.dtgvTienNhapVatTu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvTienNhapVatTu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTienNhapVatTu.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTienNhapVatTu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTienNhapVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTienNhapVatTu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HangSanXuat,
            this.VatTu,
            this.SoLuong,
            this.NgayNhap,
            this.TongTien});
            this.dtgvTienNhapVatTu.Location = new System.Drawing.Point(18, 99);
            this.dtgvTienNhapVatTu.MultiSelect = false;
            this.dtgvTienNhapVatTu.Name = "dtgvTienNhapVatTu";
            this.dtgvTienNhapVatTu.ReadOnly = true;
            this.dtgvTienNhapVatTu.RowHeadersVisible = false;
            this.dtgvTienNhapVatTu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTienNhapVatTu.Size = new System.Drawing.Size(546, 483);
            this.dtgvTienNhapVatTu.TabIndex = 5;
            // 
            // HangSanXuat
            // 
            this.HangSanXuat.HeaderText = "Hãng sản xuất";
            this.HangSanXuat.Name = "HangSanXuat";
            this.HangSanXuat.ReadOnly = true;
            // 
            // VatTu
            // 
            this.VatTu.HeaderText = "Vật tư";
            this.VatTu.Name = "VatTu";
            this.VatTu.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // dtgvTienPhiSuaChua
            // 
            this.dtgvTienPhiSuaChua.AllowUserToAddRows = false;
            this.dtgvTienPhiSuaChua.AllowUserToDeleteRows = false;
            this.dtgvTienPhiSuaChua.AllowUserToResizeRows = false;
            this.dtgvTienPhiSuaChua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvTienPhiSuaChua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTienPhiSuaChua.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTienPhiSuaChua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTienPhiSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTienPhiSuaChua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.NgayXuatHoaDon,
            this.ThanhTien});
            this.dtgvTienPhiSuaChua.Location = new System.Drawing.Point(582, 99);
            this.dtgvTienPhiSuaChua.MultiSelect = false;
            this.dtgvTienPhiSuaChua.Name = "dtgvTienPhiSuaChua";
            this.dtgvTienPhiSuaChua.ReadOnly = true;
            this.dtgvTienPhiSuaChua.RowHeadersVisible = false;
            this.dtgvTienPhiSuaChua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTienPhiSuaChua.Size = new System.Drawing.Size(403, 314);
            this.dtgvTienPhiSuaChua.TabIndex = 5;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.HeaderText = "Mã hóa đơn";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.ReadOnly = true;
            // 
            // NgayXuatHoaDon
            // 
            this.NgayXuatHoaDon.HeaderText = "Ngày xuất hóa đơn";
            this.NgayXuatHoaDon.Name = "NgayXuatHoaDon";
            this.NgayXuatHoaDon.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bảng nhập vật tư";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(578, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bảng sửa chữa";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbDoanhThu);
            this.groupBox1.Controls.Add(this.lbTongTienNhapVatTu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(582, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 163);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // lbDoanhThu
            // 
            this.lbDoanhThu.Location = new System.Drawing.Point(139, 97);
            this.lbDoanhThu.Name = "lbDoanhThu";
            this.lbDoanhThu.Size = new System.Drawing.Size(132, 39);
            this.lbDoanhThu.TabIndex = 3;
            this.lbDoanhThu.Text = "0";
            this.lbDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTongTienNhapVatTu
            // 
            this.lbTongTienNhapVatTu.Location = new System.Drawing.Point(139, 38);
            this.lbTongTienNhapVatTu.Name = "lbTongTienNhapVatTu";
            this.lbTongTienNhapVatTu.Size = new System.Drawing.Size(132, 39);
            this.lbTongTienNhapVatTu.TabIndex = 2;
            this.lbTongTienNhapVatTu.Text = "0";
            this.lbTongTienNhapVatTu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 39);
            this.label6.TabIndex = 1;
            this.label6.Text = "Doanh thu:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng phí nhập vật tư:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnXuatExcel
            // 
            this.BtnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnXuatExcel.AutoSize = true;
            this.BtnXuatExcel.Location = new System.Drawing.Point(898, 428);
            this.BtnXuatExcel.Name = "BtnXuatExcel";
            this.BtnXuatExcel.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnXuatExcel.Size = new System.Drawing.Size(87, 34);
            this.BtnXuatExcel.TabIndex = 2;
            this.BtnXuatExcel.Text = "Xuất Excel";
            this.BtnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // UC_BaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.BtnXuatExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgvTienPhiSuaChua);
            this.Controls.Add(this.dtgvTienNhapVatTu);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_BaoCaoDoanhThu";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTienNhapVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTienPhiSuaChua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.DataGridView dtgvTienNhapVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridView dtgvTienPhiSuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuatHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDoanhThu;
        private System.Windows.Forms.Label lbTongTienNhapVatTu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnXuatExcel;
    }
}
