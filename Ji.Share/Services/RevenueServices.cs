﻿using Ji.Commons;
using Ji.Core;
using Ji.Model.Billing;
using Ji.Model.CustomModels;
using Ji.Model.Entities;
using Ji.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services
{
    public class RevenueServices : IRevenueServices
    {
        public InitRevenueModel InitRevenue(int facId)
        {
            var data = API.Get<ResultCustomModel<InitRevenueModel>>(UrlApi.InitRevenue);
            return data.Data;
        }

        public bool RemoveRevenue(int orderID)
        {
            var data = API.Get<bool>(UrlApi.RemoveRevenue + "?orderId=" + orderID);
            return data;
        }

        public List<ReportBillDetail> ReprintRevenue(int billID)
        {
            var data = API.Get<ResultCustomModel<List<ReportBillDetail>>>(UrlApi.ReprintRevenue + "?billID=" + billID);
            return data.Data;
        }

        public List<ji_BillDetailResult> RevenueDetail(int billID)
        {
            var data = API.Get<ResultCustomModel<List<ji_BillDetailResult>>>(UrlApi.RevenueDetail + "?billID=" + billID);
            return data.Data;
        }

        public List<ji_Report_RevenueTodayResult> RevenueDistance(DateTime fromDate, DateTime toDate)
        {
            var data = API.Get<ResultCustomModel<List<ji_Report_RevenueTodayResult>>>(UrlApi.RevenueDistance + "?fromDate=" + fromDate + "&toDate=" + toDate);
            return data.Data;
        }
    }
}
