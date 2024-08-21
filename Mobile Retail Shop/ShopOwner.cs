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
    public partial class ShopOwner : Form
    {
        static ShopOwner obj;
        private string showOwnerID, password;
        public ShopOwner()
        {
            InitializeComponent();
        }

        public ShopOwner(string showOwnerID, string password = null) : this()
        {
            this.showOwnerID = showOwnerID;
            this.password = password;
            LoadShops();
        }

        public static ShopOwner Instance
        {
            get
            {
                if (obj == null)
                    obj = new ShopOwner();

                return obj;
            }
        }

        public Guna2Panel panelContainer
        {
            get { return data_panel; }
            set { data_panel = value; }

        }


        private void LoadShops()
        {
            string query = $"SELECT * FROM [Shop Information] WHERE [User ID] = {this.showOwnerID}";
            DataBase dataBase = new DataBase();
            DataSet dataSet = dataBase.DataAccess(query, out string error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class name: ShopOwner Function Name: ShopDataLoad \nError: {error}");
                return;
            }

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    // For shop button
                    Guna2Button shopButton = new Guna2Button
                    {
                        Text = $"Shop-{i + 1}",
                        Tag = dataSet.Tables[0].Rows[i]["ID"].ToString(),
                        Dock = DockStyle.Top
                    };
                    shopButton.Click += new System.EventHandler(this.shop_btn_Click);
                    shop_panel.Controls.Add(shopButton);


                    // Fpr dashboard data
                    ShopOwnerDashboardData shopOwnerDashboardData = new ShopOwnerDashboardData(dataSet.Tables[0].Rows[i]["ID"].ToString());
                    dashboard_data_panel.Controls.Add(shopOwnerDashboardData);

                }
            }
        }

        private void shop_btn_Click(object sender, EventArgs e)
        {
            dashboard_data_panel.Visible = false;
            data_panel.Visible = true;

            string shopId = null;
            if (sender is Guna2Button shopButton)
                 shopId = shopButton.Tag.ToString();

            Instance.panelContainer.Controls.Clear();
            Shop shop = new Shop(shopId, this.password);
            shop.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(shop);

        }

        private void ShopOwner_Load(object sender, EventArgs e)
        {
            obj = this;
        }


        private void shop_owner_profile_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile(this.showOwnerID);
            userProfile.ShowDialog();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            shop_panel.Controls.Clear();
            dashboard_data_panel.Controls.Clear();
            data_panel.Visible = false;
            dashboard_data_panel.Visible = true;
            LoadShops();
        }

        private void log_out_btn_Click(object sender, EventArgs e)
        {
            this.Hide();    
            Login login = new Login();
            login.Show();   
        }
    }
}
