using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DTO;
using BUS;

namespace GUI.QuanLiThongTinNhanVIen
{
    public partial class UC_XemThongTinNhanVien : UserControl
    {
        private string m_strUsername;
        BUS_Account BUS_AC = new BUS_Account();
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
        public static void capNhatThongTinAccount(UC_XemThongTinNhanVien NV)
        {
            string kk = "jjd";
            MessageBox.Show(kk);
            DataTable dt = new DataTable();
            DTO_Account a = new DTO_Account(1, "admin","hdhd", 1, 1);
            dt = NV.BUS_AC.getThongTinAccount(a);
           // MessageBox.Show(dt.Rows[0][2].ToString());
        }
        public void UC_XemThongTinNhanVien_Load()
        {
            capNhatThongTinAccount(this);
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
            MessageBox.Show(m_strUsername + "bbb");
            Form DoiMatKhau = new formDoiMatKau(m_strUsername);
            DoiMatKhau.ShowDialog();
            DoiMatKhau.Close();
        }

        public void GetUsername(string Username)
        {
            m_strUsername = Username;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
