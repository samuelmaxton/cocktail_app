using System.Collections.Generic;

namespace CocktailApp.Models
{
	public class Cocktail
	{
		public int CocktailId { get; set; }
		public string Name { get; set; }
		public string Recipe { get; set; }
		public int OriginYear { get; set; }
		public int? FortifiedWineId { get; set; }
		public int? SpiritId { get; set; }

		public List<int> Bitters { get; set; } = new List<int>();
	}
}
