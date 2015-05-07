namespace tescofeedmewebapi.Models
{
    public class Recipe
    {
        public string Title { get; set; }
        public string ImageName { get; set; }
        public double PricePerPerson { get; set; }
        public int HowManyItFeeds { get; set; }
        public int HowLongItTakesInMins { get; set; }
        public Ingredient[] Ingredients { get; set; }
        public string Instructions { get; set; }
    }
}