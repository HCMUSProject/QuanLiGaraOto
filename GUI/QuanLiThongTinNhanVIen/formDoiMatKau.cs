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
        public formDoiMatKau()
        {
            InitializeComponent();
        }

        public formDoiMatKau(string username)
        {
            InitializeComponent();

            m_strUsername = username;
        }

        private void formDoiMatKau_Load(object sender, EventArgs e)
        {
            txbTaiKhoan.Text = m_strUsername;
        }
    }
}
