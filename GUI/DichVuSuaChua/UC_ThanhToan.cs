using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DichVuSuaChua
{
    public partial class UC_ThanhToan : UserControl
    {
        private static UC_ThanhToan _instance;
        public static UC_ThanhToan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_ThanhToan();
                }
                return _instance;
            }
        }

        public UC_ThanhToan()
        {
            InitializeComponent();
        }

        public void XoaDuLieu()
        {
            cmbKhachHang.Text = "";
            cmbKhachHang.DataSource = null;

            cmbBienSoXe.Text = "";
            cmbBienSoXe.DataSource = null;

            txbDienThoai.Text = "";
            txbHieuXe.Text = "";
            txbMaPhieu.Text = "";
            txbNhanVien.Text = "";
            txbTongTien.Text = "";

            dtgvChiTietSuaChua.Rows.Clear();
            dtgvChiTietSuaChua.Refresh();
        }

        private void UC_ThanhToan_Load(object sender, EventArgs e)
        {

        }
    }
}
