using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public UC_BaoCaoTonKho()
        {
            InitializeComponent();
        }
        public void XoaDuLieu()
        {
            dtgvTonKho.Rows.Clear();
            dtgvTonKho.Refresh();
        }

    }
}
