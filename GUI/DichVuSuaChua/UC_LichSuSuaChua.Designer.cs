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
            this.lvChiTiet = new System.Windows.Forms.ListView();
            this.LoaiDichVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VatTu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbXemTheo
            // 
            this.cmbXemTheo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbXemTheo.FormattingEnabled = true;
            this.cmbXemTheo.Location = new System.Drawing.Point(186, 37);
            this.cmbXemTheo.Name = "cmbXemTheo";
            this.cmbXemTheo.Size = new System.Drawing.Size(184, 31);
            this.cmbXemTheo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 3;
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
            this.dtgvLichSu.Location = new System.Drawing.Point(18, 107);
            this.dtgvLichSu.Name = "dtgvLichSu";
            this.dtgvLichSu.ReadOnly = true;
            this.dtgvLichSu.RowHeadersVisible = false;
            this.dtgvLichSu.RowTemplate.Height = 24;
            this.dtgvLichSu.Size = new System.Drawing.Size(591, 509);
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
            // lvChiTiet
            // 
            this.lvChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvChiTiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LoaiDichVu,
            this.VatTu,
            this.DonGia});
            this.lvChiTiet.Location = new System.Drawing.Point(615, 107);
            this.lvChiTiet.Name = "lvChiTiet";
            this.lvChiTiet.Size = new System.Drawing.Size(367, 509);
            this.lvChiTiet.TabIndex = 2;
            this.lvChiTiet.UseCompatibleStateImageBehavior = false;
            // 
            // LoaiDichVu
            // 
            this.LoaiDichVu.Text = "Loại dịch vụ";
            // 
            // VatTu
            // 
            this.VatTu.Text = "Vật tư";
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            // 
            // UC_LichSuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lvChiTiet);
            this.Controls.Add(this.dtgvLichSu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbXemTheo);
            this.Name = "UC_LichSuSuaChua";
            this.Size = new System.Drawing.Size(1000, 640);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbXemTheo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvLichSu;
        private System.Windows.Forms.ListView lvChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HieuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySua;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.ColumnHeader LoaiDichVu;
        private System.Windows.Forms.ColumnHeader VatTu;
        private System.Windows.Forms.ColumnHeader DonGia;
    }
}
