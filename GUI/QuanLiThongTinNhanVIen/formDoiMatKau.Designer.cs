namespace GUI.QuanLiThongTinNhanVIen
{
    partial class formDoiMatKau
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTaiKhoan = new System.Windows.Forms.TextBox();
            this.txbMatKhauCu = new System.Windows.Forms.TextBox();
            this.txbMatKhauMoi = new System.Windows.Forms.TextBox();
            this.BtnDoiMatKhau = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới";
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.Location = new System.Drawing.Point(206, 123);
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.ReadOnly = true;
            this.txbTaiKhoan.Size = new System.Drawing.Size(234, 26);
            this.txbTaiKhoan.TabIndex = 3;
            this.txbTaiKhoan.TextChanged += new System.EventHandler(this.txbTaiKhoan_TextChanged);
            // 
            // txbMatKhauCu
            // 
            this.txbMatKhauCu.Location = new System.Drawing.Point(206, 195);
            this.txbMatKhauCu.Name = "txbMatKhauCu";
            this.txbMatKhauCu.Size = new System.Drawing.Size(234, 26);
            this.txbMatKhauCu.TabIndex = 4;
            // 
            // txbMatKhauMoi
            // 
            this.txbMatKhauMoi.Location = new System.Drawing.Point(206, 266);
            this.txbMatKhauMoi.Name = "txbMatKhauMoi";
            this.txbMatKhauMoi.Size = new System.Drawing.Size(234, 26);
            this.txbMatKhauMoi.TabIndex = 5;
            // 
            // BtnDoiMatKhau
            // 
            this.BtnDoiMatKhau.AutoSize = true;
            this.BtnDoiMatKhau.Location = new System.Drawing.Point(172, 341);
            this.BtnDoiMatKhau.Name = "BtnDoiMatKhau";
            this.BtnDoiMatKhau.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnDoiMatKhau.Size = new System.Drawing.Size(137, 33);
            this.BtnDoiMatKhau.TabIndex = 6;
            this.BtnDoiMatKhau.Text = "Đổi mật khẩu";
            this.BtnDoiMatKhau.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(81, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 56);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đổi Mật Khẩu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // formDoiMatKau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 406);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnDoiMatKhau);
            this.Controls.Add(this.txbMatKhauMoi);
            this.Controls.Add(this.txbMatKhauCu);
            this.Controls.Add(this.txbTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 445);
            this.MinimumSize = new System.Drawing.Size(520, 445);
            this.Name = "formDoiMatKau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.formDoiMatKau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTaiKhoan;
        private System.Windows.Forms.TextBox txbMatKhauCu;
        private System.Windows.Forms.TextBox txbMatKhauMoi;
        private System.Windows.Forms.Button BtnDoiMatKhau;
        private System.Windows.Forms.Label label4;
    }
}