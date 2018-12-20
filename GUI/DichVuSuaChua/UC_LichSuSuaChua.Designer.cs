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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvLichSu = new System.Windows.Forms.DataGridView();
            this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HieuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvChiTietSuaChua = new System.Windows.Forms.DataGridView();
            this.LoaiDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuTung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrBoxChiTiet = new System.Windows.Forms.GroupBox();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietSuaChua)).BeginInit();
            this.GrBoxChiTiet.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLichSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLichSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KhachHang,
            this.HieuXe,
            this.BienSo,
            this.NgayVao,
            this.NgayXuat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvLichSu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvLichSu.Location = new System.Drawing.Point(14, 87);
            this.dtgvLichSu.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvLichSu.MultiSelect = false;
            this.dtgvLichSu.Name = "dtgvLichSu";
            this.dtgvLichSu.ReadOnly = true;
            this.dtgvLichSu.RowHeadersVisible = false;
            this.dtgvLichSu.RowTemplate.Height = 24;
            this.dtgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLichSu.Size = new System.Drawing.Size(532, 494);
            this.dtgvLichSu.TabIndex = 2;
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
            // NgayVao
            // 
            this.NgayVao.HeaderText = "Ngày vào";
            this.NgayVao.Name = "NgayVao";
            this.NgayVao.ReadOnly = true;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvChiTietSuaChua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvChiTietSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietSuaChua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiDichVu,
            this.PhuTung,
            this.SoLuong,
            this.DonGia});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvChiTietSuaChua.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvChiTietSuaChua.Location = new System.Drawing.Point(551, 87);
            this.dtgvChiTietSuaChua.MultiSelect = false;
            this.dtgvChiTietSuaChua.Name = "dtgvChiTietSuaChua";
            this.dtgvChiTietSuaChua.ReadOnly = true;
            this.dtgvChiTietSuaChua.RowHeadersVisible = false;
            this.dtgvChiTietSuaChua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChiTietSuaChua.Size = new System.Drawing.Size(437, 306);
            this.dtgvChiTietSuaChua.TabIndex = 3;
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
            this.GrBoxChiTiet.Controls.Add(this.txbTongTien);
            this.GrBoxChiTiet.Controls.Add(this.label2);
            this.GrBoxChiTiet.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrBoxChiTiet.Location = new System.Drawing.Point(551, 409);
            this.GrBoxChiTiet.Name = "GrBoxChiTiet";
            this.GrBoxChiTiet.Size = new System.Drawing.Size(436, 171);
            this.GrBoxChiTiet.TabIndex = 4;
            this.GrBoxChiTiet.TabStop = false;
            this.GrBoxChiTiet.Text = "Thông tin chi tiết";
            // 
            // txbTongTien
            // 
            this.txbTongTien.Location = new System.Drawing.Point(178, 26);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(130, 26);
            this.txbTongTien.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đến";
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(79, 23);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(105, 26);
            this.dtFrom.TabIndex = 0;
            // 
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(244, 23);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(105, 26);
            this.dtTo.TabIndex = 1;
            // 
            // UC_LichSuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrBoxChiTiet);
            this.Controls.Add(this.dtgvChiTietSuaChua);
            this.Controls.Add(this.dtgvLichSu);
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
        private System.Windows.Forms.DataGridView dtgvLichSu;
        private System.Windows.Forms.DataGridView dtgvChiTietSuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuTung;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.GroupBox GrBoxChiTiet;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HieuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
    }
}
