using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;


namespace GUI.VatTuPhuTung
{
    public partial class UC_CapNhatVatTu : UserControl
    {
        BUS_CapNhatVatTu busCapNhat = new BUS_CapNhatVatTu();

        private int m_MaNhanVien;

        public int MaNhanVien { get => m_MaNhanVien; set => m_MaNhanVien = value; }

        private static UC_CapNhatVatTu _instance;
        public static UC_CapNhatVatTu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_CapNhatVatTu();
                }
                return _instance;
            }
        }


        public UC_CapNhatVatTu()
        {
            InitializeComponent();
        }

        public void GetMaNhanVien(int nMaNhanVien)
        {
            this.MaNhanVien = nMaNhanVien;
        }

        #region Khu vực biến
        // check load
        private bool isLoaded = false;
        // check focus vao gridview
        private bool isFocusGridView = false;
        #endregion

        public void XoaDuLieu()
        {
            //dtgvVatTu.Rows.Clear();

            cmbDanhMuc.Text = "";
            cmbDanhMuc.DataSource = null;

            dtgvVatTu.DataSource = null;

            txbDonGia.Text = "";
            txbSoLuong.Text = "";
            txbVatTu.Text = "";

            isLoaded = false;
            isFocusGridView = false;
        }

        public void UC_CapNhatVatTu_Load()
        {
            // tắt/ bật các button
            BtnThem.Enabled = true;
            BtnSua.Enabled = false;

            // khởi tạo mặc định
            dtpkGioNhap.ShowUpDown = true;
            dtpkNgayNhap.Value = DateTime.Now;
            dtpkGioNhap.Value = DateTime.Now;



            /////////////////////////////////////// XỬ LÍ //////////////////////////
            // load dữ liệu từ database vào gridview
            DataTable dt = busCapNhat.BUS_GetLichSuVatTu();

            // lay exception
            Exception ex = busCapNhat.GetException();

            if (ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            dtgvVatTu.DataSource = dt;

            // load dữ liệu Danh mục vật tư vào comboBox danhmuc
            DataTable dataComboBoxDanhMuc = busCapNhat.BUS_GetDanhMuc();

            // lay exception
            ex = null;
            ex = busCapNhat.GetException();

            if (ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            cmbDanhMuc.DisplayMember = "Tendanhmuc";
            cmbDanhMuc.ValueMember = "Maloai";
            cmbDanhMuc.DataSource = dataComboBoxDanhMuc;

            cmbDanhMuc.SelectedIndex = -1;
            //=================================
            // an cot ma vat tu
            dtgvVatTu.Columns["Mavattu"].Visible = false;
            dtgvVatTu.Columns["IDLichsunhapkho"].Visible = false;

            // thay doi ten danh muc
            dtgvVatTu.Columns["Tendanhmuc"].HeaderText = "Tên danh mục";
            dtgvVatTu.Columns["Tenvattu"].HeaderText = "Tên vật tư";
            dtgvVatTu.Columns["Soluongnhap"].HeaderText = "Số lượng nhập";
            dtgvVatTu.Columns["Ngaynhapkho"].HeaderText = "Ngày nhập kho";
            dtgvVatTu.Columns["Dongia"].HeaderText = "Đơn giá";
            dtgvVatTu.Columns["Tennhanvien"].HeaderText = "Tên nhân viên";

            // thay doi dinh dang ngay
            dtgvVatTu.Columns["Ngaynhapkho"].DefaultCellStyle.Format = "dd/mm/yy hh:mm tt";

            // thay doi dinh dang tien te sang Vietnam
            dtgvVatTu.Columns["Dongia"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            dtgvVatTu.Columns["Dongia"].DefaultCellStyle.Format = "C";

            // sua lai kich thuoc cot theo fit content
            dtgvVatTu.AutoResizeColumns();


            isLoaded = true;
        }

        private void dtgvVatTu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isLoaded == true)
            {
                // bat tat cac button
                BtnThem.Enabled = false;
                BtnSua.Enabled = true;

                // đổ dữ liệu vào textbox và các control
                txbSoLuong.Text = dtgvVatTu.SelectedRows[0].Cells["Soluongnhap"].Value.ToString();
                txbDonGia.Text = dtgvVatTu.SelectedRows[0].Cells["Dongia"].Value.ToString();
                txbVatTu.Text = dtgvVatTu.SelectedRows[0].Cells["Tenvattu"].Value.ToString();

                dtpkNgayNhap.Value = (DateTime)dtgvVatTu.SelectedRows[0].Cells["Ngaynhapkho"].Value;
                dtpkGioNhap.Value = (DateTime)dtgvVatTu.SelectedRows[0].Cells["Ngaynhapkho"].Value;

                cmbDanhMuc.SelectedIndex = cmbDanhMuc.FindString(dtgvVatTu.SelectedRows[0].Cells["Tendanhmuc"].Value.ToString());

                isFocusGridView = true;
            }
        }

        private void UC_CapNhatVatTu_Click(object sender, EventArgs e)
        {
            if (isLoaded == true && isFocusGridView == true)
            {
                // bat tat cac button
                BtnThem.Enabled = true;
                BtnSua.Enabled = false;

                // xoa cac du lieu trong combobox, textbox ,... -> reset ve ban dau
                txbVatTu.Text = "";
                txbSoLuong.Text = "";
                txbDonGia.Text = "";

                cmbDanhMuc.SelectedIndex = -1;
                cmbDanhMuc.Focus();

                dtpkNgayNhap.Value = DateTime.Now;
                dtpkGioNhap.Value = DateTime.Now;

                // reset isfocusgridview
                isFocusGridView = false;
            }
        }

        private void cmbDanhMuc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (isLoaded == true)
            {
                // xóa các field nhập khác
                txbDonGia.Text = "";
                txbSoLuong.Text = "";
                txbVatTu.Text = "";
                dtpkNgayNhap.Value = DateTime.Now;

                // lấy tên danh mục được chọn
                string strTenDanhMuc = cmbDanhMuc.GetItemText(cmbDanhMuc.SelectedItem);

                // lấy tất cả các tên vật tư từ tên danh mục
                DataTable dtTenVatTu = busCapNhat.BUS_GetTenVatTuBangDanhMuc(strTenDanhMuc);

                Exception ex = busCapNhat.GetException();

                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                // lấy tên các vật tư
                List<string> listTenVatTu = new List<string>();
                foreach (DataRow row in dtTenVatTu.Rows)
                {
                    listTenVatTu.Add(row["Tenvattu"].ToString());
                }

                //  autocomplete textbox VatTu
                AutoCompleteStringCollection CompleteTextbox = new AutoCompleteStringCollection();

                CompleteTextbox.AddRange(listTenVatTu.ToArray());

                txbVatTu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txbVatTu.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txbVatTu.AutoCompleteCustomSource = CompleteTextbox;
            }
        }

        private bool isNumberic(string str)
        {
            if (str.Length == 0)
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (!(str[i] >= '0' && str[i] <= '9'))
                {
                    return false;
                }
            }

            return true;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (isLoaded == true)
            {
                if (cmbDanhMuc.SelectedIndex == -1 || txbDonGia.Text.Length == 0
                    || txbSoLuong.Text.Length == 0 || txbVatTu.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ các trường dữ liệu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // kiêm tra đơn giá có kí tự lạ hay không
                if (isNumberic(txbDonGia.Text) == false)
                {
                    MessageBox.Show("Đơn giá chỉ gồm các chữ số!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // kiêm tra số lượng có kí tự lạ hay không
                if (isNumberic(txbSoLuong.Text) == false)
                {
                    MessageBox.Show("Số lượng chỉ gồm các chữ số!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // kiểm tra số lượng có > 0 hay không
                if (int.Parse(txbSoLuong.Text) <= 0)
                {
                    MessageBox.Show("Số lượng vật tư phải lớn hơn 0!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // kiểm tra đơn giá có > 0 hay không
                if (int.Parse(txbDonGia.Text) <= 0)
                {
                    MessageBox.Show("Đơn giá vật tư phải lớn hơn 0!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string TenDanhMuc = cmbDanhMuc.GetItemText(cmbDanhMuc.SelectedItem);

                string TenVatTu = txbVatTu.Text;

                int DonGia = int.Parse(txbDonGia.Text);

                int SoLuong = int.Parse(txbSoLuong.Text);

                // thêm ngày giờ
                DateTime NgayNhap = dtpkNgayNhap.Value;
                DateTime GioNhap = dtpkGioNhap.Value;

                DateTime NgayGioNhap = new DateTime(NgayNhap.Year, NgayNhap.Month, NgayNhap.Day, GioNhap.Hour, GioNhap.Minute, GioNhap.Second);

                int result = busCapNhat.BUS_ThemVatTu(TenDanhMuc, TenVatTu, SoLuong, DonGia, NgayGioNhap, this.MaNhanVien);

                if (result == 0)
                {
                    MessageBox.Show("Thêm vật tư thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    XoaDuLieu();
                    UC_CapNhatVatTu_Load();

                    return;
                }
                if (result == -1)
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (result == 1)
                {
                    MessageBox.Show("Thêm vật tư thất bại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (isLoaded == true)
            {
                // ta sẽ sửa bằng cách:
                // - có ID lịch sử nhập kho - > update table ở dòng IDLichsunhapkho
                // - trường hợp nếu đổi tên -> tức là phải đổi mã vật tư, từ đó mới update Soluong ở bảng VATTU
                // - tên vật tư phải có trong list các tên. không được thêm mới.
                // - ngược lại chỉ cần update tại cái IDLichsunhapkho đó các thuộc tính còn lại 
                //   và update số lượng ở bảng VATTU  nếu nó thay đổi

                if (cmbDanhMuc.SelectedIndex == -1 || txbDonGia.Text.Length == 0
                    || txbSoLuong.Text.Length == 0 || txbVatTu.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ các trường dữ liệu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // kiêm tra đơn giá có kí tự lạ hay không
                if (isNumberic(txbDonGia.Text) == false)
                {
                    MessageBox.Show("Đơn giá chỉ gồm các chữ số!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // kiêm tra số lượng có kí tự lạ hay không
                if (isNumberic(txbSoLuong.Text) == false)
                {
                    MessageBox.Show("Số lượng chỉ gồm các chữ số!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // kiểm tra số lượng có > 0 hay không
                if (int.Parse(txbSoLuong.Text) <= 0)
                {
                    MessageBox.Show("Số lượng vật tư phải lớn hơn 0!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // kiểm tra đơn giá có > 0 hay không
                if (int.Parse(txbDonGia.Text) <= 0)
                {
                    MessageBox.Show("Đơn giá vật tư phải lớn hơn 0!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                // lấy tên danh mục được chọn
                string strTenDanhMuc = cmbDanhMuc.GetItemText(cmbDanhMuc.SelectedItem);

                // lấy tất cả các tên vật tư từ tên danh mục
                DataTable dtTenVatTu = busCapNhat.BUS_GetTenVatTuBangDanhMuc(strTenDanhMuc);

                Exception ex = busCapNhat.GetException();

                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                // kiểm tra tên vật tư hiện tại có trong danh sách các tên vật tư hay không.
                // vì nếu không có thì đồng nghĩa với việc thêm mới

                bool isDuplicated = false;
                int MaVatTuMoi = -1;

                foreach (DataRow row in dtTenVatTu.Rows)
                {
                    if (txbVatTu.Text.ToLower() == row["Tenvattu"].ToString().ToLower())
                    {
                        isDuplicated = true;
                        MaVatTuMoi = int.Parse(row["Mavattu"].ToString());
                        break;
                    }
                }

                if (isDuplicated == false)  // không tồn tại
                {
                    MessageBox.Show($"Không tồn tại vật tư tên {txbVatTu.Text}. Vật tư sửa chữa phải tồn tại trong CSDL!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // có tồn tại
                    // truyền xuống BUS: IDLichsunhapkho, Mavattu, Dongia, Ngaynhapkho, Soluong
                    // trường hợp chỉ update Dongia, Ngaynhapkho, Soluong
                    // - nếu update số lượng thì cần phải tính chênh lệch số lượng giữa 2 lần thay đổi và trừ ra ở VATTU
                    //  // mã vật tư sẽ được lấy dựa vào tên nhập vào ở textbox VatTu

                    try
                    {
                        // IDLichsunhapkho: để update tại dòng này
                        int IDLichSuNhapKho = int.Parse(dtgvVatTu.SelectedRows[0].Cells["IDLichsunhapkho"].Value.ToString());


                        ///////////////////////////////////////// LẤY CÁC THÔNG TIN MỚI///////////////////////////////
                        // đơn giá vật tư
                        int DonGia = int.Parse(txbDonGia.Text);

                        // lấy số lượng vật tư
                        int SoLuong = int.Parse(txbSoLuong.Text);

                        // lấy ngày giờ nhập
                        DateTime NgayNhap = dtpkNgayNhap.Value;
                        DateTime GioNhap = dtpkGioNhap.Value;

                        DateTime NgayGioNhap = new DateTime(NgayNhap.Year, NgayNhap.Month, NgayNhap.Day, GioNhap.Hour, GioNhap.Minute, GioNhap.Second);

                        DTO_Lichsunhapkho lsNhapKho_Moi = new DTO_Lichsunhapkho
                            (IDLichSuNhapKho, MaVatTuMoi, "", DonGia, NgayGioNhap, this.MaNhanVien, SoLuong);



                        /////////////////////////////////// LẤY CÁC THÔNG TIN CŨ//////////////////////////////
                        ///// lấy các thông tin cữ từ datagridview
                        DTO_Lichsunhapkho lsNhapKho_Cu = new DTO_Lichsunhapkho();

                        lsNhapKho_Cu.IDLICHSUNHAPKHO = IDLichSuNhapKho;
                        lsNhapKho_Cu.MAVATTU = int.Parse(dtgvVatTu.SelectedRows[0].Cells["Mavattu"].Value.ToString());
                        lsNhapKho_Cu.TENVATTU = "";
                        lsNhapKho_Cu.GIATHANH = int.Parse(dtgvVatTu.SelectedRows[0].Cells["Dongia"].Value.ToString());
                        lsNhapKho_Cu.NGAYNHAPKHO = (DateTime)dtgvVatTu.SelectedRows[0].Cells["Ngaynhapkho"].Value;
                        lsNhapKho_Cu.SOLUONGNHAP = int.Parse(dtgvVatTu.SelectedRows[0].Cells["Soluongnhap"].Value.ToString());
                        lsNhapKho_Cu.MANHANVIENNHAP = -1;

                        int result = busCapNhat.BUS_SuaVatTu(lsNhapKho_Moi, lsNhapKho_Cu);

                        if(result == 0)
                        {
                            MessageBox.Show("Sửa vật tư thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (result == -1)
                        {
                            MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (result == 1)
                        {
                            MessageBox.Show("Sửa vật tư thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (result == 2)
                        {
                            MessageBox.Show("Vật tư cần sửa đã được sử dụng, không thể sửa.\n Vui lòng liên hệ chúng tôi để khắc phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        this.XoaDuLieu();
                        this.UC_CapNhatVatTu_Load();
                    }
                    catch(Exception exception)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                
            }
        }

        private void dtgvVatTu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
