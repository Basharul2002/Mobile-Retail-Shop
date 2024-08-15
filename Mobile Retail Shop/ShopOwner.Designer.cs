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
            this.log_out_btn = new Guna.UI2.WinForms.Guna2Button();
            this.left_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.data_panel.SuspendLayout();
            this.left_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // shop_panel
            // 
            this.shop_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shop_panel.Location = new System.Drawing.Point(0, 0);
            this.shop_panel.Margin = new System.Windows.Forms.Padding(0);
            this.shop_panel.Name = "shop_panel";
            this.shop_panel.Size = new System.Drawing.Size(178, 399);
            this.shop_panel.TabIndex = 0;
            // 
            // data_panel
            // 
            this.data_panel.Controls.Add(this.left_panel);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(0, 0);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(800, 450);
            this.data_panel.TabIndex = 1;
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
            // left_panel
            // 
            this.left_panel.Controls.Add(this.log_out_btn);
            this.left_panel.Controls.Add(this.shop_panel);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(178, 450);
            this.left_panel.TabIndex = 0;
            // 
            // ShopOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data_panel);
            this.Name = "ShopOwner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopOwner";
            this.Load += new System.EventHandler(this.ShopOwner_Load);
            this.data_panel.ResumeLayout(false);
            this.left_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel shop_panel;
        private Guna.UI2.WinForms.Guna2Panel data_panel;
        private Guna.UI2.WinForms.Guna2Button log_out_btn;
        private Guna.UI2.WinForms.Guna2Panel left_panel;
    }
}