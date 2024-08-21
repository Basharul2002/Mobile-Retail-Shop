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
    public partial class AdminDeshBoard : Form
    {
        public static AdminDeshBoard obj;
        private string id;
        public AdminDeshBoard()
        {
            InitializeComponent();
        }
        public AdminDeshBoard(string id, string name):this()
        {
            admin_name.Tag = admin_picture.Tag = this.id = id;
            admin_name.Text = name;
        }

        private void AdminDeshBoard_Load(object sender, EventArgs e)
        {
            obj = this;
            DataLoad();
        }

        public static AdminDeshBoard Instance
        {
            get
            {
                if (obj == null) 
                    obj = new AdminDeshBoard();

                return obj;
            }
        }

        public Guna2Panel panelContainer
        {
            get { return data_panel; }
            set { data_panel = value; }

        }

        private void HidePanel()
        {
            if (admin_panel.Visible == true)
                admin_panel.Visible = false;
            

            if (show_owner_panel.Visible == true)
                show_owner_panel.Visible = false;

            

            if (shop_panel.Visible == true)
                shop_panel.Visible = false;
           
        }


        private void ShowSubManu(Panel subManu)
        {
            if (subManu.Visible == false)
            {
                HidePanel();
                subManu.Visible = true;
            }

            else
            {
                subManu.Visible = false;
            }
        }

        private void DataLoad()
        {
            Instance.panelContainer.Controls.Clear();
            AdminDashboardDataPanel adminDashboardDataPanel = new AdminDashboardDataPanel();
            adminDashboardDataPanel.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(adminDashboardDataPanel);
        }
        private void new_admin_btn_Click(object sender, EventArgs e)
        {
            Instance.panelContainer.Controls.Clear();
            NewUser newAdmin = new NewUser(1);
            newAdmin.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(newAdmin);
        }

       

        private void new_owner_btn_Click(object sender, EventArgs e)
        {
            Instance.panelContainer.Controls.Clear();
            NewUser newAdmin = new NewUser(2);
            newAdmin.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(newAdmin);
        }

        private void new_shop_btn_Click(object sender, EventArgs e)
        {
            Instance.panelContainer.Controls.Clear();
            NewShop newShop = new NewShop();
            newShop.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(newShop);
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            ShowSubManu(admin_panel);
        }

        private void shop_owner_info_btn_Click(object sender, EventArgs e)
        {
            ShowSubManu(show_owner_panel);
        }

        private void shop_btn_Click(object sender, EventArgs e)
        {
            ShowSubManu(shop_panel);
        }

        private void admin_information_btn_Click(object sender, EventArgs e)
        {
            Instance.panelContainer.Controls.Clear();
            Users user = new Users(1);
            user.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(user);
        }

        private void all_owner_info_btn_Click(object sender, EventArgs e)
        {
            Instance.panelContainer.Controls.Clear();
            Users user = new Users(2);
            user.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(user);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void all_shop_btn_Click(object sender, EventArgs e)
        {
            Instance.panelContainer.Controls.Clear();
            ShopInformation shop = new ShopInformation();
            shop.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(shop);
        }


        private void customer_btn_Click(object sender, EventArgs e)
        {
            Instance.panelContainer.Controls.Clear();
            Users user = new Users(3);
            user.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(user);
        }

        private void admin_profile_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile(this.id);
            userProfile.ShowDialog();
        }

        private void admin_dashboard_btn_Click(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
    
}
