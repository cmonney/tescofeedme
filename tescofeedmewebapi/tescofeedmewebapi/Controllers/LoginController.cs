using System.Web.Http;
using tescofeedmewebapi.Models;

namespace tescofeedmewebapi.Controllers
{
    public enum FamilyType { Single, Couple, FamilyOf3, FamilyOf4 };

    public enum FoodTypePreferences { Budget, MidRange, Finest };

    public enum FoodLocationPreferences { Indian, French, Italian };

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
                        FirstName = "Steve",
                        LastName = "Wotton",
                        NumberOfClubcardPoints = 567,
                        FamilyType = FamilyType.FamilyOf4.ToString(),
                        FoodTypePreferences = FoodTypePreferences.Budget.ToString(),
                        FoodLocationPreferences = FoodLocationPreferences.Indian.ToString(),
                    };
                case AllowedUsers.User2:
                {
                    return new UserDetails
                    {
                        FirstName = "Polly",
                        LastName = "Shaw",
                        NumberOfClubcardPoints = 112,
                        FamilyType = FamilyType.Single.ToString(),
                        FoodTypePreferences = FoodTypePreferences.Budget.ToString(),
                        FoodLocationPreferences = FoodLocationPreferences.Italian.ToString(),
                    };
                }
                default:
                return new UserDetails
                {
                    FirstName = "Dave",
                    LastName = "Lewis",
                    NumberOfClubcardPoints = 753,
                    FamilyType = FamilyType.FamilyOf4.ToString(),
                    FoodTypePreferences = FoodTypePreferences.Finest.ToString(),
                    FoodLocationPreferences = FoodLocationPreferences.Italian.ToString(),
                };
            }
        }
    }
}