using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;


namespace BUS
{
    public class BUS_Khachhangsuachua
    {
        DAL_Khachhangsuachua dalKhachHangSuaChua = new DAL_Khachhangsuachua();


        public DataTable getKhachHangSuaChua()
        {
            return dalKhachHangSuaChua.getKhachHangSuaChua();
        }
        public DataTable getKhachHangSuaChua(DTO_Khachhangsuachua KHSC)
        {
            return dalKhachHangSuaChua.getKhachHangSuaChua(KHSC);
        }
        public DataTable getThongTinXe(DTO_Khachhangsuachua KHSC)
        {
            return dalKhachHangSuaChua.getThongTinXe(KHSC);
        }
        public bool themKhachHangSuaChua(DTO_Khachhangsuachua KHSC)
        {
            return dalKhachHangSuaChua.themKhachHangSuaChua(KHSC);
        }

        public bool suaKhachHangSuaChua(DTO_Khachhangsuachua KHSC)
        {
            return dalKhachHangSuaChua.suaKhachHangSuaChua(KHSC);
        }

        public bool xoaKhachHangSuaChua(int MaKHSC)
        {
            return dalKhachHangSuaChua.xoaKhachHangSuaChua(MaKHSC);
        }
    }
}
