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
    public class DAL_Lapphieusuachua:DAL_DBConnect
    {
        public DataTable getbienso(string cmnd,string hieuxe)
        {
            string query = string.Format("SELECT XE.Bienso FROM XE,KHACHHANGSUACHUA,HIEUXE WHERE KHACHHANGSUACHUA.CMND='{0}' " +
                "AND HIEUXE.Tenhieuxe='{1}' AND XE.Makhachhang=KHACHHANGSUACHUA.Makhachhang AND XE.Mahieuxe=HIEUXE.IDHieuxe", cmnd,hieuxe);
            SqlDataAdapter bienso = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            bienso.Fill(result);
            return result;
        }
        
        public DataTable getNhanvien()
        {
            string query = string.Format("SELECT Ten,CMND FROM NHANVIEN");
            SqlDataAdapter nhanvien = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            nhanvien.Fill(result);
            return result;
        }
        public string getMakhachhang(string cmnd)
        {
            string query = string.Format("SElECT Makhachhang FROM KHACHHANGSUACHUA WHERE CMND='{0}'",cmnd);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result.Rows[0][0].ToString();
        }
        public string getIDxe(string bienso)
        {
            string query = string.Format("SElECT IDXe FROM XE WHERE Bienso='{0}'", bienso);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result.Rows[0][0].ToString();
        }
        public string getManhanvien(string cmnd)
        {
            string query = string.Format("SElECT Manhanvien FROM NHANVIEN WHERE CMND='{0}'", cmnd);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result.Rows[0][0].ToString();
        }
        public string getMadichvu(string tendichvu)
        {
            string query = string.Format("SElECT Madichvu FROM LOAIDICHVU WHERE Tendichvu=N'{0}'", tendichvu);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result.Rows[0][0].ToString();
        }
        public DataTable getloaidichvu()
        {
            string query = string.Format("SElECT Tendichvu FROM LOAIDICHVU");
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result;

        }
        public DataTable getVattu()
        {
            string query = string.Format("SElECT Tenvattu,Mavattu FROM VATTU");
            SqlDataAdapter vattu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            vattu.Fill(result);
            return result;
        }
        public string getGiathanh(int mavt)
        {
            string query = string.Format("SElECT Giathanh FROM LICHSUNHAPKHO WHERE Mavattu='{0}'",mavt);
            SqlDataAdapter vattu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            vattu.Fill(result);

            return result.Rows[0][0].ToString();
        }
        public DataTable getHieuxe(string cmnd)
        {
            string query = string.Format("SElECT HIEUXE.Tenhieuxe  FROM XE,HIEUXE,KHACHHANGSUACHUA WHERE " +
                "KHACHHANGSUACHUA.CMND='{0}' AND XE.Makhachhang=KHACHHANGSUACHUA.Makhachhang  AND XE.Mahieuxe=HIEUXE.IDHieuxe",cmnd);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result;
        }
        public string getGiadichvu(string tendichvu)
        {
            string query = string.Format("SElECT Giadichvu FROM LOAIDICHVU WHERE Tendichvu= N'{0}'", tendichvu);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);

            return result.Rows[0][0].ToString();
        }
        public DataTable getSodienthoai(string cmnd)
        {
            string query = string.Format("SElECT Sodienthoai FROM KHACHHANGSUACHUA WHERE CMND='{0}'",cmnd);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result;
        }
        public DataTable getKhachhang()
        {
            string query = string.Format("SELECT DISTINCT KHACHHANGSUACHUA.Ten,KHACHHANGSUACHUA.CMND FROM XE,KHACHHANGSUACHUA WHERE XE.Makhachhang=KHACHHANGSUACHUA.Makhachhang");
            SqlDataAdapter khachhang = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            khachhang.Fill(result);
            return result;
        }
        public string getMaxid()
        {
            string query = string.Format("SElECT MAX(Madonhang) FROM DONHANGSUACHUA ");
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result.Rows[0][0].ToString();
        }
        public string getsoluongvattu(int mavt)
        {
            string query = string.Format("SElECT Soluong FROM VATTU WHERE Mavattu='{0}'",mavt);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result.Rows[0][0].ToString();
        }
        public bool updateVattu( int mavt,int soluong)
        {
            try
            {
                // Ket noi
                _conn.Open();


                string SQL = string.Format("UPDATE VATTU SET Soluong='{0}'WHERE Mavattu='{1}'", soluong, mavt);
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
        public bool lapphieusuachua(DTO_Donhangsuachua dh)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO DONHANGSUACHUA(Manhanvienlaphoadon, Manhanvienphutrachsua,Makhachhang,IDXe,Ngaylapdonhang,Tongtien) VALUES ('{0}', '{1}', '{2}', '{3}' , '{4}' , '{5}' )", dh.MANHANVIENLAPHOADON, dh.MANHANVIENPHUTRACHSUA, dh.MAKHACHHANG, dh.IDXE, dh.NGAYLAPDONHANG, dh.TONGTIEN);

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
        public bool chitiethoadon(DTO_Chitietdonhang ct)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO CHITIETDONHANG (Madonhang, Mavattu,Soluong,Madichvu) VALUES ('{0}', '{1}', '{2}', '{3}' )", ct.MADONHANG,ct.MAVATTU,ct.SOLUONG,ct.MADICHVU);

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
