using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DichVuSuaChua
{
    public partial class UC_PanelButtons_DichVuSuaChua : UserControl
    {
        private static UC_PanelButtons_DichVuSuaChua _instance;

        public static UC_PanelButtons_DichVuSuaChua Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_PanelButtons_DichVuSuaChua();
                }
                return _instance;
            }
        }

        public event EventHandler OnButtonClick;

        public UC_PanelButtons_DichVuSuaChua()
        {
            InitializeComponent();
        }

        private void BtnTiepNhanXe_Click(object sender, EventArgs e)
        {
            OnButtonClick?.Invoke(sender, e);
        }

        private void BtnQuanLiXe_Click(object sender, EventArgs e)
        {
            OnButtonClick?.Invoke(sender, e);

        }

        private void BtnLapPhieu_Click(object sender, EventArgs e)
        {
            OnButtonClick?.Invoke(sender, e);

        }

        private void BtnLichSuSuaChua_Click(object sender, EventArgs e)
        {
            OnButtonClick?.Invoke(sender, e);

        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            OnButtonClick?.Invoke(sender, e);
        }
    }
}
