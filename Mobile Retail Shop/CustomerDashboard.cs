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
        private string id, shopID, productID;

        private int totalReviewer;
        private decimal totalReview;

        public CustomerDashboard()
        {
            InitializeComponent();
        }

        public CustomerDashboard(string id, string shopID = null, string productID = null, CustomerDashboard form = null) : this()
        {
            this.id = id;
            this.shopID = shopID;
            this.productID = productID;
            

            if (productID == null)
                ProductsLoad();

            else if (productID != null)
            {
                data_panel.Visible = false;
                product_details_panel.Visible = true;
                ProductLoad();
            }

        }

        private void ProductsLoad()
        {
            string error, query = $@"SELECT * FROM [Product Information]";

            if (!string.IsNullOrEmpty(search_tb.Text))
                query += $@" WHERE [Compnay Name] = %{search_tb.Text}% OR [Model] = %{search_tb.Text}%";

            DataBase dataBase = new DataBase();

            DataTable dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Class name CustomerDashBoardData function ProductsLoad \nerror");
                return;
            }

            ProductInformation productInformation;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                //   ProductInformation productInformation = new ProductInformation(shopID: dataTable.Rows[i]["Shop ID"].ToString(), id: dataTable.Rows[i]["ID"].ToString(), name: dataTable.Rows[i]["Company Name"].ToString() + dataTable.Rows[i]["Model"], price: dataTable.Rows[i]["Price"].ToString(), discount: dataTable.Rows[i]["Discount"].ToString(), picture: Utility.ByteArrayToImage((byte[])dataTable.Rows[i]["Picture"]); 
              //  productInformation = new ProductInformation(customerDashboard: this, shopOwner: false, shopID: dataTable.Rows[i]["Shop ID"].ToString(), id: dataTable.Rows[i]["ID"].ToString(), name: dataTable.Rows[i]["Company Name"].ToString() + dataTable.Rows[i]["Model"], price: dataTable.Rows[i]["Price"].ToString(), discount: dataTable.Rows[i]["Discount"].ToString());
                //result_panel.Controls.Add(productInformation);
            }

        }

        private void ProductLoad()
        {
            string error, query = $@"SELECT * FROM [Product Information] WHERE ID = '{this.productID}'";

            DataBase dataBase = new DataBase();

            DataTable dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class name CustomerDashBoardData function ProductLoad \nerror: {error}");
                return;
            }


          //  product_picture.Image = Utility.ByteArrayToImage((byte[])(dataTable.Rows[0]["Picture"]));
            compnay_name.Text = dataTable.Rows[0]["Company Name"].ToString();
            model.Text = dataTable.Rows[0]["Model"].ToString();
            sim.Text = $"SIM: {dataTable.Rows[0]["SIM"]}";
            ram.Text = $"RAM: {dataTable.Rows[0]["RAM"]}";
            rom.Text = $"ROM: {dataTable.Rows[0]["ROM"]}";
            color.Text = $"COLOR: {dataTable.Rows[0]["Color"]}";
            price.Text = $"Price: {dataTable.Rows[0]["Price"]}";
            discount.Text = $"Discount: {dataTable.Rows[0]["Discount"]}";

            // Convert Total Review to decimal and Total Reviewer to int
            totalReview = Convert.ToDecimal(dataTable.Rows[0]["Total Review"]);
            totalReviewer = Convert.ToInt32(dataTable.Rows[0]["Total Reviewer"]);

            // Calculate the rating
            decimal ratingValue;

            if (totalReviewer > 0) // Ensure there are reviewers to avoid division by zero
            {
                ratingValue = (totalReview / totalReviewer) * 5; // Calculate the rating
                rating.Text = $"Rating: {ratingValue:F1} Total Review: {totalReviewer}"; // Format rating to 1 decimal place
            }
            else
                rating.Text = "Rating: N/A Total Review: 0"; // Handle case where there are no reviewers

        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
          // obj = this;
        }


        private void search_btn_Click(object sender, EventArgs e)
        {
            ProductsLoad();
        }

        private void log_out_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();   
        }

        private void card_number_tb_TextChanged(object sender, EventArgs e)
        {           
            string text = card_number_tb.Text.Replace(" ", string.Empty); // Remove existing spaces to work with the raw number.


            StringBuilder newText = new StringBuilder();  // Insert a space after every 4 digits.
            for (int i = 0; i < text.Length; i++)
            {
                newText.Append(text[i]);
                if ((i + 1) % 4 == 0 && i + 1 != text.Length)
                    newText.Append(" ");
                
            }

            // Update the TextBox text only if it differs to avoid recursive TextChanged calls.
            if (card_number_tb.Text != newText.ToString())
            {
                card_number_tb.Text = newText.ToString();
                card_number_tb.SelectionStart = card_number_tb.Text.Length;                 // Set the cursor position to the end of the TextBox.
            }
           
            card_number.Text = card_number_tb.Text;  // Update the card number label or any other display control.
        }

      


        private void card_holder_tb_TextChanged(object sender, EventArgs e)
        {
            card_holder_name.Text = card_holder_tb.Text;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (product_rating_star.Value <= 0)
            {
                MessageBox.Show("Please enter the rarting");
                return;
            }


            string error, query = $"UPDATE [User Information] SET [Total Review] = {totalReview + Convert.ToDecimal(product_rating_star.Value)}, [Total Reviewer] = {totalReviewer + 1} WHERE ID = {this.productID}";

            DataBase dataBase = new DataBase();
            dataBase.ExecuteNonQuery(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"CLass : NewProduct FUnction: submit_btn_Click \nError: {error}");
                return;
            }

            MessageBox.Show("Review successfully submiited");
        }


        private void expiry_date_tb_TextChanged(object sender, EventArgs e)
        {
            // Remove any existing slashes to work with the raw number.
            string text = expiry_date_tb.Text.Replace("/", string.Empty);

            // Insert a slash after the second digit.
            if (text.Length > 2)
                text = text.Insert(2, "/");
            

            // Update the TextBox text only if it differs to avoid recursive TextChanged calls.
            if (expiry_date_tb.Text != text)
            {
                expiry_date_tb.Text = text;
                expiry_date_tb.SelectionStart = expiry_date_tb.Text.Length;  // Set the cursor position to the end of the TextBox.
            }

            // Update the label or other control with the formatted date.
            expiry_date.Text = expiry_date_tb.Text;
        }



        private void payment_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
