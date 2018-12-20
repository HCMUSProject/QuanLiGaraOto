using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.VatTuPhuTung
{
    public partial class UC_CapNhatVatTu : UserControl
    {
        private static UC_CapNhatVatTu _instance;
        public static UC_CapNhatVatTu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_CapNhatVatTu();
                }
                return _instance;
            }
        }

        public UC_CapNhatVatTu()
        {
            InitializeComponent();
        }

        public void XoaDuLieu()
        {
            dtgvVatTu.Rows.Clear();

            cmbDanhMuc.Text = "";
            cmbDanhMuc.DataSource = null;

            cmbHangSanXuat.Text = "";
            cmbHangSanXuat.DataSource = null;

            txbDonGia.Text = "";
            txbSoLuong.Text = "";
            txbVatTu.Text = "";
        }
    }
}
