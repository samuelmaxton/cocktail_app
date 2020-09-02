using CocktailApp.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace CocktailApp.Repository.Entities
{
	[Table("CocktailBitters")]
	public class CocktailBittersEntity
	{
		public int CocktailId { get; set; }
		public virtual CocktailEntity Cocktail { get; set; }

		public int BittersId { get; set; }
		public virtual BittersEntity Bitters { get; set; }		
	}
}
