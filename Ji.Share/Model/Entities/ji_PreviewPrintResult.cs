using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.Entities
{
    public class ji_PreviewPrintResult
    {
        public int? cIndex { get; set; }
        public string CustomerName { get; set; }
        public string Cashier { get; set; }
        public DateTime? TimeCheckout { get; set; }
        public string FoodName { get; set; }
        public string Topping { get; set; }
        public int? Quantity { get; set; }
        public string Money { get; set; }
        public string TotalMoney { get; set; }
        public string MoneyCustomer { get; set; }
        public string CustomerRefund { get; set; }
        public int? Floor { get; set; }
        public int? Table { get; set; }
        public string Total { get; set; }
        public int? BillID { get; set; }
        public int? Discount { get; set; }
        public int FacId { get; set; }
    }
}
