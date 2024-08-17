namespace Mobile_Retail_Shop
{
    partial class ShopAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shop_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.shop_owner_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.total_product = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.delete_btn = new Guna.UI2.WinForms.Guna2Button();
            this.details_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shop_name
            // 
            this.shop_name.BackColor = System.Drawing.Color.Transparent;
            this.shop_name.Location = new System.Drawing.Point(15, 192);
            this.shop_name.Name = "shop_name";
            this.shop_name.Size = new System.Drawing.Size(62, 15);
            this.shop_name.TabIndex = 1;
            this.shop_name.Text = "Shop Name:";
            this.shop_name.Click += new System.EventHandler(this.details_btn_Click);
            // 
            // shop_owner_name
            // 
            this.shop_owner_name.BackColor = System.Drawing.Color.Transparent;
            this.shop_owner_name.Location = new System.Drawing.Point(15, 213);
            this.shop_owner_name.Name = "shop_owner_name";
            this.shop_owner_name.Size = new System.Drawing.Size(65, 15);
            this.shop_owner_name.TabIndex = 1;
            this.shop_owner_name.Text = "Shop Owner:";
            this.shop_owner_name.Click += new System.EventHandler(this.details_btn_Click);
            // 
            // total_product
            // 
            this.total_product.BackColor = System.Drawing.Color.Transparent;
            this.total_product.Location = new System.Drawing.Point(15, 234);
            this.total_product.Name = "total_product";
            this.total_product.Size = new System.Drawing.Size(70, 15);
            this.total_product.TabIndex = 1;
            this.total_product.Text = "Total Product:";
            this.total_product.Click += new System.EventHandler(this.details_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(164, 261);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(98, 45);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "Delete";
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // details_btn
            // 
            this.details_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.details_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.details_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.details_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.details_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.details_btn.ForeColor = System.Drawing.Color.White;
            this.details_btn.Location = new System.Drawing.Point(15, 261);
            this.details_btn.Name = "details_btn";
            this.details_btn.Size = new System.Drawing.Size(98, 45);
            this.details_btn.TabIndex = 2;
            this.details_btn.Text = "Details";
            this.details_btn.Click += new System.EventHandler(this.details_btn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(69, 23);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(150, 135);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.details_btn_Click);
            // 
            // ShopAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.details_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.total_product);
            this.Controls.Add(this.shop_owner_name);
            this.Controls.Add(this.shop_name);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "ShopAdmin";
            this.Size = new System.Drawing.Size(298, 319);
            this.Click += new System.EventHandler(this.details_btn_Click);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel shop_name;
        private Guna.UI2.WinForms.Guna2HtmlLabel shop_owner_name;
        private Guna.UI2.WinForms.Guna2HtmlLabel total_product;
        private Guna.UI2.WinForms.Guna2Button delete_btn;
        private Guna.UI2.WinForms.Guna2Button details_btn;
    }
}
