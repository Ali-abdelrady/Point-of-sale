using Grocery_Shop.Classes;
using Grocery_Shop.Login;
using Grocery_Shop.Reports;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grocery_Shop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseManger dbManger  = new DatabaseManger();
            Authenticator authenticator = new Authenticator();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            dbManger.SeedData();
            Application.Run(new login_form(authenticator));
        }
    }
}
