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
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace Mobile_Retail_Shop
{
    public partial class ShopInfoDashboard : UserControl
    {
        private string ownerID, shopID;
        public ShopInfoDashboard()
        {
            InitializeComponent();
        }

        public ShopInfoDashboard(string shopID) : this()
        {
            this.shopID = shopID;
            DataLoad();
        }

        private void DataLoad()
        {
            string error, query;

            // Shop and owner information
            query = $@"SELECT 
                        UI.[ID] AS [Owner ID],
                        UI.[Name] AS [Owner Name],
                        UI.[Email] AS [Owner Email],
                        UI.[Phone Number] AS [Owner Phone Number],
                        SI.[Name] AS [Shop Name],
                        SI.[Email] AS [Shop Email],
                        SI.[Phone Number] AS [Shop Phone Number],
                        SI.[City] AS [Shop City]
                    FROM
                        [Shop Information] SI 
                    INNER JOIN
                        [User Information] UI
                        ON SI.[User ID] = UI.ID
                    WHERE 
                        SI.ID = {this.shopID}";

            DataBase dataBase = new DataBase();
            DataSet dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class ShopInfoDashboard Function DataLoad \nError: {error}", "Shop and owner information");
                return;
            }

            
            

            this.ownerID = dataSet.Tables[0].Rows[0]["Owner ID"].ToString();

            owner_name.Text = $"Name: {dataSet.Tables[0].Rows[0]["Owner Name"]}";
            owner_email.Text = $"Email: {dataSet.Tables[0].Rows[0]["Owner Email"]}";
            owner_phone_number.Text = $"Phone Number: {dataSet.Tables[0].Rows[0]["Owner Phone Number"]}";

            shop_name.Text = $"Name: {dataSet.Tables[0].Rows[0]["Shop Name"]}";
            shop_email.Text = $"Email: {dataSet.Tables[0].Rows[0]["Shop Email"]}";
            shop_phone_number.Text = $"Phone Number: {dataSet.Tables[0].Rows[0]["Shop Phone Number"]}";
            shop_address.Text = $"Address: {dataSet.Tables[0].Rows[0]["Shop City"]}";




            // Query for find number of shop for this user
            query = $"SELECT COUNT(ID) AS [Number of Shop] FROM [Shop Information] WHERE [User ID] = '{this.ownerID}'";
            dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class ShopInfoDashboard Function DataLoad \nError: {error}", "Number of shop");
                return;
            }

            number_of_shop.Text = $"Number of Shop: {dataSet.Tables[0].Rows[0]["Number of Shop"]}";



            //  Query for find number of product for this shop
            query = $"SELECT COUNT(ID) AS [Number of Product] FROM [Product Information] WHERE [Shop ID] = '{shopID}'";

            dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class ShopInfoDashboard Function DataLoad \nError: {error}", "number of product");
                return;
            }
            total_product.Text = $"Total Product: {dataSet.Tables[0].Rows[0]["Number of Product"].ToString()}";


            if (dataSet.Tables[0].Rows.Count == 0)
            {
                data_result.Visible = false;
                no_product_panel.Visible = true;
                return;
            }

            no_product_panel.Visible = false;
            data_result.Visible = true;



            // Product information show
            query = $"SELECT * FROM [Product Information] WHERE [Shop ID] = '{shopID}'";
            dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class ShopInfoDashboard Function DataLoad \nError: {error}", "Product Information");
                return;
            }

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                NewProduct product = new NewProduct(admin: true, productID: row["ID"].ToString());
                data_result.Controls.Add(product);
            }


        }

        // Delete all product
        private void delete_all_product_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show
                                        (
                                            "N.B.: Deleting all products is a permanent action and cannot be undone. All associated data will be lost.\n\nAre you sure you want to proceed?",
                                            "Confirm Deletion",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning
                                        );

            if (dialogResult == DialogResult.Yes)
            {
                // Proceed with product deletion
                bool flag = DeleteAllProduct();

                if (flag)
                    MessageBox.Show("All products have been deleted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                
            }
        }


        private bool DeleteAllProduct()
        {
            string query, error;
            query = $"DELETE FROM [Product Information] WHERE [Shop ID] = {this.shopID}";

            DataBase dataBase = new DataBase();
            dataBase.ExecuteNonQuery(query, out error);

            if (string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: ShopInfoDashboard Function DeleteAllProduct \nError: {error}");
                return false;
            }

            delete_all_product_btn.Enabled = false;
            return true;    
        }

        private bool DeleteShop()
        {
            string query, error;
            query = $"DELETE FROM [Shop Information] WHERE [D] = {this.shopID}";

            DataBase dataBase = new DataBase();
            dataBase.ExecuteNonQuery(query, out error);

            if (string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: ShopInfoDashboard Function DeleteAllProduct \nError: {error}");
                return false;
            }

            delete_shop_btn.Enabled = false;
            return true;
        }


        private void delete_shop_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show
                                        (
                                            "N.B.: If the shop is deleted, all products associated with this shop will also be deleted. \n\nAre you sure you want to proceed?",
                                            "Confirm Deletion",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning
                                        );

            if (dialogResult == DialogResult.Yes)
            {
                // Proceed with shop deletion and cascading product deletion
                bool flag = DeleteAllProduct();

                if (flag)
                {
                    flag = DeleteShop();
                    MessageBox.Show("Shop Successfully deleted");

                }

            }
        }
    }
}
