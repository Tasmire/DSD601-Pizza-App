using System;
namespace DSD601_Pizza_App.Model
{
    public static class Factory
    {
        public static Pizza GetPizza(string pizzaType)
        {
            if (pizzaType == "CheesyGarlic")
            { 
                return new CheesyGarlic();
            }

            if (pizzaType == "ChickenCranberry")
            {
                return new ChickenCranberry();
            }

            if (pizzaType == "Hawaiian")
            {
                return new Hawaiian();
            }

            //default if no match found
            return new CheesyGarlic();
        }

        public static List<IPizza> GetAllPizzas()
        {
            return new List<IPizza>
            {
                new Hawaiian(),
                new CheesyGarlic(),
                new ChickenCranberry()
            };
        }
    }
}