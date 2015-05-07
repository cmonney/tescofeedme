using tescofeedmewebapi.Controllers;

namespace tescofeedmewebapi.Models
{
    public class UserDetails
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public int NumberOfClubcardPoints { get; set; } 
        public string FamilyType { get; set; } 
        public string FoodTypePreferences { get; set; }
        public string FoodLocationPreferences { get; set; }
        public Recipe[] RecipeList { get; set; } 
    }
}