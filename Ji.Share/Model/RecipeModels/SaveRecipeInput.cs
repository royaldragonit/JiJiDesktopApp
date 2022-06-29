using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Model.RecipeModels
{
    public class SaveRecipeInput
    {
        public Guid? FormulaID { get; set; }
        public int CategoryID { get; set; }
        public string Component { get; set; }
        public string Formula { get; set; }
        public string FoodName { get; set; }
        public int FacId { get; set; }
        public string Unit { get; set; }
        public int Price { get; set; }
        public int PriceInput { get; set; }
        public int CreateBy { get; set; }
    }
}
