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

namespace GUI.QuanLiKhachHang
{
    public partial class UC_XemThongTinKhachHang : UserControl
    {
        BUS_Khachhangsuachua BUS_KHSC = new BUS_Khachhangsuachua();
        private static UC_XemThongTinKhachHang _instance;
        public static UC_XemThongTinKhachHang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_XemThongTinKhachHang();
                }
                return _instance;
            }
        }
        public void capNhatdtgvKhachHang()
        {
            dtgvKhachHang.DataSource = null;
            // UC_QuanLiKhachHang KHSC;
            UC_XemThongTinKhachHang KHSC = new UC_XemThongTinKhachHang();
            dtgvKhachHang.DataSource = KHSC.BUS_KHSC.getKhachHangSuaChua();

            dtgvKhachHang.DataSource = KHSC.BUS_KHSC.getKhachHangSuaChua();

            //ẩn cột mã khách hàng
            dtgvKhachHang.Columns["Makhachhang"].Visible = false;

            //điều chỉnh thứ tự các cột
            dtgvKhachHang.Columns["Ten"].DisplayIndex = 0;
            dtgvKhachHang.Columns["CMND"].DisplayIndex = 1;
            dtgvKhachHang.Columns["Ngaysinh"].DisplayIndex = 2;
            dtgvKhachHang.Columns["Gioitinh"].DisplayIndex = 3;
            dtgvKhachHang.Columns["Sodienthoai"].DisplayIndex = 2;
            dtgvKhachHang.Columns["Diachi"].DisplayIndex = 5;

            //Thay đổi tên các cột
            dtgvKhachHang.Columns["Ten"].HeaderText = "Tên khách hàng";
            dtgvKhachHang.Columns["Ngaysinh"].HeaderText = "Ngày sinh";
            dtgvKhachHang.Columns["Gioitinh"].HeaderText = "Giới tính";
            dtgvKhachHang.Columns["Sodienthoai"].HeaderText = "SĐT";
            dtgvKhachHang.Columns["Diachi"].HeaderText = "Địa chỉ";

            //resize chiều rộng các cột
            dtgvKhachHang.Columns["Ten"].FillWeight = 180;
            dtgvKhachHang.Columns["Ngaysinh"].FillWeight = 80;
            dtgvKhachHang.Columns["Gioitinh"].FillWeight = 40;
            //dtgvXe.DataSource = dtgvKhachHang.DataSource;
        }
        public void capNhatdtgvXeKhachHang(int id)//id của khách hàng
        {

            //cập nhật mấy cái datagrid view
            dtgvXe.DataSource = null;
            dtgvXe.Columns[0].Visible = dtgvXe.Columns[1].Visible = false;
            dtgvXe.Columns[2].Visible = dtgvXe.Columns[3].Visible = false;

            UC_XemThongTinKhachHang KHSC = new UC_XemThongTinKhachHang();
            DateTime temp = new DateTime();

            // Tạo DTo
            DTO_Khachhangsuachua DTO_KHSC = new DTO_Khachhangsuachua(id, "", "", "", "", "", temp);
            // Tìm kiếm
            dtgvXe.DataSource = KHSC.BUS_KHSC.getThongTinXe(DTO_KHSC);

            //Thay đổi tên các cột
            dtgvXe.Columns["Tenhangxe"].HeaderText = "Hãng xe";
            dtgvXe.Columns["Tenhieuxe"].HeaderText = "Hiệu xe";
            dtgvXe.Columns["Tenxe"].HeaderText = "Tên xe";
            dtgvXe.Columns["Bienso"].HeaderText = "Biển số";

        }
        public void XoaDuLieu()
        {
            //dtgvKhachHang.Rows.Clear();
            dtgvKhachHang.Refresh();

           // dtgvXe.Rows.Clear();
            dtgvXe.Refresh();
        }
        public void UC_XemThongTinKhachHang_Load()
        {
            capNhatdtgvKhachHang();
        }
        public UC_XemThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void dtgvKhachHang_Click(object sender, EventArgs e)
        {
            dtgvXe.DataSource = null;

            DataGridViewRow row = dtgvKhachHang.SelectedRows[0];
            //cells[0] vì id khách hàng nằm ở cột thứ nhất
            string a = row.Cells[0].Value.ToString();
            capNhatdtgvXeKhachHang(int.Parse(a));
        }
    }
}
