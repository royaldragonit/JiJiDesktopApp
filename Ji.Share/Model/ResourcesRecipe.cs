using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model
{
    public class ResourcesRecipe
    {
        public int ID { get; set; }
        public int ResourcesID { get; set; }
        public int RecipeID { get; set; }
        public int Quantity { get; set; }
        public double PriceCost { get; set; }
    }
}
