using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessClasses
{
    public class NorthwindDB
    {
        public static SqlConnection GetConnection()
        {
            string ConnectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Northwind;Integrated Security=True";
            //@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Northwind.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Conection = new SqlConnection(ConnectionString);
            return Conection;
            // or:
            // return new SqlConnection(ConnectionString);
        }
    }
}
