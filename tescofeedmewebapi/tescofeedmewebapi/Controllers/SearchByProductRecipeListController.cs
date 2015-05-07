using System.Web.Http;
using tescofeedmewebapi.Models;

namespace tescofeedmewebapi.Controllers
{
    public class SearchByProductRecipeListController : ApiController
    {
        [HttpGet]
        public Recipe[] RecipesThatIncludeProduct(string id)
        {
            return AllRecipes.RecipesContainRedPeppers;
        }
    }
}