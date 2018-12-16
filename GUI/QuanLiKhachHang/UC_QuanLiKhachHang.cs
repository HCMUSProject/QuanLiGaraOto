using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QuanLiKhachHang
{
    public partial class UC_QuanLiKhachHang : UserControl
    {
        private static UC_QuanLiKhachHang _instance;
        public static UC_QuanLiKhachHang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_QuanLiKhachHang();
                }
                return _instance;
            }
        }

        public UC_QuanLiKhachHang()
        {
            InitializeComponent();
        }
    }
}
