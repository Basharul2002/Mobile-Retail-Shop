﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;
using System.Xml.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Mobile_Retail_Shop
{
    public partial class ShopInformation : UserControl
    {
        public ShopInformation()
        {
            InitializeComponent();
            DataLoad();
        }

        public void DataLoad()
        {
            string error;
            string query = @"SELECT
                                SI.ID AS [Shop ID],
                                SI.Name AS [Shop Name],
                                SI.[Phone Number] AS [Shop Phone Number], 
                                SI.Email AS [Shop Email],
                                UI.ID AS [Owner ID],
                                UI.Name AS [Owner Name],
                                UI.Email AS [Owner Email],
                                UI.[Phone Number] AS [Owner Phone Number], 
                                COUNT(PI.[Company Name]) AS [Total Product]
                            FROM
                                [Shop Information] SI
                            INNER JOIN
                                [User Information] UI
                                ON SI.[User ID] = UI.ID
                            FULL OUTER JOIN
                                [Product Information] PI
                                ON SI.ID = PI.[Shop ID]
                            GROUP BY
                                SI.ID, 
                                SI.Name, 
                                SI.[Phone Number], 
                                SI.Email, 
                                UI.ID, 
                                UI.Name, 
                                UI.Email, 
                                UI.[Phone Number]";

            DataBase dataBase = new DataBase();
            DataTable dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class name ShopInformation Function DataLoad \nError: {error}");
                return;
            }

            foreach (DataRow row in dataTable.Rows)
            {
                // (ShopInformation shopInformation, string shopID, string shopName, string shopOwnerName, string totalProduct
                ShopAdmin shopAdmin = new ShopAdmin(shopInformation: this, shopID: row["Shop ID"].ToString(), shopName: row["Shop Name"].ToString(), shopOwnerName: row["Owner Name"].ToString(), totalProduct: row["Total Product"].ToString());
                result_panel.Controls.Add(shopAdmin);
            }


        }


    }
}
