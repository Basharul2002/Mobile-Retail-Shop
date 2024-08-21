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
    public partial class UserProfile : Form
    {
        private string userID, name, email, phoneNumber, city, password;

        public UserProfile()
        {
            InitializeComponent();
        }

        public UserProfile(string userID) : this()
        {
            this.userID = userID;   
            DataLoad();
        }

        private void DataLoad()
        {
            string error, query;
            query = $"SELECT * FROM [User Information] WHERE ID = {this.userID}";

            DataBase dataBase = new DataBase();
            DataSet dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class UserProfile Function DataLoad \nError: {error}");
                return;
            }

            this.name = name_tb.Text = dataSet.Tables[0].Rows[0]["Name"].ToString();
            this.email = email_tb.Text = dataSet.Tables[0].Rows[0]["Email"].ToString();
            this.phoneNumber = phone_number_tb.Text = dataSet.Tables[0].Rows[0]["Phone Number"].ToString();
            this.city = city_tb.Text = dataSet.Tables[0].Rows[0]["City"].ToString();
            this.password = dataSet.Tables[0].Rows[0]["Password"].ToString();
        }

        private void name_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_tb.Text) || this.name == name_tb.Text)
            {
                update_btn.Enabled = false;
                return;
            }

            update_btn.Enabled = true;
        }


        private void email_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_tb.Text) || this.email == email_tb.Text)
            {
                update_btn.Enabled = false;
                return;
            }

            update_btn.Enabled = true;
        }

        private void phone_number_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phone_number_tb.Text) || this.phoneNumber == phone_number_tb.Text)
            {
                update_btn.Enabled = false;
                return;
            }

            update_btn.Enabled = true;
        }


        private void city_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(city_tb.Text) || this.city == city_tb.Text)
            {
                update_btn.Enabled = false;
                return;
            }

            update_btn.Enabled = true;
        }


        private void phone_number_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or a control key (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true; // Suppress the key press
            
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
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

            string query, error;

            query = "UPDATE [User Information] SET ";
            if (this.name != name_tb.Text)
            {
                query += $"Name = '{name_tb.Text}', ";
                this.name = name_tb.Text;
            }
                
            if (this.email != this.email_tb.Text)
            {
                query += $"Email = '{email_tb.Text}', ";
                this.email = email_tb.Text;
            }
                
            if (this.phoneNumber != phone_number_tb.Text)
            {
                query += $"[Phone Number] = '{phone_number_tb.Text}', ";
                this.phoneNumber = phone_number_tb.Text;
            }
                
            if (this.city != city_tb.Text)
            {
                query += $"City = '{city_tb.Text}', ";
                this.city = city_tb.Text;
            }

            query = $"{query.Substring(0, query.Length - 2)} WHERE ID = {this.userID}";
            DataBase dataBase = new DataBase();
            dataBase.ExecuteNonQuery(query, out error);


            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: UserProfile Function: update_btn_Click \nError: {error}");
                return;
            }

            MessageBox.Show($"Your profile successfully updated");
            update_btn.Enabled = false;
        }


        /*private void change_pasword_btn_Click(object sender, EventArgs e)
        {
            profile_panel.Visible = false;
            password_update_panel.Visible = true;
        }*/

        private void UserProfile_Load(object sender, EventArgs e)
        {
            update_btn.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            profile_panel.Visible = false;
            password_update_panel.Visible = true;
        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {


        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {


        }

        private void current_password_toggle_btn_Click(object sender, EventArgs e)
        {
            Utility.TogglePasswordVisibility(current_password_tb, current_password_toggle_btn);
        }

        private void password_toggle_btn_Click(object sender, EventArgs e)
        {
            Utility.TogglePasswordVisibility(password_tb, password_toggle_btn);
        }

        private void confirm_toggle_btn_Click(object sender, EventArgs e)
        {
            Utility.TogglePasswordVisibility(confirm_password_tb, confirm_toggle_btn);
        }

        private void reset_password_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(current_password_tb.Text))
            {
                MessageBox.Show("Enter the current password");
                current_password_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password_tb.Text))
            {
                MessageBox.Show("Enter the password");
                password_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace (confirm_password_tb.Text))
            {
                MessageBox.Show("Enter the password one more time");
                confirm_password_tb.Focus();
                return;
            }

            if (current_password_tb.Text != this.password)
            {
                MessageBox.Show("Incorrect password");
                current_password_tb.Focus();
                return;
            }

            if (password_tb.Text != confirm_password_tb.Text)
            {
                MessageBox.Show("Password does not match");
                confirm_password_tb.Focus();
                return;
            }

            string query, error;

            query = $"UPDATE [User Information] SET Password = {password_tb.Text} WHERE ID = {this.userID}";
            DataBase dataBase = new DataBase();
            dataBase.ExecuteNonQuery(query, out error);

            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class: UserProfile Function: reset_password_btn_Click \nError: {error}");
                return;
            }

            MessageBox.Show($"{this.name} your password successfully updated");

            password_update_panel.Visible = false;
            profile_panel.Visible = true;
        }

        private void reset_password_back_btn_Click(object sender, EventArgs e)
        {
            password_update_panel.Visible = false;
            profile_panel.Visible = true;
        }
       
    }
}
