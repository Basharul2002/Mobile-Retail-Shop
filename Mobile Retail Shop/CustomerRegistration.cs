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
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {
        }
        private bool ValidateEmail()
        {
            // Get the text from the email text box
            string email = email_tb.Text;

            // Check if the email ends with "@gmail.com"
            bool isValid = email.EndsWith("@gmail.com");

            // Ensure "@gmail.com" appears only once
            if (isValid && email.IndexOf("@gmail.com") == email.LastIndexOf("@gmail.com"))
                return true; // Email is valid
            
            else
                MessageBox.Show("Please enter a valid email address that ends with '@gmail.com' and appears only once.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Email is not valid
            
        }

        private void email_tb_Leave(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            // Check if all fields are empty
            if (string.IsNullOrWhiteSpace(name_tb.Text) &&
                string.IsNullOrWhiteSpace(email_tb.Text) &&
                string.IsNullOrWhiteSpace(phone_number_tb.Text) &&
                string.IsNullOrWhiteSpace(city_tb.Text) &&
                string.IsNullOrWhiteSpace(password_tb.Text) &&
                string.IsNullOrWhiteSpace(confirm_password_tb.Text))
            {
                MessageBox.Show("All field values must be entered!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(name_tb.Text))
            {
                MessageBox.Show("Fill up the name");
                name_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email_tb.Text))
            {
                MessageBox.Show("Fill up the email");
                email_tb.Focus();
                return;
            }

            // Validate the email before proceeding
            if (!ValidateEmail())
            {
                email_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone_number_tb.Text))
            {
                MessageBox.Show("Fill up the phone Number");
                phone_number_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(city_tb.Text))
            {
                MessageBox.Show("Fill the city");
                city_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password_tb.Text))
            {
                MessageBox.Show("Fill the password");
                password_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(confirm_password_tb.Text))
            {
                MessageBox.Show("Fill the confirm password");
                confirm_password_tb.Focus();
                return;
            }

            if (password_tb.Text != confirm_password_tb.Text)
            {
                MessageBox.Show("Password does not match");
                confirm_password_tb.Focus();
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


            // Check the email exists
            DataBase dataBase = new DataBase();
            string query, error;

            // Check if the email is already registered
            query = $@"
                    SELECT TOP 1 * FROM [User Information] WHERE [Email] = '{email_tb.Text}'";
            DataSet dataSet = dataBase.DataAccess(query, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class Name: RegistrationForm Function: DataStore 1 \nError: {error}", "Email");
                return;
            }

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("This EMAIL is already registered");
                email_tb.Focus();
                return;
            }

            // Check if the phone number is already registered
            query = $"SELECT TOP 1 * FROM [User Information] WHERE [Phone Number] = '{phone_number_tb.Text}' AND [User Type] = {3}";
            dataSet = dataBase.DataAccess(query, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class Name: RegistrationForm Function: DataStore 2 \nError: {error}", "Phone Number");
                return;
            }

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("This PHONE NUMBER is already registered");
                phone_number_tb.Focus();
                return;
            }

            // Register the information as a new account
            query = $@"INSERT INTO [User Information] (Name, Email, [Phone Number], City, Password, [User Type])
              VALUES('{name_tb.Text}', '{email_tb.Text}', '{phone_number_tb.Text}', '{city_tb.Text}', '{password_tb.Text}', {3})";

            dataBase.ExecuteNonQuery(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class Name: RegistrationForm Function: DataStore 3 \nError: {error}", "Execution");
                return;
            }

            this.Hide();
            Login login = new Login();
            login.Show();
        }


        private void password_toggle_btn_Click(object sender, EventArgs e)
        {
            Utility.TogglePasswordVisibility(password_tb, password_toggle_btn);
        }

        private void confirm_toggle_btn_Click(object sender, EventArgs e)
        {
            Utility.TogglePasswordVisibility(confirm_password_tb, confirm_toggle_btn);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void phone_number_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or a control key (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true; // Suppress the key press

        }

        private void email_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
