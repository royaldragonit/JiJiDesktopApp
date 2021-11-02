using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model
{
    public class Resource
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SupplierName { get; set; }
        public string Unit { get; set; }
        public int Price { get; set; }
        public string FacID { get; set; }
        public int Quantity { get; set; }
        public int QuantityInAUnit { get; set; }
        public double MoneyInAUnit { get; set; }
    }
}
