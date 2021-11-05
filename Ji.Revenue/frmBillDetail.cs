using Ji.Core;
using Ji.Model;
using Ji.Revenue.Models;
using Ji.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ji.Revenue
{
    public partial class frmBillDetail : ClientForm
    {
        public int BillID = 0;
        public List<BillDetails> dataSource;

        public frmBillDetail()
        {
            InitializeComponent();
        }

        private void frmBillDetail_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dataSource;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
                PreviewPrinting printing = new PreviewPrinting();
                //var dataSource = API.API_RePrinter<ReportBillDetail>(Extension.GetAppSetting("API") + "Print/RePrinter", API.Access_Token, BillID).ToList();
                //// var dataSource = db.ji_Checkout(gridControl1.Tag.ToInt(), 1, 0, CustomerName, "0978.123.900", DateTime.Now, CustomerMoney).ToList();
                //printing.dataSource = dataSource;
                printing.ShowDialog();
            }
    }
}
