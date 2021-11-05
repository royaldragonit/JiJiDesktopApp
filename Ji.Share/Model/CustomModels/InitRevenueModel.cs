using Ji.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.CustomModels
{
   public class InitRevenueModel
    {
        public List<ji_Report_RevenueTodayResult> RevenueToday { get; set; }
        public List<Pay> PayToDay { get; set; }
        public List<ji_Report_RevenueResult> RevenueCurrentMonth { get; set; }
    }
}
