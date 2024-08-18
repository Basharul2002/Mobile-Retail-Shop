using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Util;
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

        public Payment(string customerID, Dictionary<string, CartItem> cartItems, double totalPrice) : this() 
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



        private void Payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or a control key (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                 e.Handled = true; // Suppress the key press  
        }

        private int PaymentExecuteNonQuery()
        {
            try
            {
                // Create a new SqlConnection and SqlCommand
                using (SqlConnection connection = new SqlConnection(DataBaseConnection.connectionString))
                {
                    connection.Open();

                    // Begin a transaction
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        // Define the transaction header query
                        string transactionQuery = @"
                                                    DECLARE @TransactionID INT;
                                                    INSERT INTO [Transaction] ([User ID], [Transaction Date])
                                                    VALUES (@UserID, GETDATE());
                                                    SET @TransactionID = SCOPE_IDENTITY();
                                                    SELECT @TransactionID AS TransactionID;";

                        int transactionID;
                        using (SqlCommand cmd = new SqlCommand(transactionQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@UserID", this.customerID);
                            object result = cmd.ExecuteScalar();
                            transactionID = Convert.ToInt32(result);
                        }

                        // Define the SQL query for inserting into [Transaction Details]
                        string transactionDetailsQuery = @"
                                                            INSERT INTO [Transaction Details] ([Transaction ID], [Shop ID], [Product ID], [Quantity], [Total Price])
                                                            VALUES (@TransactionID, @ShopID, @ProductID, @Quantity, @TotalPrice);";

                        using (SqlCommand cmd = new SqlCommand(transactionDetailsQuery, connection, transaction))
                        {
                            foreach (var item in cartItems.Values)
                            {
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@TransactionID", transactionID);
                                cmd.Parameters.AddWithValue("@ShopID", item.ShopID);
                                cmd.Parameters.AddWithValue("@ProductID", item.ProductID);
                                cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                                cmd.Parameters.AddWithValue("@TotalPrice", item.Price);

                                bool success = cmd.ExecuteNonQuery() > 0;

                                if (!success)
                                {
                                    MessageBox.Show("Failed to insert transaction details.");
                                    transaction.Rollback();
                                    connection.Close();
                                    return 0;
                                }
                            }
                        }

                        // Update the Account table with the new balance
                        string updateAccountQuery = @"
                                                    UPDATE [Shop Accounts]
                                                    SET [Current Balance] = [Current Balance] + @TotalPrice
                                                    WHERE [Shop ID] = @ShopID;";

                        using (SqlCommand cmd = new SqlCommand(updateAccountQuery, connection, transaction))
                        {
                            foreach (var item in cartItems.Values)
                            {
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@ShopID", item.ShopID);
                                cmd.Parameters.AddWithValue("@TotalPrice", item.Price * item.Quantity);

                                bool success = cmd.ExecuteNonQuery() > 0;

                                if (!success)
                                {
                                    MessageBox.Show("Failed to update account balance.");
                                    transaction.Rollback();
                                    connection.Close();
                                    return 0;
                                }
                            }
                        }

                        // Commit the transaction if all operations succeed
                        transaction.Commit();
                        MessageBox.Show("Payment Successful");
                        connection.Close();
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Class name Payment Function payment_btn_Click \nError: {ex.Message}");
                return -1;
            }
        }


        private void payment_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(card_number_tb.Text) || card_number_tb.Text.Length != 19)
            {
                MessageBox.Show("Invalid Card Number");
                card_number_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(card_holder_name_tb.Text))
            {
                MessageBox.Show("Enter card holder name");
                card_holder_name_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(expiry_date_tb.Text) || expiry_date_tb.Text.Length != 5)
            {
                MessageBox.Show("Invalid Expiry Date");
                expiry_date_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cvv_tb.Text) || cvv_tb.Text.Length != 4)
            {
                MessageBox.Show("Invalid CVV Code");
                cvv_tb.Focus();
                return;
            }

            int flag = PaymentExecuteNonQuery();

            if (flag == 0)
            {
                MessageBox.Show("Ops! Something is wrong");
                return;
            }

            if (flag == 1)
            {
                MessageBox.Show("Payment successful");
                this.Hide();
                CustomerDashboard customerDashboard = new CustomerDashboard(this.customerID);
                customerDashboard.Show();

            }

        }
    }
}
