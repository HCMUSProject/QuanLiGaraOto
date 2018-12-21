using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI.DichVuSuaChua
{
    public partial class UC_TiepNhanXe : UserControl
    {
        BUS_Tiepnhanxe busTNX = new BUS_Tiepnhanxe();
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

        public event EventHandler OnButtonAddCustomerClick;

        public UC_TiepNhanXe()
        {
            InitializeComponent();
          
           
        }

        public void XoaDuLieu()
        {
            cmbHangXe.Text = "";
            cmbHangXe.Items.Clear();
            cmbHangXe.SelectedIndex = -1;

            cmbHieuXe.Text = "";
            cmbHieuXe.Items.Clear();
            cmbHieuXe.SelectedIndex = -1;

            cmbKhachHang.Text = "";
            cmbKhachHang.Items.Clear();
            cmbKhachHang.SelectedIndex = -1;

            txbBienSo.Text = String.Empty;
           
            txbTenXe.Text = String.Empty;
        }
        public string getHangxe()
        {
            return this.cmbHangXe.GetItemText(this.cmbHangXe.SelectedItem);
        }
        public string getHieuxe()
        {
            return this.cmbHieuXe.GetItemText(this.cmbHieuXe.SelectedItem);
        }
        public string getKhachhang()
        {
            return this.cmbKhachHang.GetItemText(this.cmbKhachHang.SelectedItem);
        }
        private void UC_TiepNhanXe_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < busTNX.getKhachhang().Rows.Count; i++)
            {
                cmbKhachHang.Items.Add(busTNX.getKhachhang().Rows[i][0] + " - " + busTNX.getKhachhang().Rows[i][1]);
            }

            ///


            ///

        }
       public void Load2()
        {
            for (int i = 0; i < busTNX.getKhachhang().Rows.Count; i++)
            {
                cmbKhachHang.Items.Add(busTNX.getKhachhang().Rows[i][0] + " - " + busTNX.getKhachhang().Rows[i][1]);
            }

        }
        private void BtnTiepNhanXe_Click(object sender, EventArgs e)
        {
           
           if(getKhachhang()=="")
            {
                MessageBox.Show("Vui lòng chọn khách hàng","Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           else if (getHangxe() == "")
            {
                MessageBox.Show("Vui lòng chọn hãng xe", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           else if( getHieuxe()== "")
            {
                MessageBox.Show("Vui lòng chọn hiệu xe", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           else if(txbTenXe.Text=="")
            {
                MessageBox.Show("Vui lòng nhập tên xe", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           else if(txbBienSo.Text=="")
            {
                MessageBox.Show("Vui lòng nhập biển số", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (busTNX.Checkbienso(txbBienSo.Text) == false)
            {
                DialogResult res = MessageBox.Show("Biển số đã tồn tại", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                    txbBienSo.Text = String.Empty;
            }
            else
            {

                // MessageBox.Show(busTNX.getMahangxe(getHangxe()));
                string s = getKhachhang().Substring((getKhachhang().LastIndexOf('-') + 1)).Trim();
                string a = busTNX.getMakhachhang(s);
                // MessageBox.Show(DateTime.Parse(dateNhapXe.Value.ToShortDateString()).ToString());
                DTO_Xe xe = new DTO_Xe(0, txbTenXe.Text, busTNX.getMahangxe(getHangxe()), busTNX.getMahieuxe(getHieuxe()),
                    txbBienSo.Text, Int32.Parse(a), DateTime.Parse(dateNhapXe.Value.ToShortDateString()));
                DialogResult result;
                if (busTNX.themXe(xe))
                {
                     result=MessageBox.Show("Thêm xe thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    result=MessageBox.Show("Thêm xe thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (result == DialogResult.OK)
                {
                    XoaDuLieu();
                    UC_TiepNhanXe_Load(sender, e);
                }
            }
        }

        private void BtnThemKhachHang_Click(object sender, EventArgs e)
        {
            OnButtonAddCustomerClick?.Invoke(sender, e);
        }

        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow dr in busTNX.getHangxe().Rows)
            {
                cmbHangXe.Items.Add(dr["Tenhangxe"].ToString());
            }
        }

        private void cmbHangXe_SelectedIndexChanged(object sender, EventArgs e)
        {

            //MessageBox.Show(getHangxe());
            foreach (DataRow dr in busTNX.getHieuxe(getHangxe()).Rows)
            {
                cmbHieuXe.Items.Add(dr["Tenhieuxe"].ToString());
            }
        }
    }
}
