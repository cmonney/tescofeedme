using System.Web.Http;
using tescofeedmewebapi.Models;

namespace tescofeedmewebapi.Controllers
{
    public enum FamilyType { Single, Couple, FamilyOf3 };

    public enum FoodTypePreferences { Budget, MidRange, Finest };

    public enum FoodLocationPreferences { Italian, French, AmericanSimple };

    public class LoginController : ApiController
    {
        [HttpGet]
        public UserDetails LoginForUser(string id)
        {
            switch (id)
            {
                case AllowedUsers.User1:
                    return new UserDetails
                    {
                        FirstName = "Polly",
                        LastName = "Shaw",
                        NumberOfClubcardPoints = 567,
                        FamilyType = FamilyType.FamilyOf3,
                        FoodTypePreferences = FoodTypePreferences.Finest,
                        FoodLocationPreferences = FoodLocationPreferences.Italian,
                    };
                case AllowedUsers.User2:
                {
                    return new UserDetails
                    {
                        FirstName = "Nick",
                        LastName = "Wake",
                        NumberOfClubcardPoints = 112,
                        FamilyType = FamilyType.Single,
                        FoodTypePreferences = FoodTypePreferences.Budget,
                        FoodLocationPreferences = FoodLocationPreferences.AmericanSimple,
                    };
                }
                default:
                return new UserDetails
                {
                    FirstName = "",
                    LastName = "Person",
                    NumberOfClubcardPoints = 567,
                    FamilyType = FamilyType.Couple,
                    FoodTypePreferences = FoodTypePreferences.MidRange,
                    FoodLocationPreferences = FoodLocationPreferences.French,
                };
            }
        }
    }
}