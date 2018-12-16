namespace GUI.BaoCao
{
    partial class UC_PanelButtons_BaoCao
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
            this.BtnBaoCaoTonKho = new System.Windows.Forms.Button();
            this.BtnBaoCaoDoanhThu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBaoCaoTonKho
            // 
            this.BtnBaoCaoTonKho.FlatAppearance.BorderSize = 0;
            this.BtnBaoCaoTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBaoCaoTonKho.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBaoCaoTonKho.Location = new System.Drawing.Point(140, 0);
            this.BtnBaoCaoTonKho.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBaoCaoTonKho.Name = "BtnBaoCaoTonKho";
            this.BtnBaoCaoTonKho.Size = new System.Drawing.Size(140, 70);
            this.BtnBaoCaoTonKho.TabIndex = 1;
            this.BtnBaoCaoTonKho.Text = "Báo cáo tồn kho";
            this.BtnBaoCaoTonKho.UseVisualStyleBackColor = true;
            this.BtnBaoCaoTonKho.Click += new System.EventHandler(this.BtnBaoCaoTonKho_Click);
            // 
            // BtnBaoCaoDoanhThu
            // 
            this.BtnBaoCaoDoanhThu.FlatAppearance.BorderSize = 0;
            this.BtnBaoCaoDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBaoCaoDoanhThu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBaoCaoDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.BtnBaoCaoDoanhThu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBaoCaoDoanhThu.Name = "BtnBaoCaoDoanhThu";
            this.BtnBaoCaoDoanhThu.Size = new System.Drawing.Size(140, 70);
            this.BtnBaoCaoDoanhThu.TabIndex = 0;
            this.BtnBaoCaoDoanhThu.Text = "Báo cáo doanh thu";
            this.BtnBaoCaoDoanhThu.UseVisualStyleBackColor = true;
            this.BtnBaoCaoDoanhThu.Click += new System.EventHandler(this.BtnBaoCaoDoanhThu_Click);
            // 
            // UC_PanelButtons_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnBaoCaoTonKho);
            this.Controls.Add(this.BtnBaoCaoDoanhThu);
            this.Name = "UC_PanelButtons_BaoCao";
            this.Size = new System.Drawing.Size(1000, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBaoCaoTonKho;
        private System.Windows.Forms.Button BtnBaoCaoDoanhThu;
    }
}
