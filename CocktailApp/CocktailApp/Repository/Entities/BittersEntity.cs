using CocktailApp.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CocktailApp.Repository.Entities
{
	[Table("Bitters")]
	public class BittersEntity
	{
		[Key]
		public int BittersId { get; set; }
		[Required]
		public string Name { get; set; }
		[Column(TypeName = "decimal(4,1)")]
		public decimal Abv { get; set; }
		public string Type { get; set; }

		public virtual ICollection<CocktailBittersEntity> CocktailBitters { get; set; }

		public static BittersEntity Map(Bitters model)
		{
			return new BittersEntity
			{
				BittersId = model.BittersId,
				Name = model.Name,
				Abv = model.Abv,
				Type = model.Type,
				CocktailBitters = model.Cocktails?.Select(Id => new CocktailBittersEntity { CocktailId = Id, BittersId = model.BittersId })?.ToList()
			};
		}

		public static Bitters Map(BittersEntity entity)
		{
			return new Bitters
			{
				BittersId = entity.BittersId,
				Name = entity.Name,
				Abv = entity.Abv,
				Type = entity.Type,
				Cocktails = entity.CocktailBitters?.Select(cb => cb.CocktailId)?.ToList() ?? new List<int>()
			};
		}
	}
}
