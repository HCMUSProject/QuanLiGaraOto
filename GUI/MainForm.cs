using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void AutoSlideBar(Button ct)
        {
            slideBar.Height = ct.Height;
            slideBar.Top = ct.Top;
        }
        private void BtnDichVuSuaChua_Click(object sender, EventArgs e)
        {
            AutoSlideBar(BtnDichVuSuaChua);
        }

        private void BtnVatTu_Click(object sender, EventArgs e)
        {
            AutoSlideBar(BtnVatTu);
        }

        private void BtnBaoCao_Click(object sender, EventArgs e)
        {
            AutoSlideBar(BtnBaoCao);
        }

        private void BtnQuanLiKhachHang_Click(object sender, EventArgs e)
        {
            AutoSlideBar(BtnQuanLiKhachHang);
        }
    }
}
