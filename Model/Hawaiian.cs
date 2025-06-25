namespace DSD601_Pizza_App.Model
{
    public class Hawaiian :Pizza, IPizza
    {
        public Hawaiian()
        {
            Flavour = "Hawaiian";
            Description = "A classic Hawaiian pizza with ham and pineapple.";
            PizzaChef = "Howard Waiian";
            ImageUrl = "~/img/hawaiian.jpg";
            Ingredients.Add("Ham");
            Ingredients.Add("Pineapple");
            IsGlutenFree = false;
            UpdateIsVegetarian(); // Checks if the pizza is vegetarian based on ingredients
        }
    }
}
