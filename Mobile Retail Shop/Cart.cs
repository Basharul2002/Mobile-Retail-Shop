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
        private List<CartItem> cartItems;
        public Cart()
        {
            InitializeComponent();
        }

        public Cart(string customerID, List<CartItem> cartItems) : this()
        {
            this.customerID = customerID;
            this.cartItems = cartItems;
            Design();
        }


        private void Design()
        {

            if (cartItems == null)
            {
                zero_iteam_panel.Visible = true;
                iteam_panel.Visible = false;
                return;
            }

            zero_iteam_panel.Visible = false;
            iteam_panel.Visible = true;

            CartList cartList;
            for(int i = 0; i < cartItems.Count; i++)
            {
                cartList = new CartList(productID: cartItems[i].ProductID, productName: cartItems[i].ProductName, productQuantity: cartItems[i].Quantity, productPrice: cartItems[i].Price);
                cart_list_panel.Controls.Add(cartList);
            }

        }

        private void payment_btn_Click(object sender, EventArgs e)
        {
            if (!Customer.Instance.Controls.ContainsKey("Payment"))
            {
                Customer.Instance.Controls.Clear();
                Payment payment = new Payment(customerID: this.customerID, cartItems: this.cartItems);
                payment.Dock = DockStyle.Fill;
                Customer.Instance.Controls.Add(payment);
            }
        }
    }
}
