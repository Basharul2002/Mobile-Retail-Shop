namespace Mobile_Retail_Shop
{
    partial class ShopOwner
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
            this.shop_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.data_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.left_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.log_out_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.admin_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.admin_picture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.dashboard_data_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.dashboard_btn = new Guna.UI2.WinForms.Guna2Button();
            this.left_panel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // shop_panel
            // 
            this.shop_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shop_panel.Location = new System.Drawing.Point(0, 169);
            this.shop_panel.Margin = new System.Windows.Forms.Padding(0);
            this.shop_panel.Name = "shop_panel";
            this.shop_panel.Size = new System.Drawing.Size(178, 399);
            this.shop_panel.TabIndex = 0;
            // 
            // data_panel
            // 
            this.data_panel.AutoScroll = true;
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(178, 0);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(622, 450);
            this.data_panel.TabIndex = 1;
            // 
            // left_panel
            // 
            this.left_panel.Controls.Add(this.log_out_btn);
            this.left_panel.Controls.Add(this.shop_panel);
            this.left_panel.Controls.Add(this.dashboard_btn);
            this.left_panel.Controls.Add(this.guna2Panel1);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(178, 450);
            this.left_panel.TabIndex = 0;
            // 
            // log_out_btn
            // 
            this.log_out_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.log_out_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.log_out_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.log_out_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.log_out_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.log_out_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.log_out_btn.ForeColor = System.Drawing.Color.White;
            this.log_out_btn.Location = new System.Drawing.Point(0, 405);
            this.log_out_btn.Margin = new System.Windows.Forms.Padding(0);
            this.log_out_btn.Name = "log_out_btn";
            this.log_out_btn.Size = new System.Drawing.Size(178, 45);
            this.log_out_btn.TabIndex = 0;
            this.log_out_btn.Text = "Log Out";
            this.log_out_btn.Click += new System.EventHandler(this.log_out_btn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.admin_name);
            this.guna2Panel1.Controls.Add(this.admin_picture);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(178, 124);
            this.guna2Panel1.TabIndex = 9;
            // 
            // admin_name
            // 
            this.admin_name.BackColor = System.Drawing.Color.Transparent;
            this.admin_name.Location = new System.Drawing.Point(31, 95);
            this.admin_name.Name = "admin_name";
            this.admin_name.Size = new System.Drawing.Size(31, 15);
            this.admin_name.TabIndex = 1;
            this.admin_name.Text = "Name";
            this.admin_name.Click += new System.EventHandler(this.shop_owner_profile_Click);
            // 
            // admin_picture
            // 
            this.admin_picture.ImageRotate = 0F;
            this.admin_picture.Location = new System.Drawing.Point(44, 3);
            this.admin_picture.Name = "admin_picture";
            this.admin_picture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.admin_picture.Size = new System.Drawing.Size(86, 82);
            this.admin_picture.TabIndex = 0;
            this.admin_picture.TabStop = false;
            this.admin_picture.Click += new System.EventHandler(this.shop_owner_profile_Click);
            // 
            // dashboard_data_panel
            // 
            this.dashboard_data_panel.AutoScroll = true;
            this.dashboard_data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard_data_panel.Location = new System.Drawing.Point(178, 0);
            this.dashboard_data_panel.Name = "dashboard_data_panel";
            this.dashboard_data_panel.Size = new System.Drawing.Size(622, 450);
            this.dashboard_data_panel.TabIndex = 0;
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboard_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboard_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboard_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboard_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboard_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Location = new System.Drawing.Point(0, 124);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(0);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(178, 45);
            this.dashboard_btn.TabIndex = 10;
            this.dashboard_btn.Text = "DashBoard";
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // ShopOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dashboard_data_panel);
            this.Controls.Add(this.data_panel);
            this.Controls.Add(this.left_panel);
            this.Name = "ShopOwner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopOwner";
            this.Load += new System.EventHandler(this.ShopOwner_Load);
            this.left_panel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel shop_panel;
        private Guna.UI2.WinForms.Guna2Panel data_panel;
        private Guna.UI2.WinForms.Guna2Button log_out_btn;
        private Guna.UI2.WinForms.Guna2Panel left_panel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel admin_name;
        private Guna.UI2.WinForms.Guna2CirclePictureBox admin_picture;
        private System.Windows.Forms.FlowLayoutPanel dashboard_data_panel;
        private Guna.UI2.WinForms.Guna2Button dashboard_btn;
    }
}