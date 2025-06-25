namespace DSD601_Pizza_App.Model
{
    public class ChickenCranberry :Pizza
    {
        public ChickenCranberry()
        {
            Flavour = "Chicken Cranberry";
            Description = "A unique pizza with tender chicken, tangy cranberries, and a blend of cheeses.";
            PizzaChef = "Clara Berry";
            ImageUrl = "~/img/chicken_cranberry.jpg";
            Ingredients.Add("Chicken");
            Ingredients.Add("Cranberries");
            Ingredients.Add("Mozzarella Cheese");
            Ingredients.Add("Creamy Garlic Sauce");
            IsGlutenFree = false;
            UpdateIsVegetarian(); // Checks if the pizza is vegetarian based on ingredients
        }
    }
}
