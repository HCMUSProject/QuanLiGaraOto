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
    public partial class UC_XemThongTinNhanVien : UserControl
    {
        private string m_strUsername;

        private static UC_XemThongTinNhanVien _instance;
        public static UC_XemThongTinNhanVien Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_XemThongTinNhanVien();
                }
                return _instance;
            }
        }

        public UC_XemThongTinNhanVien()
        {
            InitializeComponent();
        }

        public void XoaDuLieu()
        {
            txbHoTen.Text = "";
            txbTaiKhoan.Text = "";
            txbCMND.Text = "";
            txbDiaChi.Text = "";
            txbSDT.Text = "";
        }

        private void BtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            // sẽ truyền vào là tài khoản
            Form DoiMatKhau = new formDoiMatKau(m_strUsername);
            DoiMatKhau.ShowDialog();
            DoiMatKhau.Close();
        }

        public void GetUsername(string Username)
        {
            m_strUsername = Username;
        }
    }
}
