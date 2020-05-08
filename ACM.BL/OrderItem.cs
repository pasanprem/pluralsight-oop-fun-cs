using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemID)
        {
            OrderItemID = orderItemID;
        }

        public int OrderItemID { get; set; }
        public int ProductID { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        //retrieve one order item
        public OrderItem Retrieve(int orderItemID)
        {
            //code that retrieves the definted order item

            return new OrderItem();
        }

        //saves the current item
        public bool Save()
        {
            //code that saves the defined order item

            return true;
        }

        //validates the order item data
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductID <= 0 ) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
