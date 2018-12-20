using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Vattu
    {
        private int _mavattu;
        private int _maloai;
        private string _tenvattu;
        private int _soluong;
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
        public DTO_Vattu()
        {

        }
        public DTO_Vattu(int id, int idType,string name,int num)
        {
            this.MAVATTU = id;
            this.MALOAI = idType;
            this.TENVATTU = name;
            this.SOLUONG = num;
        }

    }
}
