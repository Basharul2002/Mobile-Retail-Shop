namespace Mobile_Retail_Shop
{
    partial class Product
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
            this.rating = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.discount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.back_btn = new Guna.UI2.WinForms.Guna2Button();
            this.add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.remove_btn = new Guna.UI2.WinForms.Guna2Button();
            this.add_cart_btn = new Guna.UI2.WinForms.Guna2Button();
            this.price = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.color = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ram = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sim = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.model = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.compnay_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.product_picture = new System.Windows.Forms.PictureBox();
            this.quantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.product_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // rating
            // 
            this.rating.BackColor = System.Drawing.Color.Transparent;
            this.rating.Location = new System.Drawing.Point(172, 194);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(78, 15);
            this.rating.TabIndex = 26;
            this.rating.Text = "Company Name";
            // 
            // discount
            // 
            this.discount.BackColor = System.Drawing.Color.Transparent;
            this.discount.Location = new System.Drawing.Point(172, 173);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(78, 15);
            this.discount.TabIndex = 27;
            this.discount.Text = "Company Name";
            // 
            // back_btn
            // 
            this.back_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(18, 255);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(80, 45);
            this.back_btn.TabIndex = 35;
            this.back_btn.Text = "Back";
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_btn.FillColor = System.Drawing.Color.Transparent;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.add_btn.ForeColor = System.Drawing.Color.Black;
            this.add_btn.Location = new System.Drawing.Point(259, 255);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(40, 45);
            this.add_btn.TabIndex = 36;
            this.add_btn.Text = "+";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.remove_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.remove_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.remove_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.remove_btn.FillColor = System.Drawing.Color.Transparent;
            this.remove_btn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.remove_btn.ForeColor = System.Drawing.Color.Black;
            this.remove_btn.Location = new System.Drawing.Point(141, 255);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(40, 45);
            this.remove_btn.TabIndex = 37;
            this.remove_btn.Text = "-";
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // add_cart_btn
            // 
            this.add_cart_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_cart_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_cart_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_cart_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_cart_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add_cart_btn.ForeColor = System.Drawing.Color.White;
            this.add_cart_btn.Location = new System.Drawing.Point(181, 255);
            this.add_cart_btn.Name = "add_cart_btn";
            this.add_cart_btn.Size = new System.Drawing.Size(78, 45);
            this.add_cart_btn.TabIndex = 38;
            this.add_cart_btn.Text = "Add to Cart";
            this.add_cart_btn.Click += new System.EventHandler(this.add_cart_btn_Click);
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Location = new System.Drawing.Point(172, 152);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(78, 15);
            this.price.TabIndex = 28;
            this.price.Text = "Company Name";
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.Color.Transparent;
            this.color.Location = new System.Drawing.Point(172, 131);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(78, 15);
            this.color.TabIndex = 29;
            this.color.Text = "Company Name";
            // 
            // rom
            // 
            this.rom.BackColor = System.Drawing.Color.Transparent;
            this.rom.Location = new System.Drawing.Point(172, 110);
            this.rom.Name = "rom";
            this.rom.Size = new System.Drawing.Size(78, 15);
            this.rom.TabIndex = 30;
            this.rom.Text = "Company Name";
            // 
            // ram
            // 
            this.ram.BackColor = System.Drawing.Color.Transparent;
            this.ram.Location = new System.Drawing.Point(172, 89);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(78, 15);
            this.ram.TabIndex = 31;
            this.ram.Text = "Company Name";
            // 
            // sim
            // 
            this.sim.BackColor = System.Drawing.Color.Transparent;
            this.sim.Location = new System.Drawing.Point(172, 68);
            this.sim.Name = "sim";
            this.sim.Size = new System.Drawing.Size(78, 15);
            this.sim.TabIndex = 32;
            this.sim.Text = "Company Name";
            // 
            // model
            // 
            this.model.BackColor = System.Drawing.Color.Transparent;
            this.model.Location = new System.Drawing.Point(172, 47);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(78, 15);
            this.model.TabIndex = 33;
            this.model.Text = "Company Name";
            // 
            // compnay_name
            // 
            this.compnay_name.BackColor = System.Drawing.Color.Transparent;
            this.compnay_name.Location = new System.Drawing.Point(172, 26);
            this.compnay_name.Name = "compnay_name";
            this.compnay_name.Size = new System.Drawing.Size(78, 15);
            this.compnay_name.TabIndex = 34;
            this.compnay_name.Text = "Company Name";
            // 
            // product_picture
            // 
            this.product_picture.Location = new System.Drawing.Point(17, 23);
            this.product_picture.Name = "product_picture";
            this.product_picture.Size = new System.Drawing.Size(149, 189);
            this.product_picture.TabIndex = 25;
            this.product_picture.TabStop = false;
            // 
            // quantity
            // 
            this.quantity.BackColor = System.Drawing.Color.Transparent;
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(210, 306);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(13, 22);
            this.quantity.TabIndex = 26;
            this.quantity.Text = "0";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.add_cart_btn);
            this.Controls.Add(this.price);
            this.Controls.Add(this.color);
            this.Controls.Add(this.rom);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.sim);
            this.Controls.Add(this.model);
            this.Controls.Add(this.compnay_name);
            this.Controls.Add(this.product_picture);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(333, 358);
            ((System.ComponentModel.ISupportInitialize)(this.product_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel rating;
        private Guna.UI2.WinForms.Guna2HtmlLabel discount;
        private Guna.UI2.WinForms.Guna2Button back_btn;
        private Guna.UI2.WinForms.Guna2Button add_btn;
        private Guna.UI2.WinForms.Guna2Button remove_btn;
        private Guna.UI2.WinForms.Guna2Button add_cart_btn;
        private Guna.UI2.WinForms.Guna2HtmlLabel price;
        private Guna.UI2.WinForms.Guna2HtmlLabel color;
        private Guna.UI2.WinForms.Guna2HtmlLabel rom;
        private Guna.UI2.WinForms.Guna2HtmlLabel ram;
        private Guna.UI2.WinForms.Guna2HtmlLabel sim;
        private Guna.UI2.WinForms.Guna2HtmlLabel model;
        private Guna.UI2.WinForms.Guna2HtmlLabel compnay_name;
        private System.Windows.Forms.PictureBox product_picture;
        private Guna.UI2.WinForms.Guna2HtmlLabel quantity;
    }
}
