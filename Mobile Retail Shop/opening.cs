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
    public partial class opening : Form
    {
        private int elapsedTime = 0; // Time elapsed in seconds
        private Timer progressBarTimer;
        private Timer delayTimer;

        public opening()
        {
            InitializeComponent();

            // Initialize the progress bar timer
            progressBarTimer = new Timer();
            progressBarTimer.Interval = 100; // Update interval in milliseconds (20 updates per second)
            progressBarTimer.Tick += ProgressBarTimer_Tick;

            // Initialize the delay timer
            delayTimer = new Timer();
            delayTimer.Interval = 2000; // 2 seconds in milliseconds
            delayTimer.Tick += DelayTimer_Tick;

            // Start the progress bar timer
            progressBarTimer.Start();
        }

        private void ProgressBarTimer_Tick(object sender, EventArgs e)
        {
            // Update progress bar value
            guna2CircleProgressBar1.Value += 2; // Adjust increment as needed

            // Check if progress bar has reached its maximum value
            if (guna2CircleProgressBar1.Value >= 100)
            {
                guna2CircleProgressBar1.Value = 100; // Ensure it is set to maximum
                progressBarTimer.Stop(); // Stop progress bar timer
                delayTimer.Start(); // Start delay timer
            }
        }

        private void DelayTimer_Tick(object sender, EventArgs e)
        {
            // Stop the delay timer
            delayTimer.Stop();

            // Transition to the login form
            Login loginForm = new Login();
            this.Hide();
            loginForm.Show();
        }

        private void Opening_Load(object sender, EventArgs e)
        {
            // Set initial properties of the progress bar
            guna2CircleProgressBar1.Maximum = 100;
            guna2CircleProgressBar1.Value = 0;

            // You can also start the timer here if needed
        }
    }
}
