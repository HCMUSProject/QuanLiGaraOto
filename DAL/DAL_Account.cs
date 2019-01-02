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
    public class DAL_Account
    {
        DAL_DBConnect connection = new DAL_DBConnect();

        public bool CheckAccount(string username, string password)
        {
            string query = string.Format("SElECT Manhanvien FROM ACCOUNT WHERE username=N'{0}'AND pass=N'{1}'",username,password);
            SqlDataAdapter acc = new SqlDataAdapter(query, connection.ConnectionString);
            DataTable result = new DataTable();
            acc.Fill(result);
            if (result.Rows.Count > 0) return true;
            return false;
        }
        public string getManhanvien(string username, string password)
        {
            string query = string.Format("SElECT Manhanvien FROM ACCOUNT WHERE username=N'{0}'AND pass=N'{1}'", username, password);
            SqlDataAdapter acc = new SqlDataAdapter(query, connection.ConnectionString);
            DataTable result = new DataTable();
            acc.Fill(result);
            return result.Rows[0][0].ToString();
        }
        public string getTennhanvien(string manhanvien)
        {
            string query = string.Format("SElECT Ten FROM NHANVIEN WHERE Manhanvien='{0}'", manhanvien);
            SqlDataAdapter dichvu = new SqlDataAdapter(query, connection.ConnectionString);
            DataTable result = new DataTable();
            dichvu.Fill(result);
            return result.Rows[0][0].ToString();
        }
        public string getLoainhanvien(string username, string password)
        {
            string query = string.Format("SElECT Loainhanvien FROM ACCOUNT WHERE username=N'{0}'AND pass=N'{1}'", username, password);
            SqlDataAdapter acc = new SqlDataAdapter(query, connection.ConnectionString);
            DataTable result = new DataTable();
            acc.Fill(result);
            return result.Rows[0][0].ToString();
        }
    }
}
