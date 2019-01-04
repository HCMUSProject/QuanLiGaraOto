using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI.QuanLiThongTinNhanVIen
{
    public partial class formDoiMatKau : Form
    {
        BUS_Account BUS_AC = new BUS_Account();
        private string m_strUsername;
        private string m_matKhauCu;
        
        private int m_MaNhanVien;
        public formDoiMatKau()
        {
            InitializeComponent();
        }

        public formDoiMatKau(string username)
        {
            InitializeComponent();

            m_strUsername = username;
        }
        public formDoiMatKau(string username,int maNhanVien)
        {
            InitializeComponent();

            m_strUsername = username;
            m_MaNhanVien = maNhanVien;
        }

        private void formDoiMatKau_Load(object sender, EventArgs e)
        {
            //tạo dto
            DTO_Account AC = new DTO_Account(0, "", "", 0, m_MaNhanVien);
            DataTable dttb = new DataTable();
            dttb = BUS_AC.getThongTinUsernamePass(AC);
            txbTaiKhoan.Text = dttb.Rows[0][0].ToString();
           m_matKhauCu = dttb.Rows[0][1].ToString();
            txtLoiXacNhan.Hide();
           // txbMatKhauMoi.Text= dttb.Rows[0][2].ToString();
        }

        private void txbTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            
            string matKhauCu = txbMatKhauCu.Text;
            string matKhauMoi = txbMatKhauMoi.Text;           
            
            if (matKhauCu == m_matKhauCu)
            {
                if (txbMatKhauMoi.Text == txbMKXacNhan.Text)
                {
                    txtLoiXacNhan.Hide();
                    //tạo dto
                    DTO_Account AC = new DTO_Account(0, "", matKhauMoi, 0, m_MaNhanVien);
                    if (BUS_AC.suaAccount(AC))
                    {
                        MessageBox.Show("Mật khẩu thay đổi thành công!", "Successful", MessageBoxButtons.OK);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    txtLoiXacNhan.Show();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbMatKhauCu.Text = "";
                return;
            }


        }
    }
}
