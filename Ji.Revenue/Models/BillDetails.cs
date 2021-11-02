using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Revenue.Models
{
    public class BillDetails
    {
        public int cIndex { get; set; }
        public int cDiscount { get; set; }
        public string cSaleOff { get; set; }
        public string cFoodName { get; set; }
        public string cToppingName { get; set; }
        public string cFoodPrice { get; set; }
        public Nullable<int> cQuantity { get; set; }
        public string cTotalMoney { get; set; }
    }
}
