using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BUS;

namespace GUI.VatTuPhuTung
{
    public partial class UC_KiemKeVatTu : UserControl
    {
        #region variable
        private bool isLoaded = false;

        BUS_KiemKeVatTu bus_KiemKe = new BUS_KiemKeVatTu();

        #endregion

        private static UC_KiemKeVatTu _instance;
        public static UC_KiemKeVatTu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_KiemKeVatTu();
                }
                return _instance;
            }
        }

        public UC_KiemKeVatTu()
        {
            InitializeComponent();
        }

        public void XoaDuLieu()
        {
            dtgvKiemKeVatTu.DataSource = null;
            dtgvKiemKeVatTu.Refresh();

            isLoaded = false;
        }

        public void UC_KiemKeVatTu_Load()
        {
            // load bảng vật tư từ database

            DataTable dtThongTinVatTu = bus_KiemKe.BUS_GetThongTinVatTu();

            Exception ex = bus_KiemKe.GetException();
            if (ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            dtgvKiemKeVatTu.DataSource = dtThongTinVatTu;

            dtgvKiemKeVatTu.Columns["Tendanhmuc"].HeaderText = "Tên danh mục";
            dtgvKiemKeVatTu.Columns["Mavattu"].HeaderText = "Mã vật tư";
            dtgvKiemKeVatTu.Columns["Tenvattu"].HeaderText = "Tên vật tư";
            dtgvKiemKeVatTu.Columns["Soluong"].HeaderText = "Số lượng";

        }
    }
}
