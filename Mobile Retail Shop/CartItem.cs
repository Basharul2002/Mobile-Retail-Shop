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
        public double Discount { get; set; }

        public CartItem(string productId, string productName, string shopId, int quantity, double price, double discount)
        {
            ProductID = productId;
            ShopID = shopId;
            Quantity = quantity;
            Price = price;
            ProductName = productName;
            Discount = discount;
        }


        public void AddToCart(Dictionary<string, CartItem> cart, string productID, string productName, string shopID, int quantity, double price, double discount)
        {
            // If the product already exists in the cart, update the quantity and price.
            if (cart.ContainsKey(productID))                 
            {
                cart[productID].Quantity += quantity;
                cart[productID].Price += price;
                cart[productID].Discount += discount;
            }
            // If the product does not exist in the cart, add it.
            else
                cart[productID] = new CartItem(productID, productName, shopID, quantity, price, discount); 

        }
    }
}
