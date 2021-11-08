using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.Entities
{
    public class ji_GetRecipeResult
    {
        public string FoodName { get; set; }
        public double? PriceCost { get; set; }
        public int Price { get; set; }
        public string RecipeName { get; set; }
        public int ID { get; set; }
        public int FoodID { get; set; }
        public string Note { get; set; }
        public int ResourcesID { get; set; }
    }
}
