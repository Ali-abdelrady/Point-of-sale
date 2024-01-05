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
    public partial class Critical_Items_Report : Form
    {
        //Database Connection
        static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        SqlConnection con = new SqlConnection(sql);

        public Critical_Items_Report()
        {
            InitializeComponent();
        }

        private void Critical_Items_Report_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            string query = "SELECT p.Product_Id, p.Name, p.Barcode, p.Price, c.Category_Name, b.Brand_Name, p.Cur_Amount\r\nFROM ((Products AS p\r\nINNER JOIN Categories AS c ON p.Category_Id = c.Category_Id)\r\nINNER JOIN Brands AS b ON p.Brand_Id = b.Brand_Id)\r\nWHERE p.Cur_Amount =0;";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("Critical_Items", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\hp\source\repos\Grocery_Shop\Grocery_Shop\Reports\Critical_Items.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
