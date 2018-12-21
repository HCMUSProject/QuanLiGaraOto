using GUI.Properties;
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
    public partial class formDangNhap : Form
    {
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            picAvatar.Image = Resources.user_login_128;
            //picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
