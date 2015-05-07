using System.Web.Http;
using tescofeedmewebapi.Models;

namespace tescofeedmewebapi.Controllers
{
    public class RecipeListController : ApiController
    {
        [HttpGet]
        public Recipe[] RecipesForUser(string id)
        {
            switch (id)
            {
                case AllowedUsers.User1:
                    return AllRecipes.Italian;
                case AllowedUsers.User2:
                    return AllRecipes.ModernEuropean;
            }
            return AllRecipes.French;
        }
    }
}