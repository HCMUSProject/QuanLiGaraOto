using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DTO;
using BUS;

namespace GUI.QuanLiThongTinNhanVIen
{
    public partial class UC_XemThongTinNhanVien : UserControl
    {
        private string m_strUsername;
        private int m_MaNhanVien;
        BUS_Account BUS_AC = new BUS_Account();
        BUS_Nhanvien BUS_NV = new BUS_Nhanvien();
        private static UC_XemThongTinNhanVien _instance;
        public static UC_XemThongTinNhanVien Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_XemThongTinNhanVien();
                }
                return _instance;
            }
        }

        public UC_XemThongTinNhanVien()
        {
            InitializeComponent();
        }
        public  void capNhatThongTinAccount(UC_XemThongTinNhanVien NV)
        {
            DataTable dttb = new DataTable();
            dttb = null;
            NV.txbCMND.Text = "";
            NV.txbDiaChi.Text = "";
            NV.txbHoTen.Text = "";
            NV.txbSDT.Text = "";
            NV.txbTaiKhoan.Text = "";
            NV.rbNam.Checked = NV.rbNu.Checked = false;

            DateTimePicker d1 = new DateTimePicker();
            DateTimePicker d2 = new DateTimePicker();
            //tạo DTO_NV
            DTO_NhanVien DTO_NV = new DTO_NhanVien(m_MaNhanVien, "", "", 0, "", "", "",d1.Value.Date,d2.Value.Date);
            dttb = NV.BUS_NV.getNhanVien(DTO_NV);

            //MessageBox.Show("llllll" + dttb.Rows[0][1].ToString());
            txbTaiKhoan.Text = dttb.Rows[0][0].ToString();
            txbHoTen.Text = dttb.Rows[0][1].ToString();
            dtpkNgaySinh.Value = (DateTime)dttb.Rows[0][2];
            if(dttb.Rows[0][3].ToString()=="Nam")
            {
                rbNam.Checked = true;
                rbNu.Checked = false;
            }
            else
            {
                rbNam.Checked = false;
                rbNu.Checked = true;
            }
            txbCMND.Text = dttb.Rows[0][4].ToString();
            txbSDT.Text = dttb.Rows[0][5].ToString();
            txbDiaChi.Text = dttb.Rows[0][6].ToString();
            dtpkNgayLam.Value = (DateTime)dttb.Rows[0][7];

        }
        public void UC_XemThongTinNhanVien_Load()
        {
            capNhatThongTinAccount(this);
        }
        public void XoaDuLieu()
        {
            txbHoTen.Text = "";
            txbTaiKhoan.Text = "";
            txbCMND.Text = "";
            txbDiaChi.Text = "";
            txbSDT.Text = "";
        }

        private void BtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            // sẽ truyền vào là tài khoản
           // MessageBox.Show("dd" + m_MaNhanVien + "bbb");
            Form DoiMatKhau = new formDoiMatKau(m_strUsername,m_MaNhanVien);
            DoiMatKhau.ShowDialog();
            DoiMatKhau.Close();
        }

        public void GetUsername(string Username)
        {
            m_strUsername = Username;
        }

        public void GetMaNhanVien(int MaNhanVien)
        {
            m_MaNhanVien = MaNhanVien;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
