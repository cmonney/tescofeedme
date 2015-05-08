using System.Web.Http;
using tescofeedmewebapi.Models;

namespace tescofeedmewebapi.Controllers
{
    public class SponsoredRecipeController : ApiController
    {
        [HttpGet]
        public Recipe GetSponsoredRecipe()
        {
            return AllRecipes.SponsoredRecipe;
        }
    }
}