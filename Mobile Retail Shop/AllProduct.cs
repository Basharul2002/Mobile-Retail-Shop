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
            DataTable dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class AllProduct Function ProductShow \n error; {error}");
                return;
            }

            //         public ProductInformation(string id, string name, string price, string discount = null, Image picture = null) : this()
            ProductInformation productInformation;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                productInformation = new ProductInformation(shopID: this.shopID, id: dataTable.Rows[i]["ID"].ToString(), name: dataTable.Rows[i]["Company Name"].ToString(), price: dataTable.Rows[i]["Price"].ToString(), 
                    discount: dataTable.Rows[i]["Discount"].ToString()/*, picture: Utility.ByteArrayToImage((byte[])(dataTable.Rows[i]["Picture"]*/);
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
            string query = @"SELECT * FROM [Product Information] 
                             WHERE [Shop ID] = @ShopID AND 
                                   ([Company Name] LIKE @SearchText OR 
                                   [Model] LIKE @SearchText OR 
                                   CONCAT([Company Name], ' ', [Model]) LIKE @SearchText)";

            DataBase dataBase = new DataBase();
            DataTable dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class AllProduct Function ProductShow \n error; {error}");
                return;
            }


            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                ProductInformation productInformation = new ProductInformation(shopID: this.shopID, id: dataTable.Rows[i]["ID"].ToString(), name: dataTable.Rows[i]["Company Name"].ToString(), price: dataTable.Rows[i]["Price"].ToString(), discount: dataTable.Rows[i]["Discount"].ToString(), picture: Utility.ByteArrayToImage((byte[])(dataTable.Rows[i]["Picture"])));
                product_result_panel.Controls.Add(productInformation);
            }
        }
    }
}
