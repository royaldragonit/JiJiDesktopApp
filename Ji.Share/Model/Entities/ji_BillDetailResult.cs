using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.Entities
{
    public class ji_BillDetailResult
    {
        public int cIndex { get; set; }
        public string cFoodName { get; set; }
        public string cToppingName { get; set; }
        public string cFoodPrice { get; set; }
        public int? cQuantity { get; set; }
        public string cTotalMoney { get; set; }
        public string cSaleOff { get; set; }
        public int? cDiscount { get; set; }
    }
}
