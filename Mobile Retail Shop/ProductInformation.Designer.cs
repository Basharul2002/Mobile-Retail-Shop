namespace Mobile_Retail_Shop
{
    partial class ProductInformation
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
            this.product_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.product_price = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.product_buy_btn = new Guna.UI2.WinForms.Guna2Button();
            this.product_details_btn = new Guna.UI2.WinForms.Guna2Button();
            this.product_picture = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.product_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // product_name
            // 
            this.product_name.BackColor = System.Drawing.Color.Transparent;
            this.product_name.Location = new System.Drawing.Point(9, 191);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(29, 15);
            this.product_name.TabIndex = 1;
            this.product_name.Text = "name";
            // 
            // product_price
            // 
            this.product_price.BackColor = System.Drawing.Color.Transparent;
            this.product_price.Location = new System.Drawing.Point(9, 212);
            this.product_price.Name = "product_price";
            this.product_price.Size = new System.Drawing.Size(27, 15);
            this.product_price.TabIndex = 1;
            this.product_price.Text = "Price";
            // 
            // product_buy_btn
            // 
            this.product_buy_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.product_buy_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.product_buy_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.product_buy_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.product_buy_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.product_buy_btn.ForeColor = System.Drawing.Color.White;
            this.product_buy_btn.Location = new System.Drawing.Point(134, 258);
            this.product_buy_btn.Name = "product_buy_btn";
            this.product_buy_btn.Size = new System.Drawing.Size(75, 31);
            this.product_buy_btn.TabIndex = 2;
            this.product_buy_btn.Text = "Add Cart";
            this.product_buy_btn.Click += new System.EventHandler(this.product_buy_btn_Click);
            // 
            // product_details_btn
            // 
            this.product_details_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.product_details_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.product_details_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.product_details_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.product_details_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.product_details_btn.ForeColor = System.Drawing.Color.White;
            this.product_details_btn.Location = new System.Drawing.Point(9, 258);
            this.product_details_btn.Name = "product_details_btn";
            this.product_details_btn.Size = new System.Drawing.Size(86, 31);
            this.product_details_btn.TabIndex = 2;
            this.product_details_btn.Text = "Details";
            this.product_details_btn.Click += new System.EventHandler(this.product_details_btn_Click);
            // 
            // product_picture
            // 
            this.product_picture.ImageRotate = 0F;
            this.product_picture.Location = new System.Drawing.Point(53, 0);
            this.product_picture.Name = "product_picture";
            this.product_picture.Size = new System.Drawing.Size(134, 168);
            this.product_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.product_picture.TabIndex = 0;
            this.product_picture.TabStop = false;
            // 
            // ProductInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.product_details_btn);
            this.Controls.Add(this.product_buy_btn);
            this.Controls.Add(this.product_price);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.product_picture);
            this.Name = "ProductInformation";
            this.Size = new System.Drawing.Size(248, 313);
            ((System.ComponentModel.ISupportInitialize)(this.product_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox product_picture;
        private Guna.UI2.WinForms.Guna2HtmlLabel product_name;
        private Guna.UI2.WinForms.Guna2HtmlLabel product_price;
        private Guna.UI2.WinForms.Guna2Button product_buy_btn;
        private Guna.UI2.WinForms.Guna2Button product_details_btn;
    }
}
