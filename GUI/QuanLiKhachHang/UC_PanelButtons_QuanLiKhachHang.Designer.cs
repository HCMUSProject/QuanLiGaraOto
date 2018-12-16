namespace GUI.QuanLiKhachHang
{
    partial class UC_PanelButtons_QuanLiKhachHang
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
            this.BtnQuanLiKhachHang = new System.Windows.Forms.Button();
            this.BtnXemThongTin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnQuanLiKhachHang
            // 
            this.BtnQuanLiKhachHang.FlatAppearance.BorderSize = 0;
            this.BtnQuanLiKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuanLiKhachHang.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuanLiKhachHang.Location = new System.Drawing.Point(0, 0);
            this.BtnQuanLiKhachHang.Margin = new System.Windows.Forms.Padding(0);
            this.BtnQuanLiKhachHang.Name = "BtnQuanLiKhachHang";
            this.BtnQuanLiKhachHang.Size = new System.Drawing.Size(140, 70);
            this.BtnQuanLiKhachHang.TabIndex = 0;
            this.BtnQuanLiKhachHang.Text = "Quản lí khách hàng";
            this.BtnQuanLiKhachHang.UseVisualStyleBackColor = true;
            this.BtnQuanLiKhachHang.Click += new System.EventHandler(this.BtnQuanLiKhachHang_Click);
            // 
            // BtnXemThongTin
            // 
            this.BtnXemThongTin.FlatAppearance.BorderSize = 0;
            this.BtnXemThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXemThongTin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXemThongTin.Location = new System.Drawing.Point(140, 0);
            this.BtnXemThongTin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnXemThongTin.Name = "BtnXemThongTin";
            this.BtnXemThongTin.Size = new System.Drawing.Size(140, 70);
            this.BtnXemThongTin.TabIndex = 1;
            this.BtnXemThongTin.Text = "Xem thông tin khách hàng";
            this.BtnXemThongTin.UseVisualStyleBackColor = true;
            this.BtnXemThongTin.Click += new System.EventHandler(this.BtnXemThongTin_Click);
            // 
            // UC_PanelButtons_QuanLiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnXemThongTin);
            this.Controls.Add(this.BtnQuanLiKhachHang);
            this.Name = "UC_PanelButtons_QuanLiKhachHang";
            this.Size = new System.Drawing.Size(1000, 70);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnQuanLiKhachHang;
        private System.Windows.Forms.Button BtnXemThongTin;
    }
}
