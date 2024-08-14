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
        private bool newProduct;
        private string shopID, productID;
        public NewProduct()
        {
            InitializeComponent();
        }

        public NewProduct(string shopID, bool newProduct = false, string productID = null) : this ()
        {
            this.shopID = shopID;
            this.newProduct = newProduct;
            this.productID = productID;

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
                
        }


        private void DataLoad()
        {

            string error, query = $"SELECT * FROM [Product Information] WHERE ID = {this.productID}";
            DataBase dataBase = new DataBase();
            DataTable dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: Product Function: DataLoad \nError: {error}");
                return;
            }


            product_picture.Image = Utility.ByteArrayToImage((byte[])(dataTable.Rows[0]["Picture"]));
            compnay_name.Text = dataTable.Rows[0]["Company Name"].ToString();
            model.Text = dataTable.Rows[0]["Model"].ToString();
            sim.Text = $"SIM: {dataTable.Rows[0]["SIM"]}";
            ram.Text = $"RAM: {dataTable.Rows[0]["RAM"]}";
            rom.Text = $"ROM: {dataTable.Rows[0]["ROM"]}";
            color.Text = $"COLOR: {dataTable.Rows[0]["Color"]}";
            price.Text = $"Price: {dataTable.Rows[0]["Price"]}";
            discount.Text = $"Discount: {dataTable.Rows[0]["Discount"]}";

        }


        private void choose_picture_btn_Click(object sender, EventArgs e)
        {
            Utility.pictureUpload(product_image);
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            float rating = product_rating_star.Value;
        }

        private void add_btn_Click(object sender, EventArgs e)
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
            if (product_picture.Image != null)
                picture = Utility.ImageToByteArray(product_picture.Image, Utility.GetImageFormat(product_picture.Image));
            
            else
                picture = Utility.ImageToByteArray(Properties.Resources.show, Utility.GetImageFormat(Properties.Resources.show));
            

            // Define the query with placeholders for parameters
            string query = $@"
                            INSERT INTO [Product Information] 
                                (Picture, [Company Name], [Model], SIM, RAM, ROM, Color, Price, Discount, [Total Review], [Total Reviewer], [Shop ID])
                            VALUES
                                ({picture}, '{company_name_tb.Text}', '{model_tb.Text}', {SimNumber()}, '{ram_value.Text} {ram_size.Text}', '{rom_value.Text} {rom_size.Text}', '{color_tb.Text}', {decimal.Parse(price_tb.Text)},  {decimal.Parse(discount_tb.Text)},  {0},  {0},  '{this.shopID}')";

            DataBase dataBase = new DataBase();
            string error;
            DataTable dataTable = dataBase.DataAccess(query, out error);

            // Handle any errors
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: Product Function: add_btn_Click  \nError: {error}");
                return;
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
    }
}
