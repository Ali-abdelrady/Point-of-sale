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
    public partial class StockIn_Report : Form
    {
        //Database Connection
        static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        SqlConnection con = new SqlConnection(sql);

        string start_date;
        string end_date;
        public StockIn_Report(string start ,string end)
        {
            InitializeComponent();
             start_date=start;
             end_date=end;
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void StockIn_Report_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT\r\nstk_ent.Stock_Id ,\r\nstk_itm.Product_Id  ,\r\np.Name AS Product_Name ,\r\nstk_itm.Quantity , \r\nstk_ent.Entry_Date , \r\ne.First_Name AS StockBy , \r\nv.Name AS Vendor_Name \r\nFROM (((( Stock_Entries AS stk_ent \r\nINNER JOIN Vendors AS v ON stk_ent.Vendor_Id = v.Vendor_Id)\r\nINNER JOIN Employees AS e ON  stk_ent.User_Id = e.User_Id)\r\nINNER JOIN StockEntries_Items AS stk_itm ON stk_ent.Stock_Id = stk_itm.Stock_Id)\r\nINNER JOIN Products AS p ON p.Product_Id = stk_itm.Product_Id)\r\nWHERE stk_ent.Entry_Date BETWEEN '" + start_date + "' AND '" + end_date + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("StockIn_History", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\hp\source\repos\Grocery_Shop\Grocery_Shop\Reports\Stock_In_History - Copy.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
    }
}
