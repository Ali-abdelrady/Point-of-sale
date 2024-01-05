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
    public partial class Inventory_Report : Form
    {        
        //Database Connection
        static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        SqlConnection con = new SqlConnection(sql);
        public Inventory_Report()
        {
            InitializeComponent();
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inventory_Report_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT p.Product_Id, p.Name, p.Barcode, p.Price, c.Category_Name, b.Brand_Name, p.Cur_Amount\r\nFROM ((Products AS p\r\nINNER JOIN Categories AS c ON p.Category_Id=c.Category_Id)\r\nINNER JOIN Brands AS b ON p.Brand_Id=b.Brand_Id);";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("Inventory_List", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\hp\source\repos\Grocery_Shop\Grocery_Shop\Reports\Inventory.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
    }
}
