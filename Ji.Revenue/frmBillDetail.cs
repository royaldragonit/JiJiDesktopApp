using Ji.Core;
using Ji.Model;
using Ji.Model.Billing;
using Ji.Model.Entities;
using Ji.Revenue.Models;
using Ji.Sales;
using Ji.Services.Interface;
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
        public List<ji_BillDetailResult> dataSource;
        public IRevenueServices _revenueServices;

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
            List<ReportBillDetail> dataReprint = _revenueServices.ReprintRevenue(BillID);
            printing.dataSource = dataReprint;
            printing.ShowDialog();
        }
    }
}
