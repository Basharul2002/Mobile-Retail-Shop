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
    public partial class BalanceWithdraw : Form
    {
        private string shopID, password;
        private double currentBalance;
        public BalanceWithdraw()
        {
            InitializeComponent();
        }

        public BalanceWithdraw(string shopID, string password, double currentBalance) : this()
        {
            this.shopID = shopID;
            this.password = password;
            this.currentBalance = currentBalance;
        }



        private void password_toggle_btn_Click(object sender, EventArgs e)
        {
            Utility.TogglePasswordVisibility(password_tb, password_toggle_btn);
        }


        private void passwrod_verify_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(password_tb.Text))
            {
                MessageBox.Show("Enter the password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.password != password_tb.Text)
            {
                MessageBox.Show("Invalid password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            password_panel.Visible = false;
            online_banking_panel.Visible = true;
        }

        private void amount_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or a control key (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true; // Suppress the key press
        }

        private void bank_balance_transfer_btn_Click(object sender, EventArgs e)
        {
            if (bank_name_cb.SelectedIndex <= 0)
            {
                MessageBox.Show("Select a bank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(account_number_tb.Text))
            {
                MessageBox.Show("Enter your account number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(amount_tb.Text))
            {
                MessageBox.Show("Enter the amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double withdrawAmount = Convert.ToDouble(amount_tb.Text);

            if (withdrawAmount > this.currentBalance)
            {
                MessageBox.Show("Insufficient Balance", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string error;
            string query = $@"UPDATE 
                                [Shop Accounts]
                            SET 
                                [Current Balance] = [Current Balance] - {withdrawAmount},
                                [Total Withdraw] = [Total Withdraw] + {withdrawAmount}
                            WHERE 
                                [Shop ID] = {this.shopID}";

            DataBase dataBase = new DataBase();
            dataBase.ExecuteNonQuery(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class BalanceWithdraw Function bank_balance_transfer_btn_Click \nError: {error}");
                return;
            }

            MessageBox.Show("Balance transfer successful");
            DialogResult = DialogResult.OK;
        }



    }
}
