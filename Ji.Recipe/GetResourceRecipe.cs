using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Recipe
{
    public class GetResourceRecipe
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public double PriceCost { get; set; }
        public int ID { get; set; }
        public string Note { get; set; }
        public int ResourcesID { get; set; }
    }
}
