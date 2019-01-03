using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Account
    {
        private int _idaccount;
        private string _username;
        private string _password;
        private int _loainhanvien;
        private int _manhanvien;
        public int IDACCOUNT
        {
            get
            {
                return _idaccount;
            }
            set
            {
                _idaccount = value;
            }
        }
        public string USERNAME
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        public string PASSWORD
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public int LOAINHANVIEN
        {
            get
            {
                return _loainhanvien;
            }
            set
            {
                _loainhanvien = value;
            }
        }
        public int MANHANVIEN
        {
            get
            {
                return _manhanvien;
            }
            set
            {
                _manhanvien = value;
            }
        }
        public DTO_Account()
        {

        }

        public DTO_Account(int id,string user,string pass,int loai,int mnv)
        {
            this.IDACCOUNT = id;
            this.USERNAME = user;
            this.PASSWORD = pass;
            this.LOAINHANVIEN = loai;
            this.MANHANVIEN = mnv;
        }
    }
}
