using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Thanhtoan
    {
        DAL_Thanhtoan thanhtoan = new DAL_Thanhtoan();
        public DataTable getKhachhang()
        {
            return thanhtoan.getKhachhang();
        }
        public string getSodienthoai(string cmnd)
        {
            return thanhtoan.getSodienthoai(cmnd);
        }
        public DataTable getBienso(string cmnd, string hieuxe)
        {
            return thanhtoan.getBienso(cmnd, hieuxe);
        }
        public DataTable getHieuxe(string cmnd)
        {
            return thanhtoan.getHieuxe(cmnd);
        }
        public string getNhanviensua(string bienso)
        {
            return thanhtoan.getNhanviensua(bienso);
        }
        public string getMaxid()
        {
            return thanhtoan.getMaxid();
        }
        public DataTable getDataGird(string bienso)
        {
            return thanhtoan.getDataGird(bienso);
        }
        public bool thanhtoanhoadon(DTO_Thanhtoan _tt)
        {
            return thanhtoan.themphieuthanhtoan(_tt);
        }
        public string getMadonhang(string bienso)
        {
            return thanhtoan.getMadonhang(bienso);
        }

    }
}
