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
    public class DAL_Nhanvien : DAL_DBConnect
    {
        /// <summary>
        /// Get toàn bộ nhân viên
        /// </summary>
        /// <returns></returns>
        public DataTable getNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT USERNAME,Ten,Ngaysinh,Gioitinh,CMND,Sodienthoai,Diachi,Ngayvaolam,AC.Manhanvien " +
                "FROM ACCOUNT AC, NHANVIEN NV WHERE AC.Manhanvien = NV.Manhanvien", _conn);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            return dtNhanVien;
        }

        /// <summary>
        /// get toàn bộ nhân viên theo CMND hoặc username
        /// </summary>
        /// <param name="NV"></param>
        /// <returns></returns>
        public DataTable getNhanVien(DTO_NhanVien NV,DTO_Account AC)
        {
            string s1 = "";
            string s2="";//string search
            
            if (AC.USERNAME != "")
            {
                s1 = AC.USERNAME;               
            }
            if (NV.CMND != "")
            {
                s2 = NV.CMND;                
            }        

            SqlDataAdapter da;
            // Query string 
            string SQL = string.Format("select * from ACCOUNT ac, NHANVIEN nv where ac.Manhanvien = nv.Manhanvien and (ac.username like N'{0}' or nv.CMND like '{1}')", s1, s2);
            //string SQL = string.Format("SELECT * FROM KHACHHANGSUACHUA WHERE {0} LIKE N'{1}%' OR {0} LIKE N'%{1}' OR {0} LIKE N'%{1}%'", ss, sc);
            da = new SqlDataAdapter(SQL, _conn);

            DataTable dtKhachHangSuaChua = new DataTable();
            da.Fill(dtKhachHangSuaChua);
            return dtKhachHangSuaChua;
        }

        /// <summary>
        /// Thêm vào Nhân viên
        /// sau đó thêm vào Tài khoản cho nhân viên đó
        /// với mật khẩu mặc định là 123456,  và loại nhân viên là 1 (khác với admin là 0)
        /// </summary>
        /// <param name="NV"></param>
        /// <returns></returns>
        public bool themNhanVien(DTO_NhanVien NV, DTO_Account AC)
        {
            try
            {
                // Ket noi
                _conn.Open();

                DateTime.Parse(NV.NGAYSINH.ToShortDateString());
                // Query string
                string SQL1 = string.Format("INSERT INTO NHANVIEN(CMND,Ten,Diachi,Gioitinh,Sodienthoai,Ngaysinh,Ngayvaolam,Tuoi) VALUES('{0}',N'{1}',N'{2}',N'{3}','{4}','{5}','{6}','{7}')", NV.CMND, NV.TENNHANVIEN, NV.DIACHI, NV.GIOITINH, NV.SODIENTHOAI, NV.NGAYSINH.ToShortDateString(), NV.NGAYVAOLAM.ToShortDateString(), NV.TUOI);
                string SQL2 = string.Format("insert into ACCOUNT(username, pass, Loainhanvien, Manhanvien) values(N'{0}', N'{1}', '{2}', (SELECT MAX(Manhanvien) from NHANVIEN))", AC.USERNAME, 123456, 1);
                // Command
                SqlCommand cmd = new SqlCommand(SQL1 + " " + SQL2, _conn);

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
        /// <summary>
        /// sửa nhân viên
        /// </summary>
        /// <param name="NV"></param>
        /// <returns></returns>
        public bool suaNhanVien(DTO_NhanVien NV)
        {
            try
            {
                //Ket noi
                _conn.Open();

                //Query string
                string SQL = string.Format("UPDATE NHANVIEN SET" +
                    " CMND = '{0}', Ten = N'{1}', Diachi= N'{2}', Gioitinh=N'{3}', Sodienthoai='{4}',Ngaysinh='{5}',Ngayvaolam='{6}' where Manhanvien={7}",
                    NV.CMND, NV.TENNHANVIEN, NV.DIACHI, NV.GIOITINH, NV.SODIENTHOAI, NV.NGAYSINH.ToShortDateString(),NV.NGAYVAOLAM.ToShortDateString(), NV.MANHANVIEN);

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
        /// Xóa nhân viên và tài khoản
        /// </summary>
        /// <param name="NV"></param>
        /// <returns></returns>
        public bool xoaNhanVien(int MaNV)
        {
            try
            {
                //mở kết nối
                _conn.Open();

                //Query string
                string SQL1 = string.Format("DELETE FROM ACCOUNT WHERE Manhanvien = {0}", MaNV);
                string SQL2 = string.Format("DELETE FROM KHACHHANGSUACHUA WHERE Makhachhang = {0}", MaNV);

                //command sql
                SqlCommand cmd = new SqlCommand(SQL1, _conn);
                //query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd = new SqlCommand(SQL2, _conn);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
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
