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
    public partial class UC_BaoCaoTonKho : UserControl
    {
        private static UC_BaoCaoTonKho _instance;
        public static UC_BaoCaoTonKho Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_BaoCaoTonKho();
                }
                return _instance;
            }
        }
        public void capNhatdtgvTonKho()
        {
            dtgvTonKho.DataSource = null;

            BUS_KiemKeVatTu bus_KiemKe = new BUS_KiemKeVatTu();
            // load bảng vật tư từ database

            DataTable dtThongTinVatTu = bus_KiemKe.BUS_GetThongTinVatTu();

            Exception ex = bus_KiemKe.GetException();
            if (ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            dtgvTonKho.DataSource = dtThongTinVatTu;

            dtgvTonKho.Columns["Tendanhmuc"].HeaderText = "Tên danh mục";
            dtgvTonKho.Columns["Mavattu"].HeaderText = "Mã vật tư";
            dtgvTonKho.Columns["Tenvattu"].HeaderText = "Tên vật tư";
            dtgvTonKho.Columns["Soluong"].HeaderText = "Số lượng còn lại";

            //ẩn cột 
            
            //dtgvTonKho.Columns["HangSanXuat"].Visible = false;
            //dtgvTonKho.Columns["VatTu"].Visible = false;
            //dtgvTonKho.Columns["SoLuongNhap"].Visible = false;
            //dtgvTonKho.Columns["SoLuongDung"].Visible = false;
            //dtgvTonKho.Columns["SoLuongConLai"].Visible = false;

            //điều chỉnh thứ tự các cột
            //dtgvTonKho.Columns["Tendanhmuc"].DisplayIndex = 0;
            //dtgvTonKho.Columns["Mavattu"].DisplayIndex = 1;
            //dtgvTonKho.Columns["Tenvattu"].DisplayIndex = 2;
            //dtgvTonKho.Columns["Soluong"].DisplayIndex = 3;
            //dtgvTonKho.Columns["SoLuongDung"].DisplayIndex = 4;
            //dtgvTonKho.Columns["SoLuongConLai"].DisplayIndex = 3;
        }
        public void XoaDuLieu()
        {
            dtgvTonKho.Refresh();
        }
        public void UC_BaoCaoTonKho_Load()
        {
            dtpkFrom.Value = DateTime.Now;
            dtpkTo.Value = DateTime.Now;
            
        }
        public UC_BaoCaoTonKho()
        {
            InitializeComponent();
        }

        private void BtnXemTonKho_Click_1(object sender, EventArgs e)
        {
            if (dtpkFrom.Value == dtpkTo.Value)

            {
                MessageBox.Show("Ngày bắt đầu và ngày kết thúc phải khác nhau!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                capNhatdtgvTonKho();
            }
        }
    }
}
