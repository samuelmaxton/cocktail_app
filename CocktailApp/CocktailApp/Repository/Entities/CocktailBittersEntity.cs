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

		public static CocktailBittersEntity Map(CocktailBitters model)
		{
			return new CocktailBittersEntity
			{
				BittersId = model.BittersId,
				CocktailId = model.CocktailId
			};
		}

		public static CocktailBitters Map(CocktailBittersEntity entity)
		{
			return new CocktailBitters
			{
				BittersId = entity.BittersId,
				CocktailId = entity.CocktailId
			};
		}
	}
}
