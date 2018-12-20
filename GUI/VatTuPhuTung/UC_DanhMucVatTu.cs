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
    public partial class UC_DanhMucVatTu : UserControl
    {
        private static UC_DanhMucVatTu _instance;
        public static UC_DanhMucVatTu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_DanhMucVatTu();
                }
                return _instance;
            }
        }

        public UC_DanhMucVatTu()
        {
            InitializeComponent();
        }

        public void XoaDuLieu()
        {
            dtgvDanhMuc.Rows.Clear();
            dtgvDanhMuc.Refresh();

            txbDanhMuc.Text = "";
        }
    }
}
