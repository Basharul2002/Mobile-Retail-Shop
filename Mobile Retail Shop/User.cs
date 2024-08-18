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
    public partial class User : UserControl
    {
        private Users users;
        public User()
        {
            InitializeComponent();
        }

        public User(string userId, string userName, string userEmail, string userPhoneNumber, string city, string password, int userType, Users users) : this()
        {
            this.Tag = new UserInfo { Id = userId, Name = userName, Email = userEmail, PhoneNumber = userPhoneNumber, City = city,  Password = password, UserType = userType };
            name.Text = userName;
            email.Text = userEmail; 
            phone_number.Text = userPhoneNumber;

            this.users = users;
            this.Click += new System.EventHandler(this.user_btn_Click);
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            UserInfo tag = (UserInfo)this.Tag;

            if (tag.UserType == 2)
            {
                AdminDeshBoard.Instance.panelContainer.Controls.Clear();
                ShopOwnerInfoDashBoard shopOwnerInfoDashBoard = new ShopOwnerInfoDashBoard(shopOwnerID: tag.Id, shopOwnerName: tag.Name, shopOwnerEmail: tag.Email, shopOwnerPhoneNumber: tag.PhoneNumber, shopOwnerCity: tag.City, shopOwnerPassword: tag.Password, this.users);
                shopOwnerInfoDashBoard.Dock = DockStyle.Fill;
                AdminDeshBoard.Instance.panelContainer.Controls.Add(shopOwnerInfoDashBoard);
                shopOwnerInfoDashBoard.BringToFront();
                return;
            }

            users.profile(userId: tag.Id, userName: tag.Name, userEmail: tag.Email, userPhoneNumber: tag.PhoneNumber, userCity: tag.City, userPassword: tag.Password, userType: tag.UserType);
            users.BringToFront();
        }
    }
}
