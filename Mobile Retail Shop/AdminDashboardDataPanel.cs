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
    public partial class AdminDashboardDataPanel : UserControl
    {
        public AdminDashboardDataPanel()
        {
            InitializeComponent();
            DataLoad();
        }

        private void DataLoad()
        {
            string query = @"
                            -- Table 0
                            -- Find total admin/shop owner/customer
                            SELECT 
                                SUM(CASE WHEN [User Type] = 1 THEN 1 ELSE 0 END) AS [Total Admin],
                                SUM(CASE WHEN [User Type] = 2 THEN 1 ELSE 0 END) AS [Total Shop Owner],
                                SUM(CASE WHEN [User Type] = 3 THEN 1 ELSE 0 END) AS [Total Customer]
                            FROM 
                                [User Information];

                            -- Table 1
                            -- Find total shop
                            SELECT COUNT(*) FROM [Shop Information];

                            -- Table 2
                            -- Find total shop owner
                            SELECT COUNT(DISTINCT [User ID]) FROM [Shop Information];

                            -- Table 3
                            -- Find total product
                            SELECT COUNT(*) FROM [Product Information];


                            -- Table 4
                            -- Find top selling shop details
                            SELECT TOP 1 
                                SI.[Name] AS [Shop Name],
                                UI.[Name] AS [Shop Owner Name],
                                SUM(TD.[Quantity]) AS [Total Sold Products],
                                PI.[Model] AS [Top Selling Product]
                            FROM [Transaction Details] TD
                            JOIN [Shop Information] SI ON TD.[Shop ID] = SI.[ID]
                            JOIN [User Information] UI ON SI.[User ID] = UI.[ID]
                            JOIN [Product Information] PI ON TD.[Product ID] = PI.[ID]
                            GROUP BY SI.[Name], UI.[Name], PI.[Model]
                            ORDER BY SUM(TD.[Quantity]) DESC;

                            -- Table 5
                            -- Find top selling product details in the last month
                            SELECT TOP 1 
                                PI.[Model] AS [Product Name],
                                SI.[Name] AS [Shop Name],
                                SUM(TD.[Quantity]) AS [Total Sold]
                            FROM [Transaction Details] TD
                            JOIN [Product Information] PI ON TD.[Product ID] = PI.[ID]
                            JOIN [Shop Information] SI ON TD.[Shop ID] = SI.[ID]
                            JOIN [Transaction] T ON TD.[Transaction ID] = T.ID
                            WHERE T.[Transaction Date] >= DATEADD(MONTH, -1, GETDATE())
                            GROUP BY PI.[Model], SI.[Name]
                            ORDER BY SUM(TD.[Quantity]) DESC;
                        ";

            // Execute the query and handle the results here
            DataBase dataBase = new DataBase();
            DataSet dataSet = dataBase.DataAccess(query, out string error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Error loading data: {error}");
                return;
            }

            // Load total admin/customer/shopOwner
            total_admin.Text = Convert.ToInt32(dataSet.Tables[0].Rows[0]["Total Admin"]) == 0 ? "Total Admin: N/A" : $"Total Admin: {dataSet.Tables[0].Rows[0]["Total Admin"]}";
            total_customer.Text = Convert.ToInt32(dataSet.Tables[0].Rows[0]["Total Customer"]) == 0 ? "Total Customer: N/A" : $"Total Customer: {dataSet.Tables[0].Rows[0]["Total Customer"]}";
            total_shop_owner.Text = Convert.ToInt32(dataSet.Tables[0].Rows[0]["Total Shop Owner"]) == 0 ? "Total Shop Owner: N/A" : $"Total Shop Owner: {dataSet.Tables[0].Rows[0]["Total Shop Owner"]}";

            // Load total shop
            total_shop.Text = Convert.ToInt32(dataSet.Tables[1].Rows[0][0]) == 0 ? "Total Shop: N/A" : $"Total Shop: {dataSet.Tables[1].Rows[0][0]}";


            // Load total shop owner
            total_shop_owner.Text = Convert.ToInt32(dataSet.Tables[2].Rows[0][0]) == 0 ? "Total Shop Owner: N/A" : $"Total Shop Owner: {dataSet.Tables[2].Rows[0][0]}";

            // Load total product
            total_product.Text = Convert.ToInt32(dataSet.Tables[3].Rows[0][0]) == 0 ? "Total Product: N/A" : $"Total Product: {dataSet.Tables[3].Rows[0][0]}";



            // Load top selling shop details
            top_shop_name.Text = $"Shop Name: {dataSet.Tables[4].Rows[0]["Shop Name"].ToString()}";
            top_shop_owner_name.Text = $"Shop Owner: {dataSet.Tables[4].Rows[0]["Shop Owner Name"].ToString()}";
            top_shop_product.Text = $"Total Sell: {dataSet.Tables[4].Rows[0]["Total Sold Products"].ToString()}";
            top_shop_top_sell_proudct.Text = $"Top Selling Product: {dataSet.Tables[4].Rows[0]["Top Selling Product"].ToString()}";


            // Load top selling product details in the last month
            top_sell_product_name.Text = $"Product Name: {dataSet.Tables[5].Rows[0]["Product Name"].ToString()} ";
            top_sell_product_shop_name.Text = $"Shop Name: {dataSet.Tables[5].Rows[0]["Shop Name"].ToString()}";
            top_product_total_sell.Text = $"Total Sell: {Convert.ToInt32(dataSet.Tables[5].Rows[0]["Total Sold"]).ToString()}";            
        }
    }

    }

