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
    public partial class Transaction_Report : Form
    {
        private SqlConnection con;
        DatabaseManger dbManger = new DatabaseManger();
        string store_name="";
        string store_address= "";
        string emp_id= "";
        string transaction_num="";
        public Transaction_Report()
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
        }

        private void Transaction_Report_Load(object sender, EventArgs e)
        {
            Load_ReceiptInfo();
            string query = "SELECT \r\np.Product_Id AS PCODE,\r\np.Name AS DESCRIPTION,\r\np.Price AS PRICE,\r\nSUM(items.Discount) AS DISCOUNT,\r\nSUM(items.Quantity) AS QTY,\r\nSUM(items.Item_Total) AS TOTAL_SALES\r\nFROM((Products AS p INNER JOIN Transaction_Item AS items ON p.Product_Id=items.Product_Id)\r\nINNER JOIN Transactions AS t ON t.Transaction_Id=items.Transaction_Id)\r\nWHERE t.Transaction_Id=IDENT_CURRENT('Transactions')\r\nGROUP BY p.Product_Id, p.Name, p.Price\r\nORDER BY p.Name ASC;\r\n";
            DataTable dt = dbManger.getDataTableFromUserQuery(query);

            ReportServices service = new ReportServices(reportViewer1, "SoldItems", "Transaction_Details",dt);
            service.Display_Report();
            //Additonal Stuff
            ReportParameter Store = new ReportParameter("Store", store_name);
            ReportParameter Address = new ReportParameter("Address", store_address);
            ReportParameter Cashier = new ReportParameter("Cashier", emp_id);
            ReportParameter Transaction = new ReportParameter("Transaction", transaction_num);
            reportViewer1.LocalReport.SetParameters(Store);
            reportViewer1.LocalReport.SetParameters(Address);
            reportViewer1.LocalReport.SetParameters(Cashier);
            reportViewer1.LocalReport.SetParameters(Transaction);
            reportViewer1.RefreshReport();
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Load_ReceiptInfo()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT s.Name AS STORE_NAME, s.Address AS ADDRESS, e.Emp_Id AS CASHIER, IDENT_CURRENT('Transactions') AS REF\r\nFROM Store_Details AS s, Employees AS e\r\nWHERE e.Emp_Id=@emp_id;\r\n";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@emp_id", User.Emp_Id);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                store_name = dt.Rows[0]["STORE_NAME"].ToString();
                store_address = dt.Rows[0]["ADDRESS"].ToString();
                emp_id = dt.Rows[0]["CASHIER"].ToString();
                transaction_num = dt.Rows[0]["REF"].ToString();
                
            }
            catch
            {
                MessageBox.Show("Error in load receipt info");
            }
            finally
            {
                con.Close();
            }

        }
    }
}
