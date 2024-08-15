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
        private static CustomerDashboard obj;
        private string id;

        public CustomerDashboard()
        {
            InitializeComponent();

        }

        public CustomerDashboard(string id) : this()
        {
            this.id = id;
            DataLoad();
        }

        private void DataLoad()
        {
            CustomerDashboard.Instance.panelContainer.Controls.Clear();
            CustomerDashBoardData data = new CustomerDashBoardData();
            data.Dock = DockStyle.Fill;
            CustomerDashboard.Instance.panelContainer.Controls.Add(data);
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            obj = this;
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
    }
}
