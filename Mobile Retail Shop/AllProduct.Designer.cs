namespace Mobile_Retail_Shop
{
    partial class AllProduct
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
            this.search_btn = new Guna.UI2.WinForms.Guna2Button();
            this.search_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.product_result_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.search_btn);
            this.guna2Panel1.Controls.Add(this.search_tb);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(426, 77);
            this.guna2Panel1.TabIndex = 0;
            // 
            // search_btn
            // 
            this.search_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.search_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.search_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.search_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.search_btn.FillColor = System.Drawing.Color.Transparent;
            this.search_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Image = global::Mobile_Retail_Shop.Properties.Resources.search1;
            this.search_btn.Location = new System.Drawing.Point(315, 23);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(33, 36);
            this.search_btn.TabIndex = 1;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_tb
            // 
            this.search_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_tb.DefaultText = "";
            this.search_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_tb.Location = new System.Drawing.Point(67, 23);
            this.search_tb.Name = "search_tb";
            this.search_tb.PasswordChar = '\0';
            this.search_tb.PlaceholderText = "Search you product here";
            this.search_tb.SelectedText = "";
            this.search_tb.Size = new System.Drawing.Size(241, 36);
            this.search_tb.TabIndex = 0;
            // 
            // product_result_panel
            // 
            this.product_result_panel.AutoScroll = true;
            this.product_result_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_result_panel.Location = new System.Drawing.Point(0, 77);
            this.product_result_panel.Name = "product_result_panel";
            this.product_result_panel.Size = new System.Drawing.Size(426, 376);
            this.product_result_panel.TabIndex = 1;
            // 
            // AllProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.product_result_panel);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "AllProduct";
            this.Size = new System.Drawing.Size(426, 453);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button search_btn;
        private Guna.UI2.WinForms.Guna2TextBox search_tb;
        private System.Windows.Forms.FlowLayoutPanel product_result_panel;
    }
}
