using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-EQ5RP11;Initial Catalog=QuanLiGara;Integrated Security=True");
    }
}
