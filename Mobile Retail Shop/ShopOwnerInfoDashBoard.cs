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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mobile_Retail_Shop
{
    public partial class ShopOwnerInfoDashBoard : UserControl
    {
        private string shopOwnerID, shopOwnerName, shopOwnerEmail, shopOwnerPhoneNumber, shopOwnerCity, shopOwnerPassword;
       

        private Users usersForm;

        public ShopOwnerInfoDashBoard()
        {
            InitializeComponent();
        }
        public ShopOwnerInfoDashBoard(string shopOwnerID, string shopOwnerName, string shopOwnerEmail, string shopOwnerPhoneNumber, string shopOwnerCity, string shopOwnerPassword, Users usersForm) : this()
        {
            this.shopOwnerID = shopOwnerID;
            this.shopOwnerName = shopOwnerName;
            this.shopOwnerEmail = shopOwnerEmail;
            this.shopOwnerPhoneNumber = shopOwnerPhoneNumber;
            this.shopOwnerCity = shopOwnerCity;
            this.shopOwnerPassword = shopOwnerPassword;
            this.usersForm = usersForm;

            DataLoad();
        }

        private void DataLoad()
        {
            string error, query;

            // Shop owner information
            query = $@"SELECT 
                        ID, 
                        Name,
                        Email,
                        [Phone Number]
                    FROM
                        [User Information]
                    WHERE
                        ID = 
            {this.shopOwnerID}";
            DataBase dataBase = new DataBase();
            DataSet dataSet = dataBase.DataAccess(query, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class ShopOwnerInfoDashBoard Function DataLoad \nError: {error}", "Shop  owner information");
                return;
            }
            owner_name.Text = $"Name: {dataSet.Tables[0].Rows[0]["Name"]}";
            owner_email.Text = $"Email: {dataSet.Tables[0].Rows[0]["Email"]}";
            owner_phone_number.Text = $"Phone Number: {dataSet.Tables[0].Rows[0]["Phone Number"]}";

            // Shop Information
            query = $@"SELECT *, 
                            (SELECT COUNT(ID) 
                            FROM [Shop Information] 
                            WHERE [User ID] = {this.shopOwnerID}) AS [Total Shop]
                    FROM [Shop Information]
                    WHERE [User ID] = {this.shopOwnerID}";

            dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class ShopOwnerInfoDashBoard Function DataLoad \nError: {error}", "Shop information");
                return;
            }

            total_shop.Text = $"Total Shop: {dataSet.Tables[0].Rows[0]["Total Shop"]}";


            shop_panel.Visible = true;

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                shop_data_panel.Visible = false;
                zero_shop_panel.Visible = true;
                return;
            }

            shop_data_panel.Visible = true;

            //         public ShopAdmin(ShopInformation shopInformation = null, string shopID = null, string shopName = null, string shopEmail = null, string shopOwnerName = null, string totalProduct = null) : this()

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                ShopAdmin shopAdmin = new ShopAdmin(shopID: row["ID"].ToString(), shopName: row["Name"].ToString(), shopEmail: row["Email"].ToString());
                shop_data_panel.Controls.Add(shopAdmin);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            AdminDeshBoard.Instance.panelContainer.Controls.Clear();    
            usersForm.profile(userId: this.shopOwnerID, userName: this.shopOwnerName, userEmail: this.shopOwnerEmail, userPhoneNumber: this.shopOwnerPhoneNumber, userCity: this.shopOwnerCity, userPassword: this.shopOwnerPassword, userType: 2);
            AdminDeshBoard.Instance.panelContainer.Controls.Add(usersForm);
            usersForm.BringToFront();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string message = "⚠️ **Important Notice:**\n\n" +
                             "Deleting this shop owner will result in the permanent removal of all associated shops and products. " +
                             "This action cannot be undone.\n\n" +
                             "Are you sure you want to proceed with this operation?";

            DialogResult dialogResult = MessageBox.Show(message,
                                                        "Critical Warning",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                bool flag = DeleteAllProduct();
                if (flag)
                {
                    flag = DeleteAllShop();

                    if (flag)
                    {
                        flag = DeleteShopOwner();
                        if (flag) 
                            MessageBox.Show("The shop owner and all associated data have been successfully deleted.",
                                        "Operation Successful",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("An error occurred while deleting the products. Please try again.",
                                    "Deletion Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                
            }
        }



        // Delete from the Product Information table
        private bool DeleteAllProduct()
        {
            string query, error;
            query = $@"DELETE FROM [Product Information]
                        WHERE [Shop ID] IN (
                            SELECT [ID] FROM [Shop Information] 
                            WHERE [User ID] = {this.delete_btn.Tag}";

            DataBase dataBase = new DataBase();
            dataBase.ExecuteNonQuery(query, out error);

            if (string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: ShopInfoDashboard Function DeleteAllProduct \nError: {error}");
                return false;
            }

            return true;
        }


        //  delete from the Shop Information table
        private bool DeleteAllShop()
        {
            string query, error;
            query = $"DELETE FROM [Shop Information] WHERE [User ID] = {this.delete_btn.Tag}";

            DataBase dataBase = new DataBase();
            dataBase.ExecuteNonQuery(query, out error);

            if (string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: ShopInfoDashboard Function DeleteAllShop \nError: {error}");
                return false;
            }

            return true;
        }

        // delete from the [User Information] table
        private bool DeleteShopOwner()
        {
            string query, error;
            query = $@"DELETE FROM [User Information]
                        WHERE [ID] = {this.delete_btn.Tag}";

            DataBase dataBase = new DataBase();
            dataBase.ExecuteNonQuery(query, out error);

            if (string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: ShopInfoDashboard Function DeleteShopOwner \nError: {error}");
                return false;
            }

            return true;
        }



    }
}
