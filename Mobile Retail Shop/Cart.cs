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
    public partial class Cart : Form
    {
        private string customerID;
        private Dictionary<string, CartItem> cartItems;
        private double totalPrice = 0, discount = 0;

        public Cart()
        {
            InitializeComponent();
        }

        public Cart(string customerID, Dictionary<string, CartItem> cartItems) : this()
        {
            this.customerID = customerID;
            this.cartItems = cartItems;
            Design();
        }


        private void Design()
        {
            if (cartItems == null || cartItems.Count == 0)
            {
                zero_iteam_panel.Visible = true;
                iteam_panel.Visible = false;
                return;
            }

            zero_iteam_panel.Visible = false;
            iteam_panel.Visible = true;

            CartList cartList;

            foreach (var cartItem in cartItems.Values)
            {
                cartList = new CartList(productID: cartItem.ProductID,
                                        productName: cartItem.ProductName,
                                        productQuantity: cartItem.Quantity,
                                        productPrice: cartItem.Price);
                cart_list_panel.Controls.Add(cartList);
                this.totalPrice += cartItem.Price;
                this.discount += cartItem.Discount;
            }

            total_price.Text = $"Total Price: {this.totalPrice-this.discount}   Discount: {this.discount}";
        }


        private void payment_btn_Click(object sender, EventArgs e)
        {
            if (!CustomerDashboard.Instance.Controls.ContainsKey("Payment"))
            {
                CustomerDashboard.Instance.Controls.Clear();
                Payment payment = new Payment(customerID: this.customerID, cartItems: this.cartItems, totalPrice: this.totalPrice-this.discount);
                payment.Dock = DockStyle.Fill;
                CustomerDashboard.Instance.Controls.Add(payment);
                this.Hide();
            }
        }
    }
}
