using CocktailApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CocktailApp.Repository.Entities
{
	[Table("FortifiedWines")]
	public class FortifiedWineEntity
	{
		[Key]
		public int FortifiedWineId { get; set; }
		[Required]
		public string Name { get; set; }
		[Column(TypeName = "decimal(4,1)")]
		public decimal Abv { get; set; }
		public string Type { get; set; }

		public static FortifiedWineEntity Map(FortifiedWine model)
		{
			return new FortifiedWineEntity
			{
				FortifiedWineId = model.FortifiedWineId,
				Name = model.Name,
				Abv = model.Abv,
				Type = model.Type
			};
		}

		public static FortifiedWine Map(FortifiedWineEntity entity)
		{
			return new FortifiedWine
			{
				FortifiedWineId = entity.FortifiedWineId,
				Name = entity.Name,
				Abv = entity.Abv,
				Type = entity.Type
			};
		}
	}
}
