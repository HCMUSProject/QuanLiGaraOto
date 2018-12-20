namespace GUI.QuanLiThongTinNhanVIen
{
    partial class UC_PanelSubButtons_QuanLyThongTinNhanVien
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
            this.BtnQuanLiNhanVien = new System.Windows.Forms.Button();
            this.BtnXemThongTin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnQuanLiNhanVien
            // 
            this.BtnQuanLiNhanVien.FlatAppearance.BorderSize = 0;
            this.BtnQuanLiNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuanLiNhanVien.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuanLiNhanVien.Location = new System.Drawing.Point(145, 0);
            this.BtnQuanLiNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.BtnQuanLiNhanVien.Name = "BtnQuanLiNhanVien";
            this.BtnQuanLiNhanVien.Size = new System.Drawing.Size(140, 70);
            this.BtnQuanLiNhanVien.TabIndex = 1;
            this.BtnQuanLiNhanVien.Text = "Quản lí thông tin nhân viên";
            this.BtnQuanLiNhanVien.UseVisualStyleBackColor = true;
            this.BtnQuanLiNhanVien.Click += new System.EventHandler(this.BtnQuanLiNhanVien_Click);
            // 
            // BtnXemThongTin
            // 
            this.BtnXemThongTin.FlatAppearance.BorderSize = 0;
            this.BtnXemThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXemThongTin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXemThongTin.Location = new System.Drawing.Point(0, 0);
            this.BtnXemThongTin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnXemThongTin.Name = "BtnXemThongTin";
            this.BtnXemThongTin.Size = new System.Drawing.Size(140, 70);
            this.BtnXemThongTin.TabIndex = 0;
            this.BtnXemThongTin.Text = "Xem thông tin";
            this.BtnXemThongTin.UseVisualStyleBackColor = true;
            this.BtnXemThongTin.Click += new System.EventHandler(this.BtnXemThongTin_Click);
            // 
            // UC_PanelSubButtons_QuanLyThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnQuanLiNhanVien);
            this.Controls.Add(this.BtnXemThongTin);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_PanelSubButtons_QuanLyThongTinNhanVien";
            this.Size = new System.Drawing.Size(1000, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnQuanLiNhanVien;
        private System.Windows.Forms.Button BtnXemThongTin;
    }
}
