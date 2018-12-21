namespace GUI.DichVuSuaChua
{
    partial class UC_ThanhToan
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
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnThanhToan = new System.Windows.Forms.Button();
            this.dtgvChiTietSuaChua = new System.Windows.Forms.DataGridView();
            this.LoaiDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuTung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.txbDienThoai = new System.Windows.Forms.TextBox();
            this.txbMaPhieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbHieuXe = new System.Windows.Forms.TextBox();
            this.txbNhanVien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpkNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.cmbBienSoXe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietSuaChua)).BeginInit();
            this.SuspendLayout();
            // 
            // txbTongTien
            // 
            this.txbTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTongTien.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongTien.Location = new System.Drawing.Point(819, 491);
            this.txbTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(169, 26);
            this.txbTongTien.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(717, 494);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tổng tiền";
            // 
            // BtnThanhToan
            // 
            this.BtnThanhToan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnThanhToan.AutoSize = true;
            this.BtnThanhToan.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThanhToan.Location = new System.Drawing.Point(449, 521);
            this.BtnThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.BtnThanhToan.Name = "BtnThanhToan";
            this.BtnThanhToan.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnThanhToan.Size = new System.Drawing.Size(119, 33);
            this.BtnThanhToan.TabIndex = 21;
            this.BtnThanhToan.Text = "Thanh toán";
            this.BtnThanhToan.UseVisualStyleBackColor = true;
            // 
            // dtgvChiTietSuaChua
            // 
            this.dtgvChiTietSuaChua.AllowUserToAddRows = false;
            this.dtgvChiTietSuaChua.AllowUserToDeleteRows = false;
            this.dtgvChiTietSuaChua.AllowUserToResizeRows = false;
            this.dtgvChiTietSuaChua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvChiTietSuaChua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChiTietSuaChua.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvChiTietSuaChua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvChiTietSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietSuaChua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiDichVu,
            this.PhuTung,
            this.SoLuong,
            this.GiaTien});
            this.dtgvChiTietSuaChua.Location = new System.Drawing.Point(319, 99);
            this.dtgvChiTietSuaChua.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvChiTietSuaChua.MultiSelect = false;
            this.dtgvChiTietSuaChua.Name = "dtgvChiTietSuaChua";
            this.dtgvChiTietSuaChua.ReadOnly = true;
            this.dtgvChiTietSuaChua.RowHeadersVisible = false;
            this.dtgvChiTietSuaChua.RowTemplate.Height = 24;
            this.dtgvChiTietSuaChua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChiTietSuaChua.Size = new System.Drawing.Size(668, 374);
            this.dtgvChiTietSuaChua.TabIndex = 22;
            // 
            // LoaiDichVu
            // 
            this.LoaiDichVu.HeaderText = "Loại dịch vụ";
            this.LoaiDichVu.Name = "LoaiDichVu";
            this.LoaiDichVu.ReadOnly = true;
            this.LoaiDichVu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PhuTung
            // 
            this.PhuTung.HeaderText = "Phụ tùng";
            this.PhuTung.Name = "PhuTung";
            this.PhuTung.ReadOnly = true;
            this.PhuTung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // GiaTien
            // 
            this.GiaTien.HeaderText = "Đơn giá";
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.Font = new System.Drawing.Font("Consolas", 12F);
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(130, 126);
            this.cmbKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(172, 27);
            this.cmbKhachHang.TabIndex = 16;
            // 
            // txbDienThoai
            // 
            this.txbDienThoai.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDienThoai.Location = new System.Drawing.Point(130, 193);
            this.txbDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.txbDienThoai.Name = "txbDienThoai";
            this.txbDienThoai.ReadOnly = true;
            this.txbDienThoai.Size = new System.Drawing.Size(172, 26);
            this.txbDienThoai.TabIndex = 17;
            // 
            // txbMaPhieu
            // 
            this.txbMaPhieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbMaPhieu.Font = new System.Drawing.Font("Consolas", 12F);
            this.txbMaPhieu.Location = new System.Drawing.Point(409, 46);
            this.txbMaPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.txbMaPhieu.Name = "txbMaPhieu";
            this.txbMaPhieu.ReadOnly = true;
            this.txbMaPhieu.Size = new System.Drawing.Size(288, 26);
            this.txbMaPhieu.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Consolas", 12F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(16, 353);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 41);
            this.label8.TabIndex = 29;
            this.label8.Text = "Nhân viên sửa chữa";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 12F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(13, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Biển số xe";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 12F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(13, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Điện thoại";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(13, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Hiệu xe";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 48);
            this.label4.TabIndex = 25;
            this.label4.Text = "Khách hàng - CMND";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(315, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã phiếu";
            // 
            // txbHieuXe
            // 
            this.txbHieuXe.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHieuXe.Location = new System.Drawing.Point(130, 246);
            this.txbHieuXe.Margin = new System.Windows.Forms.Padding(2);
            this.txbHieuXe.Name = "txbHieuXe";
            this.txbHieuXe.ReadOnly = true;
            this.txbHieuXe.Size = new System.Drawing.Size(172, 26);
            this.txbHieuXe.TabIndex = 32;
            // 
            // txbNhanVien
            // 
            this.txbNhanVien.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNhanVien.Location = new System.Drawing.Point(130, 360);
            this.txbNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.txbNhanVien.Name = "txbNhanVien";
            this.txbNhanVien.ReadOnly = true;
            this.txbNhanVien.Size = new System.Drawing.Size(172, 26);
            this.txbNhanVien.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Consolas", 12F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(16, 416);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 41);
            this.label7.TabIndex = 35;
            this.label7.Text = "Ngày thanh toán";
            // 
            // dtpkNgayThanhToan
            // 
            this.dtpkNgayThanhToan.CalendarFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayThanhToan.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayThanhToan.Location = new System.Drawing.Point(130, 426);
            this.dtpkNgayThanhToan.Name = "dtpkNgayThanhToan";
            this.dtpkNgayThanhToan.Size = new System.Drawing.Size(172, 26);
            this.dtpkNgayThanhToan.TabIndex = 36;
            // 
            // cmbBienSoXe
            // 
            this.cmbBienSoXe.Font = new System.Drawing.Font("Consolas", 12F);
            this.cmbBienSoXe.FormattingEnabled = true;
            this.cmbBienSoXe.Location = new System.Drawing.Point(130, 297);
            this.cmbBienSoXe.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBienSoXe.Name = "cmbBienSoXe";
            this.cmbBienSoXe.Size = new System.Drawing.Size(172, 27);
            this.cmbBienSoXe.TabIndex = 37;
            // 
            // UC_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.cmbBienSoXe);
            this.Controls.Add(this.dtpkNgayThanhToan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbNhanVien);
            this.Controls.Add(this.txbHieuXe);
            this.Controls.Add(this.txbTongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnThanhToan);
            this.Controls.Add(this.dtgvChiTietSuaChua);
            this.Controls.Add(this.cmbKhachHang);
            this.Controls.Add(this.txbDienThoai);
            this.Controls.Add(this.txbMaPhieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_ThanhToan";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.UC_ThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietSuaChua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnThanhToan;
        private System.Windows.Forms.DataGridView dtgvChiTietSuaChua;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.TextBox txbDienThoai;
        private System.Windows.Forms.TextBox txbMaPhieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbHieuXe;
        private System.Windows.Forms.TextBox txbNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuTung;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpkNgayThanhToan;
        private System.Windows.Forms.ComboBox cmbBienSoXe;
    }
}
