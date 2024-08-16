namespace Mobile_Retail_Shop
{
    partial class CartList
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
            this.name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.quantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.price = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.total_price = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Location = new System.Drawing.Point(18, 21);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(34, 15);
            this.name.TabIndex = 0;
            this.name.Text = "Name: ";
            // 
            // quantity
            // 
            this.quantity.BackColor = System.Drawing.Color.Transparent;
            this.quantity.Location = new System.Drawing.Point(18, 42);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(42, 15);
            this.quantity.TabIndex = 0;
            this.quantity.Text = "Quantity";
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Location = new System.Drawing.Point(123, 42);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(30, 15);
            this.price.TabIndex = 0;
            this.price.Text = "Price: ";
            // 
            // total_price
            // 
            this.total_price.BackColor = System.Drawing.Color.Transparent;
            this.total_price.Location = new System.Drawing.Point(236, 42);
            this.total_price.Name = "total_price";
            this.total_price.Size = new System.Drawing.Size(57, 15);
            this.total_price.TabIndex = 0;
            this.total_price.Text = "Total Price: ";
            // 
            // CartList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.total_price);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.name);
            this.Name = "CartList";
            this.Size = new System.Drawing.Size(423, 69);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel name;
        private Guna.UI2.WinForms.Guna2HtmlLabel quantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel price;
        private Guna.UI2.WinForms.Guna2HtmlLabel total_price;
    }
}
