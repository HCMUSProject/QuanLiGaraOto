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
    public class BUS_Tiepnhanxe
    {
        DAL_Tiepnhanxe dalTiepnhanxe = new DAL_Tiepnhanxe();
      
        public DataTable getKhachhang()
        {
            return dalTiepnhanxe.getKhachhang();
        }
        public DataTable getHangxe()
        {
            return dalTiepnhanxe.getHangxe();
        }
        public DataTable getHieuxe(string hx)
        {
            return dalTiepnhanxe.getHieuxe(hx);
        }
        public bool themXe(DTO_Xe _dxe)
        {
            return dalTiepnhanxe.themXe(_dxe);
        }
        public string getMahangxe(string hang)
        {
            return dalTiepnhanxe.getMahangxe(hang);
        }
        public string getMahieuxe(string hieu)
        {
            return dalTiepnhanxe.getMahieuxe(hieu);
        }
        public string getMakhachhang(string cmnd)
        {
            return dalTiepnhanxe.getMakhachhang(cmnd);
        }
        public bool Checkbienso(string bienso)
        {
            return dalTiepnhanxe.Checkbienso(bienso);
        }
    }
}
