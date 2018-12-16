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
            PanelContent.Controls.Clear();

            // mở submenu
            if (!PanelSubButtons.Controls.Contains(DichVuSuaChua.UC_PanelButtons_DichVuSuaChua.Instance))
            {
                PanelSubButtons.Controls.Add(DichVuSuaChua.UC_PanelButtons_DichVuSuaChua.Instance);
                DichVuSuaChua.UC_PanelButtons_DichVuSuaChua.Instance.Dock = DockStyle.Fill;
                DichVuSuaChua.UC_PanelButtons_DichVuSuaChua.Instance.BringToFront();
                DichVuSuaChua.UC_PanelButtons_DichVuSuaChua.Instance.OnButtonClick += OnSubButtons_DichVuSuaChua_Click;
            }
            else
            {
                DichVuSuaChua.UC_PanelButtons_DichVuSuaChua.Instance.BringToFront();
            }
        }

        private void BtnVatTu_Click(object sender, EventArgs e)
        {
            AutoSlideBar(BtnVatTu);
            PanelContent.Controls.Clear();

            // mở submenu
            if (!PanelSubButtons.Controls.Contains(VatTuPhuTung.UC_PanelButtons_VatTuPhuTung.Instance))
            {
                PanelSubButtons.Controls.Add(VatTuPhuTung.UC_PanelButtons_VatTuPhuTung.Instance);
                VatTuPhuTung.UC_PanelButtons_VatTuPhuTung.Instance.Dock = DockStyle.Fill;
                VatTuPhuTung.UC_PanelButtons_VatTuPhuTung.Instance.BringToFront();
                VatTuPhuTung.UC_PanelButtons_VatTuPhuTung.Instance.OnButtonClick += OnSubButtons_VatTuPhuTung_Click;
            }
            else
            {
                VatTuPhuTung.UC_PanelButtons_VatTuPhuTung.Instance.BringToFront();
            }
        }

        private void BtnBaoCao_Click(object sender, EventArgs e)
        {
            AutoSlideBar(BtnBaoCao);
        }

        private void BtnQuanLiKhachHang_Click(object sender, EventArgs e)
        {
            AutoSlideBar(BtnQuanLiKhachHang);
            PanelContent.Controls.Clear();

            // mở submenu
            if (!PanelSubButtons.Controls.Contains(QuanLiKhachHang.UC_PanelButtons_QuanLiKhachHang.Instance))
            {
                PanelSubButtons.Controls.Add(QuanLiKhachHang.UC_PanelButtons_QuanLiKhachHang.Instance);
                QuanLiKhachHang.UC_PanelButtons_QuanLiKhachHang.Instance.Dock = DockStyle.Fill;
                QuanLiKhachHang.UC_PanelButtons_QuanLiKhachHang.Instance.BringToFront();
                QuanLiKhachHang.UC_PanelButtons_QuanLiKhachHang.Instance.OnButtonClick += OnSubButtons_QuanLyKhachHang_Click;
            }
            else
            {
                QuanLiKhachHang.UC_PanelButtons_QuanLiKhachHang.Instance.BringToFront();
            }
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

        private void OnSubButtons_VatTuPhuTung_Click(object sender, EventArgs e)
        {
            // eps kiểu sender về button
            Button btnClicked = sender as Button;

            if (btnClicked.Name == "BtnDanhMucVatTu")
            {
                if (!PanelContent.Controls.Contains(VatTuPhuTung.UC_DanhMucVatTu.Instance))
                {
                    PanelContent.Controls.Add(VatTuPhuTung.UC_DanhMucVatTu.Instance);
                    VatTuPhuTung.UC_DanhMucVatTu.Instance.Dock = DockStyle.Fill;
                    VatTuPhuTung.UC_DanhMucVatTu.Instance.BringToFront();
                }
                else
                {
                    VatTuPhuTung.UC_DanhMucVatTu.Instance.BringToFront();
                }
                //MessageBox.Show("BtnTiepNhanXe");
            }
            if (btnClicked.Name == "BtnCapNhatVatTu")
            {
                if (!PanelContent.Controls.Contains(VatTuPhuTung.UC_CapNhatVatTu.Instance))
                {
                    PanelContent.Controls.Add(VatTuPhuTung.UC_CapNhatVatTu.Instance);
                    VatTuPhuTung.UC_CapNhatVatTu.Instance.Dock = DockStyle.Fill;
                    VatTuPhuTung.UC_CapNhatVatTu.Instance.BringToFront();
                }
                else
                {
                    VatTuPhuTung.UC_CapNhatVatTu.Instance.BringToFront();
                }

                //MessageBox.Show("BtnQuanLiXe");
            }
            if (btnClicked.Name == "BtnQuanLiNhapKho")
            {
                if (!PanelContent.Controls.Contains(VatTuPhuTung.UC_QuanLiNhapKho.Instance))
                {
                    PanelContent.Controls.Add(VatTuPhuTung.UC_QuanLiNhapKho.Instance);
                    VatTuPhuTung.UC_QuanLiNhapKho.Instance.Dock = DockStyle.Fill;
                    VatTuPhuTung.UC_QuanLiNhapKho.Instance.BringToFront();
                }
                else
                {
                    VatTuPhuTung.UC_QuanLiNhapKho.Instance.BringToFront();
                }

                //MessageBox.Show("BtnLapPhieu");
            }
            if (btnClicked.Name == "BtnKiemKeVatTu")
            {
                if (!PanelContent.Controls.Contains(VatTuPhuTung.UC_KiemKeVatTu.Instance))
                {
                    PanelContent.Controls.Add(VatTuPhuTung.UC_KiemKeVatTu.Instance);
                    VatTuPhuTung.UC_KiemKeVatTu.Instance.Dock = DockStyle.Fill;
                    VatTuPhuTung.UC_KiemKeVatTu.Instance.BringToFront();
                }
                else
                {
                    VatTuPhuTung.UC_KiemKeVatTu.Instance.BringToFront();
                }

                //MessageBox.Show("BtnLichSuSuaChua");
            }
        }

        private void OnSubButtons_QuanLyKhachHang_Click(object sender, EventArgs e)
        {
            // eps kiểu sender về button
            Button btnClicked = sender as Button;

            if (btnClicked.Name == "BtnQuanLiKhachHang")
            {
                if (!PanelContent.Controls.Contains(QuanLiKhachHang.UC_QuanLiKhachHang.Instance))
                {
                    PanelContent.Controls.Add(QuanLiKhachHang.UC_QuanLiKhachHang.Instance);
                    QuanLiKhachHang.UC_QuanLiKhachHang.Instance.Dock = DockStyle.Fill;
                    QuanLiKhachHang.UC_QuanLiKhachHang.Instance.BringToFront();
                }
                else
                {
                    QuanLiKhachHang.UC_QuanLiKhachHang.Instance.BringToFront();
                }
                //MessageBox.Show("BtnTiepNhanXe");
            }
            if (btnClicked.Name == "BtnXemThongTin")
            {
                if (!PanelContent.Controls.Contains(QuanLiKhachHang.UC_XemThongTinKhachHang.Instance))
                {
                    PanelContent.Controls.Add(QuanLiKhachHang.UC_XemThongTinKhachHang.Instance);
                    QuanLiKhachHang.UC_XemThongTinKhachHang.Instance.Dock = DockStyle.Fill;
                    QuanLiKhachHang.UC_XemThongTinKhachHang.Instance.BringToFront();
                }
                else
                {
                    QuanLiKhachHang.UC_XemThongTinKhachHang.Instance.BringToFront();
                }

                //MessageBox.Show("BtnQuanLiXe");
            }
        }
    }
}
