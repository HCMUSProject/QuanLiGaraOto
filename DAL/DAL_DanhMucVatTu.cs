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
    public class DAL_DanhMucVatTu : DAL_DBConnect
    {
        public DataTable GetDanhMucVatTu()
        {
            DataTable dtDanhMuc = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DANHMUCVATTU", _conn);

                da.Fill(dtDanhMuc);
            }
            catch(Exception ex)
            {
                exception?.Invoke(ex);
            }
            
            return dtDanhMuc;
        }

        public bool SuaDanhMucVatTu(DTO_Danhmucvt danhMuc)
        {
            try
            {
                _conn.Open();

                string query = string.Format($"UPDATE DANHMUCVATTU SET Tendanhmuc='{danhMuc.TENDANHMUC}' WHERE Maloai={danhMuc.MALOAI}");

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

        public DataTable TimKiemDanhMuc(string TenDanhMuc)
        {
            DataTable dtDanhMuc = new DataTable();

            try
            {
                string query = string.Format($"SELECT * FROM DANHMUCVATTU WHERE Tendanhmuc LIKE '{TenDanhMuc}%'");

                SqlDataAdapter da = new SqlDataAdapter(query, _conn);

                da.Fill(dtDanhMuc);

            }
            catch(Exception ex)
            {
                exception?.Invoke(ex);
            }
            return dtDanhMuc;
        }

        public bool ThemDanhMucVatTu(string TenDanhMuc)
        {
            try
            {
                _conn.Open();

                string query = string.Format($"INSERT INTO DANHMUCVATTU VALUES(N'{TenDanhMuc}')");

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

        public delegate void ExceptionHandler(Exception ex);
        public event ExceptionHandler exception;
    }
}
