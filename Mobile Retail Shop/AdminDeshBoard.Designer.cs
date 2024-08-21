namespace Mobile_Retail_Shop
{
    partial class AdminDeshBoard
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
            this.left_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.logout_btn = new Guna.UI2.WinForms.Guna2Button();
            this.customer_btn = new Guna.UI2.WinForms.Guna2Button();
            this.shop_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.all_shop_btn = new Guna.UI2.WinForms.Guna2Button();
            this.new_shop_btn = new Guna.UI2.WinForms.Guna2Button();
            this.shop_btn = new Guna.UI2.WinForms.Guna2Button();
            this.show_owner_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.all_owner_info_btn = new Guna.UI2.WinForms.Guna2Button();
            this.new_owner_btn = new Guna.UI2.WinForms.Guna2Button();
            this.shop_owner_info_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.admin_information_btn = new Guna.UI2.WinForms.Guna2Button();
            this.new_admin_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.admin_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.admin_picture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.data_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.admin_dashboard_btn = new Guna.UI2.WinForms.Guna2Button();
            this.left_panel.SuspendLayout();
            this.shop_panel.SuspendLayout();
            this.show_owner_panel.SuspendLayout();
            this.admin_panel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.Controls.Add(this.logout_btn);
            this.left_panel.Controls.Add(this.customer_btn);
            this.left_panel.Controls.Add(this.shop_panel);
            this.left_panel.Controls.Add(this.shop_btn);
            this.left_panel.Controls.Add(this.show_owner_panel);
            this.left_panel.Controls.Add(this.shop_owner_info_btn);
            this.left_panel.Controls.Add(this.admin_panel);
            this.left_panel.Controls.Add(this.admin_btn);
            this.left_panel.Controls.Add(this.admin_dashboard_btn);
            this.left_panel.Controls.Add(this.guna2Panel1);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(155, 511);
            this.left_panel.TabIndex = 0;
            // 
            // logout_btn
            // 
            this.logout_btn.CustomBorderColor = System.Drawing.Color.Black;
            this.logout_btn.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.logout_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logout_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logout_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logout_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(0, 481);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(155, 30);
            this.logout_btn.TabIndex = 7;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // customer_btn
            // 
            this.customer_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customer_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customer_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customer_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customer_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.customer_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customer_btn.ForeColor = System.Drawing.Color.White;
            this.customer_btn.Location = new System.Drawing.Point(0, 442);
            this.customer_btn.Name = "customer_btn";
            this.customer_btn.Size = new System.Drawing.Size(155, 31);
            this.customer_btn.TabIndex = 6;
            this.customer_btn.Text = "Customer";
            this.customer_btn.Click += new System.EventHandler(this.customer_btn_Click);
            // 
            // shop_panel
            // 
            this.shop_panel.Controls.Add(this.all_shop_btn);
            this.shop_panel.Controls.Add(this.new_shop_btn);
            this.shop_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shop_panel.Location = new System.Drawing.Point(0, 374);
            this.shop_panel.Name = "shop_panel";
            this.shop_panel.Size = new System.Drawing.Size(155, 68);
            this.shop_panel.TabIndex = 5;
            this.shop_panel.Visible = false;
            // 
            // all_shop_btn
            // 
            this.all_shop_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.all_shop_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.all_shop_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.all_shop_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.all_shop_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.all_shop_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.all_shop_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.all_shop_btn.ForeColor = System.Drawing.Color.White;
            this.all_shop_btn.Location = new System.Drawing.Point(0, 33);
            this.all_shop_btn.Name = "all_shop_btn";
            this.all_shop_btn.Size = new System.Drawing.Size(155, 33);
            this.all_shop_btn.TabIndex = 2;
            this.all_shop_btn.Text = "Shops";
            this.all_shop_btn.Click += new System.EventHandler(this.all_shop_btn_Click);
            // 
            // new_shop_btn
            // 
            this.new_shop_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.new_shop_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.new_shop_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.new_shop_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.new_shop_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.new_shop_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.new_shop_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.new_shop_btn.ForeColor = System.Drawing.Color.White;
            this.new_shop_btn.Location = new System.Drawing.Point(0, 0);
            this.new_shop_btn.Name = "new_shop_btn";
            this.new_shop_btn.Size = new System.Drawing.Size(155, 33);
            this.new_shop_btn.TabIndex = 1;
            this.new_shop_btn.Text = "New Shop";
            this.new_shop_btn.Click += new System.EventHandler(this.new_shop_btn_Click);
            // 
            // shop_btn
            // 
            this.shop_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.shop_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.shop_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.shop_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.shop_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.shop_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.shop_btn.ForeColor = System.Drawing.Color.White;
            this.shop_btn.Location = new System.Drawing.Point(0, 343);
            this.shop_btn.Name = "shop_btn";
            this.shop_btn.Size = new System.Drawing.Size(155, 31);
            this.shop_btn.TabIndex = 4;
            this.shop_btn.Text = "Shop";
            this.shop_btn.Click += new System.EventHandler(this.shop_btn_Click);
            // 
            // show_owner_panel
            // 
            this.show_owner_panel.Controls.Add(this.all_owner_info_btn);
            this.show_owner_panel.Controls.Add(this.new_owner_btn);
            this.show_owner_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.show_owner_panel.Location = new System.Drawing.Point(0, 276);
            this.show_owner_panel.Name = "show_owner_panel";
            this.show_owner_panel.Size = new System.Drawing.Size(155, 67);
            this.show_owner_panel.TabIndex = 3;
            this.show_owner_panel.Visible = false;
            // 
            // all_owner_info_btn
            // 
            this.all_owner_info_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.all_owner_info_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.all_owner_info_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.all_owner_info_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.all_owner_info_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.all_owner_info_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.all_owner_info_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.all_owner_info_btn.ForeColor = System.Drawing.Color.White;
            this.all_owner_info_btn.Location = new System.Drawing.Point(0, 33);
            this.all_owner_info_btn.Name = "all_owner_info_btn";
            this.all_owner_info_btn.Size = new System.Drawing.Size(155, 33);
            this.all_owner_info_btn.TabIndex = 1;
            this.all_owner_info_btn.Text = "All Owner";
            this.all_owner_info_btn.Click += new System.EventHandler(this.all_owner_info_btn_Click);
            // 
            // new_owner_btn
            // 
            this.new_owner_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.new_owner_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.new_owner_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.new_owner_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.new_owner_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.new_owner_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.new_owner_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.new_owner_btn.ForeColor = System.Drawing.Color.White;
            this.new_owner_btn.Location = new System.Drawing.Point(0, 0);
            this.new_owner_btn.Name = "new_owner_btn";
            this.new_owner_btn.Size = new System.Drawing.Size(155, 33);
            this.new_owner_btn.TabIndex = 0;
            this.new_owner_btn.Text = "New Owner";
            this.new_owner_btn.Click += new System.EventHandler(this.new_owner_btn_Click);
            // 
            // shop_owner_info_btn
            // 
            this.shop_owner_info_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.shop_owner_info_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.shop_owner_info_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.shop_owner_info_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.shop_owner_info_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.shop_owner_info_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.shop_owner_info_btn.ForeColor = System.Drawing.Color.White;
            this.shop_owner_info_btn.Location = new System.Drawing.Point(0, 245);
            this.shop_owner_info_btn.Name = "shop_owner_info_btn";
            this.shop_owner_info_btn.Size = new System.Drawing.Size(155, 31);
            this.shop_owner_info_btn.TabIndex = 2;
            this.shop_owner_info_btn.Text = "Shop Owner";
            this.shop_owner_info_btn.Click += new System.EventHandler(this.shop_owner_info_btn_Click);
            // 
            // admin_panel
            // 
            this.admin_panel.Controls.Add(this.admin_information_btn);
            this.admin_panel.Controls.Add(this.new_admin_btn);
            this.admin_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.admin_panel.Location = new System.Drawing.Point(0, 184);
            this.admin_panel.Name = "admin_panel";
            this.admin_panel.Size = new System.Drawing.Size(155, 61);
            this.admin_panel.TabIndex = 1;
            this.admin_panel.Visible = false;
            // 
            // admin_information_btn
            // 
            this.admin_information_btn.CustomBorderColor = System.Drawing.Color.Black;
            this.admin_information_btn.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.admin_information_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_information_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_information_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_information_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_information_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.admin_information_btn.FillColor = System.Drawing.Color.SkyBlue;
            this.admin_information_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.admin_information_btn.ForeColor = System.Drawing.Color.White;
            this.admin_information_btn.Location = new System.Drawing.Point(0, 30);
            this.admin_information_btn.Name = "admin_information_btn";
            this.admin_information_btn.Size = new System.Drawing.Size(155, 30);
            this.admin_information_btn.TabIndex = 1;
            this.admin_information_btn.Text = "All Admin";
            this.admin_information_btn.Click += new System.EventHandler(this.admin_information_btn_Click);
            // 
            // new_admin_btn
            // 
            this.new_admin_btn.CustomBorderColor = System.Drawing.Color.Black;
            this.new_admin_btn.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.new_admin_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.new_admin_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.new_admin_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.new_admin_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.new_admin_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.new_admin_btn.FillColor = System.Drawing.Color.SkyBlue;
            this.new_admin_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.new_admin_btn.ForeColor = System.Drawing.Color.White;
            this.new_admin_btn.Location = new System.Drawing.Point(0, 0);
            this.new_admin_btn.Name = "new_admin_btn";
            this.new_admin_btn.Size = new System.Drawing.Size(155, 30);
            this.new_admin_btn.TabIndex = 0;
            this.new_admin_btn.Text = "New Admin";
            this.new_admin_btn.Click += new System.EventHandler(this.new_admin_btn_Click);
            // 
            // admin_btn
            // 
            this.admin_btn.CustomBorderColor = System.Drawing.Color.Black;
            this.admin_btn.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.admin_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.admin_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.admin_btn.ForeColor = System.Drawing.Color.White;
            this.admin_btn.Location = new System.Drawing.Point(0, 154);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(155, 30);
            this.admin_btn.TabIndex = 0;
            this.admin_btn.Text = "Admin";
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.admin_name);
            this.guna2Panel1.Controls.Add(this.admin_picture);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(155, 124);
            this.guna2Panel1.TabIndex = 8;
            // 
            // admin_name
            // 
            this.admin_name.BackColor = System.Drawing.Color.Transparent;
            this.admin_name.Location = new System.Drawing.Point(31, 95);
            this.admin_name.Name = "admin_name";
            this.admin_name.Size = new System.Drawing.Size(0, 0);
            this.admin_name.TabIndex = 1;
            this.admin_name.Text = null;
            this.admin_name.Click += new System.EventHandler(this.admin_profile_Click);
            // 
            // admin_picture
            // 
            this.admin_picture.ImageRotate = 0F;
            this.admin_picture.Location = new System.Drawing.Point(31, 7);
            this.admin_picture.Name = "admin_picture";
            this.admin_picture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.admin_picture.Size = new System.Drawing.Size(86, 82);
            this.admin_picture.TabIndex = 0;
            this.admin_picture.TabStop = false;
            this.admin_picture.Click += new System.EventHandler(this.admin_profile_Click);
            // 
            // data_panel
            // 
            this.data_panel.AutoScroll = true;
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(155, 0);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(421, 511);
            this.data_panel.TabIndex = 1;
            // 
            // admin_dashboard_btn
            // 
            this.admin_dashboard_btn.CustomBorderColor = System.Drawing.Color.Black;
            this.admin_dashboard_btn.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.admin_dashboard_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_dashboard_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_dashboard_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_dashboard_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_dashboard_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.admin_dashboard_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.admin_dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.admin_dashboard_btn.Location = new System.Drawing.Point(0, 124);
            this.admin_dashboard_btn.Name = "admin_dashboard_btn";
            this.admin_dashboard_btn.Size = new System.Drawing.Size(155, 30);
            this.admin_dashboard_btn.TabIndex = 9;
            this.admin_dashboard_btn.Text = "DashBoard";
            this.admin_dashboard_btn.Click += new System.EventHandler(this.admin_dashboard_btn_Click);
            // 
            // AdminDeshBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 511);
            this.Controls.Add(this.data_panel);
            this.Controls.Add(this.left_panel);
            this.Name = "AdminDeshBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDeshBoard";
            this.Load += new System.EventHandler(this.AdminDeshBoard_Load);
            this.left_panel.ResumeLayout(false);
            this.shop_panel.ResumeLayout(false);
            this.show_owner_panel.ResumeLayout(false);
            this.admin_panel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel left_panel;
        private Guna.UI2.WinForms.Guna2Button admin_btn;
        private Guna.UI2.WinForms.Guna2Panel admin_panel;
        private Guna.UI2.WinForms.Guna2Button admin_information_btn;
        private Guna.UI2.WinForms.Guna2Button new_admin_btn;
        private Guna.UI2.WinForms.Guna2Panel show_owner_panel;
        private Guna.UI2.WinForms.Guna2Button new_owner_btn;
        private Guna.UI2.WinForms.Guna2Button shop_owner_info_btn;
        private Guna.UI2.WinForms.Guna2Panel shop_panel;
        private Guna.UI2.WinForms.Guna2Button all_shop_btn;
        private Guna.UI2.WinForms.Guna2Button new_shop_btn;
        private Guna.UI2.WinForms.Guna2Button shop_btn;
        private Guna.UI2.WinForms.Guna2Button all_owner_info_btn;
        private Guna.UI2.WinForms.Guna2Panel data_panel;
        private Guna.UI2.WinForms.Guna2Button customer_btn;
        private Guna.UI2.WinForms.Guna2Button logout_btn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel admin_name;
        private Guna.UI2.WinForms.Guna2CirclePictureBox admin_picture;
        private Guna.UI2.WinForms.Guna2Button admin_dashboard_btn;
    }
}