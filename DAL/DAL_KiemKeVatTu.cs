using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_KiemKeVatTu : DAL_DBConnect
    {
        public delegate void ExceptionHandler(Exception ex);
        public event ExceptionHandler exception;

        public DataTable DAL_GetThongTinVatTu()
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "select DM.Tendanhmuc, VT.Mavattu, VT.Tenvattu, VT.Soluong from VATTU VT, DANHMUCVATTU DM where DM.Maloai=VT.Maloai order by VT.Soluong asc";

                SqlDataAdapter da = new SqlDataAdapter(query, _conn);

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
