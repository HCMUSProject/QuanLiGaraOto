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
    public class BUS_Lapphieusuachua
    {
        DAL_Lapphieusuachua psc = new DAL_Lapphieusuachua();
        public DataTable getBienso(string cmnd,string hieuxe)
        {
            return psc.getbienso(cmnd,hieuxe);
        }
        public DataTable getNhanvien()
        {
            return psc.getNhanvien();
        }
        public DataTable getDichvu()
        {
            return psc.getloaidichvu();
        }
        public DataTable getSodienthoai(string cmnd)
        {
            return psc.getSodienthoai(cmnd);
        }
        public DataTable getHieuxe(string cmnd)
        {
            return psc.getHieuxe(cmnd);
        }
        public string getMaxid()
        {
            return psc.getMaxid();
        }
        public DataTable getKhachhang()
        {
            return psc.getKhachhang();
        }
        public bool CheckExitsCar(string bienso)
        {
            return psc.CheckExitsCar(bienso);
        }
        public DataTable getVattu()
        {
            return psc.getVattu();
        }
        public string getGiathanh(int mavt)
        {
            return psc.getGiathanh(mavt);
        }
        public string getGiadichvu(string tendichvu)
        {
            return psc.getGiadichvu(tendichvu);
        }
        public bool lapdonhang(DTO_Donhangsuachua dh)
        {
            return psc.lapphieusuachua(dh);
        }
        public bool chitietdonhang(DTO_Chitietdonhang ct)
        {
            return psc.chitiethoadon(ct);

        }
        public bool updateVattu(int mavt,int soluong)
        {
            return psc.updateVattu(mavt, soluong);
        }
        public string getMakhachhang(string cmnd)
        {
            return psc.getMakhachhang(cmnd);
        }
        public string getManhanvien(string cmnd)
        {
            return psc.getManhanvien(cmnd);
        }
        public string getIDxe(string bienso)
        {
            return psc.getIDxe(bienso);
        }
        public string getMadichvu(string tendichvu)
        {
            return psc.getMadichvu(tendichvu);
        }
        public string getSoluongvattu(int mavt)
        {
            return psc.getsoluongvattu(mavt);
        }
    }
}
