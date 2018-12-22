using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI.DichVuSuaChua
{
    public partial class UC_QuanLiXe : UserControl
    {
        BUS_Quanlixe busquanlixe = new BUS_Quanlixe();
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

        public void XoaDuLieu()
        {
            if (dtgvQuanLiXe.DataSource != null)
            {
                dtgvQuanLiXe.DataSource = null;
            }
            else
            {
                dtgvQuanLiXe.Rows.Clear();
            }

            dtgvQuanLiXe.Refresh();

            TotalCars.Text = "";
            NumOfCarsToday.Text = "";
        }
        private void UC_QuanLiXe_Load(object sender, EventArgs e)
        {
            BindingSource SBind = new BindingSource();
            dtgvQuanLiXe.Columns.Clear();
            SBind.DataSource = busquanlixe.getXe();
            dtgvQuanLiXe.DataSource = SBind;
            dtgvQuanLiXe.Columns[0].HeaderText="Khách hàng";
            dtgvQuanLiXe.Columns[1].HeaderText = "CMND";
            dtgvQuanLiXe.Columns[2].HeaderText = "Địa chỉ";
            dtgvQuanLiXe.Columns[3].HeaderText = "Tên hãng xe";
            dtgvQuanLiXe.Columns[4].HeaderText = "Tên hiệu xe";
            dtgvQuanLiXe.Columns[5].HeaderText = "Biển số";
            dtgvQuanLiXe.Columns[6].HeaderText = "Ngày nhập gara";

            NumOfCarsToday.Text = busquanlixe.getslxehomnay().ToString();
            TotalCars.Text = busquanlixe.getslxgara().ToString();
        }
        public void Load2()
        {
            BindingSource SBind = new BindingSource();
            dtgvQuanLiXe.Columns.Clear();
            SBind.DataSource = busquanlixe.getXe();
            dtgvQuanLiXe.DataSource = SBind;
            dtgvQuanLiXe.Columns[0].HeaderText = "Khách hàng";
            dtgvQuanLiXe.Columns[1].HeaderText = "CMND";
            dtgvQuanLiXe.Columns[2].HeaderText = "Địa chỉ";
            dtgvQuanLiXe.Columns[3].HeaderText = "Tên hãng xe";
            dtgvQuanLiXe.Columns[4].HeaderText = "Tên hiệu xe";
            dtgvQuanLiXe.Columns[5].HeaderText = "Biển số";
            dtgvQuanLiXe.Columns[6].HeaderText = "Ngày nhập gara";

            NumOfCarsToday.Text = busquanlixe.getslxehomnay().ToString();
            TotalCars.Text = busquanlixe.getslxgara().ToString();
        }
    }
}
