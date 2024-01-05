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
        static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        SqlConnection con = new SqlConnection(sql);
        string start_date;
        string end_date;
        public SoldItems_Reports(string start_date, string end_date)
        {
            InitializeComponent();
            this.start_date = start_date;
            this.end_date = end_date;
        }

        private void SoldItems_Reports_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT p.Product_Id AS PCODE, p.Name AS DESCRIPTION, p.Price AS PRICE, SUM(items.Discount) AS DISCOUNT, SUM(items.Quantity) AS QTY, SUM(items.Item_Total) AS TOTAL_SALES\r\nFROM((Products AS p \r\nINNER JOIN Transaction_Item AS items ON p.Product_Id=items.Product_Id)\r\nINNER JOIN Transactions AS t ON t.Transaction_Id=items.Transaction_Id)\r\nWHERE t.Transaction_Date BETWEEN '" + start_date + "' AND '" + end_date + "'\r\nGROUP BY p.Product_Id, p.Name, p.Price\r\nORDER BY p.Name ASC;\r\n";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("SoldItems", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\hp\source\repos\Grocery_Shop\Grocery_Shop\Reports\SoldItems.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
