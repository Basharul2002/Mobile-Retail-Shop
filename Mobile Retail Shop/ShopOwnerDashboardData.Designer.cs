namespace Mobile_Retail_Shop
{
    partial class ShopOwnerDashboardData
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.shop_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.shop_owner_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.total_product = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.top_seling_product_last_month = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.top_seling_product_three_month = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.top_seling_product_six_month = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.top_seling_product_one_year = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shop_name
            // 
            this.shop_name.BackColor = System.Drawing.Color.Transparent;
            this.shop_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shop_name.Location = new System.Drawing.Point(19, 20);
            this.shop_name.Name = "shop_name";
            this.shop_name.Size = new System.Drawing.Size(75, 18);
            this.shop_name.TabIndex = 0;
            this.shop_name.Text = "Shop Name";
            // 
            // shop_owner_name
            // 
            this.shop_owner_name.BackColor = System.Drawing.Color.Transparent;
            this.shop_owner_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shop_owner_name.Location = new System.Drawing.Point(19, 44);
            this.shop_owner_name.Name = "shop_owner_name";
            this.shop_owner_name.Size = new System.Drawing.Size(79, 18);
            this.shop_owner_name.TabIndex = 0;
            this.shop_owner_name.Text = "Shop Owner:";
            // 
            // total_product
            // 
            this.total_product.BackColor = System.Drawing.Color.Transparent;
            this.total_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_product.Location = new System.Drawing.Point(19, 68);
            this.total_product.Name = "total_product";
            this.total_product.Size = new System.Drawing.Size(86, 18);
            this.total_product.TabIndex = 0;
            this.total_product.Text = "Total Product:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 188);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(619, 173);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // top_seling_product_last_month
            // 
            this.top_seling_product_last_month.BackColor = System.Drawing.Color.Transparent;
            this.top_seling_product_last_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_seling_product_last_month.Location = new System.Drawing.Point(19, 92);
            this.top_seling_product_last_month.Name = "top_seling_product_last_month";
            this.top_seling_product_last_month.Size = new System.Drawing.Size(196, 18);
            this.top_seling_product_last_month.TabIndex = 0;
            this.top_seling_product_last_month.Text = "Top Selling Product(Last Month):";
            // 
            // top_seling_product_three_month
            // 
            this.top_seling_product_three_month.BackColor = System.Drawing.Color.Transparent;
            this.top_seling_product_three_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_seling_product_three_month.Location = new System.Drawing.Point(19, 116);
            this.top_seling_product_three_month.Name = "top_seling_product_three_month";
            this.top_seling_product_three_month.Size = new System.Drawing.Size(206, 18);
            this.top_seling_product_three_month.TabIndex = 0;
            this.top_seling_product_three_month.Text = "Top Selling Product(Last 6 Month):";
            // 
            // top_seling_product_six_month
            // 
            this.top_seling_product_six_month.BackColor = System.Drawing.Color.Transparent;
            this.top_seling_product_six_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_seling_product_six_month.Location = new System.Drawing.Point(19, 140);
            this.top_seling_product_six_month.Name = "top_seling_product_six_month";
            this.top_seling_product_six_month.Size = new System.Drawing.Size(199, 18);
            this.top_seling_product_six_month.TabIndex = 0;
            this.top_seling_product_six_month.Text = "Top Selling Product(Last 1 Year):";
            // 
            // top_seling_product_one_year
            // 
            this.top_seling_product_one_year.BackColor = System.Drawing.Color.Transparent;
            this.top_seling_product_one_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_seling_product_one_year.Location = new System.Drawing.Point(19, 164);
            this.top_seling_product_one_year.Name = "top_seling_product_one_year";
            this.top_seling_product_one_year.Size = new System.Drawing.Size(199, 18);
            this.top_seling_product_one_year.TabIndex = 0;
            this.top_seling_product_one_year.Text = "Top Selling Product(Last 2 Year):";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.chart1);
            this.guna2ShadowPanel1.Controls.Add(this.top_seling_product_one_year);
            this.guna2ShadowPanel1.Controls.Add(this.top_seling_product_six_month);
            this.guna2ShadowPanel1.Controls.Add(this.top_seling_product_three_month);
            this.guna2ShadowPanel1.Controls.Add(this.top_seling_product_last_month);
            this.guna2ShadowPanel1.Controls.Add(this.total_product);
            this.guna2ShadowPanel1.Controls.Add(this.shop_owner_name);
            this.guna2ShadowPanel1.Controls.Add(this.shop_name);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(622, 364);
            this.guna2ShadowPanel1.TabIndex = 2;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // ShopOwnerDashboardData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "ShopOwnerDashboardData";
            this.Size = new System.Drawing.Size(622, 364);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel shop_name;
        private Guna.UI2.WinForms.Guna2HtmlLabel shop_owner_name;
        private Guna.UI2.WinForms.Guna2HtmlLabel total_product;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2HtmlLabel top_seling_product_last_month;
        private Guna.UI2.WinForms.Guna2HtmlLabel top_seling_product_three_month;
        private Guna.UI2.WinForms.Guna2HtmlLabel top_seling_product_six_month;
        private Guna.UI2.WinForms.Guna2HtmlLabel top_seling_product_one_year;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
    }
}
