using CocktailApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CocktailApp.Repository.Entities
{
	[Table("Cocktails")]
	public class CocktailEntity
	{
		[Key]
		public int CocktailId { get; set; }
		public string Name { get; set; }
		public string Recipe { get; set; }
		public DateTime Origin { get; set; }

		public int FortifiedWineId { get; set; }
		public virtual FortifiedWineEntity FortifiedWine { get; set; }

		public int SpiritId { get; set; }
		public virtual SpiritEntity Spirit { get; set; }

		public virtual ICollection<CocktailBittersEntity> CocktailBitters { get; set; }

		public static CocktailEntity Map(Cocktail model)
		{
			return new CocktailEntity
			{
				CocktailId = model.CocktailId,
				Name = model.Name,
				FortifiedWineId = model.FortifiedWineId,
				SpiritId = model.SpiritId,
				Recipe = model.Recipe,
				Origin = model.Origin,
				CocktailBitters = model.CocktailBitters?.Select(cb => CocktailBittersEntity.Map(cb))?.ToList()

			};
		}

		public static Cocktail Map(CocktailEntity entity)
		{
			return new Cocktail
			{
				CocktailId = entity.CocktailId,
				Name = entity.Name,
				FortifiedWineId = entity.FortifiedWineId,
				SpiritId = entity.SpiritId,
				Recipe = entity.Recipe,
				Origin = entity.Origin,
				CocktailBitters = entity.CocktailBitters?.Select(cb => CocktailBittersEntity.Map(cb))?.ToList()
			};
		}
	}
}
