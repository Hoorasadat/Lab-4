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
    public partial class OrderForm : Form
    {
        private Order order;
        private int Id;


        public OrderForm()
        {
            InitializeComponent();
        }


        private void OrderForm_Load(object sender, EventArgs e)
        {
            DisplayOrders();
            order = GetOrder(10248);
            Id = 10248;
            DisplayOrderDetails(Id);
        }

        
        private void orderIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (order != null)
            {
                GetID();
                DisplayOrderDetails(Id);
            }
        }


        // method for getting data for the orders and displaying orders
        private void DisplayOrders()
        {            
            List<Order> ord = new List<Order>();
            try
            {
                ord = OrderDB.GetOrders();
                orderBindingSource.DataSource = ord;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


        // method for getting data for the details of the selected order and displaying oder's details
        private void DisplayOrderDetails(int orderId)
        {
            // to display the order details table:
            List<OrderDetails> ordDtl = new List<OrderDetails>();
            try
            {
                ordDtl = OrderDetailsDB.GetOrderDetails(orderId);
                orderDetailsDataGridView.DataSource = ordDtl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            // to display total order:
            try
            {
                txtTotal.Text = OrderDetailsDB.CalOrdTotal(orderId).ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }            
        }


        // setting Id and order after selecting something from the combo box
        private void GetID()
        {
            if (orderIDComboBox.SelectedItem != null)
            {
                order = (Order)orderIDComboBox.SelectedItem;
                Id = order.OrderID;
            }            
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


        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            UpdateForm UpdFrm = new UpdateForm();
            UpdFrm.order = this.order;
            DialogResult Rst = UpdFrm.ShowDialog();
            if (Rst == DialogResult.OK)
            {
                this.order = UpdFrm.order;
                orderIDComboBox.SelectedItem = order;
                DisplayOrders();
                GetID();
                DisplayOrderDetails(Id);
            }
            else if (Rst == DialogResult.Retry)
            {
                // to check if the current order is still in the database
                if (GetOrder(order.OrderID) != null)
                {
                    orderIDComboBox.SelectedItem = order;
                    //DisplayOrders();
                    GetID();
                    DisplayOrderDetails(Id);
                }
                else
                {
                    DisplayOrders();
                    DisplayOrderDetails(10248);
                }
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
