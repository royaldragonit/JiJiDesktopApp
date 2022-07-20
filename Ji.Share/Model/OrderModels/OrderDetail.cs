using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.OrderModels
{
    public class OrderDetail
    {
        public int cIndex { get; set; }
        public string cFood { get; set; }
        public string cTopping { get; set; }
        public int cQuantity { get; set; }
        public string cUnit { get; set; }
        public Image cImage { get; set; }
        public int cPrice { get; set; }
        public int cTotal { get; set; }
        public int cOrderID { get; set; }
        public int cFoodID { get; set; }
    }
}
