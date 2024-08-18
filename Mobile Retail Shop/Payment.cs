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
            card_holder_name.Text = card_holder_name_tb.Text;
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
            if (card_number_tb.Text.Length != 19 || string.IsNullOrWhiteSpace(card_number_tb.Text))
            {
                MessageBox.Show("Invalid Card Number");
                return;
            }

            if (string.IsNullOrWhiteSpace(card_holder_name_tb.Text))
            {
                MessageBox.Show("Enter card holder name");
                return;
            }

            if (expiry_date_tb.Text.Length != 5)
            {
                MessageBox.Show("Invalid Expire date");
                return;
            }

            if (cvv_tb.Text.Length != 4)
            {
                MessageBox.Show("Invalid CVV Number");
                return;
            }


            this.Hide();
            CustomerDashboard customerDashboard = new CustomerDashboard(this.customerID);
            customerDashboard.Show();
            
        }

        private void Payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or a control key (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                 e.Handled = true; // Suppress the key press

            
        }
    }
}
