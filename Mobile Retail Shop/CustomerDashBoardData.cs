using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Retail_Shop
{
    public partial class CustomerDashBoardData : UserControl
    {
        private string customerID, shopID, productID;

        private int totalReviewer;
        private double totalReview;
        private CustomerDashBoardData form;
        private Dictionary<string, CartItem> cart = new Dictionary<string, CartItem>();

        public CustomerDashBoardData()
        {
            InitializeComponent();
        }

        public CustomerDashBoardData(string customerID, string productID = null, CustomerDashBoardData form = null, Dictionary<string, CartItem> cart = null) : this()
        {
            this.customerID = customerID;
            this.productID = productID;
            this.form = form;
            this.cart = cart ?? new Dictionary<string, CartItem>(); // Ensure cart is initialized

            if (productID == null)
                LoadProducts();
            else
                LoadProductDetails();
        }


        private void search_btn_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }


        private void LoadProducts()
        {   
           result_panel.Controls.Clear();
            string error, query = $@"SELECT * FROM [Product Information]";

            if (!string.IsNullOrEmpty(search_tb.Text))
                query += $@" WHERE [Company Name] LIKE '%{search_tb.Text}%' OR [Model] LIKE '%{search_tb.Text}%'";

            DataBase dataBase = new DataBase();

            DataSet dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class name CustomerDashBoardData function SearchDataLoad \nerror { error}");
                return;
            }

            ProductInformation productInformation;
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                //   ProductInformation productInformation = new ProductInformation(shopID: dataTable.Rows[i]["Shop ID"].ToString(), id: dataTable.Rows[i]["ID"].ToString(), name: dataTable.Rows[i]["Company Name"].ToString() + dataTable.Rows[i]["Model"], price: dataTable.Rows[i]["Price"].ToString(), discount: dataTable.Rows[i]["Discount"].ToString(), picture: Utility.ByteArrayToImage((byte[])dataTable.Rows[i]["Picture"]); 
                productInformation = new ProductInformation(shopOwner: false, personID: this.customerID, shopID: dataSet.Tables[0].Rows[i]["Shop ID"].ToString(), id: dataSet.Tables[0].Rows[i]["ID"].ToString(), name: dataSet.Tables[0].Rows[i]["Company Name"].ToString() + " " + dataSet.Tables[0].Rows[i]["Model"], price: dataSet.Tables[0].Rows[i]["Price"].ToString(), discount: dataSet.Tables[0].Rows[i]["Discount"].ToString(), cart: this.cart);
                result_panel.Controls.Add(productInformation);
            }

        }


        private void LoadProductDetails()
        {
            dashboard_panel.Visible = false;
            product_information_panel.Visible = true;
            string error, query = $@"SELECT * FROM [Product Information] WHERE ID = '{this.productID}'";

            DataBase dataBase = new DataBase();

            DataSet dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class name CustomerDashBoardData function ProductLoad \nerror: {error}");
                return;
            }


            //  product_picture.Image = Utility.ByteArrayToImage((byte[])(dataTable.Rows[0]["Picture"]));
            compnay_name.Text = dataSet.Tables[0].Rows[0]["Company Name"].ToString();
            model.Text = dataSet.Tables[0].Rows[0]["Model"].ToString();
            sim.Text = $"SIM: {dataSet.Tables[0].Rows[0]["SIM"]}";
            ram.Text = $"RAM: {dataSet.Tables[0].Rows[0]["RAM"]}";
            rom.Text = $"ROM: {dataSet.Tables[0].Rows[0]["ROM"]}";
            color.Text = $"COLOR: {dataSet.Tables[0].Rows[0]["Color"]}";
            price.Text = $"Price: {dataSet.Tables[0].Rows[0]["Price"]}";
            discount.Text = $"Discount: {dataSet.Tables[0].Rows[0]["Discount"]}";

            // Convert Total Review to decimal and Total Reviewer to int
            totalReview = Convert.ToDouble(dataSet.Tables[0].Rows[0]["Total Review"]);
            totalReviewer = Convert.ToInt32(dataSet.Tables[0].Rows[0]["Total Reviewer"]);

            // Calculate the rating
            double ratingValue;

            if (totalReviewer > 0) // Ensure there are reviewers to avoid division by zero
            {
                ratingValue = (totalReview / totalReviewer) * 5; // Calculate the rating
                rating.Text = $"Rating: {ratingValue:F1} Total Review: {totalReviewer}"; // Format rating to 1 decimal place
            }
            else
                rating.Text = "Rating: N/A Total Review: 0"; // Handle case where there are no reviewers

        }

        private void result_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customer_profile_btn_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile(userID: this.customerID);
            userProfile.ShowDialog();
        }

        private void log_out_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }


        private void cart_btn_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart(customerID: this.customerID, cartItems: this.cart);
            DialogResult dialogResult = cart.ShowDialog();

            if (dialogResult == DialogResult.OK)
                cart.Hide();
            
        }
    }

}
