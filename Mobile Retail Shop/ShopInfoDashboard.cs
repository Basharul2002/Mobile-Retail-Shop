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
        public ShopInfoDashboard()
        {
            InitializeComponent();
        }

        public ShopInfoDashboard(string shopID) : this()
        {
            DataLoad(shopID);
        }

        private void DataLoad(string shopID)
        {
            string ownerID, error, query;

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
                        SI.ID = {shopID}";

            DataBase dataBase = new DataBase();
            DataTable dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class ShopInfoDashboard Function DataLoad \nError: {error}", "Shop and owner information");
                return;
            }

            
            

            ownerID = dataTable.Rows[0]["Owner ID"].ToString();

            owner_name.Text = $"Name: {dataTable.Rows[0]["Owner Name"]}";
            owner_email.Text = $"Email: {dataTable.Rows[0]["Owner Name"]}";
            owner_phone_number.Text = $"Phone Number: {dataTable.Rows[0]["Owner Phone Number"]}";

            shop_name.Text = $"Name: {dataTable.Rows[0]["Shop Name"]}";
            shop_email.Text = $"Email: {dataTable.Rows[0]["Shop Email"]}";
            shop_phone_number.Text = $"Phone Number: {dataTable.Rows[0]["Shop Phone Number"]}";
            shop_address.Text = $"Address: {dataTable.Rows[0]["Shop City"]}";




            // Query for find number of shop for this user
            query = $"SELECT COUNT(ID) AS [Number of Shop] FROM [Shop Information] WHERE [User ID] = '{ownerID}'";
            dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class ShopInfoDashboard Function DataLoad \nError: {error}", "Number of shop");
                return;
            }

            number_of_shop.Text = $"Number of Shop: {dataTable.Rows[0]["Number of Shop"]}";



            //  Query for find number of product for this shop
            query = $"SELECT COUNT(ID) AS [Number of Product] FROM [Product Information] WHERE [Shop ID] = '{shopID}'";

            dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class ShopInfoDashboard Function DataLoad \nError: {error}", "number of product");
                return;
            }
            total_product.Text = dataTable.Rows[0]["Number of Product"].ToString();


            if (dataTable.Rows.Count == 0)
            {
                data_result.Visible = false;
                no_product_panel.Visible = true;
                return;
            }

            no_product_panel.Visible = false;
            data_result.Visible = true;



            // Product information show
            query = $"SELECT * FROM [Product Information] WHERE [Shop ID] = '{shopID}'";
            dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class ShopInfoDashboard Function DataLoad \nError: {error}", "Product Information");
                return;
            }

            foreach (DataRow row in dataTable.Rows)
            {
                NewProduct product = new NewProduct(admin: true, productID: row["ID"].ToString());
                data_result.Controls.Add(product);
            }


        }
    }
}
