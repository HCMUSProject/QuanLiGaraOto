using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_KiemKeVatTu
    {
        private Exception ex = null;

       private  DAL_KiemKeVatTu dal_KiemKe = new DAL_KiemKeVatTu();

        public BUS_KiemKeVatTu()
        {
            dal_KiemKe.exception += SetException;
        }

        private void SetException(Exception ex)
        {
            this.ex = ex;
        }

        public Exception GetException()
        {
            return this.ex;
        }

        public DataTable BUS_GetThongTinVatTu()
        {
            return dal_KiemKe.DAL_GetThongTinVatTu();
        }
    }
}
