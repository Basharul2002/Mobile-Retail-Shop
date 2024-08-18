using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Retail_Shop
{
    public class UserInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
        public int UserType {  get; set; }
    }


    internal class Utility
    {
        public static void TogglePasswordVisibility(Guna2TextBox textBox, Guna2Button button)
        {
            if (textBox.PasswordChar != '●')
            {
                textBox.PasswordChar = '●';
                // textBox.UseSystemPasswordChar = false;
                button.Image = Properties.Resources.hide;
                return;
            }

            textBox.PasswordChar = '\0';
            // textBox.UseSystemPasswordChar = true;
            button.Image = Properties.Resources.show;
        }

        public bool IsNumeric(string input)
        {
            // Define a regular expression pattern to match numeric digits
            string pattern = "^[0-9]+$";

            // Use Regex.IsMatch to check if the input matches the pattern
            return Regex.IsMatch(input, pattern);
        }

        public static int ConvertStringToInt(string num, out string error)
        {
            try
            {
                error = string.Empty;
                return Int32.Parse(num);
            }
            catch (FormatException)
            {
                error = null;
                return 0;
            }
        }

        public static ImageFormat GetImageFormat(System.Drawing.Image image)
        {
            if (image == null)
                return null;

            if (image.RawFormat.Equals(ImageFormat.Jpeg))
                return ImageFormat.Jpeg;

            else if (image.RawFormat.Equals(ImageFormat.Png))
                return ImageFormat.Png;

            else if (image.RawFormat.Equals(ImageFormat.Gif))
                return ImageFormat.Gif;

            else if (image.RawFormat.Equals(ImageFormat.Bmp))
                return ImageFormat.Bmp;

            else if (image.RawFormat.Equals(ImageFormat.Icon))
                return ImageFormat.Icon;

            // Handle other formats or return a default if not recognized
            return null;
        }

        public static System.Drawing.Image ByteArrayToImage(byte[] byteArray)
        {
            try
            {
                if (byteArray == null || byteArray.Length == 0)
                {
                    MessageBox.Show("The byte array is null or empty.");
                    return null; // Return null if the byte array is invalid
                }

                using (MemoryStream ms = new MemoryStream())
                {
                    return Image.FromStream(ms);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Class Utility Function ByteArrayToImage \n Error: {ex.Message}");
                return null;
            }
           
           
        }

        // For normal to Database formatted image
        public static byte[] ImageToByteArray(System.Drawing.Image image, ImageFormat imageFormat)
        {
            if (image == null)
                return null; // Return null if the image is null

            // Use a try-catch block to handle any potential GDI+ exceptions
            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    // Save the image with the specified format
                    image.Save(stream, imageFormat != null ? imageFormat : ImageFormat.Jpeg);
                    return stream.ToArray(); // Return the byte array
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions related to GDI+ here
                MessageBox.Show("Class: Utility Function: ImageToByteArray \nError: " + ex.Message);
                return null; // Return null if an error occurs
            }
        }



        public static void pictureUpload(Guna2PictureBox pictureBox)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;

                    // Perform the necessary actions with the selected file here
                    // For example, you can display the file path in a TextBox:
                    // Load the image from the selected file
                    Image originalImage = Image.FromFile(selectedFile);

                    // Resize the image to fit the PictureBox size
                    Image resizedImage = new Bitmap(originalImage, new Size(130, 130));

                    // Display the resized image in the PictureBox
                    pictureBox.Image = resizedImage;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Picture Error");
            }
        }


        public static string MaskEmail(string email)
        {
            string[] parts = email.Split('@');
            string username = parts[0];
            string domain = parts[1];

            string maskedUsername;
            // Mask the username
            int usernameLength = username.Length;
            if (usernameLength > 3)
                maskedUsername = username.Substring(0, 2) + new string('x', usernameLength - 2);

            else if (usernameLength == 3)
                maskedUsername = username.Substring(0, 1) + new string('x', usernameLength - 1);

            else
                maskedUsername = username;

            // Mask the domain
            string[] domainPart = domain.Split('.');
            string domainFirstPart = domainPart[0];
            string domainSecondPart = domainPart[1];

            return maskedUsername + "@" + domain.Substring(0, 1) + new string('x', domainFirstPart.Length - 1) + "." + new string('x', domainSecondPart.Length);
        }

        public static string MaskPhoneNumber(string phoneNumber)
        {
            return new string('*', phoneNumber.Length - 2) + phoneNumber.Substring(phoneNumber.Length - 2);
        }


        public static string GenerateOTP()
        {
            // Define the characters from which the OTP will be generated
            const string chars = "0123456789";

            // Create an instance of Random class
            Random random = new Random();

            // Generate a 6-digit OTP using random characters
            return new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());

        }

        public class Validity
        {
            public static bool IsPhoneNumberValid(string phn_num)
            {
                if (phn_num.Length == 11)
                {
                    // Use Regex pattern matching to validate phone number format
                    string phnNumPattern = @"^\d{11}$";

                    // Validate phone number and email format
                    // If phone number is valied then return true otherwise false
                    return Regex.IsMatch(phn_num, phnNumPattern);
                }

                return false;
            }

            public static bool IsEmailValid(string email)
            {
                // Use Regex pattern matching to validate email format
                string emailFormatPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                // Validate email format
                // If email is valied then return true otherwise false
                return Regex.IsMatch(email, emailFormatPattern);
            }
        }

    }
}
