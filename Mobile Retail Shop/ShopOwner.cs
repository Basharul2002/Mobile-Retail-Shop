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
        private string showOwnerID;
        public ShopOwner()
        {
            InitializeComponent();
        }

        public ShopOwner(string showOwnerID) : this()
        {
            this.showOwnerID = showOwnerID;
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
            DataTable dataTable = dataBase.DataAccess(query, out string error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class name: ShopOwner Function Name: ShopDataLoad \nError: {error}");
                return;
            }

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Guna2Button shopButton = new Guna2Button
                    {
                        Text = $"Shop-{i + 1}",
                        Tag = dataTable.Rows[i]["ID"].ToString(),
                        Dock = DockStyle.Top
                    };
                    shopButton.Click += new System.EventHandler(this.shop_btn_Click);
                    shop_panel.Controls.Add(shopButton);
                }
            }
        }

        private void shop_btn_Click(object sender, EventArgs e)
        {
            string shopId = null;
            if (sender is Guna2Button shopButton)
                 shopId = shopButton.Tag.ToString();

            Instance.panelContainer.Controls.Clear();
            Shop shop = new Shop(shopId);
            shop.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(shop);

        }

        private void ShopOwner_Load(object sender, EventArgs e)
        {
            obj = this;
        }

        private void log_out_btn_Click(object sender, EventArgs e)
        {
            this.Hide();    
            Login login = new Login();
            login.Show();   
        }
    }
}
