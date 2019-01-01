using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_CapNhatVatTu
    {
        private Exception ex = null;
        DAL_CapNhatVatTu dal_CapNhatVatuTu = new DAL_CapNhatVatTu();

        private void SetException(Exception ex)
        {
            this.ex = ex;
        }

        public Exception GetException()
        {
            return this.ex;
        }

        public BUS_CapNhatVatTu()
        {
            dal_CapNhatVatuTu.exception += SetException;
        }

        public DataTable BUS_GetLichSuVatTu()
        {
            DataTable dt = dal_CapNhatVatuTu.DAL_GetLichSuVatTu();

            return dt;
        }

        public DataTable BUS_GetTenVatTuBangDanhMuc(string strTenDanhMuc)
        {
            DataTable dt = dal_CapNhatVatuTu.DAL_GetTenVatTuTheoTenDanhMuc(strTenDanhMuc);

            return dt;
        }

        public DataTable BUS_GetDanhMuc()
        {
            return dal_CapNhatVatuTu.DAL_GetDanhMuc();
        }

        public int BUS_ThemVatTu(string TenDanhMuc, string TenVatTu, int SoLuong, int DonGia, DateTime NgayGioNhap, int MaNhanVien)
        {
            // kiểm tra xem tên vật tư đó có tồn tại hay chưa
            // nếu tồn tại thì chỉ cần thêm vào bảng lịch sử và cộng dồn số lượng ở trong bảng vật tư lên
            // tên vật tư cần chuẩn hóa lại lower để kiểm tra tính chính xác
            // ngược lại thì cần thêm vào trong bảng vật tư trước rồi mới thêm vào lịch sử nhập kho

            DataTable dtVatTu =  dal_CapNhatVatuTu.DAL_GetTenVatTuTheoTenDanhMuc(TenDanhMuc);

            if (this.ex != null)
            {
                return -1;
            }

            bool isExisted = false;

            string TenVatTuDuocChuanHoa = "";

            foreach(DataRow row in dtVatTu.Rows)
            {
                if (row["Tenvattu"].ToString().ToLower() == TenVatTu.ToLower()) // nếu tồn tại thì isExisted = true
                {
                    isExisted = true;
                    TenVatTuDuocChuanHoa = row["Tenvattu"].ToString();
                    break;
                }
            }

            if (isExisted == false) // không tồn tại : thêm vào VATTU trước xong mới thêm vào lịch sử
            {
                // get id của danh mục
                DataTable dtIDDanhMuc = dal_CapNhatVatuTu.DAL_GetIDDanhMucTheoTen(TenDanhMuc);

                int IDDanhMuc = int.Parse(dtIDDanhMuc.Rows[0]["Maloai"].ToString());

                // id bằng -1 vì id trong VATTU tự tăng
                DTO_Vattu vatTu = new DTO_Vattu(-1, IDDanhMuc, TenVatTu, SoLuong);

                // thêm vật tư
                bool result = dal_CapNhatVatuTu.DAL_ThemMoiVATTU(vatTu);

                // thêm vào bảng lịch sử

                // trước tiên phải get được mã vật tư vừa thêm vào
                DataTable dtThongTinVatTu = dal_CapNhatVatuTu.DAL_GetThongTinVatTuTheoTen(TenVatTu);

                // lấy mã vật tư
                int MaVatTu = int.Parse(dtThongTinVatTu.Rows[0]["Mavattu"].ToString());

                DTO_Lichsunhapkho lsNhapKho = new DTO_Lichsunhapkho(-1, MaVatTu, TenVatTu, DonGia, NgayGioNhap, MaNhanVien, SoLuong);

                // thêm vào lịch sử nhập kho
                bool result_2 = dal_CapNhatVatuTu.DAL_ThemLichSuNhapKho(lsNhapKho);

                if (result == true && result_2 == true)
                {
                    return 0;   // thành công
                }
                return 1;   // thất bại
            }
            else
            {   // trong bảng vật tư đã có sẵn.
                // lúc nầy ta cần thêm vào bảng lịch sử và cập nhật lại số lượng ở bảng vật tư

                // THÊM VÀO BẢNG LỊCH SỬ
                // trước tiên phải get được mã vật tư vừa thêm vào
                DataTable dtThongTinVatTu = dal_CapNhatVatuTu.DAL_GetThongTinVatTuTheoTen(TenVatTuDuocChuanHoa);

                // lấy mã vật tư
                int MaVatTu = int.Parse(dtThongTinVatTu.Rows[0]["Mavattu"].ToString());

                DTO_Lichsunhapkho lsNhapKho = new DTO_Lichsunhapkho(-1, MaVatTu, TenVatTuDuocChuanHoa, DonGia, NgayGioNhap, MaNhanVien, SoLuong);

                // thêm vào lịch sử nhập kho
                bool result = dal_CapNhatVatuTu.DAL_ThemLichSuNhapKho(lsNhapKho);

                // TĂNG SỐ LƯỢNG Ở BẢNG VẬT TƯ

                // Get số lượng vật tư hiện tại
                int SoLuongTrongKho = int.Parse(dtThongTinVatTu.Rows[0]["Soluong"].ToString());

                int SoLuongTong = SoLuongTrongKho + SoLuong;

                // update số lượng
                bool result_2 = dal_CapNhatVatuTu.DAL_UpdateSoLuongVatTu(MaVatTu, SoLuongTong);

                if(result == true && result_2 == true)
                {
                    return 0;   // thành công
                }
                return 1;   // thất bại
            }
        }

        public int BUS_SuaVatTu(DTO_Lichsunhapkho lsNhapKho_Moi, DTO_Lichsunhapkho lsNhapKho_Cu)
        {
            // get số lượng vật tư cũ hiện tại. nếu số này nhỏ hơn so với số lượng nhập cũ thì không thể sửa
            // ngược lại : 
            // + xóa số lượng vật tư cũ ở bảng VATTU
            // + sau đó thì làm tương tự như thêm vật tư đã có sẵn trong bảng VATTU, cập nhật số lượng vật tư

            // RETURN CODE:
            // + -1: lỗi
            // + 0: thành công
            // + 1: thất bại
            // + 2: lỗi nghiệp vụ: số lượng vật tư còn lại không đủ để trừ

            DataTable dtThongTinVatTuHienTai = dal_CapNhatVatuTu.DAL_GetThongTinVatTuTheoMaVatTu(lsNhapKho_Cu.MAVATTU);

            if(this.ex != null)
            {
                return -1;
            }

            // get số lượng vật tư cũ hiện tại. nếu số này nhỏ hơn so với số lượng nhập cũ thì không thể sửa
            int SoLuongVatTuConLai = int.Parse(dtThongTinVatTuHienTai.Rows[0]["Soluong"].ToString()) - lsNhapKho_Cu.SOLUONGNHAP;

            if (SoLuongVatTuConLai < 0)
            {
                return 2;
            }
            else
            {
                // update số lượng vật tư còn lại
                bool result = dal_CapNhatVatuTu.DAL_UpdateSoLuongVatTu(lsNhapKho_Cu.MAVATTU, SoLuongVatTuConLai);

                if (this.ex != null)
                {
                    return -1;
                }

                // thêm vào lịch sử nhập kho tại vị trí IDLichSuNhapKho
                bool result_2 = dal_CapNhatVatuTu.DAL_UpdateLichSuNhapKho(lsNhapKho_Moi);

                // TĂNG SỐ LƯỢNG Ở BẢNG VẬT TƯ

                // get thông tin vật tư hiện tại
                DataTable dtThongTinVatTuMoi = dal_CapNhatVatuTu.DAL_GetThongTinVatTuTheoMaVatTu(lsNhapKho_Moi.MAVATTU);
                if (this.ex != null)
                {
                    return -1;
                }

                // Get số lượng vật tư hiện tại
                int SoLuongTrongKho = int.Parse(dtThongTinVatTuMoi.Rows[0]["Soluong"].ToString());

                int SoLuongTong = SoLuongTrongKho + lsNhapKho_Moi.SOLUONGNHAP;

                // update số lượng
                bool result_3 = dal_CapNhatVatuTu.DAL_UpdateSoLuongVatTu(lsNhapKho_Moi.MAVATTU, SoLuongTong);

                if (result == true && result == true && result == true)
                {
                    return 0;
                }
                return 1;
            }

        }
    }
}
