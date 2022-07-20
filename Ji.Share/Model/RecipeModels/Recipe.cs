using System;
namespace Ji.Model.RecipeModels
{
    public class Recipe
    {
        public int ID { get; set; }
        public int FoodID { get; set; }
        public string Note { get; set; }
        public DateTime CreateOn { get; set; }
    }
}
