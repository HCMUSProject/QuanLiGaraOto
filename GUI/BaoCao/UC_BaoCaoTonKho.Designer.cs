namespace GUI.BaoCao
{
    partial class UC_BaoCaoTonKho
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
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvTonKho = new System.Windows.Forms.DataGridView();
            this.HangSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnXuatExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNam
            // 
            this.cmbNam.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Location = new System.Drawing.Point(200, 25);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(77, 27);
            this.cmbNam.TabIndex = 1;
            // 
            // cmbThang
            // 
            this.cmbThang.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Location = new System.Drawing.Point(88, 25);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(40, 27);
            this.cmbThang.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tháng";
            // 
            // dtgvTonKho
            // 
            this.dtgvTonKho.AllowUserToAddRows = false;
            this.dtgvTonKho.AllowUserToDeleteRows = false;
            this.dtgvTonKho.AllowUserToResizeRows = false;
            this.dtgvTonKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvTonKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTonKho.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTonKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTonKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HangSanXuat,
            this.VatTu,
            this.SoLuongNhap,
            this.SoLuongDung,
            this.SoLuongConLai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTonKho.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTonKho.Location = new System.Drawing.Point(18, 73);
            this.dtgvTonKho.Name = "dtgvTonKho";
            this.dtgvTonKho.ReadOnly = true;
            this.dtgvTonKho.RowHeadersVisible = false;
            this.dtgvTonKho.Size = new System.Drawing.Size(968, 502);
            this.dtgvTonKho.TabIndex = 6;
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
            // SoLuongNhap
            // 
            this.SoLuongNhap.HeaderText = "Số lượng nhập";
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.ReadOnly = true;
            // 
            // SoLuongDung
            // 
            this.SoLuongDung.HeaderText = "Số lượng đã dùng";
            this.SoLuongDung.Name = "SoLuongDung";
            this.SoLuongDung.ReadOnly = true;
            // 
            // SoLuongConLai
            // 
            this.SoLuongConLai.HeaderText = "Số lượng còn lại";
            this.SoLuongConLai.Name = "SoLuongConLai";
            this.SoLuongConLai.ReadOnly = true;
            // 
            // BtnXuatExcel
            // 
            this.BtnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnXuatExcel.AutoSize = true;
            this.BtnXuatExcel.Location = new System.Drawing.Point(899, 21);
            this.BtnXuatExcel.Name = "BtnXuatExcel";
            this.BtnXuatExcel.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnXuatExcel.Size = new System.Drawing.Size(87, 34);
            this.BtnXuatExcel.TabIndex = 2;
            this.BtnXuatExcel.Text = "Xuất Excel";
            this.BtnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // UC_BaoCaoTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.BtnXuatExcel);
            this.Controls.Add(this.dtgvTonKho);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_BaoCaoTonKho";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTonKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvTonKho;
        private System.Windows.Forms.Button BtnXuatExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongConLai;
    }
}
