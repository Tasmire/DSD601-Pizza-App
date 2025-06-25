namespace DSD601_Pizza_App.Model
{
    public interface IPizza
    {
        string Flavour { get; set; }
        string Description { get; set; }
        string PizzaChef { get; set; }
        string ImageUrl { get; set; }
        List<string> Ingredients { get; set; }
        bool IsGlutenFree { get; set; }
        bool IsVegetarian { get; }
        List<PizzaSizePrice> SizePrices { get; set; }
        void UpdateIsVegetarian();
    }
}
