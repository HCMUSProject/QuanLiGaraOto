using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DTO;
using BUS;

namespace GUI.BaoCao
{
    public partial class UC_BaoCaoDoanhThu : UserControl
    {

        BUS_DoanhThuSuaChua bus_DoanhThuSuaChua = new BUS_DoanhThuSuaChua();
        BUS_DoanhThuVatTu bus_DoanhThuVatTu = new BUS_DoanhThuVatTu();
        private static UC_BaoCaoDoanhThu _instance;
        public static UC_BaoCaoDoanhThu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_BaoCaoDoanhThu();
                }
                return _instance;
            }
        }

        public void UC_BaoCaoDoanhThu_Load()
        {
            dtpkFrom.Value = DateTime.Now;
            dtpkTo.Value = DateTime.Now;
        }
        public UC_BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        public void XoaDuLieu()
        {
            //dtgvTienNhapVatTu.Rows.Clear();
            dtgvTienNhapVatTu.Refresh();

            //dtgvTienPhiSuaChua.Rows.Clear();
            dtgvTienPhiSuaChua.Refresh();

            lbDoanhThu.Text = "";
            lbTongTienNhapVatTu.Text = "";
        }

        private void BtnXemDoanhThu_Click(object sender, EventArgs e)
        {
            if (dtpkFrom.Value != dtpkTo.Value)
            {
                DataTable dt = bus_DoanhThuVatTu.BUS_GetDoanhThuVatTu(dtpkFrom.Value, dtpkTo.Value);

                Exception ex = bus_DoanhThuVatTu.GetException();

                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                dtgvTienNhapVatTu.DataSource = dt;

                dtgvTienNhapVatTu.Columns["Tendanhmuc"].HeaderText = "Tên danh mục";
                dtgvTienNhapVatTu.Columns["Tenvattu"].HeaderText = "Tên vật tư";
                //dtgvTienNhapVatTu.Columns["Giathanh"].HeaderText = "Đơn giá";
                dtgvTienNhapVatTu.Columns["Soluongdung"].HeaderText = "Số lượng đã dùng";
                dtgvTienNhapVatTu.Columns["Tienlai"].HeaderText = "Tiền lãi";
                //dtgvTienNhapVatTu.Columns["Ngaynhapkho"].HeaderText = "Ngày nhập kho";
                //dtgvTienNhapVatTu.Columns["Ten"].HeaderText = "Tên nhân viên";

                //dtgvTienNhapVatTu.Columns["Ngaynhapkho"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";

                dtgvTienNhapVatTu.Columns["Tienlai"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                dtgvTienNhapVatTu.Columns["Tienlai"].DefaultCellStyle.Format = "C";



                int TongTienVatTu = 0;
                foreach (DataGridViewRow row in dtgvTienNhapVatTu.Rows)
                {
                    TongTienVatTu += int.Parse(row.Cells["Tienlai"].Value.ToString());
                }
                lbTongTienNhapVatTu.Text = TongTienVatTu.ToString();

                //ẩn cột tên
                //dtgvTienNhapVatTu.Columns["Ten"].Visible = false;

                DataTable dtsc = bus_DoanhThuSuaChua.BUS_GetDoanhThuSuaChua(dtpkFrom.Value, dtpkTo.Value);
                Exception exdt = bus_DoanhThuSuaChua.GetException();
                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                dtgvTienPhiSuaChua.DataSource = dtsc;
                dtgvTienPhiSuaChua.Columns["Madonhang"].HeaderText = "Mã đơn hàng";
                dtgvTienPhiSuaChua.Columns["Ngayxuat"].HeaderText = "Ngày xuất";
                dtgvTienPhiSuaChua.Columns["Tiendichvu"].HeaderText = "Tiền dịch vụ";
                //dtgvTienPhiSuaChua.Columns["Ngayxuat"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";
                int TongTienSuaChua = 0;
                foreach (DataGridViewRow row in dtgvTienPhiSuaChua.Rows)
                {
                    TongTienSuaChua += int.Parse(row.Cells["Tiendichvu"].Value.ToString());
                }
                int TongTien = TongTienVatTu + TongTienSuaChua;
                lbDoanhThu.Text = TongTien.ToString();
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu và ngày kết thúc phải khác nhau!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
