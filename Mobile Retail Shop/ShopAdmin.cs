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
    public partial class ShopAdmin : UserControl
    {
        private ShopInformation shopInformation;
        public ShopAdmin()
        {
            InitializeComponent();
        }

        public ShopAdmin(ShopInformation shopInformation = null, string shopID = null, string shopName = null, string shopEmail = null, string shopOwnerName = null, string totalProduct = null) : this()
        {
            this.shopInformation = shopInformation;
            this.Tag = details_btn.Tag = delete_btn.Tag = shopID;
            shop_name.Text = $"Shop Name: {shopName}";
            
            total_product.Text = $"Total Product: {totalProduct}";

            if (shopOwnerName != null)
                shop_owner_name.Text = $"Owner Name: {shopOwnerName}";
            else
                shop_owner_name.Text = $"Email: {shopEmail}";
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            // Show confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                DeleteShop();

        }

        private void DeleteShop()
        {
            string query, error;

            // Delete All product which is store in this shop
            query = $"DELETE [Product Information] WHERE [Shop ID] = '{delete_btn.Tag}'";

            DataBase dataBase = new DataBase();
            dataBase.ExecuteNonQuery(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class ShopAdmin Function delete_btn_Click \nError: {error}", "Product Information");
                return;
            }

            query = $"DELETE [Shop Information] WHERE [ID] = '{delete_btn.Tag}'";
            dataBase.ExecuteNonQuery(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class ShopAdmin Function delete_btn_Click \nError: {error}", "Shop Information");
                return;
            }

            this.shopInformation.DataLoad();
        }

        private void details_btn_Click(object sender, EventArgs e)
        {
            if (!AdminDeshBoard.Instance.panelContainer.Controls.ContainsKey("ShopInfoDashboard"))
            {
                AdminDeshBoard.Instance.panelContainer.Controls.Clear();
                ShopInfoDashboard shopInfoDashboard = new ShopInfoDashboard(details_btn.Tag.ToString());
                shopInfoDashboard.Name = "ShopInfoDashboard"; // Set the name so it can be identified later
                shopInfoDashboard.Dock = DockStyle.Fill;
                AdminDeshBoard.Instance.panelContainer.Controls.Add(shopInfoDashboard); // Correctly add shopInfoDashboard
                shopInfoDashboard.BringToFront(); // Ensure it's displayed on top
            }


        }
    }
}
