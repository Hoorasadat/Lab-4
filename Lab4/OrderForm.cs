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
        // declaring the current order (private and not accessible from the second form) and its Id
        private Order order;
        private int Id;

        
        public OrderForm()
        {
            InitializeComponent();
        }

        // when the form loads, it should show all orders in the combo box(and also the grid view)
        // and the details for the first order in the database inside the bottom table
        private void OrderForm_Load(object sender, EventArgs e)
        {
            DisplayOrders();
            order = GetOrder(10248);
            Id = 10248;
            DisplayOrderDetails(Id);
        }

        // whenever the combo box is changed show the related details
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


        // whenever the edit button is clicked, another form should be opened
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // creating an object of the form
            UpdateForm UpdFrm = new UpdateForm();

            // passing the current order to the second form
            UpdFrm.order = this.order;

            // opening the form
            DialogResult Rst = UpdFrm.ShowDialog();

            // check if the user clicked confirm button in the second form
            if (Rst == DialogResult.OK)
            {
                // passing the edited order to the first form and
                // setting up the first form to show the proper data
                this.order = UpdFrm.order;
                orderIDComboBox.SelectedItem = order;
                DisplayOrders();
                GetID();
                DisplayOrderDetails(Id);
            }
            // if the user cancel the edit process
            else if (Rst == DialogResult.Retry)
            {
                // to check if the current order is still in the database
                if (GetOrder(order.OrderID) != null)
                {
                    // setting up the first form to show the proper data
                    orderIDComboBox.SelectedItem = order;
                    GetID();
                    DisplayOrderDetails(Id);
                }
                else
                {
                    // setting up the first form to show the data for the first order
                    DisplayOrders();
                    DisplayOrderDetails(10248);
                }
            }
        }


        // closing the app
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
