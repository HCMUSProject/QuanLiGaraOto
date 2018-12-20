using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_Hangxe
    {
        private string _idhangxe;
        private string _tenhangxe;
        public string IDHANGXE
        {
            get
            {
                return _idhangxe;
            }
            set
            {
                _idhangxe = value;
            }
        }
        public string TENHANGXE
        {
            get
            {
                return _tenhangxe;
            }
            set
            {
                _tenhangxe = value;
            }
        }
        public DTO_Hangxe()
        {

        }
        public DTO_Hangxe(string id, string name)
        {
            this.IDHANGXE = id;
            this.TENHANGXE = name;
        }


    }
}
