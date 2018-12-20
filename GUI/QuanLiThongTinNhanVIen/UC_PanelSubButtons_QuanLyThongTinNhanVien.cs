using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QuanLiThongTinNhanVIen
{
    public partial class UC_PanelSubButtons_QuanLyThongTinNhanVien : UserControl
    {
        private static UC_PanelSubButtons_QuanLyThongTinNhanVien _instance;

        public static UC_PanelSubButtons_QuanLyThongTinNhanVien Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_PanelSubButtons_QuanLyThongTinNhanVien();
                }
                return _instance;
            }
        }

        public event EventHandler OnButtonClick;

        public UC_PanelSubButtons_QuanLyThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void BtnQuanLiNhanVien_Click(object sender, EventArgs e)
        {
            OnButtonClick?.Invoke(sender, e);
        }

        private void BtnXemThongTin_Click(object sender, EventArgs e)
        {
            OnButtonClick?.Invoke(sender, e);
        }
    }
}
