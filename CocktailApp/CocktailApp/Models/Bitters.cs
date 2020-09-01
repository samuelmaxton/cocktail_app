using System.Collections.Generic;

namespace CocktailApp.Models
{
	public class Bitters : Ingredient
	{
		public int BittersId { get; set; }

		public ICollection<CocktailBitters> CocktailBitters { get; set; }
	}
}
