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
    public static class OrderDB
    {
        // a method to get a list of orders from the database:
        public static List<Order> GetOrders()
        {
            // make an empty list of orders
            List<Order> OrderList = new List<Order>();

            // make an empty order object
            Order ord;

            // get connected to the database
            SqlConnection con = NorthwindDB.GetConnection();

            // creating the proper sql query to extract data from MS SQL server
            string SelectQuery = "SELECT OrderID, CustomerID, OrderDate, RequiredDate," +
                "ShippedDate FROM Orders ORDER BY OrderID";

            // creating the proper command to run the query
            SqlCommand cmnd = new SqlCommand(SelectQuery, con);

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
                    //assign the column values to the properties of a new order object
                    ord = new Order();
                    ord.OrderID = (int)dr["OrderID"];

                    // ***************************************************************************
                    // these columns can be null in the database 
                    // so we need to check if they are null for the current row of data or not.  
                    // if they are null, the value for the related property of the object is null.
                    // ***************************************************************************
                    // get the index of the related column in the database
                    int CustomerIDIndex = dr.GetOrdinal("CustomerID");
                    if (dr.IsDBNull(CustomerIDIndex))
                    {
                        ord.CustomerID = null;
                    }
                    else
                        ord.CustomerID = dr["CustomerID"].ToString();

                    int OrderDateIndex = dr.GetOrdinal("OrderDate");
                    if (dr.IsDBNull(OrderDateIndex))
                    {
                        ord.OrderDate = null;
                    }
                    else
                    {
                        ord.OrderDate = Convert.ToDateTime(dr["OrderDate"]);
                    }

                    int RequiredDateIndex = dr.GetOrdinal("RequiredDate");
                    if (dr.IsDBNull(RequiredDateIndex))
                    {
                        ord.RequiredDate = null;
                    }
                    else
                    {
                        ord.RequiredDate = Convert.ToDateTime(dr["RequiredDate"]);
                    }

                    int ShippedDateIndex = dr.GetOrdinal("ShippedDate");
                    if (dr.IsDBNull(ShippedDateIndex))
                    {
                        ord.ShippedDate = null;
                    }
                    else
                    {
                        ord.ShippedDate = Convert.ToDateTime(dr["ShippedDate"]);
                    }
                    // ***************************************************************************
                    // adding the new object to the list of objects
                    OrderList.Add(ord);
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

            return OrderList;
        }


        // a method to get an order from the database:
        public static Order GetOrder(int orderId)
        {
            // make an empty order object
            Order ord = null;

            // get connected to the database
            SqlConnection con = NorthwindDB.GetConnection();

            // creating the proper sql query to extract data from MS SQL server
            string SelectQuery = "SELECT OrderID, CustomerID, OrderDate, RequiredDate," +
                "ShippedDate FROM Orders WHERE OrderID = @OrderId ";

            // creating the proper command to run the query
            SqlCommand cmnd = new SqlCommand(SelectQuery, con);

            // adding the input parameter for running the command (Order ID) to it
            cmnd.Parameters.AddWithValue("@OrderId", orderId);

            // try to run the command
            try
            {
                // opening the connection
                con.Open();

                // creating a sql data reader and run it to read the data from the database
                SqlDataReader dr = cmnd.ExecuteReader(CommandBehavior.SingleRow);

                // read line by line as much as there is something to read
                if (dr.Read())
                {
                    // assign the column values to the properties of a new order object
                    ord = new Order();
                    ord.OrderID = (int)dr["OrderID"];

                    // ***************************************************************************
                    // these columns can be null in the database 
                    // so we need to check if they are null for the current row of data or not.  
                    // if they are null, the value for the related property of the object is null.
                    // ***************************************************************************
                    // get the index of the related column in the database
                    int CustomerIDIndex = dr.GetOrdinal("CustomerID");
                    if (dr.IsDBNull(CustomerIDIndex))
                    {
                        ord.CustomerID = null;
                    }
                    else
                        ord.CustomerID = dr["CustomerID"].ToString();

                    int OrderDateIndex = dr.GetOrdinal("OrderDate");
                    if (dr.IsDBNull(OrderDateIndex))
                    {
                        ord.OrderDate = null;
                    }
                    else
                    {
                        ord.OrderDate = Convert.ToDateTime(dr["OrderDate"]);
                    }

                    int RequiredDateIndex = dr.GetOrdinal("RequiredDate");
                    if (dr.IsDBNull(RequiredDateIndex))
                    {
                        ord.RequiredDate = null;
                    }
                    else
                    {
                        ord.RequiredDate = Convert.ToDateTime(dr["RequiredDate"]);
                    }

                    int ShippedDateIndex = dr.GetOrdinal("ShippedDate");
                    if (dr.IsDBNull(ShippedDateIndex))
                    {
                        ord.ShippedDate = null;
                    }
                    else
                    {
                        ord.ShippedDate = Convert.ToDateTime(dr["ShippedDate"]);
                    }
                    // ***************************************************************************
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
            return ord;
        }


        // a method to update shipping date in the database
        public static bool UpdateOrder(Order newOrder, Order oldOrder)
        {
            bool result = true;

            // get connected to the database
            SqlConnection con = NorthwindDB.GetConnection();

            // creating the proper sql query to update data in MS SQL server
            string UpdateQuery = "Update Orders SET ShippedDate = @NewShippedDate " +
                // to identify record to update
                "WHERE OrderID = @OldOrderId " +
                // remaining conditions for optimistic concurrency
                "AND (ShippedDate = @OldShippedDate OR ShippedDate IS NULL AND @OldShippedDate IS NULL)";

            // creating the proper command to run the query
            SqlCommand cmnd = new SqlCommand(UpdateQuery, con);

            // adding the input parameter for running the command (Order ID) to it
            if (newOrder.ShippedDate == null)
                cmnd.Parameters.AddWithValue("@NewShippedDate", DBNull.Value);
            else
                cmnd.Parameters.AddWithValue("@NewShippedDate", newOrder.ShippedDate);


            cmnd.Parameters.AddWithValue("@OldOrderId", oldOrder.OrderID);

            if (oldOrder.ShippedDate == null)
                cmnd.Parameters.AddWithValue("@OldShippedDate", DBNull.Value);
            else
                cmnd.Parameters.AddWithValue("@OldShippedDate", oldOrder.ShippedDate);

            // try to run the command
            try
            {
                // opening the connection
                con.Open();

                // running the command to update the data in the database         
                int rowUpdated = cmnd.ExecuteNonQuery();
                if (rowUpdated == 0)
                    result = false; // did not update (another user updated or deleted)
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return result;
        }


    }
}