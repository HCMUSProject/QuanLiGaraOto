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
    public partial class UC_PanelButtons_VatTuPhuTung : UserControl
    {
        private static UC_PanelButtons_VatTuPhuTung _instance;

        public static UC_PanelButtons_VatTuPhuTung Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_PanelButtons_VatTuPhuTung();
                }
                return _instance;
            }
        }

        public event EventHandler OnButtonClick;

        public UC_PanelButtons_VatTuPhuTung()
        {
            InitializeComponent();
        }

        private void BtnDanhMucVatTu_Click(object sender, EventArgs e)
        {
            OnButtonClick?.Invoke(sender, e);
        }

        private void BtnCapNhatVatTu_Click(object sender, EventArgs e)
        {
            OnButtonClick?.Invoke(sender, e);
        }

        private void BtnQuanLiNhapKho_Click(object sender, EventArgs e)
        {
            OnButtonClick?.Invoke(sender, e);
        }

        private void BtnKiemKeVatTu_Click(object sender, EventArgs e)
        {
            OnButtonClick?.Invoke(sender, e);
        }
    }
}
