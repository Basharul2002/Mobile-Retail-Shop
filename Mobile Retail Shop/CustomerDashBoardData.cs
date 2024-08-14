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
    public partial class CustomerDashBoardData : UserControl
    {
        public CustomerDashBoardData()
        {
            InitializeComponent();
            DataLoad();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            string error, query = $@"SELECT * FROM [Product Information]";

            if (!string.IsNullOrEmpty(search_tb.Text))
                query += $@" WHERE [Compnay Name] = %{search_tb.Text}% OR [Model] = %{search_tb.Text}%";

            DataBase dataBase = new DataBase();

            DataTable dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Class name CustomerDashBoardData function SearchDataLoad \nerror");
                return;
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                //   ProductInformation productInformation = new ProductInformation(shopID: dataTable.Rows[i]["Shop ID"].ToString(), id: dataTable.Rows[i]["ID"].ToString(), name: dataTable.Rows[i]["Company Name"].ToString() + dataTable.Rows[i]["Model"], price: dataTable.Rows[i]["Price"].ToString(), discount: dataTable.Rows[i]["Discount"].ToString(), picture: Utility.ByteArrayToImage((byte[])dataTable.Rows[i]["Picture"]); 
                ProductInformation productInformation = new ProductInformation(shopID: dataTable.Rows[i]["Shop ID"].ToString(), id: dataTable.Rows[i]["ID"].ToString(), name: dataTable.Rows[i]["Company Name"].ToString() + dataTable.Rows[i]["Model"], price: dataTable.Rows[i]["Price"].ToString(), discount: dataTable.Rows[i]["Discount"].ToString());
                result_panel.Controls.Add(productInformation);   
            }
            

        }
    }

}
