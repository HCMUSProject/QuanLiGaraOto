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
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvTonKho = new System.Windows.Forms.DataGridView();
            this.BtnXuatExcel = new System.Windows.Forms.Button();
            this.BtnXemTonKho = new System.Windows.Forms.Button();
            this.dtpkTo = new System.Windows.Forms.DateTimePicker();
            this.dtpkFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Năm";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTonKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTonKho.Location = new System.Drawing.Point(18, 73);
            this.dtgvTonKho.MultiSelect = false;
            this.dtgvTonKho.Name = "dtgvTonKho";
            this.dtgvTonKho.ReadOnly = true;
            this.dtgvTonKho.RowHeadersVisible = false;
            this.dtgvTonKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTonKho.Size = new System.Drawing.Size(968, 502);
            this.dtgvTonKho.TabIndex = 6;
            // 
            // BtnXuatExcel
            // 
            this.BtnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnXuatExcel.AutoSize = true;
            this.BtnXuatExcel.Location = new System.Drawing.Point(878, 21);
            this.BtnXuatExcel.Name = "BtnXuatExcel";
            this.BtnXuatExcel.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnXuatExcel.Size = new System.Drawing.Size(108, 34);
            this.BtnXuatExcel.TabIndex = 2;
            this.BtnXuatExcel.Text = "Xuất Excel";
            this.BtnXuatExcel.UseVisualStyleBackColor = true;
            this.BtnXuatExcel.Click += new System.EventHandler(this.BtnXuatExcel_Click);
            // 
            // BtnXemTonKho
            // 
            this.BtnXemTonKho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnXemTonKho.AutoSize = true;
            this.BtnXemTonKho.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXemTonKho.Location = new System.Drawing.Point(476, 20);
            this.BtnXemTonKho.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXemTonKho.Name = "BtnXemTonKho";
            this.BtnXemTonKho.Padding = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.BtnXemTonKho.Size = new System.Drawing.Size(123, 41);
            this.BtnXemTonKho.TabIndex = 18;
            this.BtnXemTonKho.Text = "Xem";
            this.BtnXemTonKho.UseVisualStyleBackColor = true;
            this.BtnXemTonKho.Click += new System.EventHandler(this.BtnXemTonKho_Click_1);
            // 
            // dtpkTo
            // 
            this.dtpkTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpkTo.CustomFormat = "dd/MM/yy";
            this.dtpkTo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTo.Location = new System.Drawing.Point(292, 25);
            this.dtpkTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkTo.Name = "dtpkTo";
            this.dtpkTo.Size = new System.Drawing.Size(133, 31);
            this.dtpkTo.TabIndex = 15;
            // 
            // dtpkFrom
            // 
            this.dtpkFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpkFrom.CustomFormat = "dd/MM/yy";
            this.dtpkFrom.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkFrom.Location = new System.Drawing.Point(100, 25);
            this.dtpkFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkFrom.Name = "dtpkFrom";
            this.dtpkFrom.Size = new System.Drawing.Size(133, 31);
            this.dtpkFrom.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Đến";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Từ";
            // 
            // UC_BaoCaoTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.BtnXemTonKho);
            this.Controls.Add(this.dtpkTo);
            this.Controls.Add(this.dtpkFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnXuatExcel);
            this.Controls.Add(this.dtgvTonKho);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_BaoCaoTonKho";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTonKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvTonKho;
        private System.Windows.Forms.Button BtnXuatExcel;
        private System.Windows.Forms.Button BtnXemTonKho;
        private System.Windows.Forms.DateTimePicker dtpkTo;
        private System.Windows.Forms.DateTimePicker dtpkFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}
