using DevExpress.XtraPrinting.Caching;
using DevExpress.XtraReports.UI;
using Ji.Bill;
using Ji.Commons;
using Ji.Core;
using Ji.Model;
using Ji.Model.Billing;
using Ji.Model.Entities;
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
        public PreviewPrinting()
        {
            InitializeComponent();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                ListPrinter.Properties.Items.Add(printer);
            ListPrinter.SelectedIndex = 0;
            if (ListPrinter.Properties.Items.Contains(Configure.Setup.DefaultPrinter))
                ListPrinter.SelectedItem = Configure.Setup.DefaultPrinter;
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
            List<ReportBillDetail> barcode = new List<ReportBillDetail>();
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
                    var printTool = new ReportPrintTool(report);
                    printTool.PrinterSettings.PrinterName = ListPrinter.SelectedItem.ToString();
                    //In mã vạch
                    if (BarCode)
                    {
                        var PrintBarCode = new ReportPrintTool(rptBarCode);
                        PrintBarCode.PrinterSettings.PrinterName = "BarCode";
                        PrintBarCode.Print();
                    }
                    printTool.Print();
                    if (Configure.Setup.NumberPrintBill == 2)
                        printTool.Print();
                    DialogResult = DialogResult.OK;
                    Close();
                });
            });
            thread.Start();
        }
    }
}
