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
        public ProductInformation()
        {
            InitializeComponent();
        }

        public ProductInformation(string shopID, string id, string name, string price, string discount = null, Image picture = null) : this()
        {
            product_details_btn.Tag = product_buy_btn.Tag = id;
            product_picture.Image =  (picture != null) ? picture : Properties.Resources.hide;
            string error;
            if (discount != null)
                product_price.Text = (Utility.ConvertStringToInt(price, out error) - Utility.ConvertStringToInt(discount, out error)).ToString();
            else
                product_price.Text = price;

        }

        private void product_buy_btn_Click(object sender, EventArgs e)
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
