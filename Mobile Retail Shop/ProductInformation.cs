using Guna.UI2.WinForms;
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
    public partial class ProductInformation : UserControl
    {
        private string personID, shopID;
        private AllProduct allProduct;
        private bool shopOwner;
        private CustomerDashboard customerDashboard;
        private Dictionary<string, CartItem> cart; 

        public ProductInformation()
        {
            InitializeComponent();
        }

        public ProductInformation(CustomerDashboard customerDashboard = null, bool shopOwner = false, string personID = null, string shopID = null, string id = null, string name = null, string price = null, string discount = null, Image picture = null, AllProduct allProduct = null, Dictionary<string, CartItem> cart = null) : this()
        {
            this.customerDashboard = customerDashboard;
            this.personID = personID;
            this.shopOwner = shopOwner;
            this.allProduct = allProduct;
            this.cart = cart; // Initialize the cart dictionary
            product_details_btn.Tag = product_buy_btn.Tag = id;
            if (shopOwner)
            {
                product_buy_btn.Text = "DELETE";
                //product_edit_btn.Visible = true;
            }
            else
                product_buy_btn.Text = "Add Cart";

            product_picture.Image = (picture != null) ? picture : Properties.Resources.hide;
            product_name.Text = name;
            string error;
            if (discount != null)
                product_price.Text = (Utility.ConvertStringToInt(price, out error) - Utility.ConvertStringToInt(discount, out error)).ToString();
            else
                product_price.Text = price;
        }

        private void product_buy_btn_Click(object sender, EventArgs e)
        {
            // Shop Owner
            if (shopOwner)
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                    ProductDelete();
            }

            // Customer
            else if (!shopOwner)
                ProductBuy();
        }

        private void ProductDelete()
        {
            string error, query = $"DELETE FROM [Product Information] WHERE ID = {product_buy_btn.Tag}";

            DataBase dataBase = new DataBase();
            dataBase.ExecuteNonQuery(query, out error);


            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: ProductInformation Function: ProductDelete \nError: {error}");
                return;
            }

            MessageBox.Show("Product Successfully deleted");

            ShopOwner.Instance.panelContainer.Controls.Clear();
            AllProduct allProduct = new AllProduct(this.shopID);
            allProduct.Dock = DockStyle.Fill;
            ShopOwner.Instance.panelContainer.Controls.Add(allProduct);
        }


        private void ProductBuy()
        {
            string error, query = $"SELECT * FROM [Product Information] WHERE ID = '{product_buy_btn.Tag.ToString()}'";
            DataBase dataBase = new DataBase() ;
            DataSet dataSet = dataBase.DataAccess(query, out error);

            if (!string .IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class ProductInformation Function ProductBuy \nError: {error}");
                return;
            }


            CartItem cartItem = new CartItem(productId: dataSet.Tables[0].Rows[0]["ID"].ToString(), productName: dataSet.Tables[0].Rows[0]["Company Name"].ToString() + " " + dataSet.Tables[0].Rows[0]["Model"].ToString(), shopId: dataSet.Tables[0].Rows[0]["Shop ID"].ToString(), quantity: 1, price: Convert.ToDouble(dataSet.Tables[0].Rows[0]["Price"]), discount: Convert.ToDouble(dataSet.Tables[0].Rows[0]["Discount"]));
            cartItem.AddToCart(cart, productID: dataSet.Tables[0].Rows[0]["ID"].ToString(), productName: dataSet.Tables[0].Rows[0]["Company Name"].ToString() +" " + dataSet.Tables[0].Rows[0]["Model"].ToString(), shopID: dataSet.Tables[0].Rows[0]["Shop ID"].ToString(), quantity: 1, price: Convert.ToDouble(dataSet.Tables[0].Rows[0]["Price"]), discount: Convert.ToDouble(dataSet.Tables[0].Rows[0]["Discount"]));

        }


         
        private void product_details_btn_Click(object sender, EventArgs e)
        {

            if (customerDashboard == null && (ShopOwner.Instance.panelContainer.Controls.ContainsKey("AllProduct")))
            {
                ShopOwner.Instance.panelContainer.Controls.Clear();
                NewProduct allProduct = new NewProduct(shopID: this.shopID, productID: product_details_btn.Tag.ToString());
                allProduct.Dock = DockStyle.Fill;
                ShopOwner.Instance.panelContainer.Controls.Add(allProduct);
            }

            if (!this.shopOwner)
            {
                CustomerDashboard.Instance.panelContainer.Controls.Clear();
                Product allProduct = new Product(customerID: this.personID, productID: product_details_btn.Tag.ToString(), cart: this.cart);
                allProduct.Dock = DockStyle.Fill;
                CustomerDashboard.Instance.panelContainer.Controls.Add(allProduct);
            }

        }
    }
}
