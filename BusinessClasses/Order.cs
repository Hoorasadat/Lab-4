using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClasses
{
    // a class for creating order objects

    public class Order
    {
        // we only need properties

        public int OrderID { get; set; }

        public string CustomerID { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }
    }
}
