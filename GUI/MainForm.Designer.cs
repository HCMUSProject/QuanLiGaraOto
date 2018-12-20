namespace GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.PanelUserAccount = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.slideBar = new System.Windows.Forms.Panel();
            this.BtnDichVuSuaChua = new System.Windows.Forms.Button();
            this.BtnQuanLiKhachHang = new System.Windows.Forms.Button();
            this.BtnVatTu = new System.Windows.Forms.Button();
            this.BtnBaoCao = new System.Windows.Forms.Button();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.PanelSubButtons = new System.Windows.Forms.Panel();
            this.PanelDecoration = new System.Windows.Forms.Panel();
            this.PanelButtons.SuspendLayout();
            this.PanelUserAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelButtons
            // 
            this.PanelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PanelButtons.Controls.Add(this.PanelUserAccount);
            this.PanelButtons.Controls.Add(this.slideBar);
            this.PanelButtons.Controls.Add(this.BtnDichVuSuaChua);
            this.PanelButtons.Controls.Add(this.BtnQuanLiKhachHang);
            this.PanelButtons.Controls.Add(this.BtnVatTu);
            this.PanelButtons.Controls.Add(this.BtnBaoCao);
            resources.ApplyResources(this.PanelButtons, "PanelButtons");
            this.PanelButtons.Name = "PanelButtons";
            // 
            // PanelUserAccount
            // 
            this.PanelUserAccount.Controls.Add(this.picAvatar);
            this.PanelUserAccount.Controls.Add(this.panel1);
            resources.ApplyResources(this.PanelUserAccount, "PanelUserAccount");
            this.PanelUserAccount.Name = "PanelUserAccount";
            // 
            // picAvatar
            // 
            resources.ApplyResources(this.picAvatar, "picAvatar");
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTenNhanVien);
            this.panel1.Controls.Add(this.lbChucVu);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lbTenNhanVien
            // 
            resources.ApplyResources(this.lbTenNhanVien, "lbTenNhanVien");
            this.lbTenNhanVien.ForeColor = System.Drawing.Color.White;
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            // 
            // lbChucVu
            // 
            resources.ApplyResources(this.lbChucVu, "lbChucVu");
            this.lbChucVu.ForeColor = System.Drawing.Color.White;
            this.lbChucVu.Name = "lbChucVu";
            // 
            // slideBar
            // 
            this.slideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            resources.ApplyResources(this.slideBar, "slideBar");
            this.slideBar.Name = "slideBar";
            // 
            // BtnDichVuSuaChua
            // 
            this.BtnDichVuSuaChua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.BtnDichVuSuaChua.FlatAppearance.BorderSize = 0;
            this.BtnDichVuSuaChua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            resources.ApplyResources(this.BtnDichVuSuaChua, "BtnDichVuSuaChua");
            this.BtnDichVuSuaChua.ForeColor = System.Drawing.Color.White;
            this.BtnDichVuSuaChua.Image = global::GUI.Properties.Resources.tools;
            this.BtnDichVuSuaChua.Name = "BtnDichVuSuaChua";
            this.BtnDichVuSuaChua.UseVisualStyleBackColor = true;
            this.BtnDichVuSuaChua.Click += new System.EventHandler(this.BtnDichVuSuaChua_Click);
            // 
            // BtnQuanLiKhachHang
            // 
            this.BtnQuanLiKhachHang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.BtnQuanLiKhachHang.FlatAppearance.BorderSize = 0;
            this.BtnQuanLiKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            resources.ApplyResources(this.BtnQuanLiKhachHang, "BtnQuanLiKhachHang");
            this.BtnQuanLiKhachHang.ForeColor = System.Drawing.Color.White;
            this.BtnQuanLiKhachHang.Image = global::GUI.Properties.Resources.user;
            this.BtnQuanLiKhachHang.Name = "BtnQuanLiKhachHang";
            this.BtnQuanLiKhachHang.UseVisualStyleBackColor = true;
            this.BtnQuanLiKhachHang.Click += new System.EventHandler(this.BtnQuanLiKhachHang_Click);
            // 
            // BtnVatTu
            // 
            this.BtnVatTu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.BtnVatTu.FlatAppearance.BorderSize = 0;
            this.BtnVatTu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            resources.ApplyResources(this.BtnVatTu, "BtnVatTu");
            this.BtnVatTu.ForeColor = System.Drawing.Color.White;
            this.BtnVatTu.Image = global::GUI.Properties.Resources.steering_wheel;
            this.BtnVatTu.Name = "BtnVatTu";
            this.BtnVatTu.UseVisualStyleBackColor = true;
            this.BtnVatTu.Click += new System.EventHandler(this.BtnVatTu_Click);
            // 
            // BtnBaoCao
            // 
            this.BtnBaoCao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.BtnBaoCao.FlatAppearance.BorderSize = 0;
            this.BtnBaoCao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            resources.ApplyResources(this.BtnBaoCao, "BtnBaoCao");
            this.BtnBaoCao.ForeColor = System.Drawing.Color.White;
            this.BtnBaoCao.Image = global::GUI.Properties.Resources.result;
            this.BtnBaoCao.Name = "BtnBaoCao";
            this.BtnBaoCao.UseVisualStyleBackColor = true;
            this.BtnBaoCao.Click += new System.EventHandler(this.BtnBaoCao_Click);
            // 
            // PanelContent
            // 
            this.PanelContent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.PanelContent, "PanelContent");
            this.PanelContent.Name = "PanelContent";
            // 
            // PanelSubButtons
            // 
            this.PanelSubButtons.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.PanelSubButtons, "PanelSubButtons");
            this.PanelSubButtons.Name = "PanelSubButtons";
            // 
            // PanelDecoration
            // 
            this.PanelDecoration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            resources.ApplyResources(this.PanelDecoration, "PanelDecoration");
            this.PanelDecoration.Name = "PanelDecoration";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelSubButtons);
            this.Controls.Add(this.PanelDecoration);
            this.Controls.Add(this.PanelButtons);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PanelButtons.ResumeLayout(false);
            this.PanelUserAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Panel PanelUserAccount;
        private System.Windows.Forms.Panel slideBar;
        private System.Windows.Forms.Button BtnDichVuSuaChua;
        public System.Windows.Forms.Button BtnQuanLiKhachHang;
        private System.Windows.Forms.Button BtnVatTu;
        private System.Windows.Forms.Button BtnBaoCao;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.Panel PanelSubButtons;
        private System.Windows.Forms.Panel PanelDecoration;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel panel1;
    }
}