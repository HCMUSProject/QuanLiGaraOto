using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Data;

namespace GUI.VatTuPhuTung
{
    public partial class UC_QuanLiNhapKho : UserControl
    {
        BUS_QuanLiNhapKho bus_QuanLi = new BUS_QuanLiNhapKho();        

        private static UC_QuanLiNhapKho _instance;
        public static UC_QuanLiNhapKho Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_QuanLiNhapKho();
                }
                return _instance;
            }
        }

        public UC_QuanLiNhapKho()
        {
            InitializeComponent();
        }

        public void XoaDuLieu()
        {
            dtgvQuanLiNhapKho.DataSource = null;
            dtgvQuanLiNhapKho.Refresh();

            lbSoLuongVatTu.Text = "";
            lbTongTien.Text = "";
        }

        public void UC_QuanLiVatTu_Load()
        {
            dtpkFrom.Value = DateTime.Now;
            dtpkTo.Value = DateTime.Now;
        }

        private void BtnXem_Click(object sender, EventArgs e)
        {
            if (dtpkFrom.Value != dtpkTo.Value)
            {
                DataTable dt = bus_QuanLi.BUS_GetLichSuVatTu(dtpkFrom.Value, dtpkTo.Value);

                Exception ex = bus_QuanLi.GetException();

                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                dtgvQuanLiNhapKho.DataSource = dt;

                dtgvQuanLiNhapKho.Columns["Tendanhmuc"].HeaderText = "Tên danh mục";
                dtgvQuanLiNhapKho.Columns["Tenvattu"].HeaderText = "Tên vật tư";
                dtgvQuanLiNhapKho.Columns["Giathanh"].HeaderText = "Đơn giá";
                dtgvQuanLiNhapKho.Columns["Soluongnhap"].HeaderText = "Số lượng";
                dtgvQuanLiNhapKho.Columns["Ngaynhapkho"].HeaderText = "Ngày nhập kho";
                dtgvQuanLiNhapKho.Columns["Ten"].HeaderText = "Tên nhân viên";

                dtgvQuanLiNhapKho.Columns["Ngaynhapkho"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";

                dtgvQuanLiNhapKho.Columns["Giathanh"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                dtgvQuanLiNhapKho.Columns["Giathanh"].DefaultCellStyle.Format = "C";

                lbSoLuongVatTu.Text = dtgvQuanLiNhapKho.Rows.Count.ToString();

                int TongTien = 0;
                foreach(DataGridViewRow row in dtgvQuanLiNhapKho.Rows)
                {
                    TongTien += int.Parse(row.Cells["Giathanh"].Value.ToString()) * int.Parse(row.Cells["Soluongnhap"].Value.ToString());
                }

                lbTongTien.Text = TongTien.ToString();

            }
            else
            {
                MessageBox.Show("Ngày bắt đầu và ngày kết thúc phải khác nhau!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
