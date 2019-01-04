using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_DoanhThuVatTu : DAL_DBConnect
    {
        public delegate void ExceptionHandler(Exception ex);
        public event ExceptionHandler exception;

        public DataTable DAL_GetDoanhThuVatTu(DateTime from, DateTime to)
        {
            DataTable dt = new DataTable();

            try
            {
                string query = String.Format($"select DANHMUCVATTU.Tendanhmuc, VATTU.Tenvattu, sum(CHITIETDONHANG.Soluong) as Soluongdung, sum(CHITIETDONHANG.Soluong)*LICHSUNHAPKHO.Giathanh as Tienlai from CHITIETDONHANG, VATTU, LICHSUNHAPKHO, DANHMUCVATTU, THANHTOAN where CHITIETDONHANG.Madonhang = THANHTOAN.Madonhang and DANHMUCVATTU.Maloai = VATTU.Maloai and VATTU.Mavattu = CHITIETDONHANG.Mavattu and VATTU.Mavattu = LICHSUNHAPKHO.Mavattu and THANHTOAN.Ngayxuat between '{from}' and '{to}' group by CHITIETDONHANG.Mavattu, VATTU.Tenvattu, DANHMUCVATTU.Tendanhmuc, LICHSUNHAPKHO.Giathanh");

                SqlDataAdapter da = new SqlDataAdapter(query, _conn);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                exception?.Invoke(ex);
            }
            return dt;
        }

    }
}
