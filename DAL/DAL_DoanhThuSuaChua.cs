using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_DoanhThuSuaChua : DAL_DBConnect
    {
        public delegate void ExceptionHandler(Exception ex);
        public event ExceptionHandler exception;

        public DataTable DAL_GetDoanhThuSuaChua(DateTime from, DateTime to)
        {
            DataTable dt = new DataTable();

            try
            {
                string query = String.Format($"select distinct CHITIETDONHANG.Madonhang,THANHTOAN.Ngayxuat, sum (LOAIDICHVU.Giadichvu) as Tiendichvu  from THANHTOAN, LOAIDICHVU, CHITIETDONHANG where CHITIETDONHANG.Madonhang = THANHTOAN.Madonhang and CHITIETDONHANG.Madichvu = LOAIDICHVU.Madichvu and THANHTOAN.Ngayxuat between '{from}' and '{to}' group by CHITIETDONHANG.Madonhang, THANHTOAN.Ngayxuat order by THANHTOAN.Ngayxuat desc");

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
