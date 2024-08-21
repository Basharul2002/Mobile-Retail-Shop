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
    public partial class Balance : UserControl
    {
        private string shopID, password;
        private double currentBalance;
        public Balance()
        {
            InitializeComponent();
        }

        public Balance(string shopID, string password) : this()
        {
            this.shopID = shopID;
            this.password = password;
            DataLoad();
        }

        private void DataLoad()
        {
            string error, query;

            query = $@"SELECT 
                            SA.[Current Balance], 
                            SA.[Total Withdraw], 
                            ISNULL(TD.[Total Quantity], 0) AS [Total Quantity]
                        FROM 
                            [Shop Accounts] SA
                        LEFT JOIN 
                            (SELECT 
                                [Shop ID], 
                                SUM([Quantity]) AS [Total Quantity]
                             FROM 
                                [dbo].[Transaction Details]
                             GROUP BY 
                                [Shop ID]
                            ) TD
                        ON 
                            SA.[Shop ID] = TD.[Shop ID]
                        WHERE 
                            SA.[Shop ID] = {this.shopID}";

            DataBase dataBase = new DataBase();
            DataSet dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class name Balance Function: DataLoad \nError: {error}");
                return;
            }

            currentBalance = Convert.ToDouble(dataSet.Tables[0].Rows[0]["Current Balance"]);


            current_balance.Text = $"Current Balance: {dataSet.Tables[0].Rows[0]["Current Balance"]}";
            total_earn.Text = $"Total Earn: {currentBalance + Convert.ToDouble(dataSet.Tables[0].Rows[0]["Total Withdraw"])}";
            total_product_sell.Text = $"Total Product Sell: {dataSet.Tables[0].Rows[0]["Total Quantity"]}";

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void withdraw_btn_Click(object sender, EventArgs e)
        {
            //         public BalanceWithdraw(string shopID, string password, double currentBalance) : this()

            BalanceWithdraw balanceWithdraw = new BalanceWithdraw(shopID: this.shopID, password: this.password, currentBalance: currentBalance);
            DialogResult result =  balanceWithdraw.ShowDialog();

            if (result == DialogResult.OK)
                DataLoad();
        }
    }
}
