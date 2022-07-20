using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.OrderModels
{
    public class ToppingDTO
    {
        public int Price { get; set; }
        public string Name { get; set; }
    }
    public class OrderDetailV2
    {
        public int cIndex { get; set; }
        public string cFood { get; set; }
        public IEnumerable<ToppingDTO> cTopping { get; set; }
        public int cQuantity { get; set; }
        public string cUnit { get; set; }
        public string  cImage { get; set; }
        public int cSaleOff { get; set; }
        public int cPrice { get; set; }
        public int cPriceTopping { get; set; }
        public string cToppingID { get; set; }
        public int cTotal { get; set; }
        public int cOrderID { get; set; }
        public int cFoodID { get; set; }
        public string Note { get; set; }
    }
}
