using DevExpress.XtraPrinting.Caching;
using DevExpress.XtraReports.UI;
using Ji.Bill;
using Ji.Core;
using Ji.Model;
using Ji.Model.Billing;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ji.Sales
{
    public partial class PreviewPrinting : Form
    {
        public List<ReportBillDetail> dataSource;
        public string type = "print";
        JObject setup = Extension.Setup;
        public PreviewPrinting()
        {
            InitializeComponent();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                ListPrinter.Properties.Items.Add(printer);
            ListPrinter.SelectedIndex = 0;
            //if (ListPrinter.Properties.Items.Contains(setup["defaultPrinter"]))
            //    ListPrinter.SelectedItem = setup["defaultPrinter"];
        }

        rptBill report = new rptBill();
        rptBarCode rptBarCode = new rptBarCode();
        public bool BarCode { get; set; } = false;

        private void PreviewPrinting_Load(object sender, EventArgs e)
        {
            report.ShowPrintMarginsWarning = false;
            report.DataSource = dataSource;
            report.CreateDocument();
            Preview.DocumentSource = report;
            //Set cho máy in mã vạch
            rptBarCode.ShowPrintMarginsWarning = false;
            List<dynamic> barcode = new List<dynamic>();
            foreach (var item in dataSource)
            {
                for (int i = 0; i < item.Quantity; i++)
                {
                    barcode.Add(item);
                }
            }
            rptBarCode.DataSource = barcode;
            rptBarCode.CreateDocument();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                BeginInvoke((Action)delegate ()
                {
                    //var storage = new MemoryDocumentStorage();
                    //// report.ExportToPdf(Environment.SpecialFolder.MyDocuments.ToString());
                    //var cachedReportSource = new CachedReportSource(report, storage);
                    var printTool = new ReportPrintTool(report);
                    printTool.PrinterSettings.PrinterName = ListPrinter.SelectedItem.ToString();
                    //In mã vạch
                    if (BarCode)
                    {
                        var PrintBarCode = new ReportPrintTool(rptBarCode);
                        PrintBarCode.PrinterSettings.PrinterName = "BarCode";
                        PrintBarCode.Print();
                    }
                    if (setup["numberPrintBill"].ToInt() == 2)
                    {
                        printTool.Print();
                        printTool.Print();
                    }
                    else
                        printTool.Print();
                    DialogResult = DialogResult.OK;
                    Close();
                });
            });
            thread.Start();
        }
    }
}
