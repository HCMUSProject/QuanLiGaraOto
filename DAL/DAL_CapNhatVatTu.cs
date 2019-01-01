using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_CapNhatVatTu : DAL_DBConnect
    {
        public delegate void ExceptionHandler(Exception ex);
        public event ExceptionHandler exception;

        public DataTable DAL_GetLichSuVatTu()
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "select distinct DANHMUCVATTU.Tendanhmuc, VATTU.Mavattu, VATTU.Tenvattu, LICHSUNHAPKHO.IDLichsunhapkho, LICHSUNHAPKHO.Soluongnhap, LICHSUNHAPKHO.Ngaynhapkho, LICHSUNHAPKHO.Giathanh as Dongia, (select NHANVIEN.Ten from NHANVIEN where NHANVIEN.Manhanvien = LICHSUNHAPKHO.Manhanviennhap) as Tennhanvien from DANHMUCVATTU, LICHSUNHAPKHO, VATTU where LICHSUNHAPKHO.Mavattu = VATTU.Mavattu and DANHMUCVATTU.Maloai = VATTU.Maloai order by LICHSUNHAPKHO.IDLichsunhapkho desc";

                SqlDataAdapter da = new SqlDataAdapter(query, _conn);

                da.Fill(dt);
            }
            catch(Exception ex)
            {
                exception?.Invoke(ex);
            }
            return dt;
        }

        public DataTable DAL_GetDanhMuc()
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "select * from DANHMUCVATTU";

                SqlDataAdapter da = new SqlDataAdapter(query, _conn);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                exception?.Invoke(ex);
            }
            return dt;
        }

        public DataTable DAL_GetTenVatTuTheoTenDanhMuc(string strTenDanhMuc)
        {
            DataTable dt = new DataTable();

            try
            {
                string query = String.Format($"select VATTU.Mavattu, VATTU.Tenvattu from VATTU, DANHMUCVATTU where DANHMUCVATTU.Maloai=VATTU.Maloai and  DANHMUCVATTU.Tendanhmuc=N'{strTenDanhMuc}'");

                SqlDataAdapter da = new SqlDataAdapter(query, _conn);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                exception?.Invoke(ex);
            }
            return dt;
        }

        public bool DAL_ThemMoiVATTU(DTO_Vattu vatTu)
        {
            try
            {
                _conn.Open();

                string query = String.Format($"insert into VATTU values({vatTu.MALOAI},N'{vatTu.TENVATTU}',{vatTu.SOLUONG})");

                SqlCommand cmd = new SqlCommand(query, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

                return false;
            }
            catch(Exception ex)
            {
                exception?.Invoke(ex);
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable DAL_GetIDDanhMucTheoTen(string TenDanhMuc)
        {
            DataTable dt = new DataTable();

            try
            {
                string query = String.Format($"select Maloai from DANHMUCVATTU where Tendanhmuc=N'{TenDanhMuc}'");

                SqlDataAdapter da = new SqlDataAdapter(query, _conn);

                da.Fill(dt);
            }
            catch(Exception ex)
            {
                exception?.Invoke(ex);
            }
            return dt;
        }

        public DataTable DAL_GetThongTinVatTuTheoTen(string TenVatTu)
        {
            DataTable dt = new DataTable();

            try
            {
                string query = String.Format($"select * from VATTU where Tenvattu=N'{TenVatTu}'");

                SqlDataAdapter da = new SqlDataAdapter(query, _conn);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                exception?.Invoke(ex);
            }

            return dt;
        }

        public DataTable DAL_GetThongTinVatTuTheoMaVatTu(int MaVatTu)
        {
            DataTable dt = new DataTable();

            try
            {
                string query = String.Format($"select * from VATTU where Mavattu={MaVatTu}");

                SqlDataAdapter da = new SqlDataAdapter(query, _conn);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                exception?.Invoke(ex);
            }

            return dt;
        }

        public bool DAL_ThemLichSuNhapKho(DTO_Lichsunhapkho lsNhapKho)
        {
            try
            {
                _conn.Open();

                string query = String.Format($"insert into LICHSUNHAPKHO values({lsNhapKho.MAVATTU}, {lsNhapKho.GIATHANH}, '{lsNhapKho.NGAYNHAPKHO}',{lsNhapKho.MANHANVIENNHAP},{lsNhapKho.SOLUONGNHAP})");

                SqlCommand cmd = new SqlCommand(query, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                exception?.Invoke(ex);
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool DAL_UpdateSoLuongVatTu(int MaVatTu, int SoLuong)
        {
            try
            {
                _conn.Open();

                string query = String.Format($"update VATTU set Soluong={SoLuong} where Mavattu={MaVatTu}");

                SqlCommand cmd = new SqlCommand(query, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                exception?.Invoke(ex);
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool DAL_UpdateLichSuNhapKho(DTO_Lichsunhapkho lsNhapKho)
        {
            try
            {
                _conn.Open();

                string query = String.Format($"update LICHSUNHAPKHO set Mavattu={lsNhapKho.MAVATTU},Giathanh={lsNhapKho.GIATHANH}, Ngaynhapkho='{lsNhapKho.NGAYNHAPKHO}',Soluongnhap={lsNhapKho.SOLUONGNHAP}, Manhanviennhap={lsNhapKho.MANHANVIENNHAP} where IDLichsunhapkho={lsNhapKho.IDLICHSUNHAPKHO}");

                SqlCommand cmd = new SqlCommand(query, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                exception?.Invoke(ex);
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
