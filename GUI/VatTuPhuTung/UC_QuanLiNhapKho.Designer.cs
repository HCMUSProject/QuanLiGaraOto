namespace GUI.VatTuPhuTung
{
    partial class UC_QuanLiNhapKho
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
            this.dtgvQuanLiNhapKho = new System.Windows.Forms.DataGridView();
            this.DanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HangSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpkTo = new System.Windows.Forms.DateTimePicker();
            this.dtpkFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbSoLuongVatTu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuanLiNhapKho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvQuanLiNhapKho
            // 
            this.dtgvQuanLiNhapKho.AllowUserToAddRows = false;
            this.dtgvQuanLiNhapKho.AllowUserToDeleteRows = false;
            this.dtgvQuanLiNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvQuanLiNhapKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvQuanLiNhapKho.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvQuanLiNhapKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvQuanLiNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQuanLiNhapKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DanhMuc,
            this.HangSanXuat,
            this.VatTu,
            this.SoLuong,
            this.DonGia,
            this.NgayNhap,
            this.NhanVienNhap});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvQuanLiNhapKho.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvQuanLiNhapKho.Location = new System.Drawing.Point(16, 31);
            this.dtgvQuanLiNhapKho.MultiSelect = false;
            this.dtgvQuanLiNhapKho.Name = "dtgvQuanLiNhapKho";
            this.dtgvQuanLiNhapKho.ReadOnly = true;
            this.dtgvQuanLiNhapKho.RowHeadersVisible = false;
            this.dtgvQuanLiNhapKho.Size = new System.Drawing.Size(677, 557);
            this.dtgvQuanLiNhapKho.TabIndex = 0;
            // 
            // DanhMuc
            // 
            this.DanhMuc.HeaderText = "Danh mục";
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.ReadOnly = true;
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
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // NhanVienNhap
            // 
            this.NhanVienNhap.HeaderText = "Nhân viên nhập";
            this.NhanVienNhap.Name = "NhanVienNhap";
            this.NhanVienNhap.ReadOnly = true;
            // 
            // dtpkTo
            // 
            this.dtpkTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpkTo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkTo.Location = new System.Drawing.Point(887, 106);
            this.dtpkTo.Name = "dtpkTo";
            this.dtpkTo.Size = new System.Drawing.Size(101, 26);
            this.dtpkTo.TabIndex = 1;
            // 
            // dtpkFrom
            // 
            this.dtpkFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpkFrom.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFrom.Location = new System.Drawing.Point(733, 106);
            this.dtpkFrom.Name = "dtpkFrom";
            this.dtpkFrom.Size = new System.Drawing.Size(101, 26);
            this.dtpkFrom.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(845, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đến";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(700, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Từ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbTongTien);
            this.groupBox1.Controls.Add(this.lbSoLuongVatTu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(712, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 165);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(171, 121);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(18, 19);
            this.lbTongTien.TabIndex = 3;
            this.lbTongTien.Text = "0";
            // 
            // lbSoLuongVatTu
            // 
            this.lbSoLuongVatTu.AutoSize = true;
            this.lbSoLuongVatTu.Location = new System.Drawing.Point(171, 61);
            this.lbSoLuongVatTu.Name = "lbSoLuongVatTu";
            this.lbSoLuongVatTu.Size = new System.Drawing.Size(18, 19);
            this.lbSoLuongVatTu.TabIndex = 2;
            this.lbSoLuongVatTu.Text = "0";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng vật tư nhập";
            // 
            // UC_QuanLiNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpkTo);
            this.Controls.Add(this.dtpkFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvQuanLiNhapKho);
            this.Name = "UC_QuanLiNhapKho";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuanLiNhapKho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvQuanLiNhapKho;
        private System.Windows.Forms.DateTimePicker dtpkTo;
        private System.Windows.Forms.DateTimePicker dtpkFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbSoLuongVatTu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienNhap;
    }
}
