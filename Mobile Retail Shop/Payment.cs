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
    public partial class Payment : UserControl
    {
        private string customerID;
        private Dictionary<string, CartItem> cartItems;
        public Payment()
        {
            InitializeComponent();
        }

        public Payment(string customerID, Dictionary<string, CartItem> cartItems) : this() 
        {
            this.customerID = customerID;
            this.cartItems = cartItems;
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
            if (!Customer.Instance.panelContainer.Controls.ContainsKey("CustomerDashboardData"))
            {
                Customer.Instance.panelContainer.Controls.Clear();
                CustomerDashBoardData customerDashBoard = new CustomerDashBoardData(customerID: this.customerID);
                customerDashBoard.Dock = DockStyle.Fill;
                Customer.Instance.panelContainer.Controls.Add(customerDashBoard);
            }
            
        }
    }
}
