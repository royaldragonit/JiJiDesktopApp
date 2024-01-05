using Ji.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.OrderModels
{
    public class CheckoutModel
    {
        public int OrderId { get; set; }
        public int Discount { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public int CreateBy { get; set; } = 0;
        public int Table { get; set; }
        public int AffectFloor { get; set; }
        public int FacId { get; set; } = 0;
        public int CustomerMoney { get; set; }
        public string Cashier { get; set; }
        public DateTime DischargOn { get; set; }
        public string CustomerRefund { get; set; }
        public int TotalMoney { get; set; }
        public int? CustomerId { get; set; }
        public string DeliveryType { get; set; } //Grab, Goviet, v....
        public IEnumerable<Ji_GetDetailBillResult> OrderDetail { get; set; }
        public DateTime TimeCheckout { get; set; }
    }
}
