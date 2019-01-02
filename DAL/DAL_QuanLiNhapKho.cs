using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_QuanLiNhapKho : DAL_DBConnect
    {
        public delegate void ExceptionHandler(Exception ex);
        public event ExceptionHandler exception;

        public DataTable DAL_GetLichSuVatTu(DateTime from, DateTime to)
        {
            DataTable dt = new DataTable();
            
            try
            {
                string query = String.Format($"select DANHMUCVATTU.Tendanhmuc, VATTU.Tenvattu, LICHSUNHAPKHO.Soluongnhap, LICHSUNHAPKHO.Giathanh, LICHSUNHAPKHO.Ngaynhapkho, NHANVIEN.Ten  from NHANVIEN, LICHSUNHAPKHO, VATTU, DANHMUCVATTU where NHANVIEN.Manhanvien = LICHSUNHAPKHO.Manhanviennhap and DANHMUCVATTU.Maloai = VATTU.Maloai and VATTU.Mavattu = LICHSUNHAPKHO.Mavattu and LICHSUNHAPKHO.Ngaynhapkho between '{from}' and '{to}' order by LICHSUNHAPKHO.Ngaynhapkho desc");

                SqlDataAdapter da = new SqlDataAdapter(query,_conn);

                da.Fill(dt);
            }
            catch(Exception ex)
            {
                exception?.Invoke(ex);
            }
            return dt;
        }

    }
}
