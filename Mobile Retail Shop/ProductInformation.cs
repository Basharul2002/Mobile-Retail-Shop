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
        private string shopID;
        private AllProduct allProduct;
        public ProductInformation()
        {
            InitializeComponent();
        }

        public ProductInformation(bool shopOwner, string shopID, string id, string name, string price, string discount = null, Image picture = null, AllProduct allProduct = null) : this()
        {
            this.allProduct = allProduct;
            product_details_btn.Tag = product_buy_btn.Tag = id;
            if (shopOwner)
                product_buy_btn.Text = "DELETE";
            else
                product_buy_btn.Text = "BUY";

            product_picture.Image =  (picture != null) ? picture : Properties.Resources.hide;
            product_name.Text = name;
            string error;
            if (discount != null)
                product_price.Text = (Utility.ConvertStringToInt(price, out error) - Utility.ConvertStringToInt(discount, out error)).ToString();
            else
                product_price.Text = price;

        }

        private void product_buy_btn_Click(object sender, EventArgs e)
        {
            if (product_buy_btn.Text == "DELETE")
                ProductDelete();

            else if (product_buy_btn.Text == "DELETE")
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
           
        }



        private void product_details_btn_Click(object sender, EventArgs e)
        {
            if (ShopOwner.Instance.panelContainer.Controls.ContainsKey("AllProduct"))
            {
                ShopOwner.Instance.panelContainer.Controls.Clear();
                NewProduct allProduct = new NewProduct(shopID: this.shopID, productID: product_details_btn.Tag.ToString());
                allProduct.Dock = DockStyle.Fill;
                ShopOwner.Instance.panelContainer.Controls.Add(allProduct);
            }
        }
    }
}
