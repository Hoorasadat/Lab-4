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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Order> ord = new List<Order>();
            ord = OrderDB.GetOrders();
            orderBindingSource.DataSource = ord;

        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
