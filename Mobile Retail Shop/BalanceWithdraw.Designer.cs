namespace Mobile_Retail_Shop
{
    partial class BalanceWithdraw
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
            this.online_banking_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bank_name_cb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bank_balance_transfer_btn = new Guna.UI2.WinForms.Guna2Button();
            this.amount_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.account_number_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.password_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.passwrod_verify_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.password_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.password_toggle_btn = new Guna.UI2.WinForms.Guna2Button();
            this.online_banking_panel.SuspendLayout();
            this.password_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // online_banking_panel
            // 
            this.online_banking_panel.Controls.Add(this.guna2HtmlLabel3);
            this.online_banking_panel.Controls.Add(this.guna2HtmlLabel2);
            this.online_banking_panel.Controls.Add(this.guna2HtmlLabel1);
            this.online_banking_panel.Controls.Add(this.bank_name_cb);
            this.online_banking_panel.Controls.Add(this.bank_balance_transfer_btn);
            this.online_banking_panel.Controls.Add(this.amount_tb);
            this.online_banking_panel.Controls.Add(this.account_number_tb);
            this.online_banking_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.online_banking_panel.Location = new System.Drawing.Point(0, 0);
            this.online_banking_panel.Name = "online_banking_panel";
            this.online_banking_panel.Size = new System.Drawing.Size(338, 280);
            this.online_banking_panel.TabIndex = 1;
            this.online_banking_panel.Visible = false;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(25, 160);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(39, 15);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "Amount";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(26, 94);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(83, 15);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Account Number";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(26, 23);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(59, 15);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Bank Name";
            // 
            // bank_name_cb
            // 
            this.bank_name_cb.BackColor = System.Drawing.Color.Transparent;
            this.bank_name_cb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bank_name_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bank_name_cb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bank_name_cb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bank_name_cb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bank_name_cb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.bank_name_cb.ItemHeight = 30;
            this.bank_name_cb.Items.AddRange(new object[] {
            "Choose the bank",
            "NCC Bank",
            "BRAC Bank",
            "Sonali Bank"});
            this.bank_name_cb.Location = new System.Drawing.Point(26, 44);
            this.bank_name_cb.Name = "bank_name_cb";
            this.bank_name_cb.Size = new System.Drawing.Size(259, 36);
            this.bank_name_cb.StartIndex = 0;
            this.bank_name_cb.TabIndex = 1;
            // 
            // bank_balance_transfer_btn
            // 
            this.bank_balance_transfer_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bank_balance_transfer_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bank_balance_transfer_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bank_balance_transfer_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bank_balance_transfer_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bank_balance_transfer_btn.ForeColor = System.Drawing.Color.White;
            this.bank_balance_transfer_btn.Location = new System.Drawing.Point(101, 231);
            this.bank_balance_transfer_btn.Name = "bank_balance_transfer_btn";
            this.bank_balance_transfer_btn.Size = new System.Drawing.Size(124, 37);
            this.bank_balance_transfer_btn.TabIndex = 0;
            this.bank_balance_transfer_btn.Text = "Transfer To Bank";
            this.bank_balance_transfer_btn.Click += new System.EventHandler(this.bank_balance_transfer_btn_Click);
            // 
            // amount_tb
            // 
            this.amount_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amount_tb.DefaultText = "";
            this.amount_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.amount_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.amount_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amount_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amount_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amount_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.amount_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amount_tb.Location = new System.Drawing.Point(25, 176);
            this.amount_tb.Name = "amount_tb";
            this.amount_tb.PasswordChar = '\0';
            this.amount_tb.PlaceholderText = "Enter Amount";
            this.amount_tb.SelectedText = "";
            this.amount_tb.Size = new System.Drawing.Size(259, 36);
            this.amount_tb.TabIndex = 0;
            this.amount_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_tb_KeyPress);
            // 
            // account_number_tb
            // 
            this.account_number_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.account_number_tb.DefaultText = "";
            this.account_number_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.account_number_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.account_number_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.account_number_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.account_number_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.account_number_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.account_number_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.account_number_tb.Location = new System.Drawing.Point(26, 111);
            this.account_number_tb.Name = "account_number_tb";
            this.account_number_tb.PasswordChar = '\0';
            this.account_number_tb.PlaceholderText = "Enter A\\C Number";
            this.account_number_tb.SelectedText = "";
            this.account_number_tb.Size = new System.Drawing.Size(259, 36);
            this.account_number_tb.TabIndex = 0;
            this.account_number_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_tb_KeyPress);
            // 
            // password_panel
            // 
            this.password_panel.Controls.Add(this.password_tb);
            this.password_panel.Controls.Add(this.password_toggle_btn);
            this.password_panel.Controls.Add(this.passwrod_verify_btn);
            this.password_panel.Controls.Add(this.guna2HtmlLabel4);
            this.password_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password_panel.Location = new System.Drawing.Point(0, 0);
            this.password_panel.Name = "password_panel";
            this.password_panel.Size = new System.Drawing.Size(338, 280);
            this.password_panel.TabIndex = 2;
            // 
            // passwrod_verify_btn
            // 
            this.passwrod_verify_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.passwrod_verify_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.passwrod_verify_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.passwrod_verify_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.passwrod_verify_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwrod_verify_btn.ForeColor = System.Drawing.Color.White;
            this.passwrod_verify_btn.Location = new System.Drawing.Point(115, 110);
            this.passwrod_verify_btn.Name = "passwrod_verify_btn";
            this.passwrod_verify_btn.Size = new System.Drawing.Size(124, 37);
            this.passwrod_verify_btn.TabIndex = 3;
            this.passwrod_verify_btn.Text = "Verify";
            this.passwrod_verify_btn.Click += new System.EventHandler(this.passwrod_verify_btn_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(25, 38);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(99, 15);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "Enter your password";
            // 
            // password_tb
            // 
            this.password_tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_tb.DefaultText = "";
            this.password_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password_tb.ForeColor = System.Drawing.Color.Black;
            this.password_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_tb.Location = new System.Drawing.Point(26, 60);
            this.password_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '●';
            this.password_tb.PlaceholderText = "Type password..";
            this.password_tb.SelectedText = "";
            this.password_tb.Size = new System.Drawing.Size(259, 36);
            this.password_tb.TabIndex = 17;
            // 
            // password_toggle_btn
            // 
            this.password_toggle_btn.Animated = true;
            this.password_toggle_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.password_toggle_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.password_toggle_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.password_toggle_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.password_toggle_btn.FillColor = System.Drawing.Color.Transparent;
            this.password_toggle_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password_toggle_btn.ForeColor = System.Drawing.Color.White;
            this.password_toggle_btn.Image = global::Mobile_Retail_Shop.Properties.Resources.show;
            this.password_toggle_btn.Location = new System.Drawing.Point(286, 61);
            this.password_toggle_btn.Name = "password_toggle_btn";
            this.password_toggle_btn.Size = new System.Drawing.Size(40, 31);
            this.password_toggle_btn.TabIndex = 18;
            this.password_toggle_btn.Click += new System.EventHandler(this.password_toggle_btn_Click);
            // 
            // BalanceWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(338, 280);
            this.Controls.Add(this.password_panel);
            this.Controls.Add(this.online_banking_panel);
            this.Name = "BalanceWithdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BalanceWithdraw";
            this.online_banking_panel.ResumeLayout(false);
            this.online_banking_panel.PerformLayout();
            this.password_panel.ResumeLayout(false);
            this.password_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel online_banking_panel;
        private Guna.UI2.WinForms.Guna2Button bank_balance_transfer_btn;
        private Guna.UI2.WinForms.Guna2TextBox amount_tb;
        private Guna.UI2.WinForms.Guna2TextBox account_number_tb;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox bank_name_cb;
        private Guna.UI2.WinForms.Guna2Panel password_panel;
        private Guna.UI2.WinForms.Guna2Button passwrod_verify_btn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox password_tb;
        private Guna.UI2.WinForms.Guna2Button password_toggle_btn;
    }
}