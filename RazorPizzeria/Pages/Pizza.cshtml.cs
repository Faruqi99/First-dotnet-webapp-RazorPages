using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;


namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public float FinalPrice { get; set; }
        public List<PizzasModel> PizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Bolognese", PizzaName="Bolognese", BasePrice=16, Cheese=true, Pepperonni=true, TomatoSauce=true, FinalPrice=16},
			new PizzasModel(){ImageTitle="Carbonara", PizzaName="Carbonara", BasePrice=18, Cheese=true, Shrimp=true, TomatoSauce=true, FinalPrice=18 },
			new PizzasModel(){ImageTitle="Hawaiian", PizzaName="Hawaiian", BasePrice=20, Cheese=true, Pepperonni=true, TomatoSauce=true, Mashroom=true, Pinapple=true, FinalPrice=20 },
			new PizzasModel(){ImageTitle="Margerita", PizzaName="Margerita", BasePrice=12, Cheese=true, Chicken=true, TomatoSauce=true, FinalPrice=12 },
			new PizzasModel(){ImageTitle="Seafood", PizzaName="Seafood", BasePrice=16, Cheese=true, Shrimp=true, TomatoSauce=true, FinalPrice=16 },
			new PizzasModel(){ImageTitle="Vegetarian", PizzaName="Vegetarian", BasePrice=11, Cheese=true, Mashroom=true, TomatoSauce=true , FinalPrice = 11}
		};
        public void OnGet()
        {
        }
    }
}
