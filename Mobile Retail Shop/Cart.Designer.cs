namespace Mobile_Retail_Shop
{
    partial class Cart
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.total_price = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.payment_btn = new Guna.UI2.WinForms.Guna2Button();
            this.zero_iteam_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iteam_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.cart_list_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.zero_iteam_panel.SuspendLayout();
            this.iteam_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.total_price);
            this.guna2Panel1.Controls.Add(this.payment_btn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 328);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(407, 107);
            this.guna2Panel1.TabIndex = 0;
            // 
            // total_price
            // 
            this.total_price.BackColor = System.Drawing.Color.Transparent;
            this.total_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_price.Location = new System.Drawing.Point(115, 17);
            this.total_price.Name = "total_price";
            this.total_price.Size = new System.Drawing.Size(37, 18);
            this.total_price.TabIndex = 1;
            this.total_price.Text = "Total: ";
            // 
            // payment_btn
            // 
            this.payment_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.payment_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.payment_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.payment_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.payment_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.payment_btn.ForeColor = System.Drawing.Color.White;
            this.payment_btn.Location = new System.Drawing.Point(115, 50);
            this.payment_btn.Name = "payment_btn";
            this.payment_btn.Size = new System.Drawing.Size(180, 45);
            this.payment_btn.TabIndex = 0;
            this.payment_btn.Text = "Payment";
            this.payment_btn.Click += new System.EventHandler(this.payment_btn_Click);
            // 
            // zero_iteam_panel
            // 
            this.zero_iteam_panel.Controls.Add(this.label1);
            this.zero_iteam_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zero_iteam_panel.Location = new System.Drawing.Point(0, 0);
            this.zero_iteam_panel.Name = "zero_iteam_panel";
            this.zero_iteam_panel.Size = new System.Drawing.Size(407, 435);
            this.zero_iteam_panel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Iteam Selected";
            // 
            // iteam_panel
            // 
            this.iteam_panel.Controls.Add(this.cart_list_panel);
            this.iteam_panel.Controls.Add(this.guna2Panel1);
            this.iteam_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iteam_panel.Location = new System.Drawing.Point(0, 0);
            this.iteam_panel.Name = "iteam_panel";
            this.iteam_panel.Size = new System.Drawing.Size(407, 435);
            this.iteam_panel.TabIndex = 3;
            // 
            // cart_list_panel
            // 
            this.cart_list_panel.AutoScroll = true;
            this.cart_list_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cart_list_panel.Location = new System.Drawing.Point(0, 0);
            this.cart_list_panel.Name = "cart_list_panel";
            this.cart_list_panel.Size = new System.Drawing.Size(407, 328);
            this.cart_list_panel.TabIndex = 1;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 435);
            this.Controls.Add(this.iteam_panel);
            this.Controls.Add(this.zero_iteam_panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.zero_iteam_panel.ResumeLayout(false);
            this.zero_iteam_panel.PerformLayout();
            this.iteam_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button payment_btn;
        private Guna.UI2.WinForms.Guna2Panel zero_iteam_panel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel iteam_panel;
        private System.Windows.Forms.FlowLayoutPanel cart_list_panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel total_price;
    }
}