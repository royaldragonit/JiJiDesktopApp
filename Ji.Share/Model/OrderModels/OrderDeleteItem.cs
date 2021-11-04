using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.OrderModels
{
    public class OrderDeleteItem
    {
        public int OrderID { get; set; }
        public int FoodID { get; set; }
        public string ToppingID { get; set; }
    }
}
