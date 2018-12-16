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
    public partial class UC_BaoCaoDoanhThu : UserControl
    {
        private static UC_BaoCaoDoanhThu _instance;
        public static UC_BaoCaoDoanhThu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_BaoCaoDoanhThu();
                }
                return _instance;
            }
        }

        public UC_BaoCaoDoanhThu()
        {
            InitializeComponent();
        }
    }
}
