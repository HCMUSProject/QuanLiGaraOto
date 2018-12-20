using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Thanhtoan
    {
        private int _idthanhtoan;
        private int _madonhang;
        private DateTime _ngayxuat;
        public int IDTHANHTOAN
        {
            get
            {
                return _idthanhtoan;
            }
            set
            {
                _idthanhtoan = value;
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
        public DateTime NGAYXUAT
        {
            get
            {
                return _ngayxuat;
            }
            set
            {
                _ngayxuat = value;
            }
        }
        public DTO_Thanhtoan()
        {

        }
        public DTO_Thanhtoan(int id,int mdh,DateTime nx)
        {
            this.IDTHANHTOAN = id;
            this.MADONHANG = mdh;
            this.NGAYXUAT = nx;
        }

    }
}
