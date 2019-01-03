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
   public class DAL_Lichsusuachua:DAL_DBConnect
    {
        /// <summary>
        /// get lich su sua chua de dua vao  dtgvLichsu
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable getLichsu(string begin, string end)
        {
            string query = string.Format("select KH.Ten, HX.Tenhieuxe,XE.Bienso,XE.Ngaynhapgara, TT.Ngayxuat, TT.Madonhang from " +
                "KHACHHANGSUACHUA as KH, HIEUXE as HX, THANHTOAN as TT, DONHANGSUACHUA as DHSC,XE where TT.Madonhang=DHSC.Madonhang and TT.Ngayxuat between '{0}' and '{1}' and DHSC.Makhachhang=KH.Makhachhang and DHSC.IDXe=XE.IDXe  and XE.Mahieuxe=HX.IDHieuxe", begin,end);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result;
        }
        /// <summary>
        /// get chi tiet sua chua của moi don hang da thanh toan trong dtgvLichsu
        /// </summary>
        /// <param name="madonhang"></param>
        /// <returns></returns>
        public DataTable getChitiet(string madonhang)
        {
            string query = string.Format("select DV.Tendichvu, VT.Tenvattu, CT.Soluong from LOAIDICHVU as DV, VATTU as VT, " +
                "CHITIETDONHANG as CT where CT.Madonhang='{0}' and CT.Madichvu=DV.Madichvu and CT.Mavattu=VT.Mavattu",madonhang);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, _conn);
            DataTable result_tmp = new DataTable();
            dichvu.Fill(result_tmp);

            /*DataTable don gia*/
            string query1 = string.Format("select DV.Giadichvu from CHITIETDONHANG as CT, LOAIDICHVU as DV where CT.Madonhang='{0}' and CT.Madichvu=DV.Madichvu",madonhang);
            string query2 = string.Format("select LS.Giathanh from CHITIETDONHANG as CT, LICHSUNHAPKHO as LS where CT.Madonhang='{0}' and CT.Mavattu=LS.Mavattu AND LS.Ngaynhapkho=(select MAX(LICHSUNHAPKHO.Ngaynhapkho)from LICHSUNHAPKHO WHERE LICHSUNHAPKHO.Mavattu=LS.Mavattu)", madonhang);

            SqlDataAdapter a1 = new SqlDataAdapter(query2, _conn);
            SqlDataAdapter a2 = new SqlDataAdapter(query1, _conn);
            DataTable giathanh = new DataTable();
            a1.Fill(giathanh);
            DataTable giadv = new DataTable();
            a2.Fill(giadv);
            DataTable dongia = new DataTable();
            dongia.Columns.Add("Đơn giá");
            for (int i = 0; i < giadv.Rows.Count; i++)
            {
                int gt = Int32.Parse(giathanh.Rows[i][0].ToString());
                int gdv = Int32.Parse(giadv.Rows[i][0].ToString());
                int sl = Int32.Parse(result_tmp.Rows[i][2].ToString());
                // DataRow destRow = dongia.NewRow();
                // destRow[i] = (gt * sl + gdv).ToString();
                object[] o = { (gt *2* sl + gdv).ToString() };
                dongia.Rows.Add(o);
            }
            DataTable final = new DataTable();
            final.Columns.Add("Loại dịch vụ");
            final.Columns.Add("Phụ tùng");
            final.Columns.Add("Số lượng");
            final.Columns.Add("Đơn giá");

            for (int i = 0; i < dongia.Rows.Count; i++)
            {
                object[] o = { result_tmp.Rows[i][0].ToString(), result_tmp.Rows[i][1].ToString(), result_tmp.Rows[i][2].ToString(), dongia.Rows[i][0].ToString() };
                final.Rows.Add(o);
            }
            return final;
        }
    }
}
