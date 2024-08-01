﻿using System;
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
    public partial class NewUser : UserControl
    {
        private int userType;
        public NewUser()
        {
            InitializeComponent();
        }

        public NewUser(int userType) : this()
        {
            this.userType = userType;
        }


        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(label54210.Text))
            {
                MessageBox.Show("Fill up the name");
                label54210.Focus();
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
                MessageBox.Show("Fill up the phone Numvber");
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



            // Check the email exists
            DataBase dataBase = new DataBase();
            string query, error;
            DataTable dataTable;

            // Here check have any account input email
            query = $"SELECT TOP 1 * FROM [User Information] WHERE [Email] = '{email_tb.Text}' AND [User Type] = {userType}";
            dataTable = dataBase.DataAccess(query, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class Name: ResistrationForm Function: DataStore 1 \nError: {error}", "Email");
                return;
            }

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("This EMAIL is already resistered");
                email_tb.Focus();
                return;
            }


            // Check the phone number is register or not
            query = $"SELECT TOP 1 * FROM [User Information] WHERE [Phone Number] = '{phone_number_tb.Text}' AND [User Type] = {userType}";
            dataTable = dataBase.DataAccess(query, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class Name: ResistrationForm Function: DataStore 2 \nError: {error}", "Phone Number");
                return;
            }

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("This PHONE NUMBER is already resistered");
                phone_number_tb.Focus();
                return;
            }

            // Here register the information as a new account
            query = $@"INSERT INTO [User Information] (Name, Email, [Phone Number], City, Password, [User Type])
                              VALUES('{name_tb.Text}', '{email_tb.Text}', '{phone_number_tb.Text}', '{city_tb.Text}', '{password_tb.Text}', {this.userType})";

            dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class Name: ResistrationForm Function: DataStore 2 \nError: {error}", "Phone Number");
                return;
            }

            

        }

        private void password_toggle_btn_Click(object sender, EventArgs e)
        {
            Utility.TogglePasswordVisibility(password_tb, password_toggle_btn);
        }

        private void confirm_toggle_btn_Click(object sender, EventArgs e)
        {
            Utility.TogglePasswordVisibility(confirm_password_tb, confirm_toggle_btn);
        }
    }
}
