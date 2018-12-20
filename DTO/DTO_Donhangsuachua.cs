using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Donhangsuachua
    {
        private int _madonhang;
        private int _manvlaphoadon;
        private int _manvphutrachsua;
        private int _makhachhang;
        private int _idxe;
        private DateTime _ngaylapdonhang;
        private int _tongtien;
        public int MADONHANG
        {
            get
            {
                return _madonhang;
            }
            set
            {
                _madonhang = value;
            }
        }
        public int MANHANVIENLAPHOADON
        {
            get
            {
                return _manvlaphoadon;
            }
            set
            {
                _manvlaphoadon = value;
            }
        }
        public int MANHANVIENPHUTRACHSUA
        {
            get
            {
                return _manvphutrachsua;
            }
            set
            {
                _manvphutrachsua = value;
            }
        }
        public int MAKHACHHANG
        {
            get
            {
                return _makhachhang;
            }
            set
            {
                _makhachhang = value;
            }
        }

        public int IDXE
        {
            get
            {
                return _idxe;
            }
            set
            {
                _idxe = value;
            }
        }
        public DateTime NGAYLAPDONHANG
        {
            get
            {
                return _ngaylapdonhang;
            }
            set
            {
                _ngaylapdonhang = value;
            }
        }
        public int TONGTIEN
        {
            get
            {
                return _tongtien;
            }
            set
            {
                _tongtien = value;
            }
        }
        public DTO_Donhangsuachua()
        {

        }
        public DTO_Donhangsuachua(int id,int nvhd,int nvs,int mkh,int xe,DateTime nldh,int tong)
        {
            this.MADONHANG = id;
            this.MANHANVIENLAPHOADON = nvhd;
            this.MANHANVIENPHUTRACHSUA = nvs;
            this.MAKHACHHANG = mkh;
            this.IDXE = xe;
            this.NGAYLAPDONHANG = nldh;
            this.TONGTIEN = tong;
        }
    }
}
