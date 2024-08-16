using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Retail_Shop
{
    public class CartItem
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string ShopID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public CartItem(string productId, string productName, string shopId, int quantity, double price)
        {
            ProductID = productId;
            ShopID = shopId;
            Quantity = quantity;
            Price = price;
            ProductName = productName;
        }
    }

}
