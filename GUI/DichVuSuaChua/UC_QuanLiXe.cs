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
    public partial class UC_QuanLiXe : UserControl
    {
        private static UC_QuanLiXe _instance;
        public static UC_QuanLiXe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_QuanLiXe();
                }

                return _instance;
            }
        }
        public UC_QuanLiXe()
        {
            InitializeComponent();
        }
    }
}
