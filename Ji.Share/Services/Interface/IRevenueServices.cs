using Ji.Model.Billing;
using Ji.Model.CustomModels;
using Ji.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services.Interface
{
    public interface IRevenueServices
    {
        InitRevenueModel InitRevenue(int facId);
        List<ji_Report_RevenueTodayResult> RevenueDistance(DateTime fromDate, DateTime toDate);
        List<ji_BillDetailResult> RevenueDetail(int billID);
        List<ReportBillDetail> ReprintRevenue(int billID);
        bool RemoveRevenue(int orderID);
    }
}
