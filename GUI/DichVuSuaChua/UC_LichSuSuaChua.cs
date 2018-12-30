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
    public partial class UC_LichSuSuaChua : UserControl
    {
        private static UC_LichSuSuaChua _instance;
        BUS_Lichsusuachua lichsu = new BUS_Lichsusuachua();
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

        public void XoaDuLieu()
        {
            if (dtgvChiTietSuaChua.DataSource != null)
            {
                dtgvChiTietSuaChua.DataSource = null;
            }
            else
            {
                dtgvChiTietSuaChua.Rows.Clear();
            }
            dtgvChiTietSuaChua.Refresh();

            if (dtgvLichSu.DataSource != null)
            {
                dtgvLichSu.DataSource = null;
            }
            else
            {
                dtgvLichSu.Rows.Clear();
            }
            dtgvLichSu.Refresh();

            txbTongTien.Text = "";
        }

        public string getDateBegin()
        {
            return dtFrom.Value.ToShortDateString();
        }
        public string getDateEnd()
        {
            return dtTo.Value.ToShortDateString();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            
            XoaDuLieu();
            
            BindingSource SBind = new BindingSource();
            dtgvLichSu.Columns.Clear();
            SBind.DataSource = lichsu.getLichsu(getDateBegin(),getDateEnd());
            dtgvLichSu.DataSource = SBind;
            dtgvLichSu.Columns[0].HeaderText = "Khách hàng";
            dtgvLichSu.Columns[1].HeaderText = "Hiệu xe";
            dtgvLichSu.Columns[2].HeaderText = "Biển số";
            dtgvLichSu.Columns[3].HeaderText = "Ngày vào";
            dtgvLichSu.Columns[4].HeaderText = "Ngày xuất";
            dtgvLichSu.Columns[5].Visible = false;
            //MessageBox.Show(dtgvLichSu.Rows[0].Cells[5].Value.ToString());
        }

        private void dtgvLichSu_SelectionChanged(object sender, EventArgs e)
        {
            txbTongTien.Text = "";
            if (dtgvLichSu.Rows.Count > 0)
            {
                if (dtgvChiTietSuaChua.DataSource != null)
                {
                    dtgvChiTietSuaChua.DataSource = null;
                }
                else
                {
                    dtgvChiTietSuaChua.Rows.Clear();
                }
                dtgvChiTietSuaChua.Refresh();

                foreach (DataGridViewRow row in dtgvLichSu.SelectedRows)
                {
                    BindingSource SBind = new BindingSource();
                    dtgvChiTietSuaChua.Columns.Clear();
                    SBind.DataSource = lichsu.getChitiet(row.Cells[5].Value.ToString());
                    dtgvChiTietSuaChua.DataSource = SBind;
                    dtgvChiTietSuaChua.Columns[0].HeaderText = "Loại dịch vụ";
                    dtgvChiTietSuaChua.Columns[1].HeaderText = "Phụ tùng";
                    dtgvChiTietSuaChua.Columns[2].HeaderText = "Số lượng";
                    dtgvChiTietSuaChua.Columns[3].HeaderText = "Đơn giá";

                }
                int tongtien = 0;
                foreach (DataGridViewRow row in dtgvChiTietSuaChua.Rows)
                {
                    tongtien += Int32.Parse(row.Cells[3].Value.ToString());
                }
                txbTongTien.Text = tongtien.ToString();
            }
            else
                return;
        }
    }
}
