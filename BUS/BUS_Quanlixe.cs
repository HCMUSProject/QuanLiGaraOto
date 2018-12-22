using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Quanlixe
    {
        DAL_Quanlixe dalquanlixe = new DAL_Quanlixe();
        public DataTable getXe()
        {
            return dalquanlixe.getXe();
        }
        public int getslxehomnay()
        {
            return dalquanlixe.getsoluongxehomnay();

        }
        public int getslxgara()
        {
            return dalquanlixe.getsoluongxegara();
        }
        
    }
}
