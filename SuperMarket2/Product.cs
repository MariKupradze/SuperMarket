using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket2
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductSummary { get; set; }
        public double ProductPrice { get; set; }    
        public int ProductQuantity { get; set; }
        public byte[] ProductImage { get; set; }

        public Product (int productID, string productName, string productSummary, double productPrice, int productQuantity, byte productImage)
        {
            this.ProductID = productID;
            this.ProductName = productName; 
            this.ProductSummary = productSummary;
            this.ProductPrice = productPrice;
            this.ProductQuantity = productQuantity;
            this.ProductImage = ProductImage;

        }

        public Product()
        {

        }
    }
}
