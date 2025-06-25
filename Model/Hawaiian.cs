namespace DSD601_Pizza_App.Model
{
    public class Hawaiian :Pizza, IPizza
    {
        public Hawaiian()
        {
            Flavour = "Hawaiian";
            Description = "A classic Hawaiian pizza with ham and pineapple.";
            ImageUrl = "img/hawaiian.jpg";
            Ingredients.Add("Ham");
            Ingredients.Add("Pineapple");
            IsGlutenFree = false;
            UpdateIsVegetarian(); // Checks if the pizza is vegetarian based on ingredients
            SizePrices.AddRange(
                new PizzaSizePrice { Size = "Small", Price = 10 },
                new PizzaSizePrice { Size = "Medium", Price = 15 },
                new PizzaSizePrice { Size = "Large", Price = 20 }
            );
            PizzaChefName();
        }
        public override void PizzaChefName()
        {
            PizzaChef = "Howard Waiian";
        }
    }
}
