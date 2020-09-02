using System.Collections.Generic;

namespace CocktailApp.Models
{
	public class Bitters : Ingredient
	{
		public int BittersId { get; set; }

		public List<int> Cocktails { get; set; } = new List<int>();
	}
}
