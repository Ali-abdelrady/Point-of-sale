using Microsoft.Reporting.WinForms;
using SixLabors.ImageSharp.Drawing;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

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

            string exeFolder = AppDomain.CurrentDomain.BaseDirectory;
            string reportPath = System.IO.Path.Combine(exeFolder, "Reports", ""+fileName+".rdlc");
            reportViewer.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource(dataset, dt);

            reportViewer.LocalReport.ReportPath = reportPath;
            reportViewer.LocalReport.ReportPath = "../../Reports/"+fileName+".rdlc";
            reportViewer.LocalReport.DataSources.Add(source);
            reportViewer.RefreshReport();
        }

    }
}
