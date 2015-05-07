namespace tescofeedmewebapi.Models
{
    public class Ingredient
    {
        public string Name { get; set; }
        public string Price { get; set; }

        public Ingredient(string name, string price)
        {
            Name = name;
            Price = price;
        }
    }
}