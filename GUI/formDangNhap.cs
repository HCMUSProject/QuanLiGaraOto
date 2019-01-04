using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using DTO;
using BUS;


namespace GUI
{
    public partial class formDangNhap : Form
    {
        BUS_Account acc = new BUS_Account();        
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {

            cTxbUserName.Text = "";
            ctxbPassword.Text = "";
            this.ActiveControl = cTxbUserName;
            // picAvatar.Image = Resources.user_login_128;
            //picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void formDangNhap_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(400, 450, 400, 450);
            LinearGradientBrush brush = new LinearGradientBrush(r, Color.Gray, Color.LimeGreen, 180F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
            brush.Dispose();
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result==DialogResult.OK)
            {
                this.Hide();
                this.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Hide();
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = cTxbUserName.Text;
            string password = ctxbPassword.Text;
            DialogResult result;
            if (username == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = cTxbUserName;
            }
            else if(password=="")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = ctxbPassword;
            }
            else
            {
                if (acc.CheckAccount(username, password))
                {
                    this.Hide();
                    var window = new MainForm(Int32.Parse(acc.getLoainhanvien(cTxbUserName.Text, ctxbPassword.Text)), acc.getTennhanvien(getManhanvien()), Int32.Parse(getManhanvien()));

                    window.ShowDialog();
                    this.Close();
                }
                else
                {
                    result = MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        cTxbUserName.Text = "";
                        ctxbPassword.Text = "";
                        cTxbUserName.Focus();
                    }
                }
            }
           
        }

        private void cTxbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                string username = cTxbUserName.Text;
                string password = ctxbPassword.Text;
                DialogResult result;
                if (username == "")
                {
                    MessageBox.Show("Tên đăng nhập không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = cTxbUserName;
                }
                else if (password == "")
                {
                    MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = ctxbPassword;
                }
                else
                {
                    if (acc.CheckAccount(username, password))
                    {
                        this.Hide();
                        var window = new MainForm(Int32.Parse(acc.getLoainhanvien(cTxbUserName.Text, ctxbPassword.Text)),acc.getTennhanvien(getManhanvien()),Int32.Parse(getManhanvien()));
                        window.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        result = MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (result == DialogResult.OK)
                        {
                            cTxbUserName.Text = "";
                            ctxbPassword.Text = "";
                            cTxbUserName.Focus();
                        }
                    }
                }

            }
        }
        public string getManhanvien()
        {
            return acc.getManhanvien(cTxbUserName.Text, ctxbPassword.Text);
        }

        private void cTxbUserName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                this.ActiveControl = ctxbPassword;
                e.IsInputKey = true;
            }
        }

        private void ctxbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = cTxbUserName.Text;
                string password = ctxbPassword.Text;
                DialogResult result;
                if (username == "")
                {
                    MessageBox.Show("Tên đăng nhập không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = cTxbUserName;
                }
                else if (password == "")
                {
                    MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = ctxbPassword;
                }
                else
                {
                    if (acc.CheckAccount(username, password))
                    {
                        this.Hide();
                        var window = new MainForm(Int32.Parse(acc.getLoainhanvien(cTxbUserName.Text, ctxbPassword.Text)), acc.getTennhanvien(getManhanvien()), Int32.Parse(getManhanvien()));

                        window.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        result = MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (result == DialogResult.OK)
                        {
                            cTxbUserName.Text = "";
                            ctxbPassword.Text = "";
                            cTxbUserName.Focus();
                        }
                    }
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
