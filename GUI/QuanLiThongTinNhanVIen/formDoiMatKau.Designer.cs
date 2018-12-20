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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới";
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.Location = new System.Drawing.Point(216, 54);
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.ReadOnly = true;
            this.txbTaiKhoan.Size = new System.Drawing.Size(234, 26);
            this.txbTaiKhoan.TabIndex = 3;
            // 
            // txbMatKhauCu
            // 
            this.txbMatKhauCu.Location = new System.Drawing.Point(216, 126);
            this.txbMatKhauCu.Name = "txbMatKhauCu";
            this.txbMatKhauCu.Size = new System.Drawing.Size(234, 26);
            this.txbMatKhauCu.TabIndex = 4;
            // 
            // txbMatKhauMoi
            // 
            this.txbMatKhauMoi.Location = new System.Drawing.Point(216, 197);
            this.txbMatKhauMoi.Name = "txbMatKhauMoi";
            this.txbMatKhauMoi.Size = new System.Drawing.Size(234, 26);
            this.txbMatKhauMoi.TabIndex = 5;
            // 
            // BtnDoiMatKhau
            // 
            this.BtnDoiMatKhau.AutoSize = true;
            this.BtnDoiMatKhau.Location = new System.Drawing.Point(180, 302);
            this.BtnDoiMatKhau.Name = "BtnDoiMatKhau";
            this.BtnDoiMatKhau.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnDoiMatKhau.Size = new System.Drawing.Size(137, 33);
            this.BtnDoiMatKhau.TabIndex = 6;
            this.BtnDoiMatKhau.Text = "Đổi mật khẩu";
            this.BtnDoiMatKhau.UseVisualStyleBackColor = true;
            // 
            // formDoiMatKau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 379);
            this.Controls.Add(this.BtnDoiMatKhau);
            this.Controls.Add(this.txbMatKhauMoi);
            this.Controls.Add(this.txbMatKhauCu);
            this.Controls.Add(this.txbTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formDoiMatKau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formDoiMatKau";
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
    }
}