using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.Entities
{
    public class ji_BillDetailResult
    {
        public long? cIndex { get; set; }
        public string cFoodName { get; set; }
        public int? cFoodPrice { get; set; }
        public int cQuantity { get; set; }
        public int cTotalMoney { get; set; }
        public int cDiscount { get; set; }
    }
}
