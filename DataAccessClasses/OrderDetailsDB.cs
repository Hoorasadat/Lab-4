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
    public static class OrderDetailsDB
    {
        // a method to get a list of order details for a specific order (order ID) from the database:
        public static List<OrderDetails> GetOrderDetails(int orderID)
        {
            // make an empty list of order details
            List<OrderDetails> OrderDetails = new List<OrderDetails>();

            // make an empty order details object
            OrderDetails details;

            // get connected to the database
            SqlConnection con = NorthwindDB.GetConnection();
            
            // creating the proper sql query to extract data from MS SQL server
            string SelectQuery = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount " +
                                 "FROM [Order Details] WHERE OrderID = @OrderID";

            // creating the proper command to run the query
            SqlCommand cmnd = new SqlCommand(SelectQuery, con);

            // adding the input parameter for running the command (Order ID) to it
            cmnd.Parameters.AddWithValue("@OrderID", orderID);

            // try to run the command
            try
            {
                // opening the connection
                con.Open();

                // creating a sql data reader and run it to read the data from the database
                SqlDataReader dr = cmnd.ExecuteReader();

                // read line by line as much as there is something to read
                while (dr.Read())
                {
                    // for each line of the returned rows of data from database, 
                    //assign the column values to the properties of a new order details object
                    details = new OrderDetails();
                    details.OrderID = Convert.ToInt32(dr["OrderID"]);
                    details.ProductID = Convert.ToInt32(dr["ProductID"]);
                    details.UnitPrice = (decimal)dr["UnitPrice"];
                    details.Quantity = Convert.ToInt32(dr["Quantity"]);
                    details.Discount = Convert.ToDecimal(dr["Discount"]);

                    // adding the new object to the list of objects
                    OrderDetails.Add(details);
                }
                dr.Close(); // closing the data reader
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return OrderDetails;
        }



        // a method to calculate the order total for a specific order (order ID) from the order details:
        public static decimal CalOrdTotal(int orderID)
        {
            // make an empty total
            decimal total = 0;

            // get connected to the database
            SqlConnection con = NorthwindDB.GetConnection();

            // creating the proper sql query to extract data from MS SQL server
            string SelectQuery = "SELECT SUM(Quantity* UnitPrice *(1 - Discount)) AS Total " +
                                 "FROM [Order Details] WHERE OrderID = @OrderID Group by OrderID";
            
           // creating the proper command to run the query
           SqlCommand cmnd = new SqlCommand(SelectQuery, con);

            // adding the input parameter for running the command (Order ID) to it
            cmnd.Parameters.AddWithValue("@OrderID", orderID);

            // try to run the command
            try
            {
                // opening the connection
                con.Open();

                // creating a sql data reader and run it to update the data in the database
                SqlDataReader dr = cmnd.ExecuteReader(CommandBehavior.SingleRow);
                
                if (dr.Read())
                {
                    total = Convert.ToDecimal(dr["Total"]);
                } 
                dr.Close(); // closing the data reader
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return total;
        }
    }
}
