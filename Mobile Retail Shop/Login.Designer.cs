﻿namespace Mobile_Retail_Shop
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_btn = new Guna.UI2.WinForms.Guna2Button();
            this.password_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.email_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.BorderRadius = 10;
            this.login_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(375, 330);
            this.login_btn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(320, 68);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "LOGIN";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // password_tb
            // 
            this.password_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_tb.DefaultText = "";
            this.password_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_tb.Location = new System.Drawing.Point(356, 239);
            this.password_tb.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '\0';
            this.password_tb.PlaceholderText = "Password";
            this.password_tb.SelectedText = "";
            this.password_tb.Size = new System.Drawing.Size(356, 54);
            this.password_tb.TabIndex = 4;
            // 
            // email_tb
            // 
            this.email_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_tb.DefaultText = "";
            this.email_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.email_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_tb.Location = new System.Drawing.Point(356, 156);
            this.email_tb.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.email_tb.Name = "email_tb";
            this.email_tb.PasswordChar = '\0';
            this.email_tb.PlaceholderText = "Email";
            this.email_tb.SelectedText = "";
            this.email_tb.Size = new System.Drawing.Size(356, 54);
            this.email_tb.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Location = new System.Drawing.Point(734, 96);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(265, 373);
            this.guna2Panel1.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.email_tb);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button login_btn;
        private Guna.UI2.WinForms.Guna2TextBox password_tb;
        private Guna.UI2.WinForms.Guna2TextBox email_tb;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}

