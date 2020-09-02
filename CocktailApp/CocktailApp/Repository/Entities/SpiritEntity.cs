using CocktailApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CocktailApp.Repository.Entities
{
	[Table("Spirits")]
	public class SpiritEntity
	{
		[Key]
		public int SpiritId { get; set; }
		[Required]
		public string Name { get; set; }
		[Column(TypeName = "decimal(4,1)")]
		public decimal Abv { get; set; }
		public string Category { get; set; }
		public bool IsOverproof { get; set; }

		public static SpiritEntity Map(Spirit model)
		{
			return new SpiritEntity
			{
				SpiritId = model.SpiritId,
				Name = model.Name,
				Abv = model.Abv,
				Category = model.Category,
				IsOverproof = model.IsOverproof
			};
		}

		public static Spirit Map(SpiritEntity entity)
		{
			return new Spirit
			{
				SpiritId = entity.SpiritId,
				Name = entity.Name,
				Abv = entity.Abv,
				Category = entity.Category,
				IsOverproof = entity.IsOverproof
			};
		}
	}
}
