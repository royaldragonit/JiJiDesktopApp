using Ji.Commons;
using Ji.Core;
using Ji.Model;
using Ji.Model.CustomModels;
using Ji.Model.Entities;
using Ji.Model.RecipeModels;
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
        public ResultCustomModel<Recipe> AddRecipe(int foodId, string note)
        {
            var data = API.Get<ResultCustomModel<Recipe>>(UrlApi.AddRecipe + "?foodId=" + foodId + "&note=" + note);
            return data;
        }

        public ResultCustomModel<bool> AddResourceRecipe(ResourcesRecipe resources)
        {
            var data = API.Post<ResultCustomModel<bool>>(UrlApi.AddResourceRecipe,resources);
            return data;
        }

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

        public ResultCustomModel<bool> SaveRecipe(SaveRecipeInput saveRecipe)
        {
            throw new NotImplementedException();
        }

        public ResultCustomModel<bool> UpdateRecipe(int recipeId, string note)
        {
            var data = API.Get<ResultCustomModel<bool>>(UrlApi.UpdateRecipe + "?recipeId=" + recipeId+"&note="+note);
            return data;
        }
    }
}
