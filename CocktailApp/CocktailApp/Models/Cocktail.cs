using System;
using System.Collections.Generic;

namespace CocktailApp.Models
{
	public class Cocktail
	{
		public int CocktailId { get; set; }
		public string Name { get; set; }
		public List<Ingredient> Ingredients { get; set; }
		public string Recipe { get; set; }
		public DateTime Origin { get; set; }
		public int FortifiedWineId { get; set; }
		public int SpiritId { get; set; }
		public int BittersId { get; set; }
	}
}
