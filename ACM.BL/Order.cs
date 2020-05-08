using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {

        }
        public Order(int orderID)
        {
            OrderID = orderID;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderID { get; set; }

        //Retrieve one order
        public Order Retrieve(int orderID)
        {
            //code that retrieves the definited order

            return new Order();
        }

        //save the current order
        public bool Save()
        {
            //code that saves the defined order

            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

       
    }
}
