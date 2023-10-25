namespace RazorPizzeria.Models
{
	public class PizzasModel
	{
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
		public float BasePrice { get; set; } = 10;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Pepperonni { get; set; }
		public bool Mashroom { get; set; }
		public bool Chicken { get; set; }
		public bool Pinapple { get; set; }
		public bool Shrimp { get; set; }
        public float FinalPrice { get; set; }
    }
}
