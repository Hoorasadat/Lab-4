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
        public Order order;

        public UpdateForm()
        {
            InitializeComponent();
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
        

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = order.OrderID.ToString();
            txtCustomerId.Text = order.CustomerID.ToString();
            txtOrderDate.Text = order.OrderDate?.ToString("yyyy-MM-dd");
            txtRequiredDate.Text = order.RequiredDate?.ToString("yyyy-MM-dd");
            DTPShippedDate.Text = order.ShippedDate?.ToString();
        }


        private void btnAccept_Click(object sender, EventArgs e)
        {            
            if (IsValidData(DTPShippedDate))
            {
                Order newOrder = new Order();
                GetNewOrder(newOrder);

                newOrder.ShippedDate = Convert.ToDateTime(DTPShippedDate.Value);

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

        private void GetNewOrder(Order newOrder)
        {
            newOrder.OrderID = order.OrderID;
            newOrder.CustomerID = order.CustomerID;
            newOrder.OrderDate = order.OrderDate;
            newOrder.RequiredDate = order.RequiredDate;
            newOrder.ShippedDate = order.ShippedDate;
        }

        private bool IsValidData(DateTimePicker dtp)
        {
            DateTime ordDate = Convert.ToDateTime(txtOrderDate.Text);
            DateTime ReqDate = Convert.ToDateTime(txtRequiredDate.Text);

            if (Validators.IsProvided(DTPShippedDate) &&
                Validators.IsWithinRange(DTPShippedDate, ordDate, ReqDate))
                return true;
            return false;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
