using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Shop.Classes
{
    public class ReportServices
    {
        //Properties
        ReportViewer reportViewer;
        DataTable dt;
        string dataset;
        string fileName;
        public ReportServices(ReportViewer reportViewer, string dataset , string fileName,DataTable dt) 
        {
            this.reportViewer = reportViewer;
            this.dataset = dataset;
            this.dt = dt;
            this.fileName = fileName;
        }

        //Methods
        public void Display_Report()
        {
            reportViewer.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource(dataset, dt);
            reportViewer.LocalReport.ReportPath = @"C:\Users\hp\source\repos\Grocery_Shop\Grocery_Shop\Reports\"+ fileName +".rdlc";
            reportViewer.LocalReport.DataSources.Add(source);
            reportViewer.RefreshReport();
        }

    }
}
