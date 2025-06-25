namespace DSD601_Pizza_App.Model
{
    public class Pizza
    {
        public int ID { get; set; }
        public string Flavour { get; set; }
        public string Description { get; set; }
        public string PizzaChef { get; set; }
        public string ImageUrl { get; set; }
        public bool IsGlutenFree { get; set; }
        public bool IsVegetarian { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();
        public Dictionary<string, decimal> SizePrices { get; set; } = new()
        {
            { "Small", 10m },
            { "Medium", 15m },
            { "Large", 20m }
        };
        public void UpdateIsVegetarian()
        {
            var meatIngredients = new List<string>
            {
                "chicken", "beef", "ham", "bacon", "pepperoni", "sausage", "salami", "anchovies", "lamb", "turkey"
            };

            IsVegetarian = !Ingredients
                .Any(i => meatIngredients
                    .Any(meat => i.Contains(meat, StringComparison.OrdinalIgnoreCase)));
        }
    }
}
