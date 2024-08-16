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
    public partial class Customer : Form
    {
        public static Customer obj;
        public Customer form;
        private string customerID, productID;
        Dictionary<string, CartItem> cart = new Dictionary<string, CartItem>();

        public Customer()
        {
            InitializeComponent();
            
        }


        public Customer(string customerID, string productID = null, Customer form = null, Dictionary<string, CartItem> cart = null) : this()
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


        public static Customer Instance
        {
            get
            {
                if (obj == null)
                    obj = new Customer();

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

        private void CustomerDashboardDataLoad()
        {
            Instance.panelContainer.Controls.Clear();
            CustomerDashBoardData newShop = new CustomerDashBoardData(customerID: this.customerID, productID: this.productID, cart: this.cart);
            newShop.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(newShop);
        }
    }
}
