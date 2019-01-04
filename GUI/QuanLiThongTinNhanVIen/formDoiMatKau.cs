using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.QuanLiThongTinNhanVIen
{
    public partial class formDoiMatKau : Form
    {
        private string m_strUsername;
        private int m_MaNhanVien;
        public formDoiMatKau()
        {
            InitializeComponent();
        }

        public formDoiMatKau(string username)
        {
            InitializeComponent();

            m_strUsername = username;
        }
        public formDoiMatKau(string username,int maNhanVien)
        {
            InitializeComponent();

            m_strUsername = username;
            m_MaNhanVien = maNhanVien;
        }

        private void formDoiMatKau_Load(object sender, EventArgs e)
        {
            txbTaiKhoan.Text = m_MaNhanVien.ToString();            
        }

        private void txbTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
