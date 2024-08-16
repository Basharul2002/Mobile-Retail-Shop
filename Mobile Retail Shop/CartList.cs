using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Retail_Shop
{
    public partial class CartList : UserControl
    {
        public CartList()
        {
            InitializeComponent();
        }


        public CartList(string productID, string productName, int productQuantity, double productPrice) : this()
        {
            this.Tag = productID;
            name.Text = $"Name: {productName}";
            quantity.Text = $"Quantity: {productQuantity}";
            price.Text = $"Price: {productPrice / productQuantity:F2}";
            total_price.Text = $"Total Price: {productPrice:F2}";
        }
    }
}
