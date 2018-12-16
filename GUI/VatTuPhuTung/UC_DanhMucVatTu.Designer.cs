namespace GUI.VatTuPhuTung
{
    partial class UC_DanhMucVatTu
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
            this.lvDanhMuc = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDanhMuc = new System.Windows.Forms.TextBox();
            this.BtnThem = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvDanhMuc
            // 
            this.lvDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDanhMuc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDanhMuc.Location = new System.Drawing.Point(19, 34);
            this.lvDanhMuc.MultiSelect = false;
            this.lvDanhMuc.Name = "lvDanhMuc";
            this.lvDanhMuc.Size = new System.Drawing.Size(490, 543);
            this.lvDanhMuc.TabIndex = 0;
            this.lvDanhMuc.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh mục";
            // 
            // txbDanhMuc
            // 
            this.txbDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDanhMuc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDanhMuc.Location = new System.Drawing.Point(681, 74);
            this.txbDanhMuc.Name = "txbDanhMuc";
            this.txbDanhMuc.Size = new System.Drawing.Size(252, 26);
            this.txbDanhMuc.TabIndex = 2;
            // 
            // BtnThem
            // 
            this.BtnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnThem.AutoSize = true;
            this.BtnThem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThem.Location = new System.Drawing.Point(581, 142);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnThem.Size = new System.Drawing.Size(92, 33);
            this.BtnThem.TabIndex = 3;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            // 
            // BtnSua
            // 
            this.BtnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSua.AutoSize = true;
            this.BtnSua.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSua.Location = new System.Drawing.Point(711, 142);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnSua.Size = new System.Drawing.Size(92, 33);
            this.BtnSua.TabIndex = 4;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            // 
            // BtnXoa
            // 
            this.BtnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnXoa.AutoSize = true;
            this.BtnXoa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.Location = new System.Drawing.Point(841, 142);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnXoa.Size = new System.Drawing.Size(92, 33);
            this.BtnXoa.TabIndex = 5;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            // 
            // UC_DanhMucVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.txbDanhMuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDanhMuc);
            this.Name = "UC_DanhMucVatTu";
            this.Size = new System.Drawing.Size(1000, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDanhMuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDanhMuc;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnXoa;
    }
}
