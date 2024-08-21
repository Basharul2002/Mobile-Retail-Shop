using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Retail_Shop
{
    public partial class NewProduct : UserControl
    {
        private bool newProduct, admin, shopOwner;
        private string shopID, productID;
        private int totalReviewer;
        private double totalReview;
        private Dictionary<string, CartItem> cart;

        public NewProduct()
        {
            InitializeComponent();
        }

        public NewProduct(string shopID = null, bool admin = false, bool newProduct = false, string productID = null, Dictionary<string, CartItem> cart = null) : this ()
        {
            this.shopID = shopID;
            this.admin = admin;
            this.newProduct = newProduct;
            delete_btn.Tag = this.productID = productID;
            this.cart = cart;

            Design();
        }

        public void Design()
        {
            if (newProduct)
            {
                new_product_panel.Visible = true;
                product_panel.Visible = false;
            }
            else if (productID != null)
            {
                new_product_panel.Visible = false;
                product_panel.Visible = true;
                DataLoad();
            }

            else if (admin)
            {
                new_product_panel.Visible = false;
                product_panel.Visible = true;
                back_btn.Visible = false;
                DataLoad();
            }
                
        }


        private int SimNumber()
        {
            if (one_sim_rb.Checked)
                return 1;
            else if (two_sim_rb.Checked)
                return 2;
            else
                return 0;
        }

        private void DataLoad()
        {

            string error, query = $"SELECT * FROM [Product Information] WHERE ID = {this.productID}";
            DataBase dataBase = new DataBase();
            DataSet dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: Product Function: DataLoad \nError: {error}");
                return;
            }


           // product_picture.Image = Utility.ByteArrayToImage((byte[])(dataTable.Rows[0]["Picture"]));
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


        private void choose_picture_btn_Click(object sender, EventArgs e)
        {
            Utility.pictureUpload(product_image);
        }


        private void add_new_product_btn_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(company_name_tb.Text))
            {
                MessageBox.Show("Fill the company name");
                company_name_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(model_tb.Text))
            {
                MessageBox.Show("Fill the model name");
                model_tb.Focus();
                return;
            }

            if (SimNumber() == 0)
            {
                MessageBox.Show("Choose the SIM number");
                return;
            }

            if (ram_value.SelectedIndex == -1)
            {
                MessageBox.Show("Fill the RAM value");
                return;
            }

            if (ram_size.SelectedIndex == -1)
            {
                MessageBox.Show("Fill the RAM Size");
                return;
            }

            if (rom_value.SelectedIndex == -1)
            {
                MessageBox.Show("Fill the ROM value");
                return;
            }

            if (rom_size.SelectedIndex == -1)
            {
                MessageBox.Show("Fill the ROM Size");
                return;
            }

            if (string.IsNullOrWhiteSpace(color_tb.Text))
            {
                MessageBox.Show("Fill the color");
                color_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(price_tb.Text))
            {
                MessageBox.Show("Fill the price");
                price_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(discount_tb.Text))
            {
                MessageBox.Show("Fill the discount");
                discount_tb.Focus();
                return;
            }

            // Convert the image to a byte array
            byte[] picture;
            Image image = null;
            if (product_picture.Image != null)
                image = product_image.Image;

            else
                image = Properties.Resources.show;

            picture = Utility.ImageToByteArray(image, Utility.GetImageFormat(image));



            // Define the query with placeholders for parameters
            string query = $@"
                            INSERT INTO [Product Information] 
                                (Picture, [Company Name], [Model], SIM, RAM, ROM, Color, Price, Discount, [Total Review], [Total Reviewer], [Shop ID])
                            VALUES
                                ('{picture}', '{company_name_tb.Text}', '{model_tb.Text}', {SimNumber()}, '{ram_value.Text} {ram_size.Text}', '{rom_value.Text} {rom_size.Text}', '{color_tb.Text}', {decimal.Parse(price_tb.Text)},  {decimal.Parse(discount_tb.Text)},  {0},  {0},  '{this.shopID}')";

            DataBase dataBase = new DataBase();
            string error;
            dataBase.ExecuteNonQuery(query, out error);

            // Handle any errors
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: Product Function: add_btn_Click  \nError: {error}");
                return;
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
                ProductDelete();
            
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {
            if (newProduct)
            {
                new_product_panel.Visible = true;
                product_panel.Visible = false;
            }
            else if (productID != null)
            {
                new_product_panel.Visible = false;
                product_panel.Visible = true;
                DataLoad();
            }

            else if (admin)
            {
                new_product_panel.Visible = false;
                product_panel.Visible = true;
                back_btn.Visible = false;
                DataLoad();
            }
        }


        private void ProductDelete()
        {
            string error, query = $"DELETE FROM [Product Information] WHERE ID = {this.productID}";

            DataBase dataBase = new DataBase();
            dataBase.ExecuteNonQuery(query, out error);


            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: NewProduct Function: ProductDelete \nError: {error}");
                return;
            }


            MessageBox.Show("Product Successfully deleted");

            ShopOwner.Instance.panelContainer.Controls.Clear();
            AllProduct allProduct = new AllProduct(this.shopID);
            allProduct.Dock = DockStyle.Fill;
            ShopOwner.Instance.panelContainer.Controls.Add(allProduct);
        }



    }
}
