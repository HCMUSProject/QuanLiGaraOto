using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Hieuxe
    {
        private string _idhieuxe;
        private string _mahangxe;
        private string _tenhieuxe;
        public string IDHIEUXE
        {
            get
            {
                return _idhieuxe;
            }
            set
            {
                _idhieuxe = value;
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
        public string TENHIEUXE
        {
            get
            {
                return _tenhieuxe;
            }
            set
            {
                _tenhieuxe = value;
            }
        }
        public DTO_Hieuxe()
        {

        }
        public DTO_Hieuxe(string id,string idMaca,string name)
        {
            this.IDHIEUXE = id;
            this.MAHANGXE = idMaca;
            this.TENHIEUXE = name;
        }

    }
}
