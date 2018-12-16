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
    public partial class UC_QuanLiNhapKho : UserControl
    {
        private static UC_QuanLiNhapKho _instance;
        public static UC_QuanLiNhapKho Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_QuanLiNhapKho();
                }
                return _instance;
            }
        }

        public UC_QuanLiNhapKho()
        {
            InitializeComponent();
        }
    }
}
