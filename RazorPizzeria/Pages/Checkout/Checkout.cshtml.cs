using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }
        public float FinalPrice { get; set; }
		public float BasePrice { get; set; }
		public bool Cheese { get; set; }
		public bool TomatoSauce { get; set; }
		public bool Chicken { get; set; }
		public bool Pinapple { get; set; }
		public bool Mushroom { get; set; }
		public bool Pepperonni { get; set; }
		public bool Shrimp { get; set; }

		private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if(string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create"; 
            }
            

            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.FinalPrice = FinalPrice;

            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();
        }
    }
}
