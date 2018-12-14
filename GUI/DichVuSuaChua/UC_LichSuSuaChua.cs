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
    public partial class UC_LichSuSuaChua : UserControl
    {
        private static UC_LichSuSuaChua _instance;
        public static UC_LichSuSuaChua Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_LichSuSuaChua();
                }
                return _instance;
            }
        }

        public UC_LichSuSuaChua()
        {
            InitializeComponent();
        }
    }
}
