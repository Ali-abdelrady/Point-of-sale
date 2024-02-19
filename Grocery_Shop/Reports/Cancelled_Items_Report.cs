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
    public partial class Cancelled_Items_Report : Form
    {
        private SqlConnection con;
        DatabaseManger databaseManger = new DatabaseManger();
        string start_date;
        string end_date;
        public Cancelled_Items_Report(string start_date, string end_date)
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

        private void Cancelled_Items_Report_Load(object sender, EventArgs e)
        {
            string query = "SELECT \r\nTransaction_Id,\r\nName ,\r\nPrice ,\r\nCancelled_Qty,\r\nCancelled_Date,\r\nCancelledBy,\r\nCancel_Reason,\r\nAction\r\nFROM Cancelled_Orders c INNER JOIN Products p ON p.Product_Id = c.Product_Id WHERE Cancelled_Date BETWEEN '" + start_date + "' AND '" + end_date + "';";
            DataTable dt = databaseManger.getDataTableFromUserQuery(query);
            ReportServices reportServices = new ReportServices(reportViewer1, "Cancelled_Items", "Cancelled_Items", dt);
            reportServices.Display_Report();
        }
    }
}
