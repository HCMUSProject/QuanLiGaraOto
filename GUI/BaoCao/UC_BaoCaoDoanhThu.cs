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
        BUS_Khachhangsuachua BUS_KHSC = new BUS_Khachhangsuachua();
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
        public void capNhatdtgvTienNhapVatTu()
        {
            dtgvTienNhapVatTu.DataSource = null;
            // UC_QuanLiKhachHang KHSC;
            UC_BaoCaoDoanhThu KHSC = new UC_BaoCaoDoanhThu();

            UC_BaoCaoDoanhThu BCTK = new UC_BaoCaoDoanhThu();

            dtgvTienNhapVatTu.DataSource = KHSC.BUS_KHSC.getKhachHangSuaChua();



            dtgvTienNhapVatTu.DataSource = KHSC.BUS_KHSC.getKhachHangSuaChua();

            //ẩn cột mã khách hàng
            //dtgvTienNhapVatTu.Columns["Makhachhang"].Visible = false;
            dtgvTienNhapVatTu.Columns["HangSanXuat"].Visible = false;
            dtgvTienNhapVatTu.Columns["VatTu"].Visible = false;
            dtgvTienNhapVatTu.Columns["SoLuong"].Visible = false;
            dtgvTienNhapVatTu.Columns["NgayNhap"].Visible = false;
            dtgvTienNhapVatTu.Columns["TongTien"].Visible = false;

            //điều chỉnh thứ tự các cột
            dtgvTienNhapVatTu.Columns["Ten"].DisplayIndex = 0;
            dtgvTienNhapVatTu.Columns["CMND"].DisplayIndex = 1;
            dtgvTienNhapVatTu.Columns["Ngaysinh"].DisplayIndex = 2;
            dtgvTienNhapVatTu.Columns["Gioitinh"].DisplayIndex = 3;
            dtgvTienNhapVatTu.Columns["Sodienthoai"].DisplayIndex = 2;
            dtgvTienNhapVatTu.Columns["Diachi"].DisplayIndex = 5;

            //Thay đổi tên các cột
            dtgvTienNhapVatTu.Columns["Ten"].HeaderText = "Tên khách hàng";
            dtgvTienNhapVatTu.Columns["Ngaysinh"].HeaderText = "Ngày sinh";
            dtgvTienNhapVatTu.Columns["Gioitinh"].HeaderText = "Giới tính";
            dtgvTienNhapVatTu.Columns["Sodienthoai"].HeaderText = "SĐT";
            dtgvTienNhapVatTu.Columns["Diachi"].HeaderText = "Địa chỉ";

            /*
            //resize chiều rộng các cột
            dtgvTonKho.Columns["Ten"].FillWeight = 180;
            dtgvTonKho.Columns["Ngaysinh"].FillWeight = 80;
            dtgvTonKho.Columns["Gioitinh"].FillWeight = 40;
            //dtgvXe.DataSource = dtgvKhachHang.DataSource;
            */
        }
        public void capNhatdtgvTienPhiSuaChua()
        {

            //cập nhật mấy cái datagrid view
            dtgvTienPhiSuaChua.DataSource = null;
            //dtgvTienPhiSuaChua.Columns[0].Visible = dtgvTienPhiSuaChua.Columns[1].Visible = false;
            //dtgvTienPhiSuaChua.Columns[2].Visible = dtgvTienPhiSuaChua.Columns[3].Visible = false;

            UC_BaoCaoDoanhThu KHSC = new UC_BaoCaoDoanhThu();
            DateTime temp = new DateTime();

            // Tạo DTo
            //DTO_Khachhangsuachua DTO_KHSC = new DTO_Khachhangsuachua( "", "", "", "", "");
            // Tìm kiếm
            dtgvTienPhiSuaChua.DataSource = KHSC.BUS_KHSC.getKhachHangSuaChua();

            //ẩn cột mã khách hàng
            //dtgvTienNhapVatTu.Columns["Makhachhang"].Visible = false;
            dtgvTienPhiSuaChua.Columns["MaHoaDon"].Visible = false;
            dtgvTienPhiSuaChua.Columns["NgayXuatHoaDon"].Visible = false;
            dtgvTienPhiSuaChua.Columns["ThanhTien"].Visible = false;
            //dtgvTienNhapVatTu.Columns["NgayNhap"].Visible = false;
            //dtgvTienNhapVatTu.Columns["TongTien"].Visible = false;

            //điều chỉnh thứ tự các cột
            dtgvTienPhiSuaChua.Columns["Ten"].DisplayIndex = 0;
            dtgvTienPhiSuaChua.Columns["CMND"].DisplayIndex = 1;
            dtgvTienPhiSuaChua.Columns["Ngaysinh"].DisplayIndex = 2;
            dtgvTienPhiSuaChua.Columns["Gioitinh"].DisplayIndex = 3;
            //dtgvTienNhapVatTu.Columns["Sodienthoai"].DisplayIndex = 2;
            //dtgvTienNhapVatTu.Columns["Diachi"].DisplayIndex = 5;

            //Thay đổi tên các cột
            dtgvTienPhiSuaChua.Columns["Ten"].HeaderText = "Tên khách hàng";
            dtgvTienPhiSuaChua.Columns["Ngaysinh"].HeaderText = "Ngày sinh";
            dtgvTienPhiSuaChua.Columns["Gioitinh"].HeaderText = "Giới tính";
            //dtgvTienNhapVatTu.Columns["Sodienthoai"].HeaderText = "SĐT";
            //dtgvTienNhapVatTu.Columns["Diachi"].HeaderText = "Địa chỉ";

        }
        public void UC_BaoCaoDoanhThu_Load()
        {
            capNhatdtgvTienNhapVatTu();
            capNhatdtgvTienPhiSuaChua();
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

        private void dtgvTonKho_Click(object sender, EventArgs e)
        {
            /*
            dtgvXe.DataSource = null;
            */

            DataGridViewRow row = dtgvTienNhapVatTu.SelectedRows[0];
            //cells[0] vì id khách hàng nằm ở cột thứ nhất
            string a = row.Cells[0].Value.ToString();
            /*
            capNhatdtgvXeKhachHang(int.Parse(a));
            */
        }
    }
}
