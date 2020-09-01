namespace CocktailApp.Models
{
	public class Spirit
	{
		public int SpiritId { get; set; }
		public string Name { get; set; }
		public decimal Abv { get; set; }
		public string Category { get; set; }
		public bool IsOverproof { get; set; }
	}
}
