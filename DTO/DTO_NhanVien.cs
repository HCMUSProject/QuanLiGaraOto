using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        /*Thuộc tính trong bảng nhân viên*/
        private int _manhanvien;
        private string _ten;
        private string _cmnd;
        private int _tuoi;
        private string _diachi;
        private string _gioitinh;
        private string _sodienthoai;
        private DateTime _ngayvaolam;
        private DateTime _ngaysinh;

        /*phương thức get/set*/
        public int MANHANVIEN {
            get
            {
                return _manhanvien;
            }

            set
            {
                _manhanvien = value;
            }
        }
        public string TENNHANVIEN {
            get
            {
                return _ten;
            }
            set
            {
                _ten = value;
            }
        }
        public string CMND {
            get
            {
                return _cmnd;
            }
            set
            {
                _cmnd = value;
            }
        }
        public int TUOI {
            get
            {
                return _tuoi;
            }
            set
            {
                _tuoi = value;
            }
        }
        public string DIACHI {
            get
            {
                return _diachi;
            }
        
            set
            {
                _diachi = value;
            }
        }
        public string GIOITINH {
            get
            {
                return _gioitinh;
            }
            set
            {
                _gioitinh = value;
            }
        }
        public string SODIENTHOAI {
            get
            {
                return _sodienthoai;
            }
            set
            {
                _sodienthoai = value;
            }
        }

        public DateTime NGAYVAOLAM
        {
            get
            {
                return _ngayvaolam;
            }
            set
            {
                _ngayvaolam = value;
            }
        }

        public DateTime NGAYSINH {
            get
            {
                return _ngaysinh;
            }

            set
            {
                _ngaysinh = value;
            }
        }
        public DTO_NhanVien()
        {

        }
        public DTO_NhanVien(int id,string name,string noc,int age,string addr,string sex,string nphone,DateTime dow,DateTime dob)
        {
            this.MANHANVIEN = id;
            this.TENNHANVIEN = name;
            this.CMND = noc;
            this.TUOI = age;
            this.DIACHI = addr;
            this.GIOITINH = sex;
            this.SODIENTHOAI = nphone;
            this.NGAYVAOLAM = dow;
            this.NGAYSINH = dob;
        }

    }
}
