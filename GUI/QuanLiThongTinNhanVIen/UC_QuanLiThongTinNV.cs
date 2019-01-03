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
    public partial class UC_QuanLiThongTinNV : UserControl
    {
        BUS_Nhanvien BUS_NV = new BUS_Nhanvien();     
        string CMND;//kiểm tra Có đang sửa CMND hay không

        private static UC_QuanLiThongTinNV _instance;
        public static UC_QuanLiThongTinNV Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_QuanLiThongTinNV();
                }
                return _instance;
            }
        }

        public UC_QuanLiThongTinNV()
        {
            InitializeComponent();
        }
        public static void capNhatdtgvNhanVien(DataGridView dtgvNhanVien, UC_QuanLiThongTinNV NV)
        {
            dtgvNhanVien.DataSource = null;
            NV.txbCMND.Text = "";
            NV.txbDiaChi.Text = "";
            NV.txbHoTen.Text = "";
            NV.txbSDT.Text = "";
            NV.txbTaiKhoan.Text = "";
            NV.rbNam.Checked = NV.rbNu.Checked = false;

            dtgvNhanVien.DataSource = NV.BUS_NV.getNhanVien();

            //ẩn cột mã nhân viên
            dtgvNhanVien.Columns["Manhanvien"].Visible = false;

            //định dạng lại ngày
            dtgvNhanVien.Columns["Ngaysinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvNhanVien.Columns["Ngayvaolam"].DefaultCellStyle.Format = "dd/MM/yyyy";

            //Thay đổi tên các cột
            dtgvNhanVien.Columns["Ten"].HeaderText = "Tên khách hàng";
            dtgvNhanVien.Columns["Ngaysinh"].HeaderText = "Ngày sinh";
            dtgvNhanVien.Columns["Gioitinh"].HeaderText = "Giới tính";
            dtgvNhanVien.Columns["Sodienthoai"].HeaderText = "SĐT";
            dtgvNhanVien.Columns["Diachi"].HeaderText = "Địa chỉ";

            //resize chiều rộng các cột
            dtgvNhanVien.Columns["Ten"].FillWeight = 150;
            dtgvNhanVien.Columns["Ngaysinh"].FillWeight = 80;
            dtgvNhanVien.Columns["Gioitinh"].FillWeight = 40;

            dtgvNhanVien.ClearSelection();
        }
        public void XoaDuLieu()
        {
            //dtgvXemNhanVIen.Rows.Clear();
            dtgvXemNhanVIen.Refresh();

            txbHoTen.Text = "";
            txbTaiKhoan.Text = "";
            txbCMND.Text = "";
            txbDiaChi.Text = "";
            txbSDT.Text = "";
        }
        public void UC_QuanLyThongTinNV_Load()
        {
            capNhatdtgvNhanVien(dtgvXemNhanVIen, this);
        }

        private void dtgvXemNhanVIen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvXemNhanVIen_Click(object sender, EventArgs e)
        {
            if (dtgvXemNhanVIen.SelectedRows.Count > 0)
            {
                txbTaiKhoan.ReadOnly = false;                
                DataGridViewRow row;//dòng đang chọn
                row = dtgvXemNhanVIen.SelectedRows[0];

                // Chuyển giá trị lên form
                txbTaiKhoan.Text = row.Cells[0].Value.ToString();
                txbHoTen.Text = row.Cells[1].Value.ToString();
                txbCMND.Text = row.Cells[4].Value.ToString().Trim();
                txbSDT.Text = row.Cells[5].Value.ToString().Trim();

                //kiểm tra trong chức năng sửa có sửa CMND hay không
                CMND = txbCMND.Text;

                if (row.Cells[3].Value.ToString() == "Nam")
                {
                    rbNam.Checked = true;
                    rbNu.Checked = false;
                }
                else
                {
                    rbNam.Checked = false;
                    rbNu.Checked = true;
                }

                txbDiaChi.Text = row.Cells[6].Value.ToString();

                dtpkNgaySinh.Value = (DateTime)row.Cells[2].Value;
                dtpkNgayLam.Value = (DateTime)row.Cells[7].Value;
            }
           
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txbTaiKhoan.Text != "" && txbHoTen.Text!="" && txbCMND.Text != "" && txbSDT.Text != "" && txbDiaChi.Text != "" && (rbNam.Checked == true || rbNu.Checked == true))
            {

                //kiểm tra các trường dữ liệu đầu vào
                if (txbCMND.Text.All(char.IsDigit) == false || (txbCMND.Text.Length != 9 && txbCMND.Text.Length != 12))
                {
                    MessageBox.Show("CMND không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbCMND.Text = "";
                    return;
                }
                else
                {
                    // Tạo DTo
                    DTO_Account AC1 = new DTO_Account(0,txbTaiKhoan.Text,"123456", 1, 0);
                    DTO_NhanVien NV1 = new DTO_NhanVien(0, "", txbCMND.Text, 0, "", "", "", dtpkNgayLam.Value.Date, dtpkNgaySinh.Value.Date);
                   // DTO_Khachhangsuachua khCMND = new DTO_Khachhangsuachua(0, txbCMND.Text, "", "", "", "", dtpkNgaySinh.Value.Date);
                    // Tìm kiếm
                    DataTable dttb = null;
                    dttb = BUS_NV.getNhanVien(NV1,AC1);
                    //dttb = BUS_KHSC.getKhachHangSuaChua(khCMND);

                    if (dttb.Rows.Count > 0)
                    {
                        MessageBox.Show("Nhân viên hoặc tài khoản đã có rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //CapNhatDtgvKhachHang(dtgvKhachHang, this);
                       // capNhatdtgvNhanVien(dtgvXemNhanVIen, this);
                        return;
                    }


                }

                if (txbSDT.Text.All(char.IsDigit) == false)
                {
                    MessageBox.Show("SĐT không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbSDT.Text = "";
                    return;
                }

                string gioiTinh = "Khác";
                if (rbNam.Checked == true)
                {
                    gioiTinh = "Nam";
                }
                else
                {
                    gioiTinh = "Nữ";
                }

                // Tạo DTO
                DTO_NhanVien NV = new DTO_NhanVien(0, txbHoTen.Text, txbCMND.Text, 20, txbDiaChi.Text, gioiTinh, txbSDT.Text, dtpkNgayLam.Value.Date, dtpkNgaySinh.Value.Date);
                DTO_Account AC = new DTO_Account(0, txbTaiKhoan.Text, "123456", 1, 0);
                //DTO_Khachhangsuachua KHSC = new DTO_Khachhangsuachua(0, txbCMND.Text, txbTen.Text, txbDiaChi.Text, gioiTinh, txbSDT.Text, dtpkNgaySinh.Value.Date);
                //DTO_ThanhVien tv = new DTO_ThanhVien(0, txtName.Text, txtSDT.Text, txtEmail.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                // Them
                if (BUS_NV.themNhanVien(NV,AC))
                {
                    MessageBox.Show("Thêm thành công!");
                    capNhatdtgvNhanVien(dtgvXemNhanVIen, this);                   
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // dtgvKhachHang.ClearSelection();
            }
            else
            {
                MessageBox.Show("Xin nhập vào không đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static void capNhatGroupBoxThongTinChiTiet(DataGridView dtgv, UC_QuanLiThongTinNV NV)
        {
            DataGridViewRow row = dtgv.SelectedRows[0];//chọn dòng hiện tại                                                       
        }
        private void BtnSua_Click(object sender, EventArgs e)
        {

            capNhatGroupBoxThongTinChiTiet(dtgvXemNhanVIen, this);
            if (dtgvXemNhanVIen.SelectedRows.Count > 0)
            {
                if (txbHoTen.Text != "" && txbCMND.Text != "" && txbSDT.Text != "" && txbDiaChi.Text != "" && (rbNam.Checked == true || rbNu.Checked == true))
                {
                    //kiểm tra các trường dữ liệu đầu vào
                    if (txbCMND.Text.All(char.IsDigit) == false || (txbCMND.Text.Length != 9 && txbCMND.Text.Length != 12))
                    {
                        MessageBox.Show("CMND không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbCMND.Text = "";
                        return;
                    }
                    else
                    {
                        // Tạo DTo
                        DTO_Account AC = new DTO_Account();
                        DTO_NhanVien NV1 = new DTO_NhanVien(0, "", txbCMND.Text, 0, "", "", "", dtpkNgayLam.Value.Date, dtpkNgaySinh.Value.Date);
                        //DTO_Khachhangsuachua khCMND = new DTO_Khachhangsuachua(0, txbCMND.Text, "", "", "", "", dtpkNgaySinh.Value.Date);
                        // Tìm kiếm
                        DataTable dttb = null;
                        dttb = BUS_NV.getNhanVien(NV1,AC);
                       // MessageBox.Show("sau" + CMND + "txb" + txbCMND.Text);
                        if (dttb.Rows.Count >= 1 && CMND != txbCMND.Text)
                        {
                            MessageBox.Show("Nhân viên này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            capNhatdtgvNhanVien(dtgvXemNhanVIen, this);                            
                            return;
                        }


                    }

                    // Lấy row hiện tại
                    DataGridViewRow row = dtgvXemNhanVIen.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[8].Value.ToString());

                    string gioiTinh = rbNam.Checked == true ? gioiTinh = "Nam" : gioiTinh = "Nữ";
                    // Tạo DTo
                    DTO_NhanVien NV = new DTO_NhanVien(ID, txbHoTen.Text, txbCMND.Text, 20, txbDiaChi.Text, gioiTinh, txbSDT.Text, dtpkNgayLam.Value.Date, dtpkNgaySinh.Value.Date);
                    //DTO_Khachhangsuachua KHSC = new DTO_Khachhangsuachua(ID, txbCMND.Text, txbTen.Text, txbDiaChi.Text, gioiTinh, txbSDT.Text, dtpkNgaySinh.Value.Date);
                    // Sửa
                    if (BUS_NV.suaNhanVien(NV))
                    {
                        MessageBox.Show("Sửa thành công!");
                        capNhatdtgvNhanVien(dtgvXemNhanVIen, this);

                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    //dtgvKhachHang.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dtgvXemNhanVIen.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dtgvXemNhanVIen.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells["Manhanvien"].Value.ToString());

                // Xóa
                if (BUS_NV.xoaNhanVien(ID))
                {
                    MessageBox.Show("Xóa thành công!");
                    capNhatdtgvNhanVien(dtgvXemNhanVIen, this);
                    //dtgvKhachHang.DataSource = busTV.getThanhVien(); // refresh datagridview

                }
                else
                {
                    MessageBox.Show("Xóa ko thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                //dtgvKhachHang.ClearSelection();
            }
            else
            {
                MessageBox.Show("Hãy chọn nhân viên muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
