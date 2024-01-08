using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.Entities
{
    public class ji_Report_RevenueTodayResult
    {
        public int cOrderID { get; set; }
        public int cQuantity { get; set; }
        public int cTotalMoney { get; set; }
        public DateTime? cCreateOn { get; set; }
        public string CustomerName { get; set; }
        public int Table { get; set; }
        public int cDiscount { get; set; }
        public string cCustomerName { get; set; }
        public int cTotal { get; set; }
        public string Delivery { get; set; }
    }
}
