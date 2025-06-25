using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DSD601_Pizza_App.Model;

namespace DSD601_Pizza_App.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string? SelectedPizzaType { get; set; }

        public IPizza? SelectedPizza { get; set; }

        public List<IPizza> AvailablePizzas { get; set; } = new();
        public SelectList PizzaSelectList { get; set; } = null!;

        public bool FirstLoad { get; set; } = true;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            AvailablePizzas = Factory.GetAllPizzas(); // Returns List<IPizza>
            PizzaSelectList = new SelectList(AvailablePizzas, "Flavour", "Flavour");
        }

        public void OnPost()
        {
            FirstLoad = false;
            AvailablePizzas = Factory.GetAllPizzas();
            PizzaSelectList = new SelectList(AvailablePizzas, "Flavour", "Flavour");
            if (!string.IsNullOrEmpty(SelectedPizzaType))
            {
                SelectedPizza = (IPizza?)Factory.GetPizza(SelectedPizzaType);
            }
        }
    }
}
