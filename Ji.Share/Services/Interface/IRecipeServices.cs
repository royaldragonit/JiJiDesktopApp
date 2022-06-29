using Ji.Model;
using Ji.Model.CustomModels;
using Ji.Model.Entities;
using Ji.Model.RecipeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services.Interface
{
    public interface IRecipeServices
    {
        List<ji_GetRecipeResult> ListRecipe();
        ResultCustomModel<bool> UpdateRecipe(int recipeId, string note);
        List<ji_GetResourceRecipeResult> ListResourceRecipe(int recipeID);
        ResultCustomModel<bool> AddResourceRecipe(ResourcesRecipe resources);
        ResultCustomModel<bool> SaveRecipe(SaveRecipeInput saveRecipe);
        ResultCustomModel<Recipe> AddRecipe(int foodID, string note);
    }
}
