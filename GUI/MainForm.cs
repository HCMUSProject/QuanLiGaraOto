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
using BUS;

namespace GUI
{
    public partial class MainForm : Form
    {
        BUS_Nhanvien nv = new BUS_Nhanvien();
        formDangNhap dangnhap = new formDangNhap();
        private int m_nLoaiNhanVien = 1;
        private string m_strUsername;
        private int m_MaNhanVien = 1;

        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(int LoaiNhanVien, string strUsername,int Manhanvien)
        {
            InitializeComponent();

            // ẩn thanh slide
            

            // quy định:
            // 0 : admin
            // 1 : nhân viên
            this.m_nLoaiNhanVien = LoaiNhanVien;
            this.m_strUsername = strUsername;
            this.m_MaNhanVien = Manhanvien;

            
            
        }
        
        private void AutoSlideBar(Button ct)
        {
            slideBar.Show();

            slideBar.Height = ct.Height;
            slideBar.Top = ct.Top;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            slideBar.Hide();

            // event khi click vào avatar hoặc tên nhân viên
            picAvatar.Click += new EventHandler(PanelUserAccount_Click);
            lbTenNhanVien.Click += new EventHandler(PanelUserAccount_Click);


            picAvatar.Image = Resources.avatar;

            // kiểm tra là nhân viên hay là admin

            if (m_nLoaiNhanVien == 0)
            {
                lbChucVu.Text = "Admin";
            }
            else
            {
                lbChucVu.Text = "Nhân Viên";
            }

            // load avatar, load tên, load chức vụ
            lbTenNhanVien.Text = this.m_strUsername;
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
            PanelContent.Controls.Clear();

            // mở submenu
            if (!PanelSubButtons.Controls.Contains(BaoCao.UC_PanelButtons_BaoCao.Instance))
            {
                PanelSubButtons.Controls.Add(BaoCao.UC_PanelButtons_BaoCao.Instance);
                BaoCao.UC_PanelButtons_BaoCao.Instance.Dock = DockStyle.Fill;
                BaoCao.UC_PanelButtons_BaoCao.Instance.BringToFront();
                BaoCao.UC_PanelButtons_BaoCao.Instance.OnButtonClick += OnSubButtons_BaoCao_Click;
            }
            else
            {
                BaoCao.UC_PanelButtons_BaoCao.Instance.BringToFront();
            }
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

        private void PanelUserAccount_Click(object sender, EventArgs e)
        {
            PanelContent.Controls.Clear();
            slideBar.Hide();

            if (!PanelSubButtons.Controls.Contains(QuanLiThongTinNhanVIen.UC_PanelSubButtons_QuanLyThongTinNhanVien.Instance))
            {
                PanelSubButtons.Controls.Add(QuanLiThongTinNhanVIen.UC_PanelSubButtons_QuanLyThongTinNhanVien.Instance);
                QuanLiThongTinNhanVIen.UC_PanelSubButtons_QuanLyThongTinNhanVien.Instance.Dock = DockStyle.Fill;
                QuanLiThongTinNhanVIen.UC_PanelSubButtons_QuanLyThongTinNhanVien.Instance.BringToFront();
                QuanLiThongTinNhanVIen.UC_PanelSubButtons_QuanLyThongTinNhanVien.Instance.OnButtonClick += OnSubButtons_QuanLiNhanVien_Click;
            }
            else
            {
                QuanLiThongTinNhanVIen.UC_PanelSubButtons_QuanLyThongTinNhanVien.Instance.BringToFront();
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
                    DichVuSuaChua.UC_TiepNhanXe.Instance.OnButtonAddCustomerClick += OnButton_TiepNhanXe_Them_Click;
                   
                }
                else
                {
                    DichVuSuaChua.UC_TiepNhanXe.Instance.XoaDuLieu();
                    DichVuSuaChua.UC_TiepNhanXe.Instance.BringToFront();
                    DichVuSuaChua.UC_TiepNhanXe.Instance.Load2();

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
                    DichVuSuaChua.UC_QuanLiXe.Instance.XoaDuLieu();
                    DichVuSuaChua.UC_QuanLiXe.Instance.BringToFront();
                    DichVuSuaChua.UC_QuanLiXe.Instance.Load2();
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
                    DichVuSuaChua.UC_LapPhieuSuaChua.Instance.XoaDuLieu();
                    DichVuSuaChua.UC_LapPhieuSuaChua.Instance.BringToFront();
                    DichVuSuaChua.UC_LapPhieuSuaChua.Instance.Load2();
                }

                //MessageBox.Show("BtnLapPhieu");
            }

            if (btnClicked.Name == "BtnThanhToan")
            {
                if (!PanelContent.Controls.Contains(DichVuSuaChua.UC_ThanhToan.Instance))
                {
                    PanelContent.Controls.Add(DichVuSuaChua.UC_ThanhToan.Instance);
                    DichVuSuaChua.UC_ThanhToan.Instance.Dock = DockStyle.Fill;
                    DichVuSuaChua.UC_ThanhToan.Instance.BringToFront();
                }
                else
                {
                    DichVuSuaChua.UC_ThanhToan.Instance.XoaDuLieu();
                    DichVuSuaChua.UC_ThanhToan.Instance.BringToFront();
                    DichVuSuaChua.UC_ThanhToan.Instance.Load_2();
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
                    DichVuSuaChua.UC_LichSuSuaChua.Instance.XoaDuLieu();
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
                    VatTuPhuTung.UC_DanhMucVatTu.Instance.UC_DanhMucVatTu_Load();
                }
                else
                {
                    VatTuPhuTung.UC_DanhMucVatTu.Instance.XoaDuLieu();
                    VatTuPhuTung.UC_DanhMucVatTu.Instance.BringToFront();
                    VatTuPhuTung.UC_DanhMucVatTu.Instance.UC_DanhMucVatTu_Load();
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
                    VatTuPhuTung.UC_CapNhatVatTu.Instance.UC_CapNhatVatTu_Load();

                    VatTuPhuTung.UC_CapNhatVatTu.Instance.GetMaNhanVien(m_MaNhanVien);
                }
                else
                {
                    VatTuPhuTung.UC_CapNhatVatTu.Instance.XoaDuLieu();
                    VatTuPhuTung.UC_CapNhatVatTu.Instance.BringToFront();
                    VatTuPhuTung.UC_CapNhatVatTu.Instance.UC_CapNhatVatTu_Load();
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
                    VatTuPhuTung.UC_QuanLiNhapKho.Instance.UC_QuanLiVatTu_Load();
                }
                else
                {
                    VatTuPhuTung.UC_QuanLiNhapKho.Instance.XoaDuLieu();
                    VatTuPhuTung.UC_QuanLiNhapKho.Instance.BringToFront();
                    VatTuPhuTung.UC_QuanLiNhapKho.Instance.UC_QuanLiVatTu_Load();
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
                    VatTuPhuTung.UC_KiemKeVatTu.Instance.UC_KiemKeVatTu_Load();
                }
                else
                {
                    VatTuPhuTung.UC_KiemKeVatTu.Instance.XoaDuLieu();
                    VatTuPhuTung.UC_KiemKeVatTu.Instance.BringToFront();
                    VatTuPhuTung.UC_KiemKeVatTu.Instance.UC_KiemKeVatTu_Load();
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
                    QuanLiKhachHang.UC_QuanLiKhachHang.Instance.UC_QuanLyKhachHang_Load();
                }
                else
                {
                    QuanLiKhachHang.UC_QuanLiKhachHang.Instance.XoaDuLieu();
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
                    QuanLiKhachHang.UC_XemThongTinKhachHang.Instance.UC_XemThongTinKhachHang_Load();
                }
                else
                {
                    QuanLiKhachHang.UC_XemThongTinKhachHang.Instance.XoaDuLieu();
                    QuanLiKhachHang.UC_XemThongTinKhachHang.Instance.BringToFront();
                }

                //MessageBox.Show("BtnQuanLiXe");
            }
        }

        private void OnSubButtons_BaoCao_Click(object sender, EventArgs e)
        {
            // eps kiểu sender về button
            Button btnClicked = sender as Button;

            if (btnClicked.Name == "BtnBaoCaoDoanhThu")
            {
                if (!PanelContent.Controls.Contains(BaoCao.UC_BaoCaoDoanhThu.Instance))
                {
                    PanelContent.Controls.Add(BaoCao.UC_BaoCaoDoanhThu.Instance);
                    BaoCao.UC_BaoCaoDoanhThu.Instance.Dock = DockStyle.Fill;
                    BaoCao.UC_BaoCaoDoanhThu.Instance.BringToFront();
                    BaoCao.UC_BaoCaoDoanhThu.Instance.UC_BaoCaoDoanhThu_Load();
                }
                else
                {
                    BaoCao.UC_BaoCaoDoanhThu.Instance.XoaDuLieu();
                    BaoCao.UC_BaoCaoDoanhThu.Instance.BringToFront();
                }
                //MessageBox.Show("BtnTiepNhanXe");
            }
            if (btnClicked.Name == "BtnBaoCaoTonKho")
            {
                if (!PanelContent.Controls.Contains(BaoCao.UC_BaoCaoTonKho.Instance))
                {
                    PanelContent.Controls.Add(BaoCao.UC_BaoCaoTonKho.Instance);
                    BaoCao.UC_BaoCaoTonKho.Instance.Dock = DockStyle.Fill;
                    BaoCao.UC_BaoCaoTonKho.Instance.BringToFront();
                    BaoCao.UC_BaoCaoTonKho.Instance.UC_BaoCaoTonKho_Load();
                }
                else
                {
                    BaoCao.UC_BaoCaoTonKho.Instance.XoaDuLieu();
                    BaoCao.UC_BaoCaoTonKho.Instance.BringToFront();
                }

                //MessageBox.Show("BtnQuanLiXe");
            }
        }

        private void OnSubButtons_QuanLiNhanVien_Click(object sender, EventArgs e)
        {
            Button BtnClicked = sender as Button;

            if (BtnClicked.Name == "BtnXemThongTin")
            {
                if (!PanelContent.Controls.Contains(QuanLiThongTinNhanVIen.UC_XemThongTinNhanVien.Instance))
                {
                    PanelContent.Controls.Add(QuanLiThongTinNhanVIen.UC_XemThongTinNhanVien.Instance);
                    QuanLiThongTinNhanVIen.UC_XemThongTinNhanVien.Instance.Dock = DockStyle.Fill;
                    QuanLiThongTinNhanVIen.UC_XemThongTinNhanVien.Instance.BringToFront();
                    QuanLiThongTinNhanVIen.UC_XemThongTinNhanVien.Instance.GetUsername(m_strUsername);
                }
                else
                {
                    //QuanLiThongTinNhanVIen.UC_XemThongTinNhanVien.Instance.XoaDuLieu();
                    QuanLiThongTinNhanVIen.UC_XemThongTinNhanVien.Instance.BringToFront();
                }
            }

            if (BtnClicked.Name== "BtnQuanLiNhanVien")
            {
                if (!PanelContent.Controls.Contains(QuanLiThongTinNhanVIen.UC_QuanLiThongTinNV.Instance))
                {
                    PanelContent.Controls.Add(QuanLiThongTinNhanVIen.UC_QuanLiThongTinNV.Instance);
                    QuanLiThongTinNhanVIen.UC_QuanLiThongTinNV.Instance.Dock = DockStyle.Fill;
                    QuanLiThongTinNhanVIen.UC_QuanLiThongTinNV.Instance.BringToFront();
                    QuanLiThongTinNhanVIen.UC_QuanLiThongTinNV.Instance.UC_QuanLyThongTinNV_Load();
                }
                else
                {
                    QuanLiThongTinNhanVIen.UC_QuanLiThongTinNV.Instance.XoaDuLieu();
                    QuanLiThongTinNhanVIen.UC_QuanLiThongTinNV.Instance.BringToFront();
                }
            }
        }


        // ========================= event click button thêm trong tiếp nhận xe ===================

        private void OnButton_TiepNhanXe_Them_Click(object sender, EventArgs e)
        {
            if (!PanelContent.Controls.Contains(QuanLiKhachHang.UC_QuanLiKhachHang.Instance))
            {
                PanelContent.Controls.Add(QuanLiKhachHang.UC_QuanLiKhachHang.Instance);
                QuanLiKhachHang.UC_QuanLiKhachHang.Instance.Dock = DockStyle.Fill;
                QuanLiKhachHang.UC_QuanLiKhachHang.Instance.BringToFront();
            }
            else
            {
                QuanLiKhachHang.UC_QuanLiKhachHang.Instance.XoaDuLieu();
                QuanLiKhachHang.UC_QuanLiKhachHang.Instance.BringToFront();
            }
        }
    }
}
