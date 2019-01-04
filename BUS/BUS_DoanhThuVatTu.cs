using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_DoanhThuVatTu
    {
        private DAL_DoanhThuVatTu dal_DoanhThuVatTu = new DAL_DoanhThuVatTu();
        private Exception ex = null;

        public BUS_DoanhThuVatTu()
        {
            dal_DoanhThuVatTu.exception += SetException;
        }

        private void SetException(Exception ex)
        {
            this.ex = ex;
        }

        public Exception GetException()
        {
            return this.ex;
        }

        public DataTable BUS_GetDoanhThuVatTu(DateTime from, DateTime to)
        {
            return dal_DoanhThuVatTu.DAL_GetDoanhThuVatTu(from, to);
        }
    }
}
