﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Account: DAL_DBConnect
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

        public DataTable getThongTinAccountNhanVien(DTO_Account AC)
        {
            string SQL = string.Format("SELECT USERNAME,Ten,Ngaysinh,Gioitinh,CMND,Sodienthoai,Diachi,Ngayvaolam " +
                "FROM ACCOUNT AC, NHANVIEN NV WHERE AC.Manhanvien = NV.Manhanvien and AC.username like N'{0}'", AC.USERNAME);
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtThongTinAccountNhanVien = new DataTable();
            da.Fill(dtThongTinAccountNhanVien);
            return dtThongTinAccountNhanVien;
        }

        public DataTable getThongTinUsernamePass(DTO_Account AC)
        {
            string SQL = string.Format("SELECT USERNAME,pass " +
                " FROM ACCOUNT AC WHERE  AC.Manhanvien like N'{0}'", AC.MANHANVIEN);
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtThongTinAccountNhanVien = new DataTable();
            da.Fill(dtThongTinAccountNhanVien);
            return dtThongTinAccountNhanVien;
        }
        //thay đổi mật khẩu
        public bool suaAccount(DTO_Account AC)
        {
            try
            {
                //Ket noi
                _conn.Open();

                //Query string
                string SQL = string.Format("UPDATE ACCOUNT SET" +
                    " pass = '{0}'  where Manhanvien={1}",AC.PASSWORD,AC.MANHANVIEN);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
