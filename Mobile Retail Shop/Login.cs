using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Mobile_Retail_Shop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void password_toggle_btn_Click(object sender, EventArgs e)
        {
            Utility.TogglePasswordVisibility(password_tb, password_toggle_btn);
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_tb.Text))
            {
                MessageBox.Show("fill the email");
                email_tb.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(password_tb.Text))
            {
                MessageBox.Show("fill the password");
                password_tb.Focus();
                return;
            }
            string query = $"SELECT TOP  1  * FROM [User Information] WHERE [Email] = '{email_tb.Text}' AND [Password] = '{password_tb.Text}'";

            DataBase dataBase = new DataBase();
            string error;
            DataSet dataSet = dataBase.DataAccess(query, out error);

            // If error is not empty that means something is wrong
            // So, user requst is not valid for next 
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: loginPage function: Login, error: {error}");
                return;
            }

            // If no data found in database based on email and password
            // So, user requst is not valid for next 
            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Invalid email or password");
                return;

            }

            // User Type 1 mean user is admin
            if (dataSet.Tables[0].Rows[0]["User Type"].ToString() == "1")
            {
                AdminDeshBoard adminDeshBoard = new AdminDeshBoard(id: dataSet.Tables[0].Rows[0]["ID"].ToString(), name: dataSet.Tables[0].Rows[0]["Name"].ToString());
                this.Hide();
                adminDeshBoard.Show();

            }

            // User Type 2 mean user is shop owner
            if (dataSet.Tables[0].Rows[0]["User Type"].ToString() == "2")
            {
                ShopOwner shopOwner = new ShopOwner(showOwnerID: dataSet.Tables[0].Rows[0]["ID"].ToString(), password: password_tb.Text);
                this.Hide();
                shopOwner.Show();
            }

            // User Type 3 mean user is customer
            if (dataSet.Tables[0].Rows[0]["User Type"].ToString() == "3")
            {
                CustomerDashboard customerDashboard = new CustomerDashboard(dataSet.Tables[0].Rows[0]["ID"].ToString());
                this.Hide();
                customerDashboard.Show();
            }
        }

        private void customer_sign_in_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRegistration customerRegistration = new CustomerRegistration();
            customerRegistration.Show();
        }

        private void forgot_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
