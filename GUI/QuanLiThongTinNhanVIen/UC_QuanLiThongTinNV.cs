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

namespace GUI.QuanLiThongTinNhanVIen
{
    public partial class UC_QuanLiThongTinNV : UserControl
    {
        BUS_Nhanvien BUS_NV = new BUS_Nhanvien();     
        string CMND;//kiểm tra Có đang sửa CMND hay không

        private static UC_QuanLiThongTinNV _instance;
        public static UC_QuanLiThongTinNV Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_QuanLiThongTinNV();
                }
                return _instance;
            }
        }

        public UC_QuanLiThongTinNV()
        {
            InitializeComponent();
        }
        public static void capNhatdtgvNhanVien(DataGridView dtgvNhanVien, UC_QuanLiThongTinNV NV)
        {
            dtgvNhanVien.DataSource = null;
            NV.txbCMND.Text = "";
            NV.txbDiaChi.Text = "";
            NV.txbHoTen.Text = "";
            NV.txbSDT.Text = "";
            NV.txbTaiKhoan.Text = "";
            NV.rbNam.Checked = NV.rbNu.Checked = false;

            dtgvNhanVien.DataSource = NV.BUS_NV.getNhanVien();

            //ẩn cột mã nhân viên
            dtgvNhanVien.Columns["Manhanvien"].Visible = false;

            //định dạng lại ngày
            dtgvNhanVien.Columns["Ngaysinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvNhanVien.Columns["Ngayvaolam"].DefaultCellStyle.Format = "dd/MM/yyyy";

            //Thay đổi tên các cột
            dtgvNhanVien.Columns["Ten"].HeaderText = "Tên khách hàng";
            dtgvNhanVien.Columns["Ngaysinh"].HeaderText = "Ngày sinh";
            dtgvNhanVien.Columns["Gioitinh"].HeaderText = "Giới tính";
            dtgvNhanVien.Columns["Sodienthoai"].HeaderText = "SĐT";
            dtgvNhanVien.Columns["Diachi"].HeaderText = "Địa chỉ";

            //resize chiều rộng các cột
            dtgvNhanVien.Columns["Ten"].FillWeight = 150;
            dtgvNhanVien.Columns["Ngaysinh"].FillWeight = 80;
            dtgvNhanVien.Columns["Gioitinh"].FillWeight = 40;

            dtgvNhanVien.ClearSelection();
        }
        public void XoaDuLieu()
        {
            //dtgvXemNhanVIen.Rows.Clear();
            dtgvXemNhanVIen.Refresh();

            txbHoTen.Text = "";
            txbTaiKhoan.Text = "";
            txbCMND.Text = "";
            txbDiaChi.Text = "";
            txbSDT.Text = "";
        }
        public void UC_QuanLyThongTinNV_Load()
        {
            capNhatdtgvNhanVien(dtgvXemNhanVIen, this);
        }

        private void dtgvXemNhanVIen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvXemNhanVIen_Click(object sender, EventArgs e)
        {
            if (dtgvXemNhanVIen.SelectedRows.Count > 0)
            {
                DataGridViewRow row;//dòng đang chọn
                row = dtgvXemNhanVIen.SelectedRows[0];

                // Chuyển giá trị lên form
                txbTaiKhoan.Text = row.Cells[0].Value.ToString();
                txbHoTen.Text = row.Cells[1].Value.ToString();
                txbCMND.Text = row.Cells[4].Value.ToString().Trim();
                txbSDT.Text = row.Cells[5].Value.ToString().Trim();

                //kiểm tra trong chức năng sửa có sửa CMND hay không
                CMND = txbCMND.Text;

                if (row.Cells[3].Value.ToString() == "Nam")
                {
                    rbNam.Checked = true;
                    rbNu.Checked = false;
                }
                else
                {
                    rbNam.Checked = false;
                    rbNu.Checked = true;
                }

                txbDiaChi.Text = row.Cells[6].Value.ToString();

                dtpkNgaySinh.Value = (DateTime)row.Cells[2].Value;
                dtpkNgayLam.Value = (DateTime)row.Cells[7].Value;
            }
        }
    }
}
