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
    public class DAL_Thanhtoan:DAL_DBConnect
    {
        public string getMadonhang(string bienso)
        {
            string query = string.Format("SELECT DH.Madonhang FROM  DONHANGSUACHUA as DH , XE WHERE XE.Bienso ='{0}' " +
                "AND DH.IDXe = XE.IDXe", bienso);
            SqlDataAdapter dt = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dt.Fill(result);
            return result.Rows[0][0].ToString();
        }

        
        public DataTable getKhachhang()
        {
            string query = string.Format("SELECT DISTINCT KHACHHANGSUACHUA.Ten,KHACHHANGSUACHUA.CMND FROM " +
                "KHACHHANGSUACHUA,DONHANGSUACHUA,THANHTOAN WHERE KHACHHANGSUACHUA.Makhachhang=DONHANGSUACHUA.Makhachhang AND DONHANGSUACHUA.Madonhang NOT IN(SELECT DISTINCT DONHANGSUACHUA.Madonhang FROM DONHANGSUACHUA,THANHTOAN WHERE DONHANGSUACHUA.Madonhang=THANHTOAN.Madonhang)");
            SqlDataAdapter kh = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            kh.Fill(result);
            return result;
        }
        public string getSodienthoai(string cmnd)
        {
            string query = string.Format("SELECT Sodienthoai FROM KHACHHANGSUACHUA WHERE CMND='{0}'",cmnd);
            SqlDataAdapter dt = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dt.Fill(result);
            return result.Rows[0][0].ToString();
        }
        public DataTable getHieuxe(string cmnd)
        {
            string query = string.Format("SELECT DISTINCT HX.Tenhieuxe FROM KHACHHANGSUACHUA as KH,DONHANGSUACHUA as DH," +
                "HIEUXE as HX,XE WHERE KH.CMND='{0}' AND KH.Makhachhang=DH.Makhachhang AND DH.IDXe=XE.IDXe AND XE.Mahieuxe=HX.IDHieuxe AND DH.Madonhang NOT IN (SELECT DISTINCT DONHANGSUACHUA.Madonhang FROM DONHANGSUACHUA,THANHTOAN WHERE DONHANGSUACHUA.Madonhang=THANHTOAN.Madonhang)", cmnd);
            SqlDataAdapter hieuxe = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            hieuxe.Fill(result);
            return result;
        }
        public DataTable getBienso(string cmnd, string hieuxe)
        {
            string query = string.Format("SELECT DISTINCT XE.Bienso FROM KHACHHANGSUACHUA as KH, DONHANGSUACHUA as DH,XE,HIEUXE " +
                "as HX WHERE KH.CMND='{0}' AND KH.Makhachhang=DH.Makhachhang AND DH.IDXe=XE.IDXe AND XE.Mahieuxe=" +
                "HX.IDHieuxe AND HX.Tenhieuxe='{1}' AND DH.Madonhang NOT IN (SELECT DISTINCT DONHANGSUACHUA.Madonhang FROM DONHANGSUACHUA,THANHTOAN WHERE DONHANGSUACHUA.Madonhang=THANHTOAN.Madonhang)", cmnd,hieuxe);
            SqlDataAdapter bienso = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            bienso.Fill(result);
            return result;
        }
        public string getNhanviensua(string bienso)
        {
            string query = string.Format("SELECT DISTINCT NV.Ten,NV.CMND FROM NHANVIEN as NV, XE, DONHANGSUACHUA as DH WHERE XE.Bienso='{0}' AND " +
                "XE.IDXe = DH.IDXe AND DH.Manhanvienphutrachsua=NV.Manhanvien AND DH.Madonhang NOT IN (SELECT DISTINCT DONHANGSUACHUA.Madonhang FROM DONHANGSUACHUA,THANHTOAN WHERE DONHANGSUACHUA.Madonhang=THANHTOAN.Madonhang)", bienso);
            SqlDataAdapter nv = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            nv.Fill(result);
            return result.Rows[0][0].ToString()+"-"+result.Rows[0][1].ToString();
        }
        public string getMaxid()
        {
            string query = string.Format("SElECT MAX(IDThanhToan) FROM THANHTOAN");
            SqlDataAdapter maxid = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            maxid.Fill(result);
            return result.Rows[0][0].ToString();
        }
        public int getSoluongctdh(string bienso)
        {
            string query = string.Format("SElECT * FROM CHITIETDONHANG WHERE Madonhang = '{0}' AND Madonhang DH.Madonhang NOT IN (SELECT DISTINCT DONHANGSUACHUA.Madonhang FROM DONHANGSUACHUA,THANHTOAN WHERE DONHANGSUACHUA.Madonhang=THANHTOAN.Madonhang)", getMadonhang(bienso));
            SqlDataAdapter maxid = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            maxid.Fill(result);
            return result.Rows.Count;
        }
        public DataTable getDataGird(string bienso)
        {
            string query = string.Format("SELECT DV.Tendichvu,VT.Tenvattu,CT.Soluong FROM LOAIDICHVU as DV , VATTU as VT, CHITIETDONHANG as CT,XE,DONHANGSUACHUA as DH WHERE XE.Bienso ='{0}' AND XE.IDXe = DH.IDXe AND DH.Madonhang=CT.Madonhang AND CT.Mavattu=VT.Mavattu AND CT.Madichvu=DV.Madichvu AND DH.Madonhang NOT IN (SELECT DISTINCT DONHANGSUACHUA.Madonhang FROM DONHANGSUACHUA,THANHTOAN WHERE DONHANGSUACHUA.Madonhang=THANHTOAN.Madonhang)", bienso);
            SqlDataAdapter a = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            a.Fill(result);

            string query1 = string.Format("SELECT LS.Giathanh FROM LICHSUNHAPKHO as LS, XE, DONHANGSUACHUA as DH, CHITIETDONHANG as CT WHERE XE.Bienso ='{0}' AND XE.IDXe = DH.IDXe AND DH.Madonhang=CT.Madonhang AND CT.Mavattu=LS.Mavattu AND DH.Madonhang NOT IN (SELECT DISTINCT DONHANGSUACHUA.Madonhang FROM DONHANGSUACHUA,THANHTOAN WHERE DONHANGSUACHUA.Madonhang=THANHTOAN.Madonhang)", bienso);
            string query2 = string.Format("SELECT DV.Giadichvu FROM LOAIDICHVU as DV, XE, DONHANGSUACHUA as DH, CHITIETDONHANG as CT WHERE XE.Bienso ='{0}' AND XE.IDXe = DH.IDXe AND DH.Madonhang=CT.Madonhang AND CT.Madichvu=DV.Madichvu AND DH.Madonhang NOT IN (SELECT DISTINCT DONHANGSUACHUA.Madonhang FROM DONHANGSUACHUA,THANHTOAN WHERE DONHANGSUACHUA.Madonhang=THANHTOAN.Madonhang)", bienso);

            SqlDataAdapter a1 = new SqlDataAdapter(query1, _conn);
            SqlDataAdapter a2 = new SqlDataAdapter(query2, _conn);
            DataTable giathanh = new DataTable();
            a1.Fill(giathanh);
            DataTable giadv = new DataTable();
            a2.Fill(giadv);
            DataTable dongia = new DataTable();
            dongia.Columns.Add("Đơn giá");
            for (int i=0;i< giadv.Rows.Count;i++)
            {
                int gt = Int32.Parse(giathanh.Rows[i][0].ToString());
                int gdv = Int32.Parse(giadv.Rows[i][0].ToString());
                int sl = Int32.Parse(result.Rows[i][2].ToString());
                // DataRow destRow = dongia.NewRow();
                // destRow[i] = (gt * sl + gdv).ToString();
                object[] o = { (gt * sl + gdv).ToString()};
                 dongia.Rows.Add(o);
            }
            DataTable final = new DataTable();
            final.Columns.Add("Loại dịch vụ");
            final.Columns.Add("Phụ tùng");
            final.Columns.Add("Số lượng");
            final.Columns.Add("Đơn giá");

            for (int i=0;i<dongia.Rows.Count;i++)
            {
                object[] o = { result.Rows[i][0].ToString(), result.Rows[i][1].ToString(), result.Rows[i][2].ToString(), dongia.Rows[i][0].ToString() };
                final.Rows.Add(o);
            }
            //DataTable final2 = new DataTable();
            //final2 = result.Copy();
            //final2.Merge(dongia);
            return final;
        }

        public bool themphieuthanhtoan(DTO_Thanhtoan _dtt)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO THANHTOAN (Madonhang , Ngayxuat) VALUES ('{0}', '{1}')", _dtt.MADONHANG, _dtt.NGAYXUAT);

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
