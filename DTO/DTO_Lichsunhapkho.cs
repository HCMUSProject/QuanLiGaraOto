using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Lichsunhapkho
    {
        private int _idlichsunhapkho;
        private int _mavattu;
        private string _tenvattu;
        private int _giathanh;
        private DateTime _ngaynhapkho;
        private int _manhanvienhap;
        private int _soluongnhap;
        public int IDLICHSUNHAPKHO
        {
            get
            {
                return _idlichsunhapkho;
            }
            set
            {
                _idlichsunhapkho = value;
            }
        }
        public int MAVATTU
        {
            get
            {
                return _mavattu;
            }
            set
            {
                _mavattu = value;
            }
        }
        public string TENVATTU
        {
            get
            {
                return _tenvattu;
            }
            set
            {
                _tenvattu = value;
            }
        }
        public int GIATHANH
        {
            get
            {
                return _giathanh;
            }
            set
            {
                _giathanh = value;
            }
        }
        public DateTime NGAYNHAPKHO
        {
            get
            {
                return _ngaynhapkho;
            }
            set
            {
                _ngaynhapkho = value;
            }
        }
        public int MANHANVIENNHAP
        {
            get
            {
                return _manhanvienhap;
            }
            set
            {
                _manhanvienhap = value;
             
            }
        }
        public int SOLUONGNHAP
        {
            get
            {
                return _soluongnhap;
            }
            set
            {
                _soluongnhap = value;
            }
        }
        public DTO_Lichsunhapkho()
        {

        }
        public DTO_Lichsunhapkho(int id, int mvt,string tvt,int gt,DateTime nnk,int mnv,int sl)
        {
            this.IDLICHSUNHAPKHO = id;
            this.MAVATTU = mvt;
            this.TENVATTU = tvt;
            this.GIATHANH = gt;
            this.NGAYNHAPKHO = nnk;
            this.MANHANVIENNHAP = mnv;
            this.SOLUONGNHAP = sl;
        }

    }
}
