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
    public partial class Users : UserControl
    {
        private string userId, userName, userEmail, userPhoneNumber, userCity, userPassword;
        private int userType;


        public Users()
        {
            InitializeComponent();
        }

        public Users(int userType) : this()
        {
            this.userType = userType;
            user_info_panel.Visible = true;
            search_tb.PlaceholderText = "Name, Email, Phone Number";

            DataLoad();
        }

        private void DataLoad(bool search = false)
        {
            string error, query = $"SELECT * FROM [User Information] WHERE [User Type] = {this.userType}";

            if (search)
                query += $" AND (Name = '{search_tb.Text}' OR Email = '{search_tb.Text}' OR [Phone Number] = '{search_tb.Text}')";

            DataBase dataBase = new DataBase();
            DataSet dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class name: Users Function: DataLoad \nnError: {error}");
                return;
            }

            if (dataSet.Tables[0].Rows.Count == 0)
                return;

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                User user = new User(userId: row["ID"].ToString(), userName: row["Name"].ToString(), userEmail: row["Email"].ToString(), userPhoneNumber: row["Phone Number"].ToString(), city: row["City"].ToString(), password: row["Password"].ToString(), userType: userType, users: this) ;
                result_panel.Controls.Add(user);
            }
        }

        public void profile(string userId, string userName, string userEmail, string userPhoneNumber, string userCity, string userPassword, int userType)
        {
            user_info_panel.Visible = false;
            user_profile_panel.Visible = true;


            name_tb.Text = this.userName = userName;
            email_tb.Text = this.userEmail = userEmail;
            phone_number_tb.Text = this.userPhoneNumber = userPhoneNumber;
            city_tb.Text = this.userCity = userCity;
            password_tb.Text = this.userPassword = userPassword;
            this.userId = userId;
        }

        private void name_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_tb.Text) || name_tb.Text == this.userName)
            {
                update_btn.Enabled = false;
                return;
            }

            update_btn.Enabled = true;
        }

        private void email_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_tb.Text) || email_tb.Text == this.userEmail)
            {
                update_btn.Enabled = false;
                return;
            }

            update_btn.Enabled = true;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            DataLoad(search: true);
        }

        private void phone_number_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phone_number_tb.Text) || phone_number_tb.Text == this.userPhoneNumber)
            {
                update_btn.Enabled = false;
                return;
            }

            update_btn.Enabled = true;
        }


        private void city_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(city_tb.Text) || city_tb.Text == this.userCity)
            {
                update_btn.Enabled = false;
                return;
            }

            update_btn.Enabled = true;
        }



        private void password_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(password_tb.Text) || password_tb.Text == this.userPassword)
            {
                update_btn.Enabled = false;
                return;
            }

            update_btn.Enabled = true;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            user_profile_panel.Visible = false;
            user_info_panel.Visible = true;
        }


        private void update_btn_Click(object sender, EventArgs e)
        {
            string error, query = "UPDATE [User Information] SET ";

            if (!string.IsNullOrWhiteSpace(name_tb.Text) || name_tb.Text == this.userName)
                query += $"[Name] = {name_tb.Text}, ";

            if (!string.IsNullOrWhiteSpace(email_tb.Text) || email_tb.Text == this.userEmail)
                query += $"[Email] = {email_tb.Text}, ";

            if (!string.IsNullOrWhiteSpace(phone_number_tb.Text) || phone_number_tb.Text == this.userPassword)
                query += $"[Phone Number] = {userPhoneNumber}, ";

            if (!string.IsNullOrWhiteSpace(city_tb.Text) || city_tb.Text == this.userCity)
                query += $"[City] = {city_tb.Text}, ";

            if (!string.IsNullOrWhiteSpace(password_tb.Text) || password_tb.Text == this.userPassword)
                query += $"[Password] = {password_tb.Text}, ";

            query = query.Substring(0, query.Length - 2);


            DataBase dataBase = new DataBase();
            dataBase.ExecuteNonQuery(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: Users Function: update_btn_Click \nError: {error}");
                return;
            }
        }

    }
}
