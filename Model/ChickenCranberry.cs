namespace DSD601_Pizza_App.Model
{
    public class ChickenCranberry :Pizza, IPizza
    {
        public ChickenCranberry()
        {
            Flavour = "Chicken Cranberry";
            Description = "A unique pizza with tender chicken, tangy cranberries, and a blend of cheeses.";
            ImageUrl = "~/img/chicken_cranberry.jpg";
            Ingredients.Add("Chicken");
            Ingredients.Add("Cranberries");
            Ingredients.Add("Mozzarella Cheese");
            Ingredients.Add("Creamy Garlic Sauce");
            IsGlutenFree = false;
            UpdateIsVegetarian(); // Checks if the pizza is vegetarian based on ingredients
        }

        public override void PizzaChefName()
        {
            PizzaChef = "Clara Berry";
        }
    }
}
