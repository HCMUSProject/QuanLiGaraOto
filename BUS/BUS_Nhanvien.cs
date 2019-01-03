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
    public class BUS_Nhanvien
    {       
        DAL_Nhanvien dalNhanVien = new DAL_Nhanvien();

        public DataTable getNhanVien()
        {
            return dalNhanVien.getNhanVien();
        }
        public bool themNhanVien(DTO_NhanVien NV, DTO_Account AC)
        {
            return dalNhanVien.themNhanVien(NV, AC);
        }
    }
}
