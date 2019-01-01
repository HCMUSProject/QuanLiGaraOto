using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_DanhMucVatTu
    {
        private Exception ex = null;
        DAL_DanhMucVatTu dal_DanhMuc = new DAL_DanhMucVatTu();

        public BUS_DanhMucVatTu()
        {
            dal_DanhMuc.exception += SetException;
        }

        public DataTable GetDanhMucVatTu()
        {
            return dal_DanhMuc.GetDanhMucVatTu();
        }

        public List<DTO_Danhmucvt> TimKiemDanhMuc(string TenDanhMuc)
        {
            List<DTO_Danhmucvt> listDanhMuc = new List<DTO_Danhmucvt>();

            DataTable dt = dal_DanhMuc.TimKiemDanhMuc(TenDanhMuc);

            foreach(DataRow row in dt.Rows)
            {
                DTO_Danhmucvt temp = new DTO_Danhmucvt();

                temp.MALOAI = int.Parse(row["Maloai"].ToString());
                temp.TENDANHMUC = row["Tendanhmuc"].ToString();

                listDanhMuc.Add(temp);
            }

            return listDanhMuc;
        }

        public bool ThemDanhMuc(string TenDanhMuc)
        {
            List<DTO_Danhmucvt> listDanhMuc = this.TimKiemDanhMuc(TenDanhMuc);

            if (listDanhMuc.Count == 0)
            {
                return dal_DanhMuc.ThemDanhMucVatTu(TenDanhMuc);
            }
            else
            {
                return false;
            }
        }

        public bool SuaDanhMucVatTu(DTO_Danhmucvt danhMuc)
        {
            return dal_DanhMuc.SuaDanhMucVatTu(danhMuc);
        }

        private void SetException(Exception ex)
        {
            this.ex = ex;
        }

        public Exception GetException()
        {
            return this.ex;
        }
    }
}
