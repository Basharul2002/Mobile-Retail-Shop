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
    public partial class Product : UserControl
    {
        private string customerID, productID, shopID;
        private int totalReviewer;
        private double totalReview;
        private Dictionary<string, CartItem> cart;
        private CartItem cartItem;
        public Product()
        {
            InitializeComponent();
        }

        public Product(string customerID, string productID, Dictionary<string, CartItem> cart) : this()
        {
            this.customerID = customerID;
            add_cart_btn.Tag = add_btn.Tag = remove_btn.Tag = this.productID = productID;
            this.cart = cart;
            DataLoad();
            UpdateQuantityDisplay();
        }

        private void UpdateQuantityDisplay()
        {
            if (this.cart.ContainsKey(this.productID))
            {
                cartItem = this.cart[this.productID];
                quantity.Text = cartItem.Quantity.ToString();
            }
            else
                // Handle the case where the productId is not in the cart
                quantity.Text = "0";
            
        }


        private void DataLoad()
        {
            string error, query = $"SELECT * FROM [Product Information] WHERE ID = '{this.productID}'";
            DataBase dataBase = new DataBase();
            DataSet dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: Product Function: DataLoad \nError: {error}");
                return;
            }


           // product_picture.Image = Utility.ByteArrayToImage((byte[])(dataTable.Rows[0]["Picture"]));
            compnay_name.Text = dataSet.Tables[0].Rows[0]["Company Name"].ToString();
            model.Text = dataSet.Tables[0].Rows[0]["Model"].ToString();
            sim.Text = $"SIM: {dataSet.Tables[0].Rows[0]["SIM"]}";
            ram.Text = $"RAM: {dataSet.Tables[0].Rows[0]["RAM"]}";
            rom.Text = $"ROM: {dataSet.Tables[0].Rows[0]["ROM"]}";
            color.Text = $"COLOR: {dataSet.Tables[0].Rows[0]["Color"]}";
            price.Text = $"Price: {dataSet.Tables[0].Rows[0]["Price"]}";
            discount.Text = $"Discount: {dataSet.Tables[0].Rows[0]["Discount"]}";
            this.shopID = dataSet.Tables[0].Rows[0]["Shop ID"].ToString();

            // Convert Total Review to decimal and Total Reviewer to int
            totalReview = Convert.ToDouble(dataSet.Tables[0].Rows[0]["Total Review"]);
            totalReviewer = Convert.ToInt32(dataSet.Tables[0].Rows[0]["Total Reviewer"]);

            // Calculate the rating
            double ratingValue;

            if (totalReviewer > 0) // Ensure there are reviewers to avoid division by zero
            {
                ratingValue = (totalReview / totalReviewer) * 5; // Calculate the rating
                rating.Text = $"Rating: {ratingValue:F1} Total Review: {totalReviewer}"; // Format rating to 1 decimal place
            }
            else
                rating.Text = "Rating: N/A Total Review: 0"; // Handle case where there are no reviewers


        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            remove_btn.Enabled = true;
            CartItem cartItem = new CartItem(productId: this.productID, productName: compnay_name.Text + " " + model.Text, shopId: this.shopID, quantity: 1, price: Convert.ToDouble(price.Text.Substring(7)), discount: Convert.ToDouble(discount.Text.Substring(10)));
            cartItem.AddToCart(cart, productID: this.productID, productName: compnay_name.Text + " " + model.Text, shopID: this.shopID, quantity: 1, price: Convert.ToDouble(price.Text.Substring(7)), discount: Convert.ToDouble(discount.Text.Substring(10)));
            UpdateQuantityDisplay();

        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.cart[this.productID].Quantity) > 0)
            {
                CartItem cartItem = new CartItem(productId: this.productID, productName: compnay_name.Text + " " + model.Text, shopId: this.shopID, quantity: -1, price: (-(Convert.ToDouble(price.Text.Substring(7)))), discount: -Convert.ToDouble(discount.Text.Substring(10)));
                cartItem.AddToCart(cart, productID: this.productID, productName: compnay_name.Text + " " + model.Text, shopID: this.shopID, quantity: -1, price: (-(Convert.ToDouble(price.Text.Substring(7)))), discount: -Convert.ToDouble(discount.Text.Substring(10)));
                UpdateQuantityDisplay();
            }

            if (Convert.ToInt32(this.cart[this.productID].Quantity) == 0)
            {
                this.cart.Remove(this.productID);
                remove_btn.Enabled = false;
            }
               


        }

        private void add_cart_btn_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart(customerID: this.customerID, cartItems: this.cart);
            DialogResult dialogResult = cart.ShowDialog();

            if (dialogResult == DialogResult.OK)
                cart.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            CustomerDashboard.Instance.panelContainer.Controls.Clear();
            CustomerDashBoardData customerDashBoardData = new CustomerDashBoardData(customerID: this.customerID, cart: this.cart);
            customerDashBoardData.Dock = DockStyle.Fill;
            CustomerDashboard.Instance.panelContainer.Controls.Add(customerDashBoardData);
        }
    }
}
