using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void AutoSlideBar(Button ct)
        {
            slideBar.Height = ct.Height;
            slideBar.Top = ct.Top;
        }
        private void BtnDichVuSuaChua_Click(object sender, EventArgs e)
        {
            AutoSlideBar(BtnDichVuSuaChua);

            // mở submenu
            if (!PanelSubButtons.Controls.Contains(DichVuSuaChua.UC_PanelButtons_DichVuSuaChua.Instance))
            {
                DichVuSuaChua.UC_PanelButtons_DichVuSuaChua.Instance.Dock = DockStyle.Fill;
                DichVuSuaChua.UC_PanelButtons_DichVuSuaChua.Instance.BringToFront();
                DichVuSuaChua.UC_PanelButtons_DichVuSuaChua.Instance.OnButtonClick += OnSubButtons_DichVuSuaChua_Click;
                PanelSubButtons.Controls.Add(DichVuSuaChua.UC_PanelButtons_DichVuSuaChua.Instance);
            }
            else
            {
                DichVuSuaChua.UC_PanelButtons_DichVuSuaChua.Instance.BringToFront();
            }
        }

        private void BtnVatTu_Click(object sender, EventArgs e)
        {
            AutoSlideBar(BtnVatTu);
        }

        private void BtnBaoCao_Click(object sender, EventArgs e)
        {
            AutoSlideBar(BtnBaoCao);
        }

        private void BtnQuanLiKhachHang_Click(object sender, EventArgs e)
        {
            AutoSlideBar(BtnQuanLiKhachHang);
        }

        //========================= handle sự kiện trong button Dịch vụ sửa chữa ====================

        private void OnSubButtons_DichVuSuaChua_Click(object sender, EventArgs e)
        {
            // eps kiểu sender về button
            Button btnClicked = sender as Button;

            if (btnClicked.Name == "BtnTiepNhanXe")
            {
                if (!PanelContent.Controls.Contains(DichVuSuaChua.UC_TiepNhanXe.Instance))
                {
                    PanelContent.Controls.Add(DichVuSuaChua.UC_TiepNhanXe.Instance);
                    DichVuSuaChua.UC_TiepNhanXe.Instance.Dock = DockStyle.Fill;
                    DichVuSuaChua.UC_TiepNhanXe.Instance.BringToFront();
                }
                else
                {
                    DichVuSuaChua.UC_TiepNhanXe.Instance.BringToFront();
                }
                //MessageBox.Show("BtnTiepNhanXe");
            }
            if (btnClicked.Name == "BtnQuanLiXe")
            {
                if (!PanelContent.Controls.Contains(DichVuSuaChua.UC_QuanLiXe.Instance))
                {
                    PanelContent.Controls.Add(DichVuSuaChua.UC_QuanLiXe.Instance);
                    DichVuSuaChua.UC_QuanLiXe.Instance.Dock = DockStyle.Fill;
                    DichVuSuaChua.UC_QuanLiXe.Instance.BringToFront();
                }
                else
                {
                    DichVuSuaChua.UC_QuanLiXe.Instance.BringToFront();
                }

                //MessageBox.Show("BtnQuanLiXe");
            }
            if (btnClicked.Name == "BtnLapPhieu")
            {
                if (!PanelContent.Controls.Contains(DichVuSuaChua.UC_LapPhieuSuaChua.Instance))
                {
                    PanelContent.Controls.Add(DichVuSuaChua.UC_LapPhieuSuaChua.Instance);
                    DichVuSuaChua.UC_LapPhieuSuaChua.Instance.Dock = DockStyle.Fill;
                    DichVuSuaChua.UC_LapPhieuSuaChua.Instance.BringToFront();
                }
                else
                {
                    DichVuSuaChua.UC_LapPhieuSuaChua.Instance.BringToFront();
                }

                //MessageBox.Show("BtnLapPhieu");
            }
            if (btnClicked.Name == "BtnLichSuSuaChua")
            {
                if (!PanelContent.Controls.Contains(DichVuSuaChua.UC_LichSuSuaChua.Instance))
                {
                    PanelContent.Controls.Add(DichVuSuaChua.UC_LichSuSuaChua.Instance);
                    DichVuSuaChua.UC_LichSuSuaChua.Instance.Dock = DockStyle.Fill;
                    DichVuSuaChua.UC_LichSuSuaChua.Instance.BringToFront();
                }
                else
                {
                    DichVuSuaChua.UC_LichSuSuaChua.Instance.BringToFront();
                }

                //MessageBox.Show("BtnLichSuSuaChua");
            }
        }
    }
}
