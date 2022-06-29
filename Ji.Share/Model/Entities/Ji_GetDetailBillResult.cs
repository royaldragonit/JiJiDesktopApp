using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.Entities
{
    public class Ji_GetDetailBillResult
    {
        public long? cIndex { get; set; }
        public string FoodName { get; set; }
        public string cToppingID { get; set; }
        public int cPriceTopping { get; set; }
        public int cQuantity { get; set; }
        public int? cPrice { get; set; }
        public int cOrderID { get; set; }
        public int cFoodID { get; set; }
        public int? cSaleOff { get; set; }
        public string cFood { get; set; }
        public int? cTotal { get; set; }
        public string Note { get; set; }
    }
}
