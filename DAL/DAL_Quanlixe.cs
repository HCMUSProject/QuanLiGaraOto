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
    public class DAL_Quanlixe:DAL_DBConnect
    {
        /// <summary>
        /// đếm số xe trong csdl
        /// </summary>
        /// <returns></returns>
        public int demSoxe()
        {
            string sql_query = string.Format("SELECT * FROM XE, DONHANGSUACHUA, THANHTOAN WHERE XE.IDXe=DONHANGSUACHUA.IDXe AND DONHANGSUACHUA.Madonhang ");
            SqlDataAdapter db = new SqlDataAdapter(sql_query, _conn);
            DataTable dbXe = new DataTable();
            db.Fill(dbXe);
            return dbXe.Rows.Count;
        }
        /// <summary>
        /// lấy thông tin xe trong gara
        /// </summary>
        /// <returns></returns>
        public DataTable getXe()
        {
            var date = (DateTime.Now.Date).ToString("yyyy-MM-dd");
            string sql_query = string.Format("SELECT DISTINCT KHACHHANGSUACHUA.Ten,KHACHHANGSUACHUA.CMND,KHACHHANGSUACHUA.Diachi" +
                ", HANGXE.Tenhangxe,HIEUXE.Tenhieuxe,XE.Bienso,XE.Ngaynhapgara  FROM KHACHHANGSUACHUA,HANGXE,HIEUXE,XE " +
                " WHERE KHACHHANGSUACHUA.Makhachhang=XE.Makhachhang AND XE.Mahangxe=HANGXE.IDHangxe AND XE.Mahieuxe=HIEUXE.IDHieuxe AND XE.IDXe  NOT IN (SELECT DISTINCT XE.IDXe FROM XE, DONHANGSUACHUA,THANHTOAN WHERE XE.IDXe=DONHANGSUACHUA.IDXe AND DONHANGSUACHUA.Madonhang=THANHTOAN.Madonhang AND THANHTOAN.Ngayxuat<='{0}')", date.ToString());
            SqlDataAdapter a = new SqlDataAdapter(sql_query, _conn);
            DataTable dbKH = new DataTable();
            a.Fill(dbKH);
            
            return dbKH;
        }
        /// <summary>
        /// đếm số lượng xe nhập gara hôm nay
        /// </summary>
        /// <returns></returns>
        public int getsoluongxehomnay()
        {
            var date = (DateTime.Now.Date).ToString("yyyy-MM-dd");
            string query = string.Format("SELECT DISTINCT * FROM XE  WHERE  convert(varchar(10), Ngaynhapgara, 120)='{0}'  " +
                "AND XE.IDXe  NOT IN (SELECT DISTINCT XE.IDXe FROM XE, DONHANGSUACHUA,THANHTOAN WHERE XE.IDXe=DONHANGSUACHUA.IDXe " +
                "AND DONHANGSUACHUA.Madonhang=THANHTOAN.Madonhang AND THANHTOAN.Ngayxuat<='{0}')", date.ToString());
            SqlDataAdapter count = new SqlDataAdapter(query, _conn);
            DataTable slxeToday = new DataTable();
            count.Fill(slxeToday);
            return slxeToday.Rows.Count;
        }
        /// <summary>
        /// đếm số xe hiện có trong gara
        /// </summary>
        /// <returns></returns>
        public int getsoluongxegara()
        {
            var date = (DateTime.Now.Date).ToString("yyyy-MM-dd");

            string query = string.Format("SELECT DISTINCT * FROM XE  WHERE  XE.IDXe  NOT IN (SELECT DISTINCT XE.IDXe FROM XE, " +
                "DONHANGSUACHUA,THANHTOAN WHERE XE.IDXe=DONHANGSUACHUA.IDXe AND DONHANGSUACHUA.Madonhang=THANHTOAN.Madonhang " +
                "AND THANHTOAN.Ngayxuat<='{0}')", date.ToString());
            SqlDataAdapter count = new SqlDataAdapter(query, _conn);
            DataTable slxe = new DataTable();
            count.Fill(slxe);
            return slxe.Rows.Count;
        }
    }
}
