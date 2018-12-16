namespace GUI.DichVuSuaChua
{
    partial class UC_LapPhieuSuaChua
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
            this.dtgvChiTietSuaChua = new System.Windows.Forms.DataGridView();
            this.LoaiDichVu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PhuTung = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbBienSoXe = new System.Windows.Forms.ComboBox();
            this.cmbLoaiXe = new System.Windows.Forms.ComboBox();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.txbNhanVienSuaChua = new System.Windows.Forms.TextBox();
            this.txbDienThoai = new System.Windows.Forms.TextBox();
            this.txbMaPhieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLapPhieu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietSuaChua)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvChiTietSuaChua
            // 
            this.dtgvChiTietSuaChua.AllowUserToResizeRows = false;
            this.dtgvChiTietSuaChua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvChiTietSuaChua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChiTietSuaChua.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvChiTietSuaChua.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvChiTietSuaChua.Location = new System.Drawing.Point(361, 100);
            this.dtgvChiTietSuaChua.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvChiTietSuaChua.MultiSelect = false;
            this.dtgvChiTietSuaChua.Name = "dtgvChiTietSuaChua";
            this.dtgvChiTietSuaChua.RowHeadersVisible = false;
            this.dtgvChiTietSuaChua.RowTemplate.Height = 24;
            this.dtgvChiTietSuaChua.Size = new System.Drawing.Size(626, 374);
            this.dtgvChiTietSuaChua.TabIndex = 5;
            // 
            // LoaiDichVu
            // 
            this.LoaiDichVu.HeaderText = "Loại dịch vụ";
            this.LoaiDichVu.Name = "LoaiDichVu";
            this.LoaiDichVu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PhuTung
            // 
            this.PhuTung.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.PhuTung.HeaderText = "Phụ tùng";
            this.PhuTung.Name = "PhuTung";
            this.PhuTung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaTien
            // 
            this.GiaTien.HeaderText = "Đơn giá";
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            // 
            // cmbBienSoXe
            // 
            this.cmbBienSoXe.Font = new System.Drawing.Font("Consolas", 12F);
            this.cmbBienSoXe.FormattingEnabled = true;
            this.cmbBienSoXe.Location = new System.Drawing.Point(126, 300);
            this.cmbBienSoXe.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBienSoXe.Name = "cmbBienSoXe";
            this.cmbBienSoXe.Size = new System.Drawing.Size(222, 27);
            this.cmbBienSoXe.TabIndex = 3;
            // 
            // cmbLoaiXe
            // 
            this.cmbLoaiXe.Font = new System.Drawing.Font("Consolas", 12F);
            this.cmbLoaiXe.FormattingEnabled = true;
            this.cmbLoaiXe.Location = new System.Drawing.Point(126, 245);
            this.cmbLoaiXe.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLoaiXe.Name = "cmbLoaiXe";
            this.cmbLoaiXe.Size = new System.Drawing.Size(222, 27);
            this.cmbLoaiXe.TabIndex = 2;
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.Font = new System.Drawing.Font("Consolas", 12F);
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(126, 127);
            this.cmbKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(222, 27);
            this.cmbKhachHang.TabIndex = 0;
            // 
            // txbNhanVienSuaChua
            // 
            this.txbNhanVienSuaChua.Font = new System.Drawing.Font("Consolas", 12F);
            this.txbNhanVienSuaChua.Location = new System.Drawing.Point(126, 361);
            this.txbNhanVienSuaChua.Margin = new System.Windows.Forms.Padding(2);
            this.txbNhanVienSuaChua.Name = "txbNhanVienSuaChua";
            this.txbNhanVienSuaChua.Size = new System.Drawing.Size(222, 26);
            this.txbNhanVienSuaChua.TabIndex = 4;
            // 
            // txbDienThoai
            // 
            this.txbDienThoai.Font = new System.Drawing.Font("Consolas", 12F);
            this.txbDienThoai.Location = new System.Drawing.Point(126, 190);
            this.txbDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.txbDienThoai.Name = "txbDienThoai";
            this.txbDienThoai.Size = new System.Drawing.Size(222, 26);
            this.txbDienThoai.TabIndex = 1;
            // 
            // txbMaPhieu
            // 
            this.txbMaPhieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbMaPhieu.Font = new System.Drawing.Font("Consolas", 12F);
            this.txbMaPhieu.Location = new System.Drawing.Point(409, 47);
            this.txbMaPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.txbMaPhieu.Name = "txbMaPhieu";
            this.txbMaPhieu.ReadOnly = true;
            this.txbMaPhieu.Size = new System.Drawing.Size(288, 26);
            this.txbMaPhieu.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Consolas", 12F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(16, 353);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 41);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nhân viên sửa chữa";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 12F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(13, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Biển số xe";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 12F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(13, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Điện thoại";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(13, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Loại xe";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(13, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 48);
            this.label4.TabIndex = 9;
            this.label4.Text = "Khách hàng - CMND";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(315, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã phiếu";
            // 
            // BtnLapPhieu
            // 
            this.BtnLapPhieu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnLapPhieu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLapPhieu.Location = new System.Drawing.Point(409, 543);
            this.BtnLapPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLapPhieu.Name = "BtnLapPhieu";
            this.BtnLapPhieu.Size = new System.Drawing.Size(150, 32);
            this.BtnLapPhieu.TabIndex = 6;
            this.BtnLapPhieu.Text = "Lập Phiếu";
            this.BtnLapPhieu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(717, 495);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tổng tiền";
            // 
            // txbTongTien
            // 
            this.txbTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTongTien.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongTien.Location = new System.Drawing.Point(819, 492);
            this.txbTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(169, 26);
            this.txbTongTien.TabIndex = 15;
            // 
            // UC_LapPhieuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.txbTongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnLapPhieu);
            this.Controls.Add(this.dtgvChiTietSuaChua);
            this.Controls.Add(this.cmbBienSoXe);
            this.Controls.Add(this.cmbLoaiXe);
            this.Controls.Add(this.cmbKhachHang);
            this.Controls.Add(this.txbNhanVienSuaChua);
            this.Controls.Add(this.txbDienThoai);
            this.Controls.Add(this.txbMaPhieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_LapPhieuSuaChua";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietSuaChua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvChiTietSuaChua;
        private System.Windows.Forms.ComboBox cmbBienSoXe;
        private System.Windows.Forms.ComboBox cmbLoaiXe;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.TextBox txbNhanVienSuaChua;
        private System.Windows.Forms.TextBox txbDienThoai;
        private System.Windows.Forms.TextBox txbMaPhieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLapPhieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.DataGridViewComboBoxColumn LoaiDichVu;
        private System.Windows.Forms.DataGridViewComboBoxColumn PhuTung;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
    }
}
