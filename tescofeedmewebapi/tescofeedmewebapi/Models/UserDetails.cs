using tescofeedmewebapi.Controllers;

namespace tescofeedmewebapi.Models
{
    public class UserDetails
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public int NumberOfClubcardPoints { get; set; } 
        public FamilyType FamilyType { get; set; } 
        public FoodTypePreferences FoodTypePreferences { get; set; }
        public FoodLocationPreferences FoodLocationPreferences { get; set; }
        public Recipe[] RecipeList { get; set; } 
    }
}