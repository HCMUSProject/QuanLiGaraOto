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
    public class BUS_Account
    {
        DAL_Account acc = new DAL_Account();
        
        public DataTable getThongTinAccount(DTO_Account AC)
        {
            return acc.getThongTinAccountNhanVien(AC);
        }

        public DataTable getThongTinUsernamePass(DTO_Account AC)
        {
            return acc.getThongTinUsernamePass(AC);
        }

        public bool CheckAccount(string username,string password)
        {
            return acc.CheckAccount(username, password);
        }
        public string getManhanvien(string username,string password)
        {
            return acc.getManhanvien(username, password);
        }
        public string getTennhanvien(string manhanvien)
        {
            return acc.getTennhanvien(manhanvien);
        }
        public string getLoainhanvien(string username,string password)
        {
            return acc.getLoainhanvien(username, password);
        }

        public bool suaAccount(DTO_Account AC)
        {
            return acc.suaAccount(AC);
        }
    }
}
