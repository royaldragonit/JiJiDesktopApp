using Ji.Commons;
using Ji.Core;
using Ji.Model.CustomModels;
using Ji.Model.Entities;
using Ji.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Services
{
    public class RecipeServices : IRecipeServices
    {
        public List<ji_GetRecipeResult> ListRecipe()
        {
            var data = API.Get<ResultCustomModel<List<ji_GetRecipeResult>>>(UrlApi.ListRecipe);
            return data.Data;
        }

        public List<ji_GetResourceRecipeResult> ListResourceRecipe(int recipeID)
        {
            var data = API.Get<ResultCustomModel<List<ji_GetResourceRecipeResult>>>(UrlApi.ListResourceRecipe+"?recipeId="+recipeID);
            return data.Data;
        }
    }
}
