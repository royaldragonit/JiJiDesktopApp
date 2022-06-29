using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.InventoryModels
{
    public class AddResourceInput
    {
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int PriceOld { get; set; }
        public int ResourceID { get; set; }
    }
}
