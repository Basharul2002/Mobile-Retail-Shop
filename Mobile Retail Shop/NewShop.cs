using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Mobile_Retail_Shop
{
    public partial class NewShop : UserControl
    {
        public NewShop()
        {
            InitializeComponent();
            LoadShopOwner();
        }

        private void LoadShopOwner()
        {
            string error;
            string query = "SELECT ID, Name FROM [User Information] WHERE [User Type] = 2";

            DataBase dataBase = new DataBase();
            DataSet dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class name: NewShop Function: LoadShopOwner \nError: {error}");
                return;
            }

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                owner_cb.Items.Add(new ComboBoxItem { Text = "No Owner", Value = null });
                submit_btn.Enabled = false; // Disable button if no owner
                return;
            }

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                // Create a new ComboBox item with the name
                var item = new ComboBoxItem
                {
                    Text = row["Name"].ToString(),
                    Value = row["ID"]
                };
                // Add the item to the ComboBox
                owner_cb.Items.Add(item);
            }

            // Set the display member to show the text
            owner_cb.DisplayMember = "Text";
            owner_cb.ValueMember = "Value";
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(shop_name_tb.Text))
            {
                MessageBox.Show("Fill up the name");
                label.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email_tb.Text))
            {
                MessageBox.Show("Fill up the email");
                email_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone_number_tb.Text))
            {
                MessageBox.Show("Fill up the phone number");
                phone_number_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(city_tb.Text))
            {
                MessageBox.Show("Fill the city");
                city_tb.Focus();
                return;
            }

            if (owner_cb.SelectedItem == null || owner_cb.SelectedItem is ComboBoxItem selectedItem && selectedItem.Value == null)
            {
                MessageBox.Show("Select a valid owner");
                return;
            }

            if (!Utility.Validity.IsEmailValid(email_tb.Text))
            {
                MessageBox.Show("Invalid Email", "Warning");
                return;
            }

            if (!Utility.Validity.IsPhoneNumberValid(phone_number_tb.Text))
            {
                MessageBox.Show("Invalid Phone Number", "Warning");
                return;
            }

            // Get the selected owner ID
            int ownerId = (int)((ComboBoxItem)owner_cb.SelectedItem).Value;

            string error;
            string query = $@"INSERT INTO [Shop Information] (Name, Email, [Phone Number], City, [User ID])
                              VALUES ('{shop_name_tb.Text}', '{email_tb.Text}', '{phone_number_tb.Text}', '{city_tb.Text}', {ownerId})";

            DataBase dataBase = new DataBase();
            int newShopID = dataBase.ExecuteScalarQuery(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class name: NewShop Function: submit_btn_Click \nError: {error}");
                return;
            }

            query = $@"INSERT INTO [Shop Accounts] ([Shop ID], [Current Balance], [Total Withdraw]) VALUES ({newShopID}, 0, 0)";
            dataBase.ExecuteNonQuery(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class name: NewShop Function: submit_btn_Click \nError: {error}");
                return;
            }


            MessageBox.Show("Shop information inserted successfully.");
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text; // This is what will be shown in the ComboBox
        }
    }
}
