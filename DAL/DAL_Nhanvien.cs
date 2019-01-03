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

    }
}
