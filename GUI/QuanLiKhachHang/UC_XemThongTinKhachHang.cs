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
    public partial class UC_XemThongTinKhachHang : UserControl
    {
        private static UC_XemThongTinKhachHang _instance;
        public static UC_XemThongTinKhachHang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_XemThongTinKhachHang();
                }
                return _instance;
            }
        }

        public UC_XemThongTinKhachHang()
        {
            InitializeComponent();
        }
    }
}
