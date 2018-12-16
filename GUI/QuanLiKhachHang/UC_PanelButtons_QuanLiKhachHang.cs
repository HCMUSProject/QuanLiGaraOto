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
    public partial class UC_PanelButtons_QuanLiKhachHang : UserControl
    {
        private static UC_PanelButtons_QuanLiKhachHang _instance;

        public static UC_PanelButtons_QuanLiKhachHang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_PanelButtons_QuanLiKhachHang();
                }
                return _instance;
            }
        }

        public event EventHandler OnButtonClick;

        public UC_PanelButtons_QuanLiKhachHang()
        {
            InitializeComponent();
        }

        private void BtnQuanLiKhachHang_Click(object sender, EventArgs e)
        {
            OnButtonClick?.Invoke(sender, e);
        }

        private void BtnXemThongTin_Click(object sender, EventArgs e)
        {
            OnButtonClick?.Invoke(sender, e);
        }
    }
}
