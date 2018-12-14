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
    public partial class UC_LapPhieuSuaChua : UserControl
    {
        private static UC_LapPhieuSuaChua _instance;
        public static UC_LapPhieuSuaChua Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_LapPhieuSuaChua();
                }
                return _instance;
            }
        }

        public UC_LapPhieuSuaChua()
        {
            InitializeComponent();
        }
    }
}
