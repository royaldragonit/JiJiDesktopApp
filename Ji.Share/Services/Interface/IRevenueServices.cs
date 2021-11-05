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
        InitRevenueModel InitRevenue(string facId);
        List<ji_Report_RevenueTodayResult> RevenueDistance(DateTime fromDate, DateTime toDate);
    }
}
