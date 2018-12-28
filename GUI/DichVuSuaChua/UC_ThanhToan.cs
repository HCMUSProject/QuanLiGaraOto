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
    public partial class UC_ThanhToan : UserControl
    {
        BUS_Thanhtoan thanhtoan = new BUS_Thanhtoan();
        private static UC_ThanhToan _instance;
        public static UC_ThanhToan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_ThanhToan();
                }
                return _instance;
            }
        }

        public UC_ThanhToan()
        {
            InitializeComponent();
        }

        public void XoaDuLieu()
        {
            cmbKhachHang.Text = "";
            cmbKhachHang.DataSource = null;
            cmbKhachHang.Items.Clear();
            cmbKhachHang.SelectedIndex = -1;

            cmbBienSoXe.Text = "";
            cmbBienSoXe.DataSource = null;
            cmbBienSoXe.Items.Clear();
            cmbBienSoXe.SelectedIndex = -1;

            cmbHieuxe.Text = "";
            cmbHieuxe.DataSource = null;
            cmbHieuxe.Items.Clear();
            cmbHieuxe.SelectedIndex = -1;

            txbDienThoai.Text = "";
           // txbHieuXe.Text = "";
            txbMaPhieu.Text = "";
            txbNhanVien.Text = "";
            txbTongTien.Text = "";

            if (dtgvChiTietSuaChua.DataSource != null)
            {
                dtgvChiTietSuaChua.DataSource = null;
            }
            else
            {
                dtgvChiTietSuaChua.Rows.Clear();
            }
            dtgvChiTietSuaChua.Refresh();
        }

        private void UC_ThanhToan_Load(object sender, EventArgs e)
        {
            txbMaPhieu.Enabled = false;
            txbDienThoai.Enabled = false;
            txbNhanVien.Enabled = false;
            txbTongTien.Enabled = false;
            cmbHieuxe.Enabled = false;
            cmbBienSoXe.Enabled = false;
            dtpkNgayThanhToan.Enabled = false;
           string tmp = txbMaPhieu.Text = thanhtoan.getMaxid();
            if(tmp=="")
            {
                tmp = "-1";
            }
            txbMaPhieu.Text = (Int32.Parse(tmp)+1).ToString();
            for (int i = 0; i < thanhtoan.getKhachhang().Rows.Count; i++)
            {
                cmbKhachHang.Items.Add(thanhtoan.getKhachhang().Rows[i][0] + " - " + thanhtoan.getKhachhang().Rows[i][1]);
            }

        }
        public void Load_2()
        {
            dtpkNgayThanhToan.Enabled = false;
            txbMaPhieu.Enabled = false;
            txbDienThoai.Enabled = false;
            txbNhanVien.Enabled = false;
            txbTongTien.Enabled = false;
            cmbHieuxe.Enabled = false;
            cmbBienSoXe.Enabled = false;
            string tmp = txbMaPhieu.Text = thanhtoan.getMaxid();
            if (tmp == "")
            {
                tmp = "-1";
            }
            txbMaPhieu.Text = (Int32.Parse(tmp) + 1).ToString();
            for (int i = 0; i < thanhtoan.getKhachhang().Rows.Count; i++)
            {
                cmbKhachHang.Items.Add(thanhtoan.getKhachhang().Rows[i][0] + " - " + thanhtoan.getKhachhang().Rows[i][1]);
            }
        }
        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHieuxe.Text = "";
            cmbHieuxe.DataSource = null;
            cmbHieuxe.Items.Clear();
            cmbHieuxe.SelectedIndex = -1;


            cmbBienSoXe.Text = "";
            cmbBienSoXe.DataSource = null;
            cmbBienSoXe.Items.Clear();
            cmbBienSoXe.SelectedIndex = -1;

            
            txbDienThoai.Text = "";
            // txbHieuXe.Text = "";
           // txbMaPhieu.Text = "";
            txbNhanVien.Text = "";
            txbTongTien.Text = "";

            dtpkNgayThanhToan.Enabled = false;
            txbMaPhieu.Enabled = false;
            txbDienThoai.Enabled = false;
            txbNhanVien.Enabled = false;
            txbTongTien.Enabled = false;
            cmbHieuxe.Enabled = false;
            cmbBienSoXe.Enabled = false;

            if (dtgvChiTietSuaChua.DataSource != null)
            {
                dtgvChiTietSuaChua.DataSource = null;
            }
            else
            {
                dtgvChiTietSuaChua.Rows.Clear();
            }
            dtgvChiTietSuaChua.Refresh();
            txbDienThoai.Text = thanhtoan.getSodienthoai(getCMNDKhachhang());
        }

        private void txbDienThoai_TextChanged(object sender, EventArgs e)
        {
            cmbHieuxe.Text = "";
            cmbHieuxe.DataSource = null;
            cmbHieuxe.Items.Clear();
            cmbHieuxe.SelectedIndex = -1;

            cmbHieuxe.Enabled = true;
            foreach (DataRow dr in thanhtoan.getHieuxe(getCMNDKhachhang()).Rows)
            {
                cmbHieuxe.Items.Add(dr["Tenhieuxe"].ToString());
            }
        }
        private void cmbHieuxe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBienSoXe.Text = "";
            cmbBienSoXe.DataSource = null;
            cmbBienSoXe.Items.Clear();
            cmbBienSoXe.SelectedIndex = -1;


           // txbDienThoai.Text = "";   
            // txbHieuXe.Text = "";
          //  txbMaPhieu.Text = "";
            txbNhanVien.Text = "";
            txbTongTien.Text = "";

            dtpkNgayThanhToan.Enabled = false;
            txbMaPhieu.Enabled = false;
            txbDienThoai.Enabled = false;
            txbNhanVien.Enabled = false;
            txbTongTien.Enabled = false;
            // cmbHieuxe.Enabled = false;
            //cmbBienSoXe.Enabled = false;
            if (dtgvChiTietSuaChua.DataSource != null)
            {
                dtgvChiTietSuaChua.DataSource = null;
            }
            else
            {
                dtgvChiTietSuaChua.Rows.Clear();
            }
            dtgvChiTietSuaChua.Refresh();

            cmbBienSoXe.Enabled = true;
            foreach (DataRow dr in thanhtoan.getBienso(getCMNDKhachhang(),getHieuxe()).Rows)
            {
                cmbBienSoXe.Items.Add(dr["Bienso"].ToString());
            }
        }
        

        private void cmbBienSoXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbHieuxe.SelectedIndex = -1;
            //cmbHieuxe.DataSource = null;
            //cmbHieuxe.Items.Clear();
            


          //  txbDienThoai.Text = "";
            // txbHieuXe.Text = "";
           // txbMaPhieu.Text = "";
            txbNhanVien.Text = "";
            txbTongTien.Text = "";

            dtpkNgayThanhToan.Enabled = false;
            txbMaPhieu.Enabled = false;
            txbDienThoai.Enabled = false;
            txbNhanVien.Enabled = false;
            txbTongTien.Enabled = false;
            //cmbHieuxe.Enabled = false;
            //cmbBienSoXe.Enabled = false;

            if (dtgvChiTietSuaChua.DataSource != null)
            {
                dtgvChiTietSuaChua.DataSource = null;
            }
            else
            {
                dtgvChiTietSuaChua.Rows.Clear();
            }
            dtgvChiTietSuaChua.Refresh();

            txbNhanVien.Text = thanhtoan.getNhanviensua(getBienso());
        }

        private void txbNhanVien_TextChanged(object sender, EventArgs e)
        {
            dtpkNgayThanhToan.Enabled = true;

            //
            BindingSource SBind = new BindingSource();
            dtgvChiTietSuaChua.Columns.Clear();
            SBind.DataSource = thanhtoan.getDataGird(getBienso());
            dtgvChiTietSuaChua.DataSource = SBind;
            dtgvChiTietSuaChua.Columns[0].HeaderText = "Loại dịch vụ";
            dtgvChiTietSuaChua.Columns[1].HeaderText = "Phụ tùng";
            dtgvChiTietSuaChua.Columns[2].HeaderText = "Số lượng";
            dtgvChiTietSuaChua.Columns[3].HeaderText = "Đơn giá";
            txbTongTien.Text = tongtien();

        }
        public string getCMNDKhachhang()
        {
            return this.cmbKhachHang.GetItemText(this.cmbKhachHang.SelectedItem).Substring((
                (this.cmbKhachHang.GetItemText(this.cmbKhachHang.SelectedItem)).LastIndexOf('-') + 1)).Trim();
        }
        public string getHieuxe()
        {
            return this.cmbHieuxe.GetItemText(this.cmbHieuxe.SelectedItem);
        }
        public string getBienso()
        {
            return this.cmbBienSoXe.GetItemText(this.cmbBienSoXe.SelectedItem);
        }
        public string tongtien()
        {
            int tong = 0;
            for(int i=0;i<dtgvChiTietSuaChua.RowCount;i++)
            {
                tong += Int32.Parse(dtgvChiTietSuaChua.Rows[i].Cells[3].Value.ToString());
            }
            return tong.ToString();
        }
        //delete
        private void txbHieuXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbHieuxe_Click(object sender, EventArgs e)
        {
            //cmbHieuxe.SelectedIndex = -1;
            //cmbHieuxe.DataSource = null;
            //cmbHieuxe.Items.Clear();
            

            //foreach (DataRow dr in thanhtoan.getHieuxe(getCMNDKhachhang()).Rows)
            //{
            //    cmbHieuxe.Items.Add(dr["Tenhieuxe"].ToString());
            //}
        }

        private void dtpkNgayThanhToan_ValueChanged(object sender, EventArgs e)
        {
            cmbHieuxe.SelectedIndex = -1;
            cmbHieuxe.DataSource = null;
            cmbHieuxe.Items.Clear();

            cmbBienSoXe.SelectedIndex = -1;
            cmbBienSoXe.DataSource = null;
            cmbBienSoXe.Items.Clear();
        }

        private void cmbBienSoXe_Click(object sender, EventArgs e)
        {
            //cmbBienSoXe.SelectedIndex = -1;
            //cmbBienSoXe.DataSource = null;
            //cmbBienSoXe.Items.Clear();


            //foreach (DataRow dr in thanhtoan.getBienso(getCMNDKhachhang(), getHieuxe()).Rows)
            //{
            //    cmbBienSoXe.Items.Add(dr["Bienso"].ToString());
            //}
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            if (getCMNDKhachhang() == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (getHieuxe() == "")
            {
                MessageBox.Show("Vui lòng chọn hiệu xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (getBienso() == "")
            {
                MessageBox.Show("Vui lòng chọn biển số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if(dtpkNgayThanhToan.Value.ToShortDateString()=="")
            {
                MessageBox.Show("Vui lòng chọn ngày thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                DTO_Thanhtoan tt = new DTO_Thanhtoan(0, Int32.Parse(thanhtoan.getMadonhang(getBienso())), DateTime.Parse(dtpkNgayThanhToan.Value.ToShortDateString()));
                DialogResult result;
                if (thanhtoan.thanhtoanhoadon(tt))
                {
                    result = MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    result = MessageBox.Show("Thanh toán thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (result == DialogResult.OK)
                {
                    XoaDuLieu();
                    UC_ThanhToan_Load(sender, e);
                }
                //   return;
            }
        }
    }
}
