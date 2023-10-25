using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost() 
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.Cheese) PizzaPrice += 0;
            if (Pizza.TomatoSauce)PizzaPrice += 0;
            if (Pizza.Chicken) PizzaPrice += 2;
            if (Pizza.Pepperonni) PizzaPrice += 1;
            if (Pizza.Pinapple) PizzaPrice += 2;
            if (Pizza.Shrimp) PizzaPrice += 4;
            if (Pizza.Mashroom) PizzaPrice += 0.5f;

            Pizza.FinalPrice = PizzaPrice;

			return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, Pizza.FinalPrice });
        }
    }
}
