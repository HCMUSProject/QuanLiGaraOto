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
namespace GUI.QuanLiKhachHang
{
    public partial class UC_QuanLiKhachHang : UserControl
    {
        BUS_Khachhangsuachua BUS_KHSC = new BUS_Khachhangsuachua();
        public static void CapNhatDtgvKhachHang(DataGridView dtgvKhachHang, UC_QuanLiKhachHang KHSC)
        {
            dtgvKhachHang.DataSource = null;
            //xóa dữ liệu trong các textbox
            KHSC.txbTen.Text = KHSC.txbCMND.Text = KHSC.txbDiaChi.Text = KHSC.txbSDT.Text = "";
            KHSC.rbNu.Checked = KHSC.rbNam.Checked = false;


            dtgvKhachHang.DataSource = KHSC.BUS_KHSC.getKhachHangSuaChua();

            //ẩn cột mã khách hàng
            dtgvKhachHang.Columns["Makhachhang"].Visible = false;

            //điều chỉnh thứ tự các cột
            dtgvKhachHang.Columns["Ten"].DisplayIndex = 0;
            dtgvKhachHang.Columns["CMND"].DisplayIndex = 1;
            dtgvKhachHang.Columns["Ngaysinh"].DisplayIndex = 2;
            dtgvKhachHang.Columns["Gioitinh"].DisplayIndex = 3;
            dtgvKhachHang.Columns["Sodienthoai"].DisplayIndex = 2;
            dtgvKhachHang.Columns["Diachi"].DisplayIndex = 5;

            //Thay đổi tên các cột
            dtgvKhachHang.Columns["Ten"].HeaderText = "Tên khách hàng";
            dtgvKhachHang.Columns["Ngaysinh"].HeaderText = "Ngày sinh";
            dtgvKhachHang.Columns["Gioitinh"].HeaderText = "Giới tính";
            dtgvKhachHang.Columns["Sodienthoai"].HeaderText = "SĐT";
            dtgvKhachHang.Columns["Diachi"].HeaderText = "Địa chỉ";

            //resize chiều rộng các cột
            dtgvKhachHang.Columns["Ten"].FillWeight = 200;
            dtgvKhachHang.Columns["Ngaysinh"].FillWeight = 80;
            dtgvKhachHang.Columns["Gioitinh"].FillWeight = 40;
        }


        public static void capNhatGroupBoxQuanLyThongTin(DataGridView dtgv, UC_QuanLiKhachHang KHSC)
        {
            DataGridViewRow row = dtgv.SelectedRows[0];//chọn dòng hiện tại
                                                       // KHSC.txbTen.Text = row;
        }
        private static UC_QuanLiKhachHang _instance;
        public static UC_QuanLiKhachHang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_QuanLiKhachHang();
                }
                return _instance;
            }
        }

        public UC_QuanLiKhachHang()
        {
            InitializeComponent();
        }

        public void UC_QuanLyKhachHang_Load()
        {

            CapNhatDtgvKhachHang(dtgvKhachHang, this);
        }

        public void XoaDuLieu()
        {
            //dtgvKhachHang.Rows.Clear();
            dtgvKhachHang.Refresh();

            txbCMND.Text = "";
            txbDiaChi.Text = "";
            txbSDT.Text = "";
            txbTen.Text = "";
            txbTimKiemCMND.Text = "";
            txbTimKiemSDT.Text = "";
            txbTimKiemTen.Text = "";
        }

        private void dtgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvKhachHang_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgvKhachHang.SelectedRows[0];


            // Chuyển giá trị lên form
            txbTen.Text = row.Cells[2].Value.ToString();
            txbCMND.Text = row.Cells[1].Value.ToString().Trim();
            txbSDT.Text = row.Cells[5].Value.ToString().Trim();

            if (row.Cells[4].Value.ToString() == "Nam")
            {
                rbNam.Checked = true;
                rbNu.Checked = false;
            }
            else
            {
                rbNam.Checked = false;
                rbNu.Checked = true;
            }
            txbDiaChi.Text = row.Cells[3].Value.ToString();

            //phần xử lý cho ngày sinh
            string NgaySinh = row.Cells[6].Value.ToString();
            string[] SortNgaySinh = NgaySinh.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string dt = dtpkNgaySinh.Value.ToShortDateString();
            DateTimePicker dateTimePicker = new DateTimePicker();
            dateTimePicker.Value = DateTime.ParseExact(SortNgaySinh[0].ToString(), "M/d/yyyy", CultureInfo.InvariantCulture);
            dtpkNgaySinh.Value = dateTimePicker.Value;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txbTen.Text != "" && txbCMND.Text != "" && txbSDT.Text != "" && txbDiaChi.Text != "" && (rbNam.Checked == true || rbNu.Checked == true))
            {

                //kiểm tra các trường dữ liệu đầu vào
                if (txbCMND.Text.All(char.IsDigit) == false || (txbCMND.Text.Length != 9 && txbCMND.Text.Length != 12))
                {
                    MessageBox.Show("CMND không hợp lệ!");
                    txbCMND.Text = "";
                    return;
                }
                else
                {
                    // Tạo DTo
                    DTO_Khachhangsuachua khCMND = new DTO_Khachhangsuachua(0, txbCMND.Text, "", "", "", "", dtpkNgaySinh.Value.Date);
                    // Tìm kiếm
                    DataTable dttb = null;
                    dttb = BUS_KHSC.getKhachHangSuaChua(khCMND);

                    if (dttb.Rows.Count > 0)
                    {
                        MessageBox.Show("Người này đã tồn tại!");
                        CapNhatDtgvKhachHang(dtgvKhachHang, this);
                        return;
                    }


                }

                if (txbSDT.Text.All(char.IsDigit) == false)
                {
                    MessageBox.Show("SĐT không hợp lệ!");
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
                DTO_Khachhangsuachua KHSC = new DTO_Khachhangsuachua(0, txbCMND.Text, txbTen.Text, txbDiaChi.Text, gioiTinh, txbSDT.Text, dtpkNgaySinh.Value.Date);
                //DTO_ThanhVien tv = new DTO_ThanhVien(0, txtName.Text, txtSDT.Text, txtEmail.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                // Them
                if (BUS_KHSC.themKhachHangSuaChua(KHSC))
                {
                    MessageBox.Show("Thêm thành công");
                    UC_QuanLiKhachHang This = this;
                    CapNhatDtgvKhachHang(dtgvKhachHang, This);

                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
                // dtgvKhachHang.ClearSelection();
            }
            else
            {
                MessageBox.Show("Xin nhập vào không đầy đủ!");
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            capNhatGroupBoxQuanLyThongTin(dtgvKhachHang, this);
            if (dtgvKhachHang.SelectedRows.Count > 0)
            {
                if (txbTen.Text != "" && txbCMND.Text != "" && txbSDT.Text != "" && txbDiaChi.Text != "" && (rbNam.Checked == true || rbNu.Checked == true))
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dtgvKhachHang.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    string gioiTinh = rbNam.Checked == true ? gioiTinh = "Nam" : gioiTinh = "Nữ";
                    // Tạo DTo
                    DTO_Khachhangsuachua KHSC = new DTO_Khachhangsuachua(ID, txbCMND.Text, txbTen.Text, txbDiaChi.Text, gioiTinh, txbSDT.Text, dtpkNgaySinh.Value.Date);
                    // Sửa
                    if (BUS_KHSC.suaKhachHangSuaChua(KHSC))
                    {
                        MessageBox.Show("Sửa thành công");
                        CapNhatDtgvKhachHang(dtgvKhachHang, this);

                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                    //dtgvKhachHang.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dtgvKhachHang.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dtgvKhachHang.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                // Xóa
                if (BUS_KHSC.xoaKhachHangSuaChua(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    CapNhatDtgvKhachHang(dtgvKhachHang, this);
                    //dtgvKhachHang.DataSource = busTV.getThanhVien(); // refresh datagridview

                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }
                //dtgvKhachHang.ClearSelection();
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            if (txbTimKiemTen.Text == "" && txbTimKiemCMND.Text == "" && txbTimKiemSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
            }
            else
            {
                // Tạo DTo
                DTO_Khachhangsuachua KHSC = new DTO_Khachhangsuachua(0, txbTimKiemCMND.Text, txbTimKiemTen.Text, "NULL", "NULL", txbTimKiemSDT.Text, dtpkNgaySinh.Value.Date);
                // Tìm kiếm
                DataTable dttb = BUS_KHSC.getKhachHangSuaChua(KHSC);
                dtgvKhachHang.DataSource = dttb;

                //ẩn cột mã khách hàng
                dtgvKhachHang.Columns["Makhachhang"].Visible = false;

                //điều chỉnh thứ tự các cột
                dtgvKhachHang.Columns["Ten"].DisplayIndex = 0;
                dtgvKhachHang.Columns["CMND"].DisplayIndex = 1;
                dtgvKhachHang.Columns["Ngaysinh"].DisplayIndex = 2;
                dtgvKhachHang.Columns["Gioitinh"].DisplayIndex = 3;
                dtgvKhachHang.Columns["Sodienthoai"].DisplayIndex = 2;
                dtgvKhachHang.Columns["Diachi"].DisplayIndex = 5;

                //Thay đổi tên các cột
                dtgvKhachHang.Columns["Ten"].HeaderText = "Tên khách hàng";
                dtgvKhachHang.Columns["Ngaysinh"].HeaderText = "Ngày sinh";
                dtgvKhachHang.Columns["Gioitinh"].HeaderText = "Giới tính";
                dtgvKhachHang.Columns["Sodienthoai"].HeaderText = "SĐT";
                dtgvKhachHang.Columns["Diachi"].HeaderText = "Địa chỉ";

                //resize chiều rộng các cột
                dtgvKhachHang.Columns["Ten"].FillWeight = 200;
                dtgvKhachHang.Columns["Ngaysinh"].FillWeight = 80;
                dtgvKhachHang.Columns["Gioitinh"].FillWeight = 40;
            }
        }
    }
}
