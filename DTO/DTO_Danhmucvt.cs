using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Danhmucvt
    {
        private int _maloai;
        private string _tendanhmuc;
        public int MALOAI
        {
            get
            {
                return _maloai;
            }
            set
            {
                _maloai = value;
            }
        }
        public string TENDANHMUC
        {
            get
            {
                return _tendanhmuc;
            }
            set
            {
                _tendanhmuc = value;
            }
        }
        public DTO_Danhmucvt()
        {

        }
        public DTO_Danhmucvt(int id,string name)
        {
            this.MALOAI = id;
            this.TENDANHMUC = name;
        }

    }
}
