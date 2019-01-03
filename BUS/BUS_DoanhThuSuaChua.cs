using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_DoanhThuSuaChua
    {
        private DAL_DoanhThuSuaChua dal_DoanhThuSuaChua = new DAL_DoanhThuSuaChua();
        private Exception ex = null;

        public BUS_DoanhThuSuaChua()
        {
            dal_DoanhThuSuaChua.exception += SetException;
        }

        private void SetException(Exception ex)
        {
            this.ex = ex;
        }

        public Exception GetException()
        {
            return this.ex;
        }

        public DataTable BUS_GetDoanhThuSuaChua(DateTime from, DateTime to)
        {
            return dal_DoanhThuSuaChua.DAL_GetDoanhThuSuaChua(from, to);
        }
    }
}
