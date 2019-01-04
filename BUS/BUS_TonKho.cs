using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_TonKho
    {
        private DAL_TonKho dal_TonKho = new DAL_TonKho();
        private Exception ex = null;

        public BUS_TonKho()
        {
            dal_TonKho.exception += SetException;
        }

        private void SetException(Exception ex)
        {
            this.ex = ex;
        }

        public Exception GetException()
        {
            return this.ex;
        }

        public DataTable BUS_GetTonKho(DateTime from, DateTime to)
        {
            return dal_TonKho.DAL_GetTonKho(from, to);
        }
    }
}
