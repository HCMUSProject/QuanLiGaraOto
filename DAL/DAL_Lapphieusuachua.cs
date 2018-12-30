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
        /// <summary>
        /// get biển số để đưa vao cmbBienso
        /// </summary>
        /// <param name="cmnd"></param>
        /// <param name="hieuxe"></param>
        /// <returns></returns>
        public DataTable getbienso(string cmnd,string hieuxe)
        {
            string query = string.Format("SELECT XE.Bienso FROM XE,KHACHHANGSUACHUA,HIEUXE WHERE KHACHHANGSUACHUA.CMND='{0}' " +
                "AND HIEUXE.Tenhieuxe='{1}' AND XE.Makhachhang=KHACHHANGSUACHUA.Makhachhang AND XE.Mahieuxe=HIEUXE.IDHieuxe", cmnd,hieuxe);
            SqlDataAdapter bienso = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            bienso.Fill(result);
            return result;
        }
        /// <summary>
        /// get nhân viên để đưa vào cmbNhanviensuachua
        /// </summary>
        /// <returns></returns>
        public DataTable getNhanvien()
        {
            string query = string.Format("SELECT Ten,CMND FROM NHANVIEN");
            SqlDataAdapter nhanvien = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            nhanvien.Fill(result);
            return result;
        }
        /// <summary>
        /// get mã khách hàng để đưa vào csdl
        /// </summary>
        /// <param name="cmnd"></param>
        /// <returns></returns>
        public string getMakhachhang(string cmnd)
        {
            string query = string.Format("SElECT Makhachhang FROM KHACHHANGSUACHUA WHERE CMND='{0}'",cmnd);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result.Rows[0][0].ToString();
        }
        /// <summary>
        /// get IDxe để đưa vào csdl
        /// </summary>
        /// <param name="bienso"></param>
        /// <returns></returns>
        public string getIDxe(string bienso)
        {
            string query = string.Format("SElECT IDXe FROM XE WHERE Bienso='{0}'", bienso);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result.Rows[0][0].ToString();
        }
        public bool CheckExitsCar(string bienso)
        {
            string query = string.Format("SElECT Madonhang FROM DONHANGSUACHUA WHERE IDXe='{0}'AND Madonhang NOT IN (SELECT DISTINCT DONHANGSUACHUA.Madonhang FROM DONHANGSUACHUA,THANHTOAN WHERE DONHANGSUACHUA.Madonhang=THANHTOAN.Madonhang)", getIDxe(bienso));
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            if (result.Rows.Count > 0) return true;
            return false;
        }
        /// <summary>
        /// get mã nhân viên để đưa vào csdl
        /// </summary>
        /// <param name="cmnd"></param>
        /// <returns></returns>
        public string getManhanvien(string cmnd)
        {
            string query = string.Format("SElECT Manhanvien FROM NHANVIEN WHERE CMND='{0}'", cmnd);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result.Rows[0][0].ToString();
        }
        /// <summary>
        /// get mã dịch vụ để đưa vào csdl
        /// </summary>
        /// <param name="tendichvu"></param>
        /// <returns></returns>
        public string getMadichvu(string tendichvu)
        {
            string query = string.Format("SElECT Madichvu FROM LOAIDICHVU WHERE Tendichvu=N'{0}'", tendichvu);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result.Rows[0][0].ToString();
        }
        /// <summary>
        /// get loại dịch vụ để đưa vào cmb datagridview
        /// </summary>
        /// <returns></returns>
        public DataTable getloaidichvu()
        {
            string query = string.Format("SElECT Tendichvu FROM LOAIDICHVU");
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result;

        }
        /// <summary>
        /// get vật tư để đưa vào cmb datagridview
        /// </summary>
        /// <returns></returns>
        public DataTable getVattu()
        {
            string query = string.Format("SElECT Tenvattu,Mavattu FROM VATTU");
            SqlDataAdapter vattu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            vattu.Fill(result);
            return result;
        }
        /// <summary>
        /// get giá thành vật tư để tính đơn giá
        /// </summary>
        /// <param name="mavt"></param>
        /// <returns></returns>
        public string getGiathanh(int mavt)
        {
            string query = string.Format("SElECT Giathanh FROM LICHSUNHAPKHO WHERE Mavattu='{0}'",mavt);
            SqlDataAdapter vattu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            vattu.Fill(result);

            return result.Rows[0][0].ToString();
        }
        /// <summary>
        /// get hiệu xe để đưa vào cmbHieuxe
        /// </summary>
        /// <param name="cmnd"></param>
        /// <returns></returns>
        public DataTable getHieuxe(string cmnd)
        {
            string query = string.Format("SElECT HIEUXE.Tenhieuxe  FROM XE,HIEUXE,KHACHHANGSUACHUA WHERE " +
                "KHACHHANGSUACHUA.CMND='{0}' AND XE.Makhachhang=KHACHHANGSUACHUA.Makhachhang  AND XE.Mahieuxe=HIEUXE.IDHieuxe",cmnd);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result;
        }
        /// <summary>
        /// get giá dịch vụ để tính đơn giá
        /// </summary>
        /// <param name="tendichvu"></param>
        /// <returns></returns>
        public string getGiadichvu(string tendichvu)
        {
            string query = string.Format("SElECT Giadichvu FROM LOAIDICHVU WHERE Tendichvu= N'{0}'", tendichvu);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);

            return result.Rows[0][0].ToString();
        }
        /// <summary>
        /// get số điện thoại để đưa vào txbSodienthoai
        /// </summary>
        /// <param name="cmnd"></param>
        /// <returns></returns>
        public DataTable getSodienthoai(string cmnd)
        {
            string query = string.Format("SElECT Sodienthoai FROM KHACHHANGSUACHUA WHERE CMND='{0}'",cmnd);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result;
        }
        /// <summary>
        /// get khách hàng để đưa vào cmbKhachhang
        /// </summary>
        /// <returns></returns>
        public DataTable getKhachhang()
        {
            string query = string.Format("SELECT DISTINCT KHACHHANGSUACHUA.Ten,KHACHHANGSUACHUA.CMND FROM XE,KHACHHANGSUACHUA WHERE XE.Makhachhang=KHACHHANGSUACHUA.Makhachhang");
            SqlDataAdapter khachhang = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            khachhang.Fill(result);
            return result;
        }
        /// <summary>
        /// get id lớn nhất của bảng hóa đơn. tăng 1 để thành id hóa đơn hiện tại
        /// </summary>
        /// <returns></returns>
        public string getMaxid()
        {
            string query = string.Format("SElECT MAX(Madonhang) FROM DONHANGSUACHUA ");
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result.Rows[0][0].ToString();
        }
        /// <summary>
        /// get số lượng vật tư để tính đơn giá và check &update lại csdl
        /// </summary>
        /// <param name="mavt"></param>
        /// <returns></returns>
        public string getsoluongvattu(int mavt)
        {
            string query = string.Format("SElECT Soluong FROM VATTU WHERE Mavattu='{0}'",mavt);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result.Rows[0][0].ToString();
        }
        /// <summary>
        /// update lại số lượng bảng vật  tư sau khi dùng vật tư
        /// </summary>
        /// <param name="mavt"></param>
        /// <param name="soluong"></param>
        /// <returns></returns>
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
        /// <summary>
        /// lập hóa đơn
        /// </summary>
        /// <param name="dh"></param>
        /// <returns></returns>
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
        /// <summary>
        /// lập phiếu chi tiết hóa đơn
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
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
