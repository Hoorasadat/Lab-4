using BusinessClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessClasses
{
    public static class OrderDetailDB
    {
        public static OrderDetails GetOrderDetail(int orderID)
        {
            OrderDetails details = new OrderDetails();

            SqlConnection con = NorthwindDB.GetConnection();
            string SelectQuery = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount " +
                "FROM [Order Details] where OrderID = @OrderID";
            SqlCommand cmnd = new SqlCommand(SelectQuery, con);
            cmnd.Parameters.AddWithValue("@OrderID", orderID);

            try
            {
                con.Open();
                SqlDataReader dr = cmnd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    details = new OrderDetails();
                    details.OrderID = (int)dr["OrderID"];
                    details.ProductID = (int)dr["ProductID"];
                    details.UnitPrice = (decimal)dr["UnitPrice"];
                    details.Quantity = (int)dr["Quantity"];
                    details.Discount = (decimal)dr["Discount"];                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return details;
        }
    }
}
