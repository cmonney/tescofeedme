namespace tescofeedmewebapi.Models
{
    internal static class AllRecipes
    {
        static Recipe _haddockRecipe = new Recipe
            {
                Title = "Haddock with summer vegetables recipe",
                HowLongItTakesInMins = 10,
                HowManyItFeeds = 4,
                ImageName = "img1.jpg",
                Ingredients =
                    new Ingredient[] {new Ingredient("Aubergines", "£1.50"), new Ingredient("Haddock fillets", "3.70")},
                Instructions = "do baking",
                PricePerPerson = 17.10
            };

        static Recipe _lambSteaks = new Recipe
        {
            Title = "Sizzling lamb steaks",
            HowLongItTakesInMins = 10,
            HowManyItFeeds = 4,
            ImageName = "img1.jpg",
            Ingredients =
                new Ingredient[] { new Ingredient("Aubergines", "£1.50"), new Ingredient("Haddock fillets", "3.70") },
            Instructions = "do baking",
            PricePerPerson = 17.10
        };

        public static readonly Recipe[] Italian = { _haddockRecipe, _lambSteaks };
        public static readonly Recipe[] French = { _haddockRecipe, _lambSteaks };
        public static readonly Recipe[] ModernEuropean = { _haddockRecipe, _lambSteaks };
    }
}