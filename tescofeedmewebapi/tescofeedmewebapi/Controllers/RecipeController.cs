using System.Web.Http;
using tescofeedmewebapi.Models;

namespace tescofeedmewebapi.Controllers
{
    public class RecipeController : ApiController
    {
        [HttpGet]
        public Recipe GetRecipe(int id)
        {
            return AllRecipes.AllRecipesDictionary[id];
        }
    }
}