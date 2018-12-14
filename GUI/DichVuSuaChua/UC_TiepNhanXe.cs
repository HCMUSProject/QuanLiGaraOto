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
    public partial class UC_TiepNhanXe : UserControl
    {
        private static UC_TiepNhanXe _instance;

        public static UC_TiepNhanXe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_TiepNhanXe();
                }
                return _instance;
            }
        }

        public UC_TiepNhanXe()
        {
            InitializeComponent();
        }

        private void UC_TiepNhanXe_Load(object sender, EventArgs e)
        {

        }

        private void BtnTiepNhanXe_Click(object sender, EventArgs e)
        {
            
        }
    }
}
