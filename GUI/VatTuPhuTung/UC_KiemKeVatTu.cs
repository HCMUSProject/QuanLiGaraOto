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
    public partial class UC_KiemKeVatTu : UserControl
    {
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
    }
}
