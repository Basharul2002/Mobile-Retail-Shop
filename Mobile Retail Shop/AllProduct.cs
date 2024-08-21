using Mobile_Retail_Shop.Properties;
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
    public partial class AllProduct : UserControl
    {
        private string shopID;
        public AllProduct()
        {
            InitializeComponent();
            
        }

        public AllProduct(string shopID) : this()
        {
            this.shopID = shopID;
            ProductShow();
        }


        private void ProductShow()
        {
            string error, query = $"SELECT * FROM [Product Information] WHERE [Shop ID] = {this.shopID}";
            DataBase dataBase = new DataBase();
            DataSet dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class AllProduct Function ProductShow \nError: {error}");
                return;
            }

            // Iterate through each product in the DataTable
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                // Handle potential null values for the picture
                byte[] pictureBytes = dataSet.Tables[0].Rows[i]["Picture"] as byte[];
                Image image = null;

                if (pictureBytes != null && pictureBytes.Length > 0)
                    image = Utility.ByteArrayToImage(pictureBytes);

                else  // Optionally set a default image if no picture is available
                    image = Properties.Resources.hide; // Replace with your default image
                

                // Create the product information object
                ProductInformation productInformation = new ProductInformation
                (
                    shopOwner: true,
                    shopID: this.shopID,
                    id: dataSet.Tables[0].Rows[i]["ID"].ToString(),
                    name: dataSet.Tables[0].Rows[i]["Company Name"].ToString(),
                    price: dataSet.Tables[0].Rows[i]["Price"].ToString(),
                    discount: dataSet.Tables[0].Rows[i]["Discount"].ToString(),
                    picture: image
                );

                // Add the product information to the panel
                product_result_panel.Controls.Add(productInformation);
            }
        }



        private void search_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(search_tb.Text))
            {
                MessageBox.Show("Searh by name");
                return;
            }

            string error;
            string query = $@"SELECT * FROM [Product Information] 
                             WHERE [Shop ID] = {this.shopID} AND 
                                   ([Company Name] LIKE {search_tb.Text} OR 
                                   [Model] LIKE {search_tb.Text} OR 
                                   CONCAT([Company Name], ' ', [Model]) LIKE {search_tb.Text})";

            DataBase dataBase = new DataBase();
            DataSet dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class AllProduct Function ProductShow \n error; {error}");
                return;
            }


            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                ProductInformation productInformation = new ProductInformation(shopOwner: true, shopID: this.shopID, id: dataSet.Tables[0].Rows[i]["ID"].ToString(), name: dataSet.Tables[0].Rows[i]["Company Name"].ToString(), price: dataSet.Tables[0].Rows[i]["Price"].ToString(), discount: dataSet.Tables[0].Rows[i]["Discount"].ToString(), picture: Utility.ByteArrayToImage((byte[])(dataSet.Tables[0].Rows[i]["Picture"])));
                product_result_panel.Controls.Add(productInformation);
            }
        }
    }
}
