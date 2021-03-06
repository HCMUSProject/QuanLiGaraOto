﻿using System;
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

        public DataTable getNhanVien(DTO_NhanVien NV)
        {
            return dalNhanVien.getNhanVien(NV);
        }

        public bool themNhanVien(DTO_NhanVien NV, DTO_Account AC)
        {
            return dalNhanVien.themNhanVien(NV, AC);
        }

        public DataTable getNhanVien(DTO_NhanVien NV,DTO_Account AC)
        {
            return dalNhanVien.getNhanVien(NV, AC);
        }
        public bool suaNhanVien(DTO_NhanVien NV)
        {
            return dalNhanVien.suaNhanVien(NV);
        }
        public bool xoaNhanVien(int MaNV)
        {
            return dalNhanVien.xoaNhanVien(MaNV);
        }
    }
}
