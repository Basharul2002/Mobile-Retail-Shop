namespace Mobile_Retail_Shop
{
    partial class Shop
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.all_product_btn = new Guna.UI2.WinForms.Guna2Button();
            this.new_product_btn = new Guna.UI2.WinForms.Guna2Button();
            this.balance_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.balance_btn);
            this.guna2Panel1.Controls.Add(this.all_product_btn);
            this.guna2Panel1.Controls.Add(this.new_product_btn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(543, 92);
            this.guna2Panel1.TabIndex = 0;
            // 
            // all_product_btn
            // 
            this.all_product_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.all_product_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.all_product_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.all_product_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.all_product_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.all_product_btn.ForeColor = System.Drawing.Color.White;
            this.all_product_btn.Location = new System.Drawing.Point(222, 27);
            this.all_product_btn.Name = "all_product_btn";
            this.all_product_btn.Size = new System.Drawing.Size(99, 45);
            this.all_product_btn.TabIndex = 0;
            this.all_product_btn.Text = "All Product";
            this.all_product_btn.Click += new System.EventHandler(this.all_product_btn_Click);
            // 
            // new_product_btn
            // 
            this.new_product_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.new_product_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.new_product_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.new_product_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.new_product_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.new_product_btn.ForeColor = System.Drawing.Color.White;
            this.new_product_btn.Location = new System.Drawing.Point(80, 27);
            this.new_product_btn.Name = "new_product_btn";
            this.new_product_btn.Size = new System.Drawing.Size(99, 45);
            this.new_product_btn.TabIndex = 0;
            this.new_product_btn.Text = "New Product";
            this.new_product_btn.Click += new System.EventHandler(this.new_product_btn_Click);
            // 
            // balance_btn
            // 
            this.balance_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.balance_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.balance_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.balance_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.balance_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.balance_btn.ForeColor = System.Drawing.Color.White;
            this.balance_btn.Location = new System.Drawing.Point(355, 27);
            this.balance_btn.Name = "balance_btn";
            this.balance_btn.Size = new System.Drawing.Size(99, 45);
            this.balance_btn.TabIndex = 0;
            this.balance_btn.Text = "Balance";
            this.balance_btn.Click += new System.EventHandler(this.balance_btn_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Shop";
            this.Size = new System.Drawing.Size(543, 492);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button all_product_btn;
        private Guna.UI2.WinForms.Guna2Button new_product_btn;
        private Guna.UI2.WinForms.Guna2Button balance_btn;
    }
}
