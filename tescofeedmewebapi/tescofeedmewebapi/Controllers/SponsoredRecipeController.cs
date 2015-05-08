using System.Web.Mvc;
using tescofeedmewebapi.Models;

namespace tescofeedmewebapi.Controllers
{
    public class SponsoredRecipeController : Controller
    {
        public Recipe Index()
        {
            return AllRecipes.SponsoredRecipe;
        }
    }
}