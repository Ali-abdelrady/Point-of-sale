﻿using Grocery_Shop.Classes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Shop.Reports
{
    public partial class TopSelling_Report : Form
    {
        //Database Connection
        private SqlConnection con;
        string start_date,end_date;
        DatabaseManger databaseManger = new DatabaseManger();
        public TopSelling_Report(string start_date, string end_date)
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
            this.start_date = start_date;
            this.end_date = end_date;
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TopSelling_Report_Load(object sender, EventArgs e)
        {
            string query = "SELECT p.Product_Id AS PCODE, p.Name AS DESCRIPTION, SUM(items.Quantity) AS QTY, SUM(items.Item_Total) AS TOTAL_SALES\r\nFROM((Products AS p INNER JOIN Transaction_Item AS items ON p.Product_Id=items.Product_Id) INNER JOIN Transactions AS t ON t.Transaction_Id=items.Transaction_Id)\r\nWHERE t.Transaction_Date BETWEEN '" + start_date + "' AND '" + end_date + "'\r\nGROUP BY p.Product_Id, p.Name;\r\n";
            DataTable dt = databaseManger.getDataTableFromUserQuery(query);
            ReportServices reportServices = new ReportServices(reportViewer1, "Top_SoldItems", "TopSelling", dt);
            reportServices.Display_Report();
        }
    }
}
