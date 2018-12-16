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
    public partial class UC_PanelButtons_BaoCao : UserControl
    {
        private static UC_PanelButtons_BaoCao _instance;

        public static UC_PanelButtons_BaoCao Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_PanelButtons_BaoCao();
                }
                return _instance;
            }
        }

        public event EventHandler OnButtonClick;

        public UC_PanelButtons_BaoCao()
        {
            InitializeComponent();
        }

        private void BtnBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            OnButtonClick?.Invoke(sender, e);
        }

        private void BtnBaoCaoTonKho_Click(object sender, EventArgs e)
        {
            OnButtonClick?.Invoke(sender, e);
        }
    }
}
