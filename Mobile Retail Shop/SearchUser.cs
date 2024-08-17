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
    public partial class SearchUser : UserControl
    {
        private ForgetPassword forgetPasswordForm;
        public SearchUser()
        {
            InitializeComponent();
        }

        public SearchUser(ForgetPassword forgetPasswordForm, string userID,  string userName, string userType) : this()
        {
            id.Text = userID;
            name.Text = userName;
            user_type.Text =  userType;
            this.forgetPasswordForm = forgetPasswordForm;
        }


        private void user_btn_Click(object sender, EventArgs e)
        {
            UserInfo tag = (UserInfo)this.Tag;
            forgetPasswordForm.ResetPasswordOTPSendingOption(userID: tag.Id, userName: tag.Name, userEmail: tag.Email, userPhoneNumber: tag.PhoneNumber, userType: tag.UserType);
        }
    }
}
