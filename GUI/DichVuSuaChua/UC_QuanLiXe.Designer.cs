namespace GUI.DichVuSuaChua
{
    partial class UC_QuanLiXe
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
            this.GroupBoxBasicInfo = new System.Windows.Forms.GroupBox();
            this.NumOfCarsToday = new System.Windows.Forms.Label();
            this.TotalCars = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvQuanLiXe = new System.Windows.Forms.DataGridView();
            this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HangXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HieuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBoxBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuanLiXe)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxBasicInfo
            // 
            this.GroupBoxBasicInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GroupBoxBasicInfo.Controls.Add(this.NumOfCarsToday);
            this.GroupBoxBasicInfo.Controls.Add(this.TotalCars);
            this.GroupBoxBasicInfo.Controls.Add(this.label2);
            this.GroupBoxBasicInfo.Controls.Add(this.label1);
            this.GroupBoxBasicInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxBasicInfo.Location = new System.Drawing.Point(213, 33);
            this.GroupBoxBasicInfo.Name = "GroupBoxBasicInfo";
            this.GroupBoxBasicInfo.Size = new System.Drawing.Size(587, 138);
            this.GroupBoxBasicInfo.TabIndex = 1;
            this.GroupBoxBasicInfo.TabStop = false;
            this.GroupBoxBasicInfo.Text = "Thông tin cơ bản";
            // 
            // NumOfCarsToday
            // 
            this.NumOfCarsToday.AutoSize = true;
            this.NumOfCarsToday.Location = new System.Drawing.Point(404, 92);
            this.NumOfCarsToday.Name = "NumOfCarsToday";
            this.NumOfCarsToday.Size = new System.Drawing.Size(76, 23);
            this.NumOfCarsToday.TabIndex = 1;
            this.NumOfCarsToday.Text = "label4";
            // 
            // TotalCars
            // 
            this.TotalCars.AutoSize = true;
            this.TotalCars.Location = new System.Drawing.Point(404, 53);
            this.TotalCars.Name = "TotalCars";
            this.TotalCars.Size = new System.Drawing.Size(76, 23);
            this.TotalCars.TabIndex = 0;
            this.TotalCars.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số xe nhập vào hôm nay:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số xe trong gara:";
            // 
            // dtgvQuanLiXe
            // 
            this.dtgvQuanLiXe.AllowUserToAddRows = false;
            this.dtgvQuanLiXe.AllowUserToDeleteRows = false;
            this.dtgvQuanLiXe.AllowUserToOrderColumns = true;
            this.dtgvQuanLiXe.AllowUserToResizeColumns = false;
            this.dtgvQuanLiXe.AllowUserToResizeRows = false;
            this.dtgvQuanLiXe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvQuanLiXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvQuanLiXe.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgvQuanLiXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQuanLiXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KhachHang,
            this.CMND,
            this.DiaChi,
            this.HangXe,
            this.HieuXe,
            this.BienSo,
            this.DichVu});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvQuanLiXe.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvQuanLiXe.Location = new System.Drawing.Point(18, 189);
            this.dtgvQuanLiXe.Name = "dtgvQuanLiXe";
            this.dtgvQuanLiXe.ReadOnly = true;
            this.dtgvQuanLiXe.RowHeadersVisible = false;
            this.dtgvQuanLiXe.RowTemplate.Height = 24;
            this.dtgvQuanLiXe.Size = new System.Drawing.Size(966, 420);
            this.dtgvQuanLiXe.TabIndex = 0;
            // 
            // KhachHang
            // 
            this.KhachHang.HeaderText = "Khách Hàng";
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.ReadOnly = true;
            // 
            // CMND
            // 
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // HangXe
            // 
            this.HangXe.HeaderText = "Hãng xe";
            this.HangXe.Name = "HangXe";
            this.HangXe.ReadOnly = true;
            // 
            // HieuXe
            // 
            this.HieuXe.HeaderText = "Hiệu xe";
            this.HieuXe.Name = "HieuXe";
            this.HieuXe.ReadOnly = true;
            // 
            // BienSo
            // 
            this.BienSo.HeaderText = "Biển số";
            this.BienSo.Name = "BienSo";
            this.BienSo.ReadOnly = true;
            // 
            // DichVu
            // 
            this.DichVu.HeaderText = "Dịch vụ";
            this.DichVu.Name = "DichVu";
            this.DichVu.ReadOnly = true;
            // 
            // UC_QuanLiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dtgvQuanLiXe);
            this.Controls.Add(this.GroupBoxBasicInfo);
            this.Name = "UC_QuanLiXe";
            this.Size = new System.Drawing.Size(1000, 640);
            this.GroupBoxBasicInfo.ResumeLayout(false);
            this.GroupBoxBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuanLiXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxBasicInfo;
        private System.Windows.Forms.DataGridView dtgvQuanLiXe;
        private System.Windows.Forms.Label NumOfCarsToday;
        private System.Windows.Forms.Label TotalCars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn HieuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DichVu;
    }
}
