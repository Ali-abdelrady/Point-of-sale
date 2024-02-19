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
    public partial class Critical_Items_Report : Form
    {
        //Database Connection
        private SqlConnection con;
         
        DatabaseManger databaseManger = new DatabaseManger();
        public Critical_Items_Report()
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
        }

        private void Critical_Items_Report_Load(object sender, EventArgs e)
        {

            string query = "SELECT p.Product_Id, p.Name, p.Barcode, p.Price, c.Category_Name, b.Brand_Name, p.Cur_Amount\r\nFROM ((Products AS p\r\nINNER JOIN Categories AS c ON p.Category_Id = c.Category_Id)\r\nINNER JOIN Brands AS b ON p.Brand_Id = b.Brand_Id)\r\nWHERE p.Cur_Amount =0;";
            DataTable dt = databaseManger.getDataTableFromUserQuery(query);

            ReportServices reportServices = new ReportServices(reportViewer1, "Critical_Items", "Critical_Items", dt);
            reportServices.Display_Report();
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
