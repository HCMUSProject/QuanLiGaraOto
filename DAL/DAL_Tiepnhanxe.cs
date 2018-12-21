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
   public class DAL_Tiepnhanxe : DAL_DBConnect
    {
       

        /// <summary>
        /// Lấy toàn bộ tên khách hàng kèm cmnd
        /// </summary>
        /// <returns></returns>
        public DataTable getKhachhang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Ten,CMND FROM KHACHHANGSUACHUA", _conn);
            DataTable dtKhachhang = new DataTable();
            da.Fill(dtKhachhang);
            return dtKhachhang;
        }
        /// <summary>
        /// Lấy toàn bộ các hãng xe trong csdl
        /// </summary>
        /// <returns></returns>
        public DataTable getHangxe()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Tenhangxe FROM HANGXE", _conn);
            DataTable dtHangxe = new DataTable();
            da.Fill(dtHangxe);
            return dtHangxe;
        }
        /// <summary>
        /// Lấy toàn bộ mã các hãng xe trong csdl
        /// </summary>
        /// <param name='hang'></param>
        /// <returns></returns>
        public string getMahangxe(string hang)
        {
            string sql_query = string.Format("SELECT IDHangxe FROM HANGXE WHERE Tenhangxe='{0}'", hang);
            SqlDataAdapter db = new SqlDataAdapter(sql_query, _conn);
            DataTable dbmahangxe = new DataTable();
            db.Fill(dbmahangxe);
            return dbmahangxe.Rows[0][0].ToString();
        }

        /// <summary>
        /// Lấy toàn bộ mã các hiệu xe trong csdl
        /// </summary>
        /// <param name='hieu'></param>
        /// <returns></returns>
        public string getMahieuxe(string hieu)
        {
            string sql_query = string.Format("SELECT IDHieuxe FROM HIEUXE WHERE Tenhieuxe='{0}'", hieu);
            SqlDataAdapter db = new SqlDataAdapter(sql_query, _conn);
            DataTable dbmahieuxe = new DataTable();
            db.Fill(dbmahieuxe);
            return dbmahieuxe.Rows[0][0].ToString();
        }

        /// <summary>
        /// Lấy toàn bộ mã các khách hàng trong csdl
        /// </summary>
        /// <param name='cmnd'></param>
        /// <returns></returns>
        public string getMakhachhang(string cmnd)
        {
            string sql_query = string.Format("SELECT Makhachhang FROM KHACHHANGSUACHUA WHERE CMND='{0}'", cmnd);
            SqlDataAdapter db = new SqlDataAdapter(sql_query, _conn);
            DataTable dbmakhachhang = new DataTable();
            db.Fill(dbmakhachhang);
            return dbmakhachhang.Rows[0][0].ToString();
        }
        ///</summary>
        /// Lấy toàn bộ các hiệu xe trong csdl
        /// </summary>
        /// <returns></returns>
        public DataTable getHieuxe(string hx)
        { 
            string sql_query2 = string.Format("SELECT Tenhieuxe FROM HIEUXE WHERE Mahangxe='{0}'", getMahangxe(hx));
            SqlDataAdapter da = new SqlDataAdapter(sql_query2, _conn);
            DataTable dtHieuxe = new DataTable();
            da.Fill(dtHieuxe);
            return dtHieuxe;
        }

        /// <summary>
        /// Kiểm tra biển số có tồn tại hay chưa
        /// </summary>
        /// <param name='hang'></param>
        /// <returns></returns>
        public bool Checkbienso(string bienso)
        {
            string sql_query2 = string.Format("SELECT IDXe FROM XE WHERE Bienso='{0}'", bienso);
            SqlDataAdapter da = new SqlDataAdapter(sql_query2, _conn);
            DataTable daBienso = new DataTable();
            da.Fill(daBienso);
            if (daBienso.Rows.Count!=0) return false;
             return true;
        }
        ///</summary>
        /// Thêm xe vào csdl
        /// </summary>
        /// <param name="_dxe"></param>
        /// <returns></returns>
        public bool themXe(DTO_Xe _dxe)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO XE(Tenxe, Mahangxe,Mahieuxe,Bienso,Makhachhang,Ngaynhapgara) VALUES ('{0}', '{1}', '{2}', '{3}' , '{4}' , '{5}' )", _dxe.TENXE,_dxe.MAHANGXE,_dxe.MAHIEUXE,_dxe.BIENSO,_dxe.MAKHACHHANG,_dxe.NGAYNHAPGARA);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
    }
}
