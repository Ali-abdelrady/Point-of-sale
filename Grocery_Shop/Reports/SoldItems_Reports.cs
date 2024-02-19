using Grocery_Shop.Classes;
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
    public partial class SoldItems_Reports : Form
    {
        //Database Connection
        private SqlConnection con;
        DatabaseManger databaseManger = new DatabaseManger();
        string start_date;
        string end_date;
        int emp_id;
        public SoldItems_Reports(string start_date, string end_date ,int emp_id)
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
            this.start_date = start_date;
            this.end_date = end_date;
            this.emp_id = emp_id;
        }

        private void SoldItems_Reports_Load(object sender, EventArgs e)
        {
            string query = (emp_id != -1) ?
                "SELECT\r\n  p.Product_Id AS PCODE,\r\n  p.Name AS DESCRIPTION,\r\n  p.Price AS PRICE,\r\n  SUM(items.Discount) AS DISCOUNT,\r\n  SUM(items.Quantity) AS QTY,\r\n  SUM(items.Item_Total) AS TOTAL_SALES,\r\n  RTRIM(e.First_Name)+' '+RTRIM(e.Last_Name) AS SoldBy\r\nFROM\r\n  (\r\n    Products AS p\r\n    INNER JOIN Transaction_Item AS items ON p.Product_Id = items.Product_Id\r\n  )\r\n  INNER JOIN Transactions AS t ON t.Transaction_Id = items.Transaction_Id\r\n  INNER JOIN Employees AS e ON e.Emp_Id = t.Emp_Id\r\nWHERE\r\n  t.Transaction_Date BETWEEN '" + start_date + "' AND '" + end_date + "' AND e.Emp_Id = '"+emp_id+"' \r\nGROUP BY\r\n  p.Product_Id, p.Name, p.Price ,RTRIM(e.First_Name)+' '+RTRIM(e.Last_Name)\r\nORDER BY\r\n  p.Name ASC;\r\n"
                :"SELECT\r\n  p.Product_Id AS PCODE,\r\n  p.Name AS DESCRIPTION,\r\n  p.Price AS PRICE,\r\n  SUM(items.Discount) AS DISCOUNT,\r\n  SUM(items.Quantity) AS QTY,\r\n  SUM(items.Item_Total) AS TOTAL_SALES,\r\n  RTRIM(e.First_Name)+' '+RTRIM(e.Last_Name) AS SoldBy\r\nFROM\r\n  (\r\n    Products AS p\r\n    INNER JOIN Transaction_Item AS items ON p.Product_Id = items.Product_Id\r\n  )\r\n  INNER JOIN Transactions AS t ON t.Transaction_Id = items.Transaction_Id\r\n  INNER JOIN Employees AS e ON e.Emp_Id = t.Emp_Id\r\nWHERE\r\n  t.Transaction_Date BETWEEN '" + start_date + "' AND '" + end_date + "' \r\nGROUP BY\r\n  p.Product_Id, p.Name, p.Price ,RTRIM(e.First_Name)+' '+RTRIM(e.Last_Name)\r\nORDER BY\r\n  p.Name ASC;\r\n";
            DataTable dt = databaseManger.getDataTableFromUserQuery(query);
            ReportServices reportServices = new ReportServices(reportViewer1, "SoldItems", "SoldItems", dt);
            reportServices.Display_Report();
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
