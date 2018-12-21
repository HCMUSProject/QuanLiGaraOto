using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_Xe
    {
        private int _idxe;
        private string _tenxe;
        private string _mahangxe;
        private string _mahieuxe;
        private string _bienso;
        private int _makhachhang;
        private DateTime _ngaynhapgara;
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
        public string TENXE
        {
            get
            {
                return _tenxe;
            }
            set
            {
                _tenxe = value;
            }
        }

        public string MAHANGXE
        {
            get
            {
                return _mahangxe;
            }
            set
            {
                _mahangxe = value;
            }
        }

        public string MAHIEUXE
        {
            get
            {
                return _mahieuxe;
            }
            set
            {
                _mahieuxe = value;
            }
        }
        public string BIENSO
        {
            get
            {
                return _bienso;
            }
            set
            {
                _bienso = value;
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

        public DateTime NGAYNHAPGARA
        {
            get
            {
                return _ngaynhapgara;
            }
            set
            {
                _ngaynhapgara = value;
            }
        }

        public DTO_Xe()
        {

        }

        public DTO_Xe(int id,string name,string idMaca,string idCa,string lp,int nCus,DateTime dAdd)
        {
            this.IDXE = id;
            this.TENXE = name;
            this.MAHANGXE = idMaca;
            this.MAHIEUXE = idCa;
            this.BIENSO = lp;
            this.MAKHACHHANG = nCus;
            this.NGAYNHAPGARA = dAdd;
        }

    }
}
