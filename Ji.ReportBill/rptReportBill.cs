using System;
using DevExpress.XtraReports.UI;
using System.Linq;
namespace Ji.ReportBill
{
    public partial class rptReportBill
    {
        public rptReportBill()
        {
            InitializeComponent();
           // BindingData();
        }

        public void BindingData()
        {
            JiMilkTeaEntities db = new JiMilkTeaEntities();
            var ds=db.ji_Checkout(1, 1, 0, "Hoàng Long", "0978.123.900", DateTime.Now, 1000000).ToList();
            DataSource = ds;
        }
    }
}
