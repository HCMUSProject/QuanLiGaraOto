namespace GUI.QuanLiThongTinNhanVIen
{
    partial class UC_QuanLiThongTinNV
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
            this.dtgvXemNhanVIen = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.txbCMND = new System.Windows.Forms.TextBox();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbTaiKhoan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GBxGioiTinh = new System.Windows.Forms.GroupBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dtpkNgayLam = new System.Windows.Forms.DateTimePicker();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXemNhanVIen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GBxGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvXemNhanVIen
            // 
            this.dtgvXemNhanVIen.AllowUserToAddRows = false;
            this.dtgvXemNhanVIen.AllowUserToDeleteRows = false;
            this.dtgvXemNhanVIen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvXemNhanVIen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvXemNhanVIen.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvXemNhanVIen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvXemNhanVIen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvXemNhanVIen.Location = new System.Drawing.Point(13, 28);
            this.dtgvXemNhanVIen.MultiSelect = false;
            this.dtgvXemNhanVIen.Name = "dtgvXemNhanVIen";
            this.dtgvXemNhanVIen.ReadOnly = true;
            this.dtgvXemNhanVIen.RowHeadersVisible = false;
            this.dtgvXemNhanVIen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvXemNhanVIen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvXemNhanVIen.Size = new System.Drawing.Size(666, 554);
            this.dtgvXemNhanVIen.TabIndex = 1;
            this.dtgvXemNhanVIen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvXemNhanVIen_CellContentClick);
            this.dtgvXemNhanVIen.Click += new System.EventHandler(this.dtgvXemNhanVIen_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "CMND";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số điện thoại";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa chỉ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giới tính";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(13, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 45);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày vào làm";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(118, 80);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(168, 26);
            this.txbHoTen.TabIndex = 1;
            // 
            // txbCMND
            // 
            this.txbCMND.Location = new System.Drawing.Point(118, 215);
            this.txbCMND.Name = "txbCMND";
            this.txbCMND.Size = new System.Drawing.Size(168, 26);
            this.txbCMND.TabIndex = 4;
            // 
            // txbSDT
            // 
            this.txbSDT.Location = new System.Drawing.Point(118, 254);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(168, 26);
            this.txbSDT.TabIndex = 5;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(118, 293);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(168, 26);
            this.txbDiaChi.TabIndex = 6;
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.Location = new System.Drawing.Point(118, 41);
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.Size = new System.Drawing.Size(168, 26);
            this.txbTaiKhoan.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(13, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 30);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tài khoản";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.GBxGioiTinh);
            this.groupBox1.Controls.Add(this.dtpkNgaySinh);
            this.groupBox1.Controls.Add(this.dtpkNgayLam);
            this.groupBox1.Controls.Add(this.BtnXoa);
            this.groupBox1.Controls.Add(this.BtnSua);
            this.groupBox1.Controls.Add(this.txbTaiKhoan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnThem);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbDiaChi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbSDT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbCMND);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbHoTen);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(685, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // GBxGioiTinh
            // 
            this.GBxGioiTinh.Controls.Add(this.rbNu);
            this.GBxGioiTinh.Controls.Add(this.rbNam);
            this.GBxGioiTinh.Location = new System.Drawing.Point(118, 151);
            this.GBxGioiTinh.Name = "GBxGioiTinh";
            this.GBxGioiTinh.Size = new System.Drawing.Size(168, 49);
            this.GBxGioiTinh.TabIndex = 3;
            this.GBxGioiTinh.TabStop = false;
            // 
            // rbNu
            // 
            this.rbNu.Location = new System.Drawing.Point(97, 17);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(55, 24);
            this.rbNu.TabIndex = 1;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.Location = new System.Drawing.Point(30, 17);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(55, 24);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgaySinh.Location = new System.Drawing.Point(118, 119);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(168, 26);
            this.dtpkNgaySinh.TabIndex = 2;
            // 
            // dtpkNgayLam
            // 
            this.dtpkNgayLam.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayLam.Location = new System.Drawing.Point(118, 339);
            this.dtpkNgayLam.Name = "dtpkNgayLam";
            this.dtpkNgayLam.Size = new System.Drawing.Size(168, 26);
            this.dtpkNgayLam.TabIndex = 7;
            // 
            // BtnXoa
            // 
            this.BtnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnXoa.AutoSize = true;
            this.BtnXoa.Enabled = false;
            this.BtnXoa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.Location = new System.Drawing.Point(200, 402);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnXoa.Size = new System.Drawing.Size(92, 33);
            this.BtnXoa.TabIndex = 10;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSua.AutoSize = true;
            this.BtnSua.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSua.Location = new System.Drawing.Point(102, 402);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnSua.Size = new System.Drawing.Size(92, 33);
            this.BtnSua.TabIndex = 9;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnThem.AutoSize = true;
            this.BtnThem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThem.Location = new System.Drawing.Point(4, 402);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnThem.Size = new System.Drawing.Size(92, 33);
            this.BtnThem.TabIndex = 8;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // UC_QuanLiThongTinNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvXemNhanVIen);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_QuanLiThongTinNV";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXemNhanVIen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBxGioiTinh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvXemNhanVIen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.TextBox txbCMND;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbTaiKhoan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpkNgayLam;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.GroupBox GBxGioiTinh;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
    }
}
