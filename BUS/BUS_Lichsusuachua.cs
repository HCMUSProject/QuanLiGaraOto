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
    public class BUS_Lichsusuachua
    {
        DAL_Lichsusuachua lichsu = new DAL_Lichsusuachua();
        public DataTable getLichsu(string begin, string end)
        {
            return lichsu.getLichsu(begin, end);
        }
        public DataTable getChitiet(string madonhang)
        {
            return lichsu.getChitiet(madonhang);
        }
    }
}
