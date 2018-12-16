namespace GUI.VatTuPhuTung
{
    partial class UC_KiemKeVatTu
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
            this.dtgvKiemKeVatTu = new System.Windows.Forms.DataGridView();
            this.DanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HangXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKiemKeVatTu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvKiemKeVatTu
            // 
            this.dtgvKiemKeVatTu.AllowUserToAddRows = false;
            this.dtgvKiemKeVatTu.AllowUserToDeleteRows = false;
            this.dtgvKiemKeVatTu.AllowUserToResizeRows = false;
            this.dtgvKiemKeVatTu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvKiemKeVatTu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvKiemKeVatTu.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvKiemKeVatTu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvKiemKeVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKiemKeVatTu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DanhMuc,
            this.HangXe,
            this.VatTu,
            this.SoLuong});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvKiemKeVatTu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvKiemKeVatTu.Location = new System.Drawing.Point(15, 71);
            this.dtgvKiemKeVatTu.MultiSelect = false;
            this.dtgvKiemKeVatTu.Name = "dtgvKiemKeVatTu";
            this.dtgvKiemKeVatTu.ReadOnly = true;
            this.dtgvKiemKeVatTu.RowHeadersVisible = false;
            this.dtgvKiemKeVatTu.Size = new System.Drawing.Size(969, 517);
            this.dtgvKiemKeVatTu.TabIndex = 0;
            // 
            // DanhMuc
            // 
            this.DanhMuc.HeaderText = "Danh mục";
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.ReadOnly = true;
            // 
            // HangXe
            // 
            this.HangXe.HeaderText = "Hãng xe";
            this.HangXe.Name = "HangXe";
            this.HangXe.ReadOnly = true;
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
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(224, 26);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(105, 26);
            this.dtTo.TabIndex = 11;
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(59, 26);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(105, 26);
            this.dtFrom.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Từ";
            // 
            // UC_KiemKeVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvKiemKeVatTu);
            this.Name = "UC_KiemKeVatTu";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKiemKeVatTu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvKiemKeVatTu;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}
