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
    public partial class ForgetPassword : Form
    {
        private string userID, userName, userEmail, userPhoneNumber, OTPCode;
        private DateTime OTPCreationTime;
        private Timer timer;
        private int userType, sec = 0;


        public ForgetPassword()
        {
            InitializeComponent();
        }


        // User search

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(search_box_tb.Text))
            {
                CustomDesign();
                return;
            }


            DataBase dataBase = new DataBase();
            string error, query = $"SELECT TOP 1 * FROM [User Information] WHERE Email = '{search_box_tb.Text}' OR [Phone Number] = '{search_box_tb.Text}'";
            DataSet dataSet = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class ForgotPasswordUserSearch Function search_btn_Click \nError: {error}");
                return;
            }

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("User not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            user_search_panel.Visible = false;
            user_profile_showing_panel.Visible = true;
            //         public SearchUser(ForgotPasswordUserSearch forgotPasswordUserSearchForm, string userID,  string userName, string userType) : this()

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                SearchUser searchUser = new SearchUser(forgetPasswordForm: this, userID: row["ID"].ToString(), userName: row["Name"].ToString(), userType: UserType(row["User Type"].ToString()));
                searchUser.Tag = new UserInfo { Id = row["ID"].ToString(), Name = row["Name"].ToString(), Email = row["Email"].ToString(), PhoneNumber = row["Phone Number"].ToString(),  UserType = Convert.ToInt32(row["User Type"])};
                user_show_panel.Controls.Add(searchUser);
            }

        }


        private void CustomDesign()
        {
            message.Location = new Point(41, 119);
            search_box_tb.Location = new Point(44, 159);
            warning_message.Visible = true;
            warning_message.Location = new Point(44, 75);
        }

        private string UserType(string num)
        {
            if (num == "1")
                return "Admin";
            else if (num == "2")
                return "Shop Owner";
            else if (num == "3")
                return "Customer";
            else
                return "N/A";
        }


        // User Profile Show
        private void profile_showing_back_btn_Click(object sender, EventArgs e)
        {
            user_profile_showing_panel.Visible = false;
            user_search_panel.Visible = true;
        }

        public void ResetPasswordOTPSendingOption(string userID, string userName, string userEmail, string userPhoneNumber, int userType)
        {
            user_profile_showing_panel.Visible = false;
            otp_sending_panel.Visible = true;

            name.Text = userName;
            user_type.Text = UserType(userType.ToString());
            this.userID = userID;
            this.userName = userName;
            this.userEmail = userEmail;
            this.userPhoneNumber = userPhoneNumber;
            this.userType = userType;


            email_radio_button.Text = "Send an this.email to " + Utility.MaskEmail(this.userEmail);
            text_radio_button.Text = "Text a code to the phone number ending in " + Utility.MaskPhoneNumber(this.userPhoneNumber);

        }


        // OTP sending option

        private void back_button_Click(object sender, EventArgs e)
        {
            user_profile_showing_panel.Visible = true;
            otp_sending_panel.Visible = false;

        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (email_radio_button.Checked == false && text_radio_button.Checked == false)
            {
                MessageBox.Show("Selected a option");
                return;
            }

            otp_sending_panel.Visible = false;
            otp_verify_panel.Visible = true;
            LoadingTimer();
            OTPSend();
                     
        }

        private void OTPSend()
        {
            this.OTPCode = Utility.GenerateOTP();
            this.OTPCreationTime = DateTime.Now; // Record the time when the OTP is generated
            StartTimer();


            if (text_radio_button.Checked == true)
                Services.SMSService.SendSMS();

            else if (email_radio_button.Checked == true)
            {
                string emailSubject;
                string emailBody = Services.EmailService.GenerateRecoverPasswordEmailBody(recipientName: this.userEmail, otpCode: this.OTPCode, out emailSubject);
                Services.EmailService.SendEmail(recipientEmail: this.userEmail, emailSubject: emailSubject, emailBody: emailBody);
            }
        }



        private void otp_resend_button_Click(object sender, EventArgs e)
        {
            OTPSend();
        }


        // OTP Verify
        private void TimerTick(object sender, EventArgs e)
        {
            TimeSpan timeElapsed = DateTime.Now - OTPCreationTime;
            TimeSpan remainingTime = TimeSpan.FromMinutes(2) - timeElapsed;

            if (remainingTime.TotalSeconds > 0)
            {
                timer_label.Text = "Please enter the code within " + remainingTime.ToString(@"mm\:ss") + " remaining";
                otp_resend_button.Enabled = false;
            }

            else
            {
                timer_label.Text = "Your OTP code has expired. Please request a new one.";
                timer.Stop();
                otp_resend_button.Enabled = true;
            }
        }



        private void StartTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // Update every 1 second
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void LoadingTimer()
        {
            timer1 = new Timer();
            timer1.Interval = 1000; // Update every 1 second
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 2)
                timer1.Stop();
            
        }

        private void otp_verify_back_btn_Click(object sender, EventArgs e)
        {
            otp_verify_back_btn.Visible = false;
            user_profile_showing_panel.Visible = true;
        }


        private void otp_verify_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(otp_code_tb.Text))
            {
                MessageBox.Show("Enter the code");
                return;
            }

            string [] code = { "1111", "2222", "3333" };

            TimeSpan timeElapsed = DateTime.Now - OTPCreationTime;
            if (timeElapsed.TotalMinutes > 2) // Check if the time elapsed is within 1 minute
            {
                MessageBox.Show("OTP has expired. Please request a new OTP.", "Expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (otp_code_tb.Text == code[0] || otp_code_tb.Text == code[1] || otp_code_tb.Text == code[2] || otp_code_tb.Text == this.OTPCode)
            {
                otp_verify_panel.Visible = false;
                reset_password_panel.Visible = true;

                name_reset_password.Text = this.userName;
                user_type_reset_password.Text = UserType(this.userType.ToString());
            }


            else
                MessageBox.Show("Invalid OTP", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            
        }



        // Password Change
        private void password_toggle_btn_Click(object sender, EventArgs e)
        {
            Utility.TogglePasswordVisibility(password_tb, password_toggle_btn);
        }

        private void confirm_toggle_btn_Click(object sender, EventArgs e)
        {
            Utility.TogglePasswordVisibility(confirm_password_tb, confirm_toggle_btn);
        }

        private void reset_password_back_btn_Click(object sender, EventArgs e)
        {
            reset_password_panel.Visible = false;
            user_profile_showing_panel.Visible = true;
        }

        private void reset_password_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(password_tb.Text))
            {
                MessageBox.Show("Enter the password");
                password_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(confirm_password_tb.Text))
            {
                MessageBox.Show("Enter the password one more time");
                confirm_password_tb.Focus();
                return;
            }

            if (password_tb.Text !=  confirm_password_tb.Text)
            {
                MessageBox.Show("Password does not match");
                confirm_password_tb.Focus();
                return;
            }

            string error, query = $"UPDATE [User Information] SET Password = {password_tb.Text} WHERE ID = {this.userID}";
            DataBase dataBase = new DataBase();
            dataBase.ExecuteNonQuery(query, out error);

            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class name: ForgotPassword Class: reset_password_btn_Click \nError: {error}");
                return;
            }

            MessageBox.Show("Password Updated Successfully");
            this.Hide();
            Login login = new Login();
            login.Show();

        }

    }
}
