namespace DSD601_Pizza_App.Model
{
    public class CheesyGarlic :Pizza, IPizza
    {
        public CheesyGarlic()
        {
            Flavour = "Cheesy Garlic";
            Description = "A delicious cheesy garlic pizza with a blend of mozzarella and garlic butter.";
            PizzaChef = "Garry Cheese";
            ImageUrl = "~/img/cheesy_garlic.jpg";
            Ingredients.Add("Mozzarella Cheese");
            Ingredients.Add("Garlic Butter");
            IsGlutenFree = true;
            UpdateIsVegetarian(); // Checks if the pizza is vegetarian based on ingredients
        }
    }
}
