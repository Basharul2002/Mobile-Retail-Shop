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
    public partial class CustomerDashboard : Form
    {
        public static CustomerDashboard obj;
        public CustomerDashboard form;
        private string customerID, productID;
        Dictionary<string, CartItem> cart = new Dictionary<string, CartItem>();

        public CustomerDashboard()
        {
            InitializeComponent();
            
        }


        public CustomerDashboard(string customerID, string productID = null, CustomerDashboard form = null, Dictionary<string, CartItem> cart = null) : this()
        {
            this.customerID = customerID;
            this.productID = productID;
            this.form = form;
            this.cart = cart;

             if (productID != null)
                CustomerDashboardDataLoad();

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            obj = this;
            if (productID == null)
                CustomerDashboardLoad();

        }


        public static CustomerDashboard Instance
        {
            get
            {
                if (obj == null)
                    obj = new CustomerDashboard();

                return obj;
            }
        }

        public Guna2Panel panelContainer
        {
            get { return data_panel; }
            set { data_panel = value; }

        }

        private void CustomerDashboardLoad()
        {
            Instance.panelContainer.Controls.Clear();
            CustomerDashBoardData newShop = new CustomerDashBoardData(customerID: this.customerID); 
            newShop.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(newShop);
        }

        private void data_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerDashboardDataLoad()
        {
            Instance.panelContainer.Controls.Clear();
            CustomerDashBoardData newShop = new CustomerDashBoardData(customerID: this.customerID, productID: this.productID, cart: this.cart);
            newShop.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(newShop);
        }
    }
}
