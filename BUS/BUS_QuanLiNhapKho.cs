using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_QuanLiNhapKho
    {
        private DAL_QuanLiNhapKho dal_QuanLiNhapKho = new DAL_QuanLiNhapKho();
        private Exception ex = null;

        public BUS_QuanLiNhapKho()
        {
            dal_QuanLiNhapKho.exception += SetException;
        }

        private void SetException(Exception ex)
        {
            this.ex = ex;
        }

        public Exception GetException()
        {
            return this.ex;
        }

        public DataTable BUS_GetLichSuVatTu(DateTime from, DateTime to)
        {
            return dal_QuanLiNhapKho.DAL_GetLichSuVatTu(from, to);
        }
    }
}
