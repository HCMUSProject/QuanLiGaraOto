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
    public class DAL_Khachhangsuachua : DAL_DBConnect
    {
        /// <summary>
        /// Get toàn bộ khách hàng sửa chữa
        /// </summary>
        /// <returns></returns>
        public DataTable getKhachHangSuaChua()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHACHHANGSUACHUA", _conn);
            DataTable dtKhachHangSuaChua = new DataTable();
            da.Fill(dtKhachHangSuaChua);
            return dtKhachHangSuaChua;
        }

        /// <summary>
        /// get toàn bộ khách hàng theo cmnd, số điện thoại, tên
        /// </summary>
        /// <param name="KHSC"></param>
        /// <returns></returns>
       public DataTable getKhachHangSuaChua(DTO_Khachhangsuachua KHSC)
        {
            string ss;//string search
            string sc;// string column
            if(KHSC.TEN!="")
            {
                sc = KHSC.TEN;
                ss = "Ten";
            }
            else
            {
                if(KHSC.CMND!="")
                {
                    sc = KHSC.CMND;
                    ss = "CMND";
                }
                else
                {
                    sc = KHSC.SODIENTHOAI;
                    ss = "Sodienthoai";
                }
            }
           
            SqlDataAdapter da;
            // Query string 
            string SQL = string.Format("SELECT * FROM KHACHHANGSUACHUA WHERE {0} LIKE N'{1}%' OR {0} LIKE N'%{1}' OR {0} LIKE N'%{1}%'", ss, sc);
            da = new SqlDataAdapter(SQL, _conn);
            
            DataTable dtKhachHangSuaChua = new DataTable();
            da.Fill(dtKhachHangSuaChua);
            return dtKhachHangSuaChua;
        }

        public DataTable getThongTinXe(DTO_Khachhangsuachua KHSC)
        {
           
            SqlDataAdapter da;
            // Query string 
            string SQL = string.Format("select HAXE.Tenhangxe,HIXE.Tenhieuxe,X.Tenxe,X.Bienso from KHACHHANGSUACHUA KH,XE X,HANGXE HAXE,HIEUXE HIXE where KH.Makhachhang = X.Makhachhang AND X.Mahangxe = HAXE.IDHangxe AND X.Mahieuxe = HIXE.IDHieuxe AND KH.Makhachhang = {0}",KHSC.MAKHACHANG);
            da = new SqlDataAdapter(SQL, _conn);

            DataTable dtKhachHangSuaChua = new DataTable();
            da.Fill(dtKhachHangSuaChua);
            return dtKhachHangSuaChua;
        }
      
        /// 
        /// <summary>
        /// Thêm vào Khách hàng sửa chữa
        /// </summary>
        /// <param name="KHSC"></param>
        /// <returns></returns>
        public bool themKhachHangSuaChua(DTO_Khachhangsuachua KHSC)
        {
            try
            {
                // Ket noi
                _conn.Open();

                DateTime.Parse(KHSC.NGAYSINH.ToShortDateString());
                // Query string 
                string SQL = string.Format("INSERT INTO KHACHHANGSUACHUA(CMND,Ten,Diachi,Gioitinh,Sodienthoai,Ngaysinh) VALUES('{0}',N'{1}',N'{2}',N'{3}','{4}','{5}')", KHSC.CMND, KHSC.TEN, KHSC.DIACHI,KHSC.GIOITINH, KHSC.SODIENTHOAI,KHSC.NGAYSINH.ToShortDateString());

                // Command
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

        public bool suaKhachHangSuaChua(DTO_Khachhangsuachua KHSC)
        {
            try
            {
                //Ket noi
                _conn.Open();

                //Query string
                string SQL = string.Format("UPDATE KHACHHANGSUACHUA SET" +
                    " CMND = '{0}', Ten = N'{1}', Diachi= N'{2}', Gioitinh=N'{3}', Sodienthoai='{4}',Ngaysinh='{5}' where Makhachhang={6}",
                    KHSC.CMND, KHSC.TEN, KHSC.DIACHI, KHSC.GIOITINH, KHSC.SODIENTHOAI, KHSC.NGAYSINH.ToShortDateString(), KHSC.MAKHACHANG);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        /// <summary>
        /// Xóa khách hàng sửa chữa
        /// </summary>
        /// <param name="KHSC"></param>
        /// <returns></returns>
        public bool xoaKhachHangSuaChua(int MaKHSC)
        {
            try
            {
                //mở kết nối
                _conn.Open();

                //Query string
                string SQL = string.Format("DELETE FROM KHACHHANGSUACHUA WHERE Makhachhang = {0}", MaKHSC);

                //command sql
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                //query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
