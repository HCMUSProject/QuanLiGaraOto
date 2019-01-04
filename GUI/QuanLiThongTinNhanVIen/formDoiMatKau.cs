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
            label6.Hide();
           // txbMatKhauMoi.Text= dttb.Rows[0][2].ToString();
        }

        private void txbTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        static bool ValidatePassword(string password)//nguồn :https://stackoverflow.com/questions/5859632/regular-expression-for-password-validation
        {
            const int MIN_LENGTH = 8;
            const int MAX_LENGTH = 30;

            if (password == null) throw new ArgumentNullException();

            bool meetsLengthRequirements = password.Length >= MIN_LENGTH && password.Length <= MAX_LENGTH;
            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;

            if (meetsLengthRequirements)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpperCaseLetter = true;
                    else if (char.IsLower(c)) hasLowerCaseLetter = true;
                    else if (char.IsDigit(c)) hasDecimalDigit = true;
                }
            }

            bool isValid = meetsLengthRequirements
                        && hasUpperCaseLetter
                        && hasLowerCaseLetter
                        && hasDecimalDigit
                        ;
            return isValid;

        }
        private void BtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            
            string matKhauCu = txbMatKhauCu.Text;
            string matKhauMoi = txbMatKhauMoi.Text;           
            
            if (matKhauCu == m_matKhauCu)
            {
                label6.Hide();
                if (txbMatKhauMoi.Text == txbMKXacNhan.Text)
                {
                    txtLoiXacNhan.Hide();
                    if (ValidatePassword(txbMatKhauMoi.Text))
                    {
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
                        //MessageBox.Show("Mật khẩu không quá ngắn, không chứa kí tự đặc biệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        label6.Show();
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
