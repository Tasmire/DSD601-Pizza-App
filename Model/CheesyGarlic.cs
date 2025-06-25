namespace DSD601_Pizza_App.Model
{
    public class CheesyGarlic :Pizza, IPizza
    {
        public CheesyGarlic()
        {
            Flavour = "Cheesy Garlic";
            Description = "A delicious cheesy garlic pizza with a blend of mozzarella and garlic butter.";
            ImageUrl = "img/cheesy-garlic.jpg";
            Ingredients.Add("Mozzarella Cheese");
            Ingredients.Add("Garlic Butter");
            IsGlutenFree = true;
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
            PizzaChef = "Garry Cheese";
        }
    }
}
