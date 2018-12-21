namespace GUI.QuanLiKhachHang
{
    partial class UC_QuanLiKhachHang
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
            this.dtgvKhachHang = new System.Windows.Forms.DataGridView();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnTimKiem = new System.Windows.Forms.Button();
            this.txbTimKiemSDT = new System.Windows.Forms.TextBox();
            this.txbTimKiemCMND = new System.Windows.Forms.TextBox();
            this.txbTimKiemTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GBxGioiTinh = new System.Windows.Forms.GroupBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.txbCMND = new System.Windows.Forms.TextBox();
            this.txbTen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GBxGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvKhachHang
            // 
            this.dtgvKhachHang.AllowUserToAddRows = false;
            this.dtgvKhachHang.AllowUserToDeleteRows = false;
            this.dtgvKhachHang.AllowUserToResizeRows = false;
            this.dtgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvKhachHang.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKH,
            this.CMND,
            this.SDT,
            this.DiaChi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvKhachHang.Location = new System.Drawing.Point(16, 31);
            this.dtgvKhachHang.MultiSelect = false;
            this.dtgvKhachHang.Name = "dtgvKhachHang";
            this.dtgvKhachHang.ReadOnly = true;
            this.dtgvKhachHang.RowHeadersVisible = false;
            this.dtgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvKhachHang.Size = new System.Drawing.Size(583, 552);
            this.dtgvKhachHang.TabIndex = 0;
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // CMND
            // 
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnTimKiem);
            this.groupBox1.Controls.Add(this.txbTimKiemSDT);
            this.groupBox1.Controls.Add(this.txbTimKiemCMND);
            this.groupBox1.Controls.Add(this.txbTimKiemTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(618, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm khách hàng";
            // 
            // BtnTimKiem
            // 
            this.BtnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTimKiem.AutoSize = true;
            this.BtnTimKiem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTimKiem.Location = new System.Drawing.Point(127, 133);
            this.BtnTimKiem.Name = "BtnTimKiem";
            this.BtnTimKiem.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnTimKiem.Size = new System.Drawing.Size(101, 33);
            this.BtnTimKiem.TabIndex = 3;
            this.BtnTimKiem.Text = "Tìm kiếm";
            this.BtnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txbTimKiemSDT
            // 
            this.txbTimKiemSDT.Location = new System.Drawing.Point(133, 97);
            this.txbTimKiemSDT.Name = "txbTimKiemSDT";
            this.txbTimKiemSDT.Size = new System.Drawing.Size(209, 23);
            this.txbTimKiemSDT.TabIndex = 2;
            // 
            // txbTimKiemCMND
            // 
            this.txbTimKiemCMND.Location = new System.Drawing.Point(133, 60);
            this.txbTimKiemCMND.Name = "txbTimKiemCMND";
            this.txbTimKiemCMND.Size = new System.Drawing.Size(209, 23);
            this.txbTimKiemCMND.TabIndex = 1;
            // 
            // txbTimKiemTen
            // 
            this.txbTimKiemTen.Location = new System.Drawing.Point(133, 23);
            this.txbTimKiemTen.Name = "txbTimKiemTen";
            this.txbTimKiemTen.Size = new System.Drawing.Size(209, 23);
            this.txbTimKiemTen.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "SĐT";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "CMND";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tên";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "CMND";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 41);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Địa chỉ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.GBxGioiTinh);
            this.groupBox2.Controls.Add(this.dtpkNgaySinh);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.BtnXoa);
            this.groupBox2.Controls.Add(this.BtnSua);
            this.groupBox2.Controls.Add(this.BtnThem);
            this.groupBox2.Controls.Add(this.txbDiaChi);
            this.groupBox2.Controls.Add(this.txbSDT);
            this.groupBox2.Controls.Add(this.txbCMND);
            this.groupBox2.Controls.Add(this.txbTen);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(618, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 381);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lí thông tin";
            // 
            // GBxGioiTinh
            // 
            this.GBxGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GBxGioiTinh.Controls.Add(this.rbNu);
            this.GBxGioiTinh.Controls.Add(this.rbNam);
            this.GBxGioiTinh.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBxGioiTinh.Location = new System.Drawing.Point(133, 189);
            this.GBxGioiTinh.Name = "GBxGioiTinh";
            this.GBxGioiTinh.Size = new System.Drawing.Size(209, 42);
            this.GBxGioiTinh.TabIndex = 4;
            this.GBxGioiTinh.TabStop = false;
            // 
            // rbNu
            // 
            this.rbNu.Location = new System.Drawing.Point(123, 14);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(55, 24);
            this.rbNu.TabIndex = 1;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.Location = new System.Drawing.Point(56, 14);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(55, 24);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.Location = new System.Drawing.Point(133, 256);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(209, 23);
            this.dtpkNgaySinh.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ngày sinh";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Giới tính";
            // 
            // BtnXoa
            // 
            this.BtnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnXoa.AutoSize = true;
            this.BtnXoa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.Location = new System.Drawing.Point(250, 322);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnXoa.Size = new System.Drawing.Size(92, 33);
            this.BtnXoa.TabIndex = 8;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            // 
            // BtnSua
            // 
            this.BtnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSua.AutoSize = true;
            this.BtnSua.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSua.Location = new System.Drawing.Point(136, 322);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnSua.Size = new System.Drawing.Size(92, 33);
            this.BtnSua.TabIndex = 7;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            // 
            // BtnThem
            // 
            this.BtnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnThem.AutoSize = true;
            this.BtnThem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThem.Location = new System.Drawing.Point(22, 322);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnThem.Size = new System.Drawing.Size(92, 33);
            this.BtnThem.TabIndex = 6;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(133, 153);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(209, 23);
            this.txbDiaChi.TabIndex = 3;
            // 
            // txbSDT
            // 
            this.txbSDT.Location = new System.Drawing.Point(133, 109);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(209, 23);
            this.txbSDT.TabIndex = 2;
            // 
            // txbCMND
            // 
            this.txbCMND.Location = new System.Drawing.Point(133, 66);
            this.txbCMND.Name = "txbCMND";
            this.txbCMND.Size = new System.Drawing.Size(209, 23);
            this.txbCMND.TabIndex = 1;
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(133, 24);
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(209, 23);
            this.txbTen.TabIndex = 0;
            // 
            // UC_QuanLiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvKhachHang);
            this.Name = "UC_QuanLiKhachHang";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GBxGioiTinh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbTimKiemSDT;
        private System.Windows.Forms.TextBox txbTimKiemCMND;
        private System.Windows.Forms.TextBox txbTimKiemTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.TextBox txbCMND;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.Button BtnTimKiem;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox GBxGioiTinh;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
    }
}
