using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Chitietdonhang
    {
        private int _idchitietdonhang;
        private int _madonhang;
        private int _mavattu;
        private int _soluong;
        private int _madichvu;
        public int IDCHITIETDONHANG
        {
            get
            {
                return _idchitietdonhang;
            }
            set
            {
                _idchitietdonhang = value;
            }
        }
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
        public int SOLUONG
        {
            get
            {
                return _soluong;
            }
            set
            {
                _soluong = value;
            }
        }
        public int MADICHVU
        {
            get
            {
                return _madichvu;
            }
            set
            {
                _madichvu = value;
            }
        }
        public DTO_Chitietdonhang()
        {

        }
        public DTO_Chitietdonhang(int id, int mdh,int mvt,int sl,int mdv)
        {
            this.IDCHITIETDONHANG = id;
            this.MADONHANG = mdh;
            this.MAVATTU = mvt;
            this.SOLUONG = sl;
            this.MADICHVU = mdv;
        }
    }
}
