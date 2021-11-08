using Ji.Model.Entities;
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
        List<ji_GetResourceRecipeResult> ListResourceRecipe(int recipeID);
    }
}
