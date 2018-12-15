namespace GUI.DichVuSuaChua
{
    partial class UC_LichSuSuaChua
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
            this.cmbXemTheo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvLichSu = new System.Windows.Forms.DataGridView();
            this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HieuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvChiTietSuaChua = new System.Windows.Forms.DataGridView();
            this.LoaiDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuTung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrBoxChiTiet = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.txbTienKhachTra = new System.Windows.Forms.TextBox();
            this.txbTienKhachNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietSuaChua)).BeginInit();
            this.GrBoxChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbXemTheo
            // 
            this.cmbXemTheo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbXemTheo.FormattingEnabled = true;
            this.cmbXemTheo.Location = new System.Drawing.Point(140, 30);
            this.cmbXemTheo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbXemTheo.Name = "cmbXemTheo";
            this.cmbXemTheo.Size = new System.Drawing.Size(139, 27);
            this.cmbXemTheo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xem theo";
            // 
            // dtgvLichSu
            // 
            this.dtgvLichSu.AllowUserToAddRows = false;
            this.dtgvLichSu.AllowUserToDeleteRows = false;
            this.dtgvLichSu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLichSu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLichSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KhachHang,
            this.HieuXe,
            this.BienSo,
            this.NgaySua,
            this.NgayXuat});
            this.dtgvLichSu.Location = new System.Drawing.Point(14, 87);
            this.dtgvLichSu.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvLichSu.Name = "dtgvLichSu";
            this.dtgvLichSu.ReadOnly = true;
            this.dtgvLichSu.RowHeadersVisible = false;
            this.dtgvLichSu.RowTemplate.Height = 24;
            this.dtgvLichSu.Size = new System.Drawing.Size(532, 494);
            this.dtgvLichSu.TabIndex = 1;
            // 
            // KhachHang
            // 
            this.KhachHang.HeaderText = "Khách hàng";
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.ReadOnly = true;
            // 
            // HieuXe
            // 
            this.HieuXe.HeaderText = "Hiệu xe";
            this.HieuXe.Name = "HieuXe";
            this.HieuXe.ReadOnly = true;
            // 
            // BienSo
            // 
            this.BienSo.HeaderText = "Biển Số";
            this.BienSo.Name = "BienSo";
            this.BienSo.ReadOnly = true;
            // 
            // NgaySua
            // 
            this.NgaySua.HeaderText = "Ngày sửa";
            this.NgaySua.Name = "NgaySua";
            this.NgaySua.ReadOnly = true;
            // 
            // NgayXuat
            // 
            this.NgayXuat.HeaderText = "Ngày xuất";
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.ReadOnly = true;
            // 
            // dtgvChiTietSuaChua
            // 
            this.dtgvChiTietSuaChua.AllowUserToAddRows = false;
            this.dtgvChiTietSuaChua.AllowUserToDeleteRows = false;
            this.dtgvChiTietSuaChua.AllowUserToResizeRows = false;
            this.dtgvChiTietSuaChua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvChiTietSuaChua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChiTietSuaChua.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgvChiTietSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietSuaChua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiDichVu,
            this.PhuTung,
            this.SoLuong,
            this.DonGia});
            this.dtgvChiTietSuaChua.Location = new System.Drawing.Point(551, 87);
            this.dtgvChiTietSuaChua.Name = "dtgvChiTietSuaChua";
            this.dtgvChiTietSuaChua.ReadOnly = true;
            this.dtgvChiTietSuaChua.RowHeadersVisible = false;
            this.dtgvChiTietSuaChua.Size = new System.Drawing.Size(437, 254);
            this.dtgvChiTietSuaChua.TabIndex = 2;
            // 
            // LoaiDichVu
            // 
            this.LoaiDichVu.HeaderText = "Loại dịch vụ";
            this.LoaiDichVu.Name = "LoaiDichVu";
            this.LoaiDichVu.ReadOnly = true;
            // 
            // PhuTung
            // 
            this.PhuTung.HeaderText = "Phụ tùng";
            this.PhuTung.Name = "PhuTung";
            this.PhuTung.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // GrBoxChiTiet
            // 
            this.GrBoxChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GrBoxChiTiet.Controls.Add(this.txbTienKhachNo);
            this.GrBoxChiTiet.Controls.Add(this.txbTienKhachTra);
            this.GrBoxChiTiet.Controls.Add(this.txbTongTien);
            this.GrBoxChiTiet.Controls.Add(this.label4);
            this.GrBoxChiTiet.Controls.Add(this.label3);
            this.GrBoxChiTiet.Controls.Add(this.label2);
            this.GrBoxChiTiet.Location = new System.Drawing.Point(551, 361);
            this.GrBoxChiTiet.Name = "GrBoxChiTiet";
            this.GrBoxChiTiet.Size = new System.Drawing.Size(436, 219);
            this.GrBoxChiTiet.TabIndex = 3;
            this.GrBoxChiTiet.TabStop = false;
            this.GrBoxChiTiet.Text = "Thông tin chi tiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiền khách trả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tiền khách nợ:";
            // 
            // txbTongTien
            // 
            this.txbTongTien.Location = new System.Drawing.Point(139, 25);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(130, 20);
            this.txbTongTien.TabIndex = 0;
            // 
            // txbTienKhachTra
            // 
            this.txbTienKhachTra.Location = new System.Drawing.Point(139, 59);
            this.txbTienKhachTra.Name = "txbTienKhachTra";
            this.txbTienKhachTra.ReadOnly = true;
            this.txbTienKhachTra.Size = new System.Drawing.Size(130, 20);
            this.txbTienKhachTra.TabIndex = 1;
            // 
            // txbTienKhachNo
            // 
            this.txbTienKhachNo.Location = new System.Drawing.Point(139, 93);
            this.txbTienKhachNo.Name = "txbTienKhachNo";
            this.txbTienKhachNo.ReadOnly = true;
            this.txbTienKhachNo.Size = new System.Drawing.Size(130, 20);
            this.txbTienKhachNo.TabIndex = 2;
            // 
            // UC_LichSuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.GrBoxChiTiet);
            this.Controls.Add(this.dtgvChiTietSuaChua);
            this.Controls.Add(this.dtgvLichSu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbXemTheo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_LichSuSuaChua";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietSuaChua)).EndInit();
            this.GrBoxChiTiet.ResumeLayout(false);
            this.GrBoxChiTiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbXemTheo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvLichSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HieuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySua;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.DataGridView dtgvChiTietSuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuTung;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.GroupBox GrBoxChiTiet;
        private System.Windows.Forms.TextBox txbTienKhachNo;
        private System.Windows.Forms.TextBox txbTienKhachTra;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
