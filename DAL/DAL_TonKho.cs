using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_TonKho : DAL_DBConnect
    {
        public delegate void ExceptionHandler(Exception ex);
        public event ExceptionHandler exception;

        public DataTable DAL_GetTonKho(DateTime from, DateTime to)
        {
            DataTable dt = new DataTable();

            try
            {
                string query = String.Format($"select DANHMUCVATTU.Tendanhmuc, VATTU.Tenvattu, LICHSUNHAPKHO.Soluongnhap, sum(CHITIETDONHANG.Soluong) as Soluongdung,  LICHSUNHAPKHO.Soluongnhap - sum(CHITIETDONHANG.Soluong) as Soluongconlai from CHITIETDONHANG, VATTU, LICHSUNHAPKHO, DANHMUCVATTU, DONHANGSUACHUA where DANHMUCVATTU.Maloai = VATTU.Maloai and VATTU.Mavattu = CHITIETDONHANG.Mavattu and VATTU.Mavattu = LICHSUNHAPKHO.Mavattu and DONHANGSUACHUA.Madonhang = CHITIETDONHANG.Madonhang and DONHANGSUACHUA.Ngaylapdonhang between '{from}' and '{to}' group by CHITIETDONHANG.Mavattu, VATTU.Tenvattu, LICHSUNHAPKHO.Soluongnhap, DANHMUCVATTU.Tendanhmuc");

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
