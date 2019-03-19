using BusinessClasses;
using DataAccessClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class UpdateForm : Form
    {
        // declaring the current order (public and accessible from the first form) 
        public Order order;

        // a bool to check if the user wants to delete the shipped date (checks the delete check box)
        bool delete = false;


        public UpdateForm()
        {
            InitializeComponent();
        }


        // when the form loads, it should show the data in the text boxes 
        // (only the data for the selected order in the first form to edit)
        private void UpdateForm_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = order.OrderID.ToString();
            txtCustomerId.Text = order.CustomerID.ToString();
            txtOrderDate.Text = order.OrderDate?.ToString("yyyy-MM-dd");
            txtRequiredDate.Text = order.RequiredDate?.ToString("yyyy-MM-dd");
            DTPShippedDate.Text = order.ShippedDate?.ToString();
        }


        // method for getting data for an order
        private Order GetOrder(int orderId)
        {
            Order ord = null;
            try
            {
                ord = new Order();
                ord = OrderDB.GetOrder(orderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            return ord;
        }
        

        // if the user confirm the changes
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // check if the new shipped date is valid (in range) or it is null
            if (IsValidData(DTPShippedDate) || (DTPShippedDate.Value == null))
            {
                // creating a new order and setting its properties
                Order newOrder = new Order();
                GetNewOrder(newOrder);

                // if the user wants to delete the shipped date
                if (delete == true)
                    newOrder.ShippedDate = null;
                else
                    // the new order has a different shipped date 
                    newOrder.ShippedDate = Convert.ToDateTime(DTPShippedDate.Value);

                // try to update data in the database
                try
                {
                    if (!OrderDB.UpdateOrder(newOrder, order))
                    {
                        MessageBox.Show("Another user has updated or " +
                            "deleted that customer.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else // successfully updated
                    {
                        order.ShippedDate = newOrder.ShippedDate;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }


        // assigning the new order's properties similar to the current order's properties 
        private void GetNewOrder(Order newOrder)
        {
            newOrder.OrderID = order.OrderID;
            newOrder.CustomerID = order.CustomerID;
            newOrder.OrderDate = order.OrderDate;
            newOrder.RequiredDate = order.RequiredDate;
            newOrder.ShippedDate = order.ShippedDate;
        }


        // validation process for a new shipped date
        private bool IsValidData(DateTimePicker dtp)
        {
            // if the order date and required date are both available
            if (txtOrderDate.Text != "" && txtRequiredDate.Text != "")
            {
                DateTime ordDate = Convert.ToDateTime(txtOrderDate.Text);
                DateTime ReqDate = Convert.ToDateTime(txtRequiredDate.Text);

                // calling "IsWithinRange" method from the validators class
                if (Validators.IsWithinRange(DTPShippedDate, ordDate, ReqDate))
                    return true;
            }
            else
                // because the user may make mistake about setting the shipped date 
                // between order date and requierd date when one of them is null, 
                // check with the administrator is suggested in order to set the 
                // missing data in the database first and later editing the shipped date
                MessageBox.Show("Before being able to edit the shipped date, you need to have both order date and required date.\n" +
                    "Contact your administrator.");
            
            return false;
        }


        // if the user wants to stop the edition process
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        // defining check box for deleting the shipped date
        // since the deletion is impossible for a date time picker control
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            delete = true;
            MessageBox.Show("You just deleted the shipped date. \n" +
                "If you are sure, continue with confirm button.");
            DTPShippedDate.Enabled = false;
        }
    }
}
