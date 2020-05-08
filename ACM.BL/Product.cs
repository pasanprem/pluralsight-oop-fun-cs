using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product
    {
        public Product()
        {

        }
        public Product(int productID)
        {
            ProductID = productID;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        // Retrieve one product
        public Product Retrieve(int productID)
        {
            //Code to retrieve the defined product

            return new Product();
        }

        //Save the current product
        public bool Save()
        {
            //code that saves the defined product

            return true;
        }

        //validate the product data
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }

}
