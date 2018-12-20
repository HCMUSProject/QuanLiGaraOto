using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Khachhangsuachua
    {
        private int _makhachhang;
        private string _cmnd;
        private string _ten;
        private string _diachi;
        private string _gioitinh;
        private string _sodienthoai;
        private DateTime _ngaysinh;
        public int MAKHACHANG {
            get
            {
                return _makhachhang;
            }
            set
            {
                _makhachhang = value;
            }
        }
        public string CMND
        {
            get
            {
                return _cmnd;
            }
            set
            {
                _cmnd = value;
            }
        }
        public string TEN
        {
            get
            {
                return _ten;
            }
            set
            {
                _ten = value;
            }
        }
        public string DIACHI
        {
            get
            {
                return _diachi;
            }
            set
            {
                _diachi = value;
            }
        }
        public string GIOITINH
        {
            get
            {
                return _gioitinh;
            }
            set
            {
                _gioitinh = value;
            }
        }
        public string SODIENTHOAI
        {
            get
            {
                return _sodienthoai;
            }
            set
            {
                _sodienthoai = value;
            }
        }

        public DateTime NGAYSINH
        {
            get
            {
                return _ngaysinh;
            }
            set
            {
                _ngaysinh = value;
            }
        }

        public DTO_Khachhangsuachua()
        {

        }

        public DTO_Khachhangsuachua(int id,string noc,string name,string addr,string sex,string nphone,DateTime dob)
        {
            this.MAKHACHANG = id;
            this.CMND = noc;
            this.TEN = name;
            this.DIACHI = addr;
            this.GIOITINH = sex;
            this.SODIENTHOAI = nphone;
            this.NGAYSINH = dob;
        }
       
    }

}
