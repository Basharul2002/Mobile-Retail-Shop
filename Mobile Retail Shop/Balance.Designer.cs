namespace Mobile_Retail_Shop
{
    partial class Balance
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.total_earn = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.current_balance = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.total_product_sell = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.withdraw_btn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(59, 34);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(174, 40);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Shop Cash";
            // 
            // total_earn
            // 
            this.total_earn.BackColor = System.Drawing.Color.Transparent;
            this.total_earn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_earn.Location = new System.Drawing.Point(24, 127);
            this.total_earn.Name = "total_earn";
            this.total_earn.Size = new System.Drawing.Size(68, 18);
            this.total_earn.TabIndex = 1;
            this.total_earn.Text = "Total Earn:";
            this.total_earn.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // current_balance
            // 
            this.current_balance.BackColor = System.Drawing.Color.Transparent;
            this.current_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_balance.Location = new System.Drawing.Point(24, 164);
            this.current_balance.Name = "current_balance";
            this.current_balance.Size = new System.Drawing.Size(101, 18);
            this.current_balance.TabIndex = 2;
            this.current_balance.Text = "Current Balance:";
            this.current_balance.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // total_product_sell
            // 
            this.total_product_sell.BackColor = System.Drawing.Color.Transparent;
            this.total_product_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_product_sell.Location = new System.Drawing.Point(24, 204);
            this.total_product_sell.Name = "total_product_sell";
            this.total_product_sell.Size = new System.Drawing.Size(112, 18);
            this.total_product_sell.TabIndex = 2;
            this.total_product_sell.Text = "Total Product Sell:";
            this.total_product_sell.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // withdraw_btn
            // 
            this.withdraw_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.withdraw_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.withdraw_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.withdraw_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.withdraw_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.withdraw_btn.ForeColor = System.Drawing.Color.White;
            this.withdraw_btn.Location = new System.Drawing.Point(59, 285);
            this.withdraw_btn.Name = "withdraw_btn";
            this.withdraw_btn.Size = new System.Drawing.Size(180, 45);
            this.withdraw_btn.TabIndex = 3;
            this.withdraw_btn.Text = "Withdraw";
            this.withdraw_btn.Click += new System.EventHandler(this.withdraw_btn_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.withdraw_btn);
            this.Controls.Add(this.total_product_sell);
            this.Controls.Add(this.current_balance);
            this.Controls.Add(this.total_earn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "Balance";
            this.Size = new System.Drawing.Size(304, 366);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel total_earn;
        private Guna.UI2.WinForms.Guna2HtmlLabel current_balance;
        private Guna.UI2.WinForms.Guna2HtmlLabel total_product_sell;
        private Guna.UI2.WinForms.Guna2Button withdraw_btn;
    }
}
