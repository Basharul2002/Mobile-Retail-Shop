namespace Mobile_Retail_Shop
{
    partial class SearchUser
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
            this.id = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.user_type = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Location = new System.Drawing.Point(12, 19);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(11, 15);
            this.id.TabIndex = 0;
            this.id.Text = "id";
            this.id.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Location = new System.Drawing.Point(12, 40);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(34, 15);
            this.name.TabIndex = 0;
            this.name.Text = "Name: ";
            this.name.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // user_type
            // 
            this.user_type.BackColor = System.Drawing.Color.Transparent;
            this.user_type.Location = new System.Drawing.Point(12, 61);
            this.user_type.Name = "user_type";
            this.user_type.Size = new System.Drawing.Size(55, 15);
            this.user_type.TabIndex = 0;
            this.user_type.Text = "User Type:";
            this.user_type.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // SearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.user_type);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Name = "SearchUser";
            this.Size = new System.Drawing.Size(431, 99);
            this.Click += new System.EventHandler(this.user_btn_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel id;
        private Guna.UI2.WinForms.Guna2HtmlLabel name;
        private Guna.UI2.WinForms.Guna2HtmlLabel user_type;
    }
}
