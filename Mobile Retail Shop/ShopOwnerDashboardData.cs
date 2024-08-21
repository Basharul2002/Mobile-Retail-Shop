using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Mobile_Retail_Shop
{
    public partial class ShopOwnerDashboardData : UserControl
    {
        private string shopID;
        public ShopOwnerDashboardData()
        {
            InitializeComponent();
        }

        public ShopOwnerDashboardData(string shopID) : this()
        {
            DataLoad(shopID);
            ChartDataLoad(shopID);
        }

        private void DataLoad(string shopID)
        {
            string error;

            
            string query = $@"
                                -- Table 0
                                -- Query to get shop owner name, shop name, and total products
                                SELECT 
                                    SI.[Name] AS [Shop Name], 
                                    UI.[Name] AS [Shop Owner Name], 
                                    COUNT(PI.[ID]) AS [Total Products] 
                                FROM 
                                    [Shop Information] SI
                                JOIN 
                                    [User Information] UI ON SI.[User ID] = UI.[ID]
                                LEFT JOIN 
                                    [Product Information] PI ON SI.[ID] = PI.[Shop ID]
                                WHERE 
                                    SI.[ID] = {shopID}
                                GROUP BY 
                                    SI.[Name], UI.[Name];



                                -- Table 1
                                 -- Query for selling top product for last 1 month .
                                SELECT 
                                    TOP 1 PI.[Company Name], PI.[Model] , SUM(TD.[Quantity]) AS [Total Quantity]
                                FROM 
                                   [Transaction Details] TD
                                JOIN 
                                    [Product Information] PI ON TD.[Product ID] = PI.[ID]
                                JOIN 
                                    [Transaction] T ON TD.[Transaction ID] = T.[ID]
                                WHERE 
                                    TD.[Shop ID] = {shopID} AND T.[Transaction Date] > DATEADD(MONTH, -1, GETDATE())
                                GROUP BY 
                                    PI.[Company Name],
                                    PI.[Model]
                                ORDER BY 
                                    [Total Quantity] DESC;



                                -- Table 2
                                 -- Query for selling top product for last 3 month .
                                SELECT 
                                    TOP 1 PI.[Company Name], PI.[Model] , SUM(TD.[Quantity]) AS [Total Quantity]
                                FROM 
                                   [Transaction Details] TD
                                JOIN 
                                    [Product Information] PI ON TD.[Product ID] = PI.[ID]
                                JOIN 
                                    [Transaction] T ON TD.[Transaction ID] = T.[ID]
                                WHERE 
                                    TD.[Shop ID] = {shopID} AND T.[Transaction Date] > DATEADD(MONTH, -3, GETDATE())
                                GROUP BY 
                                    PI.[Company Name],
                                    PI.[Model]
                                ORDER BY 
                                    [Total Quantity] DESC;



                                -- Table 3
                                 -- Query for selling top product for last 6 months
                                SELECT 
                                    TOP 1 PI.[Company Name], PI.[Model] , SUM(TD.[Quantity]) AS [Total Quantity]
                                FROM 
                                   [Transaction Details] TD
                                JOIN 
                                    [Product Information] PI ON TD.[Product ID] = PI.[ID]
                                JOIN 
                                    [Transaction] T ON TD.[Transaction ID] = T.[ID]
                                WHERE 
                                    TD.[Shop ID] = {shopID} AND T.[Transaction Date] > DATEADD(MONTH, -6, GETDATE())
                                GROUP BY 
                                    PI.[Company Name],
                                    PI.[Model]
                                ORDER BY 
                                    [Total Quantity] DESC;


                                -- Table 4
                                 -- Query for selling top product for last 1 year
                                SELECT 
                                    TOP 1 PI.[Company Name], PI.[Model] , SUM(TD.[Quantity]) AS [Total Quantity]
                                FROM 
                                   [Transaction Details] TD
                                JOIN 
                                    [Product Information] PI ON TD.[Product ID] = PI.[ID]
                                JOIN 
                                    [Transaction] T ON TD.[Transaction ID] = T.[ID]
                                WHERE 
                                    TD.[Shop ID] = {shopID} AND T.[Transaction Date] > DATEADD(MONTH, -12, GETDATE())
                                GROUP BY 
                                    PI.[Company Name],
                                    PI.[Model]
                                ORDER BY 
                                    [Total Quantity] DESC;";


            // Execute the first query
            DataBase dataBase = new DataBase();
            DataSet dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: AdminDashboardDataPanel Function: DataLoad\nError: {error}");
                return;
            }

            // Display the data
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                shop_name.Text = $"<b>Shop Name; </b> {dataSet.Tables[0].Rows[0]["Shop Name"].ToString()}";
                shop_owner_name.Text = $"<b>Shop Owner Name: </b>{dataSet.Tables[0].Rows[0]["Shop Owner Name"].ToString()}";
                total_product.Text = $"<b>Total Product: </b>{dataSet.Tables[0].Rows[0]["Total Products"]}";
            }
            else
            {
                shop_name.Text = "<b>Shop Name: </b>N/A";
                shop_owner_name.Text = "<b>Shop Owner Name: </b>N/A";
                total_product.Text = "<b>Total Products: </b>N/A";
            }


            if (dataSet.Tables[1].Rows.Count > 0)
                top_seling_product_last_month.Text = Convert.ToInt32(dataSet.Tables[1].Rows[0]["Total Quantity"]) == 0 ? "<b>Top Selling Product (last 1 month): </b>0" : $"<b>Top Selling Product (last 1 month): </b>{dataSet.Tables[1].Rows[0]["Company Name"]} {dataSet.Tables[1].Rows[0]["Model"]} [<b>Quantity: </b>{dataSet.Tables[1].Rows[0]["Total Quantity"]}]";
            else
                top_seling_product_last_month.Text = "<b>Top Selling Product (last 1 month): </b>N/A ";

            if (dataSet.Tables[2].Rows.Count > 0)
                top_seling_product_three_month.Text = Convert.ToInt32(dataSet.Tables[2].Rows[0]["Total Quantity"]) == 0 ? "<b>Top Selling Product (last 3 month): </b>0" : $"<b>Top Selling Product (last 3 month): </b>{dataSet.Tables[2].Rows[0]["Company Name"]} {dataSet.Tables[2].Rows[0]["Model"]} [<b>Quantity: </b>{dataSet.Tables[2].Rows[0]["Total Quantity"]}]";
            else
                top_seling_product_three_month.Text = "<b>Top Selling Product (last 3 month): </b>N/A";

            if (dataSet.Tables[3].Rows.Count > 0)
                top_seling_product_six_month.Text = Convert.ToInt32(dataSet.Tables[3].Rows[0]["Total Quantity"]) == 0 ? "<b>Top Selling Product (last 6 month): </b>0" : $"<b>Top Selling Product (last 6 month): </b>{dataSet.Tables[3].Rows[0]["Company Name"]} {dataSet.Tables[3].Rows[0]["Model"]} [<b>Quantity: </b>{dataSet.Tables[3].Rows[0]["Total Quantity"]}]";
            else
                top_seling_product_six_month.Text = "<b>Top Selling Product (last 6 month): </b>N/A";

            if (dataSet.Tables[4].Rows.Count > 0)
                top_seling_product_one_year.Text = Convert.ToInt32(dataSet.Tables[4].Rows[0]["Total Quantity"]) == 0 ? "<b>Top Selling Product (last 1 year): </b>0" : $"<b>Top Selling Product (last 1 year): </b>{dataSet.Tables[4].Rows[0]["Company Name"]} {dataSet.Tables[4].Rows[0]["Model"]} [<b>Quantity: </b>{dataSet.Tables[4].Rows[0]["Total Quantity"]}]";
            else
                top_seling_product_one_year.Text = "<b>Top Selling Product (last 1 year): </b>N/A";

        }


        private void ChartDataLoad(string shopID)
        {
            string error;

            // Query to get monthly sales data for the line graph
            string query = $@"
                            SELECT 
                                FORMAT(T.[Transaction Date], 'yyyy-MM') AS Month, 
                                SUM(TD.[Quantity]) AS TotalSold
                            FROM 
                                [Transaction Details] TD
                            JOIN 
                                [Transaction] T ON TD.[Transaction ID] = T.[ID]
                            WHERE 
                                TD.[Shop ID] = {shopID}
                            GROUP BY 
                                FORMAT(T.[Transaction Date], 'yyyy-MM')
                            ORDER BY 
                                Month ASC";

            // Execute the query
            DataBase dataBase = new DataBase();
            DataSet dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: AdminDashboardDataPanel Function: ChartDataLoad\nError: {error}");
                return;
            }


            if (dataSet.Tables[0].Rows.Count > 0)
            {
                // Assuming you have a chart control in your form
                chart1.Series.Clear();
                Series series = chart1.Series.Add("Sales");

                // Populate the chart with data
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    string month = row["Month"].ToString();
                    int totalSold = Convert.ToInt32(row["TotalSold"]);
                    series.Points.AddXY(month, totalSold);
                }

                series.ChartType = SeriesChartType.Line;
            }
            
        }


        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
