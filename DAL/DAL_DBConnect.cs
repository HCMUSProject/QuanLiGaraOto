using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Xml;

namespace DAL
{
    public class DAL_DBConnect
    {
        protected SqlConnection _conn;
        public SqlConnection ConnectionString { get { return _conn; } }

        public void ReadConnectionString()
        {
            string dataSource = "";
            string catalog = "";
            // file mặc định là config.xml
            XmlReader reader = XmlReader.Create("config.xml");
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    //return only when you have START tag  
                    switch (reader.Name.ToString())
                    {
                        case "DataSource":
                            dataSource = reader.ReadInnerXml();
                            break;
                        case "Catalog":
                            catalog = reader.ReadInnerXml();
                            break;
                    }
                }
            }

            _conn = new SqlConnection($"Data Source={dataSource};Initial Catalog={catalog};Integrated Security=True");
        }

        public DAL_DBConnect()
        {
            ReadConnectionString();
        }
    }
}
