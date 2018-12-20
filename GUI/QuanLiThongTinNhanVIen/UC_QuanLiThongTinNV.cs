using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QuanLiThongTinNhanVIen
{
    public partial class UC_QuanLiThongTinNV : UserControl
    {
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

        public void XoaDuLieu()
        {
            dtgvXemNhanVIen.Rows.Clear();
            dtgvXemNhanVIen.Refresh();

            txbHoTen.Text = "";
            txbTaiKhoan.Text = "";
            txbCMND.Text = "";
            txbDiaChi.Text = "";
            txbSDT.Text = "";
        }
    }
}
